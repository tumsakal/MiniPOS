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
using DbLib;

namespace MiniPOS
{
    public partial class FormConnection : Form
    {
        public FormConnection()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text.Trim().ToLower().StartsWith("w"))
            {
                txtUser.Clear();
                txtPassword.Clear();
                txtUser.Enabled = false;
                txtPassword.Enabled = false;
            }
            else if(comboBox1.Text.Trim().ToLower().StartsWith("s"))
            {
                txtUser.Clear();
                txtPassword.Clear();
                txtUser.Enabled = true;
                txtPassword.Enabled = true;
            }
        }
        string file_name = ".\\connection_string.con";
        string secret_key = "123456789";
        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = txtServerName.Text.Trim();
            builder.InitialCatalog = txtDatabaseNme.Text.Trim();
            if (comboBox1.Text.Trim().ToLower().StartsWith("w"))
                builder.IntegratedSecurity = true;
            else if(comboBox1.Text.Trim().ToLower().StartsWith("s"))
            {
                builder.UserID = txtUser.Text.Trim();
                builder.Password = txtPassword.Text.Trim();
            }
            
            builder.SaveToFile(file_name, secret_key);//encrypt

            Program.Connection = new SqlConnection();
            Program.Connection.ConnectionString = builder.ToString();
            try
            {
                Program.Connection.Open();
            }
            catch (Exception)
            {

                throw;
            }
            this.Close();
        }

        private void FormConnection_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.LoadFromFile(file_name, secret_key);

            txtServerName.Text = builder.DataSource;
            txtDatabaseNme.Text = builder.InitialCatalog;
            if(builder.IntegratedSecurity == false)
            {
                txtUser.Text = builder.UserID;
                txtPassword.Text = builder.Password;
            }
        }
    }
}
