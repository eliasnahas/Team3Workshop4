﻿namespace Team3Workshop4
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
            button1 = new Button();
            suppliersGrid = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            tabPackProdSupp = new TabPage();
            packProdSuppGrid = new DataGridView();
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
            tabControl1.Size = new Size(938, 691);
            tabControl1.TabIndex = 0;
            // 
            // tabPackages
            // 
            tabPackages.Controls.Add(remPackageButton);
            tabPackages.Controls.Add(modPackageButton);
            tabPackages.Controls.Add(addPackageButton);
            tabPackages.Controls.Add(packagesGrid);
            tabPackages.Location = new Point(4, 29);
            tabPackages.Margin = new Padding(3, 4, 3, 4);
            tabPackages.Name = "tabPackages";
            tabPackages.Padding = new Padding(3, 4, 3, 4);
            tabPackages.Size = new Size(930, 658);
            tabPackages.TabIndex = 0;
            tabPackages.Text = "Packages";
            tabPackages.UseVisualStyleBackColor = true;
            // 
            // remPackageButton
            // 
            remPackageButton.Location = new Point(549, 615);
            remPackageButton.Margin = new Padding(3, 4, 3, 4);
            remPackageButton.Name = "remPackageButton";
            remPackageButton.Size = new Size(122, 29);
            remPackageButton.TabIndex = 3;
            remPackageButton.Text = "Remove Package";
            remPackageButton.UseVisualStyleBackColor = true;
            remPackageButton.Click += remPackageButton_Click;
            // 
            // modPackageButton
            // 
            modPackageButton.Location = new Point(400, 615);
            modPackageButton.Margin = new Padding(3, 4, 3, 4);
            modPackageButton.Name = "modPackageButton";
            modPackageButton.Size = new Size(122, 29);
            modPackageButton.TabIndex = 2;
            modPackageButton.Text = "Modify Package";
            modPackageButton.UseVisualStyleBackColor = true;
            modPackageButton.Click += modPackageButton_Click;
            // 
            // addPackageButton
            // 
            addPackageButton.Location = new Point(255, 615);
            addPackageButton.Margin = new Padding(3, 4, 3, 4);
            addPackageButton.Name = "addPackageButton";
            addPackageButton.Size = new Size(122, 29);
            addPackageButton.TabIndex = 1;
            addPackageButton.Text = "Add Package";
            addPackageButton.UseVisualStyleBackColor = true;
            addPackageButton.Click += addPackageButton_Click;
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
            // tabProducts
            // 
            tabProducts.Controls.Add(remProdButton);
            tabProducts.Controls.Add(productsGrid);
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
            remProdButton.Location = new Point(547, 615);
            remProdButton.Margin = new Padding(3, 4, 3, 4);
            remProdButton.Name = "remProdButton";
            remProdButton.Size = new Size(122, 31);
            remProdButton.TabIndex = 6;
            remProdButton.Text = "Remove Product";
            remProdButton.UseVisualStyleBackColor = true;
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
            // modProdButton
            // 
            modProdButton.Location = new Point(399, 615);
            modProdButton.Margin = new Padding(3, 4, 3, 4);
            modProdButton.Name = "modProdButton";
            modProdButton.Size = new Size(122, 31);
            modProdButton.TabIndex = 5;
            modProdButton.Text = "Modify Product";
            modProdButton.UseVisualStyleBackColor = true;
            // 
            // addProdButton
            // 
            addProdButton.Location = new Point(254, 615);
            addProdButton.Margin = new Padding(3, 4, 3, 4);
            addProdButton.Name = "addProdButton";
            addProdButton.Size = new Size(122, 31);
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
            remProdSuppButton.Location = new Point(557, 615);
            remProdSuppButton.Margin = new Padding(3, 4, 3, 4);
            remProdSuppButton.Name = "remProdSuppButton";
            remProdSuppButton.Size = new Size(176, 31);
            remProdSuppButton.TabIndex = 6;
            remProdSuppButton.Text = "Remove Product Supplier";
            remProdSuppButton.UseVisualStyleBackColor = true;
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
            // modProdSuppButton
            // 
            modProdSuppButton.Location = new Point(191, 615);
            modProdSuppButton.Margin = new Padding(3, 4, 3, 4);
            modProdSuppButton.Name = "modProdSuppButton";
            modProdSuppButton.Size = new Size(176, 31);
            modProdSuppButton.TabIndex = 5;
            modProdSuppButton.Text = "Modify Product Supplier";
            modProdSuppButton.UseVisualStyleBackColor = true;
            // 
            // addProdSuppButton
            // 
            addProdSuppButton.Location = new Point(374, 615);
            addProdSuppButton.Margin = new Padding(3, 4, 3, 4);
            addProdSuppButton.Name = "addProdSuppButton";
            addProdSuppButton.Size = new Size(176, 31);
            addProdSuppButton.TabIndex = 4;
            addProdSuppButton.Text = "Add Product Supplier";
            addProdSuppButton.UseVisualStyleBackColor = true;
            // 
            // tabSuppliers
            // 
            tabSuppliers.Controls.Add(button1);
            tabSuppliers.Controls.Add(suppliersGrid);
            tabSuppliers.Controls.Add(button2);
            tabSuppliers.Controls.Add(button3);
            tabSuppliers.Location = new Point(4, 29);
            tabSuppliers.Margin = new Padding(3, 4, 3, 4);
            tabSuppliers.Name = "tabSuppliers";
            tabSuppliers.Size = new Size(930, 658);
            tabSuppliers.TabIndex = 3;
            tabSuppliers.Text = "Suppliers";
            tabSuppliers.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(547, 615);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(122, 31);
            button1.TabIndex = 6;
            button1.Text = "Remove Supplier";
            button1.UseVisualStyleBackColor = true;
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
            // button2
            // 
            button2.Location = new Point(399, 615);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(122, 31);
            button2.TabIndex = 5;
            button2.Text = "Modify Supplier";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(254, 615);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(122, 31);
            button3.TabIndex = 4;
            button3.Text = "Add Supplier";
            button3.UseVisualStyleBackColor = true;
            // 
            // tabPackProdSupp
            // 
            tabPackProdSupp.Controls.Add(packProdSuppGrid);
            tabPackProdSupp.Location = new Point(4, 29);
            tabPackProdSupp.Margin = new Padding(3, 4, 3, 4);
            tabPackProdSupp.Name = "tabPackProdSupp";
            tabPackProdSupp.Size = new Size(930, 658);
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
            // frmDatabaseViewer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 761);
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
        private Button remProdButton;
        private Button modProdButton;
        private Button addProdButton;
        private Button remProdSuppButton;
        private Button modProdSuppButton;
        private Button addProdSuppButton;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}