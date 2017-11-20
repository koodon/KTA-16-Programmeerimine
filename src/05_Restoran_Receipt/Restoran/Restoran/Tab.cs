using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran
{
    public class Tab
    {
        public List<double> List { get; } = new List<double>();

        public void Add(double digit)
        {
            List.Add(digit);
        }

        public double All()
        {
            double value = 0;
            foreach (var item in List)
            {
                value = value + item;
            }
            return value;
        }
    }
}