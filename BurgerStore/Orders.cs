using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerStore
{
    public class Orders
    {
        public Menu SelectedMenu { get; set; }
        public double TotalPrice { get; set; }
        public Size_ Size { get; set; }
        public int Piece { get; set; }
        public List<Extras> Extras { get; set; }
        public void CalculatePrice()
        {
            TotalPrice = SelectedMenu.Price;
            switch (Size)
            {
                case Size_.small:
                    TotalPrice += 0;
                    break;
                case Size_.medium:
                    TotalPrice *= 1.5;
                    break;
                case Size_.large:
                    TotalPrice *= 2;
                    break;
                default:
                    break;
            }
            TotalPrice *= Piece;
            foreach (var item in Extras)
            {
                TotalPrice += item.Price;
            }
        }
        public override string ToString()
        {
            string extraAdded= " ";

            foreach (var item in Extras)
            {
                extraAdded += item.Name + ",";
            }
            return ($"{SelectedMenu.Name}'den {Piece} adet,{Size} boyunda, Ekstra Malzemeler :{extraAdded}");
        }
    }
}
