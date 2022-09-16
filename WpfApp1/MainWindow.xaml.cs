using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using WpfApp1.Entities;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Products> Products { get; set; }=new ObservableCollection<Products>(){ };

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            Products product = new Products();
            product.Pname = "Table";
            product.Pprice = "12";
            product.Pimg = new BitmapImage(new Uri(@"C:\Users\Huseyn\source\repos\WpfApp1\WpfApp1\images\Table-PNG-File.png"));
            Products.Add(product);
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
