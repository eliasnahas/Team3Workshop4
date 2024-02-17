namespace Team3Workshop4
{
    partial class frmEditPackageProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditPackageProducts));
            dgvAddedProducts = new DataGridView();
            dgvAvailableProducts = new DataGridView();
            btnRemove = new Button();
            btnAdd = new Button();
            btnClose = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAddedProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAvailableProducts).BeginInit();
            SuspendLayout();
            // 
            // dgvAddedProducts
            // 
            dgvAddedProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAddedProducts.Location = new Point(12, 79);
            dgvAddedProducts.MultiSelect = false;
            dgvAddedProducts.Name = "dgvAddedProducts";
            dgvAddedProducts.RowHeadersVisible = false;
            dgvAddedProducts.RowHeadersWidth = 51;
            dgvAddedProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAddedProducts.Size = new Size(300, 499);
            dgvAddedProducts.TabIndex = 0;
            // 
            // dgvAvailableProducts
            // 
            dgvAvailableProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAvailableProducts.Location = new Point(444, 79);
            dgvAvailableProducts.MultiSelect = false;
            dgvAvailableProducts.Name = "dgvAvailableProducts";
            dgvAvailableProducts.RowHeadersVisible = false;
            dgvAvailableProducts.RowHeadersWidth = 51;
            dgvAvailableProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAvailableProducts.Size = new Size(300, 499);
            dgvAvailableProducts.TabIndex = 1;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(336, 349);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(78, 40);
            btnRemove.TabIndex = 2;
            btnRemove.Text = ">";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(336, 258);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(78, 40);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "<";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(12, 596);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 46);
            btnClose.TabIndex = 4;
            btnClose.Text = "&Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 48);
            label1.Name = "label1";
            label1.Size = new Size(190, 28);
            label1.TabIndex = 6;
            label1.Text = "Products in Package:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(444, 48);
            label2.Name = "label2";
            label2.Size = new Size(178, 28);
            label2.TabIndex = 7;
            label2.Text = "Available Products:";
            // 
            // frmEditPackageProducts
            // 
            AcceptButton = btnClose;
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(756, 654);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Controls.Add(btnAdd);
            Controls.Add(btnRemove);
            Controls.Add(dgvAvailableProducts);
            Controls.Add(dgvAddedProducts);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmEditPackageProducts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmEditPackageProducts";
            Load += frmEditPackageProducts_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAddedProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAvailableProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAddedProducts;
        private DataGridView dgvAvailableProducts;
        private Button btnRemove;
        private Button btnAdd;
        private Button btnClose;
        private Label label1;
        private Label label2;
    }
}