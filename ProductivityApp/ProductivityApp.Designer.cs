namespace ProductivityApp
{
    partial class ProductivityApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTime = new Label();
            lblStatus = new Label();
            lblSessions = new Label();
            numWork = new NumericUpDown();
            numShortBreak = new NumericUpDown();
            numLongBreak = new NumericUpDown();
            lblWork = new Label();
            lblShortBreak = new Label();
            lblLongBreak = new Label();
            btnStart = new Button();
            btnPause = new Button();
            btnReset = new Button();
            ((System.ComponentModel.ISupportInitialize)numWork).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numShortBreak).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numLongBreak).BeginInit();
            SuspendLayout();
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 24F);
            lblTime.Location = new Point(68, 45);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(95, 45);
            lblTime.TabIndex = 0;
            lblTime.Text = "00:00";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(100, 90);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(26, 15);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "Idle";
            // 
            // lblSessions
            // 
            lblSessions.AutoSize = true;
            lblSessions.Location = new Point(82, 145);
            lblSessions.Name = "lblSessions";
            lblSessions.Size = new Size(63, 15);
            lblSessions.TabIndex = 2;
            lblSessions.Text = "Sessions: 0";
            // 
            // numWork
            // 
            numWork.Location = new Point(136, 180);
            numWork.Name = "numWork";
            numWork.Size = new Size(46, 23);
            numWork.TabIndex = 3;
            numWork.Value = new decimal(new int[] { 25, 0, 0, 0 });
            // 
            // numShortBreak
            // 
            numShortBreak.Location = new Point(136, 209);
            numShortBreak.Name = "numShortBreak";
            numShortBreak.Size = new Size(46, 23);
            numShortBreak.TabIndex = 4;
            numShortBreak.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // numLongBreak
            // 
            numLongBreak.Location = new Point(136, 238);
            numLongBreak.Name = "numLongBreak";
            numLongBreak.Size = new Size(46, 23);
            numLongBreak.TabIndex = 5;
            numLongBreak.Value = new decimal(new int[] { 15, 0, 0, 0 });
            // 
            // lblWork
            // 
            lblWork.AutoSize = true;
            lblWork.Location = new Point(59, 180);
            lblWork.Name = "lblWork";
            lblWork.Size = new Size(35, 15);
            lblWork.TabIndex = 6;
            lblWork.Text = "Work";
            // 
            // lblShortBreak
            // 
            lblShortBreak.AutoSize = true;
            lblShortBreak.Location = new Point(59, 211);
            lblShortBreak.Name = "lblShortBreak";
            lblShortBreak.Size = new Size(67, 15);
            lblShortBreak.TabIndex = 7;
            lblShortBreak.Text = "Short Break";
            // 
            // lblLongBreak
            // 
            lblLongBreak.AutoSize = true;
            lblLongBreak.Location = new Point(59, 240);
            lblLongBreak.Name = "lblLongBreak";
            lblLongBreak.Size = new Size(66, 15);
            lblLongBreak.TabIndex = 8;
            lblLongBreak.Text = "Long Break";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(228, 37);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 9;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnPause
            // 
            btnPause.Location = new Point(228, 66);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(75, 23);
            btnPause.TabIndex = 10;
            btnPause.Text = "Pause";
            btnPause.UseVisualStyleBackColor = true;
            btnPause.Click += btnPause_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(228, 95);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 11;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReset);
            Controls.Add(btnPause);
            Controls.Add(btnStart);
            Controls.Add(lblLongBreak);
            Controls.Add(lblShortBreak);
            Controls.Add(lblWork);
            Controls.Add(numLongBreak);
            Controls.Add(numShortBreak);
            Controls.Add(numWork);
            Controls.Add(lblSessions);
            Controls.Add(lblStatus);
            Controls.Add(lblTime);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numWork).EndInit();
            ((System.ComponentModel.ISupportInitialize)numShortBreak).EndInit();
            ((System.ComponentModel.ISupportInitialize)numLongBreak).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTime;
        private Label lblStatus;
        private Label lblSessions;
        private NumericUpDown numWork;
        private NumericUpDown numShortBreak;
        private NumericUpDown numLongBreak;
        private Label lblWork;
        private Label lblShortBreak;
        private Label lblLongBreak;
        private Button btnStart;
        private Button btnPause;
        private Button btnReset;
    }
}
