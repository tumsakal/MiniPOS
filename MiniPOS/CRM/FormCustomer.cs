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
namespace MiniPOS.CRM
{
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();
        }

        public void FormCustomer_Load(object sender, EventArgs e)
        {
            
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = ".";
            builder.InitialCatalog = "MiniMart";
            builder.IntegratedSecurity = true;
            builder.MultipleActiveResultSets = true;

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = builder.ConnectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT * FROM Customer";

            SqlCommand command_count = new SqlCommand();
            command_count.Connection = conn;
            command_count.CommandText =
            "SELECT COUNT(*) FROM Customer WHERE Gender IN( N'Female', N'F', N'ស្រី');";

            SqlCommand command_total = new SqlCommand();
            command_total.Connection = conn;
            command_total.CommandText = "SELECT COUNT(*) FROM Customer;";
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(
                        reader["ID"],
                        reader["Name"],
                        reader["Gender"],
                        reader["Phone"],
                        reader["Email"],
                        reader["Address"],
                        reader["RegisterDate"]
                        );
                }
                //Count Female
                object result = command_count.ExecuteScalar();
                if(result != DBNull.Value)
                {
                    txtFeamale.Text = result.ToString();
                }
                //Count total
                object total = command_total.ExecuteScalar();
                if(total != DBNull.Value)
                {
                    txtTotal.Text = total.ToString();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Customer ";
            switch (cboActiveStatus.SelectedIndex)
            {
                case 0: sql += "WHERE IsActive = 0 "; break;
                case 1: sql += "WHERE IsActive = 1 "; break;
            }
            if (txtName.Text.Trim().Length != 0 && cboActiveStatus.SelectedIndex != 2)
                sql += $"AND [Name] LIKE N'%{txtName.Text.Trim()}%'";
            else if(txtName.Text.Trim().Length != 0 && cboActiveStatus.SelectedIndex == 2)
                sql += $"WHERE [Name] LIKE N'%{txtName.Text.Trim()}%'";
            //read data
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = ".";
            builder.InitialCatalog = "MiniMart";
            builder.IntegratedSecurity = true;
            SqlConnection conn = new SqlConnection(builder.ConnectionString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                dataGridView1.Rows.Clear();
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read() == true)
                {
                    dataGridView1.Rows.Add(
                        reader["ID"],
                        reader["Name"],
                        reader["Gender"],
                        reader["Phone"],
                        reader["Email"],
                        reader["Address"],
                        reader["RegisterDate"]
                        );
                }
                conn.Close();
                txtTotal.Text = dataGridView1.Rows.Count.ToString();
                int f = 0;
                string[] genders = { "female", "f", "ស្រី" };
                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    if (genders.Contains(r.Cells[2].Value.ToString().ToLower()))
                        f++;
                }
                txtFeamale.Text = f.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormNewCustomer fm = new FormNewCustomer();
            fm.Operation = "New";
            fm.StartPosition = FormStartPosition.CenterParent;
            fm.fmCust = this;
            fm.ShowDialog();
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                DataGridViewCell cell_id = dataGridView1[0, e.RowIndex];
                contextMenuStrip1.Tag = cell_id.Value;
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void eDITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string id = contextMenuStrip1.Tag.ToString();
            FormNewCustomer fm = new FormNewCustomer();
            fm.Operation = "EDIT";
            fm.fmCust = this;
            fm.StartPosition = FormStartPosition.CenterParent;
            fm.ID = id;
            fm.ShowDialog();
        }

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string id = contextMenuStrip1.Tag.ToString();
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = ".";
            builder.InitialCatalog = "MiniMart";
            builder.IntegratedSecurity = true;
            SqlConnection conn = new SqlConnection(builder.ToString());
            string sql_delete = $"DELETE FROM Customer WHERE ID = '{id}'";
            SqlCommand cmd = new SqlCommand(sql_delete, conn);
            try
            {
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                conn.Close();
                if(result > 0)
                {
                    MessageBox.Show($"{result} row deleted.");
                    dataGridView1.Rows.Clear();
                    FormCustomer_Load(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
