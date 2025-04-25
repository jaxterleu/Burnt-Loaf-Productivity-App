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

        }

        private void btnFinish_Click(object sender, EventArgs e)
        {

        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            //MainSub 0 = Main
            MainSub = 0;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            //MainSub 1 = Sub
            MainSub = 1;
        }

        private void btnCanChoose_Click(object sender, EventArgs e)
        {
            pnlTaskList.Visible = true;
            pnlChoose.Visible = false;
        }
    }
}
