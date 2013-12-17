using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace DoingLaundry
{
    public partial class LaundryControl : UserControl
    {
        private Stopwatch LaundryStopwatch { get; set; }
        private System.Timers.Timer LaundryTimer { get; set; }
        
        private readonly double CycleLength;
        private bool LaundryCompleted = false;

        /// <summary>
        /// Constructor for the LaundryControl class.
        /// </summary>
        /// <param name="startTime">The time that load was started.</param>
        /// <param name="timeRemaining">The time until the load finishes.</param>
        public LaundryControl(string startTime, double timeRemaining)
        {
            InitializeComponent();
            ConfigureTracking();
            BindRightClickEvent();

            CycleLength = timeRemaining;
            SetStartTime(startTime);
            SetRemainingTime(timeRemaining);
        }

        /// <summary>
        /// Starts the stopwatch and timer objects to keep track of the time.
        /// </summary>
        private void ConfigureTracking()
        {
            // Kick off the stopwatch to be as acurate as possible.
            LaundryStopwatch = new Stopwatch();
            LaundryStopwatch.Start();

            // Build the timer and start it.
            LaundryTimer = new System.Timers.Timer(10000);
            LaundryTimer.Elapsed += LaundryTimer_Elapsed;
            LaundryTimer.Enabled = true;
        }

        /// <summary>
        /// Actions to carry out for each timer interval that passes. 
        /// Checks if the stopwatch has reached the load time yet and acts accordingly.
        /// </summary>
        /// <param name="sender">PNU</param>
        /// <param name="e">PNU</param>
        private void LaundryTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            double minutesPassed = LaundryStopwatch.Elapsed.TotalMinutes;
            if (minutesPassed > CycleLength && !LaundryCompleted)
            {
                CompleteLaundry();
            }
            else
            {
                Invoke(new MethodInvoker(() => { SetRemainingTime(CycleLength - minutesPassed); }));
            }
        }

        /// <summary>
        /// Runs through the end of laundry cycle actions and sets the LaundryCompleted flag to true.
        /// </summary>
        private void CompleteLaundry()
        {
            LaundryCompleted = true;
            SetControlBackColor(Color.Aquamarine);
            
            if (LaundrySettings.SendEmailNotification)
            { Notifications.SendEmail(LaundrySettings.NotificationEmail, "Attention", "Laundry cycle has finished"); }

            if (LaundrySettings.PlaySoundNotification)
            { Notifications.GetAudioPlayer(LaundrySettings.SoundNotificationPath).controls.play(); }

            MessageBox.Show("Laundry cycle has finished!", "Get The Laundry", MessageBoxButtons.OK);
        }

        /// <summary>
        /// Sets the back color of the controls that are labels to the color specified.
        /// </summary>
        /// <param name="color">The desired back color.</param>
        private void SetControlBackColor(Color color)
        {
            foreach (Control control in this.Controls)
            {
                control.BackColor = color;
            }
        }

        /// <summary>
        /// Bind the right click event for all the present controls.
        /// </summary>
        private void BindRightClickEvent()
        {
            foreach (Control control in this.Controls)
            {
                control.MouseClick += LaundryControl_MouseClick;
            }
        }

        /// <summary>
        /// Sets the value for the start time label.
        /// </summary>
        /// <param name="startTime"></param>
        private void SetStartTime(string startTime)
        {
            labelStart.Text = "Start Time: " + startTime;
        }

        /// <summary>
        /// Sets the value for the remaining time label.
        /// </summary>
        /// <param name="timeRemaining"></param>
        private void SetRemainingTime(double timeRemaining)
        {
            labelTimeRemaing.Text = "Time Remaining: " + (int)timeRemaining;
        }

        /// <summary>
        /// Click event handler for the control.
        /// Checks if the click was a right click and if it was it shows the context menu at the cursor position.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LaundryControl_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                contextMenuStripLaundryControl.Show(Cursor.Position);
            }
        }

        /// <summary>
        /// Click event handler for the "Finish" option in the context menu for the control.
        /// </summary>
        /// <param name="sender">PNU</param>
        /// <param name="e">PNU</param>
        private void toolStripMenuItemEnd_Click(object sender, EventArgs e)
        {
            DestroyLaundryControl();
        }

        /// <summary>
        /// Cleans up the timers and calls dispose
        /// </summary>
        private void DestroyLaundryControl()
        {
            // Clean up the timer
            if (LaundryTimer != null)
            { LaundryTimer.Dispose(); }

            // Dispose of the user control.
            Dispose();
        }
    }
}
