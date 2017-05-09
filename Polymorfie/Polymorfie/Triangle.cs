using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Polymorfie
{
    class Triangle : Shape
    {

        private Polygon driehoek;

        public Triangle(int initX, int initY) :base(initX, initY)
        {
            x = initX;
            y = initY;
            CreateTriangle();
        }

        

        public override void DisplayOn(Canvas drawArea)
        {
            drawArea.Children.Add(driehoek);
        }

        private void CreateTriangle()
        {
            driehoek = new Polygon();
            driehoek.Stroke = brush;
            driehoek.Fill = new SolidColorBrush(Colors.Black);
            driehoek.Margin = new Thickness(x, y, 0, 0);
            driehoek.Points = new PointCollection() { new Point(x, y), new Point(x + 100, y), new Point(x, y + 100) };
        }
    }
}
