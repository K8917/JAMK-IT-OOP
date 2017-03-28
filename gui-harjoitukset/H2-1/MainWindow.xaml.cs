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

namespace H2_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            string tmp = "";
            if ((bool)Chk1.IsChecked)
            {
                tmp += Chk1.Content + " ";
            }
            if ((bool)Chk2.IsChecked)
            {
                tmp += Chk2.Content + " ";
            }
            if ((bool)Chk3.IsChecked)
            {
                tmp += Chk3.Content + " ";
            }
            if ((bool)Chk4.IsChecked)
            {
                tmp += Chk4.Content + " ";
            }
            if ((bool)Chk5.IsChecked)
            {
                tmp += Chk5.Content + " ";
            }
            Block1.Text = tmp;
        }
    }
}
