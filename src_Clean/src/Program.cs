using System;
using System.Windows.Forms;
using iAuto.App;

namespace iAuto
{
    internal static class Program
    {
        [STAThread]
        private static void Main(string[] args)
        {
            string logPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "run.log");
            try
            {
                System.IO.File.WriteAllText(logPath, "Starting...\r\n");
                Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
                Application.ThreadException += delegate(object sender, System.Threading.ThreadExceptionEventArgs e)
                {
                    System.IO.File.AppendAllText(logPath, "ThreadException: " + e.Exception.ToString() + "\r\n");
                    MessageBox.Show(e.Exception.ToString(), "iAuto Thread Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                };
                AppDomain.CurrentDomain.UnhandledException += delegate(object sender, UnhandledExceptionEventArgs e)
                {
                    System.IO.File.AppendAllText(logPath, "DomainException: " + e.ExceptionObject.ToString() + "\r\n");
                };

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                System.IO.File.AppendAllText(logPath, "Running MainForm...\r\n");
                Application.Run(new MainForm());
                System.IO.File.AppendAllText(logPath, "MainForm exited normally.\r\n");
            }
            catch (Exception ex)
            {
                System.IO.File.AppendAllText(logPath, "Catch: " + ex.ToString() + "\r\n");
                MessageBox.Show(ex.ToString(), "iAuto Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
