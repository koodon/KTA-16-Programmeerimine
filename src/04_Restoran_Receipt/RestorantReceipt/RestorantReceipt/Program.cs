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

            int subTotal = 0;

            while (true)
            {
                Console.Write("Enter price of food item [-1 to quit]: ");
                string input = Console.ReadLine();
                int value = int.Parse(input);
                subTotal = subTotal + value;

                if (value == -1)
                {
                    break;
                }
                int gratuity = 0;
                int total = 0;
                Console.WriteLine("Subtotal: " + subTotal);
                Console.WriteLine("15.00 % Gratuity: " + gratuity);
                Console.WriteLine("Total: " + total);
                Console.WriteLine("Press any key to continue");

                Console.ReadLine();
            }
        }
    }
}
