using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace MiniPOS.Inventory.Product
{
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
        }
        //global
        DataSet ds_inventory = new DataSet();
        SqlDataAdapter adapter;
        private void FormProduct_Load(object sender, EventArgs e)
        {//using System.Data.SqlClient;
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = ".";
            builder.InitialCatalog = "MiniMart";
            builder.IntegratedSecurity = true;
            SqlConnection conn = new SqlConnection(builder.ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM Product; SELECT * From Category; SELECT * FROM UnitType;";
            adapter = new SqlDataAdapter(cmd);
            SqlCommandBuilder cmd_builder = new SqlCommandBuilder(adapter);
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            //adapter = new SqlDataAdapter("sql select", "connection string");
            adapter.Fill(ds_inventory);
            DataRelation relation_category_product = new DataRelation(
                "relation_category_product",        //relationName
                ds_inventory.Tables[1].Columns["ID"],//primarykey column
                ds_inventory.Tables[0].Columns["CategoryID"]//foregnkey column
                );
            DataRelation relation_unittype_product = new DataRelation(
                "relation_unittype_product",
                ds_inventory.Tables[2].Columns["ID"],
                ds_inventory.Tables[0].Columns["UnitTypeID"]
                );
            ds_inventory.Relations.Add(relation_category_product);
            ds_inventory.Relations.Add(relation_unittype_product);
            //Display data in form
            dataGridView1.DataSource = ds_inventory.Tables[0];//Product
            dataGridView1.Columns["Image"].Visible = false;
            //
            cboCategory.ValueMember = "ID";
            cboCategory.DisplayMember = "Name";
            cboCategory.DataSource = ds_inventory.Tables[1];//Category
            cboCategory.SelectedIndex = -1;
            //
            cboUnitType.ValueMember = "ID";
            cboUnitType.DisplayMember = "Name";
            cboUnitType.DataSource = ds_inventory.Tables[2];//UnitType
            cboUnitType.SelectedIndex = -1;
            //Total
            //lblTotal.Text = "Total: " + dataGridView1.Rows.Count;
            lblTotal.Text = "Total: " + ds_inventory.Tables[0].Rows.Count;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                pictureBox1.LoadAsync(openFileDialog1.FileName);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Filter
            if(txtSearch.Text.Trim() == string.Empty)
            {
                ds_inventory.Tables[0].DefaultView.RowFilter = "";
            }
            else
            {
                ds_inventory.Tables[0].DefaultView.RowFilter = $@"ID = '{txtSearch.Text.Trim()}'
                                                                  OR Name LIKE '%{txtSearch.Text.Trim()}%'
                                                                  OR Barcode = '{txtSearch.Text.Trim()}'
                                                                ";
            }
            lblTotal.Text = "Total: " + dataGridView1.Rows.Count;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataRow row = ds_inventory.Tables[0].NewRow();
            row["ID"] = txtID.Text.Trim();
            row["Barcode"] = txtBarcode.Text.Trim();
            row["Name"] = txtName.Text.Trim();
            row["CategoryID"] = cboCategory.SelectedValue;
            row["UnitTypeID"] = cboUnitType.SelectedValue;
            row["StockQty"] = Convert.ToInt32(txtStockQty.Text.Trim());
            row["StockLevel"] = Convert.ToInt32(txtStockLevel.Text.Trim());
            row["UnitPrice"] = Convert.ToDecimal(txtUnitPrice.Text.Trim());
            row["Image"] = this.ConvertImageToBytes(pictureBox1.Image);
            row["Desc"] = txtDescription.Text.Trim();
            row["IsForSale"] = chkAvailableForSale.Checked;
            ds_inventory.Tables[0].Rows.Add(row);
            ///adapter.Update(ds_inventory.Tables[0]);
            //clear form
        }
        byte[] b = new byte[0];//empty element array
        byte[] ConvertImageToBytes(Image img)
        {            
            System.IO.MemoryStream memory = new System.IO.MemoryStream();
            img.Save(memory, img.RawFormat);
            return memory.ToArray();
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                string id = dataGridView1[columnIndex: 0, rowIndex: e.RowIndex].Value.ToString();
                contextMenuStrip1.Tag = id;
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string id = contextMenuStrip1.Tag.ToString();
            for (int i = 0; i < ds_inventory.Tables[0].Rows.Count; i++)
            {
                if (ds_inventory.Tables[0].Rows[i][0].ToString() == id)
                {
                    ds_inventory.Tables[0].Rows[i].Delete();
                    break;
                }
            }
            //2
            //DataRow[] rows = ds_inventory.Tables[0].Select($"ID = '{id}'");
            //if (rows.Length > 0)
            //    rows[0].Delete();
        }

        private void eDITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string id = contextMenuStrip1.Tag.ToString();
            for (int i = 0; i < ds_inventory.Tables[0].Rows.Count; i++)
            {
                if (ds_inventory.Tables[0].Rows[i][0].ToString() == id)
                {
                    DataRow row = ds_inventory.Tables[0].Rows[i];
                    txtID.Text = row["ID"].ToString();
                    txtID.ReadOnly = true;
                    txtBarcode.Text = row["Barcode"].ToString();
                    txtName.Text = row["Name"].ToString();
                    cboCategory.SelectedValue =(int) row["CategoryID"];
                    cboUnitType.SelectedValue = (int)row["UnitTypeID"];
                    txtStockQty.Text = row["StockQty"].ToString();
                    txtStockLevel.Text = row["StockLevel"].ToString();
                    txtUnitPrice.Text = row["UnitPrice"].ToString();
                    txtDescription.Text = row["Desc"].ToString();
                    chkAvailableForSale.Checked = (bool)row["IsForSale"];
                    if(row["Image"] != DBNull.Value)
                        pictureBox1.Image = ConvertBytesToImage((byte[])row["Image"]);
                    tabControl1.SelectedTab = tabPage1;
                    btnSave.Click -= btnSave_Click;
                    btnSave.Click += BtnSaveChange_Click;
                    break;
                }
            }
        }

        private void BtnSaveChange_Click(object sender, EventArgs e)
        {
            string id = txtID.Text.Trim();
            for (int i = 0; i < ds_inventory.Tables[0].Rows.Count; i++)
            {
                if (ds_inventory.Tables[0].Rows[i][0].ToString() == id)
                {
                    DataRow row = ds_inventory.Tables[0].Rows[i];
                    row["Barcode"] = txtBarcode.Text.Trim();
                    row["Name"] = txtName.Text.Trim();
                    row["CategoryID"] = cboCategory.SelectedValue;
                    row["UnitTypeID"] = cboUnitType.SelectedValue;
                    row["StockQty"] = Convert.ToInt32(txtStockQty.Text.Trim());
                    row["StockLevel"] = Convert.ToInt32(txtStockLevel.Text.Trim());
                    row["UnitPrice"] = Convert.ToDecimal(txtUnitPrice.Text.Trim());
                    if(pictureBox1.Image != null)
                        row["Image"] = this.ConvertImageToBytes(pictureBox1.Image);
                    row["Desc"] = txtDescription.Text.Trim();
                    row["IsForSale"] = chkAvailableForSale.Checked;
                    this.ClearForm();
                    txtID.ReadOnly = false;
                    break;
                }
            }
            //
            btnSave.Click -= BtnSaveChange_Click;
            btnSave.Click += btnSave_Click;
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
        Image ConvertBytesToImage(byte[] raw)
        {
            if (raw != null && raw.Length > 0)
            {
                System.IO.MemoryStream memory = new System.IO.MemoryStream(raw);
                Image img = Image.FromStream(memory);
                return img;
            }
            return null;
        }

        private void FormProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            adapter.Update(ds_inventory.Tables[0]);
            //execute INSERT, DELETE, UPDATE statement
            //execute InsertCommand, DeleteCommand, UpdateCommand of SqlDataAdapter
        }

        private void btnExportToXML_Click(object sender, EventArgs e)
        {
            string xml_file = $@"{Environment.CurrentDirectory}\Inventory.xml";
            ds_inventory.WriteXml(xml_file, XmlWriteMode.WriteSchema);
            //XmlWriteMode.WriteSchema : write data and schema
            //XmlWriteMode.IgnoreSchema: write data without schema
        }

        private void btnImportFromXML_Click(object sender, EventArgs e)
        {
            string xml_file = $@"{Environment.CurrentDirectory}\Inventory.xml";
            //ds_inventory = new DataSet();
            ds_inventory.ReadXml(xml_file);
            //dataGridView1.DataSource = ds_inventory.Tables[0];//Product
            //dataGridView1.Columns["Image"].Visible = false;
            ////
            //cboCategory.ValueMember = "ID";
            //cboCategory.DisplayMember = "Name";
            //cboCategory.DataSource = ds_inventory.Tables[1];//Category
            //cboCategory.SelectedIndex = -1;
            ////
            //cboUnitType.ValueMember = "ID";
            //cboUnitType.DisplayMember = "Name";
            //cboUnitType.DataSource = ds_inventory.Tables[2];//UnitType
            //cboUnitType.SelectedIndex = -1;
        }
    }
}