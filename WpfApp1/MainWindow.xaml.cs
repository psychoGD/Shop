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
using System.Windows.Media.Effects;
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
            Products products = new Products();
            products.ProductName.Content = "Table";
            products.ProductPrice.Content = "57";
            //products.ProductImage.Source = ;
            

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

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Grid_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void SearchTxtBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (SearchTxtBox.Text.Length <= 0)
            {
                SearchTxtBox.Text = "Search Product";
                SearchTxtBox.Foreground = Brushes.Gray;
            }
        }

        private void SearchTxtBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (SearchTxtBox.Text == "Search Product")
            {
                var sender2 = sender as TextBox;
                sender2.Text = "";
                sender2.Foreground = Brushes.Black;
            }
        }

        private void AddProductButton_Click(object sender, RoutedEventArgs e)
        {
            SecondMainGrid.Effect = new BlurEffect();

            UserControls.AddProduct addProduct = new UserControls.AddProduct();
            addProduct.Width = 400;
            addProduct.Height = 300;
            this.MainGrid.Children.Add(addProduct);

        }
    }
}
