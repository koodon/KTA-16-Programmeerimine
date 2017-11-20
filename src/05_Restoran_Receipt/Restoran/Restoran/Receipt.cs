using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran
{
    public class Receipt
    {
        public string Address { get; }
        public string Name { get; }
        public Tab Tab { get; }

        public Receipt(string name, string address, Tab tab)
        {
            this.Name = name;
            this.Address = address;
            this.Tab = tab;
        }

        //public string TabValues()
        //{
        //    //var result = new List<Tab>();
        //    var result = "";
        //    foreach (var item in ?)
        //    {
        //        return result += item;
        //    }
        //}
    }
}