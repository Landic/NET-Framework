using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_21_NET
{
    interface ITypeShop
    {
        void Type(string type);
    }

    class FoodShop : ITypeShop
    {
        public void Type(string type)
        {
            type = "Shop food";
        }
    }

    class HousewifelyShop : ITypeShop
    {
        public void Type(string type)
        {
            type = "Shop housewifely";
        }
    }

    class ClothesShop : ITypeShop
    {
        public void Type(string type)
        {
            type = "Shop clothes";
        }
    }

    class ShoesShop : ITypeShop
    {
        public void Type(string type)
        {
            type = "Shop shoes";
        }
    }

    internal class Shop : IDisposable
    {
        string nameshop;
        string adress;
        string type;

        public Shop()
        {
            nameshop= string.Empty;
            adress= string.Empty;
            type= string.Empty;
        }

        public Shop(string nameshop, string adress)
        {
            this.nameshop = nameshop;
            this.adress = adress;
        }

        public void Type(ITypeShop shop)
        {
            shop.Type(type);
        }

        public override string ToString()
        {
            return $"Name shop -> {nameshop}\nAdress -> {adress}\nType -> {type}\n";
        }

        public void Dispose()
        {
            Console.WriteLine("Dispose");
        }

        ~Shop()
        {
            Console.WriteLine("Finalize");
        }
    }
}
