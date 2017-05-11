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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        Bankrekening b1 = new Bankrekening();
        
        public MainWindow()
        {
            
            InitializeComponent();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            int aGeld = Convert.ToInt16(addText.Text);
            
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {

        }


    }
}
