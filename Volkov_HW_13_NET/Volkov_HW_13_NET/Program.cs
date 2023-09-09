using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Volkov_HW_13_NET
{
    internal class Program
    {
        struct Vector3D
        {
            private double x;
            private double y;
            private double z;

            public Vector3D(double x, double y, double z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }

            public override string ToString()
            {
                return $"xyz -> <{x}, {y}, {z}>\n";
            }

            public static Vector3D operator *(Vector3D a, double b)
            {
                Vector3D result = new Vector3D();
                result.x = a.x * b;
                result.y = a.y * b;
                result.z = a.z * b;
                return result;
            }

            public static Vector3D operator +(Vector3D a, Vector3D b)
            {
                Vector3D result = new Vector3D();
                result.x = a.x + b.x;
                result.y = a.y + b.y;
                result.z = a.z + b.z;
                return result;
            }

            public static Vector3D operator -(Vector3D a, Vector3D b)
            {
                Vector3D result = new Vector3D();
                result.x = a.x - b.x;
                result.y = a.y - b.y;
                result.z = a.z - b.z;
                return result;
            }
        }

        struct DecimalNumber
        {
            private int number;

            public DecimalNumber(int number)
            {
                this.number = number;
            }

            public override string ToString()
            {
                return $"number -> {number}";
            }

            public string BinarySystem()
            {
                string temp = null;
                int temp2 = 0;
                while (number > 0)
                {
                    temp2 = number % 2;
                    number = number / 2;
                    temp += Convert.ToString(temp2);

                }
                char[] temp3 = temp.ToCharArray();
                Array.Reverse(temp3);
                return new string(temp3);
            }

            public string OctalSystem()
            {
                string temp = null;
                int temp2 = 0;
                while (number > 0)
                {
                    temp2 = number % 8;
                    number = number / 8;
                    temp += Convert.ToString(temp2);
                }
                char[] temp3 = temp.ToCharArray();
                Array.Reverse(temp3);
                return new string(temp3);
            }

            public string HexadecimalSystem()
            {
                string temp = null;
                int temp2 = 0;
                while (number > 0)
                {
                    temp2 = number % 16;
                    number = number / 16;
                    temp += Convert.ToString(temp2);
                }
                char[] temp3 = temp.ToCharArray();
                Array.Reverse(temp3);
                return new string(temp3);
            }
        }

        public struct CMYK
        {
            
            public int C { get; set; }
            public int M { get; set; }
            public int Y { get; set; }
            public int K { get; set; }
            public CMYK(int C, int M, int Y, int K)
            {
                this.C = C;
                this.M = M;
                this.Y = Y;
                this.K = K;
            }
            public override string ToString()
            {
                return $"{C}% {M}% {Y}% {K}%";
            }
        }

        struct RGBCloros
        {
            private int r;
            private int g;
            private int b;
            
            public RGBCloros(int r, int g, int b)
            {
                this.r = r;
                this.g = g;
                this.b = b;
            }

            public override string ToString()
            {
                return $"RGB -> {r}.{g}.{b}";
            }

            public string HEX()
            {
                return $"HEX -> {r.ToString("X2")}{g.ToString("X2")}{b.ToString("X2")}\n";
            }

            static double Clamp(double a) 
            {
                if (a < 0 || double.IsNaN(a))
                    a = 0;
                return a;
            }

            public CMYK CMYK() 
            {
                double r1 = r / 255F;
                double g1 = g / 255F;
                double b1 = b / 255F;
                double k = Clamp(1 - Math.Max(Math.Max(r1, g1), b1));
                double c = Clamp((1 - r1 - k) / (1 - k));
                double m = Clamp((1 - g1 - k) / (1 - k));
                double y = Clamp((1 - b1 - k) / (1 - k));
                k = Math.Round(k * 100);
                c = Math.Round(c * 100);
                m = Math.Round(m * 100);
                y = Math.Round(y * 100);
                return new CMYK((int)c, (int)m, (int)y, (int)k);
            }
        }


        static void Main(string[] args)
        {
            #region task1
            //Vector3D obj = new Vector3D(2,4,7);
            //Console.WriteLine(obj);
            //Vector3D obj2 = new Vector3D(6, 2, 8);
            //Console.WriteLine(obj2);
            //obj *= 2;
            //Console.WriteLine(obj);
            //obj += obj2;
            //Console.WriteLine(obj);
            //obj2 -= obj;
            //Console.WriteLine(obj2);
            #endregion

            #region task2
            //DecimalNumber obj = new DecimalNumber(20);
            ////Console.WriteLine(obj.BinarySystem());
            ////Console.WriteLine(obj.OctalSystem());
            //Console.WriteLine(obj.HexadecimalSystem());
            #endregion

            #region task3
            RGBCloros obj = new RGBCloros(50, 168, 82);
            Console.Write(obj.CMYK());
            #endregion
        }
    }
}
