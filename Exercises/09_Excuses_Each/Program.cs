using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Excuses
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] excuses = new[] { "Koer sõi kodutöö ära", "Ema ei luba arvutit kasutada", "Mingi tekst veel" };

            int i = 0;
            foreach (var excuse in excuses)
            {
                Console.WriteLine($"{i + 1}. {excuses[i]}");
                i++;
            }
            Console.ReadLine();
        }
    }
}
