using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Session3
    {
        public static void Main3()
        {
            Ex01();
            //Ex02();
            //Ex03();
        }
        public static void Ex01()
        {
            bool kq;
            while (kq = true)
            {
                Console.Write("Enter Celcius degree: C= ");
                float C = float.Parse(Console.ReadLine());
                if (C >= -273)
                {
                    float K = C + 273;
                    float F = C * 18 / 10 + 32;
                    Console.WriteLine(" Convert to Kelvin: K= " + K);
                    Console.WriteLine(" Convert to Fahrenheit: F=" + F);
                    break;
                }
                else
                {
                    Console.WriteLine("Hieu");
                    kq = true;
                }
            }
        }
        public static void Ex02()
        {
            bool kq2;
            while (kq2 = true)
            {
                Console.Write("Enter radius: r= ");
                double r = double.Parse(Console.ReadLine());
                if (r > 0)
                {
                    double S = 4 * r * Math.PI;
                    double V = 4 / 3 * r * r * r * Math.PI;
                    Console.WriteLine("Square: S= " + S);
                    Console.WriteLine("Volume: V= " + V);
                    break;
                }
                else
                {
                    Console.WriteLine("Ban kinh ma be hon 0 ? Ngu a?");
                    kq2 = true;
                }
            }
        }

        static void Ex03()
        {
            Console.Write("Enter a: a= ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter b: b= ");
            double b = double.Parse(Console.ReadLine());
            double add = a + b;
            double sub = a - b;
            double mul = a * b;
            double div = a / b;
            double mod = a % b;
            Console.WriteLine("a+b = " + add);
            Console.WriteLine("a-b = " + sub);
            Console.WriteLine("axb = " + mul);
            Console.WriteLine("a:b = " + div);
            Console.WriteLine("a mod b = " + mod);

        }
    }
}