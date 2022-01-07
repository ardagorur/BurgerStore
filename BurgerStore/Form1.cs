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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void menüEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddMenu frmmenu = new FormAddMenu();
            formdoldur(frmmenu);
        }

        private void ekstraEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddExtra frmextra = new FormAddExtra();
            formdoldur(frmextra);
        }

        private void siparişEkranıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNewOrder formNewOrder = new FormNewOrder();
            formdoldur(formNewOrder);
        }

        private void siparişBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOrdersDetails formOrdersDetails = new FormOrdersDetails();
            formdoldur(formOrdersDetails);
        }
        private Form formdoldur(Form form)
        {

            foreach (Form frm in this.MdiChildren)
            {
                if (frm != form)
                {
                    frm.Dispose();
                    frm.Close();
                }
            }
            form.MdiParent = this;
            //form.MdiParent.Size = form.Size;
            form.Dock = DockStyle.Fill;
            form.StartPosition = FormStartPosition.CenterParent;
            form.Show();
            return form;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
