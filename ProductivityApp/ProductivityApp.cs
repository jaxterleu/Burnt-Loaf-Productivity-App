using System.Media;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using System;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;
using System.Threading.Tasks;

namespace ProductivityApp
{
    public partial class ProductivityApp : Form
    {
        //Timer Stuff
        private Timer? timer;
        private TimeSpan timeLeft;
        private int sessionCount = 0;
        private bool isWorkSession = true;

        //Task List Stuff
        int AddEditDelete = 0;
        int MainSub = 0;
        private List<TaskItem> taskList = new();
        private List<TaskItem> finishedList = new();

        //---------------------------------------------------------------------------TIMER LOGIC
        public ProductivityApp()
        {
            InitializeComponent();
            InitTimer();
            UpdateTaskListDisplay();
            UpdateFinishedListDisplay();
            listBoxTasks.SelectedIndexChanged += listBoxTasks_SelectedIndexChanged;
        }
        private void InitTimer()
        {
            timer = new Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += Timer_Tick;
        }
        private void Timer_Tick(object? sender, EventArgs e)
        {

            if (timeLeft.TotalSeconds > 0)
            {
                timeLeft = timeLeft.Subtract(TimeSpan.FromSeconds(1));
                lblTime.Text = timeLeft.ToString("mm\\:ss");
            }
            else
            {
                timer.Stop();
                SystemSounds.Exclamation.Play();

                if (isWorkSession)
                {
                    sessionCount++;
                    lblSessions.Text = $"Sessions: {sessionCount}";

                    if (sessionCount % (int)numCycles.Value == 0)
                    {
                        timeLeft = TimeSpan.FromMinutes((double)numLongBreak.Value);
                        lblStatus.Text = "Long Break";
                    }
                    else
                    {
                        timeLeft = TimeSpan.FromMinutes((double)numShortBreak.Value);
                        lblStatus.Text = "Short Break";
                    }

                    isWorkSession = false;
                }
                else
                {
                    timeLeft = TimeSpan.FromMinutes((double)numWork.Value);
                    isWorkSession = true;
                    lblStatus.Text = "Work";
                }
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!timer.Enabled)
            {
                if (timeLeft.TotalSeconds == 0)
                {
                    timeLeft = TimeSpan.FromMinutes((double)numWork.Value);
                    isWorkSession = true;
                    lblStatus.Text = "Work";
                }
                timer.Start();
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            timer.Stop();
            timeLeft = TimeSpan.Zero;
            lblTime.Text = "00:00";
            lblStatus.Text = "Idle";
            sessionCount = 0;
            lblSessions.Text = "Sessions: 0";
        }

        //------------------------------------------------------------------------------------LOAD

        private void ProductivityApp_Load(object sender, EventArgs e)
        {
            //Setting up the panels
            pnlTaskList.Location = new Point(339, 6);
            pnlChoose.Location = new Point(339, 6);
            pnlChoose.Visible = false;
            pnlTaskCreate.Location = new Point(339, 6);
            pnlTaskCreate.Visible = false;
        }

        //-------------------------------------------------------------------------------------BASIC FORM

        private void btnAdd_Click(object sender, EventArgs e)
        {

            var task = new TaskItem();
            var dialog = new TaskEditorForm(task);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                taskList.Add(task);
                UpdateTaskListDisplay();
            }
            AddEditDelete = 0;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (listBoxTasks.SelectedItem is TaskItem selectedTask)
            {
                var dialog = new TaskEditorForm(selectedTask);
                if (dialog.ShowDialog() == DialogResult.OK)
                    UpdateTaskListDisplay();
            }

            AddEditDelete = 1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (listBoxTasks.SelectedItem is TaskItem selectedTask)
            {
                taskList.Remove(selectedTask);
                UpdateTaskListDisplay();
            }

            AddEditDelete = 2;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            AddEditDelete = 3;

            if (listBoxFinished.SelectedItem is TaskItem selectedTask)
            {
                finishedList.Remove(selectedTask);
                UpdateFinishedListDisplay();
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedItem is TaskItem selectedTask)
            {
                taskList.Remove(selectedTask);
                finishedList.Add(selectedTask);
                UpdateTaskListDisplay();
                UpdateFinishedListDisplay();
            }
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            //MainSub 0 = Main
            MainSub = 0;

            //Add main task list here

            //Panel Editing Based on function
            if (AddEditDelete == 0)
            {
                //Change text
                lblCreateLabel.Text = "Add a main task.";
                lblTaskName.Text = "Task name:";
                tbxTaskName.Text = "";
                btnCreateDo.Text = "Add";

                //Change the visible functions
                lblCreateCbx.Visible = false;
                cbxCreate.Visible = false;
                lblTaskName.Visible = true;
                tbxTaskName.Visible = true;

                //fix the positioning
                lblCreateLabel.Location = new Point(242, 54);
                lblTaskName.Location = new Point(99, 81);
                tbxTaskName.Location = new Point(188, 78);
                btnCreateDo.Location = new Point(188, 115);
                btnCreateCan.Location = new Point(365, 115);
            }
            if (AddEditDelete == 1)
            {
                //Change text
                lblCreateLabel.Text = "Which main task would you like to edit?";
                lblCreateCbx.Text = "Select task to edit:";
                lblTaskName.Text = "New Task Name:";
                tbxTaskName.Text = "";
                btnCreateDo.Text = "Edit";

                //Change the visible functions
                lblCreateCbx.Visible = true;
                cbxCreate.Visible = true;
                lblTaskName.Visible = true;
                tbxTaskName.Visible = true;

                //fix the positioning
                lblCreateLabel.Location = new Point(207, 54);
                lblCreateCbx.Location = new Point(52, 81);
                cbxCreate.Location = new Point(188, 78);
                lblTaskName.Location = new Point(65, 118);
                tbxTaskName.Location = new Point(188, 115);
                btnCreateDo.Location = new Point(188, 152);
                btnCreateCan.Location = new Point(365, 152);
            }
            if (AddEditDelete == 2)
            {
                //Change text
                lblCreateLabel.Text = "Which main task would you like to delete";
                lblCreateCbx.Text = "Select task to delete:";
                btnCreateDo.Text = "Delete";

                //Change the visible functions
                lblCreateCbx.Visible = true;
                cbxCreate.Visible = true;
                lblTaskName.Visible = false;
                tbxTaskName.Visible = false;

                //fix the positioning
                lblCreateLabel.Location = new Point(200, 54);
                lblCreateCbx.Location = new Point(36, 81);
                cbxCreate.Location = new Point(188, 78);
                btnCreateDo.Location = new Point(188, 115);
                btnCreateCan.Location = new Point(365, 115);
            }
            //Visibility
            pnlTaskCreate.Visible = true;
            pnlChoose.Visible = false;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            //MainSub 1 = Sub
            MainSub = 1;

            //Add Main Task List here

            //Panel Editing Based on function
            if (AddEditDelete == 0)
            {
                //Change text
                lblCreateLabel.Text = "Add a sub task.";
                lblCreateCbx.Text = "Select the main task:";
                lblTaskName.Text = "Sub task name:";
                tbxTaskName.Text = "";
                btnCreateDo.Text = "Add";

                //Change the visible functions
                lblCreateCbx.Visible = true;
                cbxCreate.Visible = true;
                lblTaskName.Visible = true;
                tbxTaskName.Visible = true;

                //fix the positioning
                lblCreateLabel.Location = new Point(242, 54);
                lblCreateCbx.Location = new Point(38, 81);
                cbxCreate.Location = new Point(188, 78);
                lblTaskName.Location = new Point(65, 118);
                tbxTaskName.Location = new Point(188, 115);
                btnCreateDo.Location = new Point(188, 152);
                btnCreateCan.Location = new Point(365, 152);
            }
            if (AddEditDelete == 1)
            {
                //Change text
                lblCreateLabel.Text = "Which main task is the task you want to edit part of?";
                lblCreateCbx.Text = "Select the main task:";
                lblTaskName.Text = "New Task Name:";
                tbxTaskName.Text = "";
                btnCreateDo.Text = "Edit";

                //Change the visible functions
                lblCreateCbx.Visible = true;
                cbxCreate.Visible = true;
                lblTaskName.Visible = false;
                tbxTaskName.Visible = false;

                //fix the positioning
                lblCreateLabel.Location = new Point(145, 54);
                lblCreateCbx.Location = new Point(38, 81);
                cbxCreate.Location = new Point(188, 78);
                btnCreateDo.Location = new Point(188, 115);
                btnCreateCan.Location = new Point(365, 115);
            }
            if (AddEditDelete == 2)
            {
                //Change text
                lblCreateLabel.Text = "Which main task would you like to delete";
                lblCreateCbx.Text = "Select the main task:";
                btnCreateDo.Text = "Delete";

                //Change the visible functions
                lblCreateCbx.Visible = true;
                cbxCreate.Visible = true;
                lblTaskName.Visible = false;
                tbxTaskName.Visible = false;

                //fix the positioning
                lblCreateLabel.Location = new Point(200, 54);
                lblCreateCbx.Location = new Point(38, 81);
                cbxCreate.Location = new Point(188, 78);
                btnCreateDo.Location = new Point(188, 115);
                btnCreateCan.Location = new Point(365, 115);
            }

            //Visibility
            pnlTaskCreate.Visible = true;
            pnlChoose.Visible = false;
        }

        private void btnCanChoose_Click(object sender, EventArgs e)
        {
            pnlTaskList.Visible = true;
            pnlChoose.Visible = false;
        }

        private void btnCreateDo_Click(object sender, EventArgs e)
        {
            //If the entry is editing or deleting the subtask
            if (AddEditDelete == 1 && MainSub == 1)
            {
                //MainSub 2 = Editing or Deleting Sub
                MainSub = 2;

                //Change text
                lblCreateLabel.Text = "Which sub task would you like to edit?";
                lblCreateCbx.Text = "Select task to edit:";
                lblTaskName.Text = "New Task Name:";
                tbxTaskName.Text = "";
                btnCreateDo.Text = "Edit";

                //Change the visible functions
                lblCreateCbx.Visible = true;
                cbxCreate.Visible = true;
                lblTaskName.Visible = true;
                tbxTaskName.Visible = true;

                //fix the positioning
                lblCreateLabel.Location = new Point(207, 54);
                lblCreateCbx.Location = new Point(52, 81);
                cbxCreate.Location = new Point(188, 78);
                lblTaskName.Location = new Point(65, 118);
                tbxTaskName.Location = new Point(188, 115);
                btnCreateDo.Location = new Point(188, 152);
                btnCreateCan.Location = new Point(365, 152);

            }
            if (AddEditDelete == 2 && MainSub == 1)
            {
                //MainSub 2 = Editing or Deleting Sub
                MainSub = 2;

                //Change text
                lblCreateLabel.Text = "Which main task would you like to delete";
                lblCreateCbx.Text = "Select task to delete:";
                btnCreateDo.Text = "Delete";

                //Change the visible functions
                lblCreateCbx.Visible = true;
                cbxCreate.Visible = true;
                lblTaskName.Visible = false;
                tbxTaskName.Visible = false;

                //fix the positioning
                lblCreateLabel.Location = new Point(200, 54);
                lblCreateCbx.Location = new Point(36, 81);
                cbxCreate.Location = new Point(188, 78);
                btnCreateDo.Location = new Point(188, 115);
                btnCreateCan.Location = new Point(365, 115);
            }

            //Add the adding code here
            if (AddEditDelete == 0)
            {
                if (MainSub == 0)
                {
                    //Add entering stuff into the list here

                }
                if (MainSub == 1)
                {
                    //Add entering stuff into the list here
                }
            }
            //Add the editing code here
            if (AddEditDelete == 1)
            {
                if (MainSub == 0)
                {
                    //Add editing stuff in the list here

                }
                if (MainSub == 2)
                {
                    //Add editing stuff in the list here
                }
            }
            //Add the deleting code here
            if (AddEditDelete == 2)
            {
                if (MainSub == 0)
                {
                    //Add removing stuff from the list here

                }
                if (MainSub == 2)
                {
                    //Add removing stuff from the list here
                }
            }
            //Add removing stuff from the finished list
            if (AddEditDelete == 3)
            {
                //Add removing stuff from the list here
            }
        }

        private void btnCreateCan_Click(object sender, EventArgs e)
        {
            pnlTaskCreate.Visible = false;
            pnlTaskList.Visible = true;
        }

        //------------------------------------------------------------------------------------------------TASK LOGIC
        public class Subtask
        {
            public string Title { get; set; }
            public bool IsDone { get; set; }
            public override string ToString() => (IsDone ? "[x] " : "[ ] ") + Title;
        }

        public class TaskItem
        {
            public string Title { get; set; }
            public List<Subtask> Subtasks { get; set; } = new List<Subtask>();
            public override string ToString() => Title;
        }
        private void listBoxTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxSubtasks.Items.Clear();

            if (listBoxTasks.SelectedItem is TaskItem selectedTask)
            {
                foreach (var sub in selectedTask.Subtasks)
                    listBoxSubtasks.Items.Add(sub);
            }
        }
        private void UpdateTaskListDisplay()
        {
            listBoxTasks.Items.Clear();
            foreach (var task in taskList)
                listBoxTasks.Items.Add(task);
            listBoxSubtasks.Items.Clear(); // Reset subtasks if no task is selected
        }
        private void UpdateFinishedListDisplay()
        {
            listBoxFinished.Items.Clear();
            foreach (var task in finishedList)
                listBoxFinished.Items.Add(task);
            listBoxSubtasks.Items.Clear(); // Reset subtasks if no task is selected
        }
        private void UpdateSubtaskList()
        {
            if (listBoxTasks.SelectedItem is TaskItem selectedTask)
            {
                listBoxSubtasks.Items.Clear();
                foreach (var sub in selectedTask.Subtasks)
                    listBoxSubtasks.Items.Add(sub);
            }
        }

        private void btnToggleDone_Click_1(object sender, EventArgs e)
        {
            if (listBoxSubtasks.SelectedItem is Subtask sub)
            {
                sub.IsDone = !sub.IsDone;
                UpdateSubtaskList();
            }
        }

        private void btnClearFinished_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to clear all finished tasks?",
                                  "Confirm Clear",
                                  MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                listBoxFinished.Items.Clear();
            }
        }
    }
}
