using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniPOS.POS.POS_SaleTableAdapters;
namespace MiniPOS.POS
{
    public partial class FormSale : Form
    {
        POS_Sale dataset = new POS_Sale();
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
            txtCashier.Text = $"{Program.StaffID} : {Program.KHName} : {Program.ENGName}";
            //Customer
            CustomerTableAdapter cust_adpater = new CustomerTableAdapter();
            cust_adpater.Connection = Program.Connection;
            cust_adpater.Fill(dataset.Customer);

            cboCustomer.DisplayMember = "Name";
            cboCustomer.ValueMember = "ID";
            cboCustomer.DataSource = dataset.Customer;
            cboCustomer.SelectedIndex = -1;
            //Category
            CategoryTableAdapter cate_adapter = new CategoryTableAdapter();
            cate_adapter.Connection = Program.Connection;
            cate_adapter.Fill(dataset.Category);

            foreach (var cate in dataset.Category)
            {
                Button btnCategory = new Button();
                btnCategory.Text = cate.Name;
                btnCategory.Tag = cate.ID;
                btnCategory.Width = flowLayoutPanel_Category.Width;
                btnCategory.Height = 30;
                btnCategory.Click += BtnCategory_Click;
                flowLayoutPanel_Category.Controls.Add(btnCategory);
            }
            //
            dataGridView_Purchasing_Items.DataSource = dataset.PurchasingItems;
            dataGridView_Purchasing_Items.Columns[0].Visible = false;//ProductID
            //add 
            DataGridViewImageColumn plus = new DataGridViewImageColumn();
            //plus.HeaderText = "";
            plus.ImageLayout = DataGridViewImageCellLayout.Zoom;
            plus.Image = Properties.Resources.Plus_32px;
            DataGridViewImageColumn delete = new DataGridViewImageColumn();
            //delete.HeaderText = "";
            delete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            delete.Image = Properties.Resources.Cancel_16px1;
            dataGridView_Purchasing_Items.Columns.Add(plus);
            dataGridView_Purchasing_Items.Columns.Add(delete);
        }

        private void BtnCategory_Click(object sender, EventArgs e)
        {
            Button btnCategory = sender as Button;
            dataset.Product.Clear();
            ProductTableAdapter pro_adapter = new ProductTableAdapter();
            pro_adapter.Connection = Program.Connection;
            pro_adapter.FillByCategoryID(dataset.Product , Convert.ToInt32(btnCategory.Tag));
            //add to flowlayoutpanel_products
            flowLayoutPanel_Products.Controls.Clear();
            foreach (var pro in dataset.Product)
            {
                UserControl_Product uc_product = new UserControl_Product();
                uc_product.Label_Price.Text = pro.UnitPrice.ToString();
                uc_product.Label_Product_Name.Text = pro.Name;
                uc_product.PictureBox_Product_Image.Image = this.ConvertImageFromBytes(pro.Image);

                uc_product.PictureBox_Product_Image.Tag = pro.ID;
                uc_product.PictureBox_Product_Image.Click += PictureBox_Product_Image_Click;

                flowLayoutPanel_Products.Controls.Add(uc_product);
            }
        }

        private void PictureBox_Product_Image_Click(object sender, EventArgs e)
        {
            PictureBox ptb = sender as PictureBox;
            string pro_id = ptb.Tag.ToString();
            POS_Sale.ProductRow pro = dataset.Product.FindByID(pro_id);
            //
            POS_Sale.PurchasingItemsRow purchase_item = dataset.PurchasingItems.FindByProductID(pro.ID);
            if (purchase_item == null)
            {
                purchase_item = dataset.PurchasingItems.NewPurchasingItemsRow();
                purchase_item.ProductID = pro.ID;
                purchase_item.Name = pro.Name;
                purchase_item.Qty = 1;
                purchase_item.Price = pro.UnitPrice;
                purchase_item.Disc = 0;
                dataset.PurchasingItems.AddPurchasingItemsRow(purchase_item);
                //ptb.Click -= PictureBox_Product_Image_Click;
            }
            else if(purchase_item != null)
            {
                purchase_item.Qty++;
            }
        }

        private Image ConvertImageFromBytes(byte[] raw)
        {
            return Image.FromStream(new System.IO.MemoryStream(raw));
        }

        private void dataGridView_Purchasing_Items_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.ColumnIndex >= 6)
            {
                string pro_id = dataGridView_Purchasing_Items[0, e.RowIndex].Value.ToString();
                POS_Sale.PurchasingItemsRow purchase = dataset.PurchasingItems.FindByProductID(pro_id);
                if(e.ColumnIndex == 6)//plus
                {
                    purchase.Qty++;
                }
                else if(e.ColumnIndex ==7)//delete
                {
                    purchase.Qty--;
                    if (purchase.Qty == 0)
                        purchase.Delete();
                }
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
        
    }
}