using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniPOS
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void ShowChildForm(Form fm)
        {
            //teamos
            fm.Dock = DockStyle.Fill;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;

            panel_Container.Controls.Clear();
            panel_Container.Controls.Add(fm);
            fm.Show();
        }
        private void customerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CRM.FormCustomer fm = new CRM.FormCustomer();
            ShowChildForm(fm);
        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HR.Staff.FormStaff fm = new HR.Staff.FormStaff();
            ShowChildForm(fm);
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventory.Product.FormProduct fm = new Inventory.Product.FormProduct();
            ShowChildForm(fm);
        }

        private void product1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventory.Product1.FormProduct fm = new Inventory.Product1.FormProduct();
            ShowChildForm(fm);
        }

        private void saleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            POS.FormSale fm = new POS.FormSale();
            this.Hide();
            fm.ShowDialog();
            this.Show();
        }
    }
}
