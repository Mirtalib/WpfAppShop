using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5.Models
{
    public class Product
    {

        public decimal Id { get; set; }
        public string? Image { get; set; }
        public string? Name { get; set; }
        public int Price { get; set; }
        public DateTime DateTime { get; set; }
        public Product(decimal id, string? name, int price, DateTime dateTime)
        {
            Id = id;
            Name = name;
            Price = price;
            DateTime = dateTime;
        }
    }
}
