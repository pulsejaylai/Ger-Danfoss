namespace SauerDanfoss
{
    partial class SN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sninput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sninput
            // 
            this.sninput.Location = new System.Drawing.Point(186, 43);
            this.sninput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sninput.Name = "sninput";
            this.sninput.Size = new System.Drawing.Size(244, 26);
            this.sninput.TabIndex = 0;
            this.sninput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sninput_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 115);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 170);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sninput);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SN";
            this.Text = "SN";
            this.Load += new System.EventHandler(this.SN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sninput;
        private System.Windows.Forms.Button button1;
    }
}