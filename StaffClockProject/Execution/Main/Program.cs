using System;
using OpenQA.Selenium;
using System.Windows.Forms;
using OpenQA.Selenium.Chrome;

namespace StaffClockProject {
    class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
