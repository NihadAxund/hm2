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

namespace wpf.View
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        public Main()
        {
            InitializeComponent();
            MyFunction();
        }
        private void MyFunction()
        {
            for (int i = 0; i < 100; i++)
            {
                BookControl bk = new();
                bk.Margin = new Thickness(20, 10, 0, 0);
                Book_list.Children.Add(bk);
            }
        }
    }
}
