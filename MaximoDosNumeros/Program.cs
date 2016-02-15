using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximoDosNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer valor");
            var a = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el segundo valor");
            var b = double.Parse(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine("Los números son iguales");
                Console.ReadLine();

            }

            else
            {
                double numeromayor = maxDosNumeros(a, b);
                Console.WriteLine($"El número mayor es {numeromayor}");
                Console.ReadLine();
            }
        }
        private static double maxDosNumeros(double a, double b)
        {
            //if (a > b)
            //{
            //    return a;
            //}

            //else
            //{
            //    return b;
            //}

            return a > b ? a : b;
        }



    }
}
