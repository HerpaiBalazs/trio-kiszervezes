using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ricsi;
using beto;

namespace marc
{
    class Program
    {
        static void Main(string[] args)
        {
            ricsi.csempe csempe = new ricsi.csempe();
            beto.fal fal = new beto.fal();

            Console.Write("Szoba hossza: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Szoba szélessége: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Szoba magassága: ");
            int num3 = int.Parse(Console.ReadLine());

            int festek = fal.fall(num1, num2, num3);
            int csemp = csempe.csemp(num1, num2);

            Console.WriteLine($"A szobához {festek} m2 festékre van szükség és {csemp} m2 csempére");
        }
    }
}
