using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoingLaundry
{
    class Notifications
    {
        static private MailAddress fromAddress = new MailAddress("DoingTheLaundryNotification@gmail.com", null);
        const string fromPassword = "doingthelaundry";

        /// <summary>
        /// Sends an email notification using background worker to avoid blocking UI
        /// </summary>
        /// <param name="notificationRecipient">The recipient of the email.</param>
        /// <param name="emailSubject">The subject of the email.</param>
        /// <param name="emailBody">The body of the email.</param>
        public static void SendEmail(string notificationRecipient, string emailSubject, string emailBody)
        {
            MailAddress toAddress = new MailAddress(notificationRecipient, null);

            var worker = new BackgroundWorker();
            worker.WorkerReportsProgress = false;
            worker.DoWork += (sender, e) =>
            {
                try
                {
                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                    };
                    using (var message = new MailMessage(fromAddress, toAddress)
                    {
                        Subject = emailSubject,
                        Body = emailBody
                    })
                    {
                        smtp.Send(message);
                    }
                }
                catch (Exception)
                {
                    // Silent catch...not the end of the world if the email isn't sent.
                }
            };
            worker.RunWorkerAsync();
        }

        /// <summary>
        /// Creates a new instance of the WindowsMediaPlayer class and returns it.
        /// </summary>
        /// <param name="audioPath">The path of the audio file.</param>
        /// <returns>Instance of the WindowsMediaPlayer class </returns>
        public static WMPLib.WindowsMediaPlayer GetAudioPlayer(String audioPath)
        {
            WMPLib.WindowsMediaPlayer Player = new WMPLib.WindowsMediaPlayer();
            Player.MediaError += (o) => { MessageBox.Show("Unable to play audio notification.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); };
            Player.URL = audioPath;
            return Player;
        }
    }
}
