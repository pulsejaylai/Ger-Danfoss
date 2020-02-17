namespace SauerDanfoss
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.testresult = new System.Windows.Forms.Panel();
            this.messagebox1 = new System.Windows.Forms.RichTextBox();
            this.serialPortTester = new System.IO.Ports.SerialPort(this.components);
            this.serialPortTemperatureSensor = new System.IO.Ports.SerialPort(this.components);
            this.plotwindow = new ZedGraph.ZedGraphControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.article_description = new System.Windows.Forms.Label();
            this.article_code = new System.Windows.Forms.Label();
            this.articlenumber_field = new System.Windows.Forms.RichTextBox();
            this.articlecode_field = new System.Windows.Forms.RichTextBox();
            this.test_name1 = new System.Windows.Forms.RichTextBox();
            this.test_name2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.richTextBox7 = new System.Windows.Forms.RichTextBox();
            this.richTextBox8 = new System.Windows.Forms.RichTextBox();
            this.test1_led_result = new System.Windows.Forms.RichTextBox();
            this.test6_sv1_ll = new System.Windows.Forms.RichTextBox();
            this.test5_sv1_ll = new System.Windows.Forms.RichTextBox();
            this.test4_sv1_ll = new System.Windows.Forms.RichTextBox();
            this.test3_sv1_ll = new System.Windows.Forms.RichTextBox();
            this.test2_sv1_ll = new System.Windows.Forms.RichTextBox();
            this.test1_sv1_ll = new System.Windows.Forms.RichTextBox();
            this.test6_sv1_ul = new System.Windows.Forms.RichTextBox();
            this.test5_sv1_ul = new System.Windows.Forms.RichTextBox();
            this.test4_sv1_ul = new System.Windows.Forms.RichTextBox();
            this.test3_sv1_ul = new System.Windows.Forms.RichTextBox();
            this.test2_sv1_ul = new System.Windows.Forms.RichTextBox();
            this.test1_sv1_ul = new System.Windows.Forms.RichTextBox();
            this.test6_sv1_result = new System.Windows.Forms.RichTextBox();
            this.test5_sv1_result = new System.Windows.Forms.RichTextBox();
            this.test4_sv1_result = new System.Windows.Forms.RichTextBox();
            this.test3_sv1_result = new System.Windows.Forms.RichTextBox();
            this.test2_sv1_result = new System.Windows.Forms.RichTextBox();
            this.test1_sv1_result = new System.Windows.Forms.RichTextBox();
            this.test6_sv3_result = new System.Windows.Forms.RichTextBox();
            this.test5_sv3_result = new System.Windows.Forms.RichTextBox();
            this.test4_sv3_result = new System.Windows.Forms.RichTextBox();
            this.test3_sv3_result = new System.Windows.Forms.RichTextBox();
            this.test2_sv3_result = new System.Windows.Forms.RichTextBox();
            this.test1_sv3_result = new System.Windows.Forms.RichTextBox();
            this.test6_sv3_ul = new System.Windows.Forms.RichTextBox();
            this.test5_sv3_ul = new System.Windows.Forms.RichTextBox();
            this.test4_sv3_ul = new System.Windows.Forms.RichTextBox();
            this.test3_sv3_ul = new System.Windows.Forms.RichTextBox();
            this.test2_sv3_ul = new System.Windows.Forms.RichTextBox();
            this.test1_sv3_ul = new System.Windows.Forms.RichTextBox();
            this.test6_sv3_ll = new System.Windows.Forms.RichTextBox();
            this.test5_sv3_ll = new System.Windows.Forms.RichTextBox();
            this.test4_sv3_ll = new System.Windows.Forms.RichTextBox();
            this.test3_sv3_ll = new System.Windows.Forms.RichTextBox();
            this.test2_sv3_ll = new System.Windows.Forms.RichTextBox();
            this.test1_sv3_ll = new System.Windows.Forms.RichTextBox();
            this.test6_spool_result = new System.Windows.Forms.RichTextBox();
            this.test5_spool_result = new System.Windows.Forms.RichTextBox();
            this.test4_spool_result = new System.Windows.Forms.RichTextBox();
            this.test3_spool_result = new System.Windows.Forms.RichTextBox();
            this.test2_spool_result = new System.Windows.Forms.RichTextBox();
            this.test1_spool_result = new System.Windows.Forms.RichTextBox();
            this.test6_spool_ul = new System.Windows.Forms.RichTextBox();
            this.test5_spool_ul = new System.Windows.Forms.RichTextBox();
            this.test4_spool_ul = new System.Windows.Forms.RichTextBox();
            this.test3_spool_ul = new System.Windows.Forms.RichTextBox();
            this.test2_spool_ul = new System.Windows.Forms.RichTextBox();
            this.test1_spool_ul = new System.Windows.Forms.RichTextBox();
            this.test6_spool_ll = new System.Windows.Forms.RichTextBox();
            this.test5_spool_ll = new System.Windows.Forms.RichTextBox();
            this.test4_spool_ll = new System.Windows.Forms.RichTextBox();
            this.test3_spool_ll = new System.Windows.Forms.RichTextBox();
            this.test2_spool_ll = new System.Windows.Forms.RichTextBox();
            this.test1_spool_ll = new System.Windows.Forms.RichTextBox();
            this.test6_dira_result = new System.Windows.Forms.RichTextBox();
            this.test5_dira_result = new System.Windows.Forms.RichTextBox();
            this.test4_dira_result = new System.Windows.Forms.RichTextBox();
            this.test3_dira_result = new System.Windows.Forms.RichTextBox();
            this.test2_dira_result = new System.Windows.Forms.RichTextBox();
            this.test1_dira_result = new System.Windows.Forms.RichTextBox();
            this.test6_dira_ul = new System.Windows.Forms.RichTextBox();
            this.test5_dira_ul = new System.Windows.Forms.RichTextBox();
            this.test4_dira_ul = new System.Windows.Forms.RichTextBox();
            this.test3_dira_ul = new System.Windows.Forms.RichTextBox();
            this.test2_dira_ul = new System.Windows.Forms.RichTextBox();
            this.test1_dira_ul = new System.Windows.Forms.RichTextBox();
            this.test6_dira_ll = new System.Windows.Forms.RichTextBox();
            this.test5_dira_ll = new System.Windows.Forms.RichTextBox();
            this.test4_dira_ll = new System.Windows.Forms.RichTextBox();
            this.test3_dira_ll = new System.Windows.Forms.RichTextBox();
            this.test2_dira_ll = new System.Windows.Forms.RichTextBox();
            this.test1_dira_ll = new System.Windows.Forms.RichTextBox();
            this.test6_dirb_result = new System.Windows.Forms.RichTextBox();
            this.test5_dirb_result = new System.Windows.Forms.RichTextBox();
            this.test4_dirb_result = new System.Windows.Forms.RichTextBox();
            this.test3_dirb_result = new System.Windows.Forms.RichTextBox();
            this.test2_dirb_result = new System.Windows.Forms.RichTextBox();
            this.test1_dirb_result = new System.Windows.Forms.RichTextBox();
            this.test6_dirb_ul = new System.Windows.Forms.RichTextBox();
            this.test5_dirb_ul = new System.Windows.Forms.RichTextBox();
            this.test4_dirb_ul = new System.Windows.Forms.RichTextBox();
            this.test3_dirb_ul = new System.Windows.Forms.RichTextBox();
            this.test2_dirb_ul = new System.Windows.Forms.RichTextBox();
            this.test1_dirb_ul = new System.Windows.Forms.RichTextBox();
            this.test6_dirb_ll = new System.Windows.Forms.RichTextBox();
            this.test5_dirb_ll = new System.Windows.Forms.RichTextBox();
            this.test4_dirb_ll = new System.Windows.Forms.RichTextBox();
            this.test3_dirb_ll = new System.Windows.Forms.RichTextBox();
            this.test2_dirb_ll = new System.Windows.Forms.RichTextBox();
            this.test1_dirb_ll = new System.Windows.Forms.RichTextBox();
            this.test6_drven_result = new System.Windows.Forms.RichTextBox();
            this.test5_drven_result = new System.Windows.Forms.RichTextBox();
            this.test4_drven_result = new System.Windows.Forms.RichTextBox();
            this.test3_drven_result = new System.Windows.Forms.RichTextBox();
            this.test2_drven_result = new System.Windows.Forms.RichTextBox();
            this.test1_drven_result = new System.Windows.Forms.RichTextBox();
            this.test6_drven_ul = new System.Windows.Forms.RichTextBox();
            this.test5_drven_ul = new System.Windows.Forms.RichTextBox();
            this.test4_drven_ul = new System.Windows.Forms.RichTextBox();
            this.test3_drven_ul = new System.Windows.Forms.RichTextBox();
            this.test2_drven_ul = new System.Windows.Forms.RichTextBox();
            this.test1_drven_ul = new System.Windows.Forms.RichTextBox();
            this.test6_drven_ll = new System.Windows.Forms.RichTextBox();
            this.test5_drven_ll = new System.Windows.Forms.RichTextBox();
            this.test4_drven_ll = new System.Windows.Forms.RichTextBox();
            this.test3_drven_ll = new System.Windows.Forms.RichTextBox();
            this.test2_drven_ll = new System.Windows.Forms.RichTextBox();
            this.test1_drven_ll = new System.Windows.Forms.RichTextBox();
            this.test1_led_target = new System.Windows.Forms.RichTextBox();
            this.test2_led_target = new System.Windows.Forms.RichTextBox();
            this.test2_led_result = new System.Windows.Forms.RichTextBox();
            this.test3_led_target = new System.Windows.Forms.RichTextBox();
            this.test3_led_result = new System.Windows.Forms.RichTextBox();
            this.test4_led_target = new System.Windows.Forms.RichTextBox();
            this.test4_led_result = new System.Windows.Forms.RichTextBox();
            this.test5_led_target = new System.Windows.Forms.RichTextBox();
            this.test5_led_result = new System.Windows.Forms.RichTextBox();
            this.test6_led_target = new System.Windows.Forms.RichTextBox();
            this.test6_led_result = new System.Windows.Forms.RichTextBox();
            this.test1_result = new System.Windows.Forms.RichTextBox();
            this.test2_result = new System.Windows.Forms.RichTextBox();
            this.test3_result = new System.Windows.Forms.RichTextBox();
            this.test4_result = new System.Windows.Forms.RichTextBox();
            this.test5_result = new System.Windows.Forms.RichTextBox();
            this.test6_result = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.test7_sv3_result = new System.Windows.Forms.RichTextBox();
            this.test7_sv3_ul = new System.Windows.Forms.RichTextBox();
            this.test7_sv3_ll = new System.Windows.Forms.RichTextBox();
            this.test7_sv1_result = new System.Windows.Forms.RichTextBox();
            this.test7_sv1_ul = new System.Windows.Forms.RichTextBox();
            this.test7_sv1_ll = new System.Windows.Forms.RichTextBox();
            this.richTextBox143 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.test7_result = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lvdt_result = new System.Windows.Forms.RichTextBox();
            this.serialPortMilliohmmeter = new System.IO.Ports.SerialPort(this.components);
            this.sys_ready = new System.Windows.Forms.RichTextBox();
            this.meastime = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.debugit = new System.Windows.Forms.CheckBox();
            this.LedVideo = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.LedPicture = new System.Windows.Forms.PictureBox();
            this.Up = new System.Windows.Forms.Button();
            this.Down = new System.Windows.Forms.Button();
            this.Right = new System.Windows.Forms.Button();
            this.Left = new System.Windows.Forms.Button();
            this.Saturation = new System.Windows.Forms.RichTextBox();
            this.Brightness = new System.Windows.Forms.RichTextBox();
            this.Hue = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Minus = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.test6_sv2_result = new System.Windows.Forms.RichTextBox();
            this.test5_sv2_result = new System.Windows.Forms.RichTextBox();
            this.test4_sv2_result = new System.Windows.Forms.RichTextBox();
            this.test3_sv2_result = new System.Windows.Forms.RichTextBox();
            this.test2_sv2_result = new System.Windows.Forms.RichTextBox();
            this.test1_sv2_result = new System.Windows.Forms.RichTextBox();
            this.test6_sv4_result = new System.Windows.Forms.RichTextBox();
            this.test5_sv4_result = new System.Windows.Forms.RichTextBox();
            this.test4_sv4_result = new System.Windows.Forms.RichTextBox();
            this.test3_sv4_result = new System.Windows.Forms.RichTextBox();
            this.test2_sv4_result = new System.Windows.Forms.RichTextBox();
            this.test1_sv4_result = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pVEOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.P12401100 = new System.Windows.Forms.ToolStripMenuItem();
            this.P12401110 = new System.Windows.Forms.ToolStripMenuItem();
            this.P12401090 = new System.Windows.Forms.ToolStripMenuItem();
            this.P1240099 = new System.Windows.Forms.ToolStripMenuItem();
            this.P1240090 = new System.Windows.Forms.ToolStripMenuItem();
            this.pVEDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.P12401020 = new System.Windows.Forms.ToolStripMenuItem();
            this.P12401010 = new System.Windows.Forms.ToolStripMenuItem();
            this.pVECToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.P1240113 = new System.Windows.Forms.ToolStripMenuItem();
            this.P1240112 = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox9 = new System.Windows.Forms.RichTextBox();
            this.test8_sv1_ll = new System.Windows.Forms.RichTextBox();
            this.test8_sv2_result = new System.Windows.Forms.RichTextBox();
            this.test8_sv1_result = new System.Windows.Forms.RichTextBox();
            this.test8_sv1_ul = new System.Windows.Forms.RichTextBox();
            this.test8_sv3_ll = new System.Windows.Forms.RichTextBox();
            this.test8_sv3_result = new System.Windows.Forms.RichTextBox();
            this.test8_sv4_result = new System.Windows.Forms.RichTextBox();
            this.test8_sv3_ul = new System.Windows.Forms.RichTextBox();
            this.test8_led_result = new System.Windows.Forms.RichTextBox();
            this.test8_led_target = new System.Windows.Forms.RichTextBox();
            this.test8_spool_ll = new System.Windows.Forms.RichTextBox();
            this.test8_spool_result = new System.Windows.Forms.RichTextBox();
            this.test8_spool_ul = new System.Windows.Forms.RichTextBox();
            this.test8_dira_ll = new System.Windows.Forms.RichTextBox();
            this.test8_dira_result = new System.Windows.Forms.RichTextBox();
            this.test8_dira_ul = new System.Windows.Forms.RichTextBox();
            this.test8_dirb_ll = new System.Windows.Forms.RichTextBox();
            this.test8_dirb_result = new System.Windows.Forms.RichTextBox();
            this.test8_dirb_ul = new System.Windows.Forms.RichTextBox();
            this.test8_drven_ll = new System.Windows.Forms.RichTextBox();
            this.test8_drven_result = new System.Windows.Forms.RichTextBox();
            this.test8_drven_ul = new System.Windows.Forms.RichTextBox();
            this.test8_result = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SNInput = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.test0_sv4_result = new System.Windows.Forms.RichTextBox();
            this.test0_sv2_result = new System.Windows.Forms.RichTextBox();
            this.test0_result = new System.Windows.Forms.RichTextBox();
            this.test0_led_target = new System.Windows.Forms.RichTextBox();
            this.test0_drven_result = new System.Windows.Forms.RichTextBox();
            this.test0_drven_ul = new System.Windows.Forms.RichTextBox();
            this.test0_drven_ll = new System.Windows.Forms.RichTextBox();
            this.test0_dirb_result = new System.Windows.Forms.RichTextBox();
            this.test0_dirb_ul = new System.Windows.Forms.RichTextBox();
            this.test0_dirb_ll = new System.Windows.Forms.RichTextBox();
            this.test0_dira_result = new System.Windows.Forms.RichTextBox();
            this.test0_dira_ul = new System.Windows.Forms.RichTextBox();
            this.test0_dira_ll = new System.Windows.Forms.RichTextBox();
            this.test0_spool_result = new System.Windows.Forms.RichTextBox();
            this.test0_spool_ul = new System.Windows.Forms.RichTextBox();
            this.test0_spool_ll = new System.Windows.Forms.RichTextBox();
            this.test0_sv3_result = new System.Windows.Forms.RichTextBox();
            this.test0_sv3_ul = new System.Windows.Forms.RichTextBox();
            this.test0_sv3_ll = new System.Windows.Forms.RichTextBox();
            this.test0_sv1_result = new System.Windows.Forms.RichTextBox();
            this.test0_sv1_ul = new System.Windows.Forms.RichTextBox();
            this.test0_sv1_ll = new System.Windows.Forms.RichTextBox();
            this.test0_led_result = new System.Windows.Forms.RichTextBox();
            this.test_name0 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.LedVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LedPicture)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // testresult
            // 
            this.testresult.BackColor = System.Drawing.Color.White;
            this.testresult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.testresult.ForeColor = System.Drawing.Color.Black;
            this.testresult.Location = new System.Drawing.Point(814, 888);
            this.testresult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.testresult.Name = "testresult";
            this.testresult.Size = new System.Drawing.Size(294, 494);
            this.testresult.TabIndex = 13;
            // 
            // messagebox1
            // 
            this.messagebox1.BackColor = System.Drawing.Color.White;
            this.messagebox1.ForeColor = System.Drawing.Color.Black;
            this.messagebox1.Location = new System.Drawing.Point(1176, 888);
            this.messagebox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.messagebox1.Name = "messagebox1";
            this.messagebox1.ReadOnly = true;
            this.messagebox1.Size = new System.Drawing.Size(670, 454);
            this.messagebox1.TabIndex = 14;
            this.messagebox1.Text = "";
            // 
            // serialPortTester
            // 
            this.serialPortTester.ReadTimeout = 2000;
            this.serialPortTester.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPortTester_DataReceived);
            // 
            // plotwindow
            // 
            this.plotwindow.Location = new System.Drawing.Point(38, 888);
            this.plotwindow.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.plotwindow.Name = "plotwindow";
            this.plotwindow.ScrollGrace = 0D;
            this.plotwindow.ScrollMaxX = 0D;
            this.plotwindow.ScrollMaxY = 0D;
            this.plotwindow.ScrollMaxY2 = 0D;
            this.plotwindow.ScrollMinX = 0D;
            this.plotwindow.ScrollMinY = 0D;
            this.plotwindow.ScrollMinY2 = 0D;
            this.plotwindow.Size = new System.Drawing.Size(711, 497);
            this.plotwindow.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(32, 257);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1868, 30);
            this.label1.TabIndex = 59;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(33, 288);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1810, 30);
            this.label2.TabIndex = 60;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // article_description
            // 
            this.article_description.AutoSize = true;
            this.article_description.BackColor = System.Drawing.Color.Transparent;
            this.article_description.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.article_description.ForeColor = System.Drawing.Color.Black;
            this.article_description.Location = new System.Drawing.Point(32, 145);
            this.article_description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.article_description.Name = "article_description";
            this.article_description.Size = new System.Drawing.Size(185, 33);
            this.article_description.TabIndex = 61;
            this.article_description.Text = "Articlenumber:";
            // 
            // article_code
            // 
            this.article_code.AutoSize = true;
            this.article_code.BackColor = System.Drawing.Color.Transparent;
            this.article_code.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.article_code.ForeColor = System.Drawing.Color.Black;
            this.article_code.Location = new System.Drawing.Point(32, 180);
            this.article_code.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.article_code.Name = "article_code";
            this.article_code.Size = new System.Drawing.Size(153, 33);
            this.article_code.TabIndex = 62;
            this.article_code.Text = "Articlecode:";
            // 
            // articlenumber_field
            // 
            this.articlenumber_field.BackColor = System.Drawing.Color.White;
            this.articlenumber_field.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.articlenumber_field.ForeColor = System.Drawing.Color.Black;
            this.articlenumber_field.Location = new System.Drawing.Point(242, 152);
            this.articlenumber_field.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.articlenumber_field.Multiline = false;
            this.articlenumber_field.Name = "articlenumber_field";
            this.articlenumber_field.Size = new System.Drawing.Size(133, 29);
            this.articlenumber_field.TabIndex = 63;
            this.articlenumber_field.Text = "";
            // 
            // articlecode_field
            // 
            this.articlecode_field.BackColor = System.Drawing.Color.White;
            this.articlecode_field.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.articlecode_field.ForeColor = System.Drawing.Color.Black;
            this.articlecode_field.Location = new System.Drawing.Point(242, 187);
            this.articlecode_field.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.articlecode_field.Multiline = false;
            this.articlecode_field.Name = "articlecode_field";
            this.articlecode_field.Size = new System.Drawing.Size(66, 29);
            this.articlecode_field.TabIndex = 64;
            this.articlecode_field.Text = "";
            // 
            // test_name1
            // 
            this.test_name1.BackColor = System.Drawing.Color.White;
            this.test_name1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.test_name1.ForeColor = System.Drawing.Color.Black;
            this.test_name1.Location = new System.Drawing.Point(38, 350);
            this.test_name1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test_name1.Multiline = false;
            this.test_name1.Name = "test_name1";
            this.test_name1.Size = new System.Drawing.Size(66, 29);
            this.test_name1.TabIndex = 65;
            this.test_name1.Text = "Test 1";
            // 
            // test_name2
            // 
            this.test_name2.BackColor = System.Drawing.Color.White;
            this.test_name2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.test_name2.ForeColor = System.Drawing.Color.Black;
            this.test_name2.Location = new System.Drawing.Point(38, 390);
            this.test_name2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test_name2.Multiline = false;
            this.test_name2.Name = "test_name2";
            this.test_name2.Size = new System.Drawing.Size(66, 29);
            this.test_name2.TabIndex = 66;
            this.test_name2.Text = "Test 2";
            // 
            // richTextBox5
            // 
            this.richTextBox5.BackColor = System.Drawing.Color.White;
            this.richTextBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox5.ForeColor = System.Drawing.Color.Black;
            this.richTextBox5.Location = new System.Drawing.Point(38, 430);
            this.richTextBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox5.Multiline = false;
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.Size = new System.Drawing.Size(66, 29);
            this.richTextBox5.TabIndex = 67;
            this.richTextBox5.Text = "Test 3";
            // 
            // richTextBox6
            // 
            this.richTextBox6.BackColor = System.Drawing.Color.White;
            this.richTextBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox6.ForeColor = System.Drawing.Color.Black;
            this.richTextBox6.Location = new System.Drawing.Point(38, 470);
            this.richTextBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox6.Multiline = false;
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.Size = new System.Drawing.Size(66, 29);
            this.richTextBox6.TabIndex = 68;
            this.richTextBox6.Text = "Test 4";
            // 
            // richTextBox7
            // 
            this.richTextBox7.BackColor = System.Drawing.Color.White;
            this.richTextBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox7.ForeColor = System.Drawing.Color.Black;
            this.richTextBox7.Location = new System.Drawing.Point(38, 510);
            this.richTextBox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox7.Multiline = false;
            this.richTextBox7.Name = "richTextBox7";
            this.richTextBox7.Size = new System.Drawing.Size(66, 29);
            this.richTextBox7.TabIndex = 69;
            this.richTextBox7.Text = "Test 5";
            // 
            // richTextBox8
            // 
            this.richTextBox8.BackColor = System.Drawing.Color.White;
            this.richTextBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox8.ForeColor = System.Drawing.Color.Black;
            this.richTextBox8.Location = new System.Drawing.Point(38, 550);
            this.richTextBox8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox8.Multiline = false;
            this.richTextBox8.Name = "richTextBox8";
            this.richTextBox8.Size = new System.Drawing.Size(66, 29);
            this.richTextBox8.TabIndex = 70;
            this.richTextBox8.Text = "Test 6";
            // 
            // test1_led_result
            // 
            this.test1_led_result.BackColor = System.Drawing.Color.White;
            this.test1_led_result.ForeColor = System.Drawing.Color.Black;
            this.test1_led_result.Location = new System.Drawing.Point(732, 350);
            this.test1_led_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test1_led_result.Multiline = false;
            this.test1_led_result.Name = "test1_led_result";
            this.test1_led_result.Size = new System.Drawing.Size(80, 29);
            this.test1_led_result.TabIndex = 71;
            this.test1_led_result.Text = "";
            // 
            // test6_sv1_ll
            // 
            this.test6_sv1_ll.BackColor = System.Drawing.Color.White;
            this.test6_sv1_ll.ForeColor = System.Drawing.Color.Black;
            this.test6_sv1_ll.Location = new System.Drawing.Point(111, 550);
            this.test6_sv1_ll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test6_sv1_ll.Multiline = false;
            this.test6_sv1_ll.Name = "test6_sv1_ll";
            this.test6_sv1_ll.Size = new System.Drawing.Size(66, 29);
            this.test6_sv1_ll.TabIndex = 77;
            this.test6_sv1_ll.Text = "";
            // 
            // test5_sv1_ll
            // 
            this.test5_sv1_ll.BackColor = System.Drawing.Color.White;
            this.test5_sv1_ll.ForeColor = System.Drawing.Color.Black;
            this.test5_sv1_ll.Location = new System.Drawing.Point(111, 510);
            this.test5_sv1_ll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test5_sv1_ll.Multiline = false;
            this.test5_sv1_ll.Name = "test5_sv1_ll";
            this.test5_sv1_ll.Size = new System.Drawing.Size(66, 29);
            this.test5_sv1_ll.TabIndex = 76;
            this.test5_sv1_ll.Text = "";
            // 
            // test4_sv1_ll
            // 
            this.test4_sv1_ll.BackColor = System.Drawing.Color.White;
            this.test4_sv1_ll.ForeColor = System.Drawing.Color.Black;
            this.test4_sv1_ll.Location = new System.Drawing.Point(111, 470);
            this.test4_sv1_ll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test4_sv1_ll.Multiline = false;
            this.test4_sv1_ll.Name = "test4_sv1_ll";
            this.test4_sv1_ll.Size = new System.Drawing.Size(66, 29);
            this.test4_sv1_ll.TabIndex = 75;
            this.test4_sv1_ll.Text = "";
            // 
            // test3_sv1_ll
            // 
            this.test3_sv1_ll.BackColor = System.Drawing.Color.White;
            this.test3_sv1_ll.ForeColor = System.Drawing.Color.Black;
            this.test3_sv1_ll.Location = new System.Drawing.Point(111, 430);
            this.test3_sv1_ll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test3_sv1_ll.Multiline = false;
            this.test3_sv1_ll.Name = "test3_sv1_ll";
            this.test3_sv1_ll.Size = new System.Drawing.Size(66, 29);
            this.test3_sv1_ll.TabIndex = 74;
            this.test3_sv1_ll.Text = "";
            // 
            // test2_sv1_ll
            // 
            this.test2_sv1_ll.BackColor = System.Drawing.Color.White;
            this.test2_sv1_ll.ForeColor = System.Drawing.Color.Black;
            this.test2_sv1_ll.Location = new System.Drawing.Point(111, 390);
            this.test2_sv1_ll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test2_sv1_ll.Multiline = false;
            this.test2_sv1_ll.Name = "test2_sv1_ll";
            this.test2_sv1_ll.Size = new System.Drawing.Size(66, 29);
            this.test2_sv1_ll.TabIndex = 73;
            this.test2_sv1_ll.Text = "";
            // 
            // test1_sv1_ll
            // 
            this.test1_sv1_ll.BackColor = System.Drawing.Color.White;
            this.test1_sv1_ll.ForeColor = System.Drawing.Color.Black;
            this.test1_sv1_ll.Location = new System.Drawing.Point(111, 350);
            this.test1_sv1_ll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test1_sv1_ll.Multiline = false;
            this.test1_sv1_ll.Name = "test1_sv1_ll";
            this.test1_sv1_ll.Size = new System.Drawing.Size(66, 29);
            this.test1_sv1_ll.TabIndex = 72;
            this.test1_sv1_ll.Text = "";
            // 
            // test6_sv1_ul
            // 
            this.test6_sv1_ul.BackColor = System.Drawing.Color.White;
            this.test6_sv1_ul.ForeColor = System.Drawing.Color.Black;
            this.test6_sv1_ul.Location = new System.Drawing.Point(322, 550);
            this.test6_sv1_ul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test6_sv1_ul.Multiline = false;
            this.test6_sv1_ul.Name = "test6_sv1_ul";
            this.test6_sv1_ul.Size = new System.Drawing.Size(66, 29);
            this.test6_sv1_ul.TabIndex = 83;
            this.test6_sv1_ul.Text = "";
            // 
            // test5_sv1_ul
            // 
            this.test5_sv1_ul.BackColor = System.Drawing.Color.White;
            this.test5_sv1_ul.ForeColor = System.Drawing.Color.Black;
            this.test5_sv1_ul.Location = new System.Drawing.Point(322, 510);
            this.test5_sv1_ul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test5_sv1_ul.Multiline = false;
            this.test5_sv1_ul.Name = "test5_sv1_ul";
            this.test5_sv1_ul.Size = new System.Drawing.Size(66, 29);
            this.test5_sv1_ul.TabIndex = 82;
            this.test5_sv1_ul.Text = "";
            // 
            // test4_sv1_ul
            // 
            this.test4_sv1_ul.BackColor = System.Drawing.Color.White;
            this.test4_sv1_ul.ForeColor = System.Drawing.Color.Black;
            this.test4_sv1_ul.Location = new System.Drawing.Point(322, 470);
            this.test4_sv1_ul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test4_sv1_ul.Multiline = false;
            this.test4_sv1_ul.Name = "test4_sv1_ul";
            this.test4_sv1_ul.Size = new System.Drawing.Size(66, 29);
            this.test4_sv1_ul.TabIndex = 81;
            this.test4_sv1_ul.Text = "";
            // 
            // test3_sv1_ul
            // 
            this.test3_sv1_ul.BackColor = System.Drawing.Color.White;
            this.test3_sv1_ul.ForeColor = System.Drawing.Color.Black;
            this.test3_sv1_ul.Location = new System.Drawing.Point(322, 430);
            this.test3_sv1_ul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test3_sv1_ul.Multiline = false;
            this.test3_sv1_ul.Name = "test3_sv1_ul";
            this.test3_sv1_ul.Size = new System.Drawing.Size(66, 29);
            this.test3_sv1_ul.TabIndex = 80;
            this.test3_sv1_ul.Text = "";
            // 
            // test2_sv1_ul
            // 
            this.test2_sv1_ul.BackColor = System.Drawing.Color.White;
            this.test2_sv1_ul.ForeColor = System.Drawing.Color.Black;
            this.test2_sv1_ul.Location = new System.Drawing.Point(322, 390);
            this.test2_sv1_ul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test2_sv1_ul.Multiline = false;
            this.test2_sv1_ul.Name = "test2_sv1_ul";
            this.test2_sv1_ul.Size = new System.Drawing.Size(66, 29);
            this.test2_sv1_ul.TabIndex = 79;
            this.test2_sv1_ul.Text = "";
            // 
            // test1_sv1_ul
            // 
            this.test1_sv1_ul.BackColor = System.Drawing.Color.White;
            this.test1_sv1_ul.ForeColor = System.Drawing.Color.Black;
            this.test1_sv1_ul.Location = new System.Drawing.Point(322, 350);
            this.test1_sv1_ul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test1_sv1_ul.Multiline = false;
            this.test1_sv1_ul.Name = "test1_sv1_ul";
            this.test1_sv1_ul.Size = new System.Drawing.Size(66, 29);
            this.test1_sv1_ul.TabIndex = 78;
            this.test1_sv1_ul.Text = "";
            // 
            // test6_sv1_result
            // 
            this.test6_sv1_result.BackColor = System.Drawing.Color.White;
            this.test6_sv1_result.ForeColor = System.Drawing.Color.Black;
            this.test6_sv1_result.Location = new System.Drawing.Point(252, 550);
            this.test6_sv1_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test6_sv1_result.Multiline = false;
            this.test6_sv1_result.Name = "test6_sv1_result";
            this.test6_sv1_result.Size = new System.Drawing.Size(66, 29);
            this.test6_sv1_result.TabIndex = 89;
            this.test6_sv1_result.Text = "";
            // 
            // test5_sv1_result
            // 
            this.test5_sv1_result.BackColor = System.Drawing.Color.White;
            this.test5_sv1_result.ForeColor = System.Drawing.Color.Black;
            this.test5_sv1_result.Location = new System.Drawing.Point(252, 510);
            this.test5_sv1_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test5_sv1_result.Multiline = false;
            this.test5_sv1_result.Name = "test5_sv1_result";
            this.test5_sv1_result.Size = new System.Drawing.Size(66, 29);
            this.test5_sv1_result.TabIndex = 88;
            this.test5_sv1_result.Text = "";
            // 
            // test4_sv1_result
            // 
            this.test4_sv1_result.BackColor = System.Drawing.Color.White;
            this.test4_sv1_result.ForeColor = System.Drawing.Color.Black;
            this.test4_sv1_result.Location = new System.Drawing.Point(252, 470);
            this.test4_sv1_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test4_sv1_result.Multiline = false;
            this.test4_sv1_result.Name = "test4_sv1_result";
            this.test4_sv1_result.Size = new System.Drawing.Size(66, 29);
            this.test4_sv1_result.TabIndex = 87;
            this.test4_sv1_result.Text = "";
            // 
            // test3_sv1_result
            // 
            this.test3_sv1_result.BackColor = System.Drawing.Color.White;
            this.test3_sv1_result.ForeColor = System.Drawing.Color.Black;
            this.test3_sv1_result.Location = new System.Drawing.Point(252, 430);
            this.test3_sv1_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test3_sv1_result.Multiline = false;
            this.test3_sv1_result.Name = "test3_sv1_result";
            this.test3_sv1_result.Size = new System.Drawing.Size(66, 29);
            this.test3_sv1_result.TabIndex = 86;
            this.test3_sv1_result.Text = "";
            // 
            // test2_sv1_result
            // 
            this.test2_sv1_result.BackColor = System.Drawing.Color.White;
            this.test2_sv1_result.ForeColor = System.Drawing.Color.Black;
            this.test2_sv1_result.Location = new System.Drawing.Point(252, 390);
            this.test2_sv1_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test2_sv1_result.Multiline = false;
            this.test2_sv1_result.Name = "test2_sv1_result";
            this.test2_sv1_result.Size = new System.Drawing.Size(66, 29);
            this.test2_sv1_result.TabIndex = 85;
            this.test2_sv1_result.Text = "";
            // 
            // test1_sv1_result
            // 
            this.test1_sv1_result.BackColor = System.Drawing.Color.White;
            this.test1_sv1_result.ForeColor = System.Drawing.Color.Black;
            this.test1_sv1_result.Location = new System.Drawing.Point(252, 350);
            this.test1_sv1_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test1_sv1_result.Multiline = false;
            this.test1_sv1_result.Name = "test1_sv1_result";
            this.test1_sv1_result.Size = new System.Drawing.Size(66, 29);
            this.test1_sv1_result.TabIndex = 84;
            this.test1_sv1_result.Text = "";
            // 
            // test6_sv3_result
            // 
            this.test6_sv3_result.BackColor = System.Drawing.Color.White;
            this.test6_sv3_result.ForeColor = System.Drawing.Color.Black;
            this.test6_sv3_result.Location = new System.Drawing.Point(488, 550);
            this.test6_sv3_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test6_sv3_result.Multiline = false;
            this.test6_sv3_result.Name = "test6_sv3_result";
            this.test6_sv3_result.Size = new System.Drawing.Size(66, 29);
            this.test6_sv3_result.TabIndex = 107;
            this.test6_sv3_result.Text = "";
            // 
            // test5_sv3_result
            // 
            this.test5_sv3_result.BackColor = System.Drawing.Color.White;
            this.test5_sv3_result.ForeColor = System.Drawing.Color.Black;
            this.test5_sv3_result.Location = new System.Drawing.Point(488, 510);
            this.test5_sv3_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test5_sv3_result.Multiline = false;
            this.test5_sv3_result.Name = "test5_sv3_result";
            this.test5_sv3_result.Size = new System.Drawing.Size(66, 29);
            this.test5_sv3_result.TabIndex = 106;
            this.test5_sv3_result.Text = "";
            // 
            // test4_sv3_result
            // 
            this.test4_sv3_result.BackColor = System.Drawing.Color.White;
            this.test4_sv3_result.ForeColor = System.Drawing.Color.Black;
            this.test4_sv3_result.Location = new System.Drawing.Point(488, 470);
            this.test4_sv3_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test4_sv3_result.Multiline = false;
            this.test4_sv3_result.Name = "test4_sv3_result";
            this.test4_sv3_result.Size = new System.Drawing.Size(66, 29);
            this.test4_sv3_result.TabIndex = 105;
            this.test4_sv3_result.Text = "";
            // 
            // test3_sv3_result
            // 
            this.test3_sv3_result.BackColor = System.Drawing.Color.White;
            this.test3_sv3_result.ForeColor = System.Drawing.Color.Black;
            this.test3_sv3_result.Location = new System.Drawing.Point(488, 430);
            this.test3_sv3_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test3_sv3_result.Multiline = false;
            this.test3_sv3_result.Name = "test3_sv3_result";
            this.test3_sv3_result.Size = new System.Drawing.Size(66, 29);
            this.test3_sv3_result.TabIndex = 104;
            this.test3_sv3_result.Text = "";
            // 
            // test2_sv3_result
            // 
            this.test2_sv3_result.BackColor = System.Drawing.Color.White;
            this.test2_sv3_result.ForeColor = System.Drawing.Color.Black;
            this.test2_sv3_result.Location = new System.Drawing.Point(488, 390);
            this.test2_sv3_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test2_sv3_result.Multiline = false;
            this.test2_sv3_result.Name = "test2_sv3_result";
            this.test2_sv3_result.Size = new System.Drawing.Size(66, 29);
            this.test2_sv3_result.TabIndex = 103;
            this.test2_sv3_result.Text = "";
            // 
            // test1_sv3_result
            // 
            this.test1_sv3_result.BackColor = System.Drawing.Color.White;
            this.test1_sv3_result.ForeColor = System.Drawing.Color.Black;
            this.test1_sv3_result.Location = new System.Drawing.Point(488, 350);
            this.test1_sv3_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test1_sv3_result.Multiline = false;
            this.test1_sv3_result.Name = "test1_sv3_result";
            this.test1_sv3_result.Size = new System.Drawing.Size(66, 29);
            this.test1_sv3_result.TabIndex = 102;
            this.test1_sv3_result.Text = "";
            // 
            // test6_sv3_ul
            // 
            this.test6_sv3_ul.BackColor = System.Drawing.Color.White;
            this.test6_sv3_ul.ForeColor = System.Drawing.Color.Black;
            this.test6_sv3_ul.Location = new System.Drawing.Point(628, 550);
            this.test6_sv3_ul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test6_sv3_ul.Multiline = false;
            this.test6_sv3_ul.Name = "test6_sv3_ul";
            this.test6_sv3_ul.Size = new System.Drawing.Size(66, 29);
            this.test6_sv3_ul.TabIndex = 101;
            this.test6_sv3_ul.Text = "";
            // 
            // test5_sv3_ul
            // 
            this.test5_sv3_ul.BackColor = System.Drawing.Color.White;
            this.test5_sv3_ul.ForeColor = System.Drawing.Color.Black;
            this.test5_sv3_ul.Location = new System.Drawing.Point(628, 510);
            this.test5_sv3_ul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test5_sv3_ul.Multiline = false;
            this.test5_sv3_ul.Name = "test5_sv3_ul";
            this.test5_sv3_ul.Size = new System.Drawing.Size(66, 29);
            this.test5_sv3_ul.TabIndex = 100;
            this.test5_sv3_ul.Text = "";
            // 
            // test4_sv3_ul
            // 
            this.test4_sv3_ul.BackColor = System.Drawing.Color.White;
            this.test4_sv3_ul.ForeColor = System.Drawing.Color.Black;
            this.test4_sv3_ul.Location = new System.Drawing.Point(628, 470);
            this.test4_sv3_ul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test4_sv3_ul.Multiline = false;
            this.test4_sv3_ul.Name = "test4_sv3_ul";
            this.test4_sv3_ul.Size = new System.Drawing.Size(66, 29);
            this.test4_sv3_ul.TabIndex = 99;
            this.test4_sv3_ul.Text = "";
            // 
            // test3_sv3_ul
            // 
            this.test3_sv3_ul.BackColor = System.Drawing.Color.White;
            this.test3_sv3_ul.ForeColor = System.Drawing.Color.Black;
            this.test3_sv3_ul.Location = new System.Drawing.Point(628, 430);
            this.test3_sv3_ul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test3_sv3_ul.Multiline = false;
            this.test3_sv3_ul.Name = "test3_sv3_ul";
            this.test3_sv3_ul.Size = new System.Drawing.Size(66, 29);
            this.test3_sv3_ul.TabIndex = 98;
            this.test3_sv3_ul.Text = "";
            // 
            // test2_sv3_ul
            // 
            this.test2_sv3_ul.BackColor = System.Drawing.Color.White;
            this.test2_sv3_ul.ForeColor = System.Drawing.Color.Black;
            this.test2_sv3_ul.Location = new System.Drawing.Point(628, 390);
            this.test2_sv3_ul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test2_sv3_ul.Multiline = false;
            this.test2_sv3_ul.Name = "test2_sv3_ul";
            this.test2_sv3_ul.Size = new System.Drawing.Size(66, 29);
            this.test2_sv3_ul.TabIndex = 97;
            this.test2_sv3_ul.Text = "";
            // 
            // test1_sv3_ul
            // 
            this.test1_sv3_ul.BackColor = System.Drawing.Color.White;
            this.test1_sv3_ul.ForeColor = System.Drawing.Color.Black;
            this.test1_sv3_ul.Location = new System.Drawing.Point(628, 350);
            this.test1_sv3_ul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test1_sv3_ul.Multiline = false;
            this.test1_sv3_ul.Name = "test1_sv3_ul";
            this.test1_sv3_ul.Size = new System.Drawing.Size(66, 29);
            this.test1_sv3_ul.TabIndex = 96;
            this.test1_sv3_ul.Text = "";
            // 
            // test6_sv3_ll
            // 
            this.test6_sv3_ll.BackColor = System.Drawing.Color.White;
            this.test6_sv3_ll.ForeColor = System.Drawing.Color.Black;
            this.test6_sv3_ll.Location = new System.Drawing.Point(417, 550);
            this.test6_sv3_ll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test6_sv3_ll.Multiline = false;
            this.test6_sv3_ll.Name = "test6_sv3_ll";
            this.test6_sv3_ll.Size = new System.Drawing.Size(66, 29);
            this.test6_sv3_ll.TabIndex = 95;
            this.test6_sv3_ll.Text = "";
            // 
            // test5_sv3_ll
            // 
            this.test5_sv3_ll.BackColor = System.Drawing.Color.White;
            this.test5_sv3_ll.ForeColor = System.Drawing.Color.Black;
            this.test5_sv3_ll.Location = new System.Drawing.Point(417, 510);
            this.test5_sv3_ll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test5_sv3_ll.Multiline = false;
            this.test5_sv3_ll.Name = "test5_sv3_ll";
            this.test5_sv3_ll.Size = new System.Drawing.Size(66, 29);
            this.test5_sv3_ll.TabIndex = 94;
            this.test5_sv3_ll.Text = "";
            // 
            // test4_sv3_ll
            // 
            this.test4_sv3_ll.BackColor = System.Drawing.Color.White;
            this.test4_sv3_ll.ForeColor = System.Drawing.Color.Black;
            this.test4_sv3_ll.Location = new System.Drawing.Point(417, 470);
            this.test4_sv3_ll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test4_sv3_ll.Multiline = false;
            this.test4_sv3_ll.Name = "test4_sv3_ll";
            this.test4_sv3_ll.Size = new System.Drawing.Size(66, 29);
            this.test4_sv3_ll.TabIndex = 93;
            this.test4_sv3_ll.Text = "";
            // 
            // test3_sv3_ll
            // 
            this.test3_sv3_ll.BackColor = System.Drawing.Color.White;
            this.test3_sv3_ll.ForeColor = System.Drawing.Color.Black;
            this.test3_sv3_ll.Location = new System.Drawing.Point(417, 430);
            this.test3_sv3_ll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test3_sv3_ll.Multiline = false;
            this.test3_sv3_ll.Name = "test3_sv3_ll";
            this.test3_sv3_ll.Size = new System.Drawing.Size(66, 29);
            this.test3_sv3_ll.TabIndex = 92;
            this.test3_sv3_ll.Text = "";
            // 
            // test2_sv3_ll
            // 
            this.test2_sv3_ll.BackColor = System.Drawing.Color.White;
            this.test2_sv3_ll.ForeColor = System.Drawing.Color.Black;
            this.test2_sv3_ll.Location = new System.Drawing.Point(417, 390);
            this.test2_sv3_ll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test2_sv3_ll.Multiline = false;
            this.test2_sv3_ll.Name = "test2_sv3_ll";
            this.test2_sv3_ll.Size = new System.Drawing.Size(66, 29);
            this.test2_sv3_ll.TabIndex = 91;
            this.test2_sv3_ll.Text = "";
            // 
            // test1_sv3_ll
            // 
            this.test1_sv3_ll.BackColor = System.Drawing.Color.White;
            this.test1_sv3_ll.ForeColor = System.Drawing.Color.Black;
            this.test1_sv3_ll.Location = new System.Drawing.Point(417, 350);
            this.test1_sv3_ll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test1_sv3_ll.Multiline = false;
            this.test1_sv3_ll.Name = "test1_sv3_ll";
            this.test1_sv3_ll.Size = new System.Drawing.Size(66, 29);
            this.test1_sv3_ll.TabIndex = 90;
            this.test1_sv3_ll.Text = "";
            // 
            // test6_spool_result
            // 
            this.test6_spool_result.BackColor = System.Drawing.Color.White;
            this.test6_spool_result.ForeColor = System.Drawing.Color.Black;
            this.test6_spool_result.Location = new System.Drawing.Point(992, 550);
            this.test6_spool_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test6_spool_result.Multiline = false;
            this.test6_spool_result.Name = "test6_spool_result";
            this.test6_spool_result.Size = new System.Drawing.Size(66, 29);
            this.test6_spool_result.TabIndex = 125;
            this.test6_spool_result.Text = "";
            // 
            // test5_spool_result
            // 
            this.test5_spool_result.BackColor = System.Drawing.Color.White;
            this.test5_spool_result.ForeColor = System.Drawing.Color.Black;
            this.test5_spool_result.Location = new System.Drawing.Point(992, 510);
            this.test5_spool_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test5_spool_result.Multiline = false;
            this.test5_spool_result.Name = "test5_spool_result";
            this.test5_spool_result.Size = new System.Drawing.Size(66, 29);
            this.test5_spool_result.TabIndex = 124;
            this.test5_spool_result.Text = "";
            // 
            // test4_spool_result
            // 
            this.test4_spool_result.BackColor = System.Drawing.Color.White;
            this.test4_spool_result.ForeColor = System.Drawing.Color.Black;
            this.test4_spool_result.Location = new System.Drawing.Point(992, 470);
            this.test4_spool_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test4_spool_result.Multiline = false;
            this.test4_spool_result.Name = "test4_spool_result";
            this.test4_spool_result.Size = new System.Drawing.Size(66, 29);
            this.test4_spool_result.TabIndex = 123;
            this.test4_spool_result.Text = "";
            // 
            // test3_spool_result
            // 
            this.test3_spool_result.BackColor = System.Drawing.Color.White;
            this.test3_spool_result.ForeColor = System.Drawing.Color.Black;
            this.test3_spool_result.Location = new System.Drawing.Point(992, 430);
            this.test3_spool_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test3_spool_result.Multiline = false;
            this.test3_spool_result.Name = "test3_spool_result";
            this.test3_spool_result.Size = new System.Drawing.Size(66, 29);
            this.test3_spool_result.TabIndex = 122;
            this.test3_spool_result.Text = "";
            // 
            // test2_spool_result
            // 
            this.test2_spool_result.BackColor = System.Drawing.Color.White;
            this.test2_spool_result.ForeColor = System.Drawing.Color.Black;
            this.test2_spool_result.Location = new System.Drawing.Point(992, 390);
            this.test2_spool_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test2_spool_result.Multiline = false;
            this.test2_spool_result.Name = "test2_spool_result";
            this.test2_spool_result.Size = new System.Drawing.Size(66, 29);
            this.test2_spool_result.TabIndex = 121;
            this.test2_spool_result.Text = "";
            // 
            // test1_spool_result
            // 
            this.test1_spool_result.BackColor = System.Drawing.Color.White;
            this.test1_spool_result.ForeColor = System.Drawing.Color.Black;
            this.test1_spool_result.Location = new System.Drawing.Point(992, 350);
            this.test1_spool_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test1_spool_result.Multiline = false;
            this.test1_spool_result.Name = "test1_spool_result";
            this.test1_spool_result.Size = new System.Drawing.Size(66, 29);
            this.test1_spool_result.TabIndex = 120;
            this.test1_spool_result.Text = "";
            // 
            // test6_spool_ul
            // 
            this.test6_spool_ul.BackColor = System.Drawing.Color.White;
            this.test6_spool_ul.ForeColor = System.Drawing.Color.Black;
            this.test6_spool_ul.Location = new System.Drawing.Point(1060, 550);
            this.test6_spool_ul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test6_spool_ul.Multiline = false;
            this.test6_spool_ul.Name = "test6_spool_ul";
            this.test6_spool_ul.Size = new System.Drawing.Size(66, 29);
            this.test6_spool_ul.TabIndex = 119;
            this.test6_spool_ul.Text = "";
            // 
            // test5_spool_ul
            // 
            this.test5_spool_ul.BackColor = System.Drawing.Color.White;
            this.test5_spool_ul.ForeColor = System.Drawing.Color.Black;
            this.test5_spool_ul.Location = new System.Drawing.Point(1060, 510);
            this.test5_spool_ul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test5_spool_ul.Multiline = false;
            this.test5_spool_ul.Name = "test5_spool_ul";
            this.test5_spool_ul.Size = new System.Drawing.Size(66, 29);
            this.test5_spool_ul.TabIndex = 118;
            this.test5_spool_ul.Text = "";
            // 
            // test4_spool_ul
            // 
            this.test4_spool_ul.BackColor = System.Drawing.Color.White;
            this.test4_spool_ul.ForeColor = System.Drawing.Color.Black;
            this.test4_spool_ul.Location = new System.Drawing.Point(1060, 470);
            this.test4_spool_ul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test4_spool_ul.Multiline = false;
            this.test4_spool_ul.Name = "test4_spool_ul";
            this.test4_spool_ul.Size = new System.Drawing.Size(66, 29);
            this.test4_spool_ul.TabIndex = 117;
            this.test4_spool_ul.Text = "";
            // 
            // test3_spool_ul
            // 
            this.test3_spool_ul.BackColor = System.Drawing.Color.White;
            this.test3_spool_ul.ForeColor = System.Drawing.Color.Black;
            this.test3_spool_ul.Location = new System.Drawing.Point(1060, 430);
            this.test3_spool_ul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test3_spool_ul.Multiline = false;
            this.test3_spool_ul.Name = "test3_spool_ul";
            this.test3_spool_ul.Size = new System.Drawing.Size(66, 29);
            this.test3_spool_ul.TabIndex = 116;
            this.test3_spool_ul.Text = "";
            // 
            // test2_spool_ul
            // 
            this.test2_spool_ul.BackColor = System.Drawing.Color.White;
            this.test2_spool_ul.ForeColor = System.Drawing.Color.Black;
            this.test2_spool_ul.Location = new System.Drawing.Point(1060, 390);
            this.test2_spool_ul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test2_spool_ul.Multiline = false;
            this.test2_spool_ul.Name = "test2_spool_ul";
            this.test2_spool_ul.Size = new System.Drawing.Size(66, 29);
            this.test2_spool_ul.TabIndex = 115;
            this.test2_spool_ul.Text = "";
            // 
            // test1_spool_ul
            // 
            this.test1_spool_ul.BackColor = System.Drawing.Color.White;
            this.test1_spool_ul.ForeColor = System.Drawing.Color.Black;
            this.test1_spool_ul.Location = new System.Drawing.Point(1060, 350);
            this.test1_spool_ul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test1_spool_ul.Multiline = false;
            this.test1_spool_ul.Name = "test1_spool_ul";
            this.test1_spool_ul.Size = new System.Drawing.Size(66, 29);
            this.test1_spool_ul.TabIndex = 114;
            this.test1_spool_ul.Text = "";
            // 
            // test6_spool_ll
            // 
            this.test6_spool_ll.BackColor = System.Drawing.Color.White;
            this.test6_spool_ll.ForeColor = System.Drawing.Color.Black;
            this.test6_spool_ll.Location = new System.Drawing.Point(922, 550);
            this.test6_spool_ll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test6_spool_ll.Multiline = false;
            this.test6_spool_ll.Name = "test6_spool_ll";
            this.test6_spool_ll.Size = new System.Drawing.Size(66, 29);
            this.test6_spool_ll.TabIndex = 113;
            this.test6_spool_ll.Text = "";
            // 
            // test5_spool_ll
            // 
            this.test5_spool_ll.BackColor = System.Drawing.Color.White;
            this.test5_spool_ll.ForeColor = System.Drawing.Color.Black;
            this.test5_spool_ll.Location = new System.Drawing.Point(922, 510);
            this.test5_spool_ll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test5_spool_ll.Multiline = false;
            this.test5_spool_ll.Name = "test5_spool_ll";
            this.test5_spool_ll.Size = new System.Drawing.Size(66, 29);
            this.test5_spool_ll.TabIndex = 112;
            this.test5_spool_ll.Text = "";
            // 
            // test4_spool_ll
            // 
            this.test4_spool_ll.BackColor = System.Drawing.Color.White;
            this.test4_spool_ll.ForeColor = System.Drawing.Color.Black;
            this.test4_spool_ll.Location = new System.Drawing.Point(922, 470);
            this.test4_spool_ll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test4_spool_ll.Multiline = false;
            this.test4_spool_ll.Name = "test4_spool_ll";
            this.test4_spool_ll.Size = new System.Drawing.Size(66, 29);
            this.test4_spool_ll.TabIndex = 111;
            this.test4_spool_ll.Text = "";
            // 
            // test3_spool_ll
            // 
            this.test3_spool_ll.BackColor = System.Drawing.Color.White;
            this.test3_spool_ll.ForeColor = System.Drawing.Color.Black;
            this.test3_spool_ll.Location = new System.Drawing.Point(922, 430);
            this.test3_spool_ll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test3_spool_ll.Multiline = false;
            this.test3_spool_ll.Name = "test3_spool_ll";
            this.test3_spool_ll.Size = new System.Drawing.Size(66, 29);
            this.test3_spool_ll.TabIndex = 110;
            this.test3_spool_ll.Text = "";
            // 
            // test2_spool_ll
            // 
            this.test2_spool_ll.BackColor = System.Drawing.Color.White;
            this.test2_spool_ll.ForeColor = System.Drawing.Color.Black;
            this.test2_spool_ll.Location = new System.Drawing.Point(922, 390);
            this.test2_spool_ll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test2_spool_ll.Multiline = false;
            this.test2_spool_ll.Name = "test2_spool_ll";
            this.test2_spool_ll.Size = new System.Drawing.Size(66, 29);
            this.test2_spool_ll.TabIndex = 109;
            this.test2_spool_ll.Text = "";
            // 
            // test1_spool_ll
            // 
            this.test1_spool_ll.BackColor = System.Drawing.Color.White;
            this.test1_spool_ll.ForeColor = System.Drawing.Color.Black;
            this.test1_spool_ll.Location = new System.Drawing.Point(922, 350);
            this.test1_spool_ll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test1_spool_ll.Multiline = false;
            this.test1_spool_ll.Name = "test1_spool_ll";
            this.test1_spool_ll.Size = new System.Drawing.Size(66, 29);
            this.test1_spool_ll.TabIndex = 108;
            this.test1_spool_ll.Text = "";
            // 
            // test6_dira_result
            // 
            this.test6_dira_result.BackColor = System.Drawing.Color.White;
            this.test6_dira_result.ForeColor = System.Drawing.Color.Black;
            this.test6_dira_result.Location = new System.Drawing.Point(1210, 550);
            this.test6_dira_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test6_dira_result.Multiline = false;
            this.test6_dira_result.Name = "test6_dira_result";
            this.test6_dira_result.Size = new System.Drawing.Size(66, 29);
            this.test6_dira_result.TabIndex = 143;
            this.test6_dira_result.Text = "";
            // 
            // test5_dira_result
            // 
            this.test5_dira_result.BackColor = System.Drawing.Color.White;
            this.test5_dira_result.ForeColor = System.Drawing.Color.Black;
            this.test5_dira_result.Location = new System.Drawing.Point(1210, 510);
            this.test5_dira_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test5_dira_result.Multiline = false;
            this.test5_dira_result.Name = "test5_dira_result";
            this.test5_dira_result.Size = new System.Drawing.Size(66, 29);
            this.test5_dira_result.TabIndex = 142;
            this.test5_dira_result.Text = "";
            // 
            // test4_dira_result
            // 
            this.test4_dira_result.BackColor = System.Drawing.Color.White;
            this.test4_dira_result.ForeColor = System.Drawing.Color.Black;
            this.test4_dira_result.Location = new System.Drawing.Point(1210, 470);
            this.test4_dira_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test4_dira_result.Multiline = false;
            this.test4_dira_result.Name = "test4_dira_result";
            this.test4_dira_result.Size = new System.Drawing.Size(66, 29);
            this.test4_dira_result.TabIndex = 141;
            this.test4_dira_result.Text = "";
            // 
            // test3_dira_result
            // 
            this.test3_dira_result.BackColor = System.Drawing.Color.White;
            this.test3_dira_result.ForeColor = System.Drawing.Color.Black;
            this.test3_dira_result.Location = new System.Drawing.Point(1210, 430);
            this.test3_dira_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test3_dira_result.Multiline = false;
            this.test3_dira_result.Name = "test3_dira_result";
            this.test3_dira_result.Size = new System.Drawing.Size(66, 29);
            this.test3_dira_result.TabIndex = 140;
            this.test3_dira_result.Text = "";
            // 
            // test2_dira_result
            // 
            this.test2_dira_result.BackColor = System.Drawing.Color.White;
            this.test2_dira_result.ForeColor = System.Drawing.Color.Black;
            this.test2_dira_result.Location = new System.Drawing.Point(1210, 390);
            this.test2_dira_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test2_dira_result.Multiline = false;
            this.test2_dira_result.Name = "test2_dira_result";
            this.test2_dira_result.Size = new System.Drawing.Size(66, 29);
            this.test2_dira_result.TabIndex = 139;
            this.test2_dira_result.Text = "";
            // 
            // test1_dira_result
            // 
            this.test1_dira_result.BackColor = System.Drawing.Color.White;
            this.test1_dira_result.ForeColor = System.Drawing.Color.Black;
            this.test1_dira_result.Location = new System.Drawing.Point(1210, 350);
            this.test1_dira_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test1_dira_result.Multiline = false;
            this.test1_dira_result.Name = "test1_dira_result";
            this.test1_dira_result.Size = new System.Drawing.Size(66, 29);
            this.test1_dira_result.TabIndex = 138;
            this.test1_dira_result.Text = "";
            // 
            // test6_dira_ul
            // 
            this.test6_dira_ul.BackColor = System.Drawing.Color.White;
            this.test6_dira_ul.ForeColor = System.Drawing.Color.Black;
            this.test6_dira_ul.Location = new System.Drawing.Point(1280, 550);
            this.test6_dira_ul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test6_dira_ul.Multiline = false;
            this.test6_dira_ul.Name = "test6_dira_ul";
            this.test6_dira_ul.Size = new System.Drawing.Size(66, 29);
            this.test6_dira_ul.TabIndex = 137;
            this.test6_dira_ul.Text = "";
            // 
            // test5_dira_ul
            // 
            this.test5_dira_ul.BackColor = System.Drawing.Color.White;
            this.test5_dira_ul.ForeColor = System.Drawing.Color.Black;
            this.test5_dira_ul.Location = new System.Drawing.Point(1280, 510);
            this.test5_dira_ul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test5_dira_ul.Multiline = false;
            this.test5_dira_ul.Name = "test5_dira_ul";
            this.test5_dira_ul.Size = new System.Drawing.Size(66, 29);
            this.test5_dira_ul.TabIndex = 136;
            this.test5_dira_ul.Text = "";
            // 
            // test4_dira_ul
            // 
            this.test4_dira_ul.BackColor = System.Drawing.Color.White;
            this.test4_dira_ul.ForeColor = System.Drawing.Color.Black;
            this.test4_dira_ul.Location = new System.Drawing.Point(1280, 470);
            this.test4_dira_ul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test4_dira_ul.Multiline = false;
            this.test4_dira_ul.Name = "test4_dira_ul";
            this.test4_dira_ul.Size = new System.Drawing.Size(66, 29);
            this.test4_dira_ul.TabIndex = 135;
            this.test4_dira_ul.Text = "";
            // 
            // test3_dira_ul
            // 
            this.test3_dira_ul.BackColor = System.Drawing.Color.White;
            this.test3_dira_ul.ForeColor = System.Drawing.Color.Black;
            this.test3_dira_ul.Location = new System.Drawing.Point(1280, 430);
            this.test3_dira_ul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test3_dira_ul.Multiline = false;
            this.test3_dira_ul.Name = "test3_dira_ul";
            this.test3_dira_ul.Size = new System.Drawing.Size(66, 29);
            this.test3_dira_ul.TabIndex = 134;
            this.test3_dira_ul.Text = "";
            // 
            // test2_dira_ul
            // 
            this.test2_dira_ul.BackColor = System.Drawing.Color.White;
            this.test2_dira_ul.ForeColor = System.Drawing.Color.Black;
            this.test2_dira_ul.Location = new System.Drawing.Point(1280, 390);
            this.test2_dira_ul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test2_dira_ul.Multiline = false;
            this.test2_dira_ul.Name = "test2_dira_ul";
            this.test2_dira_ul.Size = new System.Drawing.Size(66, 29);
            this.test2_dira_ul.TabIndex = 133;
            this.test2_dira_ul.Text = "";
            // 
            // test1_dira_ul
            // 
            this.test1_dira_ul.BackColor = System.Drawing.Color.White;
            this.test1_dira_ul.ForeColor = System.Drawing.Color.Black;
            this.test1_dira_ul.Location = new System.Drawing.Point(1280, 350);
            this.test1_dira_ul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test1_dira_ul.Multiline = false;
            this.test1_dira_ul.Name = "test1_dira_ul";
            this.test1_dira_ul.Size = new System.Drawing.Size(66, 29);
            this.test1_dira_ul.TabIndex = 132;
            this.test1_dira_ul.Text = "";
            // 
            // test6_dira_ll
            // 
            this.test6_dira_ll.BackColor = System.Drawing.Color.White;
            this.test6_dira_ll.ForeColor = System.Drawing.Color.Black;
            this.test6_dira_ll.Location = new System.Drawing.Point(1142, 550);
            this.test6_dira_ll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test6_dira_ll.Multiline = false;
            this.test6_dira_ll.Name = "test6_dira_ll";
            this.test6_dira_ll.Size = new System.Drawing.Size(66, 29);
            this.test6_dira_ll.TabIndex = 131;
            this.test6_dira_ll.Text = "";
            // 
            // test5_dira_ll
            // 
            this.test5_dira_ll.BackColor = System.Drawing.Color.White;
            this.test5_dira_ll.ForeColor = System.Drawing.Color.Black;
            this.test5_dira_ll.Location = new System.Drawing.Point(1142, 510);
            this.test5_dira_ll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test5_dira_ll.Multiline = false;
            this.test5_dira_ll.Name = "test5_dira_ll";
            this.test5_dira_ll.Size = new System.Drawing.Size(66, 29);
            this.test5_dira_ll.TabIndex = 130;
            this.test5_dira_ll.Text = "";
            // 
            // test4_dira_ll
            // 
            this.test4_dira_ll.BackColor = System.Drawing.Color.White;
            this.test4_dira_ll.ForeColor = System.Drawing.Color.Black;
            this.test4_dira_ll.Location = new System.Drawing.Point(1142, 470);
            this.test4_dira_ll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test4_dira_ll.Multiline = false;
            this.test4_dira_ll.Name = "test4_dira_ll";
            this.test4_dira_ll.Size = new System.Drawing.Size(66, 29);
            this.test4_dira_ll.TabIndex = 129;
            this.test4_dira_ll.Text = "";
            // 
            // test3_dira_ll
            // 
            this.test3_dira_ll.BackColor = System.Drawing.Color.White;
            this.test3_dira_ll.ForeColor = System.Drawing.Color.Black;
            this.test3_dira_ll.Location = new System.Drawing.Point(1142, 430);
            this.test3_dira_ll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test3_dira_ll.Multiline = false;
            this.test3_dira_ll.Name = "test3_dira_ll";
            this.test3_dira_ll.Size = new System.Drawing.Size(66, 29);
            this.test3_dira_ll.TabIndex = 128;
            this.test3_dira_ll.Text = "";
            // 
            // test2_dira_ll
            // 
            this.test2_dira_ll.BackColor = System.Drawing.Color.White;
            this.test2_dira_ll.ForeColor = System.Drawing.Color.Black;
            this.test2_dira_ll.Location = new System.Drawing.Point(1142, 390);
            this.test2_dira_ll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test2_dira_ll.Multiline = false;
            this.test2_dira_ll.Name = "test2_dira_ll";
            this.test2_dira_ll.Size = new System.Drawing.Size(66, 29);
            this.test2_dira_ll.TabIndex = 127;
            this.test2_dira_ll.Text = "";
            // 
            // test1_dira_ll
            // 
            this.test1_dira_ll.BackColor = System.Drawing.Color.White;
            this.test1_dira_ll.ForeColor = System.Drawing.Color.Black;
            this.test1_dira_ll.Location = new System.Drawing.Point(1142, 350);
            this.test1_dira_ll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test1_dira_ll.Multiline = false;
            this.test1_dira_ll.Name = "test1_dira_ll";
            this.test1_dira_ll.Size = new System.Drawing.Size(66, 29);
            this.test1_dira_ll.TabIndex = 126;
            this.test1_dira_ll.Text = "";
            // 
            // test6_dirb_result
            // 
            this.test6_dirb_result.BackColor = System.Drawing.Color.White;
            this.test6_dirb_result.ForeColor = System.Drawing.Color.Black;
            this.test6_dirb_result.Location = new System.Drawing.Point(1442, 550);
            this.test6_dirb_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test6_dirb_result.Multiline = false;
            this.test6_dirb_result.Name = "test6_dirb_result";
            this.test6_dirb_result.Size = new System.Drawing.Size(66, 29);
            this.test6_dirb_result.TabIndex = 161;
            this.test6_dirb_result.Text = "";
            // 
            // test5_dirb_result
            // 
            this.test5_dirb_result.BackColor = System.Drawing.Color.White;
            this.test5_dirb_result.ForeColor = System.Drawing.Color.Black;
            this.test5_dirb_result.Location = new System.Drawing.Point(1442, 510);
            this.test5_dirb_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test5_dirb_result.Multiline = false;
            this.test5_dirb_result.Name = "test5_dirb_result";
            this.test5_dirb_result.Size = new System.Drawing.Size(66, 29);
            this.test5_dirb_result.TabIndex = 160;
            this.test5_dirb_result.Text = "";
            // 
            // test4_dirb_result
            // 
            this.test4_dirb_result.BackColor = System.Drawing.Color.White;
            this.test4_dirb_result.ForeColor = System.Drawing.Color.Black;
            this.test4_dirb_result.Location = new System.Drawing.Point(1442, 470);
            this.test4_dirb_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test4_dirb_result.Multiline = false;
            this.test4_dirb_result.Name = "test4_dirb_result";
            this.test4_dirb_result.Size = new System.Drawing.Size(66, 29);
            this.test4_dirb_result.TabIndex = 159;
            this.test4_dirb_result.Text = "";
            // 
            // test3_dirb_result
            // 
            this.test3_dirb_result.BackColor = System.Drawing.Color.White;
            this.test3_dirb_result.ForeColor = System.Drawing.Color.Black;
            this.test3_dirb_result.Location = new System.Drawing.Point(1442, 430);
            this.test3_dirb_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test3_dirb_result.Multiline = false;
            this.test3_dirb_result.Name = "test3_dirb_result";
            this.test3_dirb_result.Size = new System.Drawing.Size(66, 29);
            this.test3_dirb_result.TabIndex = 158;
            this.test3_dirb_result.Text = "";
            // 
            // test2_dirb_result
            // 
            this.test2_dirb_result.BackColor = System.Drawing.Color.White;
            this.test2_dirb_result.ForeColor = System.Drawing.Color.Black;
            this.test2_dirb_result.Location = new System.Drawing.Point(1442, 390);
            this.test2_dirb_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test2_dirb_result.Multiline = false;
            this.test2_dirb_result.Name = "test2_dirb_result";
            this.test2_dirb_result.Size = new System.Drawing.Size(66, 29);
            this.test2_dirb_result.TabIndex = 157;
            this.test2_dirb_result.Text = "";
            // 
            // test1_dirb_result
            // 
            this.test1_dirb_result.BackColor = System.Drawing.Color.White;
            this.test1_dirb_result.ForeColor = System.Drawing.Color.Black;
            this.test1_dirb_result.Location = new System.Drawing.Point(1442, 350);
            this.test1_dirb_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test1_dirb_result.Multiline = false;
            this.test1_dirb_result.Name = "test1_dirb_result";
            this.test1_dirb_result.Size = new System.Drawing.Size(66, 29);
            this.test1_dirb_result.TabIndex = 156;
            this.test1_dirb_result.Text = "";
            // 
            // test6_dirb_ul
            // 
            this.test6_dirb_ul.BackColor = System.Drawing.Color.White;
            this.test6_dirb_ul.ForeColor = System.Drawing.Color.Black;
            this.test6_dirb_ul.Location = new System.Drawing.Point(1510, 550);
            this.test6_dirb_ul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test6_dirb_ul.Multiline = false;
            this.test6_dirb_ul.Name = "test6_dirb_ul";
            this.test6_dirb_ul.Size = new System.Drawing.Size(66, 29);
            this.test6_dirb_ul.TabIndex = 155;
            this.test6_dirb_ul.Text = "";
            // 
            // test5_dirb_ul
            // 
            this.test5_dirb_ul.BackColor = System.Drawing.Color.White;
            this.test5_dirb_ul.ForeColor = System.Drawing.Color.Black;
            this.test5_dirb_ul.Location = new System.Drawing.Point(1510, 510);
            this.test5_dirb_ul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test5_dirb_ul.Multiline = false;
            this.test5_dirb_ul.Name = "test5_dirb_ul";
            this.test5_dirb_ul.Size = new System.Drawing.Size(66, 29);
            this.test5_dirb_ul.TabIndex = 154;
            this.test5_dirb_ul.Text = "";
            // 
            // test4_dirb_ul
            // 
            this.test4_dirb_ul.BackColor = System.Drawing.Color.White;
            this.test4_dirb_ul.ForeColor = System.Drawing.Color.Black;
            this.test4_dirb_ul.Location = new System.Drawing.Point(1510, 470);
            this.test4_dirb_ul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test4_dirb_ul.Multiline = false;
            this.test4_dirb_ul.Name = "test4_dirb_ul";
            this.test4_dirb_ul.Size = new System.Drawing.Size(66, 29);
            this.test4_dirb_ul.TabIndex = 153;
            this.test4_dirb_ul.Text = "";
            // 
            // test3_dirb_ul
            // 
            this.test3_dirb_ul.BackColor = System.Drawing.Color.White;
            this.test3_dirb_ul.ForeColor = System.Drawing.Color.Black;
            this.test3_dirb_ul.Location = new System.Drawing.Point(1510, 430);
            this.test3_dirb_ul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test3_dirb_ul.Multiline = false;
            this.test3_dirb_ul.Name = "test3_dirb_ul";
            this.test3_dirb_ul.Size = new System.Drawing.Size(66, 29);
            this.test3_dirb_ul.TabIndex = 152;
            this.test3_dirb_ul.Text = "";
            // 
            // test2_dirb_ul
            // 
            this.test2_dirb_ul.BackColor = System.Drawing.Color.White;
            this.test2_dirb_ul.ForeColor = System.Drawing.Color.Black;
            this.test2_dirb_ul.Location = new System.Drawing.Point(1510, 390);
            this.test2_dirb_ul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test2_dirb_ul.Multiline = false;
            this.test2_dirb_ul.Name = "test2_dirb_ul";
            this.test2_dirb_ul.Size = new System.Drawing.Size(66, 29);
            this.test2_dirb_ul.TabIndex = 151;
            this.test2_dirb_ul.Text = "";
            // 
            // test1_dirb_ul
            // 
            this.test1_dirb_ul.BackColor = System.Drawing.Color.White;
            this.test1_dirb_ul.ForeColor = System.Drawing.Color.Black;
            this.test1_dirb_ul.Location = new System.Drawing.Point(1510, 350);
            this.test1_dirb_ul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test1_dirb_ul.Multiline = false;
            this.test1_dirb_ul.Name = "test1_dirb_ul";
            this.test1_dirb_ul.Size = new System.Drawing.Size(66, 29);
            this.test1_dirb_ul.TabIndex = 150;
            this.test1_dirb_ul.Text = "";
            // 
            // test6_dirb_ll
            // 
            this.test6_dirb_ll.BackColor = System.Drawing.Color.White;
            this.test6_dirb_ll.ForeColor = System.Drawing.Color.Black;
            this.test6_dirb_ll.Location = new System.Drawing.Point(1372, 550);
            this.test6_dirb_ll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test6_dirb_ll.Multiline = false;
            this.test6_dirb_ll.Name = "test6_dirb_ll";
            this.test6_dirb_ll.Size = new System.Drawing.Size(66, 29);
            this.test6_dirb_ll.TabIndex = 149;
            this.test6_dirb_ll.Text = "";
            // 
            // test5_dirb_ll
            // 
            this.test5_dirb_ll.BackColor = System.Drawing.Color.White;
            this.test5_dirb_ll.ForeColor = System.Drawing.Color.Black;
            this.test5_dirb_ll.Location = new System.Drawing.Point(1372, 510);
            this.test5_dirb_ll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test5_dirb_ll.Multiline = false;
            this.test5_dirb_ll.Name = "test5_dirb_ll";
            this.test5_dirb_ll.Size = new System.Drawing.Size(66, 29);
            this.test5_dirb_ll.TabIndex = 148;
            this.test5_dirb_ll.Text = "";
            // 
            // test4_dirb_ll
            // 
            this.test4_dirb_ll.BackColor = System.Drawing.Color.White;
            this.test4_dirb_ll.ForeColor = System.Drawing.Color.Black;
            this.test4_dirb_ll.Location = new System.Drawing.Point(1372, 470);
            this.test4_dirb_ll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test4_dirb_ll.Multiline = false;
            this.test4_dirb_ll.Name = "test4_dirb_ll";
            this.test4_dirb_ll.Size = new System.Drawing.Size(66, 29);
            this.test4_dirb_ll.TabIndex = 147;
            this.test4_dirb_ll.Text = "";
            // 
            // test3_dirb_ll
            // 
            this.test3_dirb_ll.BackColor = System.Drawing.Color.White;
            this.test3_dirb_ll.ForeColor = System.Drawing.Color.Black;
            this.test3_dirb_ll.Location = new System.Drawing.Point(1372, 430);
            this.test3_dirb_ll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test3_dirb_ll.Multiline = false;
            this.test3_dirb_ll.Name = "test3_dirb_ll";
            this.test3_dirb_ll.Size = new System.Drawing.Size(66, 29);
            this.test3_dirb_ll.TabIndex = 146;
            this.test3_dirb_ll.Text = "";
            // 
            // test2_dirb_ll
            // 
            this.test2_dirb_ll.BackColor = System.Drawing.Color.White;
            this.test2_dirb_ll.ForeColor = System.Drawing.Color.Black;
            this.test2_dirb_ll.Location = new System.Drawing.Point(1372, 390);
            this.test2_dirb_ll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test2_dirb_ll.Multiline = false;
            this.test2_dirb_ll.Name = "test2_dirb_ll";
            this.test2_dirb_ll.Size = new System.Drawing.Size(66, 29);
            this.test2_dirb_ll.TabIndex = 145;
            this.test2_dirb_ll.Text = "";
            // 
            // test1_dirb_ll
            // 
            this.test1_dirb_ll.BackColor = System.Drawing.Color.White;
            this.test1_dirb_ll.ForeColor = System.Drawing.Color.Black;
            this.test1_dirb_ll.Location = new System.Drawing.Point(1372, 350);
            this.test1_dirb_ll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test1_dirb_ll.Multiline = false;
            this.test1_dirb_ll.Name = "test1_dirb_ll";
            this.test1_dirb_ll.Size = new System.Drawing.Size(66, 29);
            this.test1_dirb_ll.TabIndex = 144;
            this.test1_dirb_ll.Text = "";
            // 
            // test6_drven_result
            // 
            this.test6_drven_result.BackColor = System.Drawing.Color.White;
            this.test6_drven_result.ForeColor = System.Drawing.Color.Black;
            this.test6_drven_result.Location = new System.Drawing.Point(1665, 550);
            this.test6_drven_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test6_drven_result.Multiline = false;
            this.test6_drven_result.Name = "test6_drven_result";
            this.test6_drven_result.Size = new System.Drawing.Size(66, 29);
            this.test6_drven_result.TabIndex = 179;
            this.test6_drven_result.Text = "";
            // 
            // test5_drven_result
            // 
            this.test5_drven_result.BackColor = System.Drawing.Color.White;
            this.test5_drven_result.ForeColor = System.Drawing.Color.Black;
            this.test5_drven_result.Location = new System.Drawing.Point(1665, 510);
            this.test5_drven_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test5_drven_result.Multiline = false;
            this.test5_drven_result.Name = "test5_drven_result";
            this.test5_drven_result.Size = new System.Drawing.Size(66, 29);
            this.test5_drven_result.TabIndex = 178;
            this.test5_drven_result.Text = "";
            // 
            // test4_drven_result
            // 
            this.test4_drven_result.BackColor = System.Drawing.Color.White;
            this.test4_drven_result.ForeColor = System.Drawing.Color.Black;
            this.test4_drven_result.Location = new System.Drawing.Point(1665, 470);
            this.test4_drven_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test4_drven_result.Multiline = false;
            this.test4_drven_result.Name = "test4_drven_result";
            this.test4_drven_result.Size = new System.Drawing.Size(66, 29);
            this.test4_drven_result.TabIndex = 177;
            this.test4_drven_result.Text = "";
            // 
            // test3_drven_result
            // 
            this.test3_drven_result.BackColor = System.Drawing.Color.White;
            this.test3_drven_result.ForeColor = System.Drawing.Color.Black;
            this.test3_drven_result.Location = new System.Drawing.Point(1665, 430);
            this.test3_drven_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test3_drven_result.Multiline = false;
            this.test3_drven_result.Name = "test3_drven_result";
            this.test3_drven_result.Size = new System.Drawing.Size(66, 29);
            this.test3_drven_result.TabIndex = 176;
            this.test3_drven_result.Text = "";
            // 
            // test2_drven_result
            // 
            this.test2_drven_result.BackColor = System.Drawing.Color.White;
            this.test2_drven_result.ForeColor = System.Drawing.Color.Black;
            this.test2_drven_result.Location = new System.Drawing.Point(1665, 390);
            this.test2_drven_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test2_drven_result.Multiline = false;
            this.test2_drven_result.Name = "test2_drven_result";
            this.test2_drven_result.Size = new System.Drawing.Size(66, 29);
            this.test2_drven_result.TabIndex = 175;
            this.test2_drven_result.Text = "";
            // 
            // test1_drven_result
            // 
            this.test1_drven_result.BackColor = System.Drawing.Color.White;
            this.test1_drven_result.ForeColor = System.Drawing.Color.Black;
            this.test1_drven_result.Location = new System.Drawing.Point(1665, 350);
            this.test1_drven_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test1_drven_result.Multiline = false;
            this.test1_drven_result.Name = "test1_drven_result";
            this.test1_drven_result.Size = new System.Drawing.Size(66, 29);
            this.test1_drven_result.TabIndex = 174;
            this.test1_drven_result.Text = "";
            // 
            // test6_drven_ul
            // 
            this.test6_drven_ul.BackColor = System.Drawing.Color.White;
            this.test6_drven_ul.ForeColor = System.Drawing.Color.Black;
            this.test6_drven_ul.Location = new System.Drawing.Point(1734, 550);
            this.test6_drven_ul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test6_drven_ul.Multiline = false;
            this.test6_drven_ul.Name = "test6_drven_ul";
            this.test6_drven_ul.Size = new System.Drawing.Size(66, 29);
            this.test6_drven_ul.TabIndex = 173;
            this.test6_drven_ul.Text = "";
            // 
            // test5_drven_ul
            // 
            this.test5_drven_ul.BackColor = System.Drawing.Color.White;
            this.test5_drven_ul.ForeColor = System.Drawing.Color.Black;
            this.test5_drven_ul.Location = new System.Drawing.Point(1734, 510);
            this.test5_drven_ul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test5_drven_ul.Multiline = false;
            this.test5_drven_ul.Name = "test5_drven_ul";
            this.test5_drven_ul.Size = new System.Drawing.Size(66, 29);
            this.test5_drven_ul.TabIndex = 172;
            this.test5_drven_ul.Text = "";
            // 
            // test4_drven_ul
            // 
            this.test4_drven_ul.BackColor = System.Drawing.Color.White;
            this.test4_drven_ul.ForeColor = System.Drawing.Color.Black;
            this.test4_drven_ul.Location = new System.Drawing.Point(1734, 470);
            this.test4_drven_ul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test4_drven_ul.Multiline = false;
            this.test4_drven_ul.Name = "test4_drven_ul";
            this.test4_drven_ul.Size = new System.Drawing.Size(66, 29);
            this.test4_drven_ul.TabIndex = 171;
            this.test4_drven_ul.Text = "";
            // 
            // test3_drven_ul
            // 
            this.test3_drven_ul.BackColor = System.Drawing.Color.White;
            this.test3_drven_ul.ForeColor = System.Drawing.Color.Black;
            this.test3_drven_ul.Location = new System.Drawing.Point(1734, 430);
            this.test3_drven_ul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test3_drven_ul.Multiline = false;
            this.test3_drven_ul.Name = "test3_drven_ul";
            this.test3_drven_ul.Size = new System.Drawing.Size(66, 29);
            this.test3_drven_ul.TabIndex = 170;
            this.test3_drven_ul.Text = "";
            // 
            // test2_drven_ul
            // 
            this.test2_drven_ul.BackColor = System.Drawing.Color.White;
            this.test2_drven_ul.ForeColor = System.Drawing.Color.Black;
            this.test2_drven_ul.Location = new System.Drawing.Point(1734, 390);
            this.test2_drven_ul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test2_drven_ul.Multiline = false;
            this.test2_drven_ul.Name = "test2_drven_ul";
            this.test2_drven_ul.Size = new System.Drawing.Size(66, 29);
            this.test2_drven_ul.TabIndex = 169;
            this.test2_drven_ul.Text = "";
            // 
            // test1_drven_ul
            // 
            this.test1_drven_ul.BackColor = System.Drawing.Color.White;
            this.test1_drven_ul.ForeColor = System.Drawing.Color.Black;
            this.test1_drven_ul.Location = new System.Drawing.Point(1734, 350);
            this.test1_drven_ul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test1_drven_ul.Multiline = false;
            this.test1_drven_ul.Name = "test1_drven_ul";
            this.test1_drven_ul.Size = new System.Drawing.Size(66, 29);
            this.test1_drven_ul.TabIndex = 168;
            this.test1_drven_ul.Text = "";
            // 
            // test6_drven_ll
            // 
            this.test6_drven_ll.BackColor = System.Drawing.Color.White;
            this.test6_drven_ll.ForeColor = System.Drawing.Color.Black;
            this.test6_drven_ll.Location = new System.Drawing.Point(1596, 550);
            this.test6_drven_ll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test6_drven_ll.Multiline = false;
            this.test6_drven_ll.Name = "test6_drven_ll";
            this.test6_drven_ll.Size = new System.Drawing.Size(66, 29);
            this.test6_drven_ll.TabIndex = 167;
            this.test6_drven_ll.Text = "";
            // 
            // test5_drven_ll
            // 
            this.test5_drven_ll.BackColor = System.Drawing.Color.White;
            this.test5_drven_ll.ForeColor = System.Drawing.Color.Black;
            this.test5_drven_ll.Location = new System.Drawing.Point(1596, 510);
            this.test5_drven_ll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test5_drven_ll.Multiline = false;
            this.test5_drven_ll.Name = "test5_drven_ll";
            this.test5_drven_ll.Size = new System.Drawing.Size(66, 29);
            this.test5_drven_ll.TabIndex = 166;
            this.test5_drven_ll.Text = "";
            // 
            // test4_drven_ll
            // 
            this.test4_drven_ll.BackColor = System.Drawing.Color.White;
            this.test4_drven_ll.ForeColor = System.Drawing.Color.Black;
            this.test4_drven_ll.Location = new System.Drawing.Point(1596, 470);
            this.test4_drven_ll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test4_drven_ll.Multiline = false;
            this.test4_drven_ll.Name = "test4_drven_ll";
            this.test4_drven_ll.Size = new System.Drawing.Size(66, 29);
            this.test4_drven_ll.TabIndex = 165;
            this.test4_drven_ll.Text = "";
            // 
            // test3_drven_ll
            // 
            this.test3_drven_ll.BackColor = System.Drawing.Color.White;
            this.test3_drven_ll.ForeColor = System.Drawing.Color.Black;
            this.test3_drven_ll.Location = new System.Drawing.Point(1596, 430);
            this.test3_drven_ll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test3_drven_ll.Multiline = false;
            this.test3_drven_ll.Name = "test3_drven_ll";
            this.test3_drven_ll.Size = new System.Drawing.Size(66, 29);
            this.test3_drven_ll.TabIndex = 164;
            this.test3_drven_ll.Text = "";
            // 
            // test2_drven_ll
            // 
            this.test2_drven_ll.BackColor = System.Drawing.Color.White;
            this.test2_drven_ll.ForeColor = System.Drawing.Color.Black;
            this.test2_drven_ll.Location = new System.Drawing.Point(1596, 390);
            this.test2_drven_ll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test2_drven_ll.Multiline = false;
            this.test2_drven_ll.Name = "test2_drven_ll";
            this.test2_drven_ll.Size = new System.Drawing.Size(66, 29);
            this.test2_drven_ll.TabIndex = 163;
            this.test2_drven_ll.Text = "";
            // 
            // test1_drven_ll
            // 
            this.test1_drven_ll.BackColor = System.Drawing.Color.White;
            this.test1_drven_ll.ForeColor = System.Drawing.Color.Black;
            this.test1_drven_ll.Location = new System.Drawing.Point(1596, 350);
            this.test1_drven_ll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test1_drven_ll.Multiline = false;
            this.test1_drven_ll.Name = "test1_drven_ll";
            this.test1_drven_ll.Size = new System.Drawing.Size(66, 29);
            this.test1_drven_ll.TabIndex = 162;
            this.test1_drven_ll.Text = "";
            // 
            // test1_led_target
            // 
            this.test1_led_target.BackColor = System.Drawing.Color.White;
            this.test1_led_target.ForeColor = System.Drawing.Color.Black;
            this.test1_led_target.Location = new System.Drawing.Point(816, 350);
            this.test1_led_target.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test1_led_target.Multiline = false;
            this.test1_led_target.Name = "test1_led_target";
            this.test1_led_target.Size = new System.Drawing.Size(80, 29);
            this.test1_led_target.TabIndex = 180;
            this.test1_led_target.Text = "";
            // 
            // test2_led_target
            // 
            this.test2_led_target.BackColor = System.Drawing.Color.White;
            this.test2_led_target.ForeColor = System.Drawing.Color.Black;
            this.test2_led_target.Location = new System.Drawing.Point(816, 390);
            this.test2_led_target.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test2_led_target.Multiline = false;
            this.test2_led_target.Name = "test2_led_target";
            this.test2_led_target.Size = new System.Drawing.Size(80, 29);
            this.test2_led_target.TabIndex = 182;
            this.test2_led_target.Text = "";
            // 
            // test2_led_result
            // 
            this.test2_led_result.BackColor = System.Drawing.Color.White;
            this.test2_led_result.ForeColor = System.Drawing.Color.Black;
            this.test2_led_result.Location = new System.Drawing.Point(732, 390);
            this.test2_led_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test2_led_result.Multiline = false;
            this.test2_led_result.Name = "test2_led_result";
            this.test2_led_result.Size = new System.Drawing.Size(80, 29);
            this.test2_led_result.TabIndex = 181;
            this.test2_led_result.Text = "";
            // 
            // test3_led_target
            // 
            this.test3_led_target.BackColor = System.Drawing.Color.White;
            this.test3_led_target.ForeColor = System.Drawing.Color.Black;
            this.test3_led_target.Location = new System.Drawing.Point(816, 430);
            this.test3_led_target.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test3_led_target.Multiline = false;
            this.test3_led_target.Name = "test3_led_target";
            this.test3_led_target.Size = new System.Drawing.Size(80, 29);
            this.test3_led_target.TabIndex = 184;
            this.test3_led_target.Text = "";
            // 
            // test3_led_result
            // 
            this.test3_led_result.BackColor = System.Drawing.Color.White;
            this.test3_led_result.ForeColor = System.Drawing.Color.Black;
            this.test3_led_result.Location = new System.Drawing.Point(732, 430);
            this.test3_led_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test3_led_result.Multiline = false;
            this.test3_led_result.Name = "test3_led_result";
            this.test3_led_result.Size = new System.Drawing.Size(80, 29);
            this.test3_led_result.TabIndex = 183;
            this.test3_led_result.Text = "";
            // 
            // test4_led_target
            // 
            this.test4_led_target.BackColor = System.Drawing.Color.White;
            this.test4_led_target.ForeColor = System.Drawing.Color.Black;
            this.test4_led_target.Location = new System.Drawing.Point(816, 470);
            this.test4_led_target.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test4_led_target.Multiline = false;
            this.test4_led_target.Name = "test4_led_target";
            this.test4_led_target.Size = new System.Drawing.Size(80, 29);
            this.test4_led_target.TabIndex = 186;
            this.test4_led_target.Text = "";
            // 
            // test4_led_result
            // 
            this.test4_led_result.BackColor = System.Drawing.Color.White;
            this.test4_led_result.ForeColor = System.Drawing.Color.Black;
            this.test4_led_result.Location = new System.Drawing.Point(732, 470);
            this.test4_led_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test4_led_result.Multiline = false;
            this.test4_led_result.Name = "test4_led_result";
            this.test4_led_result.Size = new System.Drawing.Size(80, 29);
            this.test4_led_result.TabIndex = 185;
            this.test4_led_result.Text = "";
            // 
            // test5_led_target
            // 
            this.test5_led_target.BackColor = System.Drawing.Color.White;
            this.test5_led_target.ForeColor = System.Drawing.Color.Black;
            this.test5_led_target.Location = new System.Drawing.Point(816, 510);
            this.test5_led_target.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test5_led_target.Multiline = false;
            this.test5_led_target.Name = "test5_led_target";
            this.test5_led_target.Size = new System.Drawing.Size(80, 29);
            this.test5_led_target.TabIndex = 188;
            this.test5_led_target.Text = "";
            // 
            // test5_led_result
            // 
            this.test5_led_result.BackColor = System.Drawing.Color.White;
            this.test5_led_result.ForeColor = System.Drawing.Color.Black;
            this.test5_led_result.Location = new System.Drawing.Point(732, 510);
            this.test5_led_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test5_led_result.Multiline = false;
            this.test5_led_result.Name = "test5_led_result";
            this.test5_led_result.Size = new System.Drawing.Size(80, 29);
            this.test5_led_result.TabIndex = 187;
            this.test5_led_result.Text = "";
            // 
            // test6_led_target
            // 
            this.test6_led_target.BackColor = System.Drawing.Color.White;
            this.test6_led_target.ForeColor = System.Drawing.Color.Black;
            this.test6_led_target.Location = new System.Drawing.Point(816, 550);
            this.test6_led_target.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test6_led_target.Multiline = false;
            this.test6_led_target.Name = "test6_led_target";
            this.test6_led_target.Size = new System.Drawing.Size(80, 29);
            this.test6_led_target.TabIndex = 190;
            this.test6_led_target.Text = "";
            // 
            // test6_led_result
            // 
            this.test6_led_result.BackColor = System.Drawing.Color.White;
            this.test6_led_result.ForeColor = System.Drawing.Color.Black;
            this.test6_led_result.Location = new System.Drawing.Point(732, 550);
            this.test6_led_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test6_led_result.Multiline = false;
            this.test6_led_result.Name = "test6_led_result";
            this.test6_led_result.Size = new System.Drawing.Size(80, 29);
            this.test6_led_result.TabIndex = 189;
            this.test6_led_result.Text = "";
            // 
            // test1_result
            // 
            this.test1_result.BackColor = System.Drawing.Color.White;
            this.test1_result.ForeColor = System.Drawing.Color.Black;
            this.test1_result.Location = new System.Drawing.Point(1818, 350);
            this.test1_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test1_result.Multiline = false;
            this.test1_result.Name = "test1_result";
            this.test1_result.Size = new System.Drawing.Size(28, 29);
            this.test1_result.TabIndex = 191;
            this.test1_result.Text = "";
            // 
            // test2_result
            // 
            this.test2_result.BackColor = System.Drawing.Color.White;
            this.test2_result.ForeColor = System.Drawing.Color.Black;
            this.test2_result.Location = new System.Drawing.Point(1818, 390);
            this.test2_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test2_result.Multiline = false;
            this.test2_result.Name = "test2_result";
            this.test2_result.Size = new System.Drawing.Size(28, 29);
            this.test2_result.TabIndex = 192;
            this.test2_result.Text = "";
            // 
            // test3_result
            // 
            this.test3_result.BackColor = System.Drawing.Color.White;
            this.test3_result.ForeColor = System.Drawing.Color.Black;
            this.test3_result.Location = new System.Drawing.Point(1818, 430);
            this.test3_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test3_result.Multiline = false;
            this.test3_result.Name = "test3_result";
            this.test3_result.Size = new System.Drawing.Size(28, 29);
            this.test3_result.TabIndex = 193;
            this.test3_result.Text = "";
            // 
            // test4_result
            // 
            this.test4_result.BackColor = System.Drawing.Color.White;
            this.test4_result.ForeColor = System.Drawing.Color.Black;
            this.test4_result.Location = new System.Drawing.Point(1818, 470);
            this.test4_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test4_result.Multiline = false;
            this.test4_result.Name = "test4_result";
            this.test4_result.Size = new System.Drawing.Size(28, 29);
            this.test4_result.TabIndex = 194;
            this.test4_result.Text = "";
            // 
            // test5_result
            // 
            this.test5_result.BackColor = System.Drawing.Color.White;
            this.test5_result.ForeColor = System.Drawing.Color.Black;
            this.test5_result.Location = new System.Drawing.Point(1818, 510);
            this.test5_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test5_result.Multiline = false;
            this.test5_result.Name = "test5_result";
            this.test5_result.Size = new System.Drawing.Size(28, 29);
            this.test5_result.TabIndex = 195;
            this.test5_result.Text = "";
            // 
            // test6_result
            // 
            this.test6_result.BackColor = System.Drawing.Color.White;
            this.test6_result.ForeColor = System.Drawing.Color.Black;
            this.test6_result.Location = new System.Drawing.Point(1818, 550);
            this.test6_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test6_result.Multiline = false;
            this.test6_result.Name = "test6_result";
            this.test6_result.Size = new System.Drawing.Size(28, 29);
            this.test6_result.TabIndex = 196;
            this.test6_result.Text = "";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(32, 640);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(861, 30);
            this.label3.TabIndex = 197;
            this.label3.Text = "Test Nr.           Resistance SV1                 Resistance SV3                 " +
    "Result\r\n";
            // 
            // test7_sv3_result
            // 
            this.test7_sv3_result.BackColor = System.Drawing.Color.White;
            this.test7_sv3_result.ForeColor = System.Drawing.Color.Black;
            this.test7_sv3_result.Location = new System.Drawing.Point(454, 708);
            this.test7_sv3_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test7_sv3_result.Multiline = false;
            this.test7_sv3_result.Name = "test7_sv3_result";
            this.test7_sv3_result.Size = new System.Drawing.Size(66, 29);
            this.test7_sv3_result.TabIndex = 205;
            this.test7_sv3_result.Text = "";
            // 
            // test7_sv3_ul
            // 
            this.test7_sv3_ul.BackColor = System.Drawing.Color.White;
            this.test7_sv3_ul.ForeColor = System.Drawing.Color.Black;
            this.test7_sv3_ul.Location = new System.Drawing.Point(531, 708);
            this.test7_sv3_ul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test7_sv3_ul.Multiline = false;
            this.test7_sv3_ul.Name = "test7_sv3_ul";
            this.test7_sv3_ul.Size = new System.Drawing.Size(66, 29);
            this.test7_sv3_ul.TabIndex = 204;
            this.test7_sv3_ul.Text = "";
            // 
            // test7_sv3_ll
            // 
            this.test7_sv3_ll.BackColor = System.Drawing.Color.White;
            this.test7_sv3_ll.ForeColor = System.Drawing.Color.Black;
            this.test7_sv3_ll.Location = new System.Drawing.Point(378, 708);
            this.test7_sv3_ll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test7_sv3_ll.Multiline = false;
            this.test7_sv3_ll.Name = "test7_sv3_ll";
            this.test7_sv3_ll.Size = new System.Drawing.Size(66, 29);
            this.test7_sv3_ll.TabIndex = 203;
            this.test7_sv3_ll.Text = "";
            // 
            // test7_sv1_result
            // 
            this.test7_sv1_result.BackColor = System.Drawing.Color.White;
            this.test7_sv1_result.ForeColor = System.Drawing.Color.Black;
            this.test7_sv1_result.Location = new System.Drawing.Point(207, 708);
            this.test7_sv1_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test7_sv1_result.Multiline = false;
            this.test7_sv1_result.Name = "test7_sv1_result";
            this.test7_sv1_result.Size = new System.Drawing.Size(66, 29);
            this.test7_sv1_result.TabIndex = 202;
            this.test7_sv1_result.Text = "";
            // 
            // test7_sv1_ul
            // 
            this.test7_sv1_ul.BackColor = System.Drawing.Color.White;
            this.test7_sv1_ul.ForeColor = System.Drawing.Color.Black;
            this.test7_sv1_ul.Location = new System.Drawing.Point(284, 708);
            this.test7_sv1_ul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test7_sv1_ul.Multiline = false;
            this.test7_sv1_ul.Name = "test7_sv1_ul";
            this.test7_sv1_ul.Size = new System.Drawing.Size(66, 29);
            this.test7_sv1_ul.TabIndex = 201;
            this.test7_sv1_ul.Text = "";
            // 
            // test7_sv1_ll
            // 
            this.test7_sv1_ll.BackColor = System.Drawing.Color.White;
            this.test7_sv1_ll.ForeColor = System.Drawing.Color.Black;
            this.test7_sv1_ll.Location = new System.Drawing.Point(130, 708);
            this.test7_sv1_ll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test7_sv1_ll.Multiline = false;
            this.test7_sv1_ll.Name = "test7_sv1_ll";
            this.test7_sv1_ll.Size = new System.Drawing.Size(66, 29);
            this.test7_sv1_ll.TabIndex = 200;
            this.test7_sv1_ll.Text = "";
            // 
            // richTextBox143
            // 
            this.richTextBox143.BackColor = System.Drawing.Color.White;
            this.richTextBox143.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox143.ForeColor = System.Drawing.Color.Black;
            this.richTextBox143.Location = new System.Drawing.Point(38, 708);
            this.richTextBox143.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox143.Multiline = false;
            this.richTextBox143.Name = "richTextBox143";
            this.richTextBox143.Size = new System.Drawing.Size(66, 29);
            this.richTextBox143.TabIndex = 198;
            this.richTextBox143.Text = "R test";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(32, 672);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(753, 30);
            this.label4.TabIndex = 207;
            this.label4.Text = "                 l-limit     result     h-limit       l-limit     result     h-li" +
    "mit ";
            // 
            // test7_result
            // 
            this.test7_result.BackColor = System.Drawing.Color.White;
            this.test7_result.ForeColor = System.Drawing.Color.Black;
            this.test7_result.Location = new System.Drawing.Point(674, 708);
            this.test7_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test7_result.Multiline = false;
            this.test7_result.Name = "test7_result";
            this.test7_result.Size = new System.Drawing.Size(28, 29);
            this.test7_result.TabIndex = 208;
            this.test7_result.Text = "";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(27, 843);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1778, 30);
            this.label5.TabIndex = 209;
            this.label5.Text = "LVDT-Feedback linearity check                                                   R" +
    "esult                              Overall test result                         S" +
    "ystem messages  ";
            // 
            // lvdt_result
            // 
            this.lvdt_result.BackColor = System.Drawing.Color.White;
            this.lvdt_result.ForeColor = System.Drawing.Color.Black;
            this.lvdt_result.Location = new System.Drawing.Point(718, 842);
            this.lvdt_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvdt_result.Multiline = false;
            this.lvdt_result.Name = "lvdt_result";
            this.lvdt_result.Size = new System.Drawing.Size(28, 29);
            this.lvdt_result.TabIndex = 210;
            this.lvdt_result.Text = "";
            // 
            // serialPortMilliohmmeter
            // 
            this.serialPortMilliohmmeter.ReadTimeout = 2000;
            // 
            // sys_ready
            // 
            this.sys_ready.BackColor = System.Drawing.Color.White;
            this.sys_ready.ForeColor = System.Drawing.Color.Black;
            this.sys_ready.Location = new System.Drawing.Point(1818, 1353);
            this.sys_ready.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sys_ready.Multiline = false;
            this.sys_ready.Name = "sys_ready";
            this.sys_ready.Size = new System.Drawing.Size(28, 29);
            this.sys_ready.TabIndex = 211;
            this.sys_ready.Text = "";
            // 
            // meastime
            // 
            this.meastime.BackColor = System.Drawing.Color.White;
            this.meastime.ForeColor = System.Drawing.Color.Black;
            this.meastime.Location = new System.Drawing.Point(1494, 1352);
            this.meastime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.meastime.Multiline = false;
            this.meastime.Name = "meastime";
            this.meastime.Size = new System.Drawing.Size(67, 29);
            this.meastime.TabIndex = 212;
            this.meastime.Text = "";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(1170, 1353);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1778, 30);
            this.label6.TabIndex = 213;
            this.label6.Text = "Measurement Time  in seconds                                   System O.K.       " +
    "    ";
            // 
            // debugit
            // 
            this.debugit.AutoSize = true;
            this.debugit.BackColor = System.Drawing.Color.Transparent;
            this.debugit.Location = new System.Drawing.Point(1718, 1418);
            this.debugit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.debugit.Name = "debugit";
            this.debugit.Size = new System.Drawing.Size(127, 24);
            this.debugit.TabIndex = 216;
            this.debugit.Text = "Debug mode";
            this.debugit.UseVisualStyleBackColor = false;
            this.debugit.CheckedChanged += new System.EventHandler(this.debugit_CheckedChanged);
            // 
            // LedVideo
            // 
            this.LedVideo.Location = new System.Drawing.Point(1176, 662);
            this.LedVideo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LedVideo.Name = "LedVideo";
            this.LedVideo.Size = new System.Drawing.Size(297, 182);
            this.LedVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LedVideo.TabIndex = 217;
            this.LedVideo.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1516, 672);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 218;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Start_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1638, 672);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 35);
            this.button3.TabIndex = 220;
            this.button3.Text = "Capture";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Capture_Click);
            // 
            // LedPicture
            // 
            this.LedPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LedPicture.Location = new System.Drawing.Point(1780, 665);
            this.LedPicture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LedPicture.Name = "LedPicture";
            this.LedPicture.Size = new System.Drawing.Size(66, 54);
            this.LedPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LedPicture.TabIndex = 221;
            this.LedPicture.TabStop = false;
            // 
            // Up
            // 
            this.Up.Location = new System.Drawing.Point(1545, 735);
            this.Up.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(34, 35);
            this.Up.TabIndex = 222;
            this.Up.Text = "^";
            this.Up.UseVisualStyleBackColor = true;
            this.Up.Click += new System.EventHandler(this.Up_Click);
            // 
            // Down
            // 
            this.Down.Location = new System.Drawing.Point(1545, 800);
            this.Down.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(34, 35);
            this.Down.TabIndex = 223;
            this.Down.Text = "v";
            this.Down.UseVisualStyleBackColor = true;
            this.Down.Click += new System.EventHandler(this.Down_Click);
            // 
            // Right
            // 
            this.Right.Location = new System.Drawing.Point(1578, 767);
            this.Right.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(34, 35);
            this.Right.TabIndex = 225;
            this.Right.Text = ">";
            this.Right.UseVisualStyleBackColor = true;
            this.Right.Click += new System.EventHandler(this.Right_Click);
            // 
            // Left
            // 
            this.Left.Location = new System.Drawing.Point(1512, 767);
            this.Left.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(34, 35);
            this.Left.TabIndex = 224;
            this.Left.Text = "<";
            this.Left.UseVisualStyleBackColor = true;
            this.Left.Click += new System.EventHandler(this.Left_Click);
            // 
            // Saturation
            // 
            this.Saturation.BackColor = System.Drawing.Color.White;
            this.Saturation.ForeColor = System.Drawing.Color.Black;
            this.Saturation.Location = new System.Drawing.Point(1780, 810);
            this.Saturation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Saturation.Multiline = false;
            this.Saturation.Name = "Saturation";
            this.Saturation.Size = new System.Drawing.Size(66, 29);
            this.Saturation.TabIndex = 228;
            this.Saturation.Text = "";
            // 
            // Brightness
            // 
            this.Brightness.BackColor = System.Drawing.Color.White;
            this.Brightness.ForeColor = System.Drawing.Color.Black;
            this.Brightness.Location = new System.Drawing.Point(1780, 770);
            this.Brightness.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Brightness.Multiline = false;
            this.Brightness.Name = "Brightness";
            this.Brightness.Size = new System.Drawing.Size(66, 29);
            this.Brightness.TabIndex = 227;
            this.Brightness.Text = "";
            // 
            // Hue
            // 
            this.Hue.BackColor = System.Drawing.Color.White;
            this.Hue.ForeColor = System.Drawing.Color.Black;
            this.Hue.Location = new System.Drawing.Point(1780, 730);
            this.Hue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Hue.Multiline = false;
            this.Hue.Name = "Hue";
            this.Hue.Size = new System.Drawing.Size(66, 29);
            this.Hue.TabIndex = 226;
            this.Hue.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(1666, 735);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 229;
            this.label7.Text = "Hue";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(1666, 775);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 20);
            this.label8.TabIndex = 230;
            this.label8.Text = "Brightness";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(1666, 815);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 20);
            this.label9.TabIndex = 231;
            this.label9.Text = "Saturation";
            // 
            // Minus
            // 
            this.Minus.Location = new System.Drawing.Point(1624, 785);
            this.Minus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(34, 35);
            this.Minus.TabIndex = 233;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // Plus
            // 
            this.Plus.Location = new System.Drawing.Point(1624, 745);
            this.Plus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(34, 35);
            this.Plus.TabIndex = 232;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // test6_sv2_result
            // 
            this.test6_sv2_result.BackColor = System.Drawing.Color.White;
            this.test6_sv2_result.ForeColor = System.Drawing.Color.Black;
            this.test6_sv2_result.Location = new System.Drawing.Point(182, 550);
            this.test6_sv2_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test6_sv2_result.Multiline = false;
            this.test6_sv2_result.Name = "test6_sv2_result";
            this.test6_sv2_result.Size = new System.Drawing.Size(66, 29);
            this.test6_sv2_result.TabIndex = 239;
            this.test6_sv2_result.Text = "";
            // 
            // test5_sv2_result
            // 
            this.test5_sv2_result.BackColor = System.Drawing.Color.White;
            this.test5_sv2_result.ForeColor = System.Drawing.Color.Black;
            this.test5_sv2_result.Location = new System.Drawing.Point(182, 510);
            this.test5_sv2_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test5_sv2_result.Multiline = false;
            this.test5_sv2_result.Name = "test5_sv2_result";
            this.test5_sv2_result.Size = new System.Drawing.Size(66, 29);
            this.test5_sv2_result.TabIndex = 238;
            this.test5_sv2_result.Text = "";
            // 
            // test4_sv2_result
            // 
            this.test4_sv2_result.BackColor = System.Drawing.Color.White;
            this.test4_sv2_result.ForeColor = System.Drawing.Color.Black;
            this.test4_sv2_result.Location = new System.Drawing.Point(182, 470);
            this.test4_sv2_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test4_sv2_result.Multiline = false;
            this.test4_sv2_result.Name = "test4_sv2_result";
            this.test4_sv2_result.Size = new System.Drawing.Size(66, 29);
            this.test4_sv2_result.TabIndex = 237;
            this.test4_sv2_result.Text = "";
            // 
            // test3_sv2_result
            // 
            this.test3_sv2_result.BackColor = System.Drawing.Color.White;
            this.test3_sv2_result.ForeColor = System.Drawing.Color.Black;
            this.test3_sv2_result.Location = new System.Drawing.Point(182, 430);
            this.test3_sv2_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test3_sv2_result.Multiline = false;
            this.test3_sv2_result.Name = "test3_sv2_result";
            this.test3_sv2_result.Size = new System.Drawing.Size(66, 29);
            this.test3_sv2_result.TabIndex = 236;
            this.test3_sv2_result.Text = "";
            // 
            // test2_sv2_result
            // 
            this.test2_sv2_result.BackColor = System.Drawing.Color.White;
            this.test2_sv2_result.ForeColor = System.Drawing.Color.Black;
            this.test2_sv2_result.Location = new System.Drawing.Point(182, 390);
            this.test2_sv2_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test2_sv2_result.Multiline = false;
            this.test2_sv2_result.Name = "test2_sv2_result";
            this.test2_sv2_result.Size = new System.Drawing.Size(66, 29);
            this.test2_sv2_result.TabIndex = 235;
            this.test2_sv2_result.Text = "";
            // 
            // test1_sv2_result
            // 
            this.test1_sv2_result.BackColor = System.Drawing.Color.White;
            this.test1_sv2_result.ForeColor = System.Drawing.Color.Black;
            this.test1_sv2_result.Location = new System.Drawing.Point(182, 350);
            this.test1_sv2_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test1_sv2_result.Multiline = false;
            this.test1_sv2_result.Name = "test1_sv2_result";
            this.test1_sv2_result.Size = new System.Drawing.Size(66, 29);
            this.test1_sv2_result.TabIndex = 234;
            this.test1_sv2_result.Text = "";
            // 
            // test6_sv4_result
            // 
            this.test6_sv4_result.BackColor = System.Drawing.Color.White;
            this.test6_sv4_result.ForeColor = System.Drawing.Color.Black;
            this.test6_sv4_result.Location = new System.Drawing.Point(558, 550);
            this.test6_sv4_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test6_sv4_result.Multiline = false;
            this.test6_sv4_result.Name = "test6_sv4_result";
            this.test6_sv4_result.Size = new System.Drawing.Size(66, 29);
            this.test6_sv4_result.TabIndex = 245;
            this.test6_sv4_result.Text = "";
            // 
            // test5_sv4_result
            // 
            this.test5_sv4_result.BackColor = System.Drawing.Color.White;
            this.test5_sv4_result.ForeColor = System.Drawing.Color.Black;
            this.test5_sv4_result.Location = new System.Drawing.Point(558, 510);
            this.test5_sv4_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test5_sv4_result.Multiline = false;
            this.test5_sv4_result.Name = "test5_sv4_result";
            this.test5_sv4_result.Size = new System.Drawing.Size(66, 29);
            this.test5_sv4_result.TabIndex = 244;
            this.test5_sv4_result.Text = "";
            // 
            // test4_sv4_result
            // 
            this.test4_sv4_result.BackColor = System.Drawing.Color.White;
            this.test4_sv4_result.ForeColor = System.Drawing.Color.Black;
            this.test4_sv4_result.Location = new System.Drawing.Point(558, 470);
            this.test4_sv4_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test4_sv4_result.Multiline = false;
            this.test4_sv4_result.Name = "test4_sv4_result";
            this.test4_sv4_result.Size = new System.Drawing.Size(66, 29);
            this.test4_sv4_result.TabIndex = 243;
            this.test4_sv4_result.Text = "";
            // 
            // test3_sv4_result
            // 
            this.test3_sv4_result.BackColor = System.Drawing.Color.White;
            this.test3_sv4_result.ForeColor = System.Drawing.Color.Black;
            this.test3_sv4_result.Location = new System.Drawing.Point(558, 430);
            this.test3_sv4_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test3_sv4_result.Multiline = false;
            this.test3_sv4_result.Name = "test3_sv4_result";
            this.test3_sv4_result.Size = new System.Drawing.Size(66, 29);
            this.test3_sv4_result.TabIndex = 242;
            this.test3_sv4_result.Text = "";
            // 
            // test2_sv4_result
            // 
            this.test2_sv4_result.BackColor = System.Drawing.Color.White;
            this.test2_sv4_result.ForeColor = System.Drawing.Color.Black;
            this.test2_sv4_result.Location = new System.Drawing.Point(558, 390);
            this.test2_sv4_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test2_sv4_result.Multiline = false;
            this.test2_sv4_result.Name = "test2_sv4_result";
            this.test2_sv4_result.Size = new System.Drawing.Size(66, 29);
            this.test2_sv4_result.TabIndex = 241;
            this.test2_sv4_result.Text = "";
            // 
            // test1_sv4_result
            // 
            this.test1_sv4_result.BackColor = System.Drawing.Color.White;
            this.test1_sv4_result.ForeColor = System.Drawing.Color.Black;
            this.test1_sv4_result.Location = new System.Drawing.Point(558, 350);
            this.test1_sv4_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test1_sv4_result.Multiline = false;
            this.test1_sv4_result.Name = "test1_sv4_result";
            this.test1_sv4_result.Size = new System.Drawing.Size(66, 29);
            this.test1_sv4_result.TabIndex = 240;
            this.test1_sv4_result.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pVEOToolStripMenuItem,
            this.pVEDToolStripMenuItem,
            this.pVECToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(2948, 35);
            this.menuStrip1.TabIndex = 246;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pVEOToolStripMenuItem
            // 
            this.pVEOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.P12401100,
            this.P12401110,
            this.P12401090,
            this.P1240099,
            this.P1240090});
            this.pVEOToolStripMenuItem.Name = "pVEOToolStripMenuItem";
            this.pVEOToolStripMenuItem.Size = new System.Drawing.Size(68, 29);
            this.pVEOToolStripMenuItem.Text = "PVEO";
            // 
            // P12401100
            // 
            this.P12401100.Name = "P12401100";
            this.P12401100.Size = new System.Drawing.Size(190, 30);
            this.P12401100.Text = "124-0110-0";
            this.P12401100.Click += new System.EventHandler(this.P12401100_Click);
            // 
            // P12401110
            // 
            this.P12401110.Name = "P12401110";
            this.P12401110.Size = new System.Drawing.Size(190, 30);
            this.P12401110.Text = "124-0111-0";
            this.P12401110.Click += new System.EventHandler(this.P12401110_Click);
            // 
            // P12401090
            // 
            this.P12401090.Name = "P12401090";
            this.P12401090.Size = new System.Drawing.Size(190, 30);
            this.P12401090.Text = "124-0109-0";
            this.P12401090.Click += new System.EventHandler(this.P12401090_Click);
            // 
            // P1240099
            // 
            this.P1240099.Name = "P1240099";
            this.P1240099.Size = new System.Drawing.Size(190, 30);
            this.P1240099.Text = "124-0099-0";
            this.P1240099.Click += new System.EventHandler(this.P1240099_Click);
            // 
            // P1240090
            // 
            this.P1240090.Name = "P1240090";
            this.P1240090.Size = new System.Drawing.Size(190, 30);
            this.P1240090.Text = "124-0090-0";
            this.P1240090.Click += new System.EventHandler(this.P1240090_Click);
            // 
            // pVEDToolStripMenuItem
            // 
            this.pVEDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.P12401020,
            this.P12401010});
            this.pVEDToolStripMenuItem.Name = "pVEDToolStripMenuItem";
            this.pVEDToolStripMenuItem.Size = new System.Drawing.Size(67, 29);
            this.pVEDToolStripMenuItem.Text = "PVED";
            // 
            // P12401020
            // 
            this.P12401020.Name = "P12401020";
            this.P12401020.Size = new System.Drawing.Size(190, 30);
            this.P12401020.Text = "124-0102-0";
            this.P12401020.Click += new System.EventHandler(this.P12401020_Click);
            // 
            // P12401010
            // 
            this.P12401010.Name = "P12401010";
            this.P12401010.Size = new System.Drawing.Size(190, 30);
            this.P12401010.Text = "124-0101-0";
            this.P12401010.Click += new System.EventHandler(this.P12401010_Click);
            // 
            // pVECToolStripMenuItem
            // 
            this.pVECToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.P1240113,
            this.P1240112});
            this.pVECToolStripMenuItem.Name = "pVECToolStripMenuItem";
            this.pVECToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.pVECToolStripMenuItem.Text = "PVEC";
            // 
            // P1240113
            // 
            this.P1240113.Name = "P1240113";
            this.P1240113.Size = new System.Drawing.Size(173, 30);
            this.P1240113.Text = "124-0113";
            this.P1240113.Click += new System.EventHandler(this.P1240113_Click);
            // 
            // P1240112
            // 
            this.P1240112.Name = "P1240112";
            this.P1240112.Size = new System.Drawing.Size(173, 30);
            this.P1240112.Text = "124-0112";
            this.P1240112.Click += new System.EventHandler(this.P1240112_Click);
            // 
            // richTextBox9
            // 
            this.richTextBox9.BackColor = System.Drawing.Color.White;
            this.richTextBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox9.ForeColor = System.Drawing.Color.Black;
            this.richTextBox9.Location = new System.Drawing.Point(39, 592);
            this.richTextBox9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox9.Multiline = false;
            this.richTextBox9.Name = "richTextBox9";
            this.richTextBox9.Size = new System.Drawing.Size(66, 29);
            this.richTextBox9.TabIndex = 247;
            this.richTextBox9.Text = "Test 8";
            // 
            // test8_sv1_ll
            // 
            this.test8_sv1_ll.BackColor = System.Drawing.Color.White;
            this.test8_sv1_ll.ForeColor = System.Drawing.Color.Black;
            this.test8_sv1_ll.Location = new System.Drawing.Point(111, 592);
            this.test8_sv1_ll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test8_sv1_ll.Multiline = false;
            this.test8_sv1_ll.Name = "test8_sv1_ll";
            this.test8_sv1_ll.Size = new System.Drawing.Size(66, 29);
            this.test8_sv1_ll.TabIndex = 248;
            this.test8_sv1_ll.Text = "";
            // 
            // test8_sv2_result
            // 
            this.test8_sv2_result.BackColor = System.Drawing.Color.White;
            this.test8_sv2_result.ForeColor = System.Drawing.Color.Black;
            this.test8_sv2_result.Location = new System.Drawing.Point(182, 592);
            this.test8_sv2_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test8_sv2_result.Multiline = false;
            this.test8_sv2_result.Name = "test8_sv2_result";
            this.test8_sv2_result.Size = new System.Drawing.Size(66, 29);
            this.test8_sv2_result.TabIndex = 249;
            this.test8_sv2_result.Text = "";
            // 
            // test8_sv1_result
            // 
            this.test8_sv1_result.BackColor = System.Drawing.Color.White;
            this.test8_sv1_result.ForeColor = System.Drawing.Color.Black;
            this.test8_sv1_result.Location = new System.Drawing.Point(252, 592);
            this.test8_sv1_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test8_sv1_result.Multiline = false;
            this.test8_sv1_result.Name = "test8_sv1_result";
            this.test8_sv1_result.Size = new System.Drawing.Size(66, 29);
            this.test8_sv1_result.TabIndex = 250;
            this.test8_sv1_result.Text = "";
            // 
            // test8_sv1_ul
            // 
            this.test8_sv1_ul.BackColor = System.Drawing.Color.White;
            this.test8_sv1_ul.ForeColor = System.Drawing.Color.Black;
            this.test8_sv1_ul.Location = new System.Drawing.Point(322, 592);
            this.test8_sv1_ul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test8_sv1_ul.Multiline = false;
            this.test8_sv1_ul.Name = "test8_sv1_ul";
            this.test8_sv1_ul.Size = new System.Drawing.Size(66, 29);
            this.test8_sv1_ul.TabIndex = 251;
            this.test8_sv1_ul.Text = "";
            // 
            // test8_sv3_ll
            // 
            this.test8_sv3_ll.BackColor = System.Drawing.Color.White;
            this.test8_sv3_ll.ForeColor = System.Drawing.Color.Black;
            this.test8_sv3_ll.Location = new System.Drawing.Point(417, 592);
            this.test8_sv3_ll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test8_sv3_ll.Multiline = false;
            this.test8_sv3_ll.Name = "test8_sv3_ll";
            this.test8_sv3_ll.Size = new System.Drawing.Size(66, 29);
            this.test8_sv3_ll.TabIndex = 252;
            this.test8_sv3_ll.Text = "";
            // 
            // test8_sv3_result
            // 
            this.test8_sv3_result.BackColor = System.Drawing.Color.White;
            this.test8_sv3_result.ForeColor = System.Drawing.Color.Black;
            this.test8_sv3_result.Location = new System.Drawing.Point(488, 592);
            this.test8_sv3_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test8_sv3_result.Multiline = false;
            this.test8_sv3_result.Name = "test8_sv3_result";
            this.test8_sv3_result.Size = new System.Drawing.Size(66, 29);
            this.test8_sv3_result.TabIndex = 253;
            this.test8_sv3_result.Text = "";
            // 
            // test8_sv4_result
            // 
            this.test8_sv4_result.BackColor = System.Drawing.Color.White;
            this.test8_sv4_result.ForeColor = System.Drawing.Color.Black;
            this.test8_sv4_result.Location = new System.Drawing.Point(558, 592);
            this.test8_sv4_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test8_sv4_result.Multiline = false;
            this.test8_sv4_result.Name = "test8_sv4_result";
            this.test8_sv4_result.Size = new System.Drawing.Size(66, 29);
            this.test8_sv4_result.TabIndex = 254;
            this.test8_sv4_result.Text = "";
            // 
            // test8_sv3_ul
            // 
            this.test8_sv3_ul.BackColor = System.Drawing.Color.White;
            this.test8_sv3_ul.ForeColor = System.Drawing.Color.Black;
            this.test8_sv3_ul.Location = new System.Drawing.Point(628, 592);
            this.test8_sv3_ul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test8_sv3_ul.Multiline = false;
            this.test8_sv3_ul.Name = "test8_sv3_ul";
            this.test8_sv3_ul.Size = new System.Drawing.Size(66, 29);
            this.test8_sv3_ul.TabIndex = 255;
            this.test8_sv3_ul.Text = "";
            // 
            // test8_led_result
            // 
            this.test8_led_result.BackColor = System.Drawing.Color.White;
            this.test8_led_result.ForeColor = System.Drawing.Color.Black;
            this.test8_led_result.Location = new System.Drawing.Point(732, 593);
            this.test8_led_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test8_led_result.Multiline = false;
            this.test8_led_result.Name = "test8_led_result";
            this.test8_led_result.Size = new System.Drawing.Size(80, 29);
            this.test8_led_result.TabIndex = 256;
            this.test8_led_result.Text = "";
            // 
            // test8_led_target
            // 
            this.test8_led_target.BackColor = System.Drawing.Color.White;
            this.test8_led_target.ForeColor = System.Drawing.Color.Black;
            this.test8_led_target.Location = new System.Drawing.Point(816, 593);
            this.test8_led_target.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test8_led_target.Multiline = false;
            this.test8_led_target.Name = "test8_led_target";
            this.test8_led_target.Size = new System.Drawing.Size(80, 29);
            this.test8_led_target.TabIndex = 257;
            this.test8_led_target.Text = "";
            // 
            // test8_spool_ll
            // 
            this.test8_spool_ll.BackColor = System.Drawing.Color.White;
            this.test8_spool_ll.ForeColor = System.Drawing.Color.Black;
            this.test8_spool_ll.Location = new System.Drawing.Point(922, 593);
            this.test8_spool_ll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test8_spool_ll.Multiline = false;
            this.test8_spool_ll.Name = "test8_spool_ll";
            this.test8_spool_ll.Size = new System.Drawing.Size(66, 29);
            this.test8_spool_ll.TabIndex = 258;
            this.test8_spool_ll.Text = "";
            // 
            // test8_spool_result
            // 
            this.test8_spool_result.BackColor = System.Drawing.Color.White;
            this.test8_spool_result.ForeColor = System.Drawing.Color.Black;
            this.test8_spool_result.Location = new System.Drawing.Point(993, 593);
            this.test8_spool_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test8_spool_result.Multiline = false;
            this.test8_spool_result.Name = "test8_spool_result";
            this.test8_spool_result.Size = new System.Drawing.Size(66, 29);
            this.test8_spool_result.TabIndex = 259;
            this.test8_spool_result.Text = "";
            // 
            // test8_spool_ul
            // 
            this.test8_spool_ul.BackColor = System.Drawing.Color.White;
            this.test8_spool_ul.ForeColor = System.Drawing.Color.Black;
            this.test8_spool_ul.Location = new System.Drawing.Point(1060, 593);
            this.test8_spool_ul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test8_spool_ul.Multiline = false;
            this.test8_spool_ul.Name = "test8_spool_ul";
            this.test8_spool_ul.Size = new System.Drawing.Size(66, 29);
            this.test8_spool_ul.TabIndex = 260;
            this.test8_spool_ul.Text = "";
            // 
            // test8_dira_ll
            // 
            this.test8_dira_ll.BackColor = System.Drawing.Color.White;
            this.test8_dira_ll.ForeColor = System.Drawing.Color.Black;
            this.test8_dira_ll.Location = new System.Drawing.Point(1142, 593);
            this.test8_dira_ll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test8_dira_ll.Multiline = false;
            this.test8_dira_ll.Name = "test8_dira_ll";
            this.test8_dira_ll.Size = new System.Drawing.Size(66, 29);
            this.test8_dira_ll.TabIndex = 261;
            this.test8_dira_ll.Text = "";
            // 
            // test8_dira_result
            // 
            this.test8_dira_result.BackColor = System.Drawing.Color.White;
            this.test8_dira_result.ForeColor = System.Drawing.Color.Black;
            this.test8_dira_result.Location = new System.Drawing.Point(1210, 592);
            this.test8_dira_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test8_dira_result.Multiline = false;
            this.test8_dira_result.Name = "test8_dira_result";
            this.test8_dira_result.Size = new System.Drawing.Size(66, 29);
            this.test8_dira_result.TabIndex = 262;
            this.test8_dira_result.Text = "";
            // 
            // test8_dira_ul
            // 
            this.test8_dira_ul.BackColor = System.Drawing.Color.White;
            this.test8_dira_ul.ForeColor = System.Drawing.Color.Black;
            this.test8_dira_ul.Location = new System.Drawing.Point(1280, 590);
            this.test8_dira_ul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test8_dira_ul.Multiline = false;
            this.test8_dira_ul.Name = "test8_dira_ul";
            this.test8_dira_ul.Size = new System.Drawing.Size(66, 29);
            this.test8_dira_ul.TabIndex = 263;
            this.test8_dira_ul.Text = "";
            // 
            // test8_dirb_ll
            // 
            this.test8_dirb_ll.BackColor = System.Drawing.Color.White;
            this.test8_dirb_ll.ForeColor = System.Drawing.Color.Black;
            this.test8_dirb_ll.Location = new System.Drawing.Point(1372, 588);
            this.test8_dirb_ll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test8_dirb_ll.Multiline = false;
            this.test8_dirb_ll.Name = "test8_dirb_ll";
            this.test8_dirb_ll.Size = new System.Drawing.Size(66, 29);
            this.test8_dirb_ll.TabIndex = 264;
            this.test8_dirb_ll.Text = "";
            // 
            // test8_dirb_result
            // 
            this.test8_dirb_result.BackColor = System.Drawing.Color.White;
            this.test8_dirb_result.ForeColor = System.Drawing.Color.Black;
            this.test8_dirb_result.Location = new System.Drawing.Point(1442, 587);
            this.test8_dirb_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test8_dirb_result.Multiline = false;
            this.test8_dirb_result.Name = "test8_dirb_result";
            this.test8_dirb_result.Size = new System.Drawing.Size(66, 29);
            this.test8_dirb_result.TabIndex = 265;
            this.test8_dirb_result.Text = "";
            // 
            // test8_dirb_ul
            // 
            this.test8_dirb_ul.BackColor = System.Drawing.Color.White;
            this.test8_dirb_ul.ForeColor = System.Drawing.Color.Black;
            this.test8_dirb_ul.Location = new System.Drawing.Point(1510, 585);
            this.test8_dirb_ul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test8_dirb_ul.Multiline = false;
            this.test8_dirb_ul.Name = "test8_dirb_ul";
            this.test8_dirb_ul.Size = new System.Drawing.Size(66, 29);
            this.test8_dirb_ul.TabIndex = 266;
            this.test8_dirb_ul.Text = "";
            // 
            // test8_drven_ll
            // 
            this.test8_drven_ll.BackColor = System.Drawing.Color.White;
            this.test8_drven_ll.ForeColor = System.Drawing.Color.Black;
            this.test8_drven_ll.Location = new System.Drawing.Point(1596, 583);
            this.test8_drven_ll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test8_drven_ll.Multiline = false;
            this.test8_drven_ll.Name = "test8_drven_ll";
            this.test8_drven_ll.Size = new System.Drawing.Size(66, 29);
            this.test8_drven_ll.TabIndex = 267;
            this.test8_drven_ll.Text = "";
            // 
            // test8_drven_result
            // 
            this.test8_drven_result.BackColor = System.Drawing.Color.White;
            this.test8_drven_result.ForeColor = System.Drawing.Color.Black;
            this.test8_drven_result.Location = new System.Drawing.Point(1665, 583);
            this.test8_drven_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test8_drven_result.Multiline = false;
            this.test8_drven_result.Name = "test8_drven_result";
            this.test8_drven_result.Size = new System.Drawing.Size(66, 29);
            this.test8_drven_result.TabIndex = 268;
            this.test8_drven_result.Text = "";
            // 
            // test8_drven_ul
            // 
            this.test8_drven_ul.BackColor = System.Drawing.Color.White;
            this.test8_drven_ul.ForeColor = System.Drawing.Color.Black;
            this.test8_drven_ul.Location = new System.Drawing.Point(1734, 582);
            this.test8_drven_ul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test8_drven_ul.Multiline = false;
            this.test8_drven_ul.Name = "test8_drven_ul";
            this.test8_drven_ul.Size = new System.Drawing.Size(66, 29);
            this.test8_drven_ul.TabIndex = 269;
            this.test8_drven_ul.Text = "";
            // 
            // test8_result
            // 
            this.test8_result.BackColor = System.Drawing.Color.White;
            this.test8_result.ForeColor = System.Drawing.Color.Black;
            this.test8_result.Location = new System.Drawing.Point(1818, 580);
            this.test8_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test8_result.Multiline = false;
            this.test8_result.Name = "test8_result";
            this.test8_result.Size = new System.Drawing.Size(28, 29);
            this.test8_result.TabIndex = 270;
            this.test8_result.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(33, 218);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 33);
            this.label10.TabIndex = 271;
            this.label10.Text = "SN:";
            // 
            // SNInput
            // 
            this.SNInput.BackColor = System.Drawing.Color.White;
            this.SNInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SNInput.ForeColor = System.Drawing.Color.Black;
            this.SNInput.Location = new System.Drawing.Point(242, 223);
            this.SNInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SNInput.Multiline = false;
            this.SNInput.Name = "SNInput";
            this.SNInput.Size = new System.Drawing.Size(133, 29);
            this.SNInput.TabIndex = 272;
            this.SNInput.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1121, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 20);
            this.label11.TabIndex = 273;
            this.label11.Text = "Sample";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1121, 161);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 20);
            this.label12.TabIndex = 274;
            this.label12.Text = "Production";
            // 
            // test0_sv4_result
            // 
            this.test0_sv4_result.BackColor = System.Drawing.Color.White;
            this.test0_sv4_result.ForeColor = System.Drawing.Color.Black;
            this.test0_sv4_result.Location = new System.Drawing.Point(560, 315);
            this.test0_sv4_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test0_sv4_result.Multiline = false;
            this.test0_sv4_result.Name = "test0_sv4_result";
            this.test0_sv4_result.Size = new System.Drawing.Size(66, 29);
            this.test0_sv4_result.TabIndex = 298;
            this.test0_sv4_result.Text = "";
            // 
            // test0_sv2_result
            // 
            this.test0_sv2_result.BackColor = System.Drawing.Color.White;
            this.test0_sv2_result.ForeColor = System.Drawing.Color.Black;
            this.test0_sv2_result.Location = new System.Drawing.Point(184, 315);
            this.test0_sv2_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test0_sv2_result.Multiline = false;
            this.test0_sv2_result.Name = "test0_sv2_result";
            this.test0_sv2_result.Size = new System.Drawing.Size(66, 29);
            this.test0_sv2_result.TabIndex = 297;
            this.test0_sv2_result.Text = "";
            // 
            // test0_result
            // 
            this.test0_result.BackColor = System.Drawing.Color.White;
            this.test0_result.ForeColor = System.Drawing.Color.Black;
            this.test0_result.Location = new System.Drawing.Point(1817, 315);
            this.test0_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test0_result.Multiline = false;
            this.test0_result.Name = "test0_result";
            this.test0_result.Size = new System.Drawing.Size(28, 29);
            this.test0_result.TabIndex = 296;
            this.test0_result.Text = "";
            // 
            // test0_led_target
            // 
            this.test0_led_target.BackColor = System.Drawing.Color.White;
            this.test0_led_target.ForeColor = System.Drawing.Color.Black;
            this.test0_led_target.Location = new System.Drawing.Point(818, 315);
            this.test0_led_target.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test0_led_target.Multiline = false;
            this.test0_led_target.Name = "test0_led_target";
            this.test0_led_target.Size = new System.Drawing.Size(80, 29);
            this.test0_led_target.TabIndex = 295;
            this.test0_led_target.Text = "";
            // 
            // test0_drven_result
            // 
            this.test0_drven_result.BackColor = System.Drawing.Color.White;
            this.test0_drven_result.ForeColor = System.Drawing.Color.Black;
            this.test0_drven_result.Location = new System.Drawing.Point(1667, 315);
            this.test0_drven_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test0_drven_result.Multiline = false;
            this.test0_drven_result.Name = "test0_drven_result";
            this.test0_drven_result.Size = new System.Drawing.Size(66, 29);
            this.test0_drven_result.TabIndex = 294;
            this.test0_drven_result.Text = "";
            // 
            // test0_drven_ul
            // 
            this.test0_drven_ul.BackColor = System.Drawing.Color.White;
            this.test0_drven_ul.ForeColor = System.Drawing.Color.Black;
            this.test0_drven_ul.Location = new System.Drawing.Point(1736, 315);
            this.test0_drven_ul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test0_drven_ul.Multiline = false;
            this.test0_drven_ul.Name = "test0_drven_ul";
            this.test0_drven_ul.Size = new System.Drawing.Size(66, 29);
            this.test0_drven_ul.TabIndex = 293;
            this.test0_drven_ul.Text = "";
            // 
            // test0_drven_ll
            // 
            this.test0_drven_ll.BackColor = System.Drawing.Color.White;
            this.test0_drven_ll.ForeColor = System.Drawing.Color.Black;
            this.test0_drven_ll.Location = new System.Drawing.Point(1598, 315);
            this.test0_drven_ll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test0_drven_ll.Multiline = false;
            this.test0_drven_ll.Name = "test0_drven_ll";
            this.test0_drven_ll.Size = new System.Drawing.Size(66, 29);
            this.test0_drven_ll.TabIndex = 292;
            this.test0_drven_ll.Text = "";
            // 
            // test0_dirb_result
            // 
            this.test0_dirb_result.BackColor = System.Drawing.Color.White;
            this.test0_dirb_result.ForeColor = System.Drawing.Color.Black;
            this.test0_dirb_result.Location = new System.Drawing.Point(1444, 315);
            this.test0_dirb_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test0_dirb_result.Multiline = false;
            this.test0_dirb_result.Name = "test0_dirb_result";
            this.test0_dirb_result.Size = new System.Drawing.Size(66, 29);
            this.test0_dirb_result.TabIndex = 291;
            this.test0_dirb_result.Text = "";
            // 
            // test0_dirb_ul
            // 
            this.test0_dirb_ul.BackColor = System.Drawing.Color.White;
            this.test0_dirb_ul.ForeColor = System.Drawing.Color.Black;
            this.test0_dirb_ul.Location = new System.Drawing.Point(1512, 315);
            this.test0_dirb_ul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test0_dirb_ul.Multiline = false;
            this.test0_dirb_ul.Name = "test0_dirb_ul";
            this.test0_dirb_ul.Size = new System.Drawing.Size(66, 29);
            this.test0_dirb_ul.TabIndex = 290;
            this.test0_dirb_ul.Text = "";
            // 
            // test0_dirb_ll
            // 
            this.test0_dirb_ll.BackColor = System.Drawing.Color.White;
            this.test0_dirb_ll.ForeColor = System.Drawing.Color.Black;
            this.test0_dirb_ll.Location = new System.Drawing.Point(1374, 315);
            this.test0_dirb_ll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test0_dirb_ll.Multiline = false;
            this.test0_dirb_ll.Name = "test0_dirb_ll";
            this.test0_dirb_ll.Size = new System.Drawing.Size(66, 29);
            this.test0_dirb_ll.TabIndex = 289;
            this.test0_dirb_ll.Text = "";
            // 
            // test0_dira_result
            // 
            this.test0_dira_result.BackColor = System.Drawing.Color.White;
            this.test0_dira_result.ForeColor = System.Drawing.Color.Black;
            this.test0_dira_result.Location = new System.Drawing.Point(1212, 315);
            this.test0_dira_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test0_dira_result.Multiline = false;
            this.test0_dira_result.Name = "test0_dira_result";
            this.test0_dira_result.Size = new System.Drawing.Size(66, 29);
            this.test0_dira_result.TabIndex = 288;
            this.test0_dira_result.Text = "";
            // 
            // test0_dira_ul
            // 
            this.test0_dira_ul.BackColor = System.Drawing.Color.White;
            this.test0_dira_ul.ForeColor = System.Drawing.Color.Black;
            this.test0_dira_ul.Location = new System.Drawing.Point(1282, 315);
            this.test0_dira_ul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test0_dira_ul.Multiline = false;
            this.test0_dira_ul.Name = "test0_dira_ul";
            this.test0_dira_ul.Size = new System.Drawing.Size(66, 29);
            this.test0_dira_ul.TabIndex = 287;
            this.test0_dira_ul.Text = "";
            // 
            // test0_dira_ll
            // 
            this.test0_dira_ll.BackColor = System.Drawing.Color.White;
            this.test0_dira_ll.ForeColor = System.Drawing.Color.Black;
            this.test0_dira_ll.Location = new System.Drawing.Point(1144, 315);
            this.test0_dira_ll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test0_dira_ll.Multiline = false;
            this.test0_dira_ll.Name = "test0_dira_ll";
            this.test0_dira_ll.Size = new System.Drawing.Size(66, 29);
            this.test0_dira_ll.TabIndex = 286;
            this.test0_dira_ll.Text = "";
            // 
            // test0_spool_result
            // 
            this.test0_spool_result.BackColor = System.Drawing.Color.White;
            this.test0_spool_result.ForeColor = System.Drawing.Color.Black;
            this.test0_spool_result.Location = new System.Drawing.Point(994, 315);
            this.test0_spool_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test0_spool_result.Multiline = false;
            this.test0_spool_result.Name = "test0_spool_result";
            this.test0_spool_result.Size = new System.Drawing.Size(66, 29);
            this.test0_spool_result.TabIndex = 285;
            this.test0_spool_result.Text = "";
            // 
            // test0_spool_ul
            // 
            this.test0_spool_ul.BackColor = System.Drawing.Color.White;
            this.test0_spool_ul.ForeColor = System.Drawing.Color.Black;
            this.test0_spool_ul.Location = new System.Drawing.Point(1062, 315);
            this.test0_spool_ul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test0_spool_ul.Multiline = false;
            this.test0_spool_ul.Name = "test0_spool_ul";
            this.test0_spool_ul.Size = new System.Drawing.Size(66, 29);
            this.test0_spool_ul.TabIndex = 284;
            this.test0_spool_ul.Text = "";
            // 
            // test0_spool_ll
            // 
            this.test0_spool_ll.BackColor = System.Drawing.Color.White;
            this.test0_spool_ll.ForeColor = System.Drawing.Color.Black;
            this.test0_spool_ll.Location = new System.Drawing.Point(924, 315);
            this.test0_spool_ll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test0_spool_ll.Multiline = false;
            this.test0_spool_ll.Name = "test0_spool_ll";
            this.test0_spool_ll.Size = new System.Drawing.Size(66, 29);
            this.test0_spool_ll.TabIndex = 283;
            this.test0_spool_ll.Text = "";
            // 
            // test0_sv3_result
            // 
            this.test0_sv3_result.BackColor = System.Drawing.Color.White;
            this.test0_sv3_result.ForeColor = System.Drawing.Color.Black;
            this.test0_sv3_result.Location = new System.Drawing.Point(490, 315);
            this.test0_sv3_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test0_sv3_result.Multiline = false;
            this.test0_sv3_result.Name = "test0_sv3_result";
            this.test0_sv3_result.Size = new System.Drawing.Size(66, 29);
            this.test0_sv3_result.TabIndex = 282;
            this.test0_sv3_result.Text = "";
            // 
            // test0_sv3_ul
            // 
            this.test0_sv3_ul.BackColor = System.Drawing.Color.White;
            this.test0_sv3_ul.ForeColor = System.Drawing.Color.Black;
            this.test0_sv3_ul.Location = new System.Drawing.Point(630, 315);
            this.test0_sv3_ul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test0_sv3_ul.Multiline = false;
            this.test0_sv3_ul.Name = "test0_sv3_ul";
            this.test0_sv3_ul.Size = new System.Drawing.Size(66, 29);
            this.test0_sv3_ul.TabIndex = 281;
            this.test0_sv3_ul.Text = "";
            // 
            // test0_sv3_ll
            // 
            this.test0_sv3_ll.BackColor = System.Drawing.Color.White;
            this.test0_sv3_ll.ForeColor = System.Drawing.Color.Black;
            this.test0_sv3_ll.Location = new System.Drawing.Point(419, 315);
            this.test0_sv3_ll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test0_sv3_ll.Multiline = false;
            this.test0_sv3_ll.Name = "test0_sv3_ll";
            this.test0_sv3_ll.Size = new System.Drawing.Size(66, 29);
            this.test0_sv3_ll.TabIndex = 280;
            this.test0_sv3_ll.Text = "";
            // 
            // test0_sv1_result
            // 
            this.test0_sv1_result.BackColor = System.Drawing.Color.White;
            this.test0_sv1_result.ForeColor = System.Drawing.Color.Black;
            this.test0_sv1_result.Location = new System.Drawing.Point(254, 315);
            this.test0_sv1_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test0_sv1_result.Multiline = false;
            this.test0_sv1_result.Name = "test0_sv1_result";
            this.test0_sv1_result.Size = new System.Drawing.Size(66, 29);
            this.test0_sv1_result.TabIndex = 279;
            this.test0_sv1_result.Text = "";
            // 
            // test0_sv1_ul
            // 
            this.test0_sv1_ul.BackColor = System.Drawing.Color.White;
            this.test0_sv1_ul.ForeColor = System.Drawing.Color.Black;
            this.test0_sv1_ul.Location = new System.Drawing.Point(324, 315);
            this.test0_sv1_ul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test0_sv1_ul.Multiline = false;
            this.test0_sv1_ul.Name = "test0_sv1_ul";
            this.test0_sv1_ul.Size = new System.Drawing.Size(66, 29);
            this.test0_sv1_ul.TabIndex = 278;
            this.test0_sv1_ul.Text = "";
            // 
            // test0_sv1_ll
            // 
            this.test0_sv1_ll.BackColor = System.Drawing.Color.White;
            this.test0_sv1_ll.ForeColor = System.Drawing.Color.Black;
            this.test0_sv1_ll.Location = new System.Drawing.Point(113, 315);
            this.test0_sv1_ll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test0_sv1_ll.Multiline = false;
            this.test0_sv1_ll.Name = "test0_sv1_ll";
            this.test0_sv1_ll.Size = new System.Drawing.Size(66, 29);
            this.test0_sv1_ll.TabIndex = 277;
            this.test0_sv1_ll.Text = "";
            // 
            // test0_led_result
            // 
            this.test0_led_result.BackColor = System.Drawing.Color.White;
            this.test0_led_result.ForeColor = System.Drawing.Color.Black;
            this.test0_led_result.Location = new System.Drawing.Point(734, 315);
            this.test0_led_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test0_led_result.Multiline = false;
            this.test0_led_result.Name = "test0_led_result";
            this.test0_led_result.Size = new System.Drawing.Size(80, 29);
            this.test0_led_result.TabIndex = 276;
            this.test0_led_result.Text = "";
            // 
            // test_name0
            // 
            this.test_name0.BackColor = System.Drawing.Color.White;
            this.test_name0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.test_name0.ForeColor = System.Drawing.Color.Black;
            this.test_name0.Location = new System.Drawing.Point(40, 315);
            this.test_name0.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test_name0.Multiline = false;
            this.test_name0.Name = "test_name0";
            this.test_name0.Size = new System.Drawing.Size(66, 29);
            this.test_name0.TabIndex = 275;
            this.test_name0.Text = "Test 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1028);
            this.Controls.Add(this.test0_sv4_result);
            this.Controls.Add(this.test0_sv2_result);
            this.Controls.Add(this.test0_result);
            this.Controls.Add(this.test0_led_target);
            this.Controls.Add(this.test0_drven_result);
            this.Controls.Add(this.test0_drven_ul);
            this.Controls.Add(this.test0_drven_ll);
            this.Controls.Add(this.test0_dirb_result);
            this.Controls.Add(this.test0_dirb_ul);
            this.Controls.Add(this.test0_dirb_ll);
            this.Controls.Add(this.test0_dira_result);
            this.Controls.Add(this.test0_dira_ul);
            this.Controls.Add(this.test0_dira_ll);
            this.Controls.Add(this.test0_spool_result);
            this.Controls.Add(this.test0_spool_ul);
            this.Controls.Add(this.test0_spool_ll);
            this.Controls.Add(this.test0_sv3_result);
            this.Controls.Add(this.test0_sv3_ul);
            this.Controls.Add(this.test0_sv3_ll);
            this.Controls.Add(this.test0_sv1_result);
            this.Controls.Add(this.test0_sv1_ul);
            this.Controls.Add(this.test0_sv1_ll);
            this.Controls.Add(this.test0_led_result);
            this.Controls.Add(this.test_name0);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.SNInput);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.test8_result);
            this.Controls.Add(this.test8_drven_ul);
            this.Controls.Add(this.test8_drven_result);
            this.Controls.Add(this.test8_drven_ll);
            this.Controls.Add(this.test8_dirb_ul);
            this.Controls.Add(this.test8_dirb_result);
            this.Controls.Add(this.test8_dirb_ll);
            this.Controls.Add(this.test8_dira_ul);
            this.Controls.Add(this.test8_dira_result);
            this.Controls.Add(this.test8_dira_ll);
            this.Controls.Add(this.test8_spool_ul);
            this.Controls.Add(this.test8_spool_result);
            this.Controls.Add(this.test8_spool_ll);
            this.Controls.Add(this.test8_led_target);
            this.Controls.Add(this.test8_led_result);
            this.Controls.Add(this.test8_sv3_ul);
            this.Controls.Add(this.test8_sv4_result);
            this.Controls.Add(this.test8_sv3_result);
            this.Controls.Add(this.test8_sv3_ll);
            this.Controls.Add(this.test8_sv1_ul);
            this.Controls.Add(this.test8_sv1_result);
            this.Controls.Add(this.test8_sv2_result);
            this.Controls.Add(this.test8_sv1_ll);
            this.Controls.Add(this.richTextBox9);
            this.Controls.Add(this.test6_sv4_result);
            this.Controls.Add(this.test5_sv4_result);
            this.Controls.Add(this.test4_sv4_result);
            this.Controls.Add(this.test3_sv4_result);
            this.Controls.Add(this.test2_sv4_result);
            this.Controls.Add(this.test1_sv4_result);
            this.Controls.Add(this.test6_sv2_result);
            this.Controls.Add(this.test5_sv2_result);
            this.Controls.Add(this.test4_sv2_result);
            this.Controls.Add(this.test3_sv2_result);
            this.Controls.Add(this.test2_sv2_result);
            this.Controls.Add(this.test1_sv2_result);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Saturation);
            this.Controls.Add(this.Brightness);
            this.Controls.Add(this.Hue);
            this.Controls.Add(this.Right);
            this.Controls.Add(this.Left);
            this.Controls.Add(this.Down);
            this.Controls.Add(this.Up);
            this.Controls.Add(this.LedPicture);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LedVideo);
            this.Controls.Add(this.debugit);
            this.Controls.Add(this.sys_ready);
            this.Controls.Add(this.meastime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lvdt_result);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.test7_result);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.test7_sv3_result);
            this.Controls.Add(this.test7_sv3_ul);
            this.Controls.Add(this.test7_sv3_ll);
            this.Controls.Add(this.test7_sv1_result);
            this.Controls.Add(this.test7_sv1_ul);
            this.Controls.Add(this.test7_sv1_ll);
            this.Controls.Add(this.richTextBox143);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.test6_result);
            this.Controls.Add(this.test5_result);
            this.Controls.Add(this.test4_result);
            this.Controls.Add(this.test3_result);
            this.Controls.Add(this.test2_result);
            this.Controls.Add(this.test1_result);
            this.Controls.Add(this.test6_led_target);
            this.Controls.Add(this.test6_led_result);
            this.Controls.Add(this.test5_led_target);
            this.Controls.Add(this.test5_led_result);
            this.Controls.Add(this.test4_led_target);
            this.Controls.Add(this.test4_led_result);
            this.Controls.Add(this.test3_led_target);
            this.Controls.Add(this.test3_led_result);
            this.Controls.Add(this.test2_led_target);
            this.Controls.Add(this.test2_led_result);
            this.Controls.Add(this.test1_led_target);
            this.Controls.Add(this.test6_drven_result);
            this.Controls.Add(this.test5_drven_result);
            this.Controls.Add(this.test4_drven_result);
            this.Controls.Add(this.test3_drven_result);
            this.Controls.Add(this.test2_drven_result);
            this.Controls.Add(this.test1_drven_result);
            this.Controls.Add(this.test6_drven_ul);
            this.Controls.Add(this.test5_drven_ul);
            this.Controls.Add(this.test4_drven_ul);
            this.Controls.Add(this.test3_drven_ul);
            this.Controls.Add(this.test2_drven_ul);
            this.Controls.Add(this.test1_drven_ul);
            this.Controls.Add(this.test6_drven_ll);
            this.Controls.Add(this.test5_drven_ll);
            this.Controls.Add(this.test4_drven_ll);
            this.Controls.Add(this.test3_drven_ll);
            this.Controls.Add(this.test2_drven_ll);
            this.Controls.Add(this.test1_drven_ll);
            this.Controls.Add(this.test6_dirb_result);
            this.Controls.Add(this.test5_dirb_result);
            this.Controls.Add(this.test4_dirb_result);
            this.Controls.Add(this.test3_dirb_result);
            this.Controls.Add(this.test2_dirb_result);
            this.Controls.Add(this.test1_dirb_result);
            this.Controls.Add(this.test6_dirb_ul);
            this.Controls.Add(this.test5_dirb_ul);
            this.Controls.Add(this.test4_dirb_ul);
            this.Controls.Add(this.test3_dirb_ul);
            this.Controls.Add(this.test2_dirb_ul);
            this.Controls.Add(this.test1_dirb_ul);
            this.Controls.Add(this.test6_dirb_ll);
            this.Controls.Add(this.test5_dirb_ll);
            this.Controls.Add(this.test4_dirb_ll);
            this.Controls.Add(this.test3_dirb_ll);
            this.Controls.Add(this.test2_dirb_ll);
            this.Controls.Add(this.test1_dirb_ll);
            this.Controls.Add(this.test6_dira_result);
            this.Controls.Add(this.test5_dira_result);
            this.Controls.Add(this.test4_dira_result);
            this.Controls.Add(this.test3_dira_result);
            this.Controls.Add(this.test2_dira_result);
            this.Controls.Add(this.test1_dira_result);
            this.Controls.Add(this.test6_dira_ul);
            this.Controls.Add(this.test5_dira_ul);
            this.Controls.Add(this.test4_dira_ul);
            this.Controls.Add(this.test3_dira_ul);
            this.Controls.Add(this.test2_dira_ul);
            this.Controls.Add(this.test1_dira_ul);
            this.Controls.Add(this.test6_dira_ll);
            this.Controls.Add(this.test5_dira_ll);
            this.Controls.Add(this.test4_dira_ll);
            this.Controls.Add(this.test3_dira_ll);
            this.Controls.Add(this.test2_dira_ll);
            this.Controls.Add(this.test1_dira_ll);
            this.Controls.Add(this.test6_spool_result);
            this.Controls.Add(this.test5_spool_result);
            this.Controls.Add(this.test4_spool_result);
            this.Controls.Add(this.test3_spool_result);
            this.Controls.Add(this.test2_spool_result);
            this.Controls.Add(this.test1_spool_result);
            this.Controls.Add(this.test6_spool_ul);
            this.Controls.Add(this.test5_spool_ul);
            this.Controls.Add(this.test4_spool_ul);
            this.Controls.Add(this.test3_spool_ul);
            this.Controls.Add(this.test2_spool_ul);
            this.Controls.Add(this.test1_spool_ul);
            this.Controls.Add(this.test6_spool_ll);
            this.Controls.Add(this.test5_spool_ll);
            this.Controls.Add(this.test4_spool_ll);
            this.Controls.Add(this.test3_spool_ll);
            this.Controls.Add(this.test2_spool_ll);
            this.Controls.Add(this.test1_spool_ll);
            this.Controls.Add(this.test6_sv3_result);
            this.Controls.Add(this.test5_sv3_result);
            this.Controls.Add(this.test4_sv3_result);
            this.Controls.Add(this.test3_sv3_result);
            this.Controls.Add(this.test2_sv3_result);
            this.Controls.Add(this.test1_sv3_result);
            this.Controls.Add(this.test6_sv3_ul);
            this.Controls.Add(this.test5_sv3_ul);
            this.Controls.Add(this.test4_sv3_ul);
            this.Controls.Add(this.test3_sv3_ul);
            this.Controls.Add(this.test2_sv3_ul);
            this.Controls.Add(this.test1_sv3_ul);
            this.Controls.Add(this.test6_sv3_ll);
            this.Controls.Add(this.test5_sv3_ll);
            this.Controls.Add(this.test4_sv3_ll);
            this.Controls.Add(this.test3_sv3_ll);
            this.Controls.Add(this.test2_sv3_ll);
            this.Controls.Add(this.test1_sv3_ll);
            this.Controls.Add(this.test6_sv1_result);
            this.Controls.Add(this.test5_sv1_result);
            this.Controls.Add(this.test4_sv1_result);
            this.Controls.Add(this.test3_sv1_result);
            this.Controls.Add(this.test2_sv1_result);
            this.Controls.Add(this.test1_sv1_result);
            this.Controls.Add(this.test6_sv1_ul);
            this.Controls.Add(this.test5_sv1_ul);
            this.Controls.Add(this.test4_sv1_ul);
            this.Controls.Add(this.test3_sv1_ul);
            this.Controls.Add(this.test2_sv1_ul);
            this.Controls.Add(this.test1_sv1_ul);
            this.Controls.Add(this.test6_sv1_ll);
            this.Controls.Add(this.test5_sv1_ll);
            this.Controls.Add(this.test4_sv1_ll);
            this.Controls.Add(this.test3_sv1_ll);
            this.Controls.Add(this.test2_sv1_ll);
            this.Controls.Add(this.test1_sv1_ll);
            this.Controls.Add(this.test1_led_result);
            this.Controls.Add(this.richTextBox8);
            this.Controls.Add(this.richTextBox7);
            this.Controls.Add(this.richTextBox6);
            this.Controls.Add(this.richTextBox5);
            this.Controls.Add(this.test_name2);
            this.Controls.Add(this.test_name1);
            this.Controls.Add(this.articlecode_field);
            this.Controls.Add(this.articlenumber_field);
            this.Controls.Add(this.article_code);
            this.Controls.Add(this.article_description);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plotwindow);
            this.Controls.Add(this.messagebox1);
            this.Controls.Add(this.testresult);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sauer Danfoss \'series 6 & 7\' end of line test";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.LedVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LedPicture)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel testresult;
        private System.Windows.Forms.RichTextBox messagebox1;
        private System.IO.Ports.SerialPort serialPortTester;
        private ZedGraph.ZedGraphControl plotwindow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label article_description;
        private System.Windows.Forms.Label article_code;
        private System.Windows.Forms.RichTextBox articlenumber_field;
        private System.Windows.Forms.RichTextBox articlecode_field;
        private System.Windows.Forms.RichTextBox test_name1;
        private System.Windows.Forms.RichTextBox test_name2;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.RichTextBox richTextBox6;
        private System.Windows.Forms.RichTextBox richTextBox7;
        private System.Windows.Forms.RichTextBox richTextBox8;
        private System.Windows.Forms.RichTextBox test1_led_result;
        private System.Windows.Forms.RichTextBox test6_sv1_ll;
        private System.Windows.Forms.RichTextBox test5_sv1_ll;
        private System.Windows.Forms.RichTextBox test4_sv1_ll;
        private System.Windows.Forms.RichTextBox test3_sv1_ll;
        private System.Windows.Forms.RichTextBox test2_sv1_ll;
        private System.Windows.Forms.RichTextBox test1_sv1_ll;
        private System.Windows.Forms.RichTextBox test6_sv1_ul;
        private System.Windows.Forms.RichTextBox test5_sv1_ul;
        private System.Windows.Forms.RichTextBox test4_sv1_ul;
        private System.Windows.Forms.RichTextBox test3_sv1_ul;
        private System.Windows.Forms.RichTextBox test2_sv1_ul;
        private System.Windows.Forms.RichTextBox test1_sv1_ul;
        private System.Windows.Forms.RichTextBox test6_sv1_result;
        private System.Windows.Forms.RichTextBox test5_sv1_result;
        private System.Windows.Forms.RichTextBox test4_sv1_result;
        private System.Windows.Forms.RichTextBox test3_sv1_result;
        private System.Windows.Forms.RichTextBox test2_sv1_result;
        private System.Windows.Forms.RichTextBox test1_sv1_result;
        private System.Windows.Forms.RichTextBox test6_sv3_result;
        private System.Windows.Forms.RichTextBox test5_sv3_result;
        private System.Windows.Forms.RichTextBox test4_sv3_result;
        private System.Windows.Forms.RichTextBox test3_sv3_result;
        private System.Windows.Forms.RichTextBox test2_sv3_result;
        private System.Windows.Forms.RichTextBox test1_sv3_result;
        private System.Windows.Forms.RichTextBox test6_sv3_ul;
        private System.Windows.Forms.RichTextBox test5_sv3_ul;
        private System.Windows.Forms.RichTextBox test4_sv3_ul;
        private System.Windows.Forms.RichTextBox test3_sv3_ul;
        private System.Windows.Forms.RichTextBox test2_sv3_ul;
        private System.Windows.Forms.RichTextBox test1_sv3_ul;
        private System.Windows.Forms.RichTextBox test6_sv3_ll;
        private System.Windows.Forms.RichTextBox test5_sv3_ll;
        private System.Windows.Forms.RichTextBox test4_sv3_ll;
        private System.Windows.Forms.RichTextBox test3_sv3_ll;
        private System.Windows.Forms.RichTextBox test2_sv3_ll;
        private System.Windows.Forms.RichTextBox test1_sv3_ll;
        private System.Windows.Forms.RichTextBox test6_spool_result;
        private System.Windows.Forms.RichTextBox test5_spool_result;
        private System.Windows.Forms.RichTextBox test4_spool_result;
        private System.Windows.Forms.RichTextBox test3_spool_result;
        private System.Windows.Forms.RichTextBox test2_spool_result;
        private System.Windows.Forms.RichTextBox test1_spool_result;
        private System.Windows.Forms.RichTextBox test6_spool_ul;
        private System.Windows.Forms.RichTextBox test5_spool_ul;
        private System.Windows.Forms.RichTextBox test4_spool_ul;
        private System.Windows.Forms.RichTextBox test3_spool_ul;
        private System.Windows.Forms.RichTextBox test2_spool_ul;
        private System.Windows.Forms.RichTextBox test1_spool_ul;
        private System.Windows.Forms.RichTextBox test6_spool_ll;
        private System.Windows.Forms.RichTextBox test5_spool_ll;
        private System.Windows.Forms.RichTextBox test4_spool_ll;
        private System.Windows.Forms.RichTextBox test3_spool_ll;
        private System.Windows.Forms.RichTextBox test2_spool_ll;
        private System.Windows.Forms.RichTextBox test1_spool_ll;
        private System.Windows.Forms.RichTextBox test6_dira_result;
        private System.Windows.Forms.RichTextBox test5_dira_result;
        private System.Windows.Forms.RichTextBox test4_dira_result;
        private System.Windows.Forms.RichTextBox test3_dira_result;
        private System.Windows.Forms.RichTextBox test2_dira_result;
        private System.Windows.Forms.RichTextBox test1_dira_result;
        private System.Windows.Forms.RichTextBox test6_dira_ul;
        private System.Windows.Forms.RichTextBox test5_dira_ul;
        private System.Windows.Forms.RichTextBox test4_dira_ul;
        private System.Windows.Forms.RichTextBox test3_dira_ul;
        private System.Windows.Forms.RichTextBox test2_dira_ul;
        private System.Windows.Forms.RichTextBox test1_dira_ul;
        private System.Windows.Forms.RichTextBox test6_dira_ll;
        private System.Windows.Forms.RichTextBox test5_dira_ll;
        private System.Windows.Forms.RichTextBox test4_dira_ll;
        private System.Windows.Forms.RichTextBox test3_dira_ll;
        private System.Windows.Forms.RichTextBox test2_dira_ll;
        private System.Windows.Forms.RichTextBox test1_dira_ll;
        private System.Windows.Forms.RichTextBox test6_dirb_result;
        private System.Windows.Forms.RichTextBox test5_dirb_result;
        private System.Windows.Forms.RichTextBox test4_dirb_result;
        private System.Windows.Forms.RichTextBox test3_dirb_result;
        private System.Windows.Forms.RichTextBox test2_dirb_result;
        private System.Windows.Forms.RichTextBox test1_dirb_result;
        private System.Windows.Forms.RichTextBox test6_dirb_ul;
        private System.Windows.Forms.RichTextBox test5_dirb_ul;
        private System.Windows.Forms.RichTextBox test4_dirb_ul;
        private System.Windows.Forms.RichTextBox test3_dirb_ul;
        private System.Windows.Forms.RichTextBox test2_dirb_ul;
        private System.Windows.Forms.RichTextBox test1_dirb_ul;
        private System.Windows.Forms.RichTextBox test6_dirb_ll;
        private System.Windows.Forms.RichTextBox test5_dirb_ll;
        private System.Windows.Forms.RichTextBox test4_dirb_ll;
        private System.Windows.Forms.RichTextBox test3_dirb_ll;
        private System.Windows.Forms.RichTextBox test2_dirb_ll;
        private System.Windows.Forms.RichTextBox test1_dirb_ll;
        private System.Windows.Forms.RichTextBox test6_drven_result;
        private System.Windows.Forms.RichTextBox test5_drven_result;
        private System.Windows.Forms.RichTextBox test4_drven_result;
        private System.Windows.Forms.RichTextBox test3_drven_result;
        private System.Windows.Forms.RichTextBox test2_drven_result;
        private System.Windows.Forms.RichTextBox test1_drven_result;
        private System.Windows.Forms.RichTextBox test6_drven_ul;
        private System.Windows.Forms.RichTextBox test5_drven_ul;
        private System.Windows.Forms.RichTextBox test4_drven_ul;
        private System.Windows.Forms.RichTextBox test3_drven_ul;
        private System.Windows.Forms.RichTextBox test2_drven_ul;
        private System.Windows.Forms.RichTextBox test1_drven_ul;
        private System.Windows.Forms.RichTextBox test6_drven_ll;
        private System.Windows.Forms.RichTextBox test5_drven_ll;
        private System.Windows.Forms.RichTextBox test4_drven_ll;
        private System.Windows.Forms.RichTextBox test3_drven_ll;
        private System.Windows.Forms.RichTextBox test2_drven_ll;
        private System.Windows.Forms.RichTextBox test1_drven_ll;
        private System.Windows.Forms.RichTextBox test1_led_target;
        private System.Windows.Forms.RichTextBox test2_led_target;
        private System.Windows.Forms.RichTextBox test2_led_result;
        private System.Windows.Forms.RichTextBox test3_led_target;
        private System.Windows.Forms.RichTextBox test3_led_result;
        private System.Windows.Forms.RichTextBox test4_led_target;
        private System.Windows.Forms.RichTextBox test4_led_result;
        private System.Windows.Forms.RichTextBox test5_led_target;
        private System.Windows.Forms.RichTextBox test5_led_result;
        private System.Windows.Forms.RichTextBox test6_led_target;
        private System.Windows.Forms.RichTextBox test6_led_result;
        private System.Windows.Forms.RichTextBox test1_result;
        private System.Windows.Forms.RichTextBox test2_result;
        private System.Windows.Forms.RichTextBox test3_result;
        private System.Windows.Forms.RichTextBox test4_result;
        private System.Windows.Forms.RichTextBox test5_result;
        private System.Windows.Forms.RichTextBox test6_result;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox test7_sv3_result;
        private System.Windows.Forms.RichTextBox test7_sv3_ul;
        private System.Windows.Forms.RichTextBox test7_sv3_ll;
        private System.Windows.Forms.RichTextBox test7_sv1_result;
        private System.Windows.Forms.RichTextBox test7_sv1_ul;
        private System.Windows.Forms.RichTextBox test7_sv1_ll;
        private System.Windows.Forms.RichTextBox richTextBox143;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox test7_result;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox lvdt_result;
        private System.IO.Ports.SerialPort serialPortMilliohmmeter;
        private System.IO.Ports.SerialPort serialPortTemperatureSensor;
        private System.Windows.Forms.RichTextBox sys_ready;
        private System.Windows.Forms.RichTextBox meastime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox debugit;
        private System.Windows.Forms.PictureBox LedVideo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox LedPicture;
        private System.Windows.Forms.Button Up;
        private System.Windows.Forms.Button Down;
        private System.Windows.Forms.Button Right;
        private System.Windows.Forms.Button Left;
        private System.Windows.Forms.RichTextBox Saturation;
        private System.Windows.Forms.RichTextBox Brightness;
        private System.Windows.Forms.RichTextBox Hue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.RichTextBox test6_sv2_result;
        private System.Windows.Forms.RichTextBox test5_sv2_result;
        private System.Windows.Forms.RichTextBox test4_sv2_result;
        private System.Windows.Forms.RichTextBox test3_sv2_result;
        private System.Windows.Forms.RichTextBox test2_sv2_result;
        private System.Windows.Forms.RichTextBox test1_sv2_result;
        private System.Windows.Forms.RichTextBox test6_sv4_result;
        private System.Windows.Forms.RichTextBox test5_sv4_result;
        private System.Windows.Forms.RichTextBox test4_sv4_result;
        private System.Windows.Forms.RichTextBox test3_sv4_result;
        private System.Windows.Forms.RichTextBox test2_sv4_result;
        private System.Windows.Forms.RichTextBox test1_sv4_result;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pVEOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem P12401100;
        private System.Windows.Forms.ToolStripMenuItem P12401110;
        private System.Windows.Forms.ToolStripMenuItem P12401090;
        private System.Windows.Forms.ToolStripMenuItem pVEDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem P12401020;
        private System.Windows.Forms.ToolStripMenuItem P12401010;
        private System.Windows.Forms.RichTextBox richTextBox9;
        private System.Windows.Forms.RichTextBox test8_sv1_ll;
        private System.Windows.Forms.RichTextBox test8_sv2_result;
        private System.Windows.Forms.RichTextBox test8_sv1_result;
        private System.Windows.Forms.RichTextBox test8_sv1_ul;
        private System.Windows.Forms.RichTextBox test8_sv3_ll;
        private System.Windows.Forms.RichTextBox test8_sv3_result;
        private System.Windows.Forms.RichTextBox test8_sv4_result;
        private System.Windows.Forms.RichTextBox test8_sv3_ul;
        private System.Windows.Forms.RichTextBox test8_led_result;
        private System.Windows.Forms.RichTextBox test8_led_target;
        private System.Windows.Forms.RichTextBox test8_spool_ll;
        private System.Windows.Forms.RichTextBox test8_spool_result;
        private System.Windows.Forms.RichTextBox test8_spool_ul;
        private System.Windows.Forms.RichTextBox test8_dira_ll;
        private System.Windows.Forms.RichTextBox test8_dira_result;
        private System.Windows.Forms.RichTextBox test8_dira_ul;
        private System.Windows.Forms.RichTextBox test8_dirb_ll;
        private System.Windows.Forms.RichTextBox test8_dirb_result;
        private System.Windows.Forms.RichTextBox test8_dirb_ul;
        private System.Windows.Forms.RichTextBox test8_drven_ll;
        private System.Windows.Forms.RichTextBox test8_drven_result;
        private System.Windows.Forms.RichTextBox test8_drven_ul;
        private System.Windows.Forms.RichTextBox test8_result;
        private System.Windows.Forms.ToolStripMenuItem P1240099;
        private System.Windows.Forms.ToolStripMenuItem P1240090;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox SNInput;
        private System.Windows.Forms.ToolStripMenuItem pVECToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem P1240113;
        private System.Windows.Forms.ToolStripMenuItem P1240112;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox test0_sv4_result;
        private System.Windows.Forms.RichTextBox test0_sv2_result;
        private System.Windows.Forms.RichTextBox test0_result;
        private System.Windows.Forms.RichTextBox test0_led_target;
        private System.Windows.Forms.RichTextBox test0_drven_result;
        private System.Windows.Forms.RichTextBox test0_drven_ul;
        private System.Windows.Forms.RichTextBox test0_drven_ll;
        private System.Windows.Forms.RichTextBox test0_dirb_result;
        private System.Windows.Forms.RichTextBox test0_dirb_ul;
        private System.Windows.Forms.RichTextBox test0_dirb_ll;
        private System.Windows.Forms.RichTextBox test0_dira_result;
        private System.Windows.Forms.RichTextBox test0_dira_ul;
        private System.Windows.Forms.RichTextBox test0_dira_ll;
        private System.Windows.Forms.RichTextBox test0_spool_result;
        private System.Windows.Forms.RichTextBox test0_spool_ul;
        private System.Windows.Forms.RichTextBox test0_spool_ll;
        private System.Windows.Forms.RichTextBox test0_sv3_result;
        private System.Windows.Forms.RichTextBox test0_sv3_ul;
        private System.Windows.Forms.RichTextBox test0_sv3_ll;
        private System.Windows.Forms.RichTextBox test0_sv1_result;
        private System.Windows.Forms.RichTextBox test0_sv1_ul;
        private System.Windows.Forms.RichTextBox test0_sv1_ll;
        private System.Windows.Forms.RichTextBox test0_led_result;
        private System.Windows.Forms.RichTextBox test_name0;
    }
}

