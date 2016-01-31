using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCirculoRectanguloCarreta
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("Ingresar el radio de la primera llanta");
            var r = float.Parse(Console.ReadLine());
            float areaLlanta1 = areaCirculo(r);
            Console.WriteLine("Ingresar el radio de la segunda llanta");
            var r1 = float.Parse(Console.ReadLine());
            float areaLlanta2 = areaCirculo(r1);


            Console.WriteLine("Ingresar el valor de la base");
            var b = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar el valor de la altura");
            var h = float.Parse(Console.ReadLine());
            float areaMiRectangulo = areaRectangulo(b, h);
            //Console.WriteLine($"El area del rectangulo es {areaMiRectangulo}");
           
            float areaMicarreta = areaCarreta(areaMiRectangulo, areaLlanta1, areaLlanta2);
            Console.WriteLine($"El area de la carreta es {areaMicarreta}");
            Console.ReadLine();
        
        }

        private static float areaCarreta(float areaMiRectangulo, float areaLlanta1, float areaLlanta2)
        {
            float resultAreaCarreta = areaMiRectangulo + areaLlanta1 + areaLlanta2;
            return resultAreaCarreta;
        }

        private static float areaCirculo(float r)
        {
            float resultAreaCirculo = (float) Math.PI * (r*r);
            return resultAreaCirculo;

        }
        
        private static float areaRectangulo(float b, float h)
        {
        float resultAreaRectangulo = b * h;
        return resultAreaRectangulo;
        }

    }
}
