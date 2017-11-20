using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Procent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Allahindluse kalkulaator");
            Console.WriteLine();
            Console.Write("Sisesta summa: ");
            int input = int.Parse(Console.ReadLine());

            double value = 0;
            double percent = 0;

            if (input < 50 && input > 0)
            {
                percent = 0;
            }
            if (input > 50 && input < 250)
            {
                percent = 5;
                value = input * 0.05;
            }
            if (input > 250 && input < 500)
            {
                percent = 10;
                value = input * 0.10;
            }
            if (input > 500)
            {
                percent = 20;
                value = input * 0.20;
            }
            Console.WriteLine($"Allahindluse arvutuskäik: {input} - {percent}% = {input - value}");
            Console.ReadLine();
        }
    }
}