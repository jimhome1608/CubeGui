namespace CubeGui
{
    partial class frmCubeGui
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
            this.pnlConnectedStatus = new System.Windows.Forms.Panel();
            this.lblColorInfo = new System.Windows.Forms.Label();
            this.nudRed = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudGreen = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudBlue = new System.Windows.Forms.NumericUpDown();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlConnectedStatus
            // 
            this.pnlConnectedStatus.BackColor = System.Drawing.Color.Blue;
            this.pnlConnectedStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlConnectedStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlConnectedStatus.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlConnectedStatus.Location = new System.Drawing.Point(20, 21);
            this.pnlConnectedStatus.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pnlConnectedStatus.Name = "pnlConnectedStatus";
            this.pnlConnectedStatus.Size = new System.Drawing.Size(26, 30);
            this.pnlConnectedStatus.TabIndex = 1;
            // 
            // lblColorInfo
            // 
            this.lblColorInfo.AutoSize = true;
            this.lblColorInfo.Location = new System.Drawing.Point(16, 56);
            this.lblColorInfo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblColorInfo.Name = "lblColorInfo";
            this.lblColorInfo.Size = new System.Drawing.Size(101, 23);
            this.lblColorInfo.TabIndex = 2;
            this.lblColorInfo.Text = "lblColorInfo";
            // 
            // nudRed
            // 
            this.nudRed.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudRed.Location = new System.Drawing.Point(88, 108);
            this.nudRed.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.nudRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRed.Name = "nudRed";
            this.nudRed.Size = new System.Drawing.Size(81, 30);
            this.nudRed.TabIndex = 3;
            this.nudRed.ValueChanged += new System.EventHandler(this.nudRed_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Red:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Green:";
            // 
            // nudGreen
            // 
            this.nudGreen.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudGreen.Location = new System.Drawing.Point(88, 148);
            this.nudGreen.Margin = new System.Windows.Forms.Padding(5);
            this.nudGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudGreen.Name = "nudGreen";
            this.nudGreen.Size = new System.Drawing.Size(81, 30);
            this.nudGreen.TabIndex = 5;
            this.nudGreen.ValueChanged += new System.EventHandler(this.nudGreen_valuechanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Blue:";
            // 
            // nudBlue
            // 
            this.nudBlue.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudBlue.Location = new System.Drawing.Point(88, 188);
            this.nudBlue.Margin = new System.Windows.Forms.Padding(5);
            this.nudBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudBlue.Name = "nudBlue";
            this.nudBlue.Size = new System.Drawing.Size(81, 30);
            this.nudBlue.TabIndex = 7;
            this.nudBlue.ValueChanged += new System.EventHandler(this.nudBlue_ValueChanged);
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.Location = new System.Drawing.Point(46, 21);
            this.lblConnectionStatus.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(146, 23);
            this.lblConnectionStatus.TabIndex = 9;
            this.lblConnectionStatus.Text = "ConnectionStatus";
            // 
            // frmCubeGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 750);
            this.Controls.Add(this.lblConnectionStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudBlue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudGreen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudRed);
            this.Controls.Add(this.lblColorInfo);
            this.Controls.Add(this.pnlConnectedStatus);
            this.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmCubeGui";
            this.Text = "Cube GUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCubeGui_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nudRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlConnectedStatus;
        private System.Windows.Forms.Label lblColorInfo;
        private System.Windows.Forms.NumericUpDown nudRed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudGreen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudBlue;
        private System.Windows.Forms.Label lblConnectionStatus;
    }
}

