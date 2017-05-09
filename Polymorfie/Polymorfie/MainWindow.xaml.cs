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

namespace Polymorfie
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Ellipse ellip = new Ellipse();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void knop_Click(object sender, RoutedEventArgs e)
        {
            Square vierkant = new Square(210, 170);
            RandomPositionedSquare vierkant2 = new RandomPositionedSquare();
            Circle cirkel = new Circle(100, 100);
            RandomPositionedCircle cirkel2 = new RandomPositionedCircle();
            Triangle driehoek = new Triangle(20, 20);
            List<Shape> group = new List<Shape>();

            /*group.Add(cirkel);
            group.Add(vierkant);
            group.Add(driehoek);*/
            group.Add(vierkant2);
            group.Add(cirkel2);

            foreach (Shape shape in group)
            {
                shape.DisplayOn(canvas);
            }
        }
    }
}
