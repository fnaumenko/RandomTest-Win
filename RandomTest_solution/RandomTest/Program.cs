using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RandomTest
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
            catch (System.IO.FileNotFoundException e)   // not found Plot.dll 
            {
                MessageBox.Show(e.Message, "Missing Plot.dll",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)                        // for any case
            {
                MessageBox.Show(e.Message, "Unrecognised error",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
