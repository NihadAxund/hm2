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
using wpf.Model;

namespace wpf.View
{
    /// <summary>
    /// Interaction logic for BookControl.xaml
    /// </summary>
    public partial class BookControl : UserControl
    {
        private BookControl()
        {
            InitializeComponent();
        }
        private int Number { get; set; } = 0;
        public BookControl(Books bk)
        {
            InitializeComponent();
            lbl_txt.Content = bk.Name;
            Count.Content = "Count: "+bk.Quantity.ToString();
        }
        private void Funtion()
        {
            Count_txt.Content = Number.ToString();
            //MessageBox.Show(Number)
        }
        private void btn_Click(object sender, RoutedEventArgs e)
        {
            Number++;
            Funtion();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Number>0)
            {
                Number--;
            }
            Funtion();
        }
    }
}
