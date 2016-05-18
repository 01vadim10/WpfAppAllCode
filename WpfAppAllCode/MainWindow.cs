using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfAppAllCode
{
    class MainWindow : Window
    {
        private Button btnExitApp = new Button();
        public MainWindow(string windowTitle, int height, int width)
        {
            btnExitApp.Click += new RoutedEventHandler(btnExitApp_Clicked);
            btnExitApp.Content = "Exit Application";
            btnExitApp.Height = 25;
            btnExitApp.Width = 100;

            this.AddChild(btnExitApp);

            Title = windowTitle;
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            Height = height;
            Width = width;
            Closing += MainWindow_Closing;
            Closed += MainWindow_Closed;
            MouseMove += MainWindow_MouseMove;
            KeyDown += MainWindow_KeyDown;
            Show();
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            btnExitApp.Content = e.Key.ToString();
        }

        protected void MainWindow_MouseMove(object sender, MouseEventArgs e)
        {
            Title = e.GetPosition(this).ToString();
        }

        private void MainWindow_Closed(object sender, EventArgs e)
        {
            MessageBox.Show("See ya!");
        }

        private void MainWindow_Closing(object sender, CancelEventArgs e)
        {
            string msg = "Do you want to close without saving?";
            MessageBoxResult result = MessageBox.Show(msg,
                "MyApp", MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnExitApp_Clicked(object sender, RoutedEventArgs e)
        {
            if ((bool) Application.Current.Properties["GodMode"])
            {
                MessageBox.Show("Cheater!");
            }
            Close();
        }
    }
}
