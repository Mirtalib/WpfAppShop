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
using WpfApp5.Models;

namespace WpfApp5.Veiw
{
    /// <summary>
    /// Interaction logic for EditProduct.xaml
    /// </summary>
    public partial class EditProduct : Window
    {
        public Product? product { get; set; }

        public EditProduct()
        {
            InitializeComponent();
            DataContext = this;
        }
    }
}
