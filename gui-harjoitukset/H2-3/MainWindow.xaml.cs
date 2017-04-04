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

namespace H2_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MyInitialize();
        }
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            string selection = cb1.SelectedValue.ToString();
            int rivit = 0;
            bool tmp = int.TryParse(tb1.Text, out rivit);
            Random r = new Random();
            if (selection.Equals("Lotto") && tmp)
            {
                for (int i = 0; i < rivit; ++i)
                {
                    int[] numerot = lotto(r);
                    box1.Text += "Rivi " + i 
                        + ":   " 
                        + numerot[0] + "  " 
                        + numerot[1] + "  "
                        + numerot[2] + "  "
                        + numerot[3] + "  "
                        + numerot[4] + "  "
                        + numerot[5] + "  "
                        + numerot[6] 
                        + "\n";
                }
            }
            else if (selection.Equals("Viking Lotto"))
            {
                for (int i = 0; i < rivit; ++i)
                {
                    int[] numerot = lotto(r);
                    box1.Text += "Rivi " + i
                        + ":   "
                        + numerot[0] + "  "
                        + numerot[1] + "  "
                        + numerot[2] + "  "
                        + numerot[3] + "  "
                        + numerot[4] + "  "
                        + numerot[5]
                        + "\n";
                }
            }
            else
            {
                for (int i = 0; i < rivit; ++i)
                {
                    int[] numerot = euro(r);
                    box1.Text += "Rivi " + i
                        + ":   "
                        + numerot[0] + "  "
                        + numerot[1] + "  "
                        + numerot[2] + "  "
                        + numerot[3] + "  "
                        + numerot[4] + "  *"
                        + numerot[5] + "  *"
                        + numerot[6]
                        + "\n";
                }
            }
        }
        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            box1.Text = "";
        }

        public int[] lotto(Random r)
        {
            int[] numerot = new int[7];
            for (int i = 0; i < 7; ++i)
            {
                int tmp = r.Next(1, 39);
                numerot[i] = tmp;
            }
            return numerot;
        }
        public int[] vlotto(Random r)
        {
            int[] numerot = new int[6];
            for (int i = 0; i < 6; ++i)
            {
                int tmp = r.Next(1, 48);
                numerot[i] = tmp;
            }
            return numerot;
        }
        public int[] euro(Random r)
        {
            int[] numerot = new int[7];
            for (int i = 0; i < 5; ++i)
            {
                int tmp = r.Next(1, 50);
                numerot[i] = tmp;
            }
            Random tr = new Random();
            for (int i = 5; i < 7; ++i)
            {
                int tmp = tr.Next(1, 50);
                numerot[i] = tmp;
            }
            return numerot;
        }

        private void MyInitialize()
        {
            tb1.Text = "";
        }
    }
}
