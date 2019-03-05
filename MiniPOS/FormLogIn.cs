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

namespace MiniPOS
{
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
        }

        private void FormLogIn_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F12)
            {
                FormConnection fm = new FormConnection();
                fm.StartPosition = FormStartPosition.CenterScreen;
                fm.FormBorderStyle = FormBorderStyle.FixedSingle;
                fm.MinimizeBox = false;
                fm.MaximizeBox = false;

                this.Hide();
                fm.ShowDialog();
                this.Show();
            }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = Program.Connection;
            command.CommandText = $"SELECT Staff.ID, Staff.EngName, Staff.KhName, Staff.Gender, Staff.[Image] FROM UserAccount INNER JOIN Staff ON UserAccount.StaffID = Staff.[ID] WHERE Username = N'{txtUusername.Text.Trim()}' AND[Password] = N'{txtPassword.Text.Trim()}' AND Staff.Working = 1";
            command.CommandType = CommandType.Text;
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                if(reader.HasRows == true)
                {
                    reader.Read();
                    Program.StaffID = reader["ID"].ToString();
                    Program.ENGName = reader["EngName"].ToString();
                    Program.KHName = reader["KhName"].ToString();
                    Program.Gender = reader["Gender"].ToString();
                    FormMain fm = new FormMain();
                    this.Hide();
                    fm.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
