using System;
using System.Windows.Forms;

namespace cs345_barcenilla_f1_image_processing
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ImageProcessor());
        }
    }
}
