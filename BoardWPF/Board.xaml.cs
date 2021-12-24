using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;
using Microsoft.Win32;
using mshtml;

namespace BoardWPF
{
    /// <summary>
    /// Interaction logic for Board1.xaml
    /// </summary>
    public partial class Board1 : Window
    {
        public static int Second = 0;
        public Board1()
        {
            PreviewMouseDown += Window_Action;
            PreviewKeyDown += Window_Action;
            PreviewMouseMove += Window_Action;

            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();

            InitializeComponent();
        }
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            // Updating the Label which displays the current second
            Second++;
            if (Second > 60)
            {
                Second = 0;
                this.Hide();
                var form2 = new MainWindow();
                form2.Closed += (s, args) => this.Close();
                form2.Show();

            }
            // Forcing the CommandManager to raise the RequerySuggested event
            CommandManager.InvalidateRequerySuggested();
        }
        private void Window_Action(object Sender, InputEventArgs e)
        {
            Second = 0;
        }
        private void FUp_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WBUp.Load("https://www.facebook.com/");
            WBUp.Visibility = Visibility.Visible;
        }

        private void WPUp_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WBUp.Load("https://www.bpte-web.com/webportal/");
            WBUp.Visibility = Visibility.Visible;
        }

        private void YUp_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WBUp.Load("https://www.youtube.com/embed/CEZ6cF8eoeg");
            WBUp.Visibility = Visibility.Visible;
        }

        private void TUp_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WBUp.Load("https://www.Twitter.com/");
            WBUp.Visibility = Visibility.Visible;
        }
        private void WBUp_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
            //var doc = WBUp.Document as HTMLDocument;
            //if (doc == null)
            //    return;

            //var css = doc.createStyleSheet(string.Empty, 0);
            //css.cssText = "body { transform: rotate(180deg); }";
        }

        private void TLeft_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WBLeft.Load("https://www.Twitter.com/");
            WBLeft.Visibility = Visibility.Visible;
        }

        private void FLeft_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WBLeft.Load("https://www.facebook.com/");
            WBLeft.Visibility = Visibility.Visible;
        }

        private void YLeft_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WBLeft.Load("https://www.youtube.com/");
            WBLeft.Visibility = Visibility.Visible;
        }

        private void WLeft_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WBLeft.Load("https://www.bpte-web.com/webportal/");
            WBLeft.Visibility = Visibility.Visible;
        }

        private void YDown_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WBDown.Load("https://www.youtube.com/");
            WBDown.Visibility = Visibility.Visible;
        }

        private void WDown_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WBDown.Load("https://www.bpte-web.com/webportal/");
            WBDown.Visibility = Visibility.Visible;
        }

        private void FDown_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WBDown.Load("https://www.facebook.com/");
            WBDown.Visibility = Visibility.Visible;
        }

        private void TDown_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WBDown.Load("https://www.Twitter.com/");
            WBDown.Visibility = Visibility.Visible;
        }

        private void TRight_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WBRight.Load("https://www.Twitter.com/");
            WBRight.Visibility = Visibility.Visible;
        }

        private void FRight_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WBRight.Load("https://www.facebook.com/");
            WBRight.Visibility = Visibility.Visible;
        }

        private void WRight_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WBRight.Load("https://www.bpte-web.com/webportal/");
            WBRight.Visibility = Visibility.Visible;
        }

        private void YRight_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WBRight.Load("https://www.youtube.com/");
            WBRight.Visibility = Visibility.Visible;
        }

        private void WBLeft_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
            //var doc = WBLeft.Document as HTMLDocument;
            //if (doc == null)
            //    return;

            //var css = doc.createStyleSheet(string.Empty, 0);
            //css.cssText = "body { transform: rotate(90deg); }";
        }

        private void WBRight_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
            //var doc = WBRight.Document as HTMLDocument;
            //if (doc == null)
            //    return;

            //var css = doc.createStyleSheet(string.Empty, 0);
            //css.cssText = "body { transform: rotate(-90deg); }";
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Btnback_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            var form2 = new MainWindow();
            form2.Closed += (s, args) => this.Close();
            form2.Show();

        }

    }
}
