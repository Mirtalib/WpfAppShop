using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp5.Models;

namespace WpfApp5.Fake_Data
{
    public class FakeProductRepository
    {


        public List<Product> products { get; set; } = new List<Product>()
        {

             new(1, "Ihpone 11 128Gb", 1200, DateTime.Now),
             new(2, "Ihpone 12 128Gb", 1600, DateTime.Now),
             new(3, "MacBook", 3000, DateTime.Now),
             new(3, "Samsung Galaxy A51 ", 550, DateTime.Now),
             new(6, "xiaomi Mi 11 56Gb", 899, DateTime.Now),
        };




    }
}
