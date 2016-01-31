using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)

        {
            int i = 8;
            float f = 8.0f;
            string s = "8";
            i.ToString();
            var sf = s + f.ToString();
            var r = float.Parse(sf);
            var isf = int.Parse(sf);
            var fuck = r.ToString() + s;
            var refuck = float.Parse(fuck);
            var refucker = i + refuck;
            Console.WriteLine(refucker.ToString());
            Console.WriteLine(refucker.GetType().ToString());
            Console.WriteLine(refuck.GetType().ToString());
            Console.ReadLine();
        }
    }
}

