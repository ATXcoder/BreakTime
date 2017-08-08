using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace BreakTime
{
    public partial class Form1 : Form
    {
        int breakTime = 0;
        int workTime = 0;
        int intervalCount = 0;
        bool onBreak = false;
        int timeRemaining = 0;
        string statusLabel = null;
        

        public Form1()
        {
            InitializeComponent();

            // Get work interval
            workTime = int.Parse(Box_WorkInterval.Text);

            // Get the break interval
            breakTime = int.Parse(Box_BreakInterval.Text);

            // Convert minutes to seconds for both
            workTime = workTime * 60;
            breakTime = breakTime * 60;

            // Handles locking and unlocking computer
            SystemEvents.SessionSwitch += SystemEvents_SessionSwitch;
        }

        void SystemEvents_SessionSwitch(object sender, SessionSwitchEventArgs e)
        {
            switch (e.Reason.ToString())
            {
                case "SessionLock":
                    // Pause/Stop timer
                    StopTimer();
                    break;

                case "SessionUnlock":
                    // Resume timer
                    StartTimer();
                    break;

                default:
                    // Do nothing
                    break;
            }
        }

        private void Bttn_Start_Click(object sender, EventArgs e)
        {
            // Get work interval
            workTime = int.Parse(Box_WorkInterval.Text);

            // Get the break interval
            breakTime = int.Parse(Box_BreakInterval.Text);

            // Convert minutes to seconds for both
            workTime = workTime * 60;
            breakTime = breakTime * 60;

            // Start the timer
            breakTimer.Enabled = true;
            breakTimer.Start();

            // Disable the Work and Break boxes
            Box_WorkInterval.Enabled = false;
            Box_BreakInterval.Enabled = false;

            // Disable START button
            Bttn_Start.Enabled = false;
            Bttn_Stop.Enabled = true;

        }

        private void breakTimer_Tick(object sender, EventArgs e)
        {
            // Increment the counter
            intervalCount++;

            // Check if we are on break
            if (onBreak)
            {
                timeRemaining = breakTime - intervalCount;
                statusLabel = "BREAK";
                Label_Status.Text = statusLabel;
            }
            else
            {
                timeRemaining = workTime - intervalCount;
                statusLabel = "WORKING";
                Label_Status.Text = statusLabel;
            }
            

            if (timeRemaining > 0)
            {
                TimeSpan time = TimeSpan.FromSeconds(timeRemaining);
                string _tempTime = time.ToString(@"hh\:mm\:ss");

                Label_Timer.Text = _tempTime;
                notifyIcon1.Text = "Break Time - " + _tempTime + " - " + statusLabel;
            }
            else
            {
                // If we are on a break and time is up
                if (onBreak)
                {
                    // Set break to false (back to work)
                    onBreak = false;
                    breakTimer.Stop();
                    var popupNotifier = new PopupNotifier();
                    popupNotifier.TitleText = "BREAK ENDED";
                    popupNotifier.ContentText = "Your break has ended. Now resuming work session.";
                    popupNotifier.IsRightToLeft = false;
                    popupNotifier.BodyColor = Color.White;
                    popupNotifier.TitleColor = Color.Black;
                    popupNotifier.Popup();
                    intervalCount = 0;
                    breakTimer.Start();
                }
                else
                {
                    onBreak = true;
                    breakTimer.Stop();
                    var popupNotifier = new PopupNotifier();
                    popupNotifier.TitleText = "BREAK STARTED";
                    popupNotifier.ContentText = "Time to take a break!";
                    popupNotifier.IsRightToLeft = false;
                    popupNotifier.Popup();
                    intervalCount = 0;
                    breakTimer.Start();
                }             
            }
        }

        private void Bttn_Stop_Click(object sender, EventArgs e)
        {
            // Stop timer
            StopTimer();
        }

        private void Bttn_Reset_Click(object sender, EventArgs e)
        {
            // Stop the timer
            StopTimer();
            // Reset the interval counter
            intervalCount = 0;
            // Set "on break" to false
            onBreak = false;
            // Reset timer display to zero
            Label_Timer.Text = "00:00:00";
            // Enable the Work and Break boxes
            Box_WorkInterval.Enabled = true;
            Box_BreakInterval.Enabled = true;
        }

        private void IconMenu_Pause_Click(object sender, EventArgs e)
        {
            // Stop / Pause timer
            StopTimer();
        }

        private void IconMenu_Start_Click(object sender, EventArgs e)
        {
            // Start timer
            StartTimer();
        }

        private void IconMenu_AddFive_Click(object sender, EventArgs e)
        {
            if (onBreak)
            {
                breakTime = breakTime + 300;
            }
            else
            {
                workTime = workTime + 300;
            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void IconMenu_Hide_Click(object sender, EventArgs e)
        {
            this.Hide();            
        }

        private void StopTimer()
        {
            // Stop timer
            breakTimer.Stop();

            // Enable START and STOP button
            Bttn_Start.Enabled = true;
            Bttn_Stop.Enabled = false;
        }

        private void StartTimer()
        {
            if (!breakTimer.Enabled)
            {
                breakTimer.Enabled = true;
            }
            // Start timer
            breakTimer.Start();

            //Disable START button
            Bttn_Start.Enabled = false;

            // Enable STOP button
            Bttn_Stop.Enabled = true;
        }

       
    }
}
