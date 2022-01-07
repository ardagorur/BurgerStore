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
    public partial class FormNewOrder : Form
    {
        public FormNewOrder()
        {
            InitializeComponent();
        }
        public static List<Menu> Menus_ = new List<Menu>()
        {
            new Menu("asd",12),
            new Menu("asdda",123)
        };
        public static List<Extras> Extras = new List<Extras>()
        {
            new Extras("dsa",1),
            new Extras("das",2),
            new Extras("fd",3)
        };
        public static List<Orders> Orders = new List<Orders>();
        public static List<Orders> CurrentOrder = new List<Orders>();
        
        private void FormNewOrder_Load(object sender, EventArgs e)
        {
            foreach (var item in Menus_)
            {
                cbMenu.Items.Add(item);
            }
            cbMenu.DisplayMember = "Name";
            foreach (var item in Extras)
            {
                flpextra.Controls.Add(new CheckBox { Text = item.Name, Tag = item});
            }
            cbMenu.SelectedIndex = 0;
            rbLarge.Checked =true ;
        }

        private void btnAddMenu_Click(object sender, EventArgs e)
        {
            Orders newOrder = new Orders();

            newOrder.SelectedMenu = (Menu)cbMenu.SelectedItem;
            if (rbSmall.Checked)
            {
                newOrder.Size = Size_.small;
            }
            else if (rbMedium.Checked)
            {
                newOrder.Size = Size_.medium;
            }
            else
            {
                newOrder.Size = Size_.large;
            }
            newOrder.Extras = new List<Extras>();
            foreach (CheckBox item in flpextra.Controls)
            {
                if (item.Checked)
                {
                    newOrder.Extras.Add((Extras)item.Tag);
                }
            }
            newOrder.Piece = Convert.ToInt32(numPiece.Value);           
            newOrder.CalculatePrice();
            
            CurrentOrder.Add(newOrder);
            lbMenu.Items.Add(newOrder.ToString());
            totalPrice();
        }
        public double totalPrice()
        {
            double billTotal = 0;

            //for (int i = 0; i < lbMenu.Items.Count; i++)
            //{
            //    Orders orders = (Orders)lbMenu.Items[i];
            //    billTotal += orders.TotalPrice;
            //}
            foreach (Orders item in CurrentOrder)
            {
                billTotal += item.TotalPrice;
            }
            lblTotalPrice.Text = billTotal.ToString();
            return billTotal;
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Sipariş ücreti: " + totalPrice().ToString() + "Satın almak için ","Şipraiş Sonucu", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                MessageBox.Show("Siparişiniz Başarılı şekilde tamamlandı.");
                foreach (var item in CurrentOrder)
                {
                    FormOrdersDetails.paidOrders.Add(item);
                }
                lbMenu.Items.Clear();
                CurrentOrder.Clear();
            }
            else
            {
                MessageBox.Show("Sipraiş iptal edildi.");
                lbMenu.Items.Clear();
                CurrentOrder.Clear();
            }

        }
    }
}
