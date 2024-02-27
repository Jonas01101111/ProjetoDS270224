using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inversão //inversão de variaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("valor a:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("valor b:");
            int b = int.Parse(Console.ReadLine());


            int ib = a;
            a = b;
            b = ib;

            Console.WriteLine("A:" + a);
            Console.WriteLine("B:" + b);

            Console.ReadKey();

        }
    }
}
