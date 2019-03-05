using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MiniPOS.Inventory.Product1.InventoryTableAdapters;

using System.Data.OleDb;
using System.Data.Odbc;
using MySql.Data.MySqlClient;
using System.Data.SQLite;
using System.Data.SqlClient;

namespace MiniPOS.Inventory.Product1
{
    public partial class FormProduct : Form
    {
        Inventory invent = new Inventory();//Category, UnitType, Product
        CategoryTableAdapter cate_adapter;
        UnitTypeTableAdapter unit_adapter;
        ProductTableAdapter pro_adapter;
        public FormProduct()
        {
            InitializeComponent();
            //SqlConnection
            //MySqlConnection
            //SQLiteConnection
            //OleDbConnection
            //OdbcConnection
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            string conn_str = "Server=.;Database=MiniMart;Integrated Security=true;";
            SqlConnection conn = new SqlConnection(conn_str);
            cate_adapter = new CategoryTableAdapter();
            cate_adapter.Connection = conn;
            cate_adapter.Fill(invent.Category);

            unit_adapter = new UnitTypeTableAdapter();
            unit_adapter.Connection = conn;
            unit_adapter.Fill(invent.UnitType);

            pro_adapter = new ProductTableAdapter();
            pro_adapter.Connection = conn;
            pro_adapter.Fill(invent.Product);

            //bind to controls
            cboCategory.DisplayMember = invent.Category.NameColumn.ColumnName;
            cboCategory.ValueMember = invent.Category.IDColumn.ColumnName;
            cboCategory.DataSource = invent.Category;

            cboUnitType.DisplayMember = invent.UnitType.NameColumn.ColumnName;
            cboUnitType.ValueMember = invent.UnitType.IDColumn.ColumnName;
            cboUnitType.DataSource = invent.UnitType;

            dataGridView1.DataSource = invent.Product;
            (dataGridView1.Columns[invent.Product.ImageColumn.ColumnName]  as DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Zoom;

            lblTotal.Text = "Total: " + invent.Product.Rows.Count.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Inventory.ProductRow row = invent.Product.NewProductRow();
            row.ID = txtID.Text.Trim();
            row.Barcode = txtBarcode.Text.Trim();
            row.Name = txtName.Text.Trim();
            row.CategoryID = Convert.ToInt32(cboCategory.SelectedValue);
            row.UnitTypeID = (int)cboUnitType.SelectedValue;
            row.StockQty = Convert.ToInt32(txtStockQty.Text.Trim());
            row.StockLevel = Convert.ToInt32(txtStockLevel.Text.Trim());
            row.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text.Trim());
            row.Desc = txtDescription.Text.Trim();
            row.IsForSale = chkAvailableForSale.Checked;
            if(pictureBox1.Image != null)
                row.Image = this.ConvertImageToBytes(pictureBox1.Image);
            //
            invent.Product.AddProductRow(row);
            lblTotal.Text = "Total: " + invent.Product.Rows.Count;
            //
            this.ClearForm();
        }
        byte[] ConvertImageToBytes(Image img)
        {
            using (System.IO.MemoryStream memory = new System.IO.MemoryStream())
            {
                img.Save(memory, img.RawFormat);
                return memory.ToArray();
            }
        }
        void ClearForm()
        {
            foreach (Control item in tabPage1.Controls)
            {
                switch (item)
                {
                    case TextBoxBase txt: txt.Clear(); break;
                    case ComboBox cbo: cbo.SelectedIndex = -1; break;
                }
            }
            chkAvailableForSale.Checked = false;
            pictureBox1.Image = null;
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                string pro_id = dataGridView1[0, e.RowIndex].Value.ToString();
                contextMenuStrip1.Tag = pro_id;
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string pro_id = contextMenuStrip1.Tag.ToString();
            Inventory.ProductRow selected_row = invent.Product.FindByID(pro_id);
            if (selected_row != null)
                selected_row.Delete();
        }

        private void eDITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string pro_id = contextMenuStrip1.Tag.ToString();
            Inventory.ProductRow selected_row = invent.Product.FindByID(pro_id);
            if (selected_row != null)
            {
                txtID.Text = selected_row.ID;
                txtBarcode.Text = selected_row.Barcode;
                txtName.Text = selected_row.Name;
                cboCategory.SelectedValue = selected_row.CategoryID;
                cboUnitType.SelectedValue = selected_row.UnitTypeID;
                txtStockQty.Text = selected_row.StockQty.ToString();
                txtStockLevel.Text = selected_row.StockLevel.ToString();
                txtUnitPrice.Text = selected_row.UnitPrice.ToString();
                txtDescription.Text = selected_row.Desc;
                chkAvailableForSale.Checked = selected_row.IsForSale;
                if(selected_row.Image != null)
                    pictureBox1.Image = ConvertBytesToImage(selected_row.Image);
            }
            Image ConvertBytesToImage(byte[] raw_img)
            {
                System.IO.MemoryStream memory = new System.IO.MemoryStream(raw_img);
                Image img = Image.FromStream(memory);
                return img;
            }
            tabControl1.SelectedTab = tabPage1;
            btnSave.Click -= btnSave_Click;
            btnSave.Click += BtnSaveChange_Click;
        }

        private void BtnSaveChange_Click(object sender, EventArgs e)
        {
            Inventory.ProductRow row = invent.Product.FindByID(txtID.Text.Trim());
            if (row != null)
            {
                row.Barcode = txtBarcode.Text.Trim();
                row.Name = txtName.Text.Trim();
                row.StockQty = Convert.ToInt32(txtStockQty.Text.Trim());
                row.StockLevel = Convert.ToInt32(txtStockLevel.Text.Trim());
                row.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text.Trim());
                row.CategoryID = Convert.ToInt32(cboCategory.SelectedValue);
                row.UnitTypeID = Convert.ToInt32(cboUnitType.SelectedValue);
                row.Desc = txtDescription.Text.Trim();
                row.IsForSale = chkAvailableForSale.Checked;
                if (pictureBox1.Image != null)
                    row.Image = ConvertImageToBytes(pictureBox1.Image);
            }
            this.ClearForm();
            btnSave.Click -= BtnSaveChange_Click;
            btnSave.Click += btnSave_Click;
            //
            //pro_adapter.Update(invent.Product);
            pro_adapter.Update(row);
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            pro_adapter.Update(invent.Product);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text.Trim() == string.Empty)
            {
                invent.Product.DefaultView.RowFilter = "";
            }
            else
            {
                invent.Product.DefaultView.RowFilter = $@"ID = '{txtSearch.Text.Trim()}'
                                                                  OR Name LIKE '%{txtSearch.Text.Trim()}%'
                                                                  OR Barcode = '{txtSearch.Text.Trim()}'
                                                                ";
            }
            lblTotal.Text = "Total: " + dataGridView1.Rows.Count;
        }
    }
}
