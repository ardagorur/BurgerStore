using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerStore
{
    public class Extras:BaseProduct
    {
        public Extras()
        {

        }
        public Extras(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
