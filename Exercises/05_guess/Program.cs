using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_guess
{
    class Program
    {
        static void Main(string[] args)
        {
            int nr = 40;
            Console.WriteLine("Ma valin välja ühe suvalise numbri [1-100]. Proovi see ära arvata");
            Console.Write("Sina pakud: ");
            int input = int.Parse(Console.ReadLine());            

            if (input > nr)
            {
                Console.WriteLine("Sinu valitud number on suurem!");
            }
            if (nr > input)
            {
                Console.WriteLine("Sinu valitud number on väiksem!");
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
    }
}
