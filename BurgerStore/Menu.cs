using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerStore
{
    public class Menu:BaseProduct
    {
        public Menu()
        {

        }
        public Menu(string name, double price)
        {
          Name = name;
           Price = price;
        }
    }
}
