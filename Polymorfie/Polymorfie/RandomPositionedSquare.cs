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
    class RandomPositionedSquare : Square
    {
        Random rndGen = new Random();

        public RandomPositionedSquare() : base(0, 0)
        {

        }

        public override void DisplayOn(Canvas drawArea)
        {
            int x = rndGen.Next(300);
            int y = rndGen.Next(300);

            rect = new Rectangle();
            rect.Stroke = brush;
            rect.Width = size;
            rect.Height = size;
            //rect.Fill = new SolidColorBrush(Colors.Black);
            rect.Margin = new Thickness(x, y, 0, 0);
            drawArea.Children.Add(rect);
        }
    }
}
