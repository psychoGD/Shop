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

namespace WpfApp1
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
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in LeftMenu_WrapPanel.Children)
            {
                if(item is Button)
                {
                    var item2 = item as Button;
                    if (item2.Foreground == Brushes.Black)
                    {
                        item2.Foreground = Brushes.Gray;
                    }
                }
            }
            
            var sender2 = sender as Button;
            sender2.Foreground = Brushes.Black;
        }
    }
}
