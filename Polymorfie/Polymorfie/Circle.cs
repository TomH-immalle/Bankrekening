﻿using System;
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
    class Circle : Shape
    {
         protected Ellipse ellipse;

        public Circle(int initX, int initY) : base(initX, initY)
        {
            x = initX;
            y = initY;
            CreateEllipse();
        }

        public override void DisplayOn(Canvas drawArea)
        {
            drawArea.Children.Add(ellipse);
        }

        private void CreateEllipse()
        {
            ellipse = new Ellipse();
            ellipse.Stroke = brush;
            ellipse.Height = size;
            ellipse.Width = size;
            ellipse.Fill = new SolidColorBrush(Colors.Black);
            ellipse.Margin = new Thickness(x, y, 0, 0);
        }
    }

}
