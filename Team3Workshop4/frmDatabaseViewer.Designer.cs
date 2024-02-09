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
            modPackageButton = new Button();
            addPackageButton = new Button();
            packagesGrid = new DataGridView();
            tabProducts = new TabPage();
            remProdButton = new Button();
            productsGrid = new DataGridView();
            modProdButton = new Button();
            addProdButton = new Button();
            tabProdSupp = new TabPage();
            remProdSuppButton = new Button();
            prodSuppGrid = new DataGridView();
            modProdSuppButton = new Button();
            addProdSuppButton = new Button();
            tabSuppliers = new TabPage();
            btnRemoveSup = new Button();
            dgvSuppliers = new DataGridView();
            btnModifySup = new Button();
            btnAddSup = new Button();
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
            tabPackages.Controls.Add(modPackageButton);
            tabPackages.Controls.Add(addPackageButton);
            tabPackages.Controls.Add(packagesGrid);
            tabPackages.Location = new Point(4, 24);
            tabPackages.Name = "tabPackages";
            tabPackages.Padding = new Padding(3);
            tabPackages.Padding = new Padding(3);
            tabPackages.Size = new Size(813, 490);
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
            // modPackageButton
            // 
            modPackageButton.Location = new Point(350, 461);
            modPackageButton.Name = "modPackageButton";
            modPackageButton.Size = new Size(107, 23);
            modPackageButton.TabIndex = 2;
            modPackageButton.Text = "Modify Package";
            modPackageButton.UseVisualStyleBackColor = true;
            modPackageButton.Click += modPackageButton_Click;
            // 
            // addPackageButton
            // 
            addPackageButton.Location = new Point(223, 461);
            addPackageButton.Name = "addPackageButton";
            addPackageButton.Size = new Size(107, 23);
            addPackageButton.TabIndex = 1;
            addPackageButton.Text = "Add Package";
            addPackageButton.UseVisualStyleBackColor = true;
            addPackageButton.Click += addPackageButton_Click;
            // 
            // packagesGrid
            // 
            packagesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            packagesGrid.Location = new Point(0, 0);
            packagesGrid.Name = "packagesGrid";
            packagesGrid.RowHeadersWidth = 51;
            packagesGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            packagesGrid.Size = new Size(813, 455);
            packagesGrid.TabIndex = 0;
            // 
            // tabProducts
            // 
            tabProducts.Controls.Add(remProdButton);
            tabProducts.Controls.Add(productsGrid);
            tabProducts.Controls.Add(modProdButton);
            tabProducts.Controls.Add(addProdButton);
            tabProducts.Location = new Point(4, 24);
            tabProducts.Name = "tabProducts";
            tabProducts.Padding = new Padding(3);
            tabProducts.Size = new Size(813, 490);
            tabProducts.TabIndex = 1;
            tabProducts.Text = "Products";
            tabProducts.UseVisualStyleBackColor = true;
            // 
            // remProdButton
            // 
            remProdButton.Location = new Point(479, 461);
            remProdButton.Name = "remProdButton";
            remProdButton.Size = new Size(107, 23);
            remProdButton.TabIndex = 6;
            remProdButton.Text = "Remove Product";
            remProdButton.UseVisualStyleBackColor = true;
            // 
            // remProdButton
            // 
            remProdButton.Location = new Point(479, 461);
            remProdButton.Name = "remProdButton";
            remProdButton.Size = new Size(107, 23);
            remProdButton.TabIndex = 6;
            remProdButton.Text = "Remove Product";
            remProdButton.UseVisualStyleBackColor = true;
            // 
            // productsGrid
            // 
            productsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsGrid.Location = new Point(0, 0);
            productsGrid.Name = "productsGrid";
            productsGrid.RowHeadersWidth = 51;
            productsGrid.Size = new Size(813, 455);
            productsGrid.TabIndex = 1;
            // 
            // modProdButton
            // 
            modProdButton.Location = new Point(349, 461);
            modProdButton.Name = "modProdButton";
            modProdButton.Size = new Size(107, 23);
            modProdButton.TabIndex = 5;
            modProdButton.Text = "Modify Product";
            modProdButton.UseVisualStyleBackColor = true;
            // 
            // addProdButton
            // 
            addProdButton.Location = new Point(222, 461);
            addProdButton.Name = "addProdButton";
            addProdButton.Size = new Size(107, 23);
            addProdButton.TabIndex = 4;
            addProdButton.Text = "Add Product";
            addProdButton.UseVisualStyleBackColor = true;
            // 
            // tabProdSupp
            // 
            tabProdSupp.Controls.Add(remProdSuppButton);
            tabProdSupp.Controls.Add(prodSuppGrid);
            tabProdSupp.Controls.Add(modProdSuppButton);
            tabProdSupp.Controls.Add(addProdSuppButton);
            tabProdSupp.Location = new Point(4, 24);
            tabProdSupp.Name = "tabProdSupp";
            tabProdSupp.Size = new Size(813, 490);
            tabProdSupp.TabIndex = 2;
            tabProdSupp.Text = "Products_suppliers";
            tabProdSupp.UseVisualStyleBackColor = true;
            // 
            // remProdSuppButton
            // 
            remProdSuppButton.Location = new Point(487, 461);
            remProdSuppButton.Name = "remProdSuppButton";
            remProdSuppButton.Size = new Size(154, 23);
            remProdSuppButton.TabIndex = 6;
            remProdSuppButton.Text = "Remove Product Supplier";
            remProdSuppButton.UseVisualStyleBackColor = true;
            // 
            // prodSuppGrid
            // 
            prodSuppGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            prodSuppGrid.Location = new Point(0, 0);
            prodSuppGrid.Name = "prodSuppGrid";
            prodSuppGrid.RowHeadersWidth = 51;
            prodSuppGrid.Size = new Size(813, 455);
            prodSuppGrid.TabIndex = 1;
            // 
            // modProdSuppButton
            // 
            modProdSuppButton.Location = new Point(167, 461);
            modProdSuppButton.Name = "modProdSuppButton";
            modProdSuppButton.Size = new Size(154, 23);
            modProdSuppButton.TabIndex = 5;
            modProdSuppButton.Text = "Modify Product Supplier";
            modProdSuppButton.UseVisualStyleBackColor = true;
            // 
            // addProdSuppButton
            // 
            addProdSuppButton.Location = new Point(327, 461);
            addProdSuppButton.Name = "addProdSuppButton";
            addProdSuppButton.Size = new Size(154, 23);
            addProdSuppButton.TabIndex = 4;
            addProdSuppButton.Text = "Add Product Supplier";
            addProdSuppButton.UseVisualStyleBackColor = true;
            // 
            // tabSuppliers
            // 
            tabSuppliers.Controls.Add(btnRemoveSup);
            tabSuppliers.Controls.Add(dgvSuppliers);
            tabSuppliers.Controls.Add(btnModifySup);
            tabSuppliers.Controls.Add(btnAddSup);
            tabSuppliers.Location = new Point(4, 24);
            tabSuppliers.Name = "tabSuppliers";
            tabSuppliers.Size = new Size(813, 490);
            tabSuppliers.TabIndex = 3;
            tabSuppliers.Text = "Suppliers";
            tabSuppliers.UseVisualStyleBackColor = true;
            // 
            // btnRemoveSup
            // 
            btnRemoveSup.Location = new Point(479, 461);
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
            btnModifySup.Location = new Point(349, 461);
            btnModifySup.Name = "btnModifySup";
            btnModifySup.Size = new Size(107, 23);
            btnModifySup.TabIndex = 5;
            btnModifySup.Text = "Modify Supplier";
            btnModifySup.UseVisualStyleBackColor = true;
            btnModifySup.Click += btnModifySup_Click;
            // 
            // btnAddSup
            // 
            btnAddSup.Location = new Point(222, 461);
            btnAddSup.Name = "btnAddSup";
            btnAddSup.Size = new Size(107, 23);
            btnAddSup.TabIndex = 4;
            btnAddSup.Text = "Add Supplier";
            btnAddSup.UseVisualStyleBackColor = true;
            btnAddSup.Click += btnAddSup_Click;
            // 
            // tabPackProdSupp
            // 
            tabPackProdSupp.Controls.Add(packProdSuppGrid);
            tabPackProdSupp.Location = new Point(4, 24);
            tabPackProdSupp.Name = "tabPackProdSupp";
            tabPackProdSupp.Size = new Size(813, 490);
            tabPackProdSupp.TabIndex = 4;
            tabPackProdSupp.Text = "Packages_products_suppliers";
            tabPackProdSupp.UseVisualStyleBackColor = true;
            // 
            // packProdSuppGrid
            // 
            packProdSuppGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            packProdSuppGrid.Location = new Point(0, 0);
            packProdSuppGrid.Name = "packProdSuppGrid";
            packProdSuppGrid.RowHeadersWidth = 51;
            packProdSuppGrid.Size = new Size(813, 455);
            packProdSuppGrid.TabIndex = 1;
            // 
            // addPackageButton
            // 
            addPackageButton.Location = new Point(238, 536);
            addPackageButton.Name = "addPackageButton";
            addPackageButton.Size = new Size(107, 23);
            addPackageButton.TabIndex = 1;
            addPackageButton.Text = "Add Package";
            addPackageButton.UseVisualStyleBackColor = true;
            addPackageButton.Click += addPackageButton_Click;
            // 
            // modPackageButton
            // 
            modPackageButton.Location = new Point(365, 536);
            modPackageButton.Name = "modPackageButton";
            modPackageButton.Size = new Size(107, 23);
            modPackageButton.TabIndex = 2;
            modPackageButton.Text = "Modify Package";
            modPackageButton.UseVisualStyleBackColor = true;
            modPackageButton.Click += modPackageButton_Click;
            // 
            // remPackageButton
            // 
            remPackageButton.Location = new Point(495, 536);
            remPackageButton.Name = "remPackageButton";
            remPackageButton.Size = new Size(107, 23);
            remPackageButton.TabIndex = 3;
            remPackageButton.Text = "Remove Package";
            remPackageButton.UseVisualStyleBackColor = true;
            remPackageButton.Click += remPackageButton_Click;
            // 
            // frmDatabaseViewer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
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
            ((System.ComponentModel.ISupportInitialize)productsGrid).EndInit();
            tabProdSupp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)prodSuppGrid).EndInit();
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
        private DataGridView productsGrid;
        private DataGridView prodSuppGrid;
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
        private Button btnAddPackProdSupp;
        private Button btnRemPackProdSupp;
        private Button btnModPackProdSupp;
    }
}