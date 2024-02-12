namespace Team3Workshop4
{
    partial class frmAddModifyPackage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtPkgName = new TextBox();
            label2 = new Label();
            dtpPkgEndDate = new DateTimePicker();
            dtpPkgStartDate = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            txtPkgDesc = new TextBox();
            label5 = new Label();
            txtPkgBasePrice = new TextBox();
            txtPkgAgencyCommission = new TextBox();
            label6 = new Label();
            label7 = new Label();
            btnAccept = new Button();
            btnCancel = new Button();
            lvProducts = new ListView();
            Products = new ColumnHeader();
            Suppliers = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(68, 28);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // txtPkgName
            // 
            txtPkgName.Location = new Point(134, 15);
            txtPkgName.MaxLength = 50;
            txtPkgName.Name = "txtPkgName";
            txtPkgName.Size = new Size(477, 34);
            txtPkgName.TabIndex = 1;
            txtPkgName.Tag = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(103, 28);
            label2.TabIndex = 2;
            label2.Text = "Start Date:";
            // 
            // dtpPkgEndDate
            // 
            dtpPkgEndDate.CustomFormat = " ";
            dtpPkgEndDate.Format = DateTimePickerFormat.Custom;
            dtpPkgEndDate.Location = new Point(444, 55);
            dtpPkgEndDate.Name = "dtpPkgEndDate";
            dtpPkgEndDate.Size = new Size(167, 34);
            dtpPkgEndDate.TabIndex = 3;
            dtpPkgEndDate.Tag = "End Date";
            dtpPkgEndDate.ValueChanged += dtpPkgEndDate_ValueChanged;
            dtpPkgEndDate.KeyDown += dtpPkgEndDate_KeyDown;
            // 
            // dtpPkgStartDate
            // 
            dtpPkgStartDate.CustomFormat = " ";
            dtpPkgStartDate.Format = DateTimePickerFormat.Custom;
            dtpPkgStartDate.Location = new Point(134, 55);
            dtpPkgStartDate.Name = "dtpPkgStartDate";
            dtpPkgStartDate.Size = new Size(167, 34);
            dtpPkgStartDate.TabIndex = 5;
            dtpPkgStartDate.Tag = "Start Date";
            dtpPkgStartDate.ValueChanged += dtpPkgStartDate_ValueChanged;
            dtpPkgStartDate.KeyDown += dtpPkgStartDate_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(343, 60);
            label3.Name = "label3";
            label3.Size = new Size(95, 28);
            label3.TabIndex = 4;
            label3.Text = "End Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 98);
            label4.Name = "label4";
            label4.Size = new Size(116, 28);
            label4.TabIndex = 6;
            label4.Text = "Description:";
            // 
            // txtPkgDesc
            // 
            txtPkgDesc.Location = new Point(134, 95);
            txtPkgDesc.MaxLength = 50;
            txtPkgDesc.Name = "txtPkgDesc";
            txtPkgDesc.Size = new Size(477, 34);
            txtPkgDesc.TabIndex = 7;
            txtPkgDesc.Tag = "Description";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 138);
            label5.Name = "label5";
            label5.Size = new Size(102, 28);
            label5.TabIndex = 8;
            label5.Text = "Base Price:";
            // 
            // txtPkgBasePrice
            // 
            txtPkgBasePrice.Location = new Point(134, 135);
            txtPkgBasePrice.Name = "txtPkgBasePrice";
            txtPkgBasePrice.Size = new Size(125, 34);
            txtPkgBasePrice.TabIndex = 9;
            txtPkgBasePrice.Tag = "Base Price";
            txtPkgBasePrice.TextAlign = HorizontalAlignment.Right;
            // 
            // txtPkgAgencyCommission
            // 
            txtPkgAgencyCommission.Location = new Point(486, 135);
            txtPkgAgencyCommission.Name = "txtPkgAgencyCommission";
            txtPkgAgencyCommission.Size = new Size(125, 34);
            txtPkgAgencyCommission.TabIndex = 11;
            txtPkgAgencyCommission.Tag = "Agency Commission";
            txtPkgAgencyCommission.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(287, 138);
            label6.Name = "label6";
            label6.Size = new Size(193, 28);
            label6.TabIndex = 10;
            label6.Text = "Agency Commission:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 178);
            label7.Name = "label7";
            label7.Size = new Size(93, 28);
            label7.TabIndex = 12;
            label7.Text = "Products:";
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(12, 465);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(94, 41);
            btnAccept.TabIndex = 14;
            btnAccept.Text = "&Accept";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(519, 465);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 41);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // lvProducts
            // 
            lvProducts.Columns.AddRange(new ColumnHeader[] { Products, Suppliers });
            lvProducts.Location = new Point(12, 209);
            lvProducts.Name = "lvProducts";
            lvProducts.OwnerDraw = true;
            lvProducts.Size = new Size(599, 190);
            lvProducts.TabIndex = 17;
            lvProducts.UseCompatibleStateImageBehavior = false;
            lvProducts.View = View.Details;
            lvProducts.DrawColumnHeader += lvProducts_DrawColumnHeader;
            lvProducts.DrawItem += lvProducts_DrawItem;
            // 
            // Products
            // 
            Products.Text = "Products";
            Products.Width = 285;
            // 
            // Suppliers
            // 
            Suppliers.Text = "Suppliers";
            Suppliers.Width = 285;
            // 
            // frmAddModifyPackage
            // 
            AcceptButton = btnAccept;
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(625, 518);
            Controls.Add(lvProducts);
            Controls.Add(btnCancel);
            Controls.Add(btnAccept);
            Controls.Add(label7);
            Controls.Add(txtPkgAgencyCommission);
            Controls.Add(label6);
            Controls.Add(txtPkgBasePrice);
            Controls.Add(label5);
            Controls.Add(txtPkgDesc);
            Controls.Add(label4);
            Controls.Add(dtpPkgStartDate);
            Controls.Add(label3);
            Controls.Add(dtpPkgEndDate);
            Controls.Add(label2);
            Controls.Add(txtPkgName);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmAddModifyPackage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += frmAddModifyPackage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPkgName;
        private Label label2;
        private DateTimePicker dtpPkgEndDate;
        private DateTimePicker dtpPkgStartDate;
        private Label label3;
        private Label label4;
        private TextBox txtPkgDesc;
        private Label label5;
        private TextBox txtPkgBasePrice;
        private TextBox txtPkgAgencyCommission;
        private Label label6;
        private Label label7;
        private Button btnAccept;
        private Button btnCancel;
        private ListView lvProducts;
        private ColumnHeader Products;
        private ColumnHeader Suppliers;
    }
}
