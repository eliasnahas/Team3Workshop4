namespace Team3Workshop4
{
    partial class frmAddModifyProductSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddModifyProductSupplier));
            txtProductSupplierID = new TextBox();
            lblProductSupplierID = new Label();
            label2 = new Label();
            label3 = new Label();
            cboProductName = new ComboBox();
            cboSupplierName = new ComboBox();
            btnConfirm = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtProductSupplierID
            // 
            txtProductSupplierID.Location = new Point(201, 22);
            txtProductSupplierID.Name = "txtProductSupplierID";
            txtProductSupplierID.ReadOnly = true;
            txtProductSupplierID.Size = new Size(103, 29);
            txtProductSupplierID.TabIndex = 0;
            // 
            // lblProductSupplierID
            // 
            lblProductSupplierID.AutoSize = true;
            lblProductSupplierID.Location = new Point(32, 25);
            lblProductSupplierID.Name = "lblProductSupplierID";
            lblProductSupplierID.Size = new Size(148, 21);
            lblProductSupplierID.TabIndex = 1;
            lblProductSupplierID.Text = "Product Supplier ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 74);
            label2.Name = "label2";
            label2.Size = new Size(113, 21);
            label2.TabIndex = 2;
            label2.Text = "Product Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 119);
            label3.Name = "label3";
            label3.Size = new Size(117, 21);
            label3.TabIndex = 3;
            label3.Text = "Supplier Name:";
            // 
            // cboProductName
            // 
            cboProductName.FormattingEnabled = true;
            cboProductName.Location = new Point(201, 74);
            cboProductName.Name = "cboProductName";
            cboProductName.Size = new Size(334, 29);
            cboProductName.TabIndex = 8;
            // 
            // cboSupplierName
            // 
            cboSupplierName.FormattingEnabled = true;
            cboSupplierName.Location = new Point(201, 119);
            cboSupplierName.Name = "cboSupplierName";
            cboSupplierName.Size = new Size(334, 29);
            cboSupplierName.TabIndex = 9;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(32, 168);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(170, 36);
            btnConfirm.TabIndex = 10;
            btnConfirm.Text = "&Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(365, 168);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(170, 36);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "C&ancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmAddModifyProductSupplier
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(563, 232);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(cboSupplierName);
            Controls.Add(cboProductName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblProductSupplierID);
            Controls.Add(txtProductSupplierID);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmAddModifyProductSupplier";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAddModifyProductSupplier";
            Load += frmAddModifyProductSupplier_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtProductSupplierID;
        private Label lblProductSupplierID;
        private Label label2;
        private Label label3;
        private ComboBox cboProductName;
        private ComboBox cboSupplierName;
        private Button btnConfirm;
        private Button btnCancel;
    }
}