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
namespace MiniPOS.HR.Staff
{
    public partial class FormStaff : Form
    {
        public FormStaff()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        SqlConnection conn;
        private void FormStaff_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = ".";
            builder.InitialCatalog = "MiniMart";
            builder.IntegratedSecurity = true;
            builder.MultipleActiveResultSets = true;
            conn = new SqlConnection(builder.ConnectionString);
            conn.Open();
            LoadBrand();
            LoadPosition();
            LoadStaff();
        }
        void LoadStaff()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * From VStaff", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                BindingSource bs = new BindingSource();
                bs.DataSource = reader;
                dataGridView1.DataSource = bs;
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        void LoadBrand()
        {
            try
            {
                SqlCommand cmd_brand = new SqlCommand("SELECT [ID], [Name] FROM Branch;", conn);
                SqlDataReader branch_reader = cmd_brand.ExecuteReader();
                BindingSource branch_bs = new BindingSource();
                branch_bs.DataSource = branch_reader;
                cboBrand.ValueMember = "ID";
                cboBrand.DisplayMember = "Name";
                cboBrand.DataSource = branch_bs;
                branch_reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void LoadPosition()
        {
            try
            {
                SqlCommand cmd_position = new SqlCommand("SELECT [ID], [Name] FROM Position", conn);
                SqlDataReader position_reader = cmd_position.ExecuteReader();
                BindingSource position_bs = new BindingSource();
                position_bs.DataSource = position_reader;
                cboPosition.ValueMember = "ID";
                cboPosition.DisplayMember = "Name";
                cboPosition.DataSource = position_bs;
                position_reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                ptbImage.LoadAsync(openFileDialog1.FileName);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = $@"INSERT INTO Staff(
                                            ID,
                                            NID,
                                            BranchID,
                                            PositionID,
                                            EngName,
                                            KhName,
                                            Gender,
                                            DOB,
                                            POB,
                                            CurrentAddress,
                                            Phone,
                                            Email,
                                            SocialMedia,
                                            MaritalStatus,
                                            Image,
                                            Working
                                            ) 
                                VALUES(
                                            @id,
                                            @nid,
                                            @bid,
                                            @pid,
                                            @eng_name,
                                            @kh_name,
                                            @gender,
                                            @dob,
                                            @pob,
                                            @current_address,
                                            @phone,
                                            @email,
                                            @social_media,
                                            @marital,
                                            @img,
                                            @working
                                            )";
            //1
            SqlParameter param_id = new SqlParameter();
            param_id.ParameterName = "@id";
            param_id.SqlDbType = SqlDbType.VarChar;
            param_id.Size = 15;
            param_id.Direction = ParameterDirection.Input;
            param_id.Value = txtID.Text.Trim();
            cmd.Parameters.Add(param_id);
            //2
            SqlParameter param_nid = new SqlParameter("@nid", SqlDbType.VarChar, 20) { Value = txtNID.Text.Trim() };
            cmd.Parameters.Add(param_nid);
            //3
            cmd.Parameters.AddWithValue("@bid", cboBrand.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@pid", Convert.ToInt32(cboPosition.SelectedValue));
            cmd.Parameters.AddWithValue("@eng_name", txtNameLatin.Text.Trim());
            cmd.Parameters.AddWithValue("@kh_name", txtNameKH.Text.Trim());
            cmd.Parameters.AddWithValue("gender", cboGender.Text);
            cmd.Parameters.AddWithValue("@dob", dtpDOB.Value);
            cmd.Parameters.AddWithValue("@pob", txtPOB.Text.Trim());
            cmd.Parameters.AddWithValue("@current_address", txtAddress.Text.Trim());
            cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
            cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
            cmd.Parameters.AddWithValue("@social_media", txtSocialMedia.Text.Trim());
            cmd.Parameters.AddWithValue("@marital",
                            (radioButton1.Checked ? radioButton1.Text : radioButton2.Text));
            cmd.Parameters.AddWithValue("@working", chkWorking.Checked);
            //convert image to byte[]
            System.IO.MemoryStream memory = new System.IO.MemoryStream();
            ptbImage.Image.Save(memory, ptbImage.Image.RawFormat);
            cmd.Parameters.AddWithValue("@img", memory.ToArray());
            try
            {
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Saved");
                    this.ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                contextMenuStrip1.Tag = row;
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = contextMenuStrip1.Tag as DataGridViewRow;
            string id = row.Cells[0].Value.ToString();
            string sql = @"DELETE FROM Staff WHERE ID = @id";
            //
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue(parameterName: "@id", value: id);
            try
            {
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    dataGridView1.Rows.Remove(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void eDITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Enabled = false;
            DataGridViewRow row = contextMenuStrip1.Tag as DataGridViewRow;
            //***set form controls
            txtID.Text = row.Cells[0].Value.ToString();
            txtID.ReadOnly = true;
            txtNID.Text = row.Cells[1].Value.ToString();
            cboBrand.SelectedValue = row.Cells[2].Value;
            cboPosition.SelectedValue = row.Cells[3].Value;
            txtNameLatin.Text = row.Cells[4].Value.ToString();
            txtNameKH.Text = row.Cells[5].Value.ToString();
            cboGender.SelectedItem = row.Cells[6].Value.ToString();
            dtpDOB.Value = Convert.ToDateTime(row.Cells[7].Value);
            txtPOB.Text = row.Cells[8].Value.ToString();
            txtAddress.Text = row.Cells[9].Value.ToString();
            txtPOB.Text = row.Cells[10].Value.ToString();
            txtEmail.Text = row.Cells[11].Value.ToString();
            txtSocialMedia.Text = row.Cells[12].Value.ToString();
            if (radioButton1.Text == row.Cells[13].Value.ToString())
                radioButton1.Checked = true;
            else
                radioButton2.Checked = true;
            chkWorking.Checked = Convert.ToBoolean(row.Cells[14].Value);
            //load image
            //SqlCommand cmd_image = new SqlCommand("SELECT Image FROM Staff WHERE ID = @id;", this.conn);
            //cmd_image.Parameters.AddWithValue("@id", txtID.Text.Trim());
            //try
            //{
            //    object raw_image = cmd_image.ExecuteScalar();
            //    if (raw_image != DBNull.Value && ((byte[])raw_image).Length > 0)
            //    {
            //        System.IO.MemoryStream memory = new System.IO.MemoryStream((byte[])raw_image);
            //        ptbImage.Image = Image.FromStream(memory);
            //    }
            //    cmd_image.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //set event to btnSave
            btnSave.Click -= btnSave_Click;
            btnSave.Click += BtnSaveChange_Click;
        }

        private void BtnSaveChange_Click(object sender, EventArgs e)
        {
            //***update

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = this.conn;
            cmd.CommandText = $@"UPDATE Staff SET NID = '{txtNID.Text.Trim()}' ,BranchID = '{cboBrand.SelectedValue}' ,PositionID = {cboPosition.SelectedValue},EngName = '{txtNameLatin.Text.Trim()}',KhName = N'{txtNameKH.Text.Trim()}',Gender = N'{cboGender.Text}',DOB = @dob,POB = N'{txtPOB.Text.Trim()}',CurrentAddress = N'{txtAddress.Text.Trim()}',Phone = '{txtPhone.Text.Trim()}',Email = '{txtEmail.Text.Trim()}',SocialMedia = N'{txtSocialMedia.Text.Trim()}',MaritalStatus = N'{(radioButton1.Checked ? radioButton1.Text : radioButton2.Text)}',Image = @img,Working = @working WHERE ID = '{txtID.Text.Trim()}';";
            cmd.Parameters.AddWithValue("@dob", dtpDOB.Value);
            System.IO.MemoryStream memory = new System.IO.MemoryStream();
            ptbImage.Image.Save(memory, ptbImage.Image.RawFormat);
            cmd.Parameters.AddWithValue("@img", memory.ToArray());
            cmd.Parameters.AddWithValue("@working", chkWorking.Checked);
            try
            {
                conn.Close();
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                conn.Close();
                if (result > 0)
                {
                    MessageBox.Show("Updated");
                    LoadStaff();
                    this.ClearForm();
                    dataGridView1.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //
            btnSave.Click -= BtnSaveChange_Click;
            btnSave.Click += btnSave_Click;
        }
        void ClearForm()
        {
            foreach (Control item in this.Controls)
            {
                switch (item)
                {
                    case TextBoxBase txt: txt.Clear(); break;
                    case ComboBox cbo: cbo.SelectedIndex = -1; break;
                }
            }
            radioButton1.Checked = true;
            ptbImage.Image = null;
            chkWorking.Checked = false;
        }

        private void FormStaff_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.conn.Close();
        }
    }
}
