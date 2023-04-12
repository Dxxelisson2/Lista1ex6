using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double v1;
            double v2;
            double mediageometrica;
            Console.WriteLine("digite valor 1 ");
            v1 = double.Parse(Console.ReadLine());
            Console.WriteLine("digite valor 2 ");
            v2 = double.Parse(Console.ReadLine());
           
           

            mediageometrica = Math.Sqrt(v1 * v2);
            Console.WriteLine("media geometrica:" + mediageometrica);
        }
    }
}
