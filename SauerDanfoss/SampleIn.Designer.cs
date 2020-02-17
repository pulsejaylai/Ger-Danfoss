namespace SauerDanfoss
{
    partial class SampleIn
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
            this.Sample = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Sample
            // 
            this.Sample.Location = new System.Drawing.Point(203, 30);
            this.Sample.Name = "Sample";
            this.Sample.Size = new System.Drawing.Size(476, 26);
            this.Sample.TabIndex = 0;
            this.Sample.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Sample_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(361, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SampleIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 159);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Sample);
            this.Name = "SampleIn";
            this.Text = "SampleIn";
            this.Load += new System.EventHandler(this.SampleIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Sample;
        private System.Windows.Forms.Button button1;
    }
}