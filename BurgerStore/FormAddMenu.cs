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
    public partial class FormAddMenu : Form
    {
        public FormAddMenu()
        {
            InitializeComponent();
        }

        private void btnProdSave_Click(object sender, EventArgs e)
        {
            FormNewOrder.Menus_.Add(new Menu
            {
                Name = txName.Text,
                Price = Convert.ToDouble(numPrice.Value)
            });
            MessageBox.Show("Yeni Menü eklendi.");
        }
    }
}
