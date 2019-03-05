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
    public partial class FormNewCustomer : Form
    {
        public FormCustomer fmCust { get; set; }
        public string ID { get; set; }
        public string Operation { get; set; }
        public FormNewCustomer()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = ".";
            builder.InitialCatalog = "MiniMart";
            builder.IntegratedSecurity = true;

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = builder.ConnectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = $@"INSERT INTO Customer(
                                                    ID, 
                                                    Name,
                                                    Gender,
                                                    Phone,
                                                    Email,
                                                    Address,
                                                    RegisterDate,
                                                    IsActive
                                                    )
                                            VALUES(
                                                    '{txtID.Text.Trim()}',
                                                    N'{txtName.Text.Trim()}',
                                                    N'{cboGender.Text}',
                                                    '{txtPhone.Text.Trim()}',
                                                    '{txtEmail.Text.Trim()}',
                                                    N'{txtAddress.Text.Trim()}',
                                                    '{dtpRegisterDate.Value.ToString("MM-dd-yyyy")}',
                                                    {Convert.ToInt32(chkIsActive.Checked)}
                                                   )";
            try
            {
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                conn.Close();
                if(result >0)
                {
                    MessageBox.Show($"{result} row Inserted");
                    fmCust.dataGridView1.Rows.Clear();
                    fmCust.FormCustomer_Load(null, null);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnSaveChange_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = ".";
            builder.InitialCatalog = "MiniMart";
            builder.IntegratedSecurity = true;

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = builder.ConnectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = string.Format("UPDATE Customer SET [Name] = N'{0}', Gender = N'{1}', Phone = '{2}',Email = '{3}', [Address] = N'{4}', RegisterDate = '{5}', IsActive = {6} WHERE ID = '{7}'", txtName.Text.Trim(), cboGender.Text, txtPhone.Text.Trim(),txtEmail.Text.Trim(),txtAddress.Text.Trim(), dtpRegisterDate.Value.ToString("MM-dd-yyyy"), Convert.ToInt32(chkIsActive.Checked), txtID.Text.Trim());
            try
            {
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                conn.Close();
                if(result > 0)
                {
                    MessageBox.Show("Updated");
                    fmCust.dataGridView1.Rows.Clear();
                    fmCust.FormCustomer_Load(null, null);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FormNewCustomer_Load(object sender, EventArgs e)
        {
            switch (Operation)
            {
                case "New":
                    btnSave.Click += btnSave_Click;
                    break;
                case "EDIT":
                    btnSave.Click += btnSaveChange_Click;
                    SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                    builder.DataSource = ".";
                    builder.InitialCatalog = "MiniMart";
                    builder.IntegratedSecurity = true;

                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = builder.ConnectionString;

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = $"SELECT * FROM Customer WHERE ID = '{this.ID}'";
                    try
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if(reader.Read() == true)
                        {
                            txtID.Text = ID;
                            txtName.Text = reader["Name"].ToString();
                            cboGender.SelectedItem = reader["Gender"].ToString();
                            txtPhone.Text = reader["Phone"].ToString();
                            txtEmail.Text = reader["Email"].ToString();
                            txtAddress.Text = reader["Address"].ToString();
                            dtpRegisterDate.Value = (DateTime)reader["RegisterDate"];
                            chkIsActive.Checked = (bool)reader["IsActive"];
                        }
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(Operation == "EDIT")
            {
                DialogResult result = MessageBox.Show("Are sure?", "Confirm", MessageBoxButtons.OKCancel
                                            , MessageBoxIcon.Exclamation);
                if (result == DialogResult.OK)
                    Close();
            }
        }
    }
}
