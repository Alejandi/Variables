using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpresionImpares
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[] { 1, 2, 3, 4, 8, 7 };
            for (int i = 0; i <= 5; i++)
            {
                if (numeros[i] % 2 == 1)
                {
                    for (int j = 0; j < i + 1; j++)

                    {
                        Console.Write(numeros[i]);

                    }
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }

    }
}
