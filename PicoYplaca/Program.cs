using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicoYplaca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para identificar si tiene Pico y placa o NO.");
            Console.WriteLine("Ingrese su placa");
            var placa = Console.ReadLine();
            var placaNumero = int.Parse(placa.Substring(5));
            int modPlacaNumero = placaNumero % 2;
            int dia = DateTime.Now.Day;
            int modDia = dia % 2;

            if ( modPlacaNumero == 0 && modDia == 0)

            {
                Console.WriteLine($"No puede salir el automóvil de placa {placa} ");

            }    
            else
            {
                Console.WriteLine($"Puede salir el automóvil de placa {placa} ");

            }        
            
            Console.ReadLine();

            

        }
    }
}
