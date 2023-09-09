using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_LAB_6_NET
{
    internal class Program
    {
        static void Task1()
        {
            Human[] obj = new Human[3];
            obj[0] = new Builder("Oleg", 25, "House");
            obj[1] = new Sailor("Vasya", 30, "Atlantic");
            obj[2] = new Pilot("Joe", 40, "Ukraine");
            foreach(Human n in obj)
            {
                Console.WriteLine(n);
            }
            obj[0].Input();
            obj[1].Input();
            obj[2].Input();
            foreach(Human n in obj)
            {
                Console.WriteLine(n);
            }
        }

        static void Task2()
        {
            Passport[] obj = new Passport[2];
            obj[0] = new ForeignPassport("Joe", "Baiden", "Male", "USA", "20.11.1942", 123456, "Poland");
            obj[1] = new Passport("Barack", "Obama", "Male", "USA", "4.08.1961");
            foreach(Passport i in obj)
            {
                Console.WriteLine(i);
            }
        }

        static void Task3()
        {
            Animal[] obj = new Animal[3];
            obj[0] = new Tiger("Tiger", "Sharp teeth");
            obj[1] = new Crocodile("Crocodile", "Lives in the swamp");
            obj[2] = new Kangaroo("Kangaroo", "Has strong legs");
            foreach(Animal i in obj)
                Console.WriteLine(i);
        }

        static void Task4()
        {
            Figure[] obj = new Figure[4];
            obj[0] = new Rectangle(2, 6);
            Console.WriteLine("Square rectangle -> " + obj[0].Square());
            obj[1] = new Circle(4);
            Console.WriteLine("Square circle -> " + obj[1].Square());
            obj[2] = new RightTriangle(3, 7);
            Console.WriteLine("Square right triangle -> " + obj[2].Square());
            obj[3] = new Trapeze(2, 5);
            Console.WriteLine("Square trapeze -> " + obj[3].Square());

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
