using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gasolina //custo de combustivel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quanto custa o litro do combustivel?");
            double litro = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantos KM o veículo faz por litro?");
            double eficiencia = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantos KMs irão ser percorridos?");
            double distancia = double.Parse(Console.ReadLine());

            double res = litro * (distancia / eficiencia);

            Console.WriteLine("Custo da viagem: R$" +  res);
            Console.ReadKey();
        }
    }
}
