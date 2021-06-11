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

namespace EntryPainter
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Point _startPoint = new Point();
        private Point _endPoint = new Point();

        public MainWindow()
        {
            InitializeComponent();
            
            /*
            paintSurface.MouseMove += (sender, args) =>
            {
                if (args.LeftButton == MouseButtonState.Pressed)
                {
                    Polyline polyLine;
                    if (paintSurface.Children.Count == 0)
                    {
                        polyLine = new Polyline();
                        polyLine.Stroke = new SolidColorBrush(Colors.DarkBlue);
                        polyLine.StrokeThickness = 10;

                        paintSurface.Children.Add(polyLine);
                    }

                    polyLine = (Polyline)paintSurface.Children[0];
                    Point currentPoint = args.GetPosition(paintSurface);
                    polyLine.Points.Add(currentPoint);
                }
            };
            */

        }

        private void paintSurface_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ButtonState == MouseButtonState.Pressed)
            {
                _startPoint = e.GetPosition(this);
            }
            else if(e.ButtonState == MouseButtonState.Released)
            {
                _endPoint = e.GetPosition(this);
            }
        }

        private void paintSurface_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                Line line = new Line();

                line.Stroke = SystemColors.WindowFrameBrush;
                line.X1 = _startPoint.X;
                line.Y1 = _startPoint.Y;
                line.X2 = e.GetPosition(this).X;
                line.Y2 = e.GetPosition(this).Y;

                _startPoint = e.GetPosition(this);

                paintSurface.Children.Add(line);
            }
            
        }
    }
}
