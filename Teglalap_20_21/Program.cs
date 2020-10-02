using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teglalap_20_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mekkorák a téglalap oldalai?");
            Console.WriteLine("a oldal?");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("b oldal?");
            int b = int.Parse(Console.ReadLine());

            int kerulet = 2 * (a + b);
            int terulet = a * b;

            Console.WriteLine("Kerület: " + kerulet);
            Console.WriteLine("Terület: " + terulet);

            Console.ReadLine();
        }
    }
}
