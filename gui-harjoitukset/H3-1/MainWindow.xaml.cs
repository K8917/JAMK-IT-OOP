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

namespace H3_1
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
        Boolean isDrawing = false;
        Point lineStart;
        SolidColorBrush brush = new SolidColorBrush(Colors.Black);

        private void My_MouseUp(object sender, MouseButtonEventArgs e)
        {
            isDrawing = false;
        }

        private void My_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                Point lineEnd = e.GetPosition(MyCanvas);
                Line l = new Line();
                l.X1 = lineStart.X;
                l.Y1 = lineStart.Y;
                l.X2 = lineEnd.X;
                l.Y2 = lineEnd.Y;
                l.Stroke = brush;
                l.StrokeThickness = 2;
                MyCanvas.Children.Add(l);
                lineStart = lineEnd;
            }
        }

        private void My_MouseDown(object sender, MouseButtonEventArgs e)
        {
            isDrawing = true;
            lineStart = e.GetPosition(MyCanvas);
        }

        private void My_ButtonClick(object sender, RoutedEventArgs e)
        {
            MyCanvas.Children.Clear();
        }
        private void ChangeColor2(object sender, RoutedEventArgs e)
        {
            brush = new SolidColorBrush(Colors.Yellow);
        }
        private void ChangeColor3(object sender, RoutedEventArgs e)
        {
            brush = new SolidColorBrush(Colors.Red);
        }
        private void ChangeColor4(object sender, RoutedEventArgs e)
        {
            brush = new SolidColorBrush(Colors.Blue);
        }
        private void ChangeColor5(object sender, RoutedEventArgs e)
        {
            brush = new SolidColorBrush(Colors.Green);
        }
        private void ChangeColor6(object sender, RoutedEventArgs e)
        {
            brush = new SolidColorBrush(Colors.Black);
        }
    }
}
