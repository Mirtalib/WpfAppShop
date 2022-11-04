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
using System.Windows.Shapes;
using WpfApp5.Fake_Data;
using WpfApp5.Models;
using WpfApp5.User_Control;

namespace WpfApp5.Veiw
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
            FakeProductRepository fakeProductRepository = new FakeProductRepository();
            UC_Product uC_Product;

            foreach (var item in fakeProductRepository.products)
            {
                uC_Product = new UC_Product();
                uC_Product.product = item;
                pnlProducts.Children.Add(uC_Product);
            }


        }

        private void btnShoping_Click(object sender, RoutedEventArgs e)
        {
            UC_Product? product;
            int total = 0;
            foreach (var item in pnlProducts.Children)
            {
                product = item as UC_Product;
                if (product is null)
                    return;
                switch (product.isAdd)
                {
                    case true:
                        total += product.product.Price;
                        break;
                    default:
                        break;
                }
            }

            MessageBox.Show(total.ToString());
        }

    }
}
