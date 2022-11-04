using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
using WpfApp5.Models;
using WpfApp5.Veiw;

namespace WpfApp5.User_Control
{

    public partial class UC_Product : UserControl , INotifyPropertyChanged
    {
        public bool isAdd = false;
        public bool isFavorite = false;
        public Product? product { get; set; }
        public event PropertyChangedEventHandler? PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public UC_Product()
        {
            InitializeComponent();
            DataContext = this;
        }


        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            EditProduct editProduct = new();
            editProduct.product = product;
            editProduct.ShowDialog();
        }

        private void btnFavorite_Click(object sender, RoutedEventArgs e)
        {
            if (isFavorite is false)
                isFavorite = true;
            else
                isFavorite = false;
        }


        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

            switch (isAdd)
            {
                case false:
                    isAdd = true;
                    btnAdd.Background = new SolidColorBrush(Colors.White);
                    btnAdd.Foreground = new SolidColorBrush(Colors.Black);
                    MessageBox.Show("The product has been added", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    break;
                case true:
                    isAdd = false;
                    btnAdd.Background = new SolidColorBrush(Colors.DarkOrange);
                    btnAdd.Foreground = new SolidColorBrush(Colors.White);
                    MessageBox.Show("Product Removed from List", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    break;
                default:
            }
        }

        private void UserControl_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ShowProduct showProduct = new ShowProduct();
            showProduct.product = product;
            showProduct.ShowDialog();
        }


        private string? _someText;

        public string? SomeText
        {
            get => _someText;
            set
            {
                _someText = value;
                NotifyPropertyChanged();
            }
        }
    }
}
