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
            clbTaskList = new CheckedListBox();
            lblFinTasks = new Label();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnRemove = new Button();
            btnFinish = new Button();
            tbxFinTasks = new TextBox();
            pnlTaskList = new Panel();
            pnlChoose = new Panel();
            btnCanChoose = new Button();
            btnSub = new Button();
            btnMain = new Button();
            lblMainSub = new Label();
            pnlTaskCreate = new Panel();
            cbxCreate = new ComboBox();
            lblCreateCbx = new Label();
            btnCreateCan = new Button();
            btnCreateDo = new Button();
            tbxTaskName = new TextBox();
            lblTaskName = new Label();
            lblCreateLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)numWork).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numShortBreak).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numLongBreak).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCycles).BeginInit();
            pnlTaskList.SuspendLayout();
            pnlChoose.SuspendLayout();
            pnlTaskCreate.SuspendLayout();
            SuspendLayout();
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 24F);
            lblTime.Location = new Point(59, 100);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(120, 54);
            lblTime.TabIndex = 0;
            lblTime.Text = "00:00";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(96, 160);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(34, 20);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "Idle";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSessions
            // 
            lblSessions.AutoSize = true;
            lblSessions.Location = new Point(145, 239);
            lblSessions.Name = "lblSessions";
            lblSessions.Size = new Size(79, 20);
            lblSessions.TabIndex = 2;
            lblSessions.Text = "Sessions: 0";
            lblSessions.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numWork
            // 
            numWork.Location = new Point(207, 285);
            numWork.Margin = new Padding(3, 4, 3, 4);
            numWork.Name = "numWork";
            numWork.Size = new Size(53, 27);
            numWork.TabIndex = 3;
            numWork.TextAlign = HorizontalAlignment.Center;
            numWork.Value = new decimal(new int[] { 25, 0, 0, 0 });
            // 
            // numShortBreak
            // 
            numShortBreak.Location = new Point(207, 324);
            numShortBreak.Margin = new Padding(3, 4, 3, 4);
            numShortBreak.Name = "numShortBreak";
            numShortBreak.Size = new Size(53, 27);
            numShortBreak.TabIndex = 4;
            numShortBreak.TextAlign = HorizontalAlignment.Center;
            numShortBreak.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // numLongBreak
            // 
            numLongBreak.Location = new Point(207, 363);
            numLongBreak.Margin = new Padding(3, 4, 3, 4);
            numLongBreak.Name = "numLongBreak";
            numLongBreak.Size = new Size(53, 27);
            numLongBreak.TabIndex = 5;
            numLongBreak.TextAlign = HorizontalAlignment.Center;
            numLongBreak.Value = new decimal(new int[] { 15, 0, 0, 0 });
            // 
            // lblWork
            // 
            lblWork.AutoSize = true;
            lblWork.Location = new Point(119, 288);
            lblWork.Name = "lblWork";
            lblWork.Size = new Size(43, 20);
            lblWork.TabIndex = 6;
            lblWork.Text = "Work";
            // 
            // lblShortBreak
            // 
            lblShortBreak.AutoSize = true;
            lblShortBreak.Location = new Point(118, 329);
            lblShortBreak.Name = "lblShortBreak";
            lblShortBreak.Size = new Size(85, 20);
            lblShortBreak.TabIndex = 7;
            lblShortBreak.Text = "Short Break";
            // 
            // lblLongBreak
            // 
            lblLongBreak.AutoSize = true;
            lblLongBreak.Location = new Point(118, 368);
            lblLongBreak.Name = "lblLongBreak";
            lblLongBreak.Size = new Size(83, 20);
            lblLongBreak.TabIndex = 8;
            lblLongBreak.Text = "Long Break";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(242, 89);
            btnStart.Margin = new Padding(3, 4, 3, 4);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(86, 31);
            btnStart.TabIndex = 9;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnPause
            // 
            btnPause.Location = new Point(242, 128);
            btnPause.Margin = new Padding(3, 4, 3, 4);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(86, 31);
            btnPause.TabIndex = 10;
            btnPause.Text = "Pause";
            btnPause.UseVisualStyleBackColor = true;
            btnPause.Click += btnPause_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(242, 167);
            btnReset.Margin = new Padding(3, 4, 3, 4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(86, 31);
            btnReset.TabIndex = 11;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // numCycles
            // 
            numCycles.Location = new Point(207, 401);
            numCycles.Margin = new Padding(3, 4, 3, 4);
            numCycles.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numCycles.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCycles.Name = "numCycles";
            numCycles.Size = new Size(53, 27);
            numCycles.TabIndex = 12;
            numCycles.TextAlign = HorizontalAlignment.Center;
            numCycles.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblCycles
            // 
            lblCycles.AutoSize = true;
            lblCycles.Location = new Point(119, 407);
            lblCycles.Name = "lblCycles";
            lblCycles.Size = new Size(50, 20);
            lblCycles.TabIndex = 13;
            lblCycles.Text = "Cycles";
            // 
            // lblTaskList
            // 
            lblTaskList.AutoSize = true;
            lblTaskList.Location = new Point(4, 3);
            lblTaskList.Name = "lblTaskList";
            lblTaskList.Size = new Size(71, 20);
            lblTaskList.TabIndex = 14;
            lblTaskList.Text = "Tasks List:";
            // 
            // clbTaskList
            // 
            clbTaskList.FormattingEnabled = true;
            clbTaskList.Location = new Point(7, 26);
            clbTaskList.Name = "clbTaskList";
            clbTaskList.Size = new Size(291, 488);
            clbTaskList.TabIndex = 15;
            // 
            // lblFinTasks
            // 
            lblFinTasks.AutoSize = true;
            lblFinTasks.Location = new Point(323, 3);
            lblFinTasks.Name = "lblFinTasks";
            lblFinTasks.Size = new Size(103, 20);
            lblFinTasks.TabIndex = 16;
            lblFinTasks.Text = "Finished Tasks:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(7, 520);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Add New";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(105, 520);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 19;
            btnEdit.Text = "Edit Task";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(204, 520);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Delete Task";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(323, 520);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(117, 29);
            btnUpdate.TabIndex = 21;
            btnUpdate.Text = "Update List";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(446, 520);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(117, 29);
            btnRemove.TabIndex = 22;
            btnRemove.Text = "Remove Task";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnFinish
            // 
            btnFinish.Location = new Point(7, 555);
            btnFinish.Name = "btnFinish";
            btnFinish.Size = new Size(556, 29);
            btnFinish.TabIndex = 23;
            btnFinish.Text = "Finish Session";
            btnFinish.UseVisualStyleBackColor = true;
            btnFinish.Click += btnFinish_Click;
            // 
            // tbxFinTasks
            // 
            tbxFinTasks.Location = new Point(323, 26);
            tbxFinTasks.Multiline = true;
            tbxFinTasks.Name = "tbxFinTasks";
            tbxFinTasks.ReadOnly = true;
            tbxFinTasks.Size = new Size(240, 488);
            tbxFinTasks.TabIndex = 24;
            // 
            // pnlTaskList
            // 
            pnlTaskList.Controls.Add(btnFinish);
            pnlTaskList.Controls.Add(tbxFinTasks);
            pnlTaskList.Controls.Add(btnRemove);
            pnlTaskList.Controls.Add(lblFinTasks);
            pnlTaskList.Controls.Add(btnUpdate);
            pnlTaskList.Controls.Add(lblTaskList);
            pnlTaskList.Controls.Add(btnDelete);
            pnlTaskList.Controls.Add(clbTaskList);
            pnlTaskList.Controls.Add(btnEdit);
            pnlTaskList.Controls.Add(btnAdd);
            pnlTaskList.Location = new Point(891, 588);
            pnlTaskList.Name = "pnlTaskList";
            pnlTaskList.Size = new Size(572, 591);
            pnlTaskList.TabIndex = 25;
            // 
            // pnlChoose
            // 
            pnlChoose.Controls.Add(btnCanChoose);
            pnlChoose.Controls.Add(btnSub);
            pnlChoose.Controls.Add(btnMain);
            pnlChoose.Controls.Add(lblMainSub);
            pnlChoose.Location = new Point(895, 536);
            pnlChoose.Name = "pnlChoose";
            pnlChoose.Size = new Size(572, 591);
            pnlChoose.TabIndex = 26;
            // 
            // btnCanChoose
            // 
            btnCanChoose.Location = new Point(258, 151);
            btnCanChoose.Name = "btnCanChoose";
            btnCanChoose.Size = new Size(94, 29);
            btnCanChoose.TabIndex = 3;
            btnCanChoose.Text = "Cancel";
            btnCanChoose.UseVisualStyleBackColor = true;
            btnCanChoose.Click += btnCanChoose_Click;
            // 
            // btnSub
            // 
            btnSub.Location = new Point(307, 116);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(94, 29);
            btnSub.TabIndex = 2;
            btnSub.Text = "Sub Task";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSub_Click;
            // 
            // btnMain
            // 
            btnMain.Location = new Point(207, 116);
            btnMain.Name = "btnMain";
            btnMain.Size = new Size(94, 29);
            btnMain.TabIndex = 1;
            btnMain.Text = "Main Task";
            btnMain.UseVisualStyleBackColor = true;
            btnMain.Click += btnMain_Click;
            // 
            // lblMainSub
            // 
            lblMainSub.AutoSize = true;
            lblMainSub.Location = new Point(206, 92);
            lblMainSub.Name = "lblMainSub";
            lblMainSub.Size = new Size(205, 20);
            lblMainSub.TabIndex = 0;
            lblMainSub.Text = "Which would you like to add?";
            lblMainSub.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlTaskCreate
            // 
            pnlTaskCreate.Controls.Add(cbxCreate);
            pnlTaskCreate.Controls.Add(lblCreateCbx);
            pnlTaskCreate.Controls.Add(btnCreateCan);
            pnlTaskCreate.Controls.Add(btnCreateDo);
            pnlTaskCreate.Controls.Add(tbxTaskName);
            pnlTaskCreate.Controls.Add(lblTaskName);
            pnlTaskCreate.Controls.Add(lblCreateLabel);
            pnlTaskCreate.Location = new Point(898, 521);
            pnlTaskCreate.Name = "pnlTaskCreate";
            pnlTaskCreate.Size = new Size(572, 591);
            pnlTaskCreate.TabIndex = 27;
            // 
            // cbxCreate
            // 
            cbxCreate.FormattingEnabled = true;
            cbxCreate.Location = new Point(188, 77);
            cbxCreate.Name = "cbxCreate";
            cbxCreate.Size = new Size(351, 28);
            cbxCreate.TabIndex = 6;
            cbxCreate.Visible = false;
            // 
            // lblCreateCbx
            // 
            lblCreateCbx.AutoSize = true;
            lblCreateCbx.Location = new Point(38, 80);
            lblCreateCbx.Name = "lblCreateCbx";
            lblCreateCbx.RightToLeft = RightToLeft.No;
            lblCreateCbx.Size = new Size(144, 20);
            lblCreateCbx.TabIndex = 5;
            lblCreateCbx.Text = "Select the main task:";
            lblCreateCbx.TextAlign = ContentAlignment.TopRight;
            lblCreateCbx.Visible = false;
            // 
            // btnCreateCan
            // 
            btnCreateCan.Location = new Point(365, 152);
            btnCreateCan.Name = "btnCreateCan";
            btnCreateCan.Size = new Size(174, 29);
            btnCreateCan.TabIndex = 4;
            btnCreateCan.Text = "Cancel";
            btnCreateCan.UseVisualStyleBackColor = true;
            btnCreateCan.Click += btnCreateCan_Click;
            // 
            // btnCreateDo
            // 
            btnCreateDo.Location = new Point(188, 152);
            btnCreateDo.Name = "btnCreateDo";
            btnCreateDo.Size = new Size(174, 29);
            btnCreateDo.TabIndex = 3;
            btnCreateDo.Text = "Add";
            btnCreateDo.UseVisualStyleBackColor = true;
            btnCreateDo.Click += btnCreateDo_Click;
            // 
            // tbxTaskName
            // 
            tbxTaskName.Location = new Point(188, 115);
            tbxTaskName.Name = "tbxTaskName";
            tbxTaskName.Size = new Size(351, 27);
            tbxTaskName.TabIndex = 2;
            // 
            // lblTaskName
            // 
            lblTaskName.AutoSize = true;
            lblTaskName.Location = new Point(65, 118);
            lblTaskName.Name = "lblTaskName";
            lblTaskName.Size = new Size(117, 20);
            lblTaskName.TabIndex = 1;
            lblTaskName.Text = "New Task Name:";
            // 
            // lblCreateLabel
            // 
            lblCreateLabel.AutoSize = true;
            lblCreateLabel.Location = new Point(101, 54);
            lblCreateLabel.Name = "lblCreateLabel";
            lblCreateLabel.Size = new Size(399, 20);
            lblCreateLabel.TabIndex = 0;
            lblCreateLabel.Text = "Which task would you like to remove from the finished list?";
            lblCreateLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // ProductivityApp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(pnlTaskCreate);
            Controls.Add(pnlChoose);
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
            Controls.Add(pnlTaskList);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProductivityApp";
            Text = "Form1";
            Load += ProductivityApp_Load;
            ((System.ComponentModel.ISupportInitialize)numWork).EndInit();
            ((System.ComponentModel.ISupportInitialize)numShortBreak).EndInit();
            ((System.ComponentModel.ISupportInitialize)numLongBreak).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCycles).EndInit();
            pnlTaskList.ResumeLayout(false);
            pnlTaskList.PerformLayout();
            pnlChoose.ResumeLayout(false);
            pnlChoose.PerformLayout();
            pnlTaskCreate.ResumeLayout(false);
            pnlTaskCreate.PerformLayout();
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
        private CheckedListBox clbTaskList;
        private Label lblFinTasks;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnRemove;
        private Button btnFinish;
        private TextBox tbxFinTasks;
        private Panel pnlTaskList;
        private Panel pnlChoose;
        private Label lblMainSub;
        private Button btnSub;
        private Button btnMain;
        private Button btnCanChoose;
        private Panel pnlTaskCreate;
        private Label lblCreateLabel;
        private Button btnCreateCan;
        private Button btnCreateDo;
        private TextBox tbxTaskName;
        private Label lblTaskName;
        private Label lblCreateCbx;
        private ComboBox cbxCreate;
    }
}
