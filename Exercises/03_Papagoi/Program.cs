using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Papagoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mina olen papagoi programm ja ma kordan selle Sulle tagasi...");
            Console.Write("Sina ütled: ");
            string input = Console.ReadLine();
            Console.WriteLine("Mina ütlen: " + input);
            Console.ReadLine();
        }
    }
}
