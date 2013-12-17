using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoingLaundry
{
    public class LaundryTray
    {
        public NotifyIcon trayIcon { get; private set; } 
        private ContextMenu trayMenu;

        /// <summary>
        /// Laundry tray constructor
        /// </summary>
        /// <param name="doubleClickEvent">EvendHandler for when the tray icon is double clicked.</param>
        /// <param name="exitClickEvent">EvendHandler for "Exit" is chosen from the context menu.</param>
        public LaundryTray(EventHandler doubleClickEvent, EventHandler exitClickEvent)
        {
            // Create a simple tray menu with only one item.
            trayMenu = new ContextMenu();
            trayMenu.MenuItems.Add("Exit", exitClickEvent);
            
            // Create a tray icon. 
            trayIcon = new NotifyIcon();
            trayIcon.Text = "Doing The Laundry";
            trayIcon.Icon = (System.Drawing.Icon)Properties.Resources.WasherIcon;
            trayIcon.DoubleClick += new System.EventHandler(doubleClickEvent);

            // Add menu to tray icon and show it.
            trayIcon.ContextMenu = trayMenu;
            trayIcon.Visible = true;
        }
    }
}
