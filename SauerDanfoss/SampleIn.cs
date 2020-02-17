using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SauerDanfoss
{
    public partial class SampleIn : Form
    {
        public delegate void TransfDelegate(String value);
        public delegate void TransintfDelegate(int valuet);
        public event TransfDelegate TransfEvent;
        public event TransintfDelegate TransintfEvent;
        public SampleIn()
        {
            InitializeComponent();
        }

        private void SampleIn_Load(object sender, EventArgs e)
        {
           Sample.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string samples;
            int slength;
            samples = Sample.Text;
            slength = samples.Length;
          //  MessageBox.Show(slength.ToString());
            TransfEvent(samples);
            TransintfEvent(slength);
            this.Close();
        }

        private void Sample_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                this.button1_Click(sender, e);
            }
        }
    }
}
