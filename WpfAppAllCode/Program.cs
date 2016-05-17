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
            Window mainWindow = new Window();
            mainWindow.Title = "My First WPF App!";
            mainWindow.Height = 200;
            mainWindow.Width = 300;
            mainWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            mainWindow.Show();
        }
    }
}
