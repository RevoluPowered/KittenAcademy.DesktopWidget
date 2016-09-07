using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Win32;

namespace Windows_Background_Web_View
{
    static class Program
    {
        /// <summary>
        /// Auto start registration for application
        /// Application will register to the registry on windows for starting up the cat viewer application
        /// </summary>
        /// <param name="enable"></param>
        public static void Autostart(bool enable)
        {
            // Assign the registry key
            RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (enable)
            {
                // Startup key should be added if it doesn't already exist.
                rk.SetValue(Application.ProductName, Application.ExecutablePath.ToString());
            }
            else
            {
                // Check if the product key is actually in the registry before deleting it.
                if (rk.GetValue(Application.ProductName) != null)
                {
                    // Delete value from registry
                    rk.DeleteValue(Application.ProductName);
                }

            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Retrieve the command line arguments
            string[] args = Environment.GetCommandLineArgs();

            // If the arguments for the 
            foreach(string s in args)
            {
                if (s == "--install")
                {
                    Autostart(true);
                }
                else if(s == "--uninstall" || s == "--remove")
                {
                    Autostart(false);
                }

            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
