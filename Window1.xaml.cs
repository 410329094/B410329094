using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Ink;

namespace WpfApplication1
{
    /// <summary>
    /// Window1.xaml 的互動邏輯
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        public InkCanvas mydraw;

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            DrawingAttributes da=new DrawingAttributes();
            da.Color=Colors.Red;
            da.Width=10;
            mydraw.DefaultDrawingAttributes = da;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            DrawingAttributes da=new DrawingAttributes();
            da.Color=Colors.Green;
            da.Width=10;
            mydraw.DefaultDrawingAttributes = da;
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            DrawingAttributes da = new DrawingAttributes(); 
            da.Width = 15;
            mydraw.DefaultDrawingAttributes = da;
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            DrawingAttributes da = new DrawingAttributes();
            da.Width = 3;
            mydraw.DefaultDrawingAttributes = da;
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            mydraw.EditingMode = InkCanvasEditingMode.EraseByStroke;
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            DrawingAttributes da = new DrawingAttributes();
            da.Color = Colors.Yellow;
            da.Width = 10;
            mydraw.DefaultDrawingAttributes = da;
        }
    }
}
