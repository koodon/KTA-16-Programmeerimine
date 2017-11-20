using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestorantReceipt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Taco Palenque");
            Console.WriteLine("1200 Main ST.");
            Console.WriteLine("-------------------------------------------------");

            double total = 0;

            while (true)
            {
                Console.Write("Enter price of food item [-1 to quit]: ");
                string input = Console.ReadLine();
                double value = int.Parse(input);

                if (value == -1)

                    break;
                total += value;
            }

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine($"Subtotal: {total}");
            Console.WriteLine($"15.00 % Gratuity: {total * 0.15:F2}");
            Console.WriteLine($"Total: {total - (total * 0.15):f2}");
            Console.WriteLine("Press any key to continue");

            Console.ReadLine();
        }
    }
}
