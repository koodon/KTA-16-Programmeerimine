using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Calc_Plus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mina olen kalkulaatori programm. Ütle mulle 2 numbrit ja ma ütlen Sulle nende summa");
            Console.Write("Esimene number: ");
            string input = Console.ReadLine();
            int arv1 = int.Parse(input);
            Console.Write("Teine number: ");
            string input2 = Console.ReadLine();
            int arv2 = int.Parse(input2);
            Console.WriteLine("Summaks on: " + (arv1 + arv2));

            Console.WriteLine("Press any key to continue");
            Console.ReadLine();


        }
    }
}
