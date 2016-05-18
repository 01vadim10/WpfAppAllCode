using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfAppAllCode
{
    class Program : Application
    {
        [STAThread]
        static void Main(string[] args)
        {
            Program app = new Program();
            app.Startup += AppStartUp;
            app.Exit += AppExit;
            app.Run();
        }

        static void AppExit(object sender, ExitEventArgs e)
        {
            MessageBox.Show("App has exited");
        }

        static void AppStartUp(object sender, StartupEventArgs e)
        {
            Current.Properties["GodMode"] = false;
            foreach (string arg in e.Args)
            {
                if (arg.ToLower() == "/godmode")
                {
                    Current.Properties["GodMode"] = true;
                    break;
                }
            }
            MainWindow wnd = new MainWindow("My better WPF App!", 200, 300);
        }
    }
}
