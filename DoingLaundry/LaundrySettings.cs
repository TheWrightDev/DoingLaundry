using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoingLaundry
{
    static class LaundrySettings
    {
        public static int DefaultWasherTime { get; private set; }
        public static int DefaultDryerTime { get; private set; }
        public static bool SendEmailNotification { get; private set; }
        public static bool PlaySoundNotification { get; private set; }
        public static string NotificationEmail { get; private set; }
        public static string SoundNotificationPath { get; private set; }

        static LaundrySettings()
        {
            LoadSettings();
        }

        /// <summary>
        /// Loads the properties with the settings from the App.config file.
        /// </summary>
        private static void LoadSettings()
        {
            int defaultWasherTime;
            int defaultDryerTime;
            if (!Int32.TryParse(ConfigurationManager.AppSettings["defaultWasherTime"].ToString(), out defaultWasherTime))
            {
                MessageBox.Show("Failed to load default washer time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                defaultWasherTime = 0;
            }
            if (!Int32.TryParse(ConfigurationManager.AppSettings["defaultDryerTime"].ToString(), out defaultDryerTime))
            {
                MessageBox.Show("Failed to load default dryer time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                defaultDryerTime = 0;
            }

            // Set the send notification check box value based on the value in the sendNotification property.
            string sendNotification = ConfigurationManager.AppSettings["sendEmailNotification"].ToString();
            string playSoundNotification = ConfigurationManager.AppSettings["playSoundNotification"].ToString();

            // Load values into the properties
            DefaultWasherTime = defaultWasherTime;
            DefaultDryerTime = defaultDryerTime;
            SendEmailNotification = sendNotification.Equals("1");
            PlaySoundNotification = playSoundNotification.Equals("1");
            NotificationEmail = ConfigurationManager.AppSettings["notificationAddress"].ToString();
            SoundNotificationPath = ConfigurationManager.AppSettings["soundPath"].ToString();
        }

        /// <summary>
        /// Saves the provided values to the App.config value.
        /// </summary>
        /// <param name="defaultWasherTime">The default washer time.</param>
        /// <param name="defaultDryerTime">The default dryer time.</param>
        /// <param name="sendNotification">True if notifications should be sent, otherwise false.</param>
        /// <param name="notificationAddress">The address to send the notifications too.</param>
        public static void SaveLaundrySettings(int defaultWasherTime, int defaultDryerTime, bool sendNotification, string notificationAddress, bool playSoundNotification, string soundPath)
        {
            // Get the configuration for the app
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            // Update all of the settings
            config.AppSettings.Settings["defaultWasherTime"].Value = defaultWasherTime.ToString();
            config.AppSettings.Settings["defaultDryerTime"].Value = defaultDryerTime.ToString();
            config.AppSettings.Settings["sendEmailNotification"].Value = sendNotification ? "1" : "0";
            config.AppSettings.Settings["notificationAddress"].Value = notificationAddress;
            config.AppSettings.Settings["playSoundNotification"].Value = playSoundNotification ? "1" : "0";
            config.AppSettings.Settings["soundPath"].Value = soundPath;

            // Apply the value and reload.
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");

            // Reload the settings
            LoadSettings();
        }
    }
}
