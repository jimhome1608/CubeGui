namespace CubeGui
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnlConnectedStatus = new System.Windows.Forms.Panel();
            this.lblColorInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 20);
            this.textBox1.TabIndex = 0;
            // 
            // pnlConnectedStatus
            // 
            this.pnlConnectedStatus.BackColor = System.Drawing.Color.Blue;
            this.pnlConnectedStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlConnectedStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlConnectedStatus.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlConnectedStatus.Location = new System.Drawing.Point(12, 12);
            this.pnlConnectedStatus.Name = "pnlConnectedStatus";
            this.pnlConnectedStatus.Size = new System.Drawing.Size(55, 20);
            this.pnlConnectedStatus.TabIndex = 1;
            // 
            // lblColorInfo
            // 
            this.lblColorInfo.AutoSize = true;
            this.lblColorInfo.Location = new System.Drawing.Point(83, 63);
            this.lblColorInfo.Name = "lblColorInfo";
            this.lblColorInfo.Size = new System.Drawing.Size(35, 13);
            this.lblColorInfo.TabIndex = 2;
            this.lblColorInfo.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 424);
            this.Controls.Add(this.lblColorInfo);
            this.Controls.Add(this.pnlConnectedStatus);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel pnlConnectedStatus;
        private System.Windows.Forms.Label lblColorInfo;
    }
}

