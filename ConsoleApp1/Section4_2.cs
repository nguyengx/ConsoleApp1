using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nguyen_31231026008
{
    internal class Section4
    {
        public static void Main4()
        {
            Ex01();

        }
         static void Ex01()
        {
            Console.Write("Nhap chieu dai canh thu nhat: a=");
            double a=double.Parse(Console.ReadLine());
            Console.Write("Nhap chieu dai canh thu hai: b= ");
            double b=double.Parse(Console.ReadLine());
            Console.Write("Nhap chieu dai canh thu ba: c= ");
            double c=double.Parse(Console.ReadLine());
            if ((a == b) || (b == c) || (c == a))
            {
                if ((a ==b) && (b == c) && (c == a))
                {
                    Console.WriteLine("Tam giac deu");
                }
                else
                {
                    Console.WriteLine("Tam giac can");
                }           
            }
            else
            {
                Console.WriteLine("Tam giac thuong");
            }   

        }
    }
}
