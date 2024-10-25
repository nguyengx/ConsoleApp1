using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nguyen_31231026008
{
    internal class Section4_1
    {
        public static void Main()
        {
            Ex03();
        }
        public static void Ex02()
        {
            int x;
            for (int i = -5; i <= 5; i++)
            {
                x = i * i + 2 * i + 1;
                Console.WriteLine(x);
            }
        }
        public static void Ex03()
        {
            Console.Write("Enter distance(km): s= ");
            double s = double.Parse(Console.ReadLine());
            Console.Write("Enter time:");
            Console.Write("hours= ");
            double hours= double.Parse(Console.ReadLine());
            Console.Write("minutes= ");
            double minutes= double.Parse(Console.ReadLine());
            Console.Write("seconds= ");
            double seconds= double.Parse(Console.ReadLine());
            double h;
            h = hours + minutes / 60 + seconds / 3600;
            double kph;
            double mph;
            kph = s / h;
            mph = (s / 1.609334) / h;
            Console.WriteLine("kph= " + kph);
            Console.WriteLine("mph= " + mph);
            Console.ReadKey();      
        }
        public static void Ex05()
        {
            Console.Write("Enter your char: ");
            char x=char.Parse(Console.ReadLine());
            switch;
        }
    }
}
