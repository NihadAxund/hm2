using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.DB
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public double Coust { get; set; }
    
        public Product(string name, string country, double coust)
        {
            Name = name;
            Country = country;
            Coust = coust;
        }
        public Product()
        {

        }


    }
}
