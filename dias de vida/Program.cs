using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dias_de_vida// calcula quantos dias foram vividos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe sua idade em anos");
            int anos = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe sua idade em meses");
            int meses = int.Parse(Console.ReadLine());

            Console.WriteLine("informe sua idade em dias");
            int dias = int.Parse(Console.ReadLine());

            dias = dias + (anos * 365) + (meses * 30);
            Console.WriteLine();
            

            Console.WriteLine("Dias vividos: " +  dias);
            Console.ReadKey();  
        }
    }
}
