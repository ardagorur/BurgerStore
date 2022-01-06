using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerStore
{
    public abstract class BaseProduct
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
