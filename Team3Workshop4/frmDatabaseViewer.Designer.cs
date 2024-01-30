namespace Team3Workshop4
{
    partial class frmDatabaseViewer
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
            tabControl1 = new TabControl();
            tabPackages = new TabPage();
            packagesGrid = new DataGridView();
            tabProducts = new TabPage();
            productsGrid = new DataGridView();
            tabProdSupp = new TabPage();
            prodSuppGrid = new DataGridView();
            tabSuppliers = new TabPage();
            suppliersGrid = new DataGridView();
            tabPackProdSupp = new TabPage();
            packProdSuppGrid = new DataGridView();
            addPackageButton = new Button();
            modPackageButton = new Button();
            remPackageButton = new Button();
            tabControl1.SuspendLayout();
            tabPackages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)packagesGrid).BeginInit();
            tabProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productsGrid).BeginInit();
            tabProdSupp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)prodSuppGrid).BeginInit();
            tabSuppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)suppliersGrid).BeginInit();
            tabPackProdSupp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)packProdSuppGrid).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPackages);
            tabControl1.Controls.Add(tabProducts);
            tabControl1.Controls.Add(tabProdSupp);
            tabControl1.Controls.Add(tabSuppliers);
            tabControl1.Controls.Add(tabPackProdSupp);
            tabControl1.Location = new Point(14, 16);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(938, 671);
            tabControl1.TabIndex = 0;
            // 
            // tabPackages
            // 
            tabPackages.Controls.Add(packagesGrid);
            tabPackages.Location = new Point(4, 29);
            tabPackages.Margin = new Padding(3, 4, 3, 4);
            tabPackages.Name = "tabPackages";
            tabPackages.Padding = new Padding(3, 4, 3, 4);
            tabPackages.Size = new Size(930, 638);
            tabPackages.TabIndex = 0;
            tabPackages.Text = "Packages";
            tabPackages.UseVisualStyleBackColor = true;
            // 
            // packagesGrid
            // 
            packagesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            packagesGrid.Location = new Point(0, 0);
            packagesGrid.Margin = new Padding(3, 4, 3, 4);
            packagesGrid.Name = "packagesGrid";
            packagesGrid.RowHeadersWidth = 51;
            packagesGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            packagesGrid.Size = new Size(929, 607);
            packagesGrid.TabIndex = 0;
            // 
            // tabProducts
            // 
            tabProducts.Controls.Add(productsGrid);
            tabProducts.Location = new Point(4, 29);
            tabProducts.Margin = new Padding(3, 4, 3, 4);
            tabProducts.Name = "tabProducts";
            tabProducts.Padding = new Padding(3, 4, 3, 4);
            tabProducts.Size = new Size(930, 638);
            tabProducts.TabIndex = 1;
            tabProducts.Text = "Products";
            tabProducts.UseVisualStyleBackColor = true;
            // 
            // productsGrid
            // 
            productsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsGrid.Location = new Point(0, 0);
            productsGrid.Margin = new Padding(3, 4, 3, 4);
            productsGrid.Name = "productsGrid";
            productsGrid.RowHeadersWidth = 51;
            productsGrid.Size = new Size(929, 607);
            productsGrid.TabIndex = 1;
            // 
            // tabProdSupp
            // 
            tabProdSupp.Controls.Add(prodSuppGrid);
            tabProdSupp.Location = new Point(4, 29);
            tabProdSupp.Margin = new Padding(3, 4, 3, 4);
            tabProdSupp.Name = "tabProdSupp";
            tabProdSupp.Size = new Size(930, 638);
            tabProdSupp.TabIndex = 2;
            tabProdSupp.Text = "Products_suppliers";
            tabProdSupp.UseVisualStyleBackColor = true;
            // 
            // prodSuppGrid
            // 
            prodSuppGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            prodSuppGrid.Location = new Point(0, 0);
            prodSuppGrid.Margin = new Padding(3, 4, 3, 4);
            prodSuppGrid.Name = "prodSuppGrid";
            prodSuppGrid.RowHeadersWidth = 51;
            prodSuppGrid.Size = new Size(929, 607);
            prodSuppGrid.TabIndex = 1;
            // 
            // tabSuppliers
            // 
            tabSuppliers.Controls.Add(suppliersGrid);
            tabSuppliers.Location = new Point(4, 29);
            tabSuppliers.Margin = new Padding(3, 4, 3, 4);
            tabSuppliers.Name = "tabSuppliers";
            tabSuppliers.Size = new Size(930, 638);
            tabSuppliers.TabIndex = 3;
            tabSuppliers.Text = "Suppliers";
            tabSuppliers.UseVisualStyleBackColor = true;
            // 
            // suppliersGrid
            // 
            suppliersGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            suppliersGrid.Location = new Point(0, 0);
            suppliersGrid.Margin = new Padding(3, 4, 3, 4);
            suppliersGrid.Name = "suppliersGrid";
            suppliersGrid.RowHeadersWidth = 51;
            suppliersGrid.Size = new Size(929, 607);
            suppliersGrid.TabIndex = 1;
            // 
            // tabPackProdSupp
            // 
            tabPackProdSupp.Controls.Add(packProdSuppGrid);
            tabPackProdSupp.Location = new Point(4, 29);
            tabPackProdSupp.Margin = new Padding(3, 4, 3, 4);
            tabPackProdSupp.Name = "tabPackProdSupp";
            tabPackProdSupp.Size = new Size(930, 638);
            tabPackProdSupp.TabIndex = 4;
            tabPackProdSupp.Text = "Packages_products_suppliers";
            tabPackProdSupp.UseVisualStyleBackColor = true;
            // 
            // packProdSuppGrid
            // 
            packProdSuppGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            packProdSuppGrid.Location = new Point(0, 0);
            packProdSuppGrid.Margin = new Padding(3, 4, 3, 4);
            packProdSuppGrid.Name = "packProdSuppGrid";
            packProdSuppGrid.RowHeadersWidth = 51;
            packProdSuppGrid.Size = new Size(929, 607);
            packProdSuppGrid.TabIndex = 1;
            // 
            // addPackageButton
            // 
            addPackageButton.Location = new Point(272, 695);
            addPackageButton.Margin = new Padding(3, 4, 3, 4);
            addPackageButton.Name = "addPackageButton";
            addPackageButton.Size = new Size(122, 31);
            addPackageButton.TabIndex = 1;
            addPackageButton.Text = "Add Package";
            addPackageButton.UseVisualStyleBackColor = true;
            addPackageButton.Click += button1_Click;
            // 
            // modPackageButton
            // 
            modPackageButton.Location = new Point(417, 695);
            modPackageButton.Margin = new Padding(3, 4, 3, 4);
            modPackageButton.Name = "modPackageButton";
            modPackageButton.Size = new Size(122, 31);
            modPackageButton.TabIndex = 2;
            modPackageButton.Text = "Modify Package";
            modPackageButton.UseVisualStyleBackColor = true;
            modPackageButton.Click += modPackageButton_Click;
            // 
            // remPackageButton
            // 
            remPackageButton.Location = new Point(566, 695);
            remPackageButton.Margin = new Padding(3, 4, 3, 4);
            remPackageButton.Name = "remPackageButton";
            remPackageButton.Size = new Size(122, 31);
            remPackageButton.TabIndex = 3;
            remPackageButton.Text = "Remove Package";
            remPackageButton.UseVisualStyleBackColor = true;
            // 
            // frmDatabaseViewer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 741);
            Controls.Add(remPackageButton);
            Controls.Add(modPackageButton);
            Controls.Add(addPackageButton);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmDatabaseViewer";
            Text = "Database Viewer";
            Load += MainForm_Load;
            tabControl1.ResumeLayout(false);
            tabPackages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)packagesGrid).EndInit();
            tabProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)productsGrid).EndInit();
            tabProdSupp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)prodSuppGrid).EndInit();
            tabSuppliers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)suppliersGrid).EndInit();
            tabPackProdSupp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)packProdSuppGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPackages;
        private TabPage tabProducts;
        private TabPage tabProdSupp;
        private TabPage tabSuppliers;
        private TabPage tabPackProdSupp;
        private DataGridView packagesGrid;
        private DataGridView productsGrid;
        private DataGridView prodSuppGrid;
        private DataGridView suppliersGrid;
        private DataGridView packProdSuppGrid;
        private Button addPackageButton;
        private Button modPackageButton;
        private Button remPackageButton;
    }
}