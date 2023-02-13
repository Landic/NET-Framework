using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_11_NET
{
    internal class Program
    {
        static void Task1()
        {
            Money obj = new Money(20, 20);
            Money obj2 = new Money(20, 20);
            Console.WriteLine(obj);
            obj = obj + obj2;
            Console.WriteLine(obj);
            Product obj3 = new Product(obj);
            Console.WriteLine(obj3);
            obj3 = obj3 - 3;
            Console.WriteLine(obj3);
        }

        static void Task2()
        {
            Device[] obj = new Device[4];
            obj[0] = new Car("Nissan", "1200 HP, rezina sliki");
            obj[0].Sound();
            obj[0].Show();
            obj[0].Desc();
            obj[1] = new Kettle("Bosch", "Perfectly boils everyone will envy");
            obj[1].Sound();
            obj[1].Show();
            obj[1].Desc();
            obj[2] = new Microwave("Samsung", "Heats so that a fire can start");
            obj[2].Sound();
            obj[2].Show();
            obj[2].Desc();
            obj[3] = new Steamer("Teplohod", "Floats and does not sink");
            obj[3].Sound();
            obj[3].Show();
            obj[3].Desc();
        }

        static void Task3()
        {
            MusicalInstrument[] obj = new MusicalInstrument[4];
            obj[0] = new Violin("Violin", "Instrument");
            obj[0].Sound();
            obj[0].Show();
            obj[0].Desc();
            obj[0].History();
            obj[1] = new Trombone("Trombone", "Instrument");
            obj[1].Sound();
            obj[1].Show();
            obj[1].Desc();
            obj[1].History();
            obj[2] = new Ukulele("Ukulele", "Instrument");
            obj[2].Sound();
            obj[2].Show();
            obj[2].Desc();
            obj[2].History();
            obj[3] = new Cello("Cello", "Instrument");
            obj[3].Sound();
            obj[3].Show();
            obj[3].Desc();
            obj[3].History();
        }

        static void Task4()
        {
            Worker[] obj = new Worker[4];
            obj[0] = new President("Joe Baiden", 80, 3);
            obj[0].Print();
            obj[1] = new Security("Oleg", 25, "Factory");
            obj[1].Print();
            obj[2] = new Manager("Andrey", 40, 10);
            obj[2].Print();
            obj[3] = new Engineer("Jack", 20, "Сoffee machine");
            obj[3].Print();
        }

        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            Task4();
        }
    }
}
