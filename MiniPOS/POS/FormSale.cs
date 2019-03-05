using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniPOS.POS
{
    public partial class FormSale : Form
    {
        public FormSale()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtDateTime.Text = DateTime.Now.ToString();
        }

        private void FormSale_Load(object sender, EventArgs e)
        {
            txtCashier.Text = $"{Program.KHName} : {Program.ENGName}";
        }
    }
}