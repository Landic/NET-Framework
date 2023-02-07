using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_7_NET
{
    internal class Vector
    {
        private double x;
        private double y;
        private double z;

        public Vector()
        {
            x = 0;
            y = 0;
            z = 0;
        }

        public Vector(int x)
        {
            this.x = x;
        }

        public Vector(int x, int y, int z) : this(x)
        {
            this.y = y;
            this.z = z;
        }

        public void Input()
        {
            Console.WriteLine("Enter X");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Z");
            z = Convert.ToDouble(Console.ReadLine());
        }

        public override string ToString()
        {
            return $"X = {x}\tY = {y}\tZ = {z}";
        }

        public double X
        {
            get;set;
        }

        public double Y
        {
            get; set;
        }

        public double Z
        {
            get; set;
        }

        public double LengthVector()
        {
            
            double length_vector = 0;
            length_vector = ( Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2) ) / 2;
            return length_vector;
        }

        public void IncreaseByScalar(int number)
        {
            x *= number;
            y *= number;
            z *= number;
        }

        public void ReductionByScalar(int number)
        {
            x /= number;
            y /= number;
            z /= number;
        }

        public Vector AddVector(Vector obj)
        {
            Vector obj2 = new Vector();
            obj2.x = x + obj.x;
            obj2.y = y + obj.y;
            obj2.z = z + obj.z;
            return obj2;
        }

        public Vector SubtractionVector(Vector obj)
        {
            Vector obj2 = new Vector();
            obj2.x = x - obj.x;
            obj2.y = y - obj.y;
            obj2.z = z - obj.z;
            return obj2;
        }

        public Vector MultiplicationVector(Vector obj)
        {
            Vector obj2 = new Vector();
            obj2.x = x * obj.x;
            obj2.y = y * obj.y;
            obj2.z = z * obj.z;
            return obj2;
        }

        public double ScalarProduct(Vector obj)
        {
            double summa = x * obj.x + y * obj.y + z * obj.z;
            return summa;
        }

        public double AngleDetection(Vector obj)
        {
            double scalar = 0, length1 = 0, length2 = 0;
            double angle = 0;
            scalar = ScalarProduct(obj);
            length1 = LengthVector();
            length2 = obj.LengthVector();
            angle = (length1 - length2) / scalar;
            return angle;
        }

        public bool Equality(Vector obj)
        {
            if(x == obj.x && y == obj.y && z == obj.z) 
                return true;
            return false;
        }
    }
}
