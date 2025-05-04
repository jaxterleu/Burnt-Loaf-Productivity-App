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
            numCycles = new NumericUpDown();
            lblCycles = new Label();
            lblTaskList = new Label();
            lblFinTasks = new Label();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnRemove = new Button();
            btnFinish = new Button();
            pnlTaskList = new Panel();
            btnClearFinished = new Button();
            btnToggleDone = new Button();
            listBoxSubtasks = new ListBox();
            lblSubTaskList = new Label();
            listBoxFinished = new ListBox();
            listBoxTasks = new ListBox();
            ((System.ComponentModel.ISupportInitialize)numWork).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numShortBreak).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numLongBreak).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCycles).BeginInit();
            pnlTaskList.SuspendLayout();
            SuspendLayout();
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 24F);
            lblTime.Location = new Point(52, 75);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(95, 45);
            lblTime.TabIndex = 0;
            lblTime.Text = "00:00";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(84, 120);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(26, 15);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "Idle";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSessions
            // 
            lblSessions.AutoSize = true;
            lblSessions.Location = new Point(127, 179);
            lblSessions.Name = "lblSessions";
            lblSessions.Size = new Size(63, 15);
            lblSessions.TabIndex = 2;
            lblSessions.Text = "Sessions: 0";
            lblSessions.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numWork
            // 
            numWork.Location = new Point(181, 214);
            numWork.Name = "numWork";
            numWork.Size = new Size(46, 23);
            numWork.TabIndex = 3;
            numWork.TextAlign = HorizontalAlignment.Center;
            numWork.Value = new decimal(new int[] { 25, 0, 0, 0 });
            // 
            // numShortBreak
            // 
            numShortBreak.Location = new Point(181, 243);
            numShortBreak.Name = "numShortBreak";
            numShortBreak.Size = new Size(46, 23);
            numShortBreak.TabIndex = 4;
            numShortBreak.TextAlign = HorizontalAlignment.Center;
            numShortBreak.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // numLongBreak
            // 
            numLongBreak.Location = new Point(181, 272);
            numLongBreak.Name = "numLongBreak";
            numLongBreak.Size = new Size(46, 23);
            numLongBreak.TabIndex = 5;
            numLongBreak.TextAlign = HorizontalAlignment.Center;
            numLongBreak.Value = new decimal(new int[] { 15, 0, 0, 0 });
            // 
            // lblWork
            // 
            lblWork.AutoSize = true;
            lblWork.Location = new Point(104, 216);
            lblWork.Name = "lblWork";
            lblWork.Size = new Size(35, 15);
            lblWork.TabIndex = 6;
            lblWork.Text = "Work";
            // 
            // lblShortBreak
            // 
            lblShortBreak.AutoSize = true;
            lblShortBreak.Location = new Point(103, 247);
            lblShortBreak.Name = "lblShortBreak";
            lblShortBreak.Size = new Size(67, 15);
            lblShortBreak.TabIndex = 7;
            lblShortBreak.Text = "Short Break";
            // 
            // lblLongBreak
            // 
            lblLongBreak.AutoSize = true;
            lblLongBreak.Location = new Point(103, 276);
            lblLongBreak.Name = "lblLongBreak";
            lblLongBreak.Size = new Size(66, 15);
            lblLongBreak.TabIndex = 8;
            lblLongBreak.Text = "Long Break";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(212, 67);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 9;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnPause
            // 
            btnPause.Location = new Point(212, 96);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(75, 23);
            btnPause.TabIndex = 10;
            btnPause.Text = "Pause";
            btnPause.UseVisualStyleBackColor = true;
            btnPause.Click += btnPause_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(212, 125);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 11;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // numCycles
            // 
            numCycles.Location = new Point(181, 301);
            numCycles.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numCycles.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCycles.Name = "numCycles";
            numCycles.Size = new Size(46, 23);
            numCycles.TabIndex = 12;
            numCycles.TextAlign = HorizontalAlignment.Center;
            numCycles.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblCycles
            // 
            lblCycles.AutoSize = true;
            lblCycles.Location = new Point(104, 305);
            lblCycles.Name = "lblCycles";
            lblCycles.Size = new Size(41, 15);
            lblCycles.TabIndex = 13;
            lblCycles.Text = "Cycles";
            // 
            // lblTaskList
            // 
            lblTaskList.AutoSize = true;
            lblTaskList.Location = new Point(4, 2);
            lblTaskList.Name = "lblTaskList";
            lblTaskList.Size = new Size(59, 15);
            lblTaskList.TabIndex = 14;
            lblTaskList.Text = "Tasks List:";
            // 
            // lblFinTasks
            // 
            lblFinTasks.AutoSize = true;
            lblFinTasks.Location = new Point(506, 2);
            lblFinTasks.Name = "lblFinTasks";
            lblFinTasks.Size = new Size(85, 15);
            lblFinTasks.TabIndex = 16;
            lblFinTasks.Text = "Finished Tasks:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(6, 390);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(82, 22);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Add New";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(92, 390);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(82, 22);
            btnEdit.TabIndex = 19;
            btnEdit.Text = "Edit Task";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(178, 390);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 22);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Delete Task";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(648, 390);
            btnRemove.Margin = new Padding(3, 2, 3, 2);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(102, 22);
            btnRemove.TabIndex = 22;
            btnRemove.Text = "Remove Task";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnFinish
            // 
            btnFinish.BackColor = Color.PaleGreen;
            btnFinish.Location = new Point(6, 416);
            btnFinish.Margin = new Padding(3, 2, 3, 2);
            btnFinish.Name = "btnFinish";
            btnFinish.Size = new Size(254, 22);
            btnFinish.TabIndex = 23;
            btnFinish.Text = "Finish Task";
            btnFinish.UseVisualStyleBackColor = false;
            btnFinish.Click += btnFinish_Click;
            // 
            // pnlTaskList
            // 
            pnlTaskList.Controls.Add(listBoxTasks);
            pnlTaskList.Controls.Add(btnClearFinished);
            pnlTaskList.Controls.Add(btnToggleDone);
            pnlTaskList.Controls.Add(listBoxSubtasks);
            pnlTaskList.Controls.Add(lblSubTaskList);
            pnlTaskList.Controls.Add(listBoxFinished);
            pnlTaskList.Controls.Add(btnFinish);
            pnlTaskList.Controls.Add(btnRemove);
            pnlTaskList.Controls.Add(lblFinTasks);
            pnlTaskList.Controls.Add(lblTaskList);
            pnlTaskList.Controls.Add(btnDelete);
            pnlTaskList.Controls.Add(btnEdit);
            pnlTaskList.Controls.Add(btnAdd);
            pnlTaskList.Location = new Point(307, 11);
            pnlTaskList.Margin = new Padding(3, 2, 3, 2);
            pnlTaskList.Name = "pnlTaskList";
            pnlTaskList.Size = new Size(753, 443);
            pnlTaskList.TabIndex = 25;
            // 
            // btnClearFinished
            // 
            btnClearFinished.Location = new Point(506, 415);
            btnClearFinished.Name = "btnClearFinished";
            btnClearFinished.Size = new Size(244, 23);
            btnClearFinished.TabIndex = 29;
            btnClearFinished.Text = "Clear Finished Tasks";
            btnClearFinished.UseVisualStyleBackColor = true;
            btnClearFinished.Click += btnClearFinished_Click;
            // 
            // btnToggleDone
            // 
            btnToggleDone.Location = new Point(393, 164);
            btnToggleDone.Name = "btnToggleDone";
            btnToggleDone.Size = new Size(107, 23);
            btnToggleDone.TabIndex = 28;
            btnToggleDone.Text = "Finish Subtask";
            btnToggleDone.UseVisualStyleBackColor = true;
            btnToggleDone.Click += btnToggleDone_Click_1;
            // 
            // listBoxSubtasks
            // 
            listBoxSubtasks.FormattingEnabled = true;
            listBoxSubtasks.ItemHeight = 15;
            listBoxSubtasks.Location = new Point(267, 20);
            listBoxSubtasks.Name = "listBoxSubtasks";
            listBoxSubtasks.Size = new Size(233, 139);
            listBoxSubtasks.TabIndex = 27;
            // 
            // lblSubTaskList
            // 
            lblSubTaskList.AutoSize = true;
            lblSubTaskList.Location = new Point(264, 2);
            lblSubTaskList.Name = "lblSubTaskList";
            lblSubTaskList.Size = new Size(140, 15);
            lblSubTaskList.TabIndex = 26;
            lblSubTaskList.Text = "Subtasks of Selected Task";
            // 
            // listBoxFinished
            // 
            listBoxFinished.FormattingEnabled = true;
            listBoxFinished.ItemHeight = 15;
            listBoxFinished.Location = new Point(506, 20);
            listBoxFinished.Name = "listBoxFinished";
            listBoxFinished.Size = new Size(244, 364);
            listBoxFinished.TabIndex = 25;
            // 
            // listBoxTasks
            // 
            listBoxTasks.FormattingEnabled = true;
            listBoxTasks.ItemHeight = 15;
            listBoxTasks.Location = new Point(6, 20);
            listBoxTasks.Name = "listBoxTasks";
            listBoxTasks.Size = new Size(255, 364);
            listBoxTasks.TabIndex = 30;
            // 
            // ProductivityApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 480);
            Controls.Add(pnlTaskList);
            Controls.Add(lblCycles);
            Controls.Add(numCycles);
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
            Name = "ProductivityApp";
            Text = "Form1";
            Load += ProductivityApp_Load;
            ((System.ComponentModel.ISupportInitialize)numWork).EndInit();
            ((System.ComponentModel.ISupportInitialize)numShortBreak).EndInit();
            ((System.ComponentModel.ISupportInitialize)numLongBreak).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCycles).EndInit();
            pnlTaskList.ResumeLayout(false);
            pnlTaskList.PerformLayout();
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
        private NumericUpDown numCycles;
        private Label lblCycles;
        private Label lblTaskList;
        private Label lblFinTasks;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnRemove;
        private Button btnFinish;
        private Panel pnlTaskList;
        private ListBox listBoxFinished;
        private Label lblSubTaskList;
        private ListBox listBoxSubtasks;
        private Button btnToggleDone;
        private Button btnClearFinished;
        private ListBox listBoxTasks;
    }
}
