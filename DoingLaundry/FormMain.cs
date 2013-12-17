using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoingLaundry
{
    public partial class FormMain : Form
    {
        public LaundryTray LaundryTrayIcon { get; set; }

        private bool canClose = false;

        public FormMain()
        {
            InitializeComponent();
            LaundryTrayIcon = new LaundryTray(TrayIcon_DoubleClicked, TrayIcon_Exiting);
            Icon = Properties.Resources.WasherIcon;
        }

        /// <summary>
        /// Click event for the Washer button.
        /// Starts a new laundry washer cycle.
        /// </summary>
        /// <param name="sender">PNU</param>
        /// <param name="e">PNU</param>
        private void buttonWasher_Click(object sender, EventArgs e)
        {
            LaundryControl lc = new LaundryControl(DateTime.Now.ToShortTimeString(), LaundrySettings.DefaultWasherTime - (int)numericUpDownMinutesAgo.Value);
            flowLayoutPanelWashing.Controls.Add(lc);
        }

        /// <summary>
        /// Click event for the Dryer button.
        /// Starts a new laundry dryer cycle.
        /// </summary>
        /// <param name="sender">PNU</param>
        /// <param name="e">PNU</param>
        private void buttonDryer_Click(object sender, EventArgs e)
        {
            LaundryControl lc = new LaundryControl(DateTime.Now.ToShortTimeString(), LaundrySettings.DefaultDryerTime - (int)numericUpDownMinutesAgo.Value);
            flowLayoutPanelDrying.Controls.Add(lc);
        }

        /// <summary>
        /// Click event for the settings button.
        /// Creates and opens a new instance of the settings form.
        /// </summary>
        /// <param name="sender">PNU</param>
        /// <param name="e">PNU</param>
        private void buttonSettings_Click(object sender, EventArgs e)
        {
            FormSettings settingsForm = new FormSettings();
            settingsForm.Show();
        }

        /// <summary>
        /// Event handler for a double click on the LaundryTray object.
        /// If the form is currently minimized, it calls show and sets the state to normal.
        /// </summary>
        /// <param name="sender">PNU</param>
        /// <param name="e">PNU</param>
        private void TrayIcon_DoubleClicked(object sender, System.EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
            }
        }

        /// <summary>
        /// Event handler for exit option in LaundryTray object's right click context menu.
        /// Sets the canClose flag to true and exits the application.
        /// </summary>
        /// <param name="sender">PNU</param>
        /// <param name="e">PNU</param>
        private void TrayIcon_Exiting(object sender, EventArgs e)
        {
            canClose = true;
            Application.Exit();
        }

        /// <summary>
        /// Form resize event. 
        /// If the form was minimized, call hide method to prevent form from showing in task bad.
        /// </summary>
        /// <param name="sender">PNU</param>
        /// <param name="e">PNU</param>
        private void FormMain_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                this.Hide();
            }
        } 

        /// <summary>
        /// Form closing event. 
        /// Checks if the can close boolean has been set, otherwise cancels the close operation and minimizes the form.
        /// </summary>
        /// <param name="sender">PNU</param>
        /// <param name="e">PNU</param>
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (canClose)
            {
                LaundryTrayIcon.trayIcon.Dispose();
            }
            else
            {
                e.Cancel = true;
                this.WindowState = FormWindowState.Minimized;
            }
        }

        /// <summary>
        /// When the user clicks inside the NumericUpDown spin up area select all the text.
        /// </summary>
        /// <param name="sender">PNU</param>
        /// <param name="e">PNU</param>
        private void numericUpDownMinutesAgo_MouseClick(object sender, MouseEventArgs e)
        {
            (sender as NumericUpDown).Select(0, numericUpDownMinutesAgo.Value.ToString().Length);
        }
    }
}
