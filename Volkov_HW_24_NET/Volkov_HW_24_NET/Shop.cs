using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_24_NET
{
    internal class Shop
    {
        string product;
        double price;
        string date;
        
        public string Product
        {
            get { return product; }
            set { product = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        public Shop()
        {
            product= string.Empty;
            price= 0;
            date = string.Empty;
        }

        public Shop(string product, double price, string date)
        {
            this.product = product;
            this.price = price;
            this.date = date;
        }
    }
}
