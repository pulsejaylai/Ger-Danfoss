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
    public partial class SN : Form
    {
        public delegate void TransfDelegate(String value);
        public delegate void TransintfDelegate(int valuet);  
        
        public SN()
        {
            InitializeComponent();
        }

        private void SN_Load(object sender, EventArgs e)
        {
            sninput.Focus();
        }
        public event TransfDelegate TransfEvent;
        public event TransintfDelegate TransintfEvent;

        private void button1_Click(object sender, EventArgs e)
        {
            int length;           
            length = sninput.Text.Length;
            TransfEvent(sninput.Text);
            TransintfEvent(length);
            this.Close();
        }

        private void sninput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                //如果还有keypress事件，不让此快捷键触发其事件可加一句代码
                //   MessageBox.Show("765");
                e.Handled = true;   //将Handled设置为true，指示已经处理过KeyPress事件
                button1.PerformClick();////执行单击confirm1的动作

            }
        }









    }
}
