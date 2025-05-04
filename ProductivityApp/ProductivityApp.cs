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
        //int AddEditDelete = 0;
        //int MainSub = 0;
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
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (listBoxTasks.SelectedItem is TaskItem selectedTask)
            {
                var dialog = new TaskEditorForm(selectedTask);
                if (dialog.ShowDialog() == DialogResult.OK)
                    UpdateTaskListDisplay();
            }
            else
            {
                MessageBox.Show("Please select a Task.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (listBoxTasks.SelectedItem is TaskItem selectedTask)
            {
                taskList.Remove(selectedTask);
                UpdateTaskListDisplay();
            }
            else
            {
                MessageBox.Show("Please select a Task.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            if (listBoxFinished.SelectedItem is TaskItem selectedTask)
            {
                finishedList.Remove(selectedTask);
                UpdateFinishedListDisplay();
            }
            else
            {
                MessageBox.Show("Please select a Task.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
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
            else
            {
                MessageBox.Show("Please select a subtask to finish.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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
