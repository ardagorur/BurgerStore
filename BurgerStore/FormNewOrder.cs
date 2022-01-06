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
        public static List<Menu> Menus = new List<Menu>()
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
        private void FormNewOrder_Load(object sender, EventArgs e)
        {
            foreach (var item in Menus)
            {
                cbMenu.Items.Add(item);
            }
            cbMenu.DisplayMember = "Name";
            foreach (var item in Extras)
            {
                flpextra.Controls.Add(new CheckBox { Text = item.Name });
            }
            cbMenu.SelectedIndex = 0;
            rbLarge.Checked =true ;
        }

        private void btnAddMenu_Click(object sender, EventArgs e)
        {
            Orders newOrder = new Orders();
            List<Extras> addedExtra = new List<Extras>();
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
            foreach (CheckBox item in flpextra.Controls)
            {
                if (item.Checked)
                {
                    addedExtra.Add((Extras)item.Tag);
                }
            }
            newOrder.Piece = Convert.ToInt32(numPiece.Value);           
            newOrder.CalculatePrice();
            lbMenu.Items.Add(newOrder.SelectedMenu.Name);
            lblTotalPrice.Text = newOrder.TotalPrice.ToString();
        }
    }
}
