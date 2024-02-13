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
            tabControl = new TabControl();
            tabPackages = new TabPage();
            remPackageButton = new Button();
            packagesGrid = new DataGridView();
            modPackageButton = new Button();
            addPackageButton = new Button();
            tabProducts = new TabPage();
            remProdButton = new Button();
            dgvProduct = new DataGridView();
            modProdButton = new Button();
            addProdButton = new Button();
            tabProdSupp = new TabPage();
            remProdSuppButton = new Button();
            dgvProductSupplier = new DataGridView();
            modProdSuppButton = new Button();
            addProdSuppButton = new Button();
            tabSuppliers = new TabPage();
            btnRemoveSup = new Button();
            dgvSuppliers = new DataGridView();
            btnModifySup = new Button();
            btnAddSup = new Button();
            tabPackProdSupp = new TabPage();
            btnRemPackProdSupp = new Button();
            btnModPackProdSupp = new Button();
            btnAddPackProdSupp = new Button();
            dgvPacksProdsSupps = new DataGridView();
            tabControl.SuspendLayout();
            tabPackages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)packagesGrid).BeginInit();
            tabProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            tabProdSupp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductSupplier).BeginInit();
            tabSuppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).BeginInit();
            tabPackProdSupp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPacksProdsSupps).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPackages);
            tabControl.Controls.Add(tabProducts);
            tabControl.Controls.Add(tabProdSupp);
            tabControl.Controls.Add(tabSuppliers);
            tabControl.Controls.Add(tabPackProdSupp);
            tabControl.Location = new Point(12, 12);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(821, 518);
            tabControl.TabIndex = 0;
            // 
            // tabPackages
            // 
            tabPackages.Controls.Add(remPackageButton);
            tabPackages.Controls.Add(packagesGrid);
            tabPackages.Controls.Add(modPackageButton);
            tabPackages.Controls.Add(addPackageButton);
            tabPackages.Location = new Point(4, 24);
            tabPackages.Name = "tabPackages";
            tabPackages.Padding = new Padding(3, 4, 3, 4);
            tabPackages.Size = new Size(930, 658);
            tabPackages.TabIndex = 0;
            tabPackages.Text = "Packages";
            tabPackages.UseVisualStyleBackColor = true;
            // 
            // remPackageButton
            // 
            remPackageButton.Location = new Point(480, 461);
            remPackageButton.Name = "remPackageButton";
            remPackageButton.Size = new Size(107, 23);
            remPackageButton.TabIndex = 3;
            remPackageButton.Text = "Remove Package";
            remPackageButton.UseVisualStyleBackColor = true;
            remPackageButton.Click += remPackageButton_Click;
            // 
            // packagesGrid
            // 
            packagesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            packagesGrid.Location = new Point(0, 0);
            packagesGrid.Margin = new Padding(3, 4, 3, 4);
            packagesGrid.MultiSelect = false;
            packagesGrid.Name = "packagesGrid";
            packagesGrid.RowHeadersWidth = 51;
            packagesGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            packagesGrid.Size = new Size(929, 607);
            packagesGrid.TabIndex = 0;
            // 
            // modPackageButton
            // 
            modPackageButton.Location = new Point(353, 461);
            modPackageButton.Name = "modPackageButton";
            modPackageButton.Size = new Size(107, 23);
            modPackageButton.TabIndex = 2;
            modPackageButton.Text = "Modify Package";
            modPackageButton.UseVisualStyleBackColor = true;
            modPackageButton.Click += modPackageButton_Click;
            // 
            // addPackageButton
            // 
            addPackageButton.Location = new Point(226, 461);
            addPackageButton.Name = "addPackageButton";
            addPackageButton.Size = new Size(107, 23);
            addPackageButton.TabIndex = 1;
            addPackageButton.Text = "Add Package";
            addPackageButton.UseVisualStyleBackColor = true;
            addPackageButton.Click += addPackageButton_Click;
            // 
            // tabProducts
            // 
            tabProducts.Controls.Add(remProdButton);
            tabProducts.Controls.Add(dgvProduct);
            tabProducts.Controls.Add(modProdButton);
            tabProducts.Controls.Add(addProdButton);
            tabProducts.Location = new Point(4, 29);
            tabProducts.Margin = new Padding(3, 4, 3, 4);
            tabProducts.Name = "tabProducts";
            tabProducts.Padding = new Padding(3, 4, 3, 4);
            tabProducts.Size = new Size(930, 658);
            tabProducts.TabIndex = 1;
            tabProducts.Text = "Products";
            tabProducts.UseVisualStyleBackColor = true;
            // 
            // remProdButton
            // 
            remProdButton.Location = new Point(481, 461);
            remProdButton.Name = "remProdButton";
            remProdButton.Size = new Size(122, 31);
            remProdButton.TabIndex = 6;
            remProdButton.Text = "Remove Product";
            remProdButton.UseVisualStyleBackColor = true;
            remProdButton.Click += remProdButton_Click;
            // 
            // dgvProduct
            // 
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(0, 0);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProduct.Size = new Size(813, 455);
            dgvProduct.TabIndex = 1;
            // 
            // modProdButton
            // 
            modProdButton.Location = new Point(353, 461);
            modProdButton.Name = "modProdButton";
            modProdButton.Size = new Size(122, 31);
            modProdButton.TabIndex = 5;
            modProdButton.Text = "Modify Product";
            modProdButton.UseVisualStyleBackColor = true;
            modProdButton.Click += modProdButton_Click;
            // 
            // addProdButton
            // 
            addProdButton.Location = new Point(225, 461);
            addProdButton.Name = "addProdButton";
            addProdButton.Size = new Size(122, 31);
            addProdButton.TabIndex = 4;
            addProdButton.Text = "Add Product";
            addProdButton.UseVisualStyleBackColor = true;
            addProdButton.Click += addProdButton_Click;
            // 
            // tabProdSupp
            // 
            tabProdSupp.Controls.Add(remProdSuppButton);
            tabProdSupp.Controls.Add(dgvProductSupplier);
            tabProdSupp.Controls.Add(modProdSuppButton);
            tabProdSupp.Controls.Add(addProdSuppButton);
            tabProdSupp.Location = new Point(4, 29);
            tabProdSupp.Margin = new Padding(3, 4, 3, 4);
            tabProdSupp.Name = "tabProdSupp";
            tabProdSupp.Size = new Size(930, 658);
            tabProdSupp.TabIndex = 2;
            tabProdSupp.Text = "Products_suppliers";
            tabProdSupp.UseVisualStyleBackColor = true;
            // 
            // remProdSuppButton
            // 
            remProdSuppButton.Location = new Point(489, 461);
            remProdSuppButton.Name = "remProdSuppButton";
            remProdSuppButton.Size = new Size(176, 31);
            remProdSuppButton.TabIndex = 6;
            remProdSuppButton.Text = "Remove Product Supplier";
            remProdSuppButton.UseVisualStyleBackColor = true;
            remProdSuppButton.Click += remProdSuppButton_Click;
            // 
            // dgvProductSupplier
            // 
            dgvProductSupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductSupplier.Location = new Point(0, 0);
            dgvProductSupplier.Name = "dgvProductSupplier";
            dgvProductSupplier.RowHeadersWidth = 51;
            dgvProductSupplier.Size = new Size(813, 455);
            dgvProductSupplier.TabIndex = 1;
            // 
            // modProdSuppButton
            // 
            modProdSuppButton.Location = new Point(329, 461);
            modProdSuppButton.Name = "modProdSuppButton";
            modProdSuppButton.Size = new Size(176, 31);
            modProdSuppButton.TabIndex = 5;
            modProdSuppButton.Text = "Modify Product Supplier";
            modProdSuppButton.UseVisualStyleBackColor = true;
            modProdSuppButton.Click += modProdSuppButton_Click;
            // 
            // addProdSuppButton
            // 
            addProdSuppButton.Location = new Point(169, 461);
            addProdSuppButton.Name = "addProdSuppButton";
            addProdSuppButton.Size = new Size(176, 31);
            addProdSuppButton.TabIndex = 4;
            addProdSuppButton.Text = "Add Product Supplier";
            addProdSuppButton.UseVisualStyleBackColor = true;
            addProdSuppButton.Click += addProdSuppButton_Click;
            // 
            // tabSuppliers
            // 
            tabSuppliers.Controls.Add(btnRemoveSup);
            tabSuppliers.Controls.Add(dgvSuppliers);
            tabSuppliers.Controls.Add(btnModifySup);
            tabSuppliers.Controls.Add(btnAddSup);
            tabSuppliers.Location = new Point(4, 24);
            tabSuppliers.Name = "tabSuppliers";
            tabSuppliers.Size = new Size(930, 658);
            tabSuppliers.TabIndex = 3;
            tabSuppliers.Text = "Suppliers";
            tabSuppliers.UseVisualStyleBackColor = true;
            // 
            // btnRemoveSup
            // 
            btnRemoveSup.Location = new Point(481, 461);
            btnRemoveSup.Name = "btnRemoveSup";
            btnRemoveSup.Size = new Size(107, 23);
            btnRemoveSup.TabIndex = 6;
            btnRemoveSup.Text = "Remove Supplier";
            btnRemoveSup.UseVisualStyleBackColor = true;
            btnRemoveSup.Click += btnRemoveSup_Click;
            // 
            // dgvSuppliers
            // 
            dgvSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSuppliers.Location = new Point(0, 0);
            dgvSuppliers.Name = "dgvSuppliers";
            dgvSuppliers.RowHeadersWidth = 51;
            dgvSuppliers.Size = new Size(813, 455);
            dgvSuppliers.TabIndex = 1;
            // 
            // btnModifySup
            // 
            btnModifySup.Location = new Point(353, 461);
            btnModifySup.Name = "btnModifySup";
            btnModifySup.Size = new Size(107, 23);
            btnModifySup.TabIndex = 5;
            btnModifySup.Text = "Modify Supplier";
            btnModifySup.UseVisualStyleBackColor = true;
            btnModifySup.Click += btnModifySup_Click;
            // 
            // btnAddSup
            // 
            btnAddSup.Location = new Point(225, 461);
            btnAddSup.Name = "btnAddSup";
            btnAddSup.Size = new Size(107, 23);
            btnAddSup.TabIndex = 4;
            btnAddSup.Text = "Add Supplier";
            btnAddSup.UseVisualStyleBackColor = true;
            btnAddSup.Click += btnAddSup_Click;
            // 
            // tabPackProdSupp
            // 
            tabPackProdSupp.Controls.Add(btnRemPackProdSupp);
            tabPackProdSupp.Controls.Add(btnModPackProdSupp);
            tabPackProdSupp.Controls.Add(btnAddPackProdSupp);
            tabPackProdSupp.Controls.Add(dgvPacksProdsSupps);
            tabPackProdSupp.Location = new Point(4, 24);
            tabPackProdSupp.Name = "tabPackProdSupp";
            tabPackProdSupp.Size = new Size(930, 658);
            tabPackProdSupp.TabIndex = 4;
            tabPackProdSupp.Text = "Packages_products_suppliers";
            tabPackProdSupp.UseVisualStyleBackColor = true;
            // 
            // btnRemPackProdSupp
            // 
            btnRemPackProdSupp.Location = new Point(525, 461);
            btnRemPackProdSupp.Name = "btnRemPackProdSupp";
            btnRemPackProdSupp.Size = new Size(225, 23);
            btnRemPackProdSupp.TabIndex = 4;
            btnRemPackProdSupp.Text = "Remove Package Product Supplier";
            btnRemPackProdSupp.UseVisualStyleBackColor = true;
            btnRemPackProdSupp.Click += btnRemPackProdSupp_Click;
            // 
            // btnModPackProdSupp
            // 
            btnModPackProdSupp.Location = new Point(294, 461);
            btnModPackProdSupp.Name = "btnModPackProdSupp";
            btnModPackProdSupp.Size = new Size(225, 23);
            btnModPackProdSupp.TabIndex = 3;
            btnModPackProdSupp.Text = "Modify Package Product Supplier";
            btnModPackProdSupp.UseVisualStyleBackColor = true;
            btnModPackProdSupp.Click += btnModPackProdSupp_Click;
            // 
            // btnAddPackProdSupp
            // 
            btnAddPackProdSupp.Location = new Point(63, 461);
            btnAddPackProdSupp.Name = "btnAddPackProdSupp";
            btnAddPackProdSupp.Size = new Size(225, 23);
            btnAddPackProdSupp.TabIndex = 2;
            btnAddPackProdSupp.Text = "Add Package Product Supplier";
            btnAddPackProdSupp.UseVisualStyleBackColor = true;
            btnAddPackProdSupp.Click += btnAddPackProdSupp_Click;
            // 
            // dgvPacksProdsSupps
            // 
            dgvPacksProdsSupps.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPacksProdsSupps.Location = new Point(0, 0);
            dgvPacksProdsSupps.Name = "dgvPacksProdsSupps";
            dgvPacksProdsSupps.RowHeadersWidth = 51;
            dgvPacksProdsSupps.Size = new Size(813, 455);
            dgvPacksProdsSupps.TabIndex = 1;
            // 
            // frmDatabaseViewer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 571);
            Controls.Add(tabControl);
            Name = "frmDatabaseViewer";
            Text = "Database Viewer";
            Load += MainForm_Load;
            tabControl.ResumeLayout(false);
            tabPackages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)packagesGrid).EndInit();
            tabProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            tabProdSupp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProductSupplier).EndInit();
            tabSuppliers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).EndInit();
            tabPackProdSupp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPacksProdsSupps).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPackages;
        private TabPage tabProducts;
        private TabPage tabProdSupp;
        private TabPage tabSuppliers;
        private TabPage tabPackProdSupp;
        private DataGridView packagesGrid;
        private DataGridView dgvProduct;
        private DataGridView dgvProductSupplier;
        private DataGridView dgvSuppliers;
        private DataGridView dgvPacksProdsSupps;
        private Button addPackageButton;
        private Button modPackageButton;
        private Button remPackageButton;
        private Button remProdButton;
        private Button modProdButton;
        private Button addProdButton;
        private Button remProdSuppButton;
        private Button modProdSuppButton;
        private Button addProdSuppButton;
        private Button btnRemoveSup;
        private Button btnModifySup;
        private Button btnAddSup;
        private Button btnRemPackProdSupp;
        private Button btnModPackProdSupp;
        private Button btnAddPackProdSupp;
    }
}