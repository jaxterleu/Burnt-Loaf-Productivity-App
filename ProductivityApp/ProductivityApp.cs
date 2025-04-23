using System.Media;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using System;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace ProductivityApp
{
    public partial class ProductivityApp : Form
    {
        private Timer? timer;
        private TimeSpan timeLeft;
        private int sessionCount = 0;
        private bool isWorkSession = true;
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
                    if (sessionCount % 4 == 0)
                        timeLeft = TimeSpan.FromMinutes((double)numLongBreak.Value);
                    else
                        timeLeft = TimeSpan.FromMinutes((double)numShortBreak.Value);
                }
                else
                {
                    timeLeft = TimeSpan.FromMinutes((double)numWork.Value);
                }

                isWorkSession = !isWorkSession;
                lblStatus.Text = isWorkSession ? "Work" : "Break";
                lblTime.Text = timeLeft.ToString("mm\\:ss");
                timer.Start();
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
    }
}
