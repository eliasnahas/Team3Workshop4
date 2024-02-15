namespace Team3Workshop4
{
    partial class frmAddModifyProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddModifyProduct));
            txtProductName = new TextBox();
            label1 = new Label();
            btnConfirm = new Button();
            btnCancel = new Button();
            lblProductID = new Label();
            txtProductID = new TextBox();
            SuspendLayout();
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(186, 62);
            txtProductName.Margin = new Padding(4);
            txtProductName.MaxLength = 50;
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(127, 29);
            txtProductName.TabIndex = 1;
            txtProductName.Tag = "Product Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 65);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(113, 21);
            label1.TabIndex = 2;
            label1.Text = "Product Name:";
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(25, 108);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(94, 37);
            btnConfirm.TabIndex = 3;
            btnConfirm.Text = "&Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(227, 108);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(86, 37);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "C&ancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblProductID
            // 
            lblProductID.AutoSize = true;
            lblProductID.Location = new Point(25, 20);
            lblProductID.Margin = new Padding(4, 0, 4, 0);
            lblProductID.Name = "lblProductID";
            lblProductID.Size = new Size(86, 21);
            lblProductID.TabIndex = 5;
            lblProductID.Text = "Product ID:";
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(186, 17);
            txtProductID.Margin = new Padding(4);
            txtProductID.MaxLength = 50;
            txtProductID.Name = "txtProductID";
            txtProductID.ReadOnly = true;
            txtProductID.Size = new Size(127, 29);
            txtProductID.TabIndex = 6;
            txtProductID.Tag = "Product Name";
            // 
            // frmAddModifyProduct
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(334, 157);
            Controls.Add(txtProductID);
            Controls.Add(lblProductID);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(label1);
            Controls.Add(txtProductName);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmAddModifyProduct";
            Text = "Form1";
            Load += frmAddModify_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtProductName;
        private Label label1;
        private Button btnConfirm;
        private Button btnCancel;
        private Label lblProductID;
        private TextBox txtProductID;
    }
}