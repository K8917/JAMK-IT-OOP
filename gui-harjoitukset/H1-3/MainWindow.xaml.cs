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

namespace H1_3
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

        private void laske_Click(object sender, RoutedEventArgs e)
        {
            // karmi, leveys, korkeus, piiri, iAla, lAla
            double korkeus_ = 0;
            double leveys_ = 0;
            double karmi_ = 0;
            bool tmp = double.TryParse(leveys.Text, out leveys_);
            bool tmp2 = double.TryParse(korkeus.Text, out korkeus_);
            bool tmp3 = double.TryParse(karmi.Text, out karmi_);
            if (tmp && tmp2)
            {
                double lasinAla = (((korkeus_ - karmi_*2) * (leveys_ - karmi_*2)) / 10);
                lAla.Text = lasinAla.ToString("0") + " cm^2";
            }
            if (tmp && tmp2 && tmp3)
            {
                double ikkunanAla = ((korkeus_ * leveys_) / 10);
                iAla.Text = ikkunanAla.ToString("0") + " cm^2";
                double karmiPiiri = (((korkeus_ + leveys_) * 2) / 10);
                piiri.Text = karmiPiiri.ToString("0") + " cm";
            }
        }
    }
}
