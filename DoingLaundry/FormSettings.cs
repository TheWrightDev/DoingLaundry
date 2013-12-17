using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace DoingLaundry
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
            ShowSettings();
        }

        /// <summary>
        /// Loads the settings from the LaundrySettings class to the fields on the form.
        /// </summary>
        private void ShowSettings()
        {
            // Load in the basic field settings
            numericUpDownWasherTime.Value = LaundrySettings.DefaultWasherTime;
            numericUpDownDryerTime.Value = LaundrySettings.DefaultDryerTime;
            checkBoxEmailNotification.Checked = LaundrySettings.SendEmailNotification;
            checkBoxSoundNotification.Checked = LaundrySettings.PlaySoundNotification;
            textBoxSoundPath.Text = LaundrySettings.SoundNotificationPath;
            textBoxEmail.Text = LaundrySettings.NotificationEmail;
            
        }

        /// <summary>
        /// Enabled/Disables the sound path depending on the checked value.
        /// </summary>
        /// <param name="sender">PNU</param>
        /// <param name="e">PNU</param>
        private void checkBoxSoundNotification_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSoundPath.Enabled = checkBoxSoundNotification.Checked;
        }

        /// <summary>
        /// Enabled/Disables the address field depending on the checked value.
        /// </summary>
        /// <param name="sender">PNU</param>
        /// <param name="e">PNU</param>
        private void checkBoxEmailNotification_CheckedChanged(object sender, EventArgs e)
        {
            textBoxEmail.Enabled = checkBoxEmailNotification.Checked;
        }

        /// <summary>
        /// Browse button for sound path.
        /// Opens an open file dialog and lets the user browse to a mp3/wav file. Sets the sound path textbox to the path.
        /// </summary>
        /// <param name="sender">PNU</param>
        /// <param name="e">PNU</param>
        private void buttonBrowseForSound_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic),
                Filter = "MP3 files (*.mp3)|*.mp3|WAV Files (*.wav)|*.wav",
                RestoreDirectory = true
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxSoundPath.Text = openFileDialog.FileName;
            }
        }

        /// <summary>
        /// When the user clicks inside the NumericUpDown spin up area select all the text.
        /// </summary>
        /// <param name="sender">PNU</param>
        /// <param name="e">PNU</param>
        private void numericUpDown_MouseClick(object sender, MouseEventArgs e)
        {
            NumericUpDown numUpDown = (sender as NumericUpDown);
            numUpDown.Select(0, numUpDown.Value.ToString().Length);
        }

        /// <summary>
        /// Saves the settings and closes the form. 
        /// </summary>
        /// <param name="sender">PNU</param>
        /// <param name="e">PNU</param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            LaundrySettings.SaveLaundrySettings((int)numericUpDownWasherTime.Value,
                                                (int)numericUpDownDryerTime.Value,
                                                checkBoxEmailNotification.Checked,
                                                textBoxEmail.Text.Trim(),
                                                checkBoxSoundNotification.Checked,
                                                textBoxSoundPath.Text.Trim());
            this.Close();
        }

        /// <summary>
        /// Closes the form.
        /// </summary>
        /// <param name="sender">PNU</param>
        /// <param name="e">PNU</param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
