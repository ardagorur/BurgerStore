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
    public partial class FormAddExtra : Form
    {
        public FormAddExtra()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormNewOrder.Extras.Add(new Extras
            {
                Name = txName.Text,
                Price = Convert.ToDouble(numPrice.Value)
            });
            MessageBox.Show("Ekstra başarıyla kaydedildi.");
        }
    }
}
