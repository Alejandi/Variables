using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ley_de_Coulomb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("En este programa vamos a calcular el valor de fuerza (F) utilizados la Ley de Coulomb");
            Console.WriteLine("Ingrese el valor de la carga 1 (Q1)");
            var Q1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de la carga 2 (Q2)");
            var Q2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el varlor de la distancia (r)");
            var r1 = double.Parse(Console.ReadLine());        
            double k = 9 * Math.Pow(10, -9);
            double f = k *((Q1*Q2)/ (r1*r1));
            Console.WriteLine($"El valor de la fuerza es: {f}");
            Console.ReadLine();  
        }
    }
}
