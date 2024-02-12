namespace Team3Workshop4
{
    partial class frmAddModifyPackProdSupp
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnAccept = new Button();
            btnCancel = new Button();
            comboPackageId = new ComboBox();
            comboProdSuppId = new ComboBox();
            textPackProdSuppId = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(18, 18);
            label1.Name = "label1";
            label1.Size = new Size(194, 21);
            label1.TabIndex = 0;
            label1.Text = "PackageProductSupplierId:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(130, 64);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 1;
            label2.Text = "PackageId:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(74, 110);
            label3.Name = "label3";
            label3.Size = new Size(138, 21);
            label3.TabIndex = 2;
            label3.Text = "ProductSupplierId:";
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(35, 154);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(117, 23);
            btnAccept.TabIndex = 9;
            btnAccept.Text = "&Accept";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(197, 154);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(113, 23);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // comboPackageId
            // 
            comboPackageId.FormattingEnabled = true;
            comboPackageId.Location = new Point(231, 66);
            comboPackageId.Name = "comboPackageId";
            comboPackageId.Size = new Size(74, 23);
            comboPackageId.TabIndex = 11;
            // 
            // comboProdSuppId
            // 
            comboProdSuppId.FormattingEnabled = true;
            comboProdSuppId.Location = new Point(231, 112);
            comboProdSuppId.Name = "comboProdSuppId";
            comboProdSuppId.Size = new Size(74, 23);
            comboProdSuppId.TabIndex = 12;
            // 
            // textPackProdSuppId
            // 
            textPackProdSuppId.Enabled = false;
            textPackProdSuppId.Location = new Point(231, 18);
            textPackProdSuppId.Name = "textPackProdSuppId";
            textPackProdSuppId.ReadOnly = true;
            textPackProdSuppId.Size = new Size(74, 23);
            textPackProdSuppId.TabIndex = 13;
            // 
            // frmAddModifyPackProdSupp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 196);
            Controls.Add(textPackProdSuppId);
            Controls.Add(comboProdSuppId);
            Controls.Add(comboPackageId);
            Controls.Add(btnCancel);
            Controls.Add(btnAccept);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAddModifyPackProdSupp";
            Text = "Add/Modify Package Product Supplier";
            Load += frmAddModifyPackProdSupp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnAccept;
        private Button btnCancel;
        private ComboBox comboPackageId;
        private ComboBox comboProdSuppId;
        private TextBox textPackProdSuppId;
    }
}