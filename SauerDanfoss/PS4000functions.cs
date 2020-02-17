/**************************************************************************
*
* Filename:    PS4000ConsoleExample.cs
*
* Copyright:   Pico Technology Limited 2009
*
* Author:      MJL
*
* Description:
*   This is a console-mode program that demonstrates how to use the
*   PS4000 driver using .NET
*
* Examples:
*    Collect a block of samples immediately
*    Collect a block of samples when a trigger event occurs
*    Collect a stream of data immediately
*    Collect a stream of data when a trigger event occurs
*
* History:
*     14Dec06	MJL	Created for PS5000
*			15Oct09	RPM Modified for PS4000
*
* Revision Info: "file %n date %f revision %v"
*						""
*
***************************************************************************/

using System;
using System.IO;
using System.Threading;
using System.Runtime.InteropServices;

namespace SauerDanfoss
{

    class Pwq
    {
        public Scope.PwqConditions[] conditions;
        public short nConditions;
        public Scope.ThresholdDirection direction;
        public uint lower;
        public uint upper;
        public Scope.PulseWidthType type;

        public Pwq(Scope.PwqConditions[] conditions,
            short nConditions,
            Scope.ThresholdDirection direction,
            uint lower, uint upper,
            Scope.PulseWidthType type)
        {
            this.conditions = conditions;
            this.nConditions = nConditions;
            this.direction = direction;
            this.lower = lower;
            this.upper = upper;
            this.type = type;
        }
    }

    public partial class Form1
    {
      


        /****************************************************************************
         * Callback
         * used by PS4000 data block collection calls, on receipt of data.
         * used to set global flags etc checked by user routines
         ****************************************************************************/
        void BlockCallback(short handle, short status, IntPtr pVoid)
        {
            // flag to say done reading data
            _ready = true;
        }

            
        
        /****************************************************************************
        *  SetTrigger
        *  this function sets all the required trigger parameters, and calls the 
        *  triggering functions
        ****************************************************************************/
        short SetTrigger(   Scope.TriggerChannelProperties[] channelProperties, 
                            short nChannelProperties, 
                            Scope.TriggerConditions[] triggerConditions,
                            short nTriggerConditions, 
                            Scope.ThresholdDirection[] directions, 
                            Pwq pwq, 
                            uint delay, 
                            short auxOutputEnabled, 
                            int autoTriggerMs)
        {
            short status;

            if (
              (status =
               Scope.SetTriggerChannelProperties(_handle, channelProperties, nChannelProperties, auxOutputEnabled,
                                                   autoTriggerMs)) != 0)
            {
                return status;
            }

            if ((status = Scope.SetTriggerChannelConditions(_handle, triggerConditions, nTriggerConditions)) != 0)
            {
                return status;
            }

            if (directions == null) directions = new Scope.ThresholdDirection[] { Scope.ThresholdDirection.None, 
        Scope.ThresholdDirection.None, Scope.ThresholdDirection.None, Scope.ThresholdDirection.None, 
        Scope.ThresholdDirection.None, Scope.ThresholdDirection.None};

            if ((status = Scope.SetTriggerChannelDirections(_handle,
                                                              directions[(int)Scope.Channel.ChannelA],
                                                              directions[(int)Scope.Channel.ChannelB],
                                                              directions[(int)Scope.Channel.ChannelC],
                                                              directions[(int)Scope.Channel.ChannelD],
                                                              directions[(int)Scope.Channel.External],
                                                              directions[(int)Scope.Channel.Aux])) != 0)
            {
                return status;
            }

            if ((status = Scope.SetTriggerDelay(_handle, delay)) != 0)
            {
                return status;
            }

            if (pwq == null) pwq = new Pwq(null, 0, Scope.ThresholdDirection.None, 0, 0, Scope.PulseWidthType.None);

            status = Scope.SetPulseWidthQualifier(_handle, pwq.conditions,
                                                    pwq.nConditions, pwq.direction,
                                                    pwq.lower, pwq.upper, pwq.type);

            return status;
        }

 


        //********************************************************************************
        //Function to acquire data to array                                              *
        //********************************************************************************

        int BlockDataAcquisition(uint sampleCount, uint timebase, short oversampling, int pretrigger)
        {
            //Time in ms the measurement will consume
            int timeIndisposed;
            int pretrig;
            int posttrig;

            //Create structured Array for measurement results of all 4channels
            //MaxPinned will contain the measurement values or the maximum values in aggregated mode
            //MinPinned will contain minimum values´in aggregated mode otherwise 0
            
            for (int i = 0; i < 4; i++)
            {
                short[] minBuffers = new short[sampleCount];
                short[] maxBuffers = new short[sampleCount];
                minPinned[i] = new PinnedArray<short>(minBuffers);
                maxPinned[i] = new PinnedArray<short>(maxBuffers);
                int status = Scope.SetDataBuffers(_handle, (Scope.Channel)i, maxBuffers, minBuffers, (int)sampleCount);
            }
            
            //Start collecting Data and create ready=true callback to acknowledge when acquisition is finished
            _ready = false;
            _callbackDelegate = BlockCallback;
            pretrig = (int)(sampleCount * pretrigger / 100);
            posttrig = (int)(sampleCount * (100-pretrigger) / 100);

            //Start acquisition
            Scope.RunBlock(_handle, pretrig, posttrig, timebase, oversampling, out timeIndisposed, 0, _callbackDelegate, IntPtr.Zero);
            
            //If a linearitytest is performed wait buffer to fill and start axis
            if (linearitytest == true)
            {
                //Wait for pretrigger buffer to fill with data
                Thread.Sleep(800);

                //Start axis movement
                serialPortTester.WriteLine("$AL3");
            }

            //Wait for measurement finished
            while (!_ready)
            {
                Thread.Sleep(10);
            }

            //Stop scope after data has been acquired
            Scope.Stop(_handle);

            //If acquisiton was successfully finished get values  
            if (_ready)
            {
                short overflow;
                Scope.GetValues(_handle, 0, ref sampleCount, 1, Scope.DownSamplingMode.None, 0, out overflow);
            }
            else
            {
            }

            return (timeIndisposed);
        }


        int StartDataAcquisition(uint sampleCount, uint timebase, short oversampling, int pretrigger)
        {
            //Time in ms the measurement will consume
            int timeIndisposed;
            int pretrig;
            int posttrig;

            //Create structured Array for measurement results of all 4channels
            //MaxPinned will contain the measurement values or the maximum values in aggregated mode
            //MinPinned will contain minimum values´in aggregated mode otherwise 0

            for (int i = 0; i < 4; i++)
            {
                short[] minBuffers = new short[sampleCount];
                short[] maxBuffers = new short[sampleCount];
                minPinned[i] = new PinnedArray<short>(minBuffers);
                maxPinned[i] = new PinnedArray<short>(maxBuffers);
                int status = Scope.SetDataBuffers(_handle, (Scope.Channel)i, maxBuffers, minBuffers, (int)sampleCount);
            }

            //Start collecting Data and create ready=true callback to acknowledge when acquisition is finished
            _ready = false;
            _callbackDelegate = BlockCallback;
            pretrig = (int)(sampleCount * pretrigger / 100);
            posttrig = (int)(sampleCount * (100 - pretrigger) / 100);

            //Start acquisition
            Scope.RunBlock(_handle, pretrig, posttrig, timebase, oversampling, out timeIndisposed, 0, _callbackDelegate, IntPtr.Zero);

            return (timeIndisposed);
        }

        int FinishDataAcquisition(uint sampleCount, uint timebase, short oversampling, int pretrigger)
        {

            //Wait for measurement finished
            while (!_ready)
            {
                Thread.Sleep(10);
            }

            //Scope.ReportedTimeUnits reported_time_units_A, reported_time_units_B;
            //long time_A, time_B;
            //int time_ah, time_bh, time_al, time_bl;

    
            //Stop scope after data has been acquired
            Scope.Stop(_handle);

            //If acquisiton was successfully finished get values  
            if (_ready)
            {
                short overflow;
                Scope.GetValues(_handle, 0, ref sampleCount, 1, Scope.DownSamplingMode.None, 0, out overflow);
            }
            else
            {
            }

            return 0;
        }

        int EvaluateDataAcquisition(uint sampleCount, uint numAvg, out double avgA, out double avgB, out double avgC, out double avgD)
        {
            long sum_a=0, sum_b=0, sum_c=0, sum_d=0;

            for (uint i = sampleCount/2; i != sampleCount/2+numAvg; i++)
            {
                sum_a += maxPinned[0].Target[i];
                sum_b += maxPinned[1].Target[i];
                sum_c += maxPinned[2].Target[i];
                sum_d += maxPinned[3].Target[i];
            }

            avgA =sum_a/numAvg;
            avgB =sum_b/numAvg;
            avgC =sum_c/numAvg;
            avgD =sum_d/numAvg;
          
            return 0;
        }


    }
}  
