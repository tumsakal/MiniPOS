namespace MiniPOS.POS
{
    partial class UserControl_Product
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PictureBox_Product_Image = new System.Windows.Forms.PictureBox();
            this.Label_Product_Name = new System.Windows.Forms.Label();
            this.Label_Price = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Product_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox_Product_Image
            // 
            this.PictureBox_Product_Image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox_Product_Image.Location = new System.Drawing.Point(0, 0);
            this.PictureBox_Product_Image.Name = "PictureBox_Product_Image";
            this.PictureBox_Product_Image.Size = new System.Drawing.Size(275, 288);
            this.PictureBox_Product_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox_Product_Image.TabIndex = 0;
            this.PictureBox_Product_Image.TabStop = false;
            // 
            // Label_Product_Name
            // 
            this.Label_Product_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Product_Name.Location = new System.Drawing.Point(0, 255);
            this.Label_Product_Name.Name = "Label_Product_Name";
            this.Label_Product_Name.Size = new System.Drawing.Size(275, 33);
            this.Label_Product_Name.TabIndex = 1;
            this.Label_Product_Name.Text = "Product Name";
            this.Label_Product_Name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label_Price
            // 
            this.Label_Price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Price.Location = new System.Drawing.Point(189, 0);
            this.Label_Price.Name = "Label_Price";
            this.Label_Price.Size = new System.Drawing.Size(83, 29);
            this.Label_Price.TabIndex = 2;
            this.Label_Price.Text = "Price";
            this.Label_Price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControl_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Label_Price);
            this.Controls.Add(this.Label_Product_Name);
            this.Controls.Add(this.PictureBox_Product_Image);
            this.Font = global::MiniPOS.Properties.Settings.Default.AppFont;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "UserControl_Product";
            this.Size = new System.Drawing.Size(275, 288);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Product_Image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox PictureBox_Product_Image;
        public System.Windows.Forms.Label Label_Product_Name;
        public System.Windows.Forms.Label Label_Price;
    }
}
