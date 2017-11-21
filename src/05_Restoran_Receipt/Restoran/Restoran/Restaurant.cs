using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran
{
    public class Restaurant
    {
        public string Name { get; }
        public string Address { get; }

        public Restaurant(string name, string address)
        {
            this.Name = name;
            this.Address = address;
        }

        public Receipt GetReceipt(Tab tab)
        {
            return new Receipt(this.Name, this.Address, tab);
        }

        //public override string ToString()
        //{
        //    var sb = StringBuilder();
        //}
    }
}
