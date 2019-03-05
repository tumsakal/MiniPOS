namespace MiniPOS.HR.Staff
{
    partial class FormStaff
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cboBrand = new System.Windows.Forms.ComboBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtPOB = new System.Windows.Forms.RichTextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.chkWorking = new System.Windows.Forms.CheckBox();
            this.txtNID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.txtNameLatin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameKH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.RichTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSocialMedia = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cboPosition = new System.Windows.Forms.ComboBox();
            this.ptbImage = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dELETEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 402);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1173, 192);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(147, 50);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(165, 33);
            this.txtID.TabIndex = 0;
            // 
            // cboBrand
            // 
            this.cboBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBrand.FormattingEnabled = true;
            this.cboBrand.Location = new System.Drawing.Point(758, 50);
            this.cboBrand.Name = "cboBrand";
            this.cboBrand.Size = new System.Drawing.Size(165, 33);
            this.cboBrand.TabIndex = 13;
            this.cboBrand.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(147, 245);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(165, 33);
            this.dtpDOB.TabIndex = 5;
            // 
            // txtPOB
            // 
            this.txtPOB.Location = new System.Drawing.Point(455, 50);
            this.txtPOB.Name = "txtPOB";
            this.txtPOB.Size = new System.Drawing.Size(165, 72);
            this.txtPOB.TabIndex = 8;
            this.txtPOB.Text = "";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(147, 284);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(82, 29);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Single";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // chkWorking
            // 
            this.chkWorking.AutoSize = true;
            this.chkWorking.Location = new System.Drawing.Point(758, 132);
            this.chkWorking.Name = "chkWorking";
            this.chkWorking.Size = new System.Drawing.Size(102, 29);
            this.chkWorking.TabIndex = 15;
            this.chkWorking.Text = "Working";
            this.chkWorking.UseVisualStyleBackColor = true;
            // 
            // txtNID
            // 
            this.txtNID.Location = new System.Drawing.Point(147, 89);
            this.txtNID.Name = "txtNID";
            this.txtNID.Size = new System.Drawing.Size(165, 33);
            this.txtNID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "NID";
            // 
            // cboGender
            // 
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "ស្រី",
            "ប្រុស"});
            this.cboGender.Location = new System.Drawing.Point(147, 206);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(119, 33);
            this.cboGender.TabIndex = 4;
            // 
            // txtNameLatin
            // 
            this.txtNameLatin.Location = new System.Drawing.Point(147, 167);
            this.txtNameLatin.Name = "txtNameLatin";
            this.txtNameLatin.Size = new System.Drawing.Size(165, 33);
            this.txtNameLatin.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Name(Latin)";
            // 
            // txtNameKH
            // 
            this.txtNameKH.Location = new System.Drawing.Point(147, 128);
            this.txtNameKH.Name = "txtNameKH";
            this.txtNameKH.Size = new System.Drawing.Size(165, 33);
            this.txtNameKH.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Name(kh)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(370, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "POB";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(370, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(455, 128);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(165, 72);
            this.txtAddress.TabIndex = 9;
            this.txtAddress.Text = "";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(455, 245);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(165, 33);
            this.txtEmail.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(370, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 25);
            this.label8.TabIndex = 22;
            this.label8.Text = "Email";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(455, 206);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(165, 33);
            this.txtPhone.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(370, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 25);
            this.label9.TabIndex = 20;
            this.label9.Text = "Phone";
            // 
            // txtSocialMedia
            // 
            this.txtSocialMedia.Location = new System.Drawing.Point(455, 284);
            this.txtSocialMedia.Name = "txtSocialMedia";
            this.txtSocialMedia.Size = new System.Drawing.Size(165, 33);
            this.txtSocialMedia.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(370, 287);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 56);
            this.label10.TabIndex = 24;
            this.label10.Text = "SocialMedia";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(147, 319);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(97, 29);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Married";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 287);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 25);
            this.label11.TabIndex = 27;
            this.label11.Text = "Marital";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(673, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 25);
            this.label12.TabIndex = 28;
            this.label12.Text = "Brand";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(673, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 25);
            this.label13.TabIndex = 30;
            this.label13.Text = "Position";
            // 
            // cboPosition
            // 
            this.cboPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPosition.FormattingEnabled = true;
            this.cboPosition.Location = new System.Drawing.Point(758, 89);
            this.cboPosition.Name = "cboPosition";
            this.cboPosition.Size = new System.Drawing.Size(165, 33);
            this.cboPosition.TabIndex = 14;
            // 
            // ptbImage
            // 
            this.ptbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbImage.Location = new System.Drawing.Point(987, 46);
            this.ptbImage.Name = "ptbImage";
            this.ptbImage.Size = new System.Drawing.Size(165, 232);
            this.ptbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbImage.TabIndex = 31;
            this.ptbImage.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnBrowse.Location = new System.Drawing.Point(987, 284);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(165, 23);
            this.btnBrowse.TabIndex = 16;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(26, 248);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 25);
            this.label14.TabIndex = 32;
            this.label14.Text = "DOB";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Image File|*.jpg;*.jpeg;*.png";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1023, 313);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 35);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dELETEToolStripMenuItem,
            this.eDITToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(114, 48);
            // 
            // dELETEToolStripMenuItem
            // 
            this.dELETEToolStripMenuItem.Name = "dELETEToolStripMenuItem";
            this.dELETEToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.dELETEToolStripMenuItem.Text = "DELETE";
            this.dELETEToolStripMenuItem.Click += new System.EventHandler(this.dELETEToolStripMenuItem_Click);
            // 
            // eDITToolStripMenuItem
            // 
            this.eDITToolStripMenuItem.Name = "eDITToolStripMenuItem";
            this.eDITToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.eDITToolStripMenuItem.Text = "EDIT";
            this.eDITToolStripMenuItem.Click += new System.EventHandler(this.eDITToolStripMenuItem_Click);
            // 
            // FormStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = global::MiniPOS.Properties.Settings.Default.AppBackColor;
            this.ClientSize = new System.Drawing.Size(1197, 606);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.ptbImage);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cboPosition);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.txtSocialMedia);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNameLatin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNameKH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboGender);
            this.Controls.Add(this.txtNID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkWorking);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.txtPOB);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.cboBrand);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = global::MiniPOS.Properties.Settings.Default.AppFont;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormStaff";
            this.Text = "FormStaff";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormStaff_FormClosed);
            this.Load += new System.EventHandler(this.FormStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox cboBrand;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.RichTextBox txtPOB;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.CheckBox chkWorking;
        private System.Windows.Forms.TextBox txtNID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.TextBox txtNameLatin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNameKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSocialMedia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboPosition;
        private System.Windows.Forms.PictureBox ptbImage;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dELETEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITToolStripMenuItem;
    }
}