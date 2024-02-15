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
            label1 = new Label();
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
            txtProductSupplierID.Size = new Size(103, 34);
            txtProductSupplierID.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 25);
            label1.Name = "label1";
            label1.Size = new Size(187, 28);
            label1.TabIndex = 1;
            label1.Text = "Product Supplier ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 74);
            label2.Name = "label2";
            label2.Size = new Size(142, 28);
            label2.TabIndex = 2;
            label2.Text = "Product Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 119);
            label3.Name = "label3";
            label3.Size = new Size(146, 28);
            label3.TabIndex = 3;
            label3.Text = "Supplier Name:";
            // 
            // cboProductName
            // 
            cboProductName.FormattingEnabled = true;
            cboProductName.Location = new Point(201, 74);
            cboProductName.Name = "cboProductName";
            cboProductName.Size = new Size(334, 36);
            cboProductName.TabIndex = 8;
            // 
            // cboSupplierName
            // 
            cboSupplierName.FormattingEnabled = true;
            cboSupplierName.Location = new Point(201, 119);
            cboSupplierName.Name = "cboSupplierName";
            cboSupplierName.Size = new Size(334, 36);
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
            AutoScaleDimensions = new SizeF(11F, 28F);
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
            Controls.Add(label1);
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
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cboProductName;
        private ComboBox cboSupplierName;
        private Button btnConfirm;
        private Button btnCancel;
    }
}