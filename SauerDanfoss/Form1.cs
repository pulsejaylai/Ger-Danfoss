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
using WinFormWebCam;
using System.Text.RegularExpressions;
//using AutoSize;

namespace SauerDanfoss
{

    /*    enum VALVEBLOCK
        {
            _00000000___INVALID = 0,
            D_11100794_S6_PVEO_12V_deutsch4p = 1,
            D_11148431_P_124_0078_0_S6_PVEO_12VCoils_deutsch4p = 1,     
      
            D_11100795_S6_PVEO_24V_deutsch4p = 2,
            D_11148443_P_124_0079_0_S6_PVEO_24VCoils_deutsch4p = 2,
      
            D_11164361_P_124_0064_0_S7_PVEO_12V9V_deutsch4p = 3,
            D_11164363_P_124_0065_0_S7_PVEO_12V9V_AMP4p = 4,
            D_11164359_P_124_0066_0_S7_PVEO_12V9V_Hirschmann4p3c = 5,
     
            D_11100792__S6_PVEA_alt_9VCoils_Deutsch4p = 6,
            D_11100793__S6_PVEA_F_alt_9VCoils_Deutsch6p5c = 7,
            D_11146202_P_124_0051_0_S6_PVEA_9VCoils_Deutsch4p = 8,
            D_11130188_P_124_0052_0_S6_PVEA_F_9VCoils_Deutsch6p5c = 9,
            
            D_11121926_P_124_0054_0_S6_PVEA_CI_9VCoils_CAN_2xDeutsch4p = 10,
            D_11133166_P_124_0055_0_S6_PVEO_CI_9VCoils_CAN_2xDeutsch4p = 11,
     
            D_11143349_P_124_0057_0_S7_PVEH_4x9VCoils_AMP4p = 12,   // vorher S6_32'er Serie
            D_11163319_P_124_0058_0_S7_PVEH_F_4x9VCoils_Deutsch6p6c = 13,   // vorher S6_32'er Serie
            D_11161438_P_124_0059_0_S7_PVEH_S_4x9VCoils_Hischmann4p4c = 14,   // vorher S6_32'er Serie
            D_11143352_P_124_0061_0_S7_PVEH_S_4x9VCoils_Deutsch4p = 15,   // vorher S6_32'er Serie
            D_11143353_P_124_0062_0_S7_PVEH_S_4x9VCoils_Metripack = 16,   // vorher S6_32'er Serie
            D_11143354_P_124_0060_0_S7_PVEH_S_DI_4x9VCoils_AMP2x4p = 17,
            D_11143355_P_124_0063_0_S7_PVEH_DI_4x9VCoils_Deutsch2x4p = 18,
      
            D_11163322_P_124_0071_0_S7_PVEA_9VCoils_Deutsch4p = 20,     Plug Type 15
            D_11168453_P_124_0080_0_S7_PVEH_F_4x9VCoils_AMP6p6c=21,     
            D_11163318_P_124_0081_0_S7_PVEH_NP_4x9VCoils_Deutsch6p5c=22,Plug Type 13
            D_11163317_P_124_0082_0_S7_PVEH_SP_4x9VCoils_Deutsch6p5c=23,Plug Type 13
      
            D_11163313_P_124_0083_0_S7_PVEA_NP_9VCoils_Deutsch6p5c=24,  Plug Type 13
            D_11163124_P_124_0067_0_S7_PVEA_9VCoils_AMP4p=25,           Plug Type 12
            D_11161383_P_124_0069_0_S7_PVEM_9VCoils_Hirschmann4p3c?=26, Plug Type 14
            D_11163325_P_124_0070_0_S7_PVEA_DI_9VCoils_2xAMP4p=27,      Plug Type 17
            D_11163123_P_124_0073_0_S7_PVEA_DI_9VCoils_2xDeutsch4p=28,  Plug Type 18 
     
            D_11163125_P_124_0084_0_S7_PVEO_DI_12V9VCoils_2xAMP4p=29,   Plug Type 19 Separater test auf coil swap (Test 1,2), der LVDT und der DIRA und DIRB(Test 3,4) sowie der Widerstände (Test 7)
            D_11163326_P_124_0077_0_S7_PVEO_DI_24VCoils_2xAMP4p=30,     Plug Type 19 Separater test auf coil swap (Test 1,2), der LVDT und der DIRA und DIRB(Test 3,4) sowie der Widerstände (test 7)
     
            D_11164362_P_124_0074_0_S7_PVEO_24VCoils_Deutsch4p=31,      Plug Type 3
            D_11164364_P_124_0075_0_S7_PVEO_24VCoils_AMP4p=32,          Plug Type 4
            D_11164360_P_124_0076_0_S7_PVEO_24VCoils_Hirschmann4p3c=33, Plug Type 5
     
            D_11167794_P_124_0085_0_S7_PVEH_S_U_9VCoils_Hirschmann4p4c=34,PlugType14
            D_11167795_P_124_0086_0_S7_PVEH_S_U_9VCoils_Deutsch4p=35,   Plug Type 15
            D_11167796_P_124_0087_0_S7_PVEH_S_U_9VCoils_AMP4p=36,       Plug Type 12
     
            D_11175113_P_124_0088_0_S7_PVEO_HP_12V_Deutsch4p=37,        Plug Type 3 (wird dann mit 24V betrieben + Widerstandsmessung!)
            D_11175112_P_124_0089_0_S7_PVEO_HP_12V_AMP4p=38,            Plug Type 4 (wird dann mit 24V betrieben + Widerstandsmessung!)
            D_11175114_P_124_0098_0_S7_PVEO_HP_24V_Deutsch4p=39,        Plug Type 3 (+ Widerstandsmessung!)     

            D_11184237_P_124_0090-0_S7_PVEO_HP_12V_Hirschmann=40,       Plug Type 5 (wird dann mit 24V betrieben + Widerstandsmessung!) 
            D_11184236_P_124_0099_0_S7_PVEO_HP_24V_AMP4p=41,            Plug Type 4 (+ Widerstandsmessung!)     
            D_11184238_P_124_0100_0_S7_PVEO_HP_24V_Hirschmann=42,       Plug Type 5 (+ Widerstandsmessung!)     
      
        }
        */
    /*
    enum AXISPOSITION
    {
        AXISPOSITION_SERIES_6_CENTER = 1,
        AXISPOSITION_SERIES_6_POTTING_SIDE = 2,
        AXISPOSITION_SERIES_6_LED_SIDE = 3,
        AXISPOSITION_SERIES_7_CENTER = 4,
        AXISPOSITION_SERIES_7_POTTING_SIDE = 5,
        AXISPOSITION_SERIES_7_LED_SIDE = 6,
        AXISPOSITION_SERIES_RETRACT = 7,
    }
    */
 
    
    
   //AutoSizeFormClass asc=new AutoSizeFormClass();  
    
    public partial class Form1 : Form
    {
        //Object to create GUI
       /* class AutoSizeFormClass
        {
            public struct controlRect
            {
                public int Left;
                public int Top;
                public int Width;
                public int Height;
            }

            //(2).声明 1个对象
            //注意这里不能使用控件列表记录 List nCtrl;，因为控件的关联性，记录的始终是当前的大小。
            //      public List oldCtrl= new List();//这里将西文的大于小于号都过滤掉了，只能改为中文的，使用中要改回西文
            public List<controlRect> oldCtrl = new List<controlRect>();
            int ctrlNo = 0;//1;

            //(3). 创建两个函数
            //(3.1)记录窗体和其控件的初始位置和大小,
            public void controllInitializeSize(Control mForm)
            {
                controlRect cR;
                cR.Left = mForm.Left; cR.Top = mForm.Top; cR.Width = mForm.Width; cR.Height = mForm.Height;
                oldCtrl.Add(cR);//第一个为"窗体本身",只加入一次即可
                AddControl(mForm);//窗体内其余控件还可能嵌套控件(比如panel),要单独抽出,因为要递归调用
                //this.WindowState = (System.Windows.Forms.FormWindowState)(2);//记录完控件的初始位置和大小后，再最大化
                //0 - Normalize , 1 - Minimize,2- Maximize
            }
            private void AddControl(Control ctl)
            {
                foreach (Control c in ctl.Controls)
                {  //**放在这里，是先记录控件的子控件，后记录控件本身
                    //if (c.Controls.Count > 0)
                    //    AddControl(c);//窗体内其余控件还可能嵌套控件(比如panel),要单独抽出,因为要递归调用
                    controlRect objCtrl;
                    objCtrl.Left = c.Left; objCtrl.Top = c.Top; objCtrl.Width = c.Width; objCtrl.Height = c.Height;
                    oldCtrl.Add(objCtrl);
                    //**放在这里，是先记录控件本身，后记录控件的子控件
                    if (c.Controls.Count > 0)
                        AddControl(c);//窗体内其余控件还可能嵌套控件(比如panel),要单独抽出,因为要递归调用
                }
            }

            //(3.2)控件自适应大小,
            public void controlAutoSize(Control mForm)
            {
                if (ctrlNo == 0)
                { //*如果在窗体的Form1_Load中，记录控件原始的大小和位置，正常没有问题，但要加入皮肤就会出现问题，因为有些控件如dataGridView的的子控件还没有完成，个数少
                    //*要在窗体的Form1_SizeChanged中，第一次改变大小时，记录控件原始的大小和位置,这里所有控件的子控件都已经形成
                    controlRect cR;
                    //  cR.Left = mForm.Left; cR.Top = mForm.Top; cR.Width = mForm.Width; cR.Height = mForm.Height;
                    cR.Left = 0; cR.Top = 0; cR.Width = mForm.PreferredSize.Width; cR.Height = mForm.PreferredSize.Height;

                    oldCtrl.Add(cR);//第一个为"窗体本身",只加入一次即可
                    AddControl(mForm);//窗体内其余控件可能嵌套其它控件(比如panel),故单独抽出以便递归调用
                }
                float wScale = (float)mForm.Width / (float)oldCtrl[0].Width;//新旧窗体之间的比例，与最早的旧窗体
                float hScale = (float)mForm.Height / (float)oldCtrl[0].Height;//.Height;
                ctrlNo = 1;//进入=1，第0个为窗体本身,窗体内的控件,从序号1开始
                AutoScaleControl(mForm, wScale, hScale);//窗体内其余控件还可能嵌套控件(比如panel),要单独抽出,因为要递归调用
            }
            private void AutoScaleControl(Control ctl, float wScale, float hScale)
            {
                int ctrLeft0, ctrTop0, ctrWidth0, ctrHeight0;
                //int ctrlNo = 1;//第1个是窗体自身的 Left,Top,Width,Height，所以窗体控件从ctrlNo=1开始
                foreach (Control c in ctl.Controls)
                { //**放在这里，是先缩放控件的子控件，后缩放控件本身
                    //if (c.Controls.Count > 0)
                    //   AutoScaleControl(c, wScale, hScale);//窗体内其余控件还可能嵌套控件(比如panel),要单独抽出,因为要递归调用
                    ctrLeft0 = oldCtrl[ctrlNo].Left;
                    ctrTop0 = oldCtrl[ctrlNo].Top;
                    ctrWidth0 = oldCtrl[ctrlNo].Width;
                    ctrHeight0 = oldCtrl[ctrlNo].Height;
                    //c.Left = (int)((ctrLeft0 - wLeft0) * wScale) + wLeft1;//新旧控件之间的线性比例
                    //c.Top = (int)((ctrTop0 - wTop0) * h) + wTop1;
                    c.Left = (int)((ctrLeft0) * wScale);//新旧控件之间的线性比例。控件位置只相对于窗体，所以不能加 + wLeft1
                    c.Top = (int)((ctrTop0) * hScale);//
                    c.Width = (int)(ctrWidth0 * wScale);//只与最初的大小相关，所以不能与现在的宽度相乘 (int)(c.Width * w);
                    c.Height = (int)(ctrHeight0 * hScale);//
                    ctrlNo++;//累加序号
                    //**放在这里，是先缩放控件本身，后缩放控件的子控件
                    if (c.Controls.Count > 0)
                        AutoScaleControl(c, wScale, hScale);//窗体内其余控件还可能嵌套控件(比如panel),要单独抽出,因为要递归调用
                }
            }

        }
        
        */
        
        
        
        
        
        
        
        
        public Form1()
        {
            //Create copy of System number format with '.' as seperator 
          
            ni = (System.Globalization.NumberFormatInfo)
            ci.NumberFormat.Clone();
            ni.NumberDecimalSeparator = ".";

            //Initalise GUI
            InitializeComponent();

            //Create Test class Dictionary to link test names and GUI objects
            for (int i = 0; i < 10; i++)
            {
                testList.Add("Test " + i.ToString(), new Test());
            }

            //Call create textfieldlist procedure
            createTextFieldList();

            // add Keypress Events
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);

            // create worker thread
            //Thread workthread = new Thread(webcam.Start());
        }

        /*   Read the following Block Data for each Module!! */
        string mCanAddress = "0CFE3006";    // adress string that will be read from CAN and/or be used for adressing of Module
        //string mCanAddress = "0CFE1080";    // adress string that will be read from CAN and/or be used for adressing of Module
        string model="";//DECIDE PVEX
        string TYPE = "",snsample="", rev, pcbrev, pdays,smodel;
        string led_type = "",led_model="";
        bool mServoExists = false;
        bool mManualDebugOperation = false; // marks if operation was started manually via shortcut key - auf Tester ohne Hardware nützlich
        bool mCameraLedTest = false;        // marks wether LED colour will be determined via Web Camera - Development not completed! (June 2015)
        int mHueGreenLowBorder = 1,samplelength,snlength;
        int mHueGreenHighBorder = 1;
        int mHueRedLowBorder = 1;
        int mHueRedHighBorder = 1;
        int mHueOrangeLowBorder = 1;
        int mHueOrangeHighBorder = 1;
        int mLedCropX = 100;                // area in Webcam Picture to read LED Colour
        int mLedCropY = 50;                 // area in Webcam Picture to read LED Colour
        int mLedCropSize = 10;              // area in Webcam Picture to read LED Colour
        bool S7_4_Coil = false;             // switch to disable(false) or enable(true) 4-Coil result-checking.
        bool S7_2_Coil = true;             // switch to distinguish between Sensor Boxes for LED Detection.
        int half_flash_period = 350;        // [ms] for 700 [ms] blinking period with 50% duty cycle.
        double cc_value=0,ci_value=0;
        double RedOffValue = 10.3;
        double GreenOffValue = 7.5;

        //Create a dictionary of the textboxcontrols of the GUI to make accessible by name
        Dictionary<string, RichTextBox> textboxList = new Dictionary<string, RichTextBox>();

        // LED color detection by camera (inactive)
        WebCam webcam;
        int area;
        int xCrop;
        int yCrop;
        float hue, brightness, saturation;
        Rectangle LedCropRect; // position, width,height in picture
        private void Start_Click(object sender, EventArgs e)
        {
           
            
            if (webcam != null) webcam.Start();
            else error_output("WebCam has not been started - Camera LED Testing is set to " + mCameraLedTest);
        }
        private void Up_Click(object sender, EventArgs e)
        {
            if (webcam != null) if (LedCropRect.Y > 0)
                    LedCropRect.Y -= 1;
            Capture_Click(sender, e);
        }
        private void Down_Click(object sender, EventArgs e)
        {
            if (webcam != null) if (LedCropRect.Y < LedVideo.Image.Height - area)
                    LedCropRect.Y += 1;
            Capture_Click(sender, e);
        }
        private void Right_Click(object sender, EventArgs e)
        {
            if (webcam != null) if (LedCropRect.X < LedVideo.Image.Width - area)
                    LedCropRect.X += 1;
            Capture_Click(sender, e);
        }
        private void Left_Click(object sender, EventArgs e)
        {
            if (webcam != null) if (LedCropRect.X > 0)
                    LedCropRect.X -= 1;
            Capture_Click(sender, e);
        }
        private void Plus_Click(object sender, EventArgs e)
        {
            if (area < 100)
            {
                area++;
                LedCropRect.Width = area;
                LedCropRect.Height = area;
            }
            Capture_Click(sender, e);
        }
        private void Minus_Click(object sender, EventArgs e)
        {
            if (area > 1)
            {
                area--;
                LedCropRect.Width = area;
                LedCropRect.Height = area;
            }
            Capture_Click(sender, e);
        }
        private void Capture_Click(object sender, EventArgs e)
        {
            if (webcam != null) capture();
        }
        private void capture()
        {

            //Create an delegate running in the UI thread to enable access on GUI at any time
            this.Invoke((MethodInvoker)delegate
            {
                Bitmap src = LedVideo.Image as Bitmap;

                hue = 0;
                brightness = 0;
                saturation = 0;

                if (src != null)
                {
                    Bitmap target = new Bitmap(LedCropRect.Width, LedCropRect.Height);
                  
                    using (Graphics g = Graphics.FromImage(src))
                    {
                        Pen pen = new Pen(Color.Red, 1);
                        g.DrawRectangle(pen, LedCropRect.X - 1, LedCropRect.Y - 1, LedCropRect.Width + 1, LedCropRect.Height + 1);
                    }
                    LedVideo.Image = src;

                    using (Graphics g = Graphics.FromImage(target))
                    {
                        g.DrawImage(src, new Rectangle(0, 0, target.Width, target.Height), LedCropRect, GraphicsUnit.Pixel);
                    }
                    LedPicture.Image = target;
                    int red = 0, green = 0, blue = 0;
                    for (int x = 0; x < area && x < target.Width; x++)
                    {
                        for (int y = 0; y < area && y < target.Width; y++)
                        {
                            Color col = target.GetPixel(x, y);
                            red += col.R;
                            green += col.G;
                            blue += col.B;
                        }
                    }
                    red /= (area * area);
                    green /= (area * area);
                    blue /= (area * area);

                    Color avgcol = Color.FromArgb(red, green, blue);
                    hue = avgcol.GetHue();
                    brightness = avgcol.GetBrightness();
                    saturation = avgcol.GetSaturation();

                    Hue.Text = hue.ToString();
                    Brightness.Text = brightness.ToString();
                    Saturation.Text = saturation.ToString();
                }
            });

        }
        // Program Control
        private void createTextFieldList()
        {
            foreach (Control item in this.Controls)
            {
                if (item.GetType() == typeof(System.Windows.Forms.RichTextBox) && item.Name.StartsWith("test"))
                    textboxList.Add(item.Name, (RichTextBox)item);
            }

        }


        static string getrev(String num, String result)
        {
            char[] numch = num.ToCharArray();
            int x, revposition, revposition2;
            x = 0;
            revposition = 0;
            revposition2 = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (numch[i].ToString() == ":")
                {
                    x++;
                    if (x == 1)
                    {
                        revposition = i;
                        // break;
                    }
                    if (x == 2)
                    {
                        revposition2 = i;
                        // break;
                    }

                }

            }
            result = num.Substring(revposition + 1, revposition2 - revposition - 1);
            // MessageBox.Show(result);
            return result;
        }
        static string getpcbrev(String num, String result)
        {
            char[] numch = num.ToCharArray();
            int x, revposition, revposition2, count;
            x = 0;
            count = 0;
            revposition = 0;
            revposition2 = 0;
            for (int i2 = 0; i2 < num.Length; i2++)
            {
                if (numch[i2].ToString() == ":")
                {
                    count++;
                }
            }
            if (count > 2)
            {
                for (int i = 0; i < num.Length; i++)
                {
                    if (numch[i].ToString() == ":")
                    {
                        x++;

                        if (x == 2)
                        {
                            revposition = i;
                            // break;
                        }
                        if (x == 3)
                        {
                            revposition2 = i;
                            // break;
                        }


                    }
                }
            }

            if (count > 2)
            { result = num.Substring(revposition + 1, revposition2 - revposition - 1); }
            else
            { result = ""; }
            return result;
        }
        void frm_TransfEvent(string value)
        {
            snsample = value;
        }
        void frm_TransintfEvent(int valuet)
        {
            samplelength = valuet;
        }
        // AutoSizeFormClass asc = new AutoSizeFormClass();  
        private void Form1_Load(object sender, EventArgs e)         //Routine that is performed once at program start automatically
        {
            //asc.controllInitializeSize(this);
            //Initialize variables
            articlenumber = "";
            articlecode = 0;
            string filename;
            //send_data("$CO", 0);
          /*  short status1 = 5;
            status1 = Scope.OpenUnit(out _handle);
            MessageBox.Show(status1.ToString());*/
            pathcommon = Application.StartupPath;
            filename = pathcommon + "\\" + "common.txt";
            if (!File.Exists(filename))
            {
                fs = new FileStream(filename, FileMode.Create);
                sw2 = new StreamWriter(fs);
            }
            else
            {
                fs = new FileStream(filename, FileMode.Open);
                sw2 = new StreamWriter(fs);
                /* StreamWriter sw = new StreamWriter(fs);
            sw.Write("test" + "\r\n");
            sw.Flush();
           // 关闭流
            sw.Close();
            fs.Close();*/
            }
          /*  StreamWriter sw = new StreamWriter(fs);
            sw.Write("test" + "\r\n");
            sw.Flush();
            关闭流
            sw.Close();
            fs.Close();-*/
            //  fs = new FileStream(pathcommon + "\\"  + "common.txt", FileMode.Create);
            //Load config file
            read_configfile();
           // textboxList["test1_sv2_result"].Text = "333";
            //Indicate Softwareversion of PC System
           error_output((DateTime.Now + " PC System boot O.K. - Softwarerevision: " + softwareversion).ToString());
           
            if (mCameraLedTest)
            {
                // add webcam access
                webcam = new WebCam();
                webcam.InitializeWebCam(ref LedVideo);
                //webcam.Start();
                area = mLedCropSize;
                xCrop = mLedCropX;
                yCrop = mLedCropY;
                LedCropRect = new Rectangle(xCrop, yCrop, area, area);
                if (webcam != null) error_output("Camera Object created successfully, looking at " + LedCropRect);
            }

            //initalize scope
            short status = 1;
            try
            {
                status = Scope.OpenUnit(out _handle);
             //   MessageBox.Show(_handle.ToString());
                Scope.SetChannel(_handle, Scope.Channel.ChannelA, 1, 1, Scope.Range.Range_20V);
                Scope.SetChannel(_handle, Scope.Channel.ChannelB, 1, 1, Scope.Range.Range_20V);
                Scope.SetChannel(_handle, Scope.Channel.ChannelC, 1, 1, Scope.Range.Range_20V);
                Scope.SetChannel(_handle, Scope.Channel.ChannelD, 1, 1, Scope.Range.Range_20V);
                //Stop scope after dat has acquired
                Scope.Stop(_handle);
            }
            catch
            {
                system_ok = false;
                picoscope_ok = false;
                error_output("PicoScope drivers not found ! Check Picoscope driver installation !");
            };

            //Check if scope was found by driver

            if (status != 0)
            {
                system_ok = false;
                picoscope_ok = false;
                error_output("PicoScope not present ! Check USB connection !");
            }

            //Initialize plotwindow for LVDT plot
            plotwindow.GraphPane.Title.IsVisible = false;
            plotwindow.GraphPane.XAxis.Title.Text = ("position in mm");
            plotwindow.GraphPane.YAxis.Title.Text = ("spoolsignal in V");
            plotwindow.GraphPane.XAxis.Scale.Min = (-5);
            plotwindow.GraphPane.XAxis.Scale.Max = (5);
            plotwindow.GraphPane.YAxis.Scale.Min = (1);
            plotwindow.GraphPane.YAxis.Scale.Max = (5.5);
            plotwindow.AxisChange();
            plotwindow.GraphPane.XAxis.MajorGrid.IsVisible = true;
            plotwindow.GraphPane.YAxis.MajorGrid.IsVisible = true;
            plotwindow.Refresh();
            plotwindow.Visible = false;

            //Initialize LVDT structure
            LVDTtest1.delta_llimit = 0.5;
            LVDTtest1.delta_ulimit = 0.5;
            LVDTtest1.offset = 2.5;
            LVDTtest1.gradient = 0.22;
            LVDTtest1.perform_test = false;
            LVDTtest1.test_result = true;


            //Intialize Comport
            bool failure = initialize_comport();


            //Indicate Softwareversion of Test Box
            try
            {
                serialPortTester.WriteLine("V");
                Thread.Sleep(controller_answer_wait);
                string testrev = serialPortTester.ReadLine();
                error_output(("PVEX Testsystem boot O.K. - Softwarerevision: " + testrev).ToString());
            }
            catch
            {
                error_output("No response to Revisioncall from PVEX Tester! - Check cable connection and power on!");
                system_ok = false;
            }

            //Check if Multimeter is present and read AC Frequency
            try
            {
                serialPortMilliohmmeter.WriteLine(":SYSTEM:LFR?");
                Thread.Sleep(resistance_meter_wait);
                string powerfreq = serialPortMilliohmmeter.ReadLine();
                error_output(("Multimeter O.K. - Powerlinefrequency is: " + powerfreq + " Hz").ToString());
            }
            catch
            {
                error_output("No response from Milliohmmeter! - Check cable connection and power on!");
                system_ok = false;
            }
            //Set com port to normal echo operation mode
            if (system_ok == false)
            { sys_ready.BackColor = Color.Red;
            messagebox1.BackColor = Color.Red;
            }
            else
            { sys_ready.BackColor = Color.Green; }
            boot_up = false;

            //Reset tester box to initial state if communication is possible
            if ((failure == false) && (system_ok == true))
            {
                try
                {
                    send_data("$CO", 0);//选择com
                    send_data("$TR", 0);//Send I.O RESULT
                }
                catch
                {
                }
            }
         /*   Regex regnum = new Regex("^[0~9]");
            SampleIn sminput=new SampleIn();
            sminput.TransfEvent += frm_TransfEvent;
           sminput.TransintfEvent += frm_TransintfEvent;
            DialogResult ddr = sminput.ShowDialog();
           
            int sindex;
            string revx, revr;
            revr = "";
            sindex = snsample.IndexOf(":");
            smodel = snsample.Substring(0, sindex);
          //  MessageBox.Show(smodel);
            revx = getrev(snsample, revr);
            //  MessageBox.Show(rev);  

            if (regnum.IsMatch(revx.Substring(0, 1)))
            {
                // MessageBox.Show("Num");
                rev = revx.Substring(0, 2);
                pdays = revx.Substring(2, 4);
                // MessageBox.Show(rev);
            }
            else
            {
                rev = revx.Substring(0, 1);
                pdays = revx.Substring(1, 4);
                // MessageBox.Show(rev);
            }
            revr = "";
            pcbrev = getpcbrev(snsample, revr);
            // this.label1.Font = new Font("隶书", 18, FontStyle.Bold); //第一个是字体，第二个大小，第三个是样式，
            this.label11.Text = snsample;
            this.label11.ForeColor = Color.Blue;// 颜色 
            */

        }

    
        private void error_output(string error_message)             //Show errormessages on screen and write to logfile
        {
            //Create an delegate running in the UI thread to enable access on GUI at any time
            this.Invoke((MethodInvoker)delegate
            {
                messagebox1.AppendText(error_message + "\n");//Create appendix to create new errorlog for each year
                string calenderyear = Convert.ToString(DateTime.Now.Year);

                //
                StreamWriter localdatafile = new StreamWriter(datapath + calenderyear + "errorlog.txt", true);
                string timestamp = (DateTime.Now.Year + "/" + DateTime.Now.Day + "/" + DateTime.Now.Month + "  " + DateTime.Now.Hour + "-" + DateTime.Now.Minute + "-" + DateTime.Now.Second + "   ");
                localdatafile.WriteLine(timestamp + (error_message + "\n"));
                localdatafile.Close();
            });
        }
        private void initial_state()                                //Routine executed when inital state is requested by PLC
        {
            reset_measurement();
            error_output("Inital state requested by PLC!");
            Thread.Sleep(resistance_meter_wait);
            send_data("$CO", 0);//INIT COMM
            send_data("$TR", 0);//SEND IO RESULT NO
            send_data("$MR", 0);//MARTIX SELECT??
            send_data("$MM", 1);//MUL MODE
        }
        void Form1_KeyDown(object sender, KeyEventArgs e)           // for debugging, check keypresses to simulate user actions on hardware
        {
            
            if (e.Alt)
                if (e.KeyValue >= 32) //this allows to add a second key after pressing Alt :-)
                {
                    switch (e.KeyValue)
                    {
                        case (char)37: //left
                            Left_Click(sender, e);
                            break;
                        case (char)38: //up
                            Up_Click(sender, e);
                            break;
                        case (char)39: //right
                            Right_Click(sender, e);
                            break;
                        case (char)40: //down
                            Down_Click(sender, e);
                            break;
                        case (char)107: // +
                            Plus_Click(sender, e);
                            break;
                        case (char)109: // -
                            Minus_Click(sender, e);
                            break;
                        case (char)77: // Alt-M für Messung
                            {
                                mManualDebugOperation = true;   // Funktionen speziell für Tester ohne SPS Hardware!!
                                received_valuestring = articlecode_field.Text;
                                if (articlecode_field.Text != "")
                                {
                                    received_value = Convert.ToDouble(received_valuestring);
                                    received_commandstring = "$PC";

                                    evaluate_received_data();
                                }
                                else
                                {
                                    String Text;
                                    Text = "Please Enter Article Code first:\n\n";
                                    Text += "1: #11100794     S6 PVEO 12V (alter Stand)\n";
                                    Text += "2: #11100795     S6 PVEO 24V (alter Stand)\n";
                                    Text += "3: #124-0064-0   S7 PVEO, 12V(9V) Coil, ohne LVDT Coil, Stecker Deutsch 4p (vorher S6, nicht mehr existent), Stand 4.12.'14\n";
                                    Text += "4: #124-0065-0   S7 PVEO, 12V(9V) Coil, ohne LVDT Coil, Stecker AMP 4p (vorher S6, nicht mehr existent), Stand 4.12.'14\n";
                                    Text += "5: #124-0066-0   S7 PVEO, 12V(9V) Coil, ohne LVDT Coil, Stecker Hirschmann 4p/3c (vorher S6, nicht mehr existent), Stand 4.12.'14\n";
                                    Text += "6: #11100792     S6 PVEA (alter Stand)\n";
                                    Text += "7: #11100793     S6 PVEA-F (alter Stand)\n";
                                    Text += "8: #124-0051-0   S6 PVEA, 9V Coils, Stand 29.1.'15\n";
                                    Text += "9: #124-0052-0   S6 PVEA-F, 9V Coils, Stand 29.1.'15\n";
                                    Text += "10:#124-0054-0   S6 PVEA-CI, 9V Coils, CAN-Bus, mit LVDT Coil Stand 29.1.'15\n";
                                    Text += "11:#124-0055-0 S6 PVEO-CI, 9V Coils, CAN Bus, ohne LVDT Coil Stand 29.1.'15\n";
                                    Text += "20:#124-0071-0 S7 PVEA, 9V Coils,mit LVDT Coil, Stand 9.3.'15\n\n";
                                    Text += "ab hier Ventilblöcke mit 4 coils\n\n";
                                    Text += "12:#124-0057-0 S7 PVEH/S, 4x 9V coil, AMP 4p Stecker (vorher S6 32'er Serie), Stand 4.12.'14\n";
                                    Text += "13:#124-0058-0 S7 PVEH-NP/SP/F, 4x 9V coil, Deutsch 6p/6c Stecker (vorher S6 32'er Serie), Stand 4.12.'14\n";
                                    Text += "14:#124-0059-0 S7 PVEH/S, 4x 9V coil, Hirschmann 4p/4c Stecker (vorher S6 32'er Serie), Stand 4.12.'14\n";
                                    Text += "15:#124-0061-0 S7, PVEH/S, 4x 9V coil, Deutsch 4p Stecker (vorher S6 32'er Serie), Stand 4.12.'14\n";
                                    Text += "16:#124-0062-0 S7, PVEH/S, 4x 9V coil, Metripack Stecker (vorher S6 32'er Serie), Stand 4.12.'14\n";
                                    Text += "17:#124-0060-0 S7, PVEH/S-DI, 4x 9V coils, AMP 2*4P Stecker, Stand 4.12.'14\n";
                                    Text += "18:#124-0063-0 S7, PVEH/S-DI, 4x 9V coil, Deutsch 2*4P Stecker, Stand 4.12.'14\n";

                                    messagebox1.AppendText(Text);

                                }
                            }
                            break;
                        case (char)49: //ALT-1 
                            send_data("$U10");
                            break;
                        case (char)50: //ALT-2 
                            send_data("$U11");
                            break;
                        case (char)51: //ALT-3 
                            send_data("$U20");
                            break;
                        case (char)52: //ALT-4 
                            send_data("$U21");
                            break;
                        /*                        case (char)53: //ALT-5 
                                                    send_data("$AM");
                                                    break;
                                                case (char)55: //ALT-7
                                                    send_data("$AS7");
                                                    break;
                        */
                        case (char)73:  //ALT-I = Init Arduino-can
                            send_data("dm");
                            break;
                        case (char)82: //ALT-R = Read latest CAN response
                            send_data("$CR");
                            break;
                        case (char)84: // ALT-T = Read current Temperature
                            double temp = GetTemperature();
                            //messagebox1.AppendText(("Temperature is " + temp + "°C").ToString());
                            break;
                        case (char)54:
                        case (char)53:
                            messagebox1.AppendText("Form.KeyPress: '" +
                                e.KeyValue.ToString() + "' consumed.");
                            e.Handled = true;
                            break;
                        default:
                            messagebox1.AppendText("Form.KeyPress: '" + e.KeyValue.ToString() + "' pressed.");
                            break;
                    }
                }
        }
        // Serial Port Control
        private bool initialize_comport()                           //Initalize the comports and the attached measurement units
        {
            bool failure = false;

            //Set which unit is connected to which COM-port
            try
            {
                serialPortTester.PortName = serialport_tester;

            }
            catch (Exception ex)
            {
                error_output(("Referenced comport for PVEX tester not present ! - Check Windows settings ! \rCOM Object must be named " + serialport_tester + " (" + ex.Message + ")").ToString());
                failure = true;
            }

            try
            {
                //Close if neccessary
                try { serialPortTester.Close(); }
                catch { };
                //Try to initalize comports
                serialPortTester.BaudRate = 9600;
                serialPortTester.DataBits = 8;
                serialPortTester.NewLine = "\r";
                serialPortTester.Open();
                serialPortTester.DiscardInBuffer();
                serialPortTester.DiscardOutBuffer();
            }
            catch
            {
                error_output("PVEX Tester port communication error !");
                failure = true;
            }
            //Set which unit is connected to which COM-port
            try
            {
                serialPortMilliohmmeter.PortName = serialport_milliohmmeter;
            }

            catch (Exception ex)
            {
                error_output(("Referenced comport for Multimeter not present !- Check Windows settings ! \rCOM Object must be named " + serialport_milliohmmeter + " (" + ex.Message + ")").ToString());
                failure = true;
            }
            try
            {
                //Close if neccessary
                try { serialPortMilliohmmeter.Close(); }
                catch { };
                //Try to initalize comports
                serialPortMilliohmmeter.BaudRate = 9600;
                serialPortMilliohmmeter.DataBits = 8;
                serialPortMilliohmmeter.NewLine = "\r";
                serialPortMilliohmmeter.Open();
                serialPortMilliohmmeter.DiscardInBuffer();
                serialPortTester.DiscardOutBuffer();

                //Initialize Milliohmmeter

                serialPortMilliohmmeter.WriteLine(":SYSTEM:REMOTE");                    //Set Multimeter to Remote mode
                serialPortMilliohmmeter.WriteLine("*RST");                              //Reset Multimeter
                serialPortMilliohmmeter.WriteLine(":SYSTEM:RWL");                       //Prvent switching to local mode on panel
                serialPortMilliohmmeter.WriteLine(":CONF:FRES");                        //Set to 4 wire resistance check mode
                serialPortMilliohmmeter.WriteLine(":SENS:FRES:NPLC 0.1");               //Set integration rate medium
                serialPortMilliohmmeter.WriteLine(":SENS:FRES:RANG:UPP 1000");          //Set upper range limit to 10kOhm
                serialPortMilliohmmeter.WriteLine(":SENS:FRES:REF:STAT 0");             //Disable comparison to reference value
                serialPortMilliohmmeter.WriteLine(":SENS:FRES:AVER:COUN 10");           //Set avergae function to 20 cycles
                serialPortMilliohmmeter.WriteLine(":SENS:FRES:AVER:STAT 1");            //Enable average function
                serialPortMilliohmmeter.WriteLine(":INIT:CONT 0");                      //Disable continous measurement
            }
            catch
            {
                error_output("Multimeter communication port error !");
                failure = true;
            }

            //Set which unit is connected to which COM-port
            try
            {
                serialPortTemperatureSensor.PortName = serialport_temperaturesensor;
                error_output(("Searching for Temperature Sensor on Port '" + serialport_temperaturesensor + "'").ToString());
            }

            catch (Exception ex)
            {
                error_output(("Referenced comport for Temperature Sensor not present !- Check Windows settings ! \rCOM Object must be named " + serialport_temperaturesensor + " (" + ex.Message + ")").ToString());
                failure = true;
            }
            try
            {
                //Close if neccessary
                try { serialPortTemperatureSensor.Close(); }
                catch { };
                //Try to initalize comports
                serialPortTemperatureSensor.BaudRate = 9600;
                serialPortTemperatureSensor.DataBits = 8;
                serialPortTemperatureSensor.Parity = Parity.None;
                serialPortTemperatureSensor.NewLine = "\r\n";
                serialPortTemperatureSensor.Open();
                serialPortTemperatureSensor.DiscardInBuffer();
                serialPortTemperatureSensor.DiscardOutBuffer();

                byte[] outbuff1 = new byte[10];
                outbuff1[0] = 0xff;   // read register
                outbuff1[1] = 0x03;   // read register
                outbuff1[2] = 0x00;  // adress: average temperature
                outbuff1[3] = 0x90;  //
                outbuff1[4] = 0x00;
                outbuff1[5] = 0x0a;
                outbuff1[6] = 0xd0;
                outbuff1[7] = 0x3e;
                outbuff1[8] = 0x0d;
                outbuff1[9] = 0x0a;

                byte[] outbuff2 = new byte[10];
                outbuff2[0] = 0xff;   // read register
                outbuff2[1] = 0x03;   // read register
                outbuff2[2] = 0x00;  // adress: average temperature
                outbuff2[3] = 0x00;  //
                outbuff2[4] = 0x00;
                outbuff2[5] = 0x12;
                outbuff2[6] = 0xd0;
                outbuff2[7] = 0x19;
                outbuff2[8] = 0x0d;
                outbuff2[9] = 0x0a;

                //int value = calculateLRC(outbuff);
                serialPortTemperatureSensor.Write(outbuff2, 0, 8);
                Thread.Sleep(125);  // Sensor reaction time 125ms
                byte[] inbuff = new byte[41];
                serialPortTemperatureSensor.Read(inbuff, 0, 41);
                string answer = "";
                for (int n = 0; n < 41; n++)
                {
                    int val;
                    val = (inbuff[n] & 0xf0) >> 4;
                    if (val < 10) answer += val;
                    else answer += (char)('A' + (val - 10));
                    val = (inbuff[n] & 0x0f);
                    if (val < 10) answer += val;
                    else answer += (char)('A' + (val - 10));
                    answer += " ";
                }
                //error_output(("found: " + answer).ToString());

                int[] register = new int[0x12];
                int r = 0;
                for (int n = 3; n < 39; n += 2)
                {
                    int val;
                    val = inbuff[n] * 255 + inbuff[n + 1];
                    register[r] = val;
                    r++;
                }
                error_output(("average Temperature: " + (register[11] / 10.0) + "°C").ToString());
            }
            catch
            {
                error_output("Temperature Sensor communication port error !");
                failure = true;
            }
            return failure;

        }
        public double GetTemperature()
        {
            try
            {
                byte[] outbuff2 = new byte[8];
                outbuff2[0] = 0xff;   // read register
                outbuff2[1] = 0x03;   // read register
                outbuff2[2] = 0x00;  // adress: average temperature
                outbuff2[3] = 0x00;  //
                outbuff2[4] = 0x00;
                outbuff2[5] = 0x12;
                outbuff2[6] = 0xd0;
                outbuff2[7] = 0x19;
                serialPortTemperatureSensor.Write(outbuff2, 0, 8);

                Thread.Sleep(125);  // Sensor reaction time 125ms
                byte[] inbuff = new byte[41];
                serialPortTemperatureSensor.Read(inbuff, 0, 41);

                int[] register = new int[0x12];
                int r = 0;
                for (int n = 3; n < 39; n += 2)
                {

                    int val;
                    val = inbuff[n] * 255 + inbuff[n + 1];
                    register[r] = val;
                    r++;
                }
                error_output(("average temperature: " + (register[11] / 10.0) + "°C").ToString());
                if (debugit.Checked)
                {
                    error_output(("filtered temperature: " + (register[14] / 10.0) + "°C").ToString());
                    error_output(("unfiltered temperature: " + (register[15] / 10.0) + "°C").ToString());
                    error_output(("sensor temperature: " + (register[16] / 10.0) + "°C").ToString());
                    error_output(("reflected temperature: " + (register[6] / 10.0) + "°C").ToString());
                }
                return register[11] / 10.0;
            }
            catch
            {
                error_output("Temperature Sensor communication port error, assuming 20°C !");
                return 20.0;

            }
        }
        public static byte calculateLRC(byte[] bytes)
        {
            byte LRC = 0;
            for (int i = 0; i < bytes.Length; i++)
            {
                LRC ^= bytes[i];
            }
            return LRC;
        }
        private void serialPortTester_DataReceived(object sender, SerialDataReceivedEventArgs e)    //Interrupt routine for serial port
        {
            //Reset variables
            received_commandstring = "";
            received_valuestring = "";
            received_value = 0;
            bool receiveerror = false;
            
            // MessageBox.Show("334");

            //This routine handles an interrupt caused by receiving data from SPS        
            //Normal operation activated after boot up
            if (boot_up == false)//boot up系统启动
            {
                try
                {
                    received_data = serialPortTester.ReadLine();
                  //  MessageBox.Show(received_data);
                     
                    sw2.Write(received_data + "\r\n");
                    Thread.Sleep(30);

                    received_commandstring = received_data.Substring(0, 3);
                    received_valuestring = received_data.Substring(3, (received_data.Length - 3));
                    if (received_commandstring != "$CA" && received_commandstring != "$CS" && received_commandstring != "$CR")/*CA-CANBUS MESSAGE CS?? CR-CANBUS READ??                    */ 
                        received_value = Convert.ToDouble(received_valuestring);
                    else
                        received_value = 0;
                }
                catch
                {
                    receiveerror = true;
                };

                if (receiveerror == false)
                {
                    //If received data seems to be OK evaluate data
                    echo_received = true;
                    if (received_commandstring != "$AL")
                    {
                        evaluate_received_data();//AL-SYS err??
                   
                    }
                    }
                else
                {
                    //SHow errormessage
                    error_output(("RS-232 received data telegram " + received_data + " is not valid!").ToString());
                    serialPortTester.DiscardInBuffer();
                }
            }
        }
        private void evaluate_received_data()                       //Routine to evaluate received data from RS-232
        {
            //************************************************************
            //Evaluation of articlenumber command
            if ((received_commandstring == "$PC") && (system_ok == true))//PC-PRODUT MODE
            {
                bool articleerror = false;
                int newarticlecode = 0;

                //Set Articlenumber and Articlecode
                newarticlecode = Convert.ToInt16(received_value);

                //Check if articlecode has changed
                if (newarticlecode == articlecode)
                {
                    //Call measurement routines
                    this.BeginInvoke(new EventHandler(measurement_flow));
                    //this.Invoke((MethodInvoker)delegate
                    //{
                    //    measurement_flow();
                    //});
                }
                else
                {

                    S7_4_Coil = false; // this switch is used for 2 or 4 Channel Coil readout and
                    S7_2_Coil = false; // both are used for LED threshold value choice

                    //Change articlenumber and read new limits from file
                    switch (newarticlecode)
                    {
                        case 1:
                            //articlenumber = "11100794";   // D_11100794_S6_PVEO_12V_deutsch4p = 1, (alter Stand)
                            if (P12401100.Checked == false)
                            {
                                articlenumber = "124-0078-0"; // D_11148431_P_124_0078_0_S6_PVEO_12VCoils_deutsch4p = 1,
                            }
                            if (P12401100.Checked == true)
                            {
                                articlenumber = "124-0110-0"; // D_11148431_P_124_0078_0_S6_PVEO_12VCoils_deutsch4p = 1,
                            }
                            if (P1240112.Checked == true)
                            {
                                articlenumber = "124-0112-0"; // D_11148431_P_124_0078_0_S6_PVEO_12VCoils_deutsch4p = 1,
                            } 
                            break;
                        case 2:
                            //articlenumber = "11100795";   // D_11100795_S6_PVEO_24V_deutsch4p = 2, (alter Stand)
                            if (P12401110.Checked == false)
                            {
                                articlenumber = "124-0079-0"; // D_11148443_P_124_0079_0_S6_PVEO_24VCoils_deutsch4p = 2,
                            }
                            if (P12401110.Checked == true)
                            {
                                articlenumber = "124-0111-0"; // D_11148443_P_124_0079_0_S6_PVEO_24VCoils_deutsch4p = 2,
                            }
                            if (P1240113.Checked == true)
                            {
                                articlenumber = "124-0113-0"; // D_11148431_P_124_0078_0_S6_PVEO_12VCoils_deutsch4p = 1,
                            }  
                            break;
                        case 3:
                            articlenumber = "124-0064-0"; //  D_11164361_P_124_0064_0_S7_PVEO_12V9V_deutsch4p = 3, (vorher S6, nicht mehr existent), Stand 4.12.'14
                            S7_2_Coil = true;
                            break;
                        case 4:
                            if (P1240099.Checked == false)
                            {
                                articlenumber = "124-0065-0"; //  D_11164363_P_124_0065_0_S7_PVEO_12V9V_AMP4p = 4, (vorher S6, nicht mehr existent), Stand 4.12.'14
                                S7_2_Coil = true;
                            }
                            if (P1240099.Checked == true)
                            {
                                articlenumber = "124-0099-0"; //  D_11164363_P_124_0065_0_S7_PVEO_12V9V_AMP4p = 4, (vorher S6, nicht mehr existent), Stand 4.12.'14
                                S7_2_Coil = true;
                            } 
                            break;
                        case 5:
                            articlenumber = "124-0066-0"; //  D_11164359_P_124_0066_0_S7_PVEO_12V9V_Hirschmann4p3c = 5, (vorher S6, nicht mehr existent), Stand 4.12.'14
                            S7_2_Coil = true;
                            break;
                        case 6:
                            articlenumber = "11100792";   //  D_11100792__S6_PVEA_alt_9VCoils_Deutsch4p = 6, (alter Stand)
                            led_type = "005X-1";
                            break;
                        case 7:
                            articlenumber = "11100793";   //  D_11100793__S6_PVEA_F_alt_9VCoils_Deutsch6p5c = 7, (alter Stand)
                            S7_2_Coil = false;
                            led_type = "005X";
                            break;
                        case 8:
                            articlenumber = "124-0051-0"; // D_11146202_P_124_0051_0_S6_PVEA_9VCoils_Deutsch4p = 8, Stand 29.1.'15
                            led_type = "005X";
                            break;
                        case 9:
                            articlenumber = "124-0052-0"; // D_11130188_P_124_0052_0_S6_PVEA_F_9VCoils_Deutsch6p5c = 9, Stand 29.1.'15
                            led_type = "005X";
                            break;
                        case 10:
                            if ((P12401010.Checked == false)&&(P12401020.Checked == false))
                            {
                                articlenumber = "124-0054-0"; // D_11121926_P_124_0054_0_S6_PVEA_CI_9VCoils_CAN_2xDeutsch4p = 10, Stand 29.1.'15
                                led_type = "005X";
                                led_model = "Immediately";
                            }
                            if ((P12401010.Checked == true)&&(P12401020.Checked == false))
                            {
                                articlenumber = "124-0101-0"; // PVED-CC
                                model = "PVED-CC";
                                S7_4_Coil = true;
                            }
                            if ((P12401010.Checked == false) && (P12401020.Checked == true))
                            {
                                articlenumber = "124-0102-0"; // PVED-CC
                                model = "PVED-CC";
                                S7_4_Coil = true;
                            }   
                            
                            break;
                        case 11:
                            if (P12401090.Checked == false)
                            {
                                articlenumber = "124-0055-0"; // D_11133166_P_124_0055_0_S6_PVEO_CI_9VCoils_CAN_2xDeutsch4p = 11, Stand 29.1.'15
                            }
                            if (P12401090.Checked == true)
                            {
                                articlenumber = "124-0109-0"; // D_11133166_P_124_0055_0_S6_PVEO_CI_12VCoils_CAN_2xDeutsch4p = 11, Stand 29.1.'15
                            }  
                            break;
                        case 12:
                            articlenumber = "124-0057-0"; // D_11143349_P_124_0057_0_S7_PVEH_4x9VCoils_AMP4p = 12, vorher S6_32'er Serie, Stand 4.12.'14
                            S7_4_Coil = true;
                            break;
                        case 13:
                            articlenumber = "124-0058-0"; // D_11163319_P_124_0058_0_S7_PVEH_NP_SP_F_4x9VCoils_Deutsch6p6c = 13, vorher S6_32'er Serie, Stand 4.12.'14
                            S7_4_Coil = true;
                            break;
                        case 14:
                            articlenumber = "124-0059-0"; // D_11161438_P_124_0059_0_S7_PVEH_S_4x9VCoils_Hirschmann4p4c = 14, vorher S6_32'er Serie, Stand 4.12.'14
                            S7_4_Coil = true;
                            break;
                        case 15:
                            articlenumber = "124-0061-0"; // D_11143352_P_124_0061_0_S7_PVEH_S_4x9VCoils_Deutsch4p = 15, vorher S6_32'er Serie, Stand 4.12.'14
                            S7_4_Coil = true;
                            break;
                        case 16:
                            articlenumber = "124-0062-0"; // D_11143353_P_124_0062_0_S7_PVEH_S_4x9VCoils_Metripack = 16, vorher S6_32'er Serie, Stand 4.12.'14
                            S7_4_Coil = true;
                            break;
                        case 17:
                            if (P12401020.Checked == false)
                            {
                                articlenumber = "124-0060-0"; // D_11143354_P_124_0060_0_S7_PVEH_S_DI_4x9VCoils_AMP2x4p = 17, Stand 4.12.'14
                                S7_4_Coil = true;
                            }
                         /*   if (P12401020.Checked == true)
                            {
                                articlenumber = "124-0102-0"; // D_11143354_P_124_0060_0_S7_PVEH_S_DI_4x9VCoils_AMP2x4p = 17, Stand 4.12.'14
                                model = "PVED-CC";
                                S7_4_Coil = true;
                             
                            } */
                            break;
                        case 18:
                            articlenumber = "124-0063-0"; // D_11143355_P_124_0063_0_S7_PVEH_S_DI_4x9VCoils_Deutsch2x4p = 18, Stand 4.12.'14
                            S7_4_Coil = true;
                            break;
                        case 20:
                            articlenumber = "124-0071-0"; // D_11163322_P_124_0071_0_S7_PVEA_9VCoils_Deutsch4p = 20, Stand 9.3.'15
                            S7_2_Coil = true;
                            break;
                        case 21:
                            articlenumber = "124-0080-0"; // S7, PVEH-F, 4x 9V coil, AMP 6p6c
                            S7_4_Coil = true;
                            break;
                        case 22:
                            articlenumber = "124-0081-0"; // D_11163318_P_124_0081_0_S7_PVEH_NP_4x9VCoils_Deutsch6p5c=22,
                            S7_4_Coil = true;
                            break;
                        case 23:
                            articlenumber = "124-0082-0"; // D_11163317_P_124_0082_0_S7_PVEH_SP_4x9VCoils_Deutsch6p5c=23,
                            S7_4_Coil = true;
                            break;
                        case 24:
                            articlenumber = "124-0083-0"; // D_11163313_P_124_0083_0_S7_PVEA_NP_9VCoils_Deutsch6p5c=24,
                            S7_2_Coil = true;
                            break;
                        case 25:
                            articlenumber = "124-0067-0"; // D_11163124_P_124_0067_0_S7_PVEA_9VCoils_AMP4p=25,
                            S7_2_Coil = true;
                            led_type = "1240067";
                            break;
                        case 26:
                            articlenumber = "124-0069-0"; // D_11161383_P_124_0069_0_S7_PVEM_9VCoils_Hirschmann4p3c?=26, 
                            S7_2_Coil = true;
                            break;
                        case 27:
                            articlenumber = "124-0070-0"; // D_11163325_P_124_0070_0_S7_PVEA_DI_9VCoils_2xAMP4p=27,
                            S7_2_Coil = true;
                            break;
                        case 28:
                            articlenumber = "124-0073-0"; // D_11163123_P_124_0073_0_S7_PVEA_DI_9VCoils_2xDeutsch4p=28,
                            S7_2_Coil = true;
                            break;
                        case 29:
                            articlenumber = "124-0084-0"; // D_11163125_P_124_0084_0_S7_PVEO_DI_12V9VCoils_2xAMP4p=29,
                            S7_2_Coil = true;
                            break;
                        case 30:
                            articlenumber = "124-0077-0"; // D_11163326_P_124_0077_0_S7_PVEO_DI_24VCoils_2xAMP4p=30,
                            S7_2_Coil = true;
                            break;
                        case 31:
                            articlenumber = "124-0074-0"; // D_11164362_P_124_0074_0_S7_PVEO_24VCoils_Deutsch4p=31,
                            S7_2_Coil = true;
                            break;
                        case 32:
                            articlenumber = "124-0075-0"; // D_11164364_P_124_0075_0_S7_PVEO_24VCoils_AMP4p=32,
                            S7_2_Coil = true;
                            break;
                        case 33:
                            if (P1240090.Checked == false)
                            {
                                articlenumber = "124-0076-0"; // D_11164360_P_124_0076_0_S7_PVEO_24VCoils_Hirschmann4p3c=33,
                                S7_2_Coil = true;
                            }
                            if (P1240090.Checked == true)
                            {
                                articlenumber = "124-0090-0"; // D_11164360_P_124_0076_0_S7_PVEO_24VCoils_Hirschmann4p3c=33,
                                S7_2_Coil = true;

                            }
                            break;
                        case 34:
                            articlenumber = "124-0085-0"; // D_11167794_P_124_0085_0_S7_PVEH_S_U_9VCoils_Hirschmann4p4c=34,
                            S7_4_Coil = true;
                            break;
                        case 35:
                            articlenumber = "124-0086-0"; // D_11167795_P_124_0086_0_S7_PVEH_S_U_9VCoils_Deutsch4p=35,
                            S7_4_Coil = true;
                            break;
                        case 36:
                            articlenumber = "124-0087-0"; // D_11167796_P_124_0087_0_S7_PVEH_S_U_9VCoils_AMP4p=36,
                            S7_4_Coil = true;
                            break;
                        case 37:
                            articlenumber = "124-0088-0"; // D_11175113_P_124_0088_0_S7_PVEO_HP_12VCoils_Deutsch4p=37,
                            S7_2_Coil = true;
                            break;
                        case 38:
                            articlenumber = "124-0089-0"; // D_11175112_P_124_0089_0_S7_PVEO_HP_12VCoils_AMP4p=38,
                            S7_2_Coil = true;
                            break;
                        case 39:
                            articlenumber = "124-0098-0"; // D_11175114_P_124_0098_0_S7_PVEO_HP_24VCoils_Deutsch4p=39,
                            S7_2_Coil = true;
                            break;
                        case 40:
                            articlenumber = "124-0090-0"; // D_11184237_P_124_0090_0_S7_PVEO_HP_12VCoils_Hirschmann4p=37,
                            S7_2_Coil = true;
                            break;
                        case 41:
                            articlenumber = "124-0099-0"; // D_11184236_P_124_0099_0_S7_PVEO_HP_24VCoils_AMP4p=39,
                            S7_2_Coil = true;
                            break;
                        case 42:
                            articlenumber = "124-0100-0"; // D_11184238_P_124_0100_0_S7_PVEO_HP_24VCoils_Hirschmann4p=39,
                            S7_2_Coil = true;
                            break;


                        default:
                            articleerror = true;
                            break;
                    };

                    //If articlecode is known run test
                    if (articleerror == false)
                    {
                        //Set new Articlecode to actual articlecode
                        articlecode = newarticlecode;

                        //Update the new measurement limits from file
                        //this.BeginInvoke(new EventHandler(update_limits)))
                        this.Invoke((MethodInvoker)delegate
                        {
                            update_limits();
                        });

                        //Call measurement routines if system is ready
                        if (system_ok == true) this.BeginInvoke(new EventHandler(measurement_flow));

                        //if (system_ok == true) this.Invoke((MethodInvoker)delegate
                        //{
                        //measurement_flow();
                        //if (system_ok == true) this.BeginInvoke(new EventHandler(measurement_flow));
                        // });
                    }
                    else
                    {
                        error_output("Articlecode received from tester is not known!");
                    }

                }
            };
            if (received_commandstring == "$IS")//IS-INIT PLC
            {
                initial_state();
            }
            if ((received_commandstring == "$AX") && (received_value == 9))//LVDT POSITION
            {
                echo_received = false;

                //Show errormessage
                error_output("axis error detected!");
            }
            if ((received_commandstring == "$CR")&&(model!="PVED-CC")) // Read CAN Message
            {
                string[] b = new string[16];
                int[] bb = new int[16];
                int brk = 1;
                string dcd = "0";
                received_value = 0;
                ci_value = 0;
                //mCanAddress = received_valuestring.Substring(0, 8); // man muss anscheinend Nicht an diese Adresse senden....
                if (received_valuestring != "")
                { MessageBox.Show("CR: " + received_valuestring); }
                if (received_valuestring=="")
                { brk = 0;dcd = "0"; pause = 1; }
                if (received_valuestring != "")
                {
                    dcd = received_valuestring.Substring(8, 2);

                    for (int i = 0; i < (received_valuestring.Length - 3) / 2; i++)
                    {
                        b[i] = received_valuestring.Substring(2 * i, 2);
                        bb[i] = int.Parse(b[i], System.Globalization.NumberStyles.HexNumber);
                    }
                }
                    string state = "invalid";

                    // Interpretieren der CAN Message und einsetzen in den Value-Parameter
                    switch (int.Parse(dcd, System.Globalization.NumberStyles.HexNumber))
                    {
                        case 8: // Adr 12
                        ci_i = ci_i + 1;
                        if (b[7] == "31")
                            {
                                state = "retracted";
                                ci_value = bb[5] - 128;
                            testList["Test " + ci_i.ToString()].Spool.value = ci_value;
                            error_output("State " + state + " received!");
                                error_output("Value " + received_value + " received!");
                            }
                            else if (b[7] == "32")
                            {
                                state = "extended";
                                ci_value = -(bb[6] - 128);
                            testList["Test " + ci_i.ToString()].Spool.value = ci_value;
                            error_output("State " + state + " received!");
                                error_output("Value " + received_value + " received!");
                            }
                            else if (b[7] == "33")
                            {
                                state = "floating";
                            testList["Test " + ci_i.ToString()].Spool.value = ci_value;
                            error_output("State " + state + " received!");
                            }
                            else if (b[7] == "30")
                            {
                                state = "blocked";
                            testList["Test " + ci_i.ToString()].Spool.value = ci_value;
                            error_output("State " + state + " received!");
                            }
                            break;
                        default:
                            error_output("Unknown CAN response!");
                            break;
                    }
                   
                
            }


            if ((received_commandstring == "$CR") && (model == "PVED-CC")) // Read CAN Message
            {
                string[] b = new string[16];
                int[] bb = new int[16];
                int ww,i;
            
                //mCanAddress = received_valuestring.Substring(0, 8); // man muss anscheinend Nicht an diese Adresse senden....
                //  MessageBox.Show(received_valuestring);
                //  string dcd = received_valuestring.Substring(8, 2);
               


                if (received_valuestring.IndexOf("07251020") != -1)//07251020
                {
                    //received_value = 11;
                    for (i = 0; i < 2; i++)
                    {
                        b[i] = received_valuestring.Substring(10 + i * 2, 2);
                       // MessageBox.Show(b[i]);
                    }
                  //  MessageBox.Show(b[1] + b[0]);
                    if ((b[1] + b[0]).Length > 2)
                    {
                        received_value = hextodec(b[1] + b[0]);//hex transform bin then bin transform dec can transform negative number
                      //  received_value = Int32.Parse(b[1] + b[0], System.Globalization.NumberStyles.HexNumber);
                        cc_value = received_value;
                    }
                  //  MessageBox.Show(received_value.ToString());
                }
                    //   MessageBox.Show(received_valuestring);
             /*   for (int i = 0; i < (received_valuestring.Length - 3) / 2; i++)
                {
                    b[i] = received_valuestring.Substring(2 * i, 2);
                    bb[i] = int.Parse(b[i], System.Globalization.NumberStyles.HexNumber);
                }*/
            //    string state = "invalid";

                // Interpretieren der CAN Message und einsetzen in den Value-Parameter
              /*  switch (int.Parse(dcd, System.Globalization.NumberStyles.HexNumber))
                {
                    case 8: // Adr 12
                        if (b[7] == "31")
                        {
                            state = "retracted";
                            received_value = bb[5] - 128;
                            error_output("State " + state + " received!");
                            error_output("Value " + received_value + " received!");
                        }
                        else if (b[7] == "32")
                        {
                            state = "extended";
                         //   received_value = -(bb[6] - 128);
                            error_output("State " + state + " received!");
                            error_output("Value " + received_value + " received!");
                        }
                        else if (b[7] == "33")
                        {
                            state = "floating";
                            error_output("State " + state + " received!");
                        }
                        else if (b[7] == "30")
                        {
                            state = "blocked";
                            error_output("State " + state + " received!");
                        }
                        break;
                    case 4:
                        received_value = 11;
                        break;
                    default:
                        error_output("Unknown CAN response!");
                        received_value = 0;
                        break;
                }*/

            }      
        
        
        
        
        
        
        
        
        
        
        }
        private void send_data(string command, double value = -1.0) //Routine to send data to RS-232 and check if data was correctly transmitted
        {
            //Create local variables
            int errorcounter = 0;
            string echo = "";
            string data_to_send = "";
            echo_received = false;
            int timeoutcounter = 0;

            if (value != -1.0)
                data_to_send = command + Convert.ToString(value);
            else
                data_to_send = command;

            while (errorcounter < 3)
            {

                //Write data to tester
                try
                {
                    serialPortTester.WriteLine(data_to_send);
                }
                catch
                {
                    error_output("Error writing serial data to Tester: Check Windows COM object settings!");
                }

                //Wait max. 2 seconds for echo
                while ((echo_received == false) && (timeoutcounter < 500))
                {
                    Thread.Sleep(10);
                    timeoutcounter++;
                }

                if (timeoutcounter > 50)
                {
                    Thread.Sleep(100);  // something delayed the answer?
                }

                //Create echo string to compare
                echo = received_commandstring + received_valuestring; //Convert.ToString(received_value);

                if (echo_received == false)
                {
                    error_output("Extra nap as tester does not answer..??");
                    Thread.Sleep(500);
                    echo = received_commandstring + received_valuestring; //Convert.ToString(received_value);
                }


                //Compare received and sent data
                int l = data_to_send.Length; if (l > echo.Length) l = echo.Length;
                if (l >= 3 && echo.Substring(0, l) == data_to_send.Substring(0, l))
                {
                    errorcounter = 5;
                    //DEBUG
                    // messagebox1.AppendText("Command: " + data_to_send+" (->"+echo+ ") Time: " + (10 * timeoutcounter) + " ms\n");
                }
                else
                {
                 //   error_output("Transmission error on comport! Sent: " + data_to_send + " Received: " + echo + "-> retrying..");
                    //serialPortTester.DiscardInBuffer();
                    Thread.Sleep(100);
                    errorcounter++;
                    timeoutcounter = 0;
                }

            }
            //DEBUG
            //Thread.Sleep(50);
        }
        // File Handling
        private void update_limits()                                //Routine to update the test limits from file
        {
            int i;                                              //number of tests
            int n = 0;                                          //counter for number of single values in each row
            string line;                                        //Variable to buffer read line from file
            int columns = 0;                                    //counter for number of columns in each row

            int rows = 0;                                      //counter for rows

            string[] test = new string[10];                      //Array of test numbers
            double[] sv1ll = new double[10];                     //Array of lower limits SV1
            double[] sv1ul = new double[10];                     //Array of upper limits SV1
            double[] sv3ll = new double[10];                     //Array of lower limits SV3
            double[] sv3ul = new double[10];                     //Array of upper limits SV3
            string[] ledtarget = new string[10];                 //Array of LED target color
            double[] spoolll = new double[10];                   //Array of spool lower limits
            double[] spoolul = new double[10];                   //Array of spool lower limits
            double[] dirall = new double[10];                    //Array of DirA pin lower limits
            double[] diraul = new double[10];                    //Array of DirA pin upper limits
            double[] dirbll = new double[10];                    //Array of DirB pin lower limits
            double[] dirbul = new double[10];                    //Array of DirB pin upper limits
            double[] drvenll = new double[10];                   //Array of Drvenable pin lower limits
            double[] drvenul = new double[10];                   //Array of Drvenable pin upper limits

            //create empty limit vectors
            for (i = 0; i < 10; i++)
            {
                test[i] = "";
                sv1ll[i] = 0;
                sv1ul[i] = 0;
                sv3ll[i] = 0;
                sv3ul[i] = 0;
                ledtarget[i] = "";
                spoolll[i] = 0;
                spoolul[i] = 0;
                dirall[i] = 0;
                diraul[i] = 0;
                dirbll[i] = 0;
                dirbul[i] = 0;
                drvenll[i] = 0;
                drvenul[i] = 0;
            }


            //Set all tests to not performed by default
            foreach (Test item in testList.Values)
            {
                //Delet all Test performs
                item.SV1.perform_test = false;
                item.SV3.perform_test = false;
                item.SV2.perform_test = false;
                item.SV4.perform_test = false;
                item.LedR.perform_test = false;
                item.LedG.perform_test = false;
                item.Spool.perform_test = false;
                item.DirA.perform_test = false;
                item.DirB.perform_test = false;
                item.DrvEnable.perform_test = false;
            }

            //Set LVDT test to not performed
            LVDTtest1.perform_test = false;

            //try importing data from file
            try
            {
                //open limitfile                                         articlenumber
                using (StreamReader reader = new StreamReader(datapath + articlenumber + ".txt"))
                {
                    sw2.Write("limit file is " + datapath + articlenumber + "\r\n");
                    i = 1;                                                              //Start with first line
                    while ((line = reader.ReadLine()) != null)                          //Repeat until end of file
                    {
                        char[] separator = { ('\t'), (' ') };                           //define tab and whitespace as value separators
                        string[] singlevalues = line.Split(separator);
                        columns = singlevalues.Count();
                        rows++;
                        n = 0;
                        while (singlevalues[n] == "") n++;
                        test[i] = singlevalues[n];
                        test[i] = test[i].Replace("_", " ");
                        n++;
                        while (singlevalues[n] == "") n++;
                        sv1ll[i] = Double.Parse(singlevalues[n], ni);
                        n++;
                        while (singlevalues[n] == "") n++;
                        sv1ul[i] = Double.Parse(singlevalues[n], ni);
                        n++;
                        while (singlevalues[n] == "") n++;
                        sv3ll[i] = Double.Parse(singlevalues[n], ni);
                        n++;
                        while (singlevalues[n] == "") n++;
                        sv3ul[i] = Double.Parse(singlevalues[n], ni);
                        n++;
                        while (singlevalues[n] == "") n++;
                        ledtarget[i] = singlevalues[n];
                        n++;
                        while (singlevalues[n] == "") n++;
                        spoolll[i] = Double.Parse(singlevalues[n], ni);
                        n++;
                        while (singlevalues[n] == "") n++;
                        spoolul[i] = Double.Parse(singlevalues[n], ni);
                        n++;
                        while (singlevalues[n] == "") n++;
                        dirall[i] = Double.Parse(singlevalues[n], ni);
                        n++;
                        while (singlevalues[n] == "") n++;
                        diraul[i] = Double.Parse(singlevalues[n], ni);
                        n++;
                        while (singlevalues[n] == "") n++;
                        dirbll[i] = Double.Parse(singlevalues[n], ni);
                        n++;
                        while (singlevalues[n] == "") n++;
                        dirbul[i] = Double.Parse(singlevalues[n], ni);
                        n++;
                        while (singlevalues[n] == "") n++;
                        drvenll[i] = Double.Parse(singlevalues[n], ni);
                        n++;
                        while (singlevalues[n] == "") n++;
                        drvenul[i] = Double.Parse(singlevalues[n], ni);
                        n++;
                        i++;
                    }

                }

                //Write Values into global structure
                for (i = 0; i < 10; i++)
                {
                    //DEBUG
                    test[i].ToString();

                    //For all non LVDT tests copy limits into global structure
                    if ((test[i] == "Test 0") || (test[i] == "Test 1") || (test[i] == "Test 2") || (test[i] == "Test 3") || (test[i] == "Test 4") || (test[i] == "Test 5") || (test[i] == "Test 6") || (test[i] == "Test 7")|| (test[i] == "Test 8"))
                    {
                        try
                        {
                            testList[test[i]].SV1.llimit = sv1ll[i];
                            testList[test[i]].SV1.ulimit = sv1ul[i];
                            testList[test[i]].SV3.llimit = sv3ll[i];
                            testList[test[i]].SV3.ulimit = sv3ul[i];
                            testList[test[i]].SV2.llimit = sv1ll[i];
                            testList[test[i]].SV2.ulimit = sv1ul[i];
                            testList[test[i]].SV4.llimit = sv3ll[i];
                            testList[test[i]].SV4.ulimit = sv3ul[i];
                            testList[test[i]].LedR.target = ledtarget[i];
                            testList[test[i]].LedG.target = ledtarget[i];
                            testList[test[i]].Spool.llimit = spoolll[i];
                            testList[test[i]].Spool.ulimit = spoolul[i];
                            testList[test[i]].DirA.llimit = dirall[i];
                            testList[test[i]].DirA.ulimit = diraul[i];
                            testList[test[i]].DirB.llimit = dirbll[i];
                            testList[test[i]].DirB.ulimit = dirbul[i];
                            testList[test[i]].DrvEnable.llimit = drvenll[i];
                            testList[test[i]].DrvEnable.ulimit = drvenul[i];



                            //Check if test valid (test is not performed if upper limit=lower limit)
                            if (sv1ll[i] < sv1ul[i]) testList[test[i]].SV1.perform_test = true;
                            else testList[test[i]].SV1.perform_test = false;

                            if (sv3ll[i] < sv3ul[i]) testList[test[i]].SV3.perform_test = true;
                            else testList[test[i]].SV3.perform_test = false;

                            if (sv1ll[i] < sv1ul[i]) testList[test[i]].SV2.perform_test = true;
                            else testList[test[i]].SV2.perform_test = false;

                            if (sv3ll[i] < sv3ul[i]) testList[test[i]].SV4.perform_test = true;
                            else testList[test[i]].SV4.perform_test = false;

                            if ((ledtarget[i] == "red") || (ledtarget[i] == "green"))
                            {
                                testList[test[i]].LedR.perform_test = true;
                                testList[test[i]].LedG.perform_test = true;
                            }
                            else
                            {
                                testList[test[i]].LedR.perform_test = false;
                                testList[test[i]].LedG.perform_test = false;
                            }

                            if (spoolll[i] < spoolul[i]) testList[test[i]].Spool.perform_test = true;
                            else testList[test[i]].Spool.perform_test = false;

                            if (dirall[i] < diraul[i]) testList[test[i]].DirA.perform_test = true;
                            else testList[test[i]].DirA.perform_test = false;

                            if (dirbll[i] < dirbul[i]) testList[test[i]].DirB.perform_test = true;
                            else testList[test[i]].DirB.perform_test = false;

                            if (drvenll[i] < drvenul[i]) testList[test[i]].DrvEnable.perform_test = true;
                            else testList[test[i]].DrvEnable.perform_test = false;

                        }

                        catch
                        {
                            error_output("Limitfile contains corrupt data in row: " + i + " !");
                        };
                    };

                    //Copy LVDT parameters into global structure
                    if (test[i] == "LVDT")
                    {
                        LVDTtest1.delta_llimit = sv1ll[i];
                        LVDTtest1.delta_ulimit = sv1ul[i];
                        LVDTtest1.offset = sv3ll[i];
                        LVDTtest1.gradient = sv3ul[i];

                        //Check if test valid (test is not performed if upper limit=lower limit)
                        if ((sv1ll[i] != 0) && (sv1ul[i] != 0)) LVDTtest1.perform_test = true;
                        else LVDTtest1.perform_test = false;
                    };
                }
            }


            //Errormessage if file was not present
            catch (Exception ex)
            {
                error_output(("Error openening limitsfile: " + ex.Message).ToString());
            }
            //Fit screen to selected measurements
            match_screen();
        }
        private void read_configfile()                              //Routine to read timings and samples from configfile
        {
            int i = 0;
            int rows;                                           //number of rows
            string line;                                        //Variable to buffer read line from file
            string[] content = new string[20];                                   //Description of the control content
            string[] value = new string[20];                                     //Value of the content

            //try importing data from file
            try
            {
                //open configfile
           //     using (StreamReader reader = new StreamReader(datapath + "PVE_config.txt"))
                StreamReader reader = new StreamReader(datapath + "PVE_config.txt");
              //  {
                    i = 1;                                                              //Start with first line
                    while ((line = reader.ReadLine()) != null)                          //Repeat until end of file
                    {
                        char[] separator = { ('\t'), (' ') };                           //define tab and whitespace as value separators
                        string[] singlevalues = line.Split(separator);
                        content[i] = singlevalues[0];
                        value[i] = singlevalues[1];
                        i++;
                    }
               // }
            }

            //Errormessage if file was not present
            catch (Exception ex)
            {
                error_output(("Error openening configfile: " + ex.Message).ToString());
            }

            rows = i;

            //Analyse read content
            try
            {

                for (int count = 1; count < rows; count++)
                {
                    if (content[count] == "triggerswap_PVEO")
                    {
                        trigger_swap = Convert.ToInt16(value[count]);
                        error_output("triggerswap set to " + trigger_swap);
                    }
                    if (content[count] == "retriggers_PVEO")
                    {
                        trigger_repeats = Convert.ToInt16(value[count]);
                        error_output("number of retriggers for PVEO set to " + trigger_repeats);
                    }
                    if (content[count] == "triggerdelay_PVEO")
                    {
                        trigger_delay_ms = Convert.ToInt16(value[count]);
                        error_output("trigger delay for PVEO set to " + trigger_delay_ms / 1000.0 + "s.");
                    }
                    if (content[count] == "triggerlevel_PVEO")
                    {
                        trigger_level_mv = Convert.ToInt16(value[count]);
                        error_output("trigger level for PVEO set to " + trigger_level_mv / 1000.0 + "V.");
                    }
                    if (content[count] == "timebase_DC")
                    {
                        timebase_DC = Convert.ToUInt32(value[count]);
                        error_output("Timebase for DC: " + timebase_DC);
                    }
                    if (content[count] == "timebase_LVDT")
                    {
                        timebase_lvdt = Convert.ToUInt32(value[count]);
                        error_output("Timebase for LVDT: " + timebase_lvdt);
                    }
                    if (content[count] == "number_acquisitions_DC")
                    {
                        number_acq_DC = Convert.ToUInt32(value[count]);
                        error_output("# Samples for DC: " + number_acq_DC);
                    }
                    if (content[count] == "number_acquisitions_LVDT")
                    {
                        number_acq_lvdt = Convert.ToUInt32(value[count]);
                        error_output("# Samples for LVDT: " + number_acq_lvdt);
                    }
                    if (content[count] == "axistimer_LED")
                    {
                        axis_position_wait_led = Convert.ToUInt16(value[count]);
                        error_output("axis wait at LED test in ms: " + axis_position_wait_led);
                    }
                    if (content[count] == "axistimer")
                    {
                        axis_position_wait = Convert.ToUInt16(value[count]);
                        error_output("axis wait in ms: " + axis_position_wait);
                    }
                    if (content[count] == "Debug_view_time")
                    {
                        debug_view_time = Convert.ToUInt16(value[count]);
                        error_output("Review time for debug screen in ms: " + debug_view_time);
                    }
                    if (content[count] == "LED_threshold")
                    {
                        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
                        // this is only needed to correctly read e.g. '1.5V' on a system set to German number system where it should be "1,5V"
                        power_minimum = Convert.ToDouble(value[count]);
                        error_output("LED detection threshold for S6 Sensor Box in V: " + power_minimum);
                    }
                    if (content[count] == "LED_threshold_S7")
                    {
                        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
                        // this is only needed to correctly read e.g. '1.5V' on a system set to German number system where it should be "1,5V"
                        power_minimum_S7 = Convert.ToDouble(value[count]);
                        error_output("LED detection threshold for S7 Sensor Box in V: " + power_minimum_S7);
                    }
                    if (content[count] == "LED_retest_ms_S7")
                    {
                        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
                        // this is only needed to correctly read e.g. '1.5V' on a system set to German number system where it should be "1,5V"
                        half_flash_period = Convert.ToUInt16(value[count]);
                        error_output("LED retesting if invalid readout in [ms]: " + half_flash_period);
                    }
                    if (content[count] == "CAN_address")
                    {
                        mCanAddress = value[count];
                        error_output("CAN address for modules set to " + value[count]);
                    }
                    if (content[count] == "PVEX_PORT")
                    {
                        serialport_tester = value[count];
                        error_output("Port for PVEX Tester set to " + value[count]);
                    }
                    if (content[count] == "DRMM_PORT")
                    {
                        serialport_milliohmmeter = value[count];
                        error_output("Port for resitance meter set to " + value[count]);
                    }
                    if (content[count] == "TEMP_PORT")
                    {
                        serialport_temperaturesensor = value[count];
                        error_output("Port for temperature sensor set to " + value[count]);
                    }
                }
            }
            catch (Exception ex)
            {
                error_output(("Error converting data in configfile: " + ex.Message).ToString());
            }
        }
        private void write_database()                               //write data to database
        {
            string outputstring;
            string calenderyear;
            try
            {
                //Create appendix to create new localdatabase for each year
                calenderyear = Convert.ToString(DateTime.Now.Year);

                // Format of Output Line: | Test1:                                                                                                                        | Test2:     ...
                //  Date, Time, TestResult, SV1-Value, SV3-Value, SV2-Value, SV4-Value, RedLED-Value, GreenLED-Value, Spool-Value, DirA-Value, DirB-Value, DrvEnable-Value, SV1-Value, ...


                //initalize outputstring   
                if (testresult.BackColor == Color.Green) // Das fehlte hier..? testok wurde im gesamten Programm nicht gesetzt..
                    testok = true;
                else
                    testok = false;

                outputstring = (articlenumber + ";" +snno+";" +testok + ";");
                //Add Test Results
                outputstring = outputstring + string.Format("{0:0.00}", testList["Test 1"].SV1.value) + ";" + string.Format("{0:0.00}", testList["Test 1"].SV3.value) + ";" + string.Format("{0:0.00}", testList["Test 1"].SV2.value) + ";" + string.Format("{0:0.00}", testList["Test 1"].SV4.value) + ";" + string.Format("{0:0.00}", 12.0 - testList["Test 1"].LedR.value) + ";" + string.Format("{0:0.00}", 12.0 - testList["Test 1"].LedG.value) + ";" + string.Format("{0:0.00}", testList["Test 1"].Spool.value) + ";" + string.Format("{0:0.00}", testList["Test 1"].DirA.value) + ";" + string.Format("{0:0.00}", testList["Test 1"].DirB.value) + ";" + string.Format("{0:0.00}", testList["Test 1"].DrvEnable.value) + ";";
                outputstring = outputstring + string.Format("{0:0.00}", testList["Test 2"].SV1.value) + ";" + string.Format("{0:0.00}", testList["Test 2"].SV3.value) + ";" + string.Format("{0:0.00}", testList["Test 2"].SV2.value) + ";" + string.Format("{0:0.00}", testList["Test 2"].SV4.value) + ";" + string.Format("{0:0.00}", 12.0 - testList["Test 2"].LedR.value) + ";" + string.Format("{0:0.00}", 12.0 - testList["Test 2"].LedG.value) + ";" + string.Format("{0:0.00}", testList["Test 2"].Spool.value) + ";" + string.Format("{0:0.00}", testList["Test 2"].DirA.value) + ";" + string.Format("{0:0.00}", testList["Test 2"].DirB.value) + ";" + string.Format("{0:0.00}", testList["Test 2"].DrvEnable.value) + ";";
                outputstring = outputstring + string.Format("{0:0.00}", testList["Test 3"].SV1.value) + ";" + string.Format("{0:0.00}", testList["Test 3"].SV3.value) + ";" + string.Format("{0:0.00}", testList["Test 3"].SV2.value) + ";" + string.Format("{0:0.00}", testList["Test 3"].SV4.value) + ";" + string.Format("{0:0.00}", 12.0 - testList["Test 3"].LedR.value) + ";" + string.Format("{0:0.00}", 12.0 - testList["Test 3"].LedG.value) + ";" + string.Format("{0:0.00}", testList["Test 3"].Spool.value) + ";" + string.Format("{0:0.00}", testList["Test 3"].DirA.value) + ";" + string.Format("{0:0.00}", testList["Test 3"].DirB.value) + ";" + string.Format("{0:0.00}", testList["Test 3"].DrvEnable.value) + ";";
                outputstring = outputstring + string.Format("{0:0.00}", testList["Test 4"].SV1.value) + ";" + string.Format("{0:0.00}", testList["Test 4"].SV3.value) + ";" + string.Format("{0:0.00}", testList["Test 4"].SV2.value) + ";" + string.Format("{0:0.00}", testList["Test 4"].SV4.value) + ";" + string.Format("{0:0.00}", 12.0 - testList["Test 4"].LedR.value) + ";" + string.Format("{0:0.00}", 12.0 - testList["Test 4"].LedG.value) + ";" + string.Format("{0:0.00}", testList["Test 4"].Spool.value) + ";" + string.Format("{0:0.00}", testList["Test 4"].DirA.value) + ";" + string.Format("{0:0.00}", testList["Test 4"].DirB.value) + ";" + string.Format("{0:0.00}", testList["Test 4"].DrvEnable.value) + ";";
                outputstring = outputstring + string.Format("{0:0.00}", testList["Test 5"].SV1.value) + ";" + string.Format("{0:0.00}", testList["Test 5"].SV3.value) + ";" + string.Format("{0:0.00}", testList["Test 5"].SV2.value) + ";" + string.Format("{0:0.00}", testList["Test 5"].SV4.value) + ";" + string.Format("{0:0.00}", 12.0 - testList["Test 5"].LedR.value) + ";" + string.Format("{0:0.00}", 12.0 - testList["Test 5"].LedG.value) + ";" + string.Format("{0:0.00}", testList["Test 5"].Spool.value) + ";" + string.Format("{0:0.00}", testList["Test 5"].DirA.value) + ";" + string.Format("{0:0.00}", testList["Test 5"].DirB.value) + ";" + string.Format("{0:0.00}", testList["Test 5"].DrvEnable.value) + ";";
                outputstring = outputstring + string.Format("{0:0.00}", testList["Test 6"].SV1.value) + ";" + string.Format("{0:0.00}", testList["Test 6"].SV3.value) + ";" + string.Format("{0:0.00}", testList["Test 6"].SV2.value) + ";" + string.Format("{0:0.00}", testList["Test 6"].SV4.value) + ";" + string.Format("{0:0.00}", 12.0 - testList["Test 6"].LedR.value) + ";" + string.Format("{0:0.00}", 12.0 - testList["Test 6"].LedG.value) + ";" + string.Format("{0:0.00}", testList["Test 6"].Spool.value) + ";" + string.Format("{0:0.00}", testList["Test 6"].DirA.value) + ";" + string.Format("{0:0.00}", testList["Test 6"].DirB.value) + ";" + string.Format("{0:0.00}", testList["Test 6"].DrvEnable.value) + ";";
                outputstring = outputstring + string.Format("{0:0.00}", testList["Test 7"].SV1.value) + ";" + string.Format("{0:0.00}", testList["Test 7"].SV3.value) + ";" + string.Format("{0:0.00}", testList["Test 7"].SV2.value) + ";" + string.Format("{0:0.00}", testList["Test 7"].SV4.value) + ";";

                //Attach LVDT result
                if (lvdt_result.BackColor == Color.Red) outputstring = outputstring + "lvdt_error";
                if (lvdt_result.BackColor == Color.Green) outputstring = outputstring + "lvdt_ok";
                if (lvdt_result.BackColor == Color.LightGray) outputstring = outputstring + "lvdt_no_test";
                if ((lvdt_result.BackColor != Color.Green) && (lvdt_result.BackColor != Color.Red)) outputstring = outputstring + "no_test";

                string firstline = "";
                string seconline = "";
                if (!System.IO.File.Exists(datapath + calenderyear + "localtestdata.txt"))
                {
                    firstline = "Date      ;Time    ;Type&SN     ;Overall;Test1                                     ;;;;;;;;;;Test2                                     ;;;;;;;;;;Test3                                     ;;;;;;;;;;Test4                                     ;;;;;;;;;;Test5                                     ;;;;;;;;;;Test6                                     ;;;;;;;;;;Test7       ;;;;LVDT  ";
                    seconline = "YYYY/DD/MM;hh:mm:ss;nn-nnnn-n;SN;Result ;SV1;SV3;SV2;SV4;LedR;LedG;Spool;DirA;DirB;DrvEnable;SV1;SV3;SV2;SV4;LedR;LedG;Spool;DirA;DirB;DrvEnable;SV1;SV3;SV2;SV4;LedR;LedG;Spool;DirA;DirB;DrvEnable;SV1;SV3;SV2;SV4;LedR;LedG;Spool;DirA;DirB;DrvEnable;SV1;SV3;SV2;SV4;LedR;LedG;Spool;DirA;DirB;DrvEnable;SV1;SV3;SV2;SV4;LedR;LedG;Spool;DirA;DirB;DrvEnable;SV1;SV3;SV2;SV4;result";
                }
                StreamWriter localdatafile = new StreamWriter(datapath + calenderyear + "localtestdata.txt", true);
                //string timestamp = (DateTime.Now.Year+";"+cal.GetWeekOfYear(DateTime.Now, dfi.CalendarWeekRule,dfi.FirstDayOfWeek)+";"+DateTime.Now.DayOfWeek+";"  + DateTime.Now.Hour + "-" + DateTime.Now.Minute + "-" + DateTime.Now.Second + ";");
                string timestamp = (DateTime.Now.Year + "/" + DateTime.Now.Day + "/" + DateTime.Now.Month + ";" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ";");

                if (firstline != "")
                {
                    localdatafile.WriteLine(firstline);
                    localdatafile.WriteLine(seconline);
                }

                localdatafile.WriteLine(timestamp + outputstring);
                localdatafile.Close();
            }
            catch
            {
                error_output("Error formating data and writing datafile !");
            }

        }
        // Screen Update
        private void match_screen()                                 //Fit screen to required tests
        {
            //Fit screen objects appearance to data read from limits file, all not required tests are greyed out all required tests are set to black on white
            for (int i = 0; i < 10; i++)
            {
                string actual_test = "test" + i.ToString();

                //Try appyling SV1 parameters to text boxes
                try
                {

                    if (testList["Test " + i.ToString()].SV1.perform_test == true)
                    {
                        textboxList[actual_test + "_sv1_ll"].BackColor = Color.White;
                        textboxList[actual_test + "_sv1_ll"].ForeColor = Color.Black;
                        textboxList[actual_test + "_sv1_ll"].Text = Convert.ToString(testList["Test " + i.ToString()].SV1.llimit);
                        textboxList[actual_test + "_sv1_result"].BackColor = Color.White;
                        textboxList[actual_test + "_sv1_result"].ForeColor = Color.Black;
                        textboxList[actual_test + "_sv1_result"].Text = "0";
                        textboxList[actual_test + "_sv1_ul"].BackColor = Color.White;
                        textboxList[actual_test + "_sv1_ul"].ForeColor = Color.Black;
                        textboxList[actual_test + "_sv1_ul"].Text = Convert.ToString(testList["Test " + i.ToString()].SV1.ulimit);
                    }
                    else
                    {
                        textboxList[actual_test + "_sv1_ll"].BackColor = Color.LightGray;
                        textboxList[actual_test + "_sv1_ll"].ForeColor = Color.LightGray;
                        textboxList[actual_test + "_sv1_ll"].Text = "0";
                        textboxList[actual_test + "_sv1_result"].BackColor = Color.LightGray;
                        textboxList[actual_test + "_sv1_result"].ForeColor = Color.LightGray;
                        textboxList[actual_test + "_sv1_result"].Text = "0";
                        textboxList[actual_test + "_sv1_ul"].BackColor = Color.LightGray;
                        textboxList[actual_test + "_sv1_ul"].ForeColor = Color.LightGray;
                        textboxList[actual_test + "_sv1_ul"].Text = "0";
                    }
                }
                catch
                {
                }

                //Try applying SV3 parameters to text boxes
                try
                {
                    if (testList["Test " + i.ToString()].SV3.perform_test == true)
                    {
                        textboxList[actual_test + "_sv3_ll"].BackColor = Color.White;
                        textboxList[actual_test + "_sv3_ll"].ForeColor = Color.Black;
                        textboxList[actual_test + "_sv3_ll"].Text = Convert.ToString(testList["Test " + i.ToString()].SV3.llimit);
                        textboxList[actual_test + "_sv3_result"].BackColor = Color.White;
                        textboxList[actual_test + "_sv3_result"].ForeColor = Color.Black;
                        textboxList[actual_test + "_sv3_result"].Text = "0";
                        textboxList[actual_test + "_sv3_ul"].BackColor = Color.White;
                        textboxList[actual_test + "_sv3_ul"].ForeColor = Color.Black;
                        textboxList[actual_test + "_sv3_ul"].Text = Convert.ToString(testList["Test " + i.ToString()].SV3.ulimit);
                    }
                    else
                    {
                        textboxList[actual_test + "_sv3_ll"].BackColor = Color.LightGray;
                        textboxList[actual_test + "_sv3_ll"].ForeColor = Color.LightGray;
                        textboxList[actual_test + "_sv3_ll"].Text = "0";
                        textboxList[actual_test + "_sv3_result"].BackColor = Color.LightGray;
                        textboxList[actual_test + "_sv3_result"].ForeColor = Color.LightGray;
                        textboxList[actual_test + "_sv3_result"].Text = "0";
                        textboxList[actual_test + "_sv3_ul"].BackColor = Color.LightGray;
                        textboxList[actual_test + "_sv3_ul"].ForeColor = Color.LightGray;
                        textboxList[actual_test + "_sv3_ul"].Text = "0";
                    }
                }
                catch
                {
                }

                //Try applying SV2 parameters to text boxes

                try
                {
                    if (testList["Test " + i.ToString()].SV2.perform_test == true && S7_4_Coil == true)
                    {
                        textboxList[actual_test + "_sv2_result"].BackColor = Color.White;
                        textboxList[actual_test + "_sv2_result"].ForeColor = Color.Black;
                        textboxList[actual_test + "_sv2_result"].Text = "0";
                    }
                    else
                    {
                        textboxList[actual_test + "_sv2_result"].BackColor = Color.LightGray;
                        textboxList[actual_test + "_sv2_result"].ForeColor = Color.LightGray;
                        textboxList[actual_test + "_sv2_result"].Text = "0";
                    }
                }
                catch
                {
                }

                //Try applying SV4 parameters to text boxes
                try
                {
                    if (testList["Test " + i.ToString()].SV4.perform_test == true && S7_4_Coil == true)
                    {
                        textboxList[actual_test + "_sv4_result"].BackColor = Color.White;
                        textboxList[actual_test + "_sv4_result"].ForeColor = Color.Black;
                        textboxList[actual_test + "_sv4_result"].Text = "0";
                    }
                    else
                    {
                        textboxList[actual_test + "_sv4_result"].BackColor = Color.LightGray;
                        textboxList[actual_test + "_sv4_result"].ForeColor = Color.LightGray;
                        textboxList[actual_test + "_sv4_result"].Text = "0";
                    }
                }
                catch
                {
                }


                //Try applying LED parameters to text boxes
                try
                {
                    if (testList["Test " + i.ToString()].LedR.perform_test == true) // or LedG
                    {
                        textboxList[actual_test + "_led_target"].BackColor = Color.White;
                        textboxList[actual_test + "_led_target"].ForeColor = Color.Black;
                        textboxList[actual_test + "_led_target"].Text = testList["Test " + i.ToString()].LedR.target;
                        textboxList[actual_test + "_led_result"].BackColor = Color.White;
                        textboxList[actual_test + "_led_result"].ForeColor = Color.Black;
                        textboxList[actual_test + "_led_result"].Text = "";
                    }
                    else
                    {
                        textboxList[actual_test + "_led_target"].BackColor = Color.LightGray;
                        textboxList[actual_test + "_led_target"].ForeColor = Color.LightGray;
                        textboxList[actual_test + "_led_target"].Text = "";
                        textboxList[actual_test + "_led_result"].BackColor = Color.LightGray;
                        textboxList[actual_test + "_led_result"].ForeColor = Color.LightGray;
                        textboxList[actual_test + "_led_result"].Text = "";
                    }
                }
                catch
                {
                }

                //Try applying Spool parameters to text boxes
                try
                {

                    if (testList["Test " + i.ToString()].Spool.perform_test == true)
                    {
                        textboxList[actual_test + "_spool_ll"].BackColor = Color.White;
                        textboxList[actual_test + "_spool_ll"].ForeColor = Color.Black;
                        textboxList[actual_test + "_spool_ll"].Text = Convert.ToString(testList["Test " + i.ToString()].Spool.llimit);
                        textboxList[actual_test + "_spool_result"].BackColor = Color.White;
                        textboxList[actual_test + "_spool_result"].ForeColor = Color.Black;
                        textboxList[actual_test + "_spool_result"].Text = "0";
                        textboxList[actual_test + "_spool_ul"].BackColor = Color.White;
                        textboxList[actual_test + "_spool_ul"].ForeColor = Color.Black;
                        textboxList[actual_test + "_spool_ul"].Text = Convert.ToString(testList["Test " + i.ToString()].Spool.ulimit);
                    }
                    else
                    {
                        textboxList[actual_test + "_spool_ll"].BackColor = Color.LightGray;
                        textboxList[actual_test + "_spool_ll"].ForeColor = Color.LightGray;
                        textboxList[actual_test + "_spool_ll"].Text = "0";
                        textboxList[actual_test + "_spool_result"].BackColor = Color.LightGray;
                        textboxList[actual_test + "_spool_result"].ForeColor = Color.LightGray;
                        textboxList[actual_test + "_spool_result"].Text = "0";
                        textboxList[actual_test + "_spool_ul"].BackColor = Color.LightGray;
                        textboxList[actual_test + "_spool_ul"].ForeColor = Color.LightGray;
                        textboxList[actual_test + "_spool_ul"].Text = "0";
                    }
                }
                catch
                {
                }

                //Try applying DirA parameters to text boxes
                try
                {
                    if (testList["Test " + i.ToString()].DirA.perform_test == true)
                    {
                        textboxList[actual_test + "_dira_ll"].BackColor = Color.White;
                        textboxList[actual_test + "_dira_ll"].ForeColor = Color.Black;
                        textboxList[actual_test + "_dira_ll"].Text = Convert.ToString(testList["Test " + i.ToString()].DirA.llimit);
                        textboxList[actual_test + "_dira_result"].BackColor = Color.White;
                        textboxList[actual_test + "_dira_result"].ForeColor = Color.Black;
                        textboxList[actual_test + "_dira_result"].Text = "0";
                        textboxList[actual_test + "_dira_ul"].BackColor = Color.White;
                        textboxList[actual_test + "_dira_ul"].ForeColor = Color.Black;
                        textboxList[actual_test + "_dira_ul"].Text = Convert.ToString(testList["Test " + i.ToString()].DirA.ulimit);
                    }
                    else
                    {
                        textboxList[actual_test + "_dira_ll"].BackColor = Color.LightGray;
                        textboxList[actual_test + "_dira_ll"].ForeColor = Color.LightGray;
                        textboxList[actual_test + "_dira_ll"].Text = "0";
                        textboxList[actual_test + "_dira_result"].BackColor = Color.LightGray;
                        textboxList[actual_test + "_dira_result"].ForeColor = Color.LightGray;
                        textboxList[actual_test + "_dira_result"].Text = "0";
                        textboxList[actual_test + "_dira_ul"].BackColor = Color.LightGray;
                        textboxList[actual_test + "_dira_ul"].ForeColor = Color.LightGray;
                        textboxList[actual_test + "_dira_ul"].Text = "0";
                    }
                }
                catch
                {
                }

                //Try applying DirB parameters to text boxes
                try
                {
                    if (testList["Test " + i.ToString()].DirB.perform_test == true)
                    {
                        textboxList[actual_test + "_dirb_ll"].BackColor = Color.White;
                        textboxList[actual_test + "_dirb_ll"].ForeColor = Color.Black;
                        textboxList[actual_test + "_dirb_ll"].Text = Convert.ToString(testList["Test " + i.ToString()].DirB.llimit);
                        textboxList[actual_test + "_dirb_result"].BackColor = Color.White;
                        textboxList[actual_test + "_dirb_result"].ForeColor = Color.Black;
                        textboxList[actual_test + "_dirb_result"].Text = "0";
                        textboxList[actual_test + "_dirb_ul"].BackColor = Color.White;
                        textboxList[actual_test + "_dirb_ul"].ForeColor = Color.Black;
                        textboxList[actual_test + "_dirb_ul"].Text = Convert.ToString(testList["Test " + i.ToString()].DirB.ulimit);
                    }
                    else
                    {
                        textboxList[actual_test + "_dirb_ll"].BackColor = Color.LightGray;
                        textboxList[actual_test + "_dirb_ll"].ForeColor = Color.LightGray;
                        textboxList[actual_test + "_dirb_ll"].Text = "0";
                        textboxList[actual_test + "_dirb_result"].BackColor = Color.LightGray;
                        textboxList[actual_test + "_dirb_result"].ForeColor = Color.LightGray;
                        textboxList[actual_test + "_dirb_result"].Text = "0";
                        textboxList[actual_test + "_dirb_ul"].BackColor = Color.LightGray;
                        textboxList[actual_test + "_dirb_ul"].ForeColor = Color.LightGray;
                        textboxList[actual_test + "_dirb_ul"].Text = "0";
                    }
                }
                catch
                {
                }

                //Try applying DrvEnable parameters to text boxes
                try
                {
                    if (testList["Test " + i.ToString()].DrvEnable.perform_test == true)
                    {
                        textboxList[actual_test + "_drven_ll"].BackColor = Color.White;
                        textboxList[actual_test + "_drven_ll"].ForeColor = Color.Black;
                        textboxList[actual_test + "_drven_ll"].Text = Convert.ToString(testList["Test " + i.ToString()].DrvEnable.llimit);
                        textboxList[actual_test + "_drven_result"].BackColor = Color.White;
                        textboxList[actual_test + "_drven_result"].ForeColor = Color.Black;
                        textboxList[actual_test + "_drven_result"].Text = "0";
                        textboxList[actual_test + "_drven_ul"].BackColor = Color.White;
                        textboxList[actual_test + "_drven_ul"].ForeColor = Color.Black;
                        textboxList[actual_test + "_drven_ul"].Text = Convert.ToString(testList["Test " + i.ToString()].DrvEnable.ulimit);
                    }
                    else
                    {
                        textboxList[actual_test + "_drven_ll"].BackColor = Color.LightGray;
                        textboxList[actual_test + "_drven_ll"].ForeColor = Color.LightGray;
                        textboxList[actual_test + "_drven_ll"].Text = "0";
                        textboxList[actual_test + "_drven_result"].BackColor = Color.LightGray;
                        textboxList[actual_test + "_drven_result"].ForeColor = Color.LightGray;
                        textboxList[actual_test + "_drven_result"].Text = "0";
                        textboxList[actual_test + "_drven_ul"].BackColor = Color.LightGray;
                        textboxList[actual_test + "_drven_ul"].ForeColor = Color.LightGray;
                        textboxList[actual_test + "_drven_ul"].Text = "0";
                    }
                }
                catch
                {
                }

                //Try applying Results to text boxes
                try
                {

                    if ((testList["Test " + i.ToString()].SV1.perform_test == true)
                        || (testList["Test " + i.ToString()].SV3.perform_test == true)
                        || (testList["Test " + i.ToString()].SV2.perform_test == true)
                        || (testList["Test " + i.ToString()].SV4.perform_test == true)
                        || (testList["Test " + i.ToString()].LedR.perform_test == true)
                        || (testList["Test " + i.ToString()].Spool.perform_test == true)
                        || (testList["Test " + i.ToString()].DirA.perform_test == true)
                        || (testList["Test " + i.ToString()].DirB.perform_test == true)
                        || (testList["Test " + i.ToString()].DrvEnable.perform_test == true))
                        textboxList[actual_test + "_result"].BackColor = Color.White;
                    else textboxList[actual_test + "_result"].BackColor = Color.LightGray;
                }
                catch
                {
                }

            }

            //Set LVDT linearity test indicator
            if (LVDTtest1.perform_test == true)
            {
                lvdt_result.BackColor = Color.White;
                plotwindow.Visible = true;
            }
            else
            {
                lvdt_result.BackColor = Color.LightGray;
                plotwindow.Visible = debugit.Checked;
                ;
            }
            //Set Articlenumber and code
            articlenumber_field.Text = Convert.ToString(articlenumber);
            articlecode_field.Text = Convert.ToString(articlecode);

            this.Refresh();

        }
        private void show_screen()                                  //Show all measured results on screen
        {
            //Put all Testresults in their according textboxes
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    textboxList["test" + i.ToString() + "_sv1_result"].Text = String.Format("{0:0.0}", testList["Test " + i.ToString()].SV1.value);
                    textboxList["test" + i.ToString() + "_sv3_result"].Text = String.Format("{0:0.0}", testList["Test " + i.ToString()].SV3.value);
                    textboxList["test" + i.ToString() + "_sv2_result"].Text = String.Format("{0:0.0}", testList["Test " + i.ToString()].SV2.value);
                    textboxList["test" + i.ToString() + "_sv4_result"].Text = String.Format("{0:0.0}", testList["Test " + i.ToString()].SV4.value);
                    textboxList["test" + i.ToString() + "_led_result"].Text = String.Format("{0:0.0}", led_color(testList["Test " + i.ToString()].LedR.value, testList["Test " + i.ToString()].LedG.value));
                    textboxList["test" + i.ToString() + "_spool_result"].Text = String.Format("{0:0.0}", testList["Test " + i.ToString()].Spool.value);
                    textboxList["test" + i.ToString() + "_dira_result"].Text = String.Format("{0:0.0}", testList["Test " + i.ToString()].DirA.value);
                    textboxList["test" + i.ToString() + "_dirb_result"].Text = String.Format("{0:0.0}", testList["Test " + i.ToString()].DirB.value);
                    textboxList["test" + i.ToString() + "_drven_result"].Text = String.Format("{0:0.0}", testList["Test " + i.ToString()].DrvEnable.value);
                }
                catch
                {
                }
            }
            this.Refresh();
        }
        private void reset_measurement()                            //Reset screen before measurement
        {
            //Reset all Measurement Values
            for (int i = 0; i < 10; i++)
            {
                testList["Test " + i.ToString()].SV1.value = 0;
                testList["Test " + i.ToString()].SV3.value = 0;
                testList["Test " + i.ToString()].SV2.value = 0;
                testList["Test " + i.ToString()].SV4.value = 0;
                testList["Test " + i.ToString()].LedR.value = 0;
                testList["Test " + i.ToString()].LedG.value = 0;
                testList["Test " + i.ToString()].Spool.value = 0;
                testList["Test " + i.ToString()].DirA.value = 0;
                testList["Test " + i.ToString()].DirB.value = 0;
                testList["Test " + i.ToString()].DrvEnable.value = 0;
            }
            //Reset Led Test result
            LVDTtest1.test_result = true;

            //Reset colors of test 1-7 and lvdt test from green or red to white if they are not greyed out
            if (test1_result.BackColor != Color.LightGray) test1_result.BackColor = Color.White;
            if (test2_result.BackColor != Color.LightGray) test2_result.BackColor = Color.White;
            if (test3_result.BackColor != Color.LightGray) test3_result.BackColor = Color.White;
            if (test4_result.BackColor != Color.LightGray) test4_result.BackColor = Color.White;
            if (test5_result.BackColor != Color.LightGray) test5_result.BackColor = Color.White;
            if (test6_result.BackColor != Color.LightGray) test6_result.BackColor = Color.White;
            if (test7_result.BackColor != Color.LightGray) test7_result.BackColor = Color.White;
            if (test8_result.BackColor != Color.LightGray) test8_result.BackColor = Color.White;
            if (lvdt_result.BackColor != Color.LightGray) lvdt_result.BackColor = Color.White;

            //Reset main result
            testresult.BackColor = Color.White;

            //Refresh screen
            this.Refresh();

        }
        // Calculations and Checks
        private void check_limits()                                 //This procedure is to check if the measured results are within limits
        {
            for (int i = 0; i < 10; i++)
            {
                //If value>ulimit or value <ulimit set test.result=false

                try
                {

                  //  if (TYPE.IndexOf("-CC") == -1)
                  //  {
                        if ((testList["Test " + i.ToString()].SV1.value > testList["Test " + i.ToString()].SV1.ulimit) || (testList["Test " + i.ToString()].SV1.value < testList["Test " + i.ToString()].SV1.llimit)) testList["Test " + i.ToString()].SV1.test_result = false; else testList["Test " + i.ToString()].SV1.test_result = true;
                        if ((testList["Test " + i.ToString()].SV3.value > testList["Test " + i.ToString()].SV3.ulimit) || (testList["Test " + i.ToString()].SV3.value < testList["Test " + i.ToString()].SV3.llimit)) testList["Test " + i.ToString()].SV3.test_result = false; else testList["Test " + i.ToString()].SV3.test_result = true;
                        if (S7_4_Coil == true)
                        {
                            if ((testList["Test " + i.ToString()].SV2.value > testList["Test " + i.ToString()].SV2.ulimit) || (testList["Test " + i.ToString()].SV2.value < testList["Test " + i.ToString()].SV2.llimit)) testList["Test " + i.ToString()].SV2.test_result = false; else testList["Test " + i.ToString()].SV2.test_result = true;
                            if ((testList["Test " + i.ToString()].SV4.value > testList["Test " + i.ToString()].SV4.ulimit) || (testList["Test " + i.ToString()].SV4.value < testList["Test " + i.ToString()].SV4.llimit)) testList["Test " + i.ToString()].SV4.test_result = false; else testList["Test " + i.ToString()].SV4.test_result = true;
                        }

                  //  }
                    
                    //   MessageBox.Show("44");
                 //   if (model != "PVED-CC")
                  //  {
                        if ((testList["Test " + i.ToString()].Spool.value > testList["Test " + i.ToString()].Spool.ulimit) || (testList["Test " + i.ToString()].Spool.value < testList["Test " + i.ToString()].Spool.llimit)) testList["Test " + i.ToString()].Spool.test_result = false; else testList["Test " + i.ToString()].Spool.test_result = true;
                  //  }
                 
                    if ((testList["Test " + i.ToString()].DirA.value > testList["Test " + i.ToString()].DirA.ulimit) || (testList["Test " + i.ToString()].DirA.value < testList["Test " + i.ToString()].DirA.llimit)) testList["Test " + i.ToString()].DirA.test_result = false; else testList["Test " + i.ToString()].DirA.test_result = true;
                    if ((testList["Test " + i.ToString()].DirB.value > testList["Test " + i.ToString()].DirB.ulimit) || (testList["Test " + i.ToString()].DirB.value < testList["Test " + i.ToString()].DirB.llimit)) testList["Test " + i.ToString()].DirB.test_result = false; else testList["Test " + i.ToString()].DirB.test_result = true;
                    if ((testList["Test " + i.ToString()].DrvEnable.value > testList["Test " + i.ToString()].DrvEnable.ulimit) || (testList["Test " + i.ToString()].DrvEnable.value < testList["Test " + i.ToString()].DrvEnable.llimit)) testList["Test " + i.ToString()].DrvEnable.test_result = false; else testList["Test " + i.ToString()].DrvEnable.test_result = true;
                    if (led_color(testList["Test " + i.ToString()].LedR.value, testList["Test " + i.ToString()].LedG.value) == testList["Test " + i.ToString()].LedR.target) testList["Test " + i.ToString()].LedR.test_result = true; else testList["Test " + i.ToString()].LedR.test_result = false;
                    if (led_color(testList["Test " + i.ToString()].LedR.value, testList["Test " + i.ToString()].LedG.value) == testList["Test " + i.ToString()].LedG.target) testList["Test " + i.ToString()].LedG.test_result = true; else testList["Test " + i.ToString()].LedG.test_result = false;

                    //If a subtest is failed set complete test indicator field to red
                    if ((testList["Test " + i.ToString()].SV1.perform_test == true) && (testList["Test " + i.ToString()].SV1.test_result == false)) textboxList["test" + i.ToString() + "_result"].BackColor = Color.Red;
                    if ((testList["Test " + i.ToString()].SV3.perform_test == true) && (testList["Test " + i.ToString()].SV3.test_result == false)) textboxList["test" + i.ToString() + "_result"].BackColor = Color.Red;
                    if (S7_4_Coil == true)
                    {
                        if ((testList["Test " + i.ToString()].SV2.perform_test == true) && (testList["Test " + i.ToString()].SV2.test_result == false)) textboxList["test" + i.ToString() + "_result"].BackColor = Color.Red;
                        if ((testList["Test " + i.ToString()].SV4.perform_test == true) && (testList["Test " + i.ToString()].SV4.test_result == false)) textboxList["test" + i.ToString() + "_result"].BackColor = Color.Red;
                    }
                    if ((testList["Test " + i.ToString()].Spool.perform_test == true) && (testList["Test " + i.ToString()].Spool.test_result == false)) textboxList["test" + i.ToString() + "_result"].BackColor = Color.Red;
                    if ((testList["Test " + i.ToString()].DirA.perform_test == true) && (testList["Test " + i.ToString()].DirA.test_result == false)) textboxList["test" + i.ToString() + "_result"].BackColor = Color.Red;
                    if ((testList["Test " + i.ToString()].DirB.perform_test == true) && (testList["Test " + i.ToString()].DirB.test_result == false)) textboxList["test" + i.ToString() + "_result"].BackColor = Color.Red;
                    if ((testList["Test " + i.ToString()].DrvEnable.perform_test == true) && (testList["Test " + i.ToString()].DrvEnable.test_result == false)) textboxList["test" + i.ToString() + "_result"].BackColor = Color.Red;
                    if ((testList["Test " + i.ToString()].LedR.perform_test == true) && (testList["Test " + i.ToString()].LedR.test_result == false)) textboxList["test" + i.ToString() + "_result"].BackColor = Color.Red;

                    //If no subtest caused chage test result indicator changing into red then set green because all tests passed
                    if (textboxList["test" + i.ToString() + "_result"].BackColor == Color.White) textboxList["test" + i.ToString() + "_result"].BackColor = Color.Green;
                }
                catch
                {
                }
            }

            //LVDT-linearity test
            if (LVDTtest1.perform_test == true)
            {
              //  if ((P12401010.Checked == true) || (P12401020.Checked == true))
                if (LVDTtest1.test_result == true) lvdt_result.BackColor = Color.Green; else lvdt_result.BackColor = Color.Red;
           
            }

            //Set global result field
            if ((test1_result.BackColor != Color.Red) && (test2_result.BackColor != Color.Red) && (test3_result.BackColor != Color.Red) && (test4_result.BackColor != Color.Red) && (test5_result.BackColor != Color.Red) && (test6_result.BackColor != Color.Red) && (test7_result.BackColor != Color.Red) && (test8_result.BackColor != Color.Red) && (lvdt_result.BackColor != Color.Red))
            {
                testresult.BackColor = Color.Green;
                send_data("$TR", 1);   //SEND IO RESULT OK
            }
            else
            {
                testresult.BackColor = Color.Red;
                send_data("$TR", 0);   //SEND IO RESULT NG
            }
            this.Refresh();

        }
        private float[] low_pass_filter(float[] input_data, float initial_value)    //FIR Low pass filter with fg=fsample/4
        {
            //Define local variables
            int nc = 11;
            int i, pointer = 0;
            float y;
            float[] b = new float[nc];
            float[] circular_buffer = new float[nc];

            //Create output array with same size as input array
            int array_size = input_data.Length;
            float[] output_data = new float[array_size];


            // Filtercoefficients for FIR filter with fg=fsample/4: b[0] = b_N, ..., b[nc - 1] = b_0
            b[0] = (float)0.0637;
            b[1] = 0;
            b[2] = (float)-0.1061;
            b[3] = 0;
            b[4] = (float)0.3183;
            b[5] = (float)0.5;
            b[6] = (float)0.3183;
            b[7] = 0;
            b[8] = (float)-0.1061;
            b[9] = 0;
            b[10] = (float)0.0637;

            //Clear circular Buffer
            for (i = 0; i < nc; i++)
                circular_buffer[i] = initial_value;

            for (int loop = 0; loop < array_size; loop++)
            {
                //Write actual input value into circular buffer
                circular_buffer[pointer] = input_data[loop];
                // Increment pointer modulo nc (gives 1,2,3,4,5,6,7,8,9,10,0,1...)
                pointer = (pointer + 1) % nc;
                // Calculate actual output value
                y = 0;
                for (i = 0; i < nc; i++)
                    y += (b[i] * circular_buffer[(pointer + i) % nc]);
                output_data[loop] = y;
            }

            //return output array
            return output_data;
        }
        private string led_color(double led_red, double led_green, bool initial = false)  //Routine to calculate LED color from read data
        {
            //Define local variables
            string led_color_calculated = "no output";
            double greenvalue = 0;
            double redvalue = 0;
            error_output("Meas LED-> red: " + led_red.ToString() + ", green: " + led_green.ToString());
            // S7 Sensor Box has different Hardware...so we need to adapt for the individual Box if S7:
            // So this is the Trick (with S7 at least it should work)
            // We measure the highest value that we can get and take this as basis. (highest Value = lowest Light)
            // So first measurement has to take part when there is no LED switched on.
            //#### nedd to check if this works with PVEO
            // we remember this value and even take lower ones when we find them.
            // In Future we measure the difference to that base value and compare which is bigger IF it's above the Border

            if (S7_2_Coil || S7_4_Coil)
            {
                // S7 Sensor Box
                if (initial)
                {
                    if (led_green > GreenOffValue) GreenOffValue = led_green;
                    if (led_red > RedOffValue) RedOffValue = led_red;
                    error_output("Initial Values-> red: " + led_red.ToString() + ", green: " + led_green.ToString());
                }

                greenvalue = GreenOffValue - led_green;
                sw2.Write("greenvalue=GreenOffValue-led_green is " + greenvalue.ToString() + "\r\n");
               
                redvalue = RedOffValue - led_red;
                sw2.Write("redvalue=RedOffValue - led_red is " + redvalue.ToString() + "\r\n");
                error_output("redvalue=RedOffValue - led_red is " + redvalue.ToString());
                error_output("greenvalue=GreenOffValue-led_green is " + greenvalue.ToString());
                error_output("powerS7 " + power_minimum_S7.ToString());
                if (led_type.IndexOf("0067") != -1)
                {
                   if(led_red < 11.1) { led_color_calculated = "red"; }
                    if ((led_red > 11.1)&&(led_red < 11.6)) { led_color_calculated = "green"; }
                    if (led_red > 11.6) { led_color_calculated = "no output"; }

                }
                    if (((redvalue > power_minimum_S7) || (greenvalue > power_minimum_S7))&&(led_type!="1240067"))
                {
                    sw2.Write("greenvalue or red value>power_minimum_S7, power_minimum_S7 is" + power_minimum_S7.ToString() + "\r\n");
                    if (greenvalue > redvalue)
                    {
                        
                        led_color_calculated = "green";
                        sw2.Write("greenvalue > redvalue color is green" + "\r\n");
                    }
                    if (greenvalue < redvalue)
                    {
                        sw2.Write("greenvalue < redvalue color is red" + "\r\n");
                        led_color_calculated = "red";
                    
                    }
                }
            }
            else
            {
                // S6 Sensor Box
                 /*  if (led_type == "005X-1")
                   {
                       MessageBox.Show("Green:" + led_green.ToString());
                       MessageBox.Show("Red:" + led_red.ToString());
                   }*/
                if (led_type.IndexOf("005X") == -1)
                {
                    greenvalue = (7.5 - led_green);
                    sw2.Write("greenvalue = (7.5 - led_green) is " + greenvalue.ToString() + "\r\n");
                    redvalue = (10.3 - led_red);
                    sw2.Write("redvalue = (10.3 - led_red) is " + redvalue.ToString() + "\r\n");
                    // Detect if radiation power is over limit = any led is on (10V is dark voltage for red, 7.5V is dark voltage for green)
                    if (((10 - led_red) + (7.5 - led_green)) > power_minimum)
                    {
                        sw2.Write("((10 - led_red) + (7.5 - led_green)) > power_minimum, power_minimum is" + power_minimum.ToString() + "\r\n");
                        if ((12 - led_red) > (12 - led_green))
                        {
                            led_color_calculated = "red";
                            sw2.Write("(12 - led_red) > (12 - led_green) color is red" + "\r\n");
                        }
                        if ((12 - led_red) < (12 - led_green))
                        {
                            led_color_calculated = "green";
                            sw2.Write("(12 - led_red) < (12 - led_green) color is green" + "\r\n");
                        }

                    }
                }
                if (led_type.IndexOf("005X") != -1)
                {
                  //  MessageBox.Show("Green:" + led_green.ToString());
                    //MessageBox.Show("Red:" + led_red.ToString());
                    if ((0.04< led_green) && (6.7 > led_green)&&(9.8<led_red)&&(10.4>led_red)) { led_color_calculated = "green"; }
if ((6.9 < led_green) && (8 > led_green) && (8.6 < led_red) && (9.2 > led_red)) { led_color_calculated = "red"; }
                }


            }//S6

            if (debugit.Checked)
                error_output("Color: " + led_color_calculated + " ( RED: " + redvalue.ToString() + ", GREEN: " + greenvalue.ToString() + " )");

            return led_color_calculated;
        }
        private string GetAuxiliaryCanCommand(string ValveState, float ValuePercent = 0, int ValveNodeID = 0x60, int SenderNodeID = 0x80, string sep = "")
        {
            // Calculate a Message String for sending a Valve Setting (extend, retract, float, block) to 0.. 100%
            // reference: 
            //      Document ED067938 S6-PVEA/O-CI User Manual, 
            //      Application SW-Version 1.33
            //      Bootloader SW-Version 1.32
            //      Print date: 2015.03.23
            //      (6.1.1.1 Auxiliary Valve Command)
            //
            // AND
            //
            //      Document ED062162 Revision G 
            //      Print date: 2015-05-29
            //      (Pages 14,17,18)

            // combine Message ID string
            int ValveID = ValveNodeID - 0x50;
            string MessageID = "0C" + sep + "FE" + sep + ValveID.ToString("X2") + sep + SenderNodeID.ToString("X2"); // this is how it should be according to the documentation
            //mCanAddress = MessageID;    //####
            if (MessageID != mCanAddress)
            {
                error_output("Different CAN adress used: 0x" + mCanAddress + " overrides 0x" + MessageID);
                MessageID = mCanAddress; // this supercedes the above !!
            }
            // generate Message content 

            // generate DLC (number of Bytes to follow...)
            string DLC;
            if (ValveState.IndexOf("pvedcc")!=-1)
            {
               // ValveState.IndexOf("pvedcc")!=-1
                DLC = "04";
            }
            else
            {
                DLC = "08";
            }
            // generate Message Bytes
            string[] Byte = new string[8];
            int value = (int)((0xFA * ValuePercent) / 100.0);

            //Byte 0: default 0x7D
            Byte[0] = "00";

            //Byte 1: default 0x7D
            Byte[1] = "00";

            //Byte2: Valve State
            Byte[2] = "XX";   // should generate an error later if not changed
            if (ValveState == "extend")
            {
                Byte[2] = "01";    // change to extend Port
                Byte[0] = value.ToString("X2"); // write extension value into associated byte 0
            }
            else if (ValveState == "retract")
            {
                Byte[2] = "02";    // change to retract Port
                Byte[0] = value.ToString("X2"); // write retraction value into associated byte 1 //#### documentation is wrong -> needs to be in Byte[0]
            }
            else if (ValveState == "float")
                Byte[2] = "03";    // change to float Port
            else if (ValveState == "block")
                Byte[2] = "00";    // change to block state
            else if (ValveState == "hand")
                Byte[2] = "0A";    // change to block state
            else if (ValveState == "emergency")
                Byte[2] = "0E";    // change to block state
          //  else error_output("Error: Valve State '" + ValveState + "' not known");

            // Set Byte 3..7 
            for (int i = 3; i <= 7; i++)
                Byte[i] = "00";


            // assemble complete string to send
         
          //  if (ValveState != "pvedcc3")
            string command = MessageID + sep + DLC;
            for (int i = 0; i <= 7; i++)
                command += sep + Byte[i];
       // }
            if (ValveState == "pvedcc3")
            {
                MessageID = "04022010";
       //     mCanAddress = "0CFE3006";
                Byte[0] = "FF";
                Byte[1] = "FF";
                Byte[2] = "00";
                Byte[3] = "40";
                for (int i = 4; i <= 7; i++)
                { Byte[i] = "00"; }
                command = MessageID + sep + DLC;
                for (int i = 0; i <= 3; i++)
                { command += sep + Byte[i]; }
            
            }
            if (ValveState == "pvedcc1")
            {
                MessageID = "04012010";
                //     mCanAddress = "0CFE3006";
                Byte[0] = "01";
                Byte[1] = "01";
                Byte[2] = "02";
                Byte[3] = "01";
                for (int i = 4; i <= 7; i++)
                { Byte[i] = "00"; }
                command = MessageID + sep + DLC;
                for (int i = 0; i <= 3; i++)
                { command += sep + Byte[i]; }

            }
            if (ValveState == "pvedcc4")
            {
                MessageID = "04022010";
                //     mCanAddress = "0CFE3006";
                Byte[0] = "FF";
                Byte[1] = "00";
                Byte[2] = "FF";
                Byte[3] = "40";
                for (int i = 4; i <= 7; i++)
                { Byte[i] = "00"; }
                command = MessageID + sep + DLC;
                for (int i = 0; i <= 3; i++)
                { command += sep + Byte[i]; }

            }
            if (ValveState == "pvedcc2")
            {
                MessageID = "04012010";
                //     mCanAddress = "0CFE3006";
                Byte[0] = "01";
                Byte[1] = "00";
                Byte[2] = "01";
                Byte[3] = "01";
                for (int i = 4; i <= 7; i++)
                { Byte[i] = "00"; }
                command = MessageID + sep + DLC;
                for (int i = 0; i <= 3; i++)
                { command += sep + Byte[i]; }

            }
            if (ValveState == "pvedcc5")
            {
                MessageID = "06252010";
                DLC = "00";
                //     mCanAddress = "0CFE3006";
                Byte[0] = "00";
                Byte[1] = "00";
                Byte[2] = "00";
                Byte[3] = "00";
                for (int i = 4; i <= 7; i++)
                { Byte[i] = "00"; }
                command = MessageID + sep + DLC;
              //  for (int i = 0; i <= 3; i++)
               // { command += sep + Byte[i]; }

            }    
            
            
            
            
            
            sw2.Write("can common :" + command + "\r\n"); 
            return command;
        }
        // Data Acquisition
        private voltagearray read_ADC(int group)                    //Measurement routine to detect both coilvoltages and the LED color
        {
            //Define local variables 
            voltagearray adc_voltages;
            adc_voltages.CH1 = 0;
            adc_voltages.CH2 = 0;
            adc_voltages.CH3 = 0;
            adc_voltages.CH4 = 0;
            string helpstring = "";

            //Send Measurement request
            send_data("$AD", group);

            //Read Back values
            try
            {
                helpstring = serialPortTester.ReadLine();
                char[] separator = { (';') };
                string[] singlevalues = helpstring.Split(separator);
                int columns = singlevalues.Count();
                adc_voltages.CH1 = Convert.ToDouble(singlevalues[0]);
                adc_voltages.CH2 = Convert.ToDouble(singlevalues[1]);
                adc_voltages.CH3 = Convert.ToDouble(singlevalues[2]);
                adc_voltages.CH4 = Convert.ToDouble(singlevalues[3]);

            }
            catch
            {
                error_output("Error reading ADC-Converter!");
            }
            return adc_voltages;
        }
        private void scope_limits(Scope.Range CHA, Scope.Range CHB, Scope.Range CHC, Scope.Range CHD)   //Routine to apply the scope measurement ranges to Picoscope
        {
            try
            {
                Scope.SetChannel(_handle, Scope.Channel.ChannelA, 1, 1, CHA);
                Scope.SetChannel(_handle, Scope.Channel.ChannelB, 1, 1, CHB);
                Scope.SetChannel(_handle, Scope.Channel.ChannelC, 1, 1, CHC);
                Scope.SetChannel(_handle, Scope.Channel.ChannelD, 1, 1, CHD);
            }
            catch
            {
                error_output("Error applying scope limits!");
            };

        }
        private short GetScopeMultiplier(Scope.Range rangeSetting)  //calculate multiplier from Scope Setting
        {
            //Set correct multiplikators
            if (rangeSetting == Scope.Range.Range_1V) return 1;
            if (rangeSetting == Scope.Range.Range_2V) return 2;
            if (rangeSetting == Scope.Range.Range_5V) return 5;
            if (rangeSetting == Scope.Range.Range_10V) return 10;
            if (rangeSetting == Scope.Range.Range_20V) return 20;
            if (rangeSetting == Scope.Range.Range_50V) return 50;
            return 0;
        }
        private voltagearray scope_DC(uint number_acquisitions, uint timebase, Scope.Range RangeA, Scope.Range RangeB, Scope.Range RangeC, Scope.Range RangeD)
        {
            //Measurement routine to detect both coilvoltages and the LED color

            //Define local variables
            short status;
            int i;
            double voltage1 = 0;
            double voltage2 = 0;
            double voltage3 = 0;
            double voltage4 = 0;

            //Set correct multiplikators
            short multiplier1 = GetScopeMultiplier(RangeA);
            short multiplier2 = GetScopeMultiplier(RangeB);
            short multiplier3 = GetScopeMultiplier(RangeC);
            short multiplier4 = GetScopeMultiplier(RangeD);

            float[] c1value = new float[number_acquisitions];
            float[] c2value = new float[number_acquisitions];
            float[] c3value = new float[number_acquisitions];
            float[] c4value = new float[number_acquisitions];

            if (debugit.Checked == true)
            {
                //DEBUG PLOT
                for (int loop = 0; loop < number_acquisitions; loop++)
                {
                    c1value[loop] = 0;
                    c2value[loop] = 0;
                    c3value[loop] = 0;
                    c4value[loop] = 0;
                }
                //Delete old plot
                plotwindow.GraphPane.CurveList.Clear();
                c1list.Clear();
                c2list.Clear();
                c3list.Clear();
                c4list.Clear();
            }


            //Set scope ranges
            try
            {
                scope_limits(RangeA, RangeB, RangeC, RangeD);
            }
            catch
            {
                error_output("Error setting scope Ranges!");
            }


            //Perform measurement
            try
            {
                status = SetTrigger(null, 0, null, 0, null, null, 0, 0, 0);
                int acquisition_ok = BlockDataAcquisition(number_acquisitions, timebase, 1, 50);
            }
            catch
            {
                error_output("Error setting to non triggered scope mode and reading values!");
            }

            //Calculate mean Values and find min/maxvalues
            double voltage1max = maxPinned[0].Target[0];
            double voltage2max = maxPinned[1].Target[0];
            double voltage3max = maxPinned[2].Target[0];
            double voltage4max = maxPinned[3].Target[0];

            double voltage1min = maxPinned[0].Target[0];
            double voltage2min = maxPinned[1].Target[0];
            double voltage3min = maxPinned[2].Target[0];
            double voltage4min = maxPinned[3].Target[0];

            for (i = 0; i < number_acquisitions; i++)
            {
                voltage1 = voltage1 + maxPinned[0].Target[i];
                voltage2 = voltage2 + maxPinned[1].Target[i];
                voltage3 = voltage3 + maxPinned[2].Target[i];
                voltage4 = voltage4 + maxPinned[3].Target[i];

                if (maxPinned[0].Target[i] > voltage1max) voltage1max = maxPinned[0].Target[i];
                if (maxPinned[1].Target[i] > voltage2max) voltage2max = maxPinned[1].Target[i];
                if (maxPinned[2].Target[i] > voltage3max) voltage3max = maxPinned[2].Target[i];
                if (maxPinned[3].Target[i] > voltage4max) voltage4max = maxPinned[3].Target[i];

                if (maxPinned[0].Target[i] < voltage1min) voltage1min = maxPinned[0].Target[i];
                if (maxPinned[1].Target[i] < voltage2min) voltage2min = maxPinned[1].Target[i];
                if (maxPinned[2].Target[i] < voltage3min) voltage3min = maxPinned[2].Target[i];
                if (maxPinned[3].Target[i] < voltage4min) voltage4min = maxPinned[3].Target[i];
            }

            //Stop scope after dat has acquired
            Scope.Stop(_handle);

            //Calculate mean value and write to variables structure
            scopevalues.CH1 = (voltage1 / 32767 * multiplier1 / number_acquisitions);
            scopevalues.CH2 = (voltage2 / 32767 * multiplier2 / number_acquisitions);
            scopevalues.CH3 = (voltage3 / 32767 * multiplier3 / number_acquisitions);
            scopevalues.CH4 = (voltage4 / 32767 * multiplier4 / number_acquisitions);

            scopemaxvalues.CH1 = voltage1max / 32767 * multiplier1;
            scopemaxvalues.CH2 = voltage2max / 32767 * multiplier2;
            scopemaxvalues.CH3 = voltage3max / 32767 * multiplier3;
            scopemaxvalues.CH4 = voltage4max / 32767 * multiplier4;

            scopeminvalues.CH1 = voltage1min / 32767 * multiplier1; 
            scopeminvalues.CH2 = voltage2min / 32767 * multiplier2; 
            scopeminvalues.CH3 = voltage3min / 32767 * multiplier3; 
            scopeminvalues.CH4 = voltage4min / 32767 * multiplier4; 
            if (debugit.Checked == true)
            {
                //DEBUG PLOT
                //generate data vectors for linearity plot
                for (int i2 = 0; i2 < number_acquisitions; i2++)
                {
                    //add points to x and y vector
                    c1value[i2] = (float)((float)maxPinned[0].Target[i2] / 32767 * 20);
                    c2value[i2] = (float)((float)maxPinned[1].Target[i2] / 32767 * 20);
                    c3value[i2] = (float)((float)maxPinned[2].Target[i2] / 32767 * 20);
                    c4value[i2] = (float)((float)maxPinned[3].Target[i2] / 32767 * 20);
                    c1list.Add((float)i2, (float)c1value[i2]);
                    c2list.Add((float)i2, (float)c2value[i2]);
                    c3list.Add((float)i2, (float)c3value[i2]);
                    c4list.Add((float)i2, (float)c4value[i2]);
                }

                //Show plot and scale axis
                plotwindow.GraphPane.AddCurve("CH1", c1list, Color.Blue);
                plotwindow.GraphPane.AddCurve("CH2", c2list, Color.Aqua);
                plotwindow.GraphPane.AddCurve("CH3", c3list, Color.Green);
                plotwindow.GraphPane.AddCurve("CH4", c4list, Color.Red);
                plotwindow.GraphPane.XAxis.Scale.Min = (0);
                plotwindow.GraphPane.XAxis.Scale.Max = (number_acquisitions);
                plotwindow.GraphPane.YAxis.Scale.Min = (0);
                plotwindow.GraphPane.YAxis.Scale.Max = (20);
                plotwindow.AxisChange();
                plotwindow.GraphPane.Title.IsVisible = false;
                plotwindow.GraphPane.XAxis.MajorGrid.IsVisible = true;
                plotwindow.GraphPane.YAxis.MajorGrid.IsVisible = true;
                plotwindow.Refresh();
                Thread.Sleep(debug_view_time);
            }
            return scopevalues;
        }
        // ...PVEO only...
        private voltagearray scope_SR(uint number_acquisitions, uint timebase, Scope.Range RangeA, Scope.Range RangeB, Scope.Range RangeC, Scope.Range RangeD, char channel, ushort numberAvg, short levelmv)
        {
            //Measurement routine to measure a voltage Step Response (the peak height after a 50% trigger, for PVEO Coil Swap detection)

            int acquisition_ms;
            bool measurement_successful = true;

            //Set correct multiplikators
            short multiplier_a = GetScopeMultiplier(RangeA);
            short multiplier_b = GetScopeMultiplier(RangeB);
            short multiplier_c = GetScopeMultiplier(RangeC);
            short multiplier_d = GetScopeMultiplier(RangeD);

            float[] c1value = new float[number_acquisitions];
            float[] c2value = new float[number_acquisitions];
            float[] c3value = new float[number_acquisitions];
            float[] c4value = new float[number_acquisitions];

            if (debugit.Checked == true)
            {
                //DEBUG PLOT
                for (int loop = 0; loop < number_acquisitions; loop++)
                {
                    c1value[loop] = 0;
                    c2value[loop] = 0;
                    c3value[loop] = 0;
                    c4value[loop] = 0;
                }
                //Delete old plot
                plotwindow.GraphPane.CurveList.Clear();
                c1list.Clear();
                c2list.Clear();
                c3list.Clear();
                c4list.Clear();
            }


            // switch scope input to coils
            send_data("$MM", 0);    // ensure power is generally on for PVEO (no multimeter mode)

            // im Gegensatz zur DC Messung müssen wir bei SR auch die Anregung (den Sprung) ausführen
            // Damit also: 
            //      0) Spannung ist eingeschaltet (coil A oder B)
            //      1) Trigger scharfstellen (coil A oder B)
            //      2) Sprung auf Null Volt ausführen (Spannung ausschalten)
            //      3) Werte auslesen und auswerten.
            switch (channel)
            {
                case 'A':
                    {
                        // 'activate' first coil by switching the resistance meter to the second coil, so the first coil is free to be switched to VS Power output.
                        send_data("$RC", 1);
                        if (mManualDebugOperation) send_data("$U1", 0);
                        if (mManualDebugOperation) send_data("$U2", 1);
                        Thread.Sleep(trigger_delay_ms);
                        //Applying scope parameters for first coil
                        try
                        {
                            //Set scope ranges
                            scope_limits(RangeA, RangeB, RangeC, RangeD);
                            //Calculate ADC Wert of 50% of supply voltage
                            short input_range_mv = (short)(multiplier_a * 1000);  // in millivolt
                            short trigger_level_mv = levelmv;  // in millivolt
                            short triggerleveladc = (short)((trigger_level_mv * Scope.MaxValue) / input_range_mv);
                            //Set scope to trigger on Calculated ADC value and Trigger to Channel A, rising edge
                            Scope.TriggerChannelProperties[] triggerproperties = new Scope.TriggerChannelProperties[] { 
                                new Scope.TriggerChannelProperties( triggerleveladc, 
                                                                    2560,//100, 
                                                                    triggerleveladc, 
                                                                    2560,//100, 
                                                                    (trigger_swap==0) ?Scope.Channel.ChannelA: Scope.Channel.ChannelB,
                                                                    Scope.ThresholdMode.Level)};
                            Scope.TriggerConditions[] triggerconditions = new Scope.TriggerConditions[] { 
                                new Scope.TriggerConditions(        (trigger_swap==0) ? Scope.TriggerState.True:Scope.TriggerState.DontCare, 
                                                                    (trigger_swap==0) ? Scope.TriggerState.DontCare:Scope.TriggerState.True,  
                                                                    Scope.TriggerState.DontCare, 
                                                                    Scope.TriggerState.DontCare, 
                                                                    Scope.TriggerState.DontCare, 
                                                                    Scope.TriggerState.DontCare, 
                                                                    Scope.TriggerState.DontCare) };
                            Scope.ThresholdDirection[] direction = new Scope.ThresholdDirection[] { 
                                                                    Scope.ThresholdDirection.Rising, 
                                                                    Scope.ThresholdDirection.Rising, 
                                                                    Scope.ThresholdDirection.None, 
                                                                    Scope.ThresholdDirection.None, 
                                                                    Scope.ThresholdDirection.None, 
                                                                    Scope.ThresholdDirection.None };
                            SetTrigger(triggerproperties, 1, triggerconditions, 1, direction, null, 0, 0, 4000);
                        }
                        catch
                        {
                            error_output("Error setting scope parameters - Check driver installation and USB connection!");
                            measurement_successful = false;
                        }
                        if (!measurement_successful)
                            return scopevalues;
                        //
                        // START! 
                        // Get Data and check for activity 
                        acquisition_ms = StartDataAcquisition(number_acquisitions, timebase, 1, 50);
                        //
                        // TRIGGER! 
                        // switch back to multimeter mode to remove the supply voltage                        
                        send_data("$MM", 1);
                        if (mManualDebugOperation) send_data("$U2", 0);    //Testaufbau! da hängen wir die Spulen an U1 und U2! (mit 24V auch für 12V varianten)
                        Thread.Sleep(trigger_delay_ms);
                        int i = 0;
                        while (i < trigger_repeats)
                        {
                            send_data("$MM", 0);
                            if (mManualDebugOperation) send_data("$U2", 1);    //Testaufbau! da hängen wir die Spulen an U1 und U2! (mit 24V! auch für 12V varianten)
                            Thread.Sleep(trigger_delay_ms);
                            send_data("$MM", 1);
                            if (mManualDebugOperation) send_data("$U2", 0);    //Testaufbau! da hängen wir die Spulen an U1 und U2! (mit 24V! auch für 12V varianten)
                            Thread.Sleep(trigger_delay_ms);
                            i++;
                        }
                        //
                        // READOUT! 
                        // Get Data and check for activity 
                        FinishDataAcquisition(number_acquisitions, timebase, 1, numberAvg);
                    }
                    break;
                case 'B':
                    {
                        // 'activate' second coil by switching the resistance meter to the first coil, so the second coil is free to be switched to VS Power output.
                        send_data("$RC", 2);
                        if (mManualDebugOperation) send_data("$U2", 0);
                        if (mManualDebugOperation) send_data("$U1", 1);
                        Thread.Sleep(trigger_delay_ms);
                        // Applying cope parameters for second coil
                        try
                        {
                            //Set scope ranges
                            scope_limits(RangeA, RangeB, RangeC, RangeD);
                            //Calculate ADC Wert of 50% of supply voltage
                            short input_range_mv = (short)(1000 * multiplier_b);  // in millivolt
                            short trigger_level_mv = levelmv;  // in millivolt
                            short triggerleveladc = (short)((trigger_level_mv * Scope.MaxValue) / input_range_mv);
                            //Set scope to trigger on Calculated ADC value and Trigger to Channel B, rising edge
                            Scope.TriggerChannelProperties[] triggerproperties = new Scope.TriggerChannelProperties[] { 
                                new Scope.TriggerChannelProperties( triggerleveladc, 
                                                                    2560,//100, 
                                                                    triggerleveladc, 
                                                                    2560,//100, 
                                                                    (trigger_swap==0) ?Scope.Channel.ChannelB: Scope.Channel.ChannelA,
                                                                    Scope.ThresholdMode.Level) };
                            Scope.TriggerConditions[] triggerconditions = new Scope.TriggerConditions[] { 
                                new Scope.TriggerConditions(        (trigger_swap==0) ? Scope.TriggerState.DontCare:Scope.TriggerState.True, 
                                                                    (trigger_swap==0) ? Scope.TriggerState.True:Scope.TriggerState.DontCare, 
                                                                    Scope.TriggerState.DontCare, 
                                                                    Scope.TriggerState.DontCare, 
                                                                    Scope.TriggerState.DontCare, 
                                                                    Scope.TriggerState.DontCare, 
                                                                    Scope.TriggerState.DontCare) };
                            Scope.ThresholdDirection[] direction = new Scope.ThresholdDirection[] { 
                                                                    Scope.ThresholdDirection.Rising, 
                                                                    Scope.ThresholdDirection.Rising, 
                                                                    Scope.ThresholdDirection.None, 
                                                                    Scope.ThresholdDirection.None, 
                                                                    Scope.ThresholdDirection.None, 
                                                                    Scope.ThresholdDirection.None };
                            SetTrigger(triggerproperties, 1, triggerconditions, 1, direction, null, 0, 0, 4000);
                        }
                        catch
                        {
                            error_output("Error setting scope parameters - Check driver installation and USB connection!");
                            measurement_successful = false;
                        }
                        if (!measurement_successful)
                            return scopevalues;
                        //
                        // START! 
                        // Get Data and check for activity 
                        acquisition_ms = StartDataAcquisition(number_acquisitions, timebase, 1, 50);
                        //
                        // TRIGGER! 
                        // switch back to multimeter mode to remove the supply voltage
                        send_data("$MM", 1);
                        if (mManualDebugOperation) send_data("$U1", 0);    //Testaufbau! da hängen wir die Spulen an U1 und U2! (mit 24V! auch für 12V varianten)
                        Thread.Sleep(trigger_delay_ms);
                        int i = 0;
                        while (i < trigger_repeats)
                        {
                            send_data("$MM", 0);
                            if (mManualDebugOperation) send_data("$U1", 1);    //Testaufbau! da hängen wir die Spulen an U1 und U2! (mit 24V! auch für 12V varianten)
                            Thread.Sleep(trigger_delay_ms);
                            send_data("$MM", 1);
                            if (mManualDebugOperation) send_data("$U1", 0);    //Testaufbau! da hängen wir die Spulen an U1 und U2! (mit 24V! auch für 12V varianten)
                            Thread.Sleep(trigger_delay_ms);
                            i++;
                        }
                        //
                        // READOUT! 
                        // Get Data and check for activity 
                        FinishDataAcquisition(number_acquisitions, timebase, 1, numberAvg);
                    }
                    break;
            }
            double raw_avg_a, raw_avg_b, raw_avg_c, raw_avg_d;
            EvaluateDataAcquisition(number_acquisitions, numberAvg, out raw_avg_a, out raw_avg_b, out raw_avg_c, out raw_avg_d);
            //Calculate mean value and write to variables structure
            scopevalues.CH1 = (raw_avg_a / Scope.MaxValue * multiplier_a);
            scopevalues.CH2 = (raw_avg_b / Scope.MaxValue * multiplier_b);
            scopevalues.CH3 = (raw_avg_c / Scope.MaxValue * multiplier_c);
            scopevalues.CH4 = (raw_avg_d / Scope.MaxValue * multiplier_d);

            if (debugit.Checked == true)
            {
                //DEBUG PLOT
                plotwindow.Visible = true;
                //generate data vectors for linearity plot
                for (int i2 = 0; i2 < number_acquisitions; i2++)
                {
                    //add points to x and y vector
                    c1value[i2] = (float)((float)maxPinned[0].Target[i2] / Scope.MaxValue * multiplier_a);
                    c2value[i2] = (float)((float)maxPinned[1].Target[i2] / Scope.MaxValue * multiplier_b);
                    c3value[i2] = (float)((float)maxPinned[2].Target[i2] / Scope.MaxValue * multiplier_c);
                    c4value[i2] = (float)((float)maxPinned[3].Target[i2] / Scope.MaxValue * multiplier_d);
                    c1list.Add((float)i2, (float)c1value[i2]);
                    c2list.Add((float)i2, (float)c2value[i2]);
                    c3list.Add((float)i2, (float)c3value[i2]);
                    c4list.Add((float)i2, (float)c4value[i2]);
                }

                //Show plot and scale axis
                plotwindow.GraphPane.AddCurve("CH1", c1list, Color.Blue);
                plotwindow.GraphPane.AddCurve("CH2", c2list, Color.Aqua);
                plotwindow.GraphPane.AddCurve("CH3", c3list, Color.Green);
                plotwindow.GraphPane.AddCurve("CH4", c4list, Color.Red);
                plotwindow.GraphPane.XAxis.Scale.Min = (0);
                plotwindow.GraphPane.XAxis.Scale.Max = (number_acquisitions);
                plotwindow.GraphPane.YAxis.Scale.Min = (0);
                plotwindow.GraphPane.YAxis.Scale.Max = (20);
                plotwindow.AxisChange();
                plotwindow.GraphPane.Title.IsVisible = false;
                plotwindow.GraphPane.XAxis.MajorGrid.IsVisible = true;
                plotwindow.GraphPane.YAxis.MajorGrid.IsVisible = true;
                plotwindow.Refresh();
                Thread.Sleep(debug_view_time);
            }
            return scopevalues;
        }
        private voltagearray resistance_measurement()               //Mesurement routine for PVEO resistance check
        {
            double resistance;
            string resistance_string;
            int numcoils = 2;
            voltagearray resistance_values;
            resistance_string = "";
            resistance = 0;
            resistance_values.CH1 = 0;
            resistance_values.CH2 = 0;
            resistance_values.CH3 = 0;
            resistance_values.CH4 = 0;

            double actual_temperature = GetTemperature();// °C 
            double temperature_coefficient = 0.00395; //~ 0,395% according to Electrisola

            for (int i = 1; i <= numcoils; i++)
            {
                send_data("$RC", i);
                if (mManualDebugOperation) MessageBox.Show("Connect Multimeter to coil " + ((i == 1) ? "SV1 (Pin A)" : "SV3 (Pin B)"));
                Thread.Sleep(controller_answer_wait);
                try
                {
                    //Read the resistance value
                    serialPortMilliohmmeter.WriteLine(":READ?");
                    Thread.Sleep(resistance_meter_wait);
                    resistance_string = (serialPortMilliohmmeter.ReadExisting());
                    //Format String into number
                    string[] resultStrings = resistance_string.Split(new Char[] { 'E' });
                    double actual_resistance = Double.Parse(resultStrings[0], ni) * Math.Pow(10, Double.Parse(resultStrings[1], ni));
                    // Resistance value needs to be compensated due to temperature influence
                    resistance = actual_resistance / (1 + temperature_coefficient * (actual_temperature - 20));
                }
                catch
                {
                    error_output("Measurement failure at Multimeter, check cables!");
                }
                if ((resistance < 0) || resistance > 1000)
                {
                    resistance = 9999;
                    error_output("Measured resistance out of Range!");
                };

                if (i == 1) resistance_values.CH1 = resistance;
                if (i == 2) resistance_values.CH2 = resistance;
                if (i == 3) resistance_values.CH3 = resistance;
                if (i == 4) resistance_values.CH4 = resistance;

            }
            return resistance_values;
        }
        //
        // Prepare Test Vectors and Initiate Measurements
        //
        private void prepare_LVDT_Test()                                                    // Prepare LVDT depending on module
        {
            switch (articlecode)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 11:
                case 29:
                case 30:
                case 31:
                case 32:
                case 33:
                    // PVEO-Module haben keine LVDT Coil !!!
                    break;
                default:
                    set_axis_position(2);
                    break;
            }
            switch (articlecode)
            {
                case 10:
                case 11:
                    //send_data("$CS" + GetLedTestCanCommand(15, 1));
                    break;
                default:
                    //Set Vi to according Voltage of 0.6V 
                    send_data("$VI", 6);
                    break;
            }
            //Perform LVDT test with 50 samples at 90Hz
            //Enable axis commands in Block data acquisition routine
            linearitytest = true;
            lvdttest(number_acq_lvdt, timebase_lvdt);
            linearitytest = false;
        }
        private voltagearray lvdttest(uint number_acquisitions, uint timebase)              // Routine to perform LVDT linearity test 
        {
            //Delete old plot
            plotwindow.GraphPane.CurveList.Clear();

            //Define local variables               
            short[] bufferA = new short[number_acquisitions];
            short[] bufferB = new short[number_acquisitions];
            float[] ulimit = new float[number_acquisitions];
            float[] llimit = new float[number_acquisitions];
            float[] xvalue = new float[number_acquisitions];
            float[] yvalue = new float[number_acquisitions];
            float[] xfiltered = new float[number_acquisitions];
            float[] yfiltered = new float[number_acquisitions];

            voltagearray scopevalues;
            timeIndisposed = 0;
            //uint _timeinterval = 0;
            //short _timeunits = 0;
            //short _oversample = 0;
            //uint _maxsamples = 0;
            //short overflow = 0;
            LVDTtest1.test_result = true;
            bool measurement_successful = true;

            //DEBUG
            for (int loop = 0; loop < number_acquisitions; loop++)
            {
                xvalue[loop] = 0;
                yvalue[loop] = 0;
            }
            //Applying scope parameters
            try
            {
                //Set scope ranges
                scope_limits(Scope.Range.Range_20V, Scope.Range.Range_20V, Scope.Range.Range_20V, Scope.Range.Range_20V);

                //Calculate ADC Wert of 50% of supply voltage
                short triggerleveladc = Convert.ToInt16(4 * 1633.7);

                //Set scope to trigger on Calculated ADC value and Trigger to Channel A, rising edge
                Scope.TriggerChannelProperties[] triggerproperties = new Scope.TriggerChannelProperties[] { new Scope.TriggerChannelProperties(triggerleveladc, 100, triggerleveladc, 100, Scope.Channel.ChannelA, Scope.ThresholdMode.Level) };
                Scope.TriggerConditions[] triggerconditions = new Scope.TriggerConditions[] { new Scope.TriggerConditions(Scope.TriggerState.True, Scope.TriggerState.DontCare, Scope.TriggerState.DontCare, Scope.TriggerState.DontCare, Scope.TriggerState.DontCare, Scope.TriggerState.DontCare, Scope.TriggerState.DontCare) };
                Scope.ThresholdDirection[] direction = new Scope.ThresholdDirection[] { Scope.ThresholdDirection.Rising, Scope.ThresholdDirection.None, Scope.ThresholdDirection.None, Scope.ThresholdDirection.None, Scope.ThresholdDirection.None, Scope.ThresholdDirection.None };
                SetTrigger(triggerproperties, 1, triggerconditions, 1, direction, null, 0, 0, 5000);
            }
            catch
            {
                error_output("Error setting scope parameters - Check driver installation and USB connection!");
                measurement_successful = false;
            }

            //clear last plot
            linearityplot.Clear();
            ulimitlist.Clear();
            llimitlist.Clear();

            //Perform test if scope is properly set
            if (measurement_successful == true)
            {

                //Data Acquisition 16 times oversampling 50% pre-trigger
                int help = BlockDataAcquisition(number_acquisitions, timebase, 16, 50);

                //generate data vectors for linearity plot
                for (int i = 0; i < number_acquisitions; i++)
                {
                    //add points to x and y vector
                    xvalue[i] = (float)((((float)maxPinned[0].Target[i] / 32767 * 20) - 4) * 2.75);
                    yvalue[i] = (float)((float)maxPinned[1].Target[i] / 32767 * 20);

                }

                //Filter measured curves
                xfiltered = low_pass_filter(xvalue, (float)-6);
                yfiltered = low_pass_filter(yvalue, (float)3.75);

                //xfiltered = xvalue;
                //yfiltered = yvalue;

                for (int loop = 0; loop < number_acquisitions; loop++)
                {
                    //generate limit curves
                    ulimit[loop] = (float)((float)(xfiltered[loop] * (-1) * LVDTtest1.gradient) + LVDTtest1.delta_ulimit + LVDTtest1.offset);
                    llimit[loop] = (float)((float)(xfiltered[loop] * (-1) * LVDTtest1.gradient) - LVDTtest1.delta_llimit + LVDTtest1.offset);

                    //Create pointlists for diagram
                    ulimitlist.Add((float)xfiltered[loop], ulimit[loop]);
                    llimitlist.Add((float)xfiltered[loop], llimit[loop]);
                    linearityplot.Add((float)xfiltered[loop], (float)yfiltered[loop]);

                    //Check for Errors in curve for relevant range
                    if ((xfiltered[loop] > (-5)) && (xfiltered[loop] < 5))

                        if (yfiltered[loop] > ulimit[loop])
                        {
                            LVDTtest1.test_result = false;
                        }
                    if (yfiltered[loop] < llimit[loop])
                    {
                        LVDTtest1.test_result = false;
                    }
                }


                //Show plot and scale axis
                plotwindow.GraphPane.AddCurve("LVDT", linearityplot, Color.Blue);
                plotwindow.GraphPane.AddCurve("upper limit", ulimitlist, Color.Black);
                plotwindow.GraphPane.AddCurve("lower limit", llimitlist, Color.Black);

                plotwindow.GraphPane.Title.IsVisible = false;
                plotwindow.GraphPane.XAxis.Title.Text = ("position");
                plotwindow.GraphPane.YAxis.Title.Text = ("spoolsignal");
                plotwindow.GraphPane.XAxis.Scale.Min = (-5);
                plotwindow.GraphPane.XAxis.Scale.Max = (5);
                plotwindow.GraphPane.YAxis.Scale.Min = (0);
                plotwindow.GraphPane.YAxis.Scale.Max = (5.5);
                plotwindow.GraphPane.XAxis.MajorGrid.IsVisible = true;
                plotwindow.GraphPane.YAxis.MajorGrid.IsVisible = true;
                plotwindow.AxisChange();
                plotwindow.Refresh();

            }
            else
            {
                error_output("LVDT lineartity measurement failed !");
                LVDTtest1.test_result = false;
            }

            scopevalues.CH1 = 1;
            scopevalues.CH2 = 1;
            scopevalues.CH3 = 1;
            scopevalues.CH4 = 1;

            return scopevalues;
        }
        private void test_generic(string test, string testType = "PVEA", char coil = ' ')   // Measure the Data from Valve Coils and LVDT feedback for all generic Tests 1..7
        {
            // Scope-Channels:  A               B               C               D
            // $SI1:            SV1,            SV3,            SV2,            SV4
            // $SI2:            Linear Axis,    Spool,          LED RED,        LED GREEN
            // $SI3:            DIR_A,          DIR_B,          Solenoid Enable,Supply Voltage Monitor

            // Obige Werte sind Default- Belegungen. Abhängig vom Modultyp sind die Eingänge jedoch unterschiedlich verschaltet:
            // Type 18:
            // $SI2:            Linear Axis,    Error,          LED RED,        LED Green        
            // $SI3:            DIR_A,          DIR_B,          Spool,          Supply Voltage Monitor
            // 

            if (debugit.Checked) error_output(test);
            if (test == "LED_INIT")
            {

                send_data("$SI", 2);//Set Scope to measure Spool voltage and LED voltages
                //Read coilvoltages back
                scope_DC(number_acq_DC, timebase_DC, Scope.Range.Range_20V, Scope.Range.Range_20V, Scope.Range.Range_20V, Scope.Range.Range_20V);
                //MessageBox.Show(scopevalues.CH3.ToString());
                double led_red_voltage = scopevalues.CH3;
                double led_green_voltage = scopevalues.CH4;
                led_color(led_red_voltage, led_green_voltage, true);

                return;
            }
            //Test coil measurements if required
            if ((testList[test].SV1.perform_test == true) || (testList[test].SV3.perform_test == true) || (testList[test].SV2.perform_test == true) || (testList[test].SV4.perform_test == true))
            {
                //Set Scope to measure Coilvoltages
                send_data("$SI", 1);//SI-SET SCOPE CHANNL1 

                if (testType == "PVEA" || testType == "PVEH" || testType == "-CI" || (testType.IndexOf("-CC") != -1))
                    scope_DC(number_acq_DC, timebase_DC, Scope.Range.Range_20V, Scope.Range.Range_20V, Scope.Range.Range_20V, Scope.Range.Range_20V);
                else if ((testType == "PVEO")||(testType == "PVEC"))
                    scope_SR(number_acq_SR, timebase_SR, Scope.Range.Range_20V, Scope.Range.Range_20V, Scope.Range.Range_20V, Scope.Range.Range_20V, coil, 50, trigger_level_mv);


                if (testType == "PVEH")
                {
                    // Series 7 PVEH
                  
                    
                    testList[test].SV1.value = scopevalues.CH1 < 0 ? -scopevalues.CH1 : scopevalues.CH1;
                    testList[test].SV2.value = scopevalues.CH2 < 0 ? -scopevalues.CH2 : scopevalues.CH2;
                    testList[test].SV3.value = scopevalues.CH3 < 0 ? -scopevalues.CH3 : scopevalues.CH3;
                    testList[test].SV4.value = scopevalues.CH4 < 0 ? -scopevalues.CH4 : scopevalues.CH4;
                }
                else
                {
                    // Series 6: Sensor BOX measures second coil (SV3) on channel 2&&PVED-CC
                    if (testType.IndexOf("-CC") != -1)
                    {
                        TYPE = testType;
                        // Series 7: PVED-CC
                        testList[test].SV1.value = scopevalues.CH1;
                        testList[test].SV3.value = scopevalues.CH3;
                        testList[test].SV2.value = scopevalues.CH2;
                        testList[test].SV4.value = scopevalues.CH4;
                      /*  if (test == "Test 1")
                        {
                            if ((testList[test].SV1.value > testList[test].SV1.ulimit) || (testList[test].SV1.value < testList[test].SV1.llimit)) testList[test].SV1.test_result = false; else testList[test].SV1.test_result = true;
                            if ((testList[test].SV3.value > testList[test].SV3.ulimit) || (testList[test].SV3.value < testList[test].SV3.llimit)) testList[test].SV3.test_result = false; else testList[test].SV3.test_result = true;
                            if (S7_4_Coil == true)
                            {
                                if ((testList[test].SV2.value > testList[test].SV2.ulimit) || (testList[test].SV2.value < testList[test].SV2.llimit)) testList[test].SV2.test_result = false; else testList[test].SV2.test_result = true;
                                if ((testList[test].SV4.value > testList[test].SV4.ulimit) || (testList[test].SV4.value < testList[test].SV4.llimit)) testList[test].SV4.test_result = false; else testList[test].SV4.test_result = true;
                            }


                        }*/
                       /* if (test == "Test 2")
                        {
                            if ((testList[test].SV1.value - testList[test].SV3.value > 1.2) && (testList[test].SV2.value - testList[test].SV4.value > 1.2))
                            {
                                testList[test].SV1.test_result = true;
                                testList[test].SV2.test_result = true;
                                testList[test].SV3.test_result = true;
                                testList[test].SV4.test_result = true;
                            }
                            else
                            {
                                testList[test].SV1.test_result = false;
                                testList[test].SV2.test_result = false;
                                testList[test].SV3.test_result = false;
                                testList[test].SV4.test_result = false;

                            }
                        
                        
                        
                        }*/
                      /*  if (test == "Test 3")
                        {
                            if ((testList[test].SV3.value - testList[test].SV1.value > 1.2) && (testList[test].SV4.value - testList[test].SV2.value > 1.2))
                            {
                                testList[test].SV1.test_result = true;
                                testList[test].SV2.test_result = true;
                                testList[test].SV3.test_result = true;
                                testList[test].SV4.test_result = true;
                            }
                            else
                            {
                                testList[test].SV1.test_result = false;
                                testList[test].SV2.test_result = false;
                                testList[test].SV3.test_result = false;
                                testList[test].SV4.test_result = false;

                            }
                            


                        }*/
                    /*    if (test == "Test 4")
                        {
                            if ((testList[test].SV1.value > testList[test].SV1.ulimit) || (testList[test].SV1.value < testList[test].SV1.llimit)) testList[test].SV1.test_result = false; else testList[test].SV1.test_result = true;
                            if ((testList[test].SV3.value > testList[test].SV3.ulimit) || (testList[test].SV3.value < testList[test].SV3.llimit)) testList[test].SV3.test_result = false; else testList[test].SV3.test_result = true;
                            if (S7_4_Coil == true)
                            {
                                if ((testList[test].SV2.value > testList[test].SV2.ulimit) || (testList[test].SV2.value < testList[test].SV2.llimit)) testList[test].SV2.test_result = false; else testList[test].SV2.test_result = true;
                                if ((testList[test].SV4.value > testList[test].SV4.ulimit) || (testList[test].SV4.value < testList[test].SV4.llimit)) testList[test].SV4.test_result = false; else testList[test].SV4.test_result = true;
                            }


                        }   */
                        
                        
                        /*  if ((testList[test].SV1.value > testList[test].SV1.ulimit) || (testList[test].SV1.value < testList[test].SV1.llimit)) testList[test].SV1.test_result = false; else testList[test].SV1.test_result = true;
                            if ((testList[test].SV3.value > testList[test].SV3.ulimit) || (testList[test].SV3.value < testList[test].SV3.llimit)) testList[test].SV3.test_result = false; else testList[test].SV3.test_result = true;
                            if (S7_4_Coil == true)
                            {
                                if ((testList[test].SV2.value > testList[test].SV2.ulimit) || (testList[test].SV2.value < testList[test].SV2.llimit)) testList[test].SV2.test_result = false; else testList[test].SV2.test_result = true;
                                if ((testList[test].SV4.value > testList[test].SV4.ulimit) || (testList[test].SV4.value < testList[test].SV4.llimit)) testList[test].SV4.test_result = false; else testList[test].SV4.test_result = true;
                            }*/
                        /*    int ffx;
                            ffx = 0;
                        while (((testList[test].SV1.test_result == false) || (testList[test].SV3.test_result == false))&&(ffx<15))   
                       {
                           ffx = ffx + 1;
                            if ((testList[test].SV1.test_result == false) || (testList[test].SV3.test_result == false))
                            {
                           // "Test 2"
                        if(test=="Test 2")
                         {
                             send_data("$CA" + GetAuxiliaryCanCommand("pvedcc1", 50 + (articlecode - 10) * 50));
                            send_data("$CA" + GetAuxiliaryCanCommand("pvedcc3", 50 + (articlecode - 10) * 50));
                         
                         }
                              if(test=="Test 3")
                         {
                             send_data("$CA" + GetAuxiliaryCanCommand("pvedcc1", 50 + (articlecode - 10) * 50));
                                  send_data("$CA" + GetAuxiliaryCanCommand("pvedcc4", 50 + (articlecode - 10) * 50));
                         
                         } 
                         testList[test].SV1.value = scopevalues.CH1;
                        testList[test].SV3.value = scopevalues.CH3;
                        testList[test].SV2.value = scopevalues.CH2;
                        testList[test].SV4.value = scopevalues.CH4;
                      //  MessageBox.Show("SV1: " + testList[test].SV1.value.ToString());
                         if ((testList[test].SV1.value > testList[test].SV1.ulimit) || (testList[test].SV1.value < testList[test].SV1.llimit)) testList[test].SV1.test_result = false; else testList[test].SV1.test_result = true;
                        if ((testList[test].SV3.value > testList[test].SV3.ulimit) || (testList[test].SV3.value < testList[test].SV3.llimit)) testList[test].SV3.test_result = false; else testList[test].SV3.test_result = true;
                        if (S7_4_Coil == true)
                        {
                            if ((testList[test].SV2.value > testList[test].SV2.ulimit) || (testList[test].SV2.value < testList[test].SV2.llimit)) testList[test].SV2.test_result = false; else testList[test].SV2.test_result = true;
                            if ((testList[test].SV4.value > testList[test].SV4.ulimit) || (testList[test].SV4.value < testList[test].SV4.llimit)) testList[test].SV4.test_result = false; else testList[test].SV4.test_result = true;
                        }  
                          
                           }
                          
                       
                       }*/
                        

                    }
                    else
                    {
                        testList[test].SV1.value = scopevalues.CH1;
                        testList[test].SV3.value = scopevalues.CH2;
                        testList[test].SV2.value = scopevalues.CH3;
                        testList[test].SV4.value = scopevalues.CH4;
                        if ((testList[test].SV1.value > testList[test].SV1.ulimit) || (testList[test].SV1.value < testList[test].SV1.llimit)) testList[test].SV1.test_result = false; else testList[test].SV1.test_result = true;
                        if ((testList[test].SV3.value > testList[test].SV3.ulimit) || (testList[test].SV3.value < testList[test].SV3.llimit)) testList[test].SV3.test_result = false; else testList[test].SV3.test_result = true;
                        int ffx;
                        ffx = 0;
                    while (((testList[test].SV1.test_result == false) || (testList[test].SV3.test_result == false)) && (ffx < 3))
                    {
                        scope_SR(number_acq_SR, timebase_SR, Scope.Range.Range_20V, Scope.Range.Range_20V, Scope.Range.Range_20V, Scope.Range.Range_20V, coil, 50, trigger_level_mv);
                        testList[test].SV1.value = scopevalues.CH1;
                        testList[test].SV3.value = scopevalues.CH2;
                        testList[test].SV2.value = scopevalues.CH3;
                        testList[test].SV4.value = scopevalues.CH4;
                        if ((testList[test].SV1.value > testList[test].SV1.ulimit) || (testList[test].SV1.value < testList[test].SV1.llimit)) testList[test].SV1.test_result = false; else testList[test].SV1.test_result = true;
                        if ((testList[test].SV3.value > testList[test].SV3.ulimit) || (testList[test].SV3.value < testList[test].SV3.llimit)) testList[test].SV3.test_result = false; else testList[test].SV3.test_result = true;
                        ffx++;
                    }
                   
                    }
                   
                }
           
           
           
           }

            //Test spool and LED measurements if required


            if ((testList[test].Spool.perform_test == true) || (testList[test].LedR.perform_test == true) || (testList[test].DrvEnable.perform_test == true))
            {
                /*
                string colour = "";
                int retry = 0;
                while(retry < 1)
                {
                    retry ++;*/
                //Set Scope to measure Spool voltage and LED voltages
                send_data("$SI", 2);//SET SCPO CHANNEL 2

                if (testType == "PVEO")
                {   // activate the right coil via RC and $MM0
                    if (coil == 'A')
                    {
                        send_data("$RC", 2);//SET MUL CHANNEL 2
                        if (mManualDebugOperation) send_data("$U1", 1); // SET BATTERY1 24V
                    }
                    if (coil == 'B')
                    {
                        send_data("$RC", 1);//SET MUL CHANNEL 1
                        if (mManualDebugOperation) send_data("$U2", 1); // SET BATTERY2 24V
                    }
                    send_data("$MM", 0);//SET SPS NO MUL MODE
                }

                //Read coilvoltages back
                scope_DC(number_acq_DC, timebase_DC, Scope.Range.Range_20V, Scope.Range.Range_50V, Scope.Range.Range_20V, Scope.Range.Range_20V);
              /*  if (testType.IndexOf("-CC") != -1)
                //if (articlecode == 10 || articlecode == 11) // CAN Variants have digitial readout
                {
                    // read CAN Message feedback
                  //  send_data("$CR");
                    Thread.Sleep(controller_answer_wait); // wait for data to be received 
                    testList[test].Spool.value = received_value;
                }*/
            
                if ((testType == "-CI")||(testType.IndexOf("-CC") != -1))
                //if (articlecode == 10 || articlecode == 11) // CAN Variants have digitial readout
                {
                    // read CAN Message feedback
                    if (testType == "-CI")
                    {
                        pause = 0;
                        send_data("$CR");
                        Thread.Sleep(controller_answer_wait); // wait for data to be received 
                        Delay(200);
                      //  MessageBox.Show("Wait CI");
                        /* do
                        {
                            Thread.Sleep(controller_answer_wait);
                        } while (pause == 0);*/
                        // MessageBox.Show(received_value.ToString());
                     //   testList[test].Spool.value = ci_value;
                    }
                    int px;
                    px = 0;
                    if ((testType.IndexOf("-CC") != -1)&&(testList[test].Spool.perform_test == true))
                {
                    send_data("$CR");
                    Thread.Sleep(controller_answer_wait); // wait for data to be received 
                    Delay(200);
                    testList[test].Spool.value = cc_value;
                  //  MessageBox.Show("Frist pos "+cc_value.ToString());
                    if ((testList[test].Spool.value > testList[test].Spool.ulimit) || (testList[test].Spool.value < testList[test].Spool.llimit)) testList[test].Spool.test_result = false; else testList[test].Spool.test_result = true;
                    while( (testList[test].Spool.test_result ==false)&&(px<3))
                   {
                       send_data("$CA" + GetAuxiliaryCanCommand("pvedcc5"));//CAN MESSAGE
                      // testtype = "-CC5";
                       send_data("$CR");
                       Thread.Sleep(controller_answer_wait); // wait for data to be received 
                       Delay(200);
                       testList[test].Spool.value = cc_value;
                     //  MessageBox.Show(test+" "+cc_value.ToString());
                        if ((testList[test].Spool.value > testList[test].Spool.ulimit) || (testList[test].Spool.value < testList[test].Spool.llimit)) testList[test].Spool.test_result = false; else testList[test].Spool.test_result = true;
                        px = px + 1;
                    }
                    // MessageBox.Show(cc_value.ToString());
               
                
                }
               
                }
                else // use Scope Value
                {
                    switch (articlecode)
                    {
                        case 12:
                        case 13:
                        case 14:
                        case 15:
                        case 16:
                        case 17:
                        case 18:
                        case 21:
                        case 20:
                        case 22:
                        case 23:
                        case 24:
                        case 25:
                        case 26:
                        case 27:
                        case 28:
                        case 34:    //PVEH_U
                        case 35:    //PVEH_U
                        case 36:    //PVEH_U
                            // rewire Spool input to Error
                            testList[test].DrvEnable.value = scopevalues.CH2;
                            break;
                        default:
                            testList[test].Spool.value = scopevalues.CH2;
                            break;
                    }
                }
                string colour = "";
                double led_red_voltage;
                double led_green_voltage;

                if (mCameraLedTest)
                {
                    capture();
                    sw2.Write("color camer " + hue.ToString() + "\r\n");
                    if (hue > 140 && hue < 180)
                    {
                        testList[test].LedR.value = 0;
                        testList[test].LedG.value = 1;
                    }
                    if (hue > 280 && hue < 330)
                    {
                        testList[test].LedR.value = 1;
                        testList[test].LedG.value = 0;
                    }
                }
                else // standard LED Test
                {
                    led_red_voltage = scopevalues.CH3;
                    led_green_voltage = scopevalues.CH4;

                 
                    if (S7_2_Coil || S7_4_Coil)
                    {
                        if (debugit.Checked)
                        {
                            error_output(" red   " + scopevalues.CH3);
                            error_output(" green " + scopevalues.CH4);
                            error_output(" minred   " + scopeminvalues.CH3);
                            error_output(" mingreen " + scopeminvalues.CH4);
                        }
                        led_red_voltage = scopeminvalues.CH3;
                        led_green_voltage = scopeminvalues.CH4;
                    }
                    sw2.Write("color redvol " + led_red_voltage.ToString() + "\r\n");
                    sw2.Write("color greenvol " + led_green_voltage.ToString() + "\r\n");
                  //  if ((test == "Test 3")||(test == "Test 4")|| (test == "Test 1")|| (test == "Test 2"))
                   // { MessageBox.Show(led_red_voltage.ToString()+"  "+ led_green_voltage.ToString()); }
                        colour = led_color(led_red_voltage, led_green_voltage);
                    testList[test].LedR.value = led_red_voltage;
                    testList[test].LedG.value = led_green_voltage;
                }
                if (S7_2_Coil || S7_4_Coil) // eventually re-do the test if we have a series 7 Module that might blink at center position.
                {
                    if (colour != "red" && colour != "green") // re-do the test: we saw nothing possibly due to blinking..
                    {
                        if (debugit.Checked)
                            error_output("re-check after " + half_flash_period + "ms due to potential blinking of S7 module");
                        Thread.Sleep(half_flash_period);
                        scope_DC(number_acq_DC, timebase_DC, Scope.Range.Range_20V, Scope.Range.Range_50V, Scope.Range.Range_20V, Scope.Range.Range_20V);
                        led_red_voltage = scopevalues.CH3;
                        led_green_voltage = scopevalues.CH4;
                        if (debugit.Checked)
                        {
                            error_output(" >red   " + scopevalues.CH3);
                            error_output(" >green " + scopevalues.CH4);
                            error_output(" >minred   " + scopeminvalues.CH3);
                            error_output(" >mingreen " + scopeminvalues.CH4);
                        }
                        sw2.Write("retest1 color redvol " + led_red_voltage.ToString() + "\r\n");
                        sw2.Write("color greenvol " + led_green_voltage.ToString() + "\r\n");
                       colour= led_color(led_red_voltage, led_green_voltage);
                       // if (led_color(testList["Test " + i.ToString()].LedR.value, testList["Test " + i.ToString()].LedG.value) == testList["Test " + i.ToString()].LedR.target) testList["Test " + i.ToString()].LedR.test_result = true; else testList["Test " + i.ToString()].LedR.test_result = false;
                       // if (led_color(testList["Test " + i.ToString()].LedR.value, testList["Test " + i.ToString()].LedG.value) == testList["Test " + i.ToString()].LedG.target) testList["Test " + i.ToString()].LedG.test_result = true; else testList["Test " + i.ToString()].LedG.test_result = false;
                        testList[test].LedR.value = led_red_voltage;
                        testList[test].LedG.value = led_green_voltage;
                      //  if (led_color(testList[test].LedR.value, testList[test].LedG.value) == testList[test].LedR.target) testList[test].LedR.test_result = true; else testList[test].LedR.test_result = false;
                       // if (led_color(testList[test].LedR.value, testList[test].LedG.value) == testList[test].LedG.target) testList[test].LedG.test_result = true; else testList[test].LedG.test_result = false;
                    }
                 /*   if (colour != "red" && colour != "green") // re-do the test: we saw nothing possibly due to blinking..
                    {
                        if (debugit.Checked)
                            error_output("2.re-check after " + half_flash_period + "ms due to potential blinking of S7 module");
                        Thread.Sleep(half_flash_period);
                        scope_DC(number_acq_DC, timebase_DC, Scope.Range.Range_20V, Scope.Range.Range_50V, Scope.Range.Range_20V, Scope.Range.Range_20V);
                        led_red_voltage = scopevalues.CH3;
                        led_green_voltage = scopevalues.CH4;
                        if (debugit.Checked)
                        {
                            error_output(" >red   " + scopevalues.CH3);
                            error_output(" >green " + scopevalues.CH4);
                            error_output(" >minred   " + scopeminvalues.CH3);
                            error_output(" >mingreen " + scopeminvalues.CH4);
                        }
                        sw2.Write("retest2 color redvol " + led_red_voltage.ToString() + "\r\n");
                        sw2.Write("color greenvol " + led_green_voltage.ToString() + "\r\n");
                        led_color(led_red_voltage, led_green_voltage);
                        testList[test].LedR.value = led_red_voltage;
                        testList[test].LedG.value = led_green_voltage;
                    }*/
                /*    if (colour != "red" && colour != "green") // re-do the test: we saw nothing possibly due to blinking..
                    {
                        if (debugit.Checked)
                            error_output("3.re-check after " + half_flash_period + "ms due to potential blinking of S7 module");
                        Thread.Sleep(half_flash_period);
                        scope_DC(number_acq_DC, timebase_DC, Scope.Range.Range_20V, Scope.Range.Range_50V, Scope.Range.Range_20V, Scope.Range.Range_20V);
                        led_red_voltage = scopevalues.CH3;
                        led_green_voltage = scopevalues.CH4;
                        if (debugit.Checked)
                        {
                            error_output(" >red   " + scopevalues.CH3);
                            error_output(" >green " + scopevalues.CH4);
                            error_output(" >minred   " + scopeminvalues.CH3);
                            error_output(" >mingreen " + scopeminvalues.CH4);
                        }
                        sw2.Write("retest3 color redvol " + led_red_voltage.ToString() + "\r\n");
                        sw2.Write("color greenvol " + led_green_voltage.ToString() + "\r\n");
                        led_color(led_red_voltage, led_green_voltage);
                        testList[test].LedR.value = led_red_voltage;
                        testList[test].LedG.value = led_green_voltage;
                    }*/
                }
            }

            //Test coil measurements if required
            if ((testList[test].DirA.perform_test == true) || (testList[test].DirB.perform_test == true) || (testList[test].DrvEnable.perform_test == true) || (testList[test].Spool.perform_test == true))
            {
                //Set Scope to measure Coilvoltages
                send_data("$SI", 3);

                //Read coilvoltages back
                scope_DC(number_acq_DC, timebase_DC, Scope.Range.Range_50V, Scope.Range.Range_50V, Scope.Range.Range_50V, Scope.Range.Range_50V);
                testList[test].DirA.value = scopevalues.CH1;
                testList[test].DirB.value = scopevalues.CH2;

                switch (articlecode)
                {
                    case 13:
                    case 21:
                    case 23:
                        // rewire Solenoid-Enable to Spool
                        testList[test].Spool.value = scopevalues.CH3;
                        break;
                    case 22:
                    case 24:
                        // rewire Spool input to DirA (here: overwrite the above)
                        testList[test].DirA.value = scopevalues.CH3;
                        break;
                    case 12:
                    case 14:
                    case 15:
                    case 16:
                    case 17:
                    case 18:
                    case 20:
                    case 25:
                    case 26:
                    case 27:
                    case 28:
                    case 34:    //PVEH_U
                    case 35:    //PVEH_U
                    case 36:    //PVEH_U
                        // rewired Spool input to Error
                        // so do not overwrite error values measured before..
                        break;
                    default:
                        testList[test].DrvEnable.value = scopevalues.CH3;
                        break;
                }
            }
        }
        // Set Axis position : (1)->center              S6 
        //                     (2)->5mm to Potting Side S6 
        //                     (3)->5mm to LED Side     S6 
        //                     (4)->center              S7 
        //                     (5)->5mm to Potting Side S7
        //                     (6)->5mm to LED Side     S7
        //                     (7)->retract LVDT Pin 
        private void set_axis_position(int pos)
        {
            if (last_axis_position != pos) //Achse bei PVEO egal!
            {
                if (mManualDebugOperation && !mServoExists)
                {
                    switch (pos)
                    {
                        case 1:
                            MessageBox.Show("Series 6: center position");
                            break;
                        case 2:
                            MessageBox.Show("Series 6: 5mm towards LED side");
                            break;
                        case 3:
                            MessageBox.Show("Series 6: 5mm towards potting side");
                            break;
                        case 4:
                            MessageBox.Show("Series 7: center position");
                            break;
                        case 5:
                            MessageBox.Show("Series 7: 5mm towards potting side");  // wurde bei Serie 7 getauscht..??!
                            break;
                        case 6:
                            MessageBox.Show("Series 7: 5mm towards LED side");  // wurde bei Serie 7 getauscht..??!
                            break;
                        case 7:
                            MessageBox.Show("Serie 6/7: park position");
                            break;
                        default:
                            MessageBox.Show("Test -> pos. " + pos);
                            break;
                    }
                }
                send_data("$AX", pos);//  LVDT POSITION
                last_axis_position = pos;
                Thread.Sleep(axis_position_wait);
                if (mServoExists) Thread.Sleep(axis_position_wait_servo);
            };
        }

        // prepare Tests 1 to 7:    S6 setup LVDT position      S7 setup LVDT position      Stimulus        active/LED Result       Additional Info
        // ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void Test_1() //    center position,            center                      High(retract)   SV1/green               PVEO: Stimulus on A activates SV3
        {
            string testtype = "PVEA";
            char pveocoil = ' ';
            switch (articlecode)
            {
                case 1:
                case 3:
                case 4:
                case 5:
                case 37:
                case 38:
                case 40:
                    if (P1240099.Checked == false)
                    {
                        send_data("$VS", 120);  // 12V(9V) coil type
                        testtype = "PVEO";
                        pveocoil = 'A';
                        sw2.Write(testtype + " " + pveocoil + "\r\n");
                        set_axis_position(1);
                    }
                        if (P1240099.Checked == true)
                    {
                        send_data("$VS", 240);  // 12V(9V) coil type
                        testtype = "PVEO";
                        pveocoil = 'A';
                        sw2.Write(testtype + " " + pveocoil + "\r\n");
                        set_axis_position(1);
                    }
                        if (P1240112.Checked == true)
                        {
                            send_data("$VS", 120);  // 12V(9V) coil type
                            testtype = "PVEC";
                            pveocoil = 'A';
                            sw2.Write(testtype + " " + pveocoil + "\r\n");
                            set_axis_position(1);
                        } 
                  
                    
                    break;

                case 29:    //12V PVEO-DI
                    send_data("$VS", 120);  // 12V(9V) coil type
                    testtype = "PVEO";
                    pveocoil = 'A';
                    sw2.Write(testtype + " " + pveocoil + "\r\n");
                    set_axis_position(4);
                    break;

                case 2:
                case 31:
                case 32:
                case 33:
                case 39:
                    if (P1240090.Checked == false)
                    {
                        send_data("$VS", 240);  // 24V coil type
                        testtype = "PVEO";
                        pveocoil = 'A';
                        sw2.Write(testtype + " " + pveocoil + "\r\n");
                        set_axis_position(1);
                    }
                    if (P1240090.Checked == true)
                    {
                        send_data("$VS", 120);  // 12V coil type
                        testtype = "PVEO";
                        pveocoil = 'A';
                        sw2.Write(testtype + " " + pveocoil + "\r\n");
                        set_axis_position(1);
                    }
                    if (P1240113.Checked == true)
                    {
                        send_data("$VS", 240);  // 12V(9V) coil type
                        testtype = "PVEC";
                        pveocoil = 'A';
                        sw2.Write(testtype + " " + pveocoil + "\r\n");
                        set_axis_position(1);
                    }  
                 
                    break;

                case 30:    //24V PVEO-DI
                    send_data("$VS", 240);  // 24V coil type
                    testtype = "PVEO";
                    pveocoil = 'A';
                    sw2.Write(testtype + " " + pveocoil + "\r\n");
                    set_axis_position(4);
                    break;

                case 6:
                    send_data("$VI", 120);
                    send_data("$VF", 240);
                    set_axis_position(1);
                    break;
                case 7:
                case 8:
                case 9:
                    error_output("Test 1 not for S6 PVE16 Float versions!");
                    break;
                case 10:
                //Set valve to 50% retract
                    if ((P12401010.Checked == false)&&(P12401020.Checked == false))//124-0054
                    {
                        //MessageBox.Show("CA1: " + GetAuxiliaryCanCommand("retract", 50 + (articlecode - 10) * 50));
                     //   set_axis_position(1);
                      //  Delay(3000);
                        send_data("$CA" + GetAuxiliaryCanCommand("retract", 50 + (articlecode - 10) * 50));//CAN MESSAGE
                       // MessageBox.Show(GetAuxiliaryCanCommand("retract", 50 + (articlecode - 10) * 50));
                        testtype = "-CI";
                        sw2.Write(testtype + " " + pveocoil + "\r\n");
                        set_axis_position(1);
                    }
                    if ((P12401010.Checked == true)||(P12401020.Checked == true))//124-0101-0
                    {
                        set_axis_position(4);
                     Delay(500);
                        send_data("$CA" + GetAuxiliaryCanCommand("pvedcc1", 50 + (articlecode - 10) * 50));//CAN MESSAGE
                        testtype = "-CC1";
                    
                    
                    }
                    break;
                case 11:
                    //Set valve to 100% retract                             case 11 adds 50 below here
                   if(P12401090.Checked==false)
                   {
                       // MessageBox.Show("CA1: " + GetAuxiliaryCanCommand("retract", 50 + (articlecode - 10) * 50));
                        send_data("$CA" + GetAuxiliaryCanCommand("retract", 50 + (articlecode - 10) * 50));//CAN MESSAGE
                    testtype = "-CI";
                    sw2.Write(testtype + " " + pveocoil + "\r\n");
                    set_axis_position(1);
            }
                   if (P12401090.Checked == true)//124-0109-0
                   {
                       send_data("$VS", 120);
                       Delay(500);
                       send_data("$CA" + GetAuxiliaryCanCommand("retract", 50 + (articlecode - 10) * 50));//CAN MESSAGE
                       testtype = "-CI";
                       sw2.Write(testtype + " " + pveocoil + "\r\n");
                       set_axis_position(1);
                   }      
            
            break;
                case 17:
            if (P12401020.Checked == false)// PVEH_DI
            {
                testtype = "PVEH";
                send_data("$VI", 180);
                send_data("$VF", 0);
                sw2.Write(testtype + " " + pveocoil + "\r\n");
                set_axis_position(4); // Pos.4 für S7 entspricht Pos.1 für S6 
            }
          /*  if (P12401020.Checked == true)// PVED_CC      
            {
                set_axis_position(4);
                Delay(300);
                send_data("$CA" + GetAuxiliaryCanCommand("pvedcc1", 50 + (articlecode - 10) * 50));//CAN MESSAGE
                testtype = "-CC1";
               // sw2.Write(testtype + " " + pveocoil + "\r\n");
            
            
            }*/
                break;
                case 12:    // PVEH
                case 13:    // PVEH_NP_SP_F
                case 14:    // PVEH_S
                case 15:    // PVEH_S
                case 16:    // PVEH_S
                   // PVEH_DI
                case 18:    // PVEH_DI
                case 21:    // PVEH_F
                case 22:    // PVEH_NP
                case 23:    // PVEH_SP
                case 34:    // PVEH_S_U
                case 35:    // PVEH_S_U
                case 36:    // PVEH_S_U
                    testtype = "PVEH";
                    send_data("$VI", 180);
                    send_data("$VF", 0);
                    sw2.Write(testtype + " " + pveocoil + "\r\n");
                    set_axis_position(4); // Pos.4 für S7 entspricht Pos.1 für S6 
                    break;
                case 20:    // S7 PVEA (Deutsch 4)
                case 24:    // S7 PVEA_NP (Deutsch 6)
                case 25:    // S7 PVEA (AMP 4)
                case 26:    // S7 PVEM (Hirschmann)
                case 27:    // S7 PVEA_DI (2x AMP 4)
                case 28:    // S7_PVEA_DI (2x Deutsch 4)
                    send_data("$VI", 180);
                    send_data("$VF", 0);
                    sw2.Write(testtype + " " + pveocoil + "\r\n");
                    set_axis_position(4);
                    break;

                default: //(nur PVE Standard und PVEA-DI und PVEA-NP        
                    //Spule 2 Testen & Testen ob Spule 1 nix macht
                    //Set Vi to 18V and Vf to 0V
                    send_data("$VI", 180);
                    send_data("$VF", 0);
                    set_axis_position(1);
                    break;
            }
           // MessageBox.Show("1");
            test_generic("Test 1", testtype, pveocoil);
        }
        private void Test_2() //    center position,            center                      Low(extend)     SV3/green               PVEO: Stimulus on B activates SV1
        {


          //  MessageBox.Show("test2 begin");
            string testtype = "PVEA";
            char pveocoil = ' ';
            switch (articlecode)
            {
                case 1:
                case 3:
                case 4:
                case 5:
                case 37:
                case 38:
                case 40:
                    if (P1240099.Checked == false)
                    {
                        testtype = "PVEO";
                        send_data("$VS", 120);  // 12V(9V) coil type
                        pveocoil = 'B';
                        sw2.Write(testtype + " " + pveocoil + "\r\n");
                    }
                    if (P1240099.Checked == true)
                    {
                        testtype = "PVEO";
                        send_data("$VS", 240);  // 12V(9V) coil type
                        pveocoil = 'B';
                        sw2.Write(testtype + " " + pveocoil + "\r\n");
                    }
                    if (P1240112.Checked == true)
                    {
                        testtype = "PVEC";
                        send_data("$VS", 120);  // 12V(9V) coil type
                        pveocoil = 'B';
                        sw2.Write(testtype + " " + pveocoil + "\r\n");
                    }
                    
                    break;
                case 29:    //12V PVEO-DI
                    testtype = "PVEO";
                    send_data("$VS", 120);  // 12V(9V) coil type
                    pveocoil = 'B';
                    sw2.Write(testtype + " " + pveocoil + "\r\n");
                    set_axis_position(4);
                    break;

                case 2:
                case 31:
                case 32:
                case 33:
                case 39:
                case 41:
                case 42:
                    if (P1240090.Checked == false)
                    {
                        testtype = "PVEO";
                        send_data("$VS", 240);  // 24V coil type
                        pveocoil = 'B';
                        sw2.Write(testtype + " " + pveocoil + "\r\n");
                    }
                    if (P1240090.Checked == true)
                    {
                        testtype = "PVEO";
                        send_data("$VS", 120);  // 24V coil type
                        pveocoil = 'B';
                        sw2.Write(testtype + " " + pveocoil + "\r\n");
                    }
                    if (P1240113.Checked == true)
                    {
                        testtype = "PVEC";
                        send_data("$VS", 240);  // 12V(9V) coil type
                        pveocoil = 'B';
                        sw2.Write(testtype + " " + pveocoil + "\r\n");
                    }  
                    break;

                case 30:    // PVEO-DI 24V
                    testtype = "PVEO";
                    send_data("$VS", 240);  // 24V coil type                                          
                    pveocoil = 'B';
                    sw2.Write(testtype + " " + pveocoil + "\r\n");
                    set_axis_position(4);
                    break;

                case 6:
                case 7:
                case 8:
                case 9:
                    // Spule 1 Testen & Testen ob 
                    //PVE16 Float Versions
                    send_data("$VI", 60);
                    send_data("$VF", 0);
                    set_axis_position(1);
                    break;
                case 10:
                //Set valve to 50% extend
                    if ((P12401010.Checked == false) && (P12401020.Checked == false))
                    {
                          //MessageBox.Show("CA2: "+GetAuxiliaryCanCommand("extend", 50 + (articlecode - 10) * 50));
                       // set_axis_position(1);
                        //Delay(3000);
                        send_data("$CA" + GetAuxiliaryCanCommand("extend", 50 + (articlecode - 10) * 50));
                       // MessageBox.Show(GetAuxiliaryCanCommand("extend", 50 + (articlecode - 10) * 50));
                        set_axis_position(1);
                        testtype = "-CI";
                        sw2.Write(testtype + " " + pveocoil + "\r\n");
                    }
                    if   ((P12401010.Checked == true)||(P12401020.Checked == true))//124-0101-0
                    {
                       // set_axis_position(4);
                        Delay(500);
                        send_data("$CA" + GetAuxiliaryCanCommand("pvedcc3", 50 + (articlecode - 10) * 50));//CAN MESSAGE
                        testtype = "-CC3";
                        Delay(2000);
                     /*   send_data("$CA" + GetAuxiliaryCanCommand("pvedcc3", 50 + (articlecode - 10) * 50));//CAN MESSAGE
                   //     testtype = "-CC3";
                        Delay(2000);
                        send_data("$CA" + GetAuxiliaryCanCommand("pvedcc3", 50 + (articlecode - 10) * 50));//CAN MESSAGE
                        //     testtype = "-CC3";
                        Delay(2000);*/
                    }  
                  
                    break;
                case 11:
                    //Set valve to 100% extend                             case 11 adds 50 below here
                  if(P12401090.Checked==false)
                  {
                        //MessageBox.Show("CA2: " + GetAuxiliaryCanCommand("extend", 50 + (articlecode - 10) * 50));
                        send_data("$CA" + GetAuxiliaryCanCommand("extend", 50 + (articlecode - 10) * 50));
                    set_axis_position(1);
                    testtype = "-CI";
                    sw2.Write(testtype + " " + pveocoil + "\r\n");
            }
                  if (P12401090.Checked == true)//124-0109-0
                  {
                      send_data("$VS", 120);
                      Delay(500);
                      send_data("$CA" + GetAuxiliaryCanCommand("extend", 50 + (articlecode - 10) * 50));
                      set_axis_position(1);
                      testtype = "-CI";
                      sw2.Write(testtype + " " + pveocoil + "\r\n");
                  }   
                    break;
                case 17:
                    if (P12401020.Checked == false)// PVEH_DI
                    {
                        testtype = "PVEH";
                        send_data("$VI", 60);
                        send_data("$VF", 0);
                        sw2.Write(testtype + " " + pveocoil + "\r\n");
                        set_axis_position(4); // Pos.4 für S7 entspricht Pos.1 für S6     
                        
                       
                    }
                  /*  if (P12401020.Checked == true)
                    {
                        send_data("$CA" + GetAuxiliaryCanCommand("pvedcc3", 50 + (articlecode - 10) * 50));//CAN MESSAGE
                        testtype = "-CC3";

                    }*/
                    break;
                case 12:    // PVEH
                case 13:    // PVEH_NP_SP_F
                case 14:    // PVEH_S
                case 15:    // PVEH_S
                case 16:    // PVEH_S
                 // PVEH_DI
                case 18:    // PVEH_DI
                case 21:    // PVEH_F
                case 22:    // PVEH_NP
                case 23:    // PVEH_SP
                case 34:    // PVEH_S_U
                case 35:    // PVEH_S_U
                case 36:    // PVEH_S_U
                    testtype = "PVEH";
                    send_data("$VI", 60);
                    send_data("$VF", 0);
                    sw2.Write(testtype + " " + pveocoil + "\r\n");
                    set_axis_position(4); // Pos.4 für S7 entspricht Pos.1 für S6 
                    break;
                case 20:    // S7 PVEA (Deutsch 4)
                case 24:    // S7 PVEA_NP (Deutsch 6)
                case 25:    // S7 PVEA (AMP 4)
                case 26:    // S7 PVEM (Hirschmann)
                case 27:    // S7 PVEA_DI (2x AMP 4)
                case 28:    // S7_PVEA_DI (2x Deutsch 4)
                    send_data("$VI", 60);
                    send_data("$VF", 0);
                    set_axis_position(4); // Pos.4 für S7 entspricht Pos.1 für S6 
                    break;
                default:
                    // For all other Versions
                    // Spule 2 Testen & Testen ob Spule 1 nix macht
                    send_data("$VI", 60);
                    send_data("$VF", 0);
                    set_axis_position(1);
                    break;
            }
           // MessageBox.Show("2");
            test_generic("Test 2", testtype, pveocoil);

        }
        private void Test_3() //    5mm towards LED Side,       5mm towards LED side        Center          SV1/red                 PVEO_DI: Coils and LED OFF, DIR_A active
        {
            string testtype = "PVEA";
            //Set parameters depending on variant (Test 3 is in reality different for some variants)
            switch (articlecode)
            {
                case 6: // Fall 3A
                case 8: // Fall 3A
                case 7: // Fall 3B: sollte eigentlich 12V auf VI und 24V auf VF haben //#### 
                case 9: // Fall 3B: sollte eigentlich 12V auf VI und 24V auf VF haben //####
                    //PVEX16 and Float Versions
                    send_data("$VI", 180);
                    send_data("$VF", 0);
                    //Set linear axis in Position Nr.1 if not already there
                  //  set_axis_position(1);
                    break;
                case 10:
                //Set valve to 50% retracted
                    if ((P12401010.Checked == false) && (P12401020.Checked == false))
                    {
                       //  MessageBox.Show("CA3: " + GetAuxiliaryCanCommand("retract", 50 + (articlecode - 10) * 50));
                      //  set_axis_position(3);
                      //  Delay(3000);
                        send_data("$CA" + GetAuxiliaryCanCommand("retract", 50 + (articlecode - 10) * 50));

                        //Set linear axis in Position Nr.3 if not already there
                        set_axis_position(3);
                        testtype = "-CI";
                        sw2.Write(testtype + "\r\n");
                    }
                      if ((P12401010.Checked == true)||(P12401020.Checked == true))
                    {
                        Delay(1000);
                          send_data("$CA" + GetAuxiliaryCanCommand("pvedcc4", 50 + (articlecode - 10) * 50));//CAN MESSAGE
                        testtype = "-CC4";
                     /*   Delay(2000);
                        send_data("$CA" + GetAuxiliaryCanCommand("pvedcc4", 50 + (articlecode - 10) * 50));//CAN MESSAGE
                       // testtype = "-CC4";
                        Delay(2000);
                        send_data("$CA" + GetAuxiliaryCanCommand("pvedcc4", 50 + (articlecode - 10) * 50));//CAN MESSAGE
                    //    testtype = "-CC4";
                        Delay(2000);*/
                      }
                    break;
                case 11:
                    //Set valve to 100% retracted                           case 11 adds 50 below here
                    if (P12401090.Checked == false)
                    {
                        send_data("$CA" + GetAuxiliaryCanCommand("retract", 50 + (articlecode - 10) * 50));

                        //Set linear axis in Position Nr.3 if not already there
                        set_axis_position(3);
                        testtype = "-CI";
                        sw2.Write(testtype + "\r\n");
                    }
                    if (P12401090.Checked == true)
                    {
                        send_data("$VS", 120);
                        Delay(500);
                        send_data("$CA" + GetAuxiliaryCanCommand("retract", 50 + (articlecode - 10) * 50));

                        //Set linear axis in Position Nr.3 if not already there
                        set_axis_position(3);
                        testtype = "-CI";
                        sw2.Write(testtype + "\r\n");
                    } 
                    break;
                case 17:
                    if (P12401020.Checked == false)
                    {
                        testtype = "PVEH";
                        send_data("$VI", 120);
                        send_data("$VF", 0);
                        sw2.Write(testtype + "\r\n");
                        set_axis_position(6); // Pos.6 für S7 entspricht Pos.3 für S6
                    }
                   /* if (P12401020.Checked == true)
                    {
                        send_data("$CA" + GetAuxiliaryCanCommand("pvedcc4", 50 + (articlecode - 10) * 50));//CAN MESSAGE
                        testtype = "-CC4";

                    }*/
                    break;
                case 12:    // PVEH
                case 13:    // PVEH_NP_SP_F
                case 14:    // PVEH_S
                case 15:    // PVEH_S
                case 16:    // PVEH_S
              
                case 18:    // PVEH_DI
                case 21:    // PVEH_F
                case 22:    // PVEH_NP
                case 23:    // PVEH_SP
                case 34:    // PVEH_S_U
                case 35:    // PVEH_S_U
                case 36:    // PVEH_S_U
                    testtype = "PVEH";
                    send_data("$VI", 120);
                    send_data("$VF", 0);
                    sw2.Write(testtype + "\r\n");
                    set_axis_position(6); // Pos.6 für S7 entspricht Pos.3 für S6
                    break;
                case 20:    // S7 PVEA (Deutsch 4)
                case 24:    // S7 PVEA_NP (Deutsch 6)
                case 25:    // S7 PVEA (AMP 4)
                case 26:    // S7 PVEM (Hirschmann)
                case 27:    // S7 PVEA_DI (2x AMP 4)
                case 28:    // S7_PVEA_DI (2x Deutsch 4)
                    send_data("$VI", 120);
                    send_data("$VF", 0);
                    set_axis_position(6);
                    break;
                case 29:    // S7 PVEO-DI-12V, checking LVDT Part as in PVEA
                    send_data("$VS", 120);
                    set_axis_position(5);   //pos 2
                    break;
                case 30:    // S7 PVEO-DI-24V, checking LVDT-Part as in PVEA
                    send_data("$VS", 240);
                    set_axis_position(5);   //pos 2
                    break;
                default:
                    //For all other Versions
                    send_data("$VI", 120);
                    send_data("$VF", 0);
                    //Set linear axis in Position Nr.3 if not already there
                    set_axis_position(3);
                    break;
            }
          //  MessageBox.Show("3");
            test_generic("Test 3", testtype);
        }
        private void Test_4() //    5mm towards potting Side,   5mm towards LED side        Center          SV3/red                 PVEO_DI: Coils and LED OFF, DIR_B active
        {
            string testtype = "PVEA";
            //Set parameters depending on variant (Test 4 is in reality different for some variants)
            switch (articlecode)
            {
                case 10:
                    if ((P12401010.Checked == false) && (P12401020.Checked == false))
                    {
                        testtype = "-CI";
                        // set value to neutral position
                        //   MessageBox.Show("CA4: "+ GetAuxiliaryCanCommand("retract", 0));
                      //  set_axis_position(2);
                     //   Delay(3000);
                        send_data("$CA" + GetAuxiliaryCanCommand("retract", 0)); // seems to reset both retract and extract
                        // send_data("$CA"+GetAuxiliaryCanCommand("extend",0));
                        sw2.Write(testtype + "\r\n");
                        set_axis_position(2);
                    }
                    if ((P12401010.Checked == true) || (P12401020.Checked == true))
                    {
                        send_data("$CA" + GetAuxiliaryCanCommand("pvedcc2", 50 + (articlecode - 10) * 50));//CAN MESSAGE
                        testtype = "-CC2";
                       // Delay(500);
                    }
                        break;
                case 11:
                    if (P12401090.Checked == false)
                    {
                        testtype = "-CI";
                        // set value to neutral position
                        send_data("$CA" + GetAuxiliaryCanCommand("retract", 0)); // seems to reset both retract and extract
                        // send_data("$CA"+GetAuxiliaryCanCommand("extend",0));
                        sw2.Write(testtype + "\r\n");
                        set_axis_position(2);
                    }
                    if (P12401090.Checked == true)
                    {
                        send_data("$VS", 120); 
                        testtype = "-CI";
                        // set value to neutral position
                        Delay(500);
                        send_data("$CA" + GetAuxiliaryCanCommand("retract", 0)); // seems to reset both retract and extract
                        // send_data("$CA"+GetAuxiliaryCanCommand("extend",0));
                        sw2.Write(testtype + "\r\n");
                        set_axis_position(2);
                    }    
                    break;
                case 17:
                    if (P12401020.Checked == false)
                    {
                        testtype = "PVEH";
                        send_data("$VI", 120);
                        send_data("$VF", 0);
                        sw2.Write(testtype + "\r\n");
                        set_axis_position(5); // Pos.5 für S7 entspricht Pos.2 für S6

                   }
                 /*   if (P12401020.Checked == true)
                    {
                        send_data("$CA" + GetAuxiliaryCanCommand("pvedcc2", 50 + (articlecode - 10) * 50));//CAN MESSAGE
                        testtype = "-CC2";


                    }*/
                   
                   break;
                case 12:    // PVEH
                case 13:    // PVEH_NP_SP_F
                case 14:    // PVEH_S
                case 15:    // PVEH_S
                case 16:    // PVEH_S
            
                case 18:    // PVEH_DI
                case 21:    // PVEH_F
                case 22:    // PVEH_NP
                case 23:    // PVEH_SP
                case 34:    // PVEH_S_U
                case 35:    // PVEH_S_U
                case 36:    // PVEH_S_U
                    testtype = "PVEH";
                    send_data("$VI", 120);
                    send_data("$VF", 0);
                    sw2.Write(testtype + "\r\n");
                    set_axis_position(5); // Pos.5 für S7 entspricht Pos.2 für S6
                    break;
                case 20:    // S7 PVEA (Deutsch 4)
                case 24:    // S7 PVEA_NP (Deutsch 6)
                case 25:    // S7 PVEA (AMP 4)
                case 26:    // S7 PVEM (Hirschmann)
                case 27:    // S7 PVEA_DI (2x AMP 4)
                case 28:    // S7_PVEA_DI (2x Deutsch 4)
                    send_data("$VI", 120);
                    send_data("$VF", 0);
                    set_axis_position(5); // Pos.5 für S7 entspricht Pos.2 für S6
                    break;
                case 29:    // S7 PVEO-DI-12V, checking LVDT Part as in PVEA
                    send_data("$VS", 120);
                    set_axis_position(6);   //pos 3
                    break;
                case 30:    // S7 PVEO-DI-24V, checking LVDT-Part as in PVEA
                    send_data("$VS", 240);
                    set_axis_position(6);   //pos 3
                    break;
                case 7:
                    send_data("$VI", 120);
                    send_data("$VF", 0);
                    set_axis_position(3);
                    Delay(3000);
                    break;
                default:
                    //For all other Versions
                    send_data("$VI", 120);
                    send_data("$VF", 0);
                    set_axis_position(2);
                    break;
            }
            //Set linear axis in Position Nr.2 if not already there
           // MessageBox.Show("4");
            test_generic("Test 4", testtype);
        }
        private void Test_5() //    5mm towards LED Side,       5mm towards potting side    Low(extend)     no/green, DIR_B active  PVEH-F: LVDT coil in center pos -> Coil SV1 active
        {
            string testtype = "PVEA";
            switch (articlecode)
            {
                case 13:    // PVEH_F Deutsch6
                case 21:    // PVEH_F AMP6
                    testtype = "PVEH";
                    send_data("$VI", 120);
                    send_data("$VF", 240);
                    sw2.Write(testtype + "\r\n");
                    set_axis_position(4);
                    break;
                case 17:    // PVEH_DI
                    if (P12401020.Checked == false)
                    {
                        testtype = "PVEH";
                        send_data("$VI", 60);
                        send_data("$VF", 0);
                        sw2.Write(testtype + "\r\n");
                        set_axis_position(6);

                    }
                   /* if (P12401020.Checked == true)
                    {
                        send_data("$CA" + GetAuxiliaryCanCommand("pvedcc5", 50 + (articlecode - 10) * 50));//CAN MESSAGE
                        testtype = "-CC5";

                    }*/
                    break;
                case 18:    // PVEH_DI
                    testtype = "PVEH";
                    send_data("$VI", 60);
                    send_data("$VF", 0);
                    sw2.Write(testtype + "\r\n");
                    set_axis_position(6);
                    break;
                case 27:    // S7 PVEA_DI (2x AMP 4)
                case 28:    // S7_PVEA_DI (2x Deutsch 4)
                    send_data("$VI", 60);
                    send_data("$VF", 0);
                    set_axis_position(6);
                    break;
                case 7:
                    send_data("$VI", 180);
                    send_data("$VF", 0);
                    set_axis_position(3);
                    Delay(3000);
                  //  MessageBox.Show("444444");
                    break;
                case 10:
                    if ((P12401010.Checked == true) || (P12401020.Checked == true))
                    {
                        send_data("$CA" + GetAuxiliaryCanCommand("pvedcc5", 50 + (articlecode - 10) * 50));//CAN MESSAGE
                        testtype = "-CC5";
                      //  if ((testList["Test " + i.ToString()].Spool.value > testList["Test " + i.ToString()].Spool.ulimit) || (testList["Test " + i.ToString()].Spool.value < testList["Test " + i.ToString()].Spool.llimit)) testList["Test " + i.ToString()].Spool.test_result = false; else testList["Test " + i.ToString()].Spool.test_result = true;
                   /*     send_data("$CR");
                        Thread.Sleep(controller_answer_wait); // wait for data to be received 
                        Delay(200);
                        testList["Test 5"].Spool.value = cc_value;-*/
                     //   if ((testList["Test 5"].Spool.value > testList["Test 5" ].Spool.ulimit) || (testList["Test 5"].Spool.value < testList["Test 5"].Spool.llimit)) testList["Test 5"].Spool.test_result = false; else testList["Test 5"].Spool.test_result = true;
                   
                    
                    }

                    break;
                case 6: // Fall 3B: sollte eigentlich 12V auf VI und 24V auf VF haben //####
                    //PVEX16 and Float Versions
                    send_data("$VI", 180);
                    send_data("$VF", 0);
                    //Set linear axis in Position Nr.1 if not already there
                    set_axis_position(3);
                    Delay(5000);
                    //  MessageBox.Show("444444");
                    break;
                default:
                    error_output("Test 5 not defined for this variant!");
                    break;
            }

            test_generic("Test 5", testtype);

        }
        private void Test_6() //    5mm towards potting Side,   5mm towards LED side        VBat2=0,Center  no/green, DIR_A active  CI- Variant uses 'extend' Stimulus (why?)
        {
            string testtype = "PVEA";

            //Switch off Ubatt2
            send_data("$U2", 0);
            send_data("$MR", 1);

            switch (articlecode)
            {
                case 17:    // PVEH_DI
                    if (P12401020.Checked == false)
                    {
                        testtype = "PVEH";
                        send_data("$U2", 0);
                        send_data("$VI", 120);
                        send_data("$VF", 0);
                        sw2.Write(testtype + "\r\n");
                        set_axis_position(5);

                    }
                   /* if (P12401020.Checked == true)
                    {
                        set_axis_position(5);
                        Delay(1000);
                        send_data("$CA" + GetAuxiliaryCanCommand("pvedcc5", 50 + (articlecode - 10) * 50));//CAN MESSAGE
                        testtype = "-CC5";


                    }*/

                    break;
                case 18:    // PVEH_DI
                    testtype = "PVEH";
                    send_data("$U2", 0);
                    send_data("$VI", 120);
                    send_data("$VF", 0);
                    sw2.Write(testtype + "\r\n");
                    set_axis_position(5);
                    break;
                case 27:    // S7 PVEA_DI (2x AMP 4)
                case 28:    // S7_PVEA_DI (2x Deutsch 4)
                    send_data("$U2", 0);
                    send_data("$VI", 120);
                    send_data("$VF", 0);
                    set_axis_position(5);
                    break;
                case 10:
                    if ((P12401010.Checked == true) || (P12401020.Checked == true))
                    {
                        set_axis_position(5);
                        Delay(1000);
                        send_data("$CA" + GetAuxiliaryCanCommand("pvedcc5", 50 + (articlecode - 10) * 50));//CAN MESSAGE
                        testtype = "-CC5";
                    }

                    break;
                default:
                    error_output("Test 6 not defined for this variant!");
                    break;
            }

            test_generic("Test 6", testtype);
        }
        private void Test_7() // ---Resistance Test for PVEO Coils--------------------------------------------------------------------------------------------------------------------
        {
            //Set SPS in Multimeter mode
            send_data("$MM", 1);
            if (mManualDebugOperation) send_data("$U1", 0);
            if (mManualDebugOperation) send_data("$U2", 0);
            Thread.Sleep(controller_answer_wait);
            voltagearray resistance_values = resistance_measurement();
            testList["Test 7"].SV1.value = resistance_values.CH1;
            testList["Test 7"].SV3.value = resistance_values.CH2;
            testList["Test 7"].SV2.value = resistance_values.CH3;
            testList["Test 7"].SV4.value = resistance_values.CH4;

            //Set SPS in Tester Mode
            send_data("$MM", 0);
        }
        //Measurement flow control  
        void Sn_TransfEvent(string value)
        {
            snno = value;
        }
        void Sn_TransfintEvent(int value)
        {
            snlength = value;
        }

        private void measurement_flow(object s, EventArgs e)
        {
            //Define local variables
            //bool shortcut = false;        
            SN snbox = new SN();
            sw.Start();                     //Start timer for determining measurement run time

            reset_measurement();            //Reset all measurement results from last run
            ci_i = 0;


            send_data("$TA", 1);            //Send Test is started to Tester
            send_data("$MM", 0);            //Set SPS in Tester Mode
          //  if (led_model == "Immediately") { send_data("$SI", 3); set_axis_position(1); }
                send_data("$U1", 1);            //Set UBatt 1 24V 
            send_data("$U2", 1);            //Set UBatt 1 24V 
            /*if(led_model== "Immediately")
            {
                scope_DC(number_acq_DC, timebase_DC, Scope.Range.Range_20V, Scope.Range.Range_20V, Scope.Range.Range_20V, Scope.Range.Range_20V);

                double led_red_voltage = scopevalues.CH3;
                double led_green_voltage = scopevalues.CH4;
                MessageBox.Show(led_red_voltage.ToString());
                MessageBox.Show(led_green_voltage.ToString());
               // string colour = led_color(led_red_voltage, led_green_voltage);
               // testList["Test 0"].LedR.value = led_red_voltage;
               // testList["Test 0"].LedG.value = led_green_voltage;
            }*/
            send_data("$VS", 240);          //SET VS VOLTAGE 24V

            send_data("$MR", 3);            //MATRIX SWITCH 3??
            send_data("$SI", 3);            //Set Scope PORT 3

            test_generic("LED_INIT");

            //Set parameters to Test 1 parameters if test is enabled
            if (testList["Test 1"].SV1.perform_test || testList["Test 1"].SV3.perform_test || testList["Test 1"].SV2.perform_test || testList["Test 1"].SV4.perform_test
                || testList["Test 1"].Spool.perform_test || testList["Test 1"].LedR.perform_test || testList["Test 1"].DirA.perform_test || testList["Test 1"].DirB.perform_test
                || testList["Test 1"].DrvEnable.perform_test) Test_1();
            //MessageBox.Show("test1 finish");
            //Set parameters to Test 2 parameters if test is enabled
            if (testList["Test 2"].SV1.perform_test || testList["Test 2"].SV3.perform_test || testList["Test 2"].SV2.perform_test || testList["Test 2"].SV4.perform_test
                || testList["Test 2"].Spool.perform_test || testList["Test 2"].LedR.perform_test || testList["Test 2"].DirA.perform_test || testList["Test 2"].DirB.perform_test
                || testList["Test 2"].DrvEnable.perform_test) Test_2();
            //Set parameters to Test 3 parameters if test is enabled: Fehlerfall: Sollwert auf Mittelposition Testen und LVDT Coil zu weit rein.
           // MessageBox.Show("test2 finish");
            if (testList["Test 3"].SV1.perform_test || testList["Test 3"].SV3.perform_test || testList["Test 3"].SV1.perform_test || testList["Test 3"].SV3.perform_test
                || testList["Test 3"].Spool.perform_test || testList["Test 3"].LedR.perform_test || testList["Test 3"].DirA.perform_test || testList["Test 3"].DirB.perform_test
                || testList["Test 3"].DrvEnable.perform_test) Test_3();
            //Set parameters to Test 4 parameters if test is enabled
           // MessageBox.Show("test3 finish");
            if (testList["Test 4"].SV1.perform_test || testList["Test 4"].SV3.perform_test || testList["Test 4"].SV2.perform_test || testList["Test 4"].SV4.perform_test
                || testList["Test 4"].Spool.perform_test || testList["Test 4"].LedR.perform_test || testList["Test 4"].DirA.perform_test || testList["Test 4"].DirB.perform_test
                || testList["Test 4"].DrvEnable.perform_test) Test_4();
            //Set parameters to Test 5 parameters if test is enabled
          //  MessageBox.Show("test4 finish");
            if (testList["Test 5"].SV1.perform_test || testList["Test 5"].SV3.perform_test || testList["Test 5"].SV2.perform_test || testList["Test 5"].SV4.perform_test
                || testList["Test 5"].Spool.perform_test || testList["Test 5"].LedR.perform_test || testList["Test 5"].DirA.perform_test || testList["Test 5"].DirB.perform_test
                || testList["Test 5"].DrvEnable.perform_test) Test_5();
            //Set parameters to Test 6 parameters if test is enabled
          //  MessageBox.Show("test5 finish");
            if (testList["Test 6"].SV1.perform_test || testList["Test 6"].SV3.perform_test || testList["Test 6"].SV2.perform_test || testList["Test 6"].SV4.perform_test
                || testList["Test 6"].Spool.perform_test || testList["Test 6"].LedR.perform_test || testList["Test 6"].DirA.perform_test || testList["Test 6"].DirB.perform_test
                || testList["Test 6"].DrvEnable.perform_test) Test_6();
          //  MessageBox.Show("test6 finish");
            if (testList["Test 7"].SV1.perform_test || testList["Test 7"].SV3.perform_test || testList["Test 7"].SV2.perform_test || testList["Test 7"].SV4.perform_test
                || testList["Test 7"].LedR.perform_test) Test_7();
            //MessageBox.Show("test7 finish");
            if (testList["Test 8"].Spool.perform_test) Test_8();
          //  MessageBox.Show("test8 finish");


            if (LVDTtest1.perform_test) prepare_LVDT_Test();

            send_data("$U1", 0);            //U BATTERY1 OFF
            send_data("$U2", 0);            //U BATTERY2 OFF
            send_data("$VS", 0);            //VS VOLTAGE OFF
            send_data("$VI", 0);           //VI VOLTAGE  OFF
            send_data("$VF", 0);           //VF VOLTAGE OFF
            send_data("$MR", 0);          //MATRIX OFF
            set_axis_position(7);           //Set linear axis in Position Nr.7 (parking position) if not already there
            send_data("$MM", 1);            //Set SPS in Mulimeter Mode

            // Create protocol of test result, set acceptance status (GOOD/FAIL) for each and overall measurement
            check_limits();                 //Check the measurement results against the limits
            show_screen();                  //Output the results and values on the screen
            write_database();               //Write data into local datafile

            // Finish last Run
            sw.Stop();                      //Show elapsed time for measurement and reset time
            measurementtime = sw.Elapsed.Seconds + ((double)sw.Elapsed.Milliseconds / 1000);
            meastime.Text = (string.Format("{0:0.0}", measurementtime));
          
            sw.Reset();
            mManualDebugOperation = false;  // reset flag to automatically initiated Test as is default.
            Regex regnum = new Regex("^[0~9]");
            int snpass = 1,index,sncheck=1;
            string snmodel2,revx,rev2,days2,revr="",pcbrev2;
/*
            snbox.TransfEvent += Sn_TransfEvent;
            snbox.TransintfEvent+= Sn_TransfintEvent; 
            DialogResult ddr = snbox.ShowDialog();       
            SNInput.Text = snno;
            if (snpass == 1)
            {
                if (snlength != samplelength)
                {
                    this.label12.Text = "Length Err";
                    this.label12.ForeColor = Color.Red;// 颜色 
                    snpass = 0;
                }
            }
            if (snpass == 1)
            {
                index = snno.IndexOf(":");
                snmodel2 = snno.Substring(0, index);
                if (snmodel2 != smodel)
                {
                    this.label12.Text = "Model Err";
                    this.label12.ForeColor = Color.Red;// 颜色 
                    snpass = 0;
                }
            }
            if(snpass==1)
            {
                revx = getrev(snno, revr);
                //  MessageBox.Show(rev);  
                if (regnum.IsMatch(revx.Substring(0, 1)))
                {
                    // MessageBox.Show("Num");
                    rev2 = revx.Substring(0, 2);
                    days2 = revx.Substring(2, 4);
                    // MessageBox.Show(rev);
                }
                else
                {
                    rev2 = revx.Substring(0, 1);
                    days2 = revx.Substring(1, 4);
                    // MessageBox.Show(rev);
                }
                if (rev2 != rev)
                {
                    this.label12.Text = "rev Err";
                    this.label12.ForeColor = Color.Red;// 颜色 
                    snpass = 0;
                }
                if (days2 != pdays)
                {
                    this.label12.Text = "day Err";
                    this.label12.ForeColor = Color.Red;// 颜色 
                    snpass = 0;
                }

            }
if(snpass==1)
            {
                revr = "";
                pcbrev2 = getpcbrev(snno, revr);
                if (pcbrev2 != pcbrev)
                {
                    this.label12.Text = "PCBREV Err";
                    this.label12.ForeColor = Color.Red;// 颜色 
                    snpass = 0;
                }
            }
            if (snpass == 0)
            { send_data("$TR", 0); }

            if (snpass == 1)
                { this.label12.Text = snno;
                    this.label12.ForeColor = Color.Blue; write_database(); }
            */

        }

      
        
        
        private void Test_8()//PVED-CC
        {
            string testtype = "PVEA";
            switch (articlecode)
            {
                case 10:
                    if ((P12401010.Checked == true) || (P12401020.Checked == true))
                    {
                        set_axis_position(6);
                        Delay(1000);
                        send_data("$CA" + GetAuxiliaryCanCommand("pvedcc5", 50 + (articlecode - 10) * 50));//CAN MESSAGE
                        testtype = "-CC5";
                    }

                    break;
              /*  case 17:
                    if (P12401020.Checked == true)  
                    {
                        set_axis_position(6);
                        Delay(1000);
                        send_data("$CA" + GetAuxiliaryCanCommand("pvedcc5", 50 + (articlecode - 10) * 50));//CAN MESSAGE
                        testtype = "-CC5";

                    }
                    break;*/
                default:
                    error_output("Test 8 not defined for this variant!");
                    break;
            
            
            
            }

            test_generic("Test 8", testtype);
        }
        private void debugit_CheckedChanged(object sender, EventArgs e)
        {
            error_output("debugit clicked");
            plotwindow.Visible = debugit.Checked;

        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            //asc.controlAutoSize(this);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            sw2.Flush();
            //关闭流
            sw2.Close();
            fs.Close();
       
        }

        private void P12401100_Click(object sender, EventArgs e)
        {
            if (P12401100.Checked == true)
            {
                P12401100.Checked = false;
            }
            else
            {
                P12401100.Checked = true;
                P12401110.Checked = false;
                P12401090.Checked = false;
            }
        }

        private void P12401110_Click(object sender, EventArgs e)
        {
            if (P12401110.Checked == true)
            {
                P12401110.Checked = false;
            }
            else
            {
                P12401110.Checked = true;
                P12401100.Checked = false;
                P12401090.Checked = false;
            }
        }

        private void P12401090_Click(object sender, EventArgs e)
        {
            if (P12401090.Checked == true)
            {
                P12401090.Checked = false;
            }
            else
            {
                P12401090.Checked = true;
                P12401100.Checked = false;
                P12401110.Checked = false;
            }
        
        
        }

        private void P12401020_Click(object sender, EventArgs e)
        {
            if (P12401020.Checked == true)
            {
                P12401020.Checked = false;
            }
            else
            {
                P12401020.Checked = true;
                P12401010.Checked = false;
            }
        
        
        
        
        }

        private void P12401010_Click(object sender, EventArgs e)
        {
            if (P12401010.Checked == true)
            {
                P12401010.Checked = false;
            }
            else
            {
                P12401020.Checked = false;
                P12401010.Checked = true;
            }
        
        }

        private int hextodec(string ss = "0000")//hex transform bin then bin transform dec can transform negative number
        {
            int i, shi, actdata = 0;
            long ww;
            string er1;
            string[] er;
            int leng,ix=0;
            string erx = "";
            string erx2, erx4 = "";
            string[] erx3;
            erx3 = new string[16];
            er = new string[16];
            ww = Int32.Parse(ss, System.Globalization.NumberStyles.HexNumber);
            er1 = Convert.ToString(ww, 2);
            leng = er1.Length;
            if (leng < 16)
            {
                for (i = 0; i < 16 - leng; i++)
                {
                    er[i] = "0";
                }


                for (i = 16 - leng; i < 16; i++)
                {
                    er[i] = er1.Substring(ix, 1);
                    ix = ix + 1;
                    // MessageBox.Show(er[i]);
                }
                // MessageBox.Show("33");
            }
            else
            {

                for (i = 0; i < 16; i++)
                {
                    er[i] = er1.Substring(i, 1);
                    //  ix = ix + 1;
                    // MessageBox.Show(er[i]);
                }
            }

            if (er[0] == "1")
            {
                for (i = 0; i < 16; i++)
                {
                    erx = erx + er[i];
                }
                // MessageBox.Show(erx);
                shi = Convert.ToInt32(erx, 2);
                shi = shi - 1;
                erx2 = Convert.ToString(shi, 2);
                for (i = 0; i < 16; i++)
                {
                    if (erx2.Substring(i, 1) == "1")
                    {
                        erx3[i] = "0";
                    }
                    if (erx2.Substring(i, 1) == "0")
                    {
                        erx3[i] = "1";
                    }


                }
                for (i = 0; i < 16; i++)
                {
                    erx4 = erx4 + erx3[i];
                }
                actdata = Convert.ToInt32(erx4, 2);
                actdata = 0 - actdata;


            }
            if (er[0] == "0")
            {
                for (i = 0; i < 16; i++)
                {
                    erx = erx + er[i];
                }

                actdata = Convert.ToInt32(erx, 2);
            }   
            
            
            
            
            
            
          
            
            return actdata;
        }

        private void P1240099_Click(object sender, EventArgs e)
        {
            if (P1240099.Checked == true)
            {
                P1240099.Checked = false;
            }
            else
            {
                P1240099.Checked = true;
                P1240090.Checked = false;
            }
       
        
        
        
        }

        private void P1240090_Click(object sender, EventArgs e)
        {
            if (P1240090.Checked == true)
            {
                P1240090.Checked = false;
            }
            else
            {
                P1240090.Checked = true;
                P1240099.Checked = false;
            }
        }

        private void P1240113_Click(object sender, EventArgs e)
        {
            if (P1240113.Checked == true)
            {
                P1240113.Checked = false;
            }
            else
            {
                P1240113.Checked = true;
                P1240112.Checked = false;
            }
        }

        private void P1240112_Click(object sender, EventArgs e)
        {
            if (P1240112.Checked == true)
            {
                P1240112.Checked = false;
            }
            else
            {
                P1240112.Checked = true;
                P1240113.Checked = false;
            }
        
        
        
        }
    
    
    
    
    
    
    
   
    
    
    
    
    
    
    }
}


