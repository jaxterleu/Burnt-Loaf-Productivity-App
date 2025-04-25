using System.Media;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using System;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

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

        public ProductivityApp()
        {
            InitializeComponent();
            InitTimer();
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

        private void ProductivityApp_Load(object sender, EventArgs e)
        {
            //Setting up the panels
            pnlTaskList.Location = new Point(339, 6);
            pnlChoose.Location = new Point(339, 6);
            pnlChoose.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlTaskList.Visible = false;
            pnlChoose.Visible = true;
            lblMainSub.Text = "Which would you like to add?";

            //AddEditDelete 0 = Add
            AddEditDelete = 0;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            pnlTaskList.Visible = false;
            pnlChoose.Visible = true;
            lblMainSub.Text = "Which would you like to edit?";

            //AddEditDelete 1 = Edit
            AddEditDelete = 1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            pnlTaskList.Visible = false;
            pnlChoose.Visible = true;
            lblMainSub.Text = "Which would you like to remove?";

            //AddEditDelete 2 = Delete
            AddEditDelete = 2;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            AddEditDelete = 3;

            //Add getting the task list here

            //Change text
            lblCreateLabel.Text = "Which task would you like to remove from the finished list?";
            lblCreateCbx.Text = "Select task to Delete:";
            btnCreateDo.Text = "Delete";

            //Change the visible functions
            lblCreateCbx.Visible = true;
            cbxCreate.Visible = true;
            lblTaskName.Visible = false;
            tbxTaskName.Visible = false;

            //fix the positioning
            lblCreateLabel.Location = new Point(101, 54);
            lblCreateCbx.Location = new Point(36, 81);
            cbxCreate.Location = new Point(188, 78);
            btnCreateDo.Location = new Point(188, 115);
            btnCreateCan.Location = new Point(365, 115);

            pnlTaskCreate.Visible = true;
            pnlTaskList.Visible = false;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {

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
    }
}
