using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Management;
using System.Collections.ObjectModel;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Globalization;
using ZedGraph;


// Version 4.0 CAN Support implemented, but not tested on Production EOL Tester, includes Camera based LED detection implementation (not used, not finalized)
// Version 4.2 Series 6 including LED update for changes due to brighter LEDs. requires PLC Program version Prüftsich SD 2_3 (09.07.2015)
// Version 4.3 Series 6 including LED und Coil Test, tested with both, requires Firmware v0.52, requires PLC-Program 'Prüftisch SD 2_4 mit Coilswap Veränderung (21.08.2015)'
// Version 4.4 Series 6 CAN supported, installed and tested version, requires Firmware v0.57, plc program as above

// Version 4.5 First update for Series 7 inclusion, requires PLC-Program Update for 'Multi-Use Testing Cables'
// Version 4.6 Includes temperature measurement for the correction of resistance measurements of PVEO Variants. Using CALEXPMU21 USB IR Temperature Sensor 'PyroMiniUSB'(RS-Electronics 9058774)
// Version 4.7 Addition of more PVEO-HP Modules with AMP and Hirschmann Plug
// Version 4.8 checking for maxvalue/minvalue in picoscope readout - added for Test of flashing LED in S7 when centered.


namespace SauerDanfoss
{
    public partial class Form1
    {
        //Global variables
        string softwareversion = "4.8";                         //Variable to indicate Softwarerevision
        short _handle;                                          //handle to scope unit
        uint timeIndisposed;                                    //time indisposed during acquisition
        string serialport_tester = "COM1";                      //Set serialportname for tester connection
        string serialport_milliohmmeter = "COM2";               //Set serialportname for milliohmmeter connection
        string serialport_temperaturesensor = "COM39";           //Set serialportname for temperaturesensor connection
        string datapath = "c:/series6/";                        //Path to where config file is loaded
        bool[] error = new bool[17];                            //Array of errorcodes
        string received_data;                                   //received data from tester
        string snno;
        bool testok;                                            //flag for all tests passed
        bool finsh;
        FileStream fs;
        StreamWriter sw2;
        string pathcommon;
        string articlenumber;                                   //article number
        int articlecode;                                        //article code
        string received_commandstring;                          //Commandstring part received on RS232          
        string received_valuestring;                            //Valuestring part received on RS232    
        double received_value;                                  //Value received on RS232  
        string received_state;                                  
        bool echo_received;                                     //Flag to indicate when acho was sent from tester
        bool picoscope_ok = true;                               //Flag to indicate if the Picoscope was found
        bool _ready = false;                                    //flag for signal data acquisition is finished
        bool boot_up = true;                                    //Flag set during system boot up
        bool system_ok = true;                                  //Flag to indicate if Testsystem is ready for testing
        int last_axis_position = 7, pause = 0, ci_i = 0;                             //Buffer for last axis position
        int controller_answer_wait = 200;                       //Wait for CAN answer to be received
        int resistance_meter_wait = 1000;                       //Wait for resistance meter
        int axis_position_wait = 300;                           //Wait time after axis is in position
        int axis_position_wait_led = 1000;                      //Additional wait time after axis is in position for led to turn red
        int axis_position_wait_servo = 1000;                    //Wait time to get axis into position
        bool linearitytest = false;                             //Flag for scope routine if an linearity test is running and axis needs to start
        double measurementtime = 0;                             //Timer for complete measurement procedure
        uint number_acq_lvdt = 100;                             //Number values to acquire for LVDT test
        uint timebase_lvdt = 200000;                            //Timebase for LVDT test acquisition
        uint number_acq_DC = 10000;                             //Number values to acquire for DC measurement
        uint timebase_DC = 200;                                 //Timebase for DC measurement
        uint number_acq_SR = 10000;                             //Number values to acquire for Step response measurement
        uint timebase_SR = 200;                                 //Timebase for Step Response measurement
        int debug_view_time = 2000;                             //Time in ms to view the debug graphs for DC measurement
        double power_minimum = 1.5;                             //minimum voltage threshold for LED detection
        double power_minimum_S7 = 0.15;                          //minimum voltage threshold for LED detection
        short trigger_level_mv = 5000;
        short trigger_delay_ms = 300;
        short trigger_repeats = 1;
        short trigger_swap = 0;

        [DllImport("kernel32.dll")]
        public static extern uint GetTickCount();
        public static void Delay(uint ms)
        {
            uint start = GetTickCount();
            while (GetTickCount() - start < ms)
            {
                Application.DoEvents();
            }
        }

        //Intiatialize Variable structures for LVDT Test
        LVDTtest LVDTtest1 = new LVDTtest();

        //Create test list dictionary object that enables acessing objects of type "Test" by their names
        System.Collections.Generic.Dictionary<string, Test> testList = new Dictionary<string, Test>();

        //Create a stopwatch object for timing purposes
        Stopwatch sw = new Stopwatch();

        //Set decimal separator from installed culture dependent windows declaration
        System.Globalization.NumberFormatInfo ni = null;
        System.Globalization.CultureInfo ci = System.Globalization.CultureInfo.InstalledUICulture;

        //create new plot vectors 
        ZedGraph.PointPairList linearityplot = new ZedGraph.PointPairList();
        ZedGraph.PointPairList ulimitlist = new ZedGraph.PointPairList();
        ZedGraph.PointPairList llimitlist = new ZedGraph.PointPairList();
        ZedGraph.PointPairList c1list = new ZedGraph.PointPairList();
        ZedGraph.PointPairList c2list = new ZedGraph.PointPairList();
        ZedGraph.PointPairList c3list = new ZedGraph.PointPairList();
        ZedGraph.PointPairList c4list = new ZedGraph.PointPairList();

        //Define structured variable for coil voltage measurement returns
        struct voltagearray
        {
            public double CH1;
            public double CH2;
            public double CH3;
            public double CH4;
        };
        voltagearray scopevalues, scopemaxvalues, scopeminvalues;

        //Define class for Test structure consisting of upper limit, lower limit, measured value, flag for test to be performed, and test result flag
        class Subtest
        {
            public double llimit;                               //Lower limit
            public double ulimit;                               //Upper limit
            public double value;                                //Measurement value
            public bool perform_test;                           //Flag if test is performed
            public bool test_result;                            //Flag if test is passed or failed

            public Subtest()
            {
            }
        }

        //Define a class for the parameters of the LVDT test
        class LVDTtest
        {
            public double delta_llimit;                         //Distance of lower limit from expected value
            public double delta_ulimit;                         //Distance of upper limit from expected value
            public double gradient;                             //Gradient of expected value trace
            public double offset;                               //Offset of expected value trace
            public bool perform_test;                           //Flag if test is performed
            public bool test_result;                            //Flag if test is passed or failed

            public LVDTtest()
            {
            }
        }

        //Define a class for the LED test
        class Ledtest
        {
            public string target;                           //String containing target color
            public double value;                            //String containing detected color
            public bool perform_test;                       //Flag if test is required  
            public bool test_result;                        //Flag if test is passed or failed

            public Ledtest()
            {
            }
        }
        
        //Create a class from the subclasses with a structure including a possibly interresting values as given in SD spec sheet
        class Test
        {
            public Subtest SV1 = new Subtest();                     //Create Subtest structure for Solenoid valve 1 (Channel 1) for two coil versions and four coil versions (inner coils)
            public Subtest SV3 = new Subtest();                     //Create Subtest structure for Solenoid valve 3 (Channel 2)

            public Subtest SV2 = new Subtest();                     //Create Subtest structure for Solenoid valve 2 (Channel 3) for four coil versions (outer coils)
            public Subtest SV4 = new Subtest();                     //Create Subtest structure for Solenoid valve 4 (Channel 4)

            public Subtest Spool = new Subtest();                   //Create Subtest structure for Spool output value
            public Subtest DirA = new Subtest();                    //Create Subtest structure for DirA output value
            public Subtest DirB = new Subtest();                    //Create Subtest structure for DirB output value
            public Subtest DrvEnable = new Subtest();               //Create Subtest structure for Driver enable output value

            public Ledtest LedR = new Ledtest();                    //Create Subtest structure for Red LED color check
            public Ledtest LedG = new Ledtest();                    //Create Subtest structure for Green LED color check

            public Test()
            {
            }
        }

        //Define structured array for measurement result curves     
        PinnedArray<short>[] minPinned = new PinnedArray<short>[4];
        PinnedArray<short>[] maxPinned = new PinnedArray<short>[4];

        //Define requirement for data acquisiton callback
        private Scope.ps4000BlockReady _callbackDelegate;
    }
}
