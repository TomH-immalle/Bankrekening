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
    class RandomPositionedCircle : Circle
    {
        Random rndGen = new Random();

        public RandomPositionedCircle() : base(0, 0)
        {

        }

        public override void DisplayOn(Canvas drawArea)
        {
            int x = rndGen.Next(300);
            int y = rndGen.Next(300);

            ellipse = new Ellipse();
            ellipse.Stroke = brush;
            ellipse.Width = size;
            ellipse.Height = size;
            ellipse.Margin = new Thickness(x, y, 0, 0);
            drawArea.Children.Add(ellipse);
        }
    }
}
