namespace ProductivityApp
{
    partial class TaskEditorForm
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
            txtTitle = new TextBox();
            listBoxSubtasks = new ListBox();
            btnAddSub = new Button();
            btnRemoveSub = new Button();
            btnToggleDone = new Button();
            btnSave = new Button();
            lbltxtTitle = new Label();
            lblSubtasks = new Label();
            txtSubtaskTitle = new TextBox();
            lblSubtaskTitle = new Label();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(72, 79);
            txtTitle.Margin = new Padding(3, 4, 3, 4);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(305, 27);
            txtTitle.TabIndex = 0;
            // 
            // listBoxSubtasks
            // 
            listBoxSubtasks.FormattingEnabled = true;
            listBoxSubtasks.Location = new Point(72, 287);
            listBoxSubtasks.Margin = new Padding(3, 4, 3, 4);
            listBoxSubtasks.Name = "listBoxSubtasks";
            listBoxSubtasks.Size = new Size(305, 184);
            listBoxSubtasks.TabIndex = 1;
            // 
            // btnAddSub
            // 
            btnAddSub.Location = new Point(184, 189);
            btnAddSub.Margin = new Padding(3, 4, 3, 4);
            btnAddSub.Name = "btnAddSub";
            btnAddSub.Size = new Size(86, 31);
            btnAddSub.TabIndex = 2;
            btnAddSub.Text = "Add";
            btnAddSub.UseVisualStyleBackColor = true;
            btnAddSub.Click += btnAddSub_Click;
            // 
            // btnRemoveSub
            // 
            btnRemoveSub.Location = new Point(72, 480);
            btnRemoveSub.Margin = new Padding(3, 4, 3, 4);
            btnRemoveSub.Name = "btnRemoveSub";
            btnRemoveSub.Size = new Size(86, 31);
            btnRemoveSub.TabIndex = 3;
            btnRemoveSub.Text = "Remove";
            btnRemoveSub.UseVisualStyleBackColor = true;
            btnRemoveSub.Click += btnRemoveSub_Click;
            // 
            // btnToggleDone
            // 
            btnToggleDone.Location = new Point(257, 480);
            btnToggleDone.Margin = new Padding(3, 4, 3, 4);
            btnToggleDone.Name = "btnToggleDone";
            btnToggleDone.Size = new Size(120, 31);
            btnToggleDone.TabIndex = 4;
            btnToggleDone.Text = "Finish Subtask";
            btnToggleDone.UseVisualStyleBackColor = true;
            btnToggleDone.Click += btnToggleDone_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(119, 567);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(213, 31);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lbltxtTitle
            // 
            lbltxtTitle.AutoSize = true;
            lbltxtTitle.Location = new Point(72, 55);
            lbltxtTitle.Name = "lbltxtTitle";
            lbltxtTitle.Size = new Size(83, 20);
            lbltxtTitle.TabIndex = 6;
            lbltxtTitle.Text = "Task Name:";
            // 
            // lblSubtasks
            // 
            lblSubtasks.AutoSize = true;
            lblSubtasks.Location = new Point(72, 263);
            lblSubtasks.Name = "lblSubtasks";
            lblSubtasks.Size = new Size(73, 20);
            lblSubtasks.TabIndex = 7;
            lblSubtasks.Text = "Subtasks: ";
            // 
            // txtSubtaskTitle
            // 
            txtSubtaskTitle.Location = new Point(72, 151);
            txtSubtaskTitle.Margin = new Padding(3, 4, 3, 4);
            txtSubtaskTitle.Name = "txtSubtaskTitle";
            txtSubtaskTitle.Size = new Size(305, 27);
            txtSubtaskTitle.TabIndex = 8;
            // 
            // lblSubtaskTitle
            // 
            lblSubtaskTitle.AutoSize = true;
            lblSubtaskTitle.Location = new Point(72, 127);
            lblSubtaskTitle.Name = "lblSubtaskTitle";
            lblSubtaskTitle.Size = new Size(93, 20);
            lblSubtaskTitle.TabIndex = 9;
            lblSubtaskTitle.Text = "Subtask Title";
            // 
            // TaskEditorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 661);
            Controls.Add(lblSubtaskTitle);
            Controls.Add(txtSubtaskTitle);
            Controls.Add(lblSubtasks);
            Controls.Add(lbltxtTitle);
            Controls.Add(btnSave);
            Controls.Add(btnToggleDone);
            Controls.Add(btnRemoveSub);
            Controls.Add(btnAddSub);
            Controls.Add(listBoxSubtasks);
            Controls.Add(txtTitle);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TaskEditorForm";
            Text = "TaskEditorForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private ListBox listBoxSubtasks;
        private Button btnAddSub;
        private Button btnRemoveSub;
        private Button btnToggleDone;
        private Button btnSave;
        private Label lbltxtTitle;
        private Label lblSubtasks;
        private TextBox txtSubtaskTitle;
        private Label lblSubtaskTitle;
    }
}