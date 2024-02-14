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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddModifyPackProdSupp));
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
            label1.Location = new Point(21, 24);
            label1.Name = "label1";
            label1.Size = new Size(246, 28);
            label1.TabIndex = 0;
            label1.Text = "PackageProductSupplierId:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(149, 85);
            label2.Name = "label2";
            label2.Size = new Size(104, 28);
            label2.TabIndex = 1;
            label2.Text = "PackageId:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(85, 147);
            label3.Name = "label3";
            label3.Size = new Size(175, 28);
            label3.TabIndex = 2;
            label3.Text = "ProductSupplierId:";
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(40, 205);
            btnAccept.Margin = new Padding(3, 4, 3, 4);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(134, 31);
            btnAccept.TabIndex = 9;
            btnAccept.Text = "&Accept";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(225, 205);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(129, 31);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // comboPackageId
            // 
            comboPackageId.FormattingEnabled = true;
            comboPackageId.Location = new Point(264, 88);
            comboPackageId.Margin = new Padding(3, 4, 3, 4);
            comboPackageId.Name = "comboPackageId";
            comboPackageId.Size = new Size(84, 28);
            comboPackageId.TabIndex = 11;
            // 
            // comboProdSuppId
            // 
            comboProdSuppId.FormattingEnabled = true;
            comboProdSuppId.Location = new Point(264, 149);
            comboProdSuppId.Margin = new Padding(3, 4, 3, 4);
            comboProdSuppId.Name = "comboProdSuppId";
            comboProdSuppId.Size = new Size(84, 28);
            comboProdSuppId.TabIndex = 12;
            // 
            // textPackProdSuppId
            // 
            textPackProdSuppId.Enabled = false;
            textPackProdSuppId.Location = new Point(264, 24);
            textPackProdSuppId.Margin = new Padding(3, 4, 3, 4);
            textPackProdSuppId.Name = "textPackProdSuppId";
            textPackProdSuppId.ReadOnly = true;
            textPackProdSuppId.Size = new Size(84, 27);
            textPackProdSuppId.TabIndex = 13;
            // 
            // frmAddModifyPackProdSupp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(393, 261);
            Controls.Add(textPackProdSuppId);
            Controls.Add(comboProdSuppId);
            Controls.Add(comboPackageId);
            Controls.Add(btnCancel);
            Controls.Add(btnAccept);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
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