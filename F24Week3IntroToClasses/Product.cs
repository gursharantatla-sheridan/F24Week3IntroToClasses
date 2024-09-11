using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F24Week3IntroToClasses
{
    public class Product
    {
        // fields
        private int id;
        private string? _name;
        private double _price;

        // constructors
        public Product()
        {
            id = 0;
            _name = "";
            _price = 0;
        }

        public Product(int id, string name, double price)
        {
            this.id = id;
            _name = name;
            _price = price;
        }
    }
}
