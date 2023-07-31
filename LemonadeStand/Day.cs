using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Day
    {
        internal Weather weather;
        internal List<Customer> customers;
        public Day()
        {
            weather = new Weather();
            customers = new List<Customer>();
        }
    }
}
