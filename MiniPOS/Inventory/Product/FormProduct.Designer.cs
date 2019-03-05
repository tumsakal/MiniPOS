namespace MiniPOS.Inventory.Product
{
    partial class FormProduct
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStockLevel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStockQty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkAvailableForSale = new System.Windows.Forms.CheckBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cboUnitType = new System.Windows.Forms.ComboBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCommit = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dELETEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExportToXML = new System.Windows.Forms.Button();
            this.btnImportFromXML = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(993, 584);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnBrowse);
            this.tabPage1.Controls.Add(this.btnCancel);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtUnitPrice);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtStockLevel);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtStockQty);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtBarcode);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.chkAvailableForSale);
            this.tabPage1.Controls.Add(this.txtDescription);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.cboUnitType);
            this.tabPage1.Controls.Add(this.cboCategory);
            this.tabPage1.Controls.Add(this.txtID);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(985, 547);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New/ Edit";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(459, 254);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(141, 35);
            this.btnBrowse.TabIndex = 46;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(185, 479);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 35);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(319, 479);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 35);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 336);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 24);
            this.label9.TabIndex = 43;
            this.label9.Text = "Description";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 24);
            this.label7.TabIndex = 42;
            this.label7.Text = "Unit Type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 24);
            this.label8.TabIndex = 41;
            this.label8.Text = "Category";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(185, 221);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(245, 29);
            this.txtUnitPrice.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 24);
            this.label6.TabIndex = 39;
            this.label6.Text = "Unit Price";
            // 
            // txtStockLevel
            // 
            this.txtStockLevel.Location = new System.Drawing.Point(185, 186);
            this.txtStockLevel.Name = "txtStockLevel";
            this.txtStockLevel.Size = new System.Drawing.Size(245, 29);
            this.txtStockLevel.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 24);
            this.label4.TabIndex = 37;
            this.label4.Text = "StockLevel";
            // 
            // txtStockQty
            // 
            this.txtStockQty.Location = new System.Drawing.Point(185, 151);
            this.txtStockQty.Name = "txtStockQty";
            this.txtStockQty.Size = new System.Drawing.Size(245, 29);
            this.txtStockQty.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 24);
            this.label5.TabIndex = 35;
            this.label5.Text = "StockQty";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(185, 116);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(245, 29);
            this.txtName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 24);
            this.label3.TabIndex = 33;
            this.label3.Text = "Name";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(185, 81);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(245, 29);
            this.txtBarcode.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 31;
            this.label2.Text = "Barcode";
            // 
            // chkAvailableForSale
            // 
            this.chkAvailableForSale.AutoSize = true;
            this.chkAvailableForSale.Location = new System.Drawing.Point(185, 436);
            this.chkAvailableForSale.Name = "chkAvailableForSale";
            this.chkAvailableForSale.Size = new System.Drawing.Size(170, 28);
            this.chkAvailableForSale.TabIndex = 9;
            this.chkAvailableForSale.Text = "Available for sale";
            this.chkAvailableForSale.UseVisualStyleBackColor = true;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(185, 334);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(245, 96);
            this.txtDescription.TabIndex = 8;
            this.txtDescription.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(459, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 207);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // cboUnitType
            // 
            this.cboUnitType.FormattingEnabled = true;
            this.cboUnitType.Location = new System.Drawing.Point(185, 294);
            this.cboUnitType.Name = "cboUnitType";
            this.cboUnitType.Size = new System.Drawing.Size(245, 32);
            this.cboUnitType.TabIndex = 7;
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(185, 256);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(245, 32);
            this.cboCategory.TabIndex = 6;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(185, 46);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(245, 29);
            this.txtID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "ID";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnImportFromXML);
            this.tabPage2.Controls.Add(this.btnExportToXML);
            this.tabPage2.Controls.Add(this.btnCommit);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.btnSearch);
            this.tabPage2.Controls.Add(this.txtSearch);
            this.tabPage2.Controls.Add(this.lblTotal);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(985, 547);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnCommit
            // 
            this.btnCommit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCommit.Location = new System.Drawing.Point(854, 62);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(106, 33);
            this.btnCommit.TabIndex = 5;
            this.btnCommit.Text = "Commit";
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(186, 24);
            this.label11.TabIndex = 4;
            this.label11.Text = "ID, Name or Barcode";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(306, 98);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(97, 29);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(22, 98);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(278, 29);
            this.txtSearch.TabIndex = 2;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.Location = new System.Drawing.Point(830, 101);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(130, 24);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(938, 406);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Image File|*.jpg;*.jpeg;*.png";
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
            // btnExportToXML
            // 
            this.btnExportToXML.Location = new System.Drawing.Point(690, 62);
            this.btnExportToXML.Name = "btnExportToXML";
            this.btnExportToXML.Size = new System.Drawing.Size(158, 33);
            this.btnExportToXML.TabIndex = 6;
            this.btnExportToXML.Text = "Export to XML";
            this.btnExportToXML.UseVisualStyleBackColor = true;
            this.btnExportToXML.Click += new System.EventHandler(this.btnExportToXML_Click);
            // 
            // btnImportFromXML
            // 
            this.btnImportFromXML.Location = new System.Drawing.Point(690, 23);
            this.btnImportFromXML.Name = "btnImportFromXML";
            this.btnImportFromXML.Size = new System.Drawing.Size(158, 33);
            this.btnImportFromXML.TabIndex = 7;
            this.btnImportFromXML.Text = "Import from XML";
            this.btnImportFromXML.UseVisualStyleBackColor = true;
            this.btnImportFromXML.Click += new System.EventHandler(this.btnImportFromXML_Click);
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(993, 584);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormProduct";
            this.Text = "FormProduct";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormProduct_FormClosed);
            this.Load += new System.EventHandler(this.FormProduct_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStockLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStockQty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkAvailableForSale;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cboUnitType;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dELETEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITToolStripMenuItem;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Button btnExportToXML;
        private System.Windows.Forms.Button btnImportFromXML;
    }
}