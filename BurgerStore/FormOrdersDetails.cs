using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurgerStore
{
    public partial class FormOrdersDetails : Form
    {
        public FormOrdersDetails()
        {
            InitializeComponent();
        }
        public static List<Orders> paidOrders = new List<Orders>();
        double totalIncome = 0;
        double numberOfSold = 0;
        double extraInncome = 0;
        private void FormOrdersDetails_Load(object sender, EventArgs e)
        {
            foreach (var item in paidOrders)
            {
                totalIncome += item.TotalPrice;
                numberOfSold += item.Piece;
                foreach (var item2 in item.Extras)
                {
                    extraInncome = item2.Price;
                }
                lbAllOrders.Items.Add(item);
            }
            lblCiro.Text= totalIncome.ToString();
            lblNumOfSold.Text= numberOfSold.ToString();
            lblextra.Text = extraInncome.ToString();
            lblTotalNumOrder.Text = lbAllOrders.Items.Count.ToString();
        }
    }
}
