using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProductivityApp.ProductivityApp;

namespace ProductivityApp
{
    public partial class TaskEditorForm : Form
    {
        private TaskItem task;
        public TaskEditorForm(TaskItem task)
        {
            InitializeComponent();
            this.task = task;
            txtTitle.Text = task.Title;
            UpdateSubtaskList();
        }
        private void UpdateSubtaskList()
        {
            listBoxSubtasks.Items.Clear();
            foreach (var sub in task.Subtasks)
                listBoxSubtasks.Items.Add(sub);
        }

        private void btnAddSub_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSubtaskTitle.Text)) {
                var sub = new Subtask { Title = txtSubtaskTitle.Text.Trim() };
                task.Subtasks.Add(sub);
                txtSubtaskTitle.Clear();
                UpdateSubtaskList();
            }
            else
            {
                MessageBox.Show("Subtask Title cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnRemoveSub_Click(object sender, EventArgs e)
        {
            if (listBoxSubtasks.SelectedItem is Subtask sub)
            {
                task.Subtasks.Remove(sub);
                UpdateSubtaskList();
            }
            else
            {
                MessageBox.Show("Please select a Subtask.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnToggleDone_Click(object sender, EventArgs e)
        {
            if (listBoxSubtasks.SelectedItem is Subtask sub)
            {
                sub.IsDone = !sub.IsDone;
                UpdateSubtaskList();
            }
            else
            {
                MessageBox.Show("Please select a Subtask.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                task.Title = txtTitle.Text.Trim();
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Task title cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
