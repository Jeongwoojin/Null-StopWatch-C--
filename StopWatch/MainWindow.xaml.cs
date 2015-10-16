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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;
namespace StopWatch
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void setTime()
        {
            DateTime dt = new DateTime();
            dt = dt.Date.AddHours(nu_hour.Values).AddMinutes(nu_min.Values).AddSeconds(nu_sec.Values);
            tb_time.Text = ToTimeText(dt);
            tb_time.Tag = dt;
        }
        private string ToTimeText(DateTime dt)
        {
            if (int.Parse(String.Format(@"{0:hh:mm:ss}", dt).Split(':')[0])!= dt.Hour)
            {
                return "00:"+String.Format(@"{0:hh:mm:ss}", dt).Substring(3,5);
            }
           return  String.Format(@"{0:hh:mm:ss}",dt);
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }
        bool use;
        Thread th;
        private void bt_add_Click(object sender, RoutedEventArgs e)
        {
            setTime();
            use = true;
            try
            {
                th.Abort();
            }
            catch (Exception ex) { }
            th = new Thread(new ThreadStart(SubTrack));
            th.Start();
        }
        void SubTrack()
        {
            while (use)
            {
                this.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, (Action)delegate()
                {
                    
                    DateTime dt = (DateTime)tb_time.Tag;
                    if (dt.Ticks != 0)
                    {
                        TimeSpan tp = new TimeSpan(0, 0, 1);
                        dt = dt.Subtract(tp);
                        tb_time.Text = ToTimeText(dt);
                        tb_time.Tag = dt;

                    }
                    else
                    {
                        use = false;
                    }
                });

                Thread.Sleep(1000);
            }
            
        }

        private void rt_bar_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void tb_bartext_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void cb_top_Checked(object sender, RoutedEventArgs e)
        {
            if (cb_top.IsChecked == true)
            {
                this.Topmost = true;
            }
            else
            {
                this.Topmost = false;
            }
        }

        private void rt_Exit_MouseUp(object sender, MouseButtonEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
    }
}
