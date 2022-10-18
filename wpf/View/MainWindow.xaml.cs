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
using System.Windows.Threading;
using wpf.View;

namespace wpf
{
    public partial class MainWindow : Window
    {
        Main a = new Main();
        public MainWindow()
        {
            InitializeComponent();
            test();
        }
        DispatcherTimer dispatcherTimer = new DispatcherTimer();
        private void test()
        {
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 20);
            dispatcherTimer.Start();
        }
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            dispatcherTimer.Stop();
            this.Close();
            a.ShowDialog();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            test();
        }

    }
}
