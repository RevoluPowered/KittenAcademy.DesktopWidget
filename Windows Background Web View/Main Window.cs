using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace Windows_Background_Web_View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitialiseChromeForm();

            // Align to the right of the screen
            Rectangle rect = Screen.FromControl(this).Bounds;
            this.Location = new Point(rect.Width - 1280 - 400, 200);
            

            // Fix cursor
            this.Cursor = Cursors.Arrow;
            // Update window to be on the bottom of the screen
            Utilities.SetWindowPos(Handle, Utilities.HWND_BOTTOM, 0, 0, 0, 0, Utilities.SWP_NOMOVE | Utilities.SWP_NOSIZE | Utilities.SWP_NOACTIVATE);
        }

        /// <summary>
        /// The web browser reference
        /// </summary>
        public ChromiumWebBrowser mBrowser;

        /// <summary>
        /// The settings for the chrome browser instance
        /// </summary>
        public CefSettings mSettings;

        /// <summary>
        /// The initialise function for the web browser
        /// </summary>
        private void InitialiseChromeForm()
        {
            // Initialise the settings
            mSettings = new CefSettings();
            mSettings.CefCommandLineArgs.Add("enable-npapi", "1");
            // Initialise the chrome instance
            Cef.Initialize(mSettings);
            Cef.EnableHighDPISupport();
            // Create the browser instance
            mBrowser = new ChromiumWebBrowser("about:blank");
            mBrowser.LoadHtml(@"<iframe width='1280' height='720' src='https://www.youtube.com/embed/_o74BnFSr8g?controls=0&showinfo=0&autoplay=1' frameborder='0' allowfullscreen></iframe>", "http://cats.lololol");
            
            // Make sure no other controls exist
            Controls.Clear();

            // Attach the browser as control
            Controls.Add(mBrowser);

            // Set the browser to fill the UI element.
            //mBrowser.Dock = DockStyle.Top;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox box = new AboutBox();
            box.ShowDialog();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Kill the browser / release resources
            Cef.Shutdown();

            // Exit application
            Application.Exit();
        }
    }
}
