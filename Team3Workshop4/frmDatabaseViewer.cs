﻿using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertsData;
using TravelExpertsGUI;
using TravelSources;

namespace Team3Workshop4
{
    public partial class frmDatabaseViewer : Form
    {
        public frmDatabaseViewer()
        {
            InitializeComponent();
            UpdateDataGridView();
        }
        // product variables Jack
        private Product? selectedProduct = null;
        string productID;
        int productIDNum;
        string productSupplierID;
        int productSupplierIDNum;

        // Product Supplier Variables Jack
        private ProductsSupplier? ProductsSupplier = null;
        private Supplier? selectedSupplier = null;


        private Package selectedPackage = null!;


        // Operations done when the Database Viewer loads
        private void MainForm_Load(object sender, EventArgs e)
        {
            // gets width of grid for calculating even column widths;
            int dgvWidth = packagesGrid.Width;

            // Set DataGridViewer sources, display without extra fields
            // Set DataGridViewer sources, display without extra fields
            // Packages

            packagesGrid.DataSource = TravelSource.GetPackages();


            // Products
            dgvProduct.DataSource = TravelSource.GetProducts();


            // Products_Suppliers
            dgvProductSupplier.DataSource = TravelSource.GetProdSupps();


            // Suppliers
            dgvSuppliers.DataSource = TravelSource.GetSuppliers();

            // Packages_Products_Suppliers
            dgvPacksProdsSupps.DataSource = TravelSource.GetPacksProdsSupps();

            // Auto-scale columns to be at least as long as their data
            dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvProductSupplier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // except packages
            // Stretch last 2 columns to *just* fit in its dgv
            packagesGrid.Columns["PkgBasePrice"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            packagesGrid.Columns["PkgAgencyCommission"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////

        //// Functions for Packages
        private void modPackageButton_Click(object sender, EventArgs e)
        {
            selectedPackage = TravelSource.FindPackage((int)packagesGrid.SelectedRows[0].Cells[0].Value);
            if (selectedPackage != null)
            {
                // display second form with current data
                // and collect new data values
                frmAddModifyPackage addModifyPackageForm = new()
                {
                    isAdd = false, // is Modify operation
                    package = selectedPackage // pass selected package to second form
                };
                DialogResult result = addModifyPackageForm.ShowDialog();
                if (result == DialogResult.OK) // second form collected new data
                {
                    selectedPackage = addModifyPackageForm.package;
                    // perform the update
                    TravelSource.ModifyPackage(selectedPackage);
                    DisplayPackages();
                }
            }
        }

        private void addPackageButton_Click(object sender, EventArgs e)
        {
            // display second form to collect data
            frmAddModifyPackage addModifyPackageForm = new()
            {
                isAdd = true, // is Add operation
                package = null // no package yet
            };
            DialogResult result = addModifyPackageForm.ShowDialog();
            if (result == DialogResult.OK) // second form collected data
            {
                selectedPackage = addModifyPackageForm.package;
                // add it to the Packages table
                TravelSource.AddPackage(selectedPackage);
                DisplayPackages();
            }
        }

        private void remPackageButton_Click(object sender, EventArgs e)
        {
            selectedPackage = TravelSource.FindPackage((int)packagesGrid.SelectedRows[0].Cells[0].Value);
            if (selectedPackage != null)
            {
                DialogResult answer = MessageBox.Show(
                    $"Do you really want to delete {selectedPackage.PkgName}?",
                    "Confirm delete", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (answer == DialogResult.Yes) // user confirmed
                {
                    TravelSource.DeletePackage(selectedPackage);
                    DisplayPackages();
                }
            }
        }

        private void DisplayPackages()
        {
            packagesGrid.DataSource = TravelSource.GetPackages();
        }


        // author: Gurleen
        // date: Jan 30, 2023
        private void btnAddSup_Click(object sender, EventArgs e)
        {
            frmAddSupplier addSupplierForm = new frmAddSupplier();
            addSupplierForm.ShowDialog();

            UpdateDataGridView();
        }

        private void UpdateDataGridView()
        {
            TravelSource.GetSuppliers();
            {
                // Bind the list of suppliers to the DataGridView
                dgvSuppliers.DataSource = TravelSource.GetSuppliers();
            }
        }

        private void btnModifySup_Click(object sender, EventArgs e)
        {
            int supplierId = (int)dgvSuppliers.CurrentRow.Cells[0].Value;

            using (var context = new TravelExpertsContext())
            {
                Supplier selectedSupplier = context.Suppliers.Find(supplierId);

                if (selectedSupplier != null)
                {
                    frmModifySupplier modifySupplierForm = new frmModifySupplier(selectedSupplier);
                    modifySupplierForm.ShowDialog();

                    UpdateDataGridView();
                }
                else
                {
                    MessageBox.Show("Unable to find the selected supplier.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRemoveSup_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this supplier?",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int supplierId = (int)dgvSuppliers.CurrentRow.Cells[0].Value;
                using (var context = new TravelExpertsContext())
                {
                    Supplier selectedSupplier = context.Suppliers.Find(supplierId);
                    context.Entry(selectedSupplier).State = EntityState.Deleted;
                    context.SaveChanges();
                }

                UpdateDataGridView();

            }
            else
            {
                MessageBox.Show("Please select a supplier to modify.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        ///////////////////////////////////////////////////////////////////////////////////////////////////////

        //// Functions for Packages_Products_Suppliers      
        private void btnAddPackProdSupp_Click(object sender, EventArgs e)
        {
            frmAddModifyPackProdSupp form = new frmAddModifyPackProdSupp();
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                TravelSource.AddToPackProdSupps(form.entry);
            }
        }

        private void btnModPackProdSupp_Click(object sender, EventArgs e)
        {
            frmAddModifyPackProdSupp form = new frmAddModifyPackProdSupp();
            DialogResult result = form.ShowDialog();
            if(result == DialogResult.OK)
            {

            }
        }

        
        private void btnRemPackProdSupp_Click(object sender, EventArgs e)
        {
            int selectedRowPPSId = (int)dgvPacksProdsSupps.CurrentRow.Cells[0].Value; // gets the PackageProductSupplerId of the current row
            PackagesProductsSupplier selectedPPS = TravelSource.GetPackProdSuppFromId(selectedRowPPSId);

            // Based on the code from remPackageButton_Click()
            if (selectedPackage != null)
            {
                DialogResult answer = MessageBox.Show(
                    $"Do you really want to delete the entry at PackageProductSupplierId #{selectedPPS.PackageProductSupplierId}?",
                    "Confirm Deletion of Entry", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (answer == DialogResult.Yes) // user confirms
                {
                    TravelSource.DeletePackage(selectedPackage);
                    DisplayPackages();
                }
                // user cancels; action is canceled.
            }
        }
        // method for displaying product table
        private void DisplayProduct()
        {
            dgvProduct.DataSource = TravelSource.GetProducts();
        }
        // method for displaying Product Supplier table
        private void DisplayProductSupplier()
        {
            dgvProductSupplier.DataSource = TravelSource.GetProdSupps();
        }

        // product table controls

        // product add
        private void addProdButton_Click(object sender, EventArgs e)
        {
            frmAddModifyProduct secondForm = new frmAddModifyProduct();
            secondForm.isAdd = true;
            DialogResult result = secondForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                selectedProduct = secondForm.product;
                using (TravelExpertsContext db = new TravelExpertsContext())
                {
                    db.Products.Add(selectedProduct);
                    db.SaveChanges();
                }
                DisplayProduct();
            }
        }
        // product modify
        private void modProdButton_Click(object sender, EventArgs e)
        {
            productID = dgvProduct.CurrentRow.Cells[0].Value.ToString();
            productIDNum = Convert.ToInt32(productID);
            TravelExpertsContext prod = new TravelExpertsContext();
            selectedProduct = prod.Products.Find(productIDNum);
            frmAddModifyProduct secondForm = new frmAddModifyProduct();
            secondForm.isAdd = false;
            secondForm.product = selectedProduct;
            DialogResult result = secondForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                using (TravelExpertsContext db = new TravelExpertsContext())
                {

                    db.Products.Update(secondForm.product);
                    db.SaveChanges();
                    dgvProduct.DataSource = TravelSource.GetProducts();
                }
            }
        }

        // product remove
        private void remProdButton_Click(object sender, EventArgs e)
        {
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                productID = dgvProduct.CurrentRow.Cells[0].Value.ToString();
                productIDNum = Convert.ToInt32(productID);
                selectedProduct = db.Products.Find(productIDNum);
                db.Products.Remove(selectedProduct);
                db.SaveChanges();
            }
            dgvProduct.DataSource = TravelSource.GetProducts();
        }


        // Add ProductSupplier
        private void addProdSuppButton_Click(object sender, EventArgs e)
        {
            frmAddModifyProductSupplier ProdSuppForm = new frmAddModifyProductSupplier();
            ProdSuppForm.isAdd = true;
            DialogResult result = ProdSuppForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                ProductsSupplier = ProdSuppForm.ProdSupp;
                using (TravelExpertsContext db = new TravelExpertsContext())
                {
                    db.ProductsSuppliers.Add(ProductsSupplier);
                    db.SaveChanges();
                    
                }
                dgvProductSupplier.DataSource = TravelSource.GetProdSupps();
            }
        }

        // modify ProductSupplier 
        private void modProdSuppButton_Click(object sender, EventArgs e)
        {
            productSupplierID = dgvProductSupplier.CurrentRow.Cells[0].Value.ToString();
            productSupplierIDNum = Convert.ToInt32(productSupplierID);
            TravelExpertsContext prodSupp = new TravelExpertsContext();
            ProductsSupplier = prodSupp.ProductsSuppliers.Find(productSupplierIDNum);

            frmAddModifyProductSupplier ProdSuppForm = new frmAddModifyProductSupplier();
            ProdSuppForm.isAdd = false;
            ProdSuppForm.ProdSupp = ProductsSupplier;
            DialogResult result = ProdSuppForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                using (TravelExpertsContext db = new TravelExpertsContext())
                {

                    db.ProductsSuppliers.Update(ProdSuppForm.ProdSupp);
                    db.SaveChanges();
                    dgvProductSupplier.DataSource = TravelSource.GetProdSupps();
                }
            }
        }

        // Remove ProductSupplier
        private void remProdSuppButton_Click(object sender, EventArgs e)
        {
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                productSupplierID = dgvProductSupplier.CurrentRow.Cells[0].Value.ToString();
                productSupplierIDNum = Convert.ToInt32(productSupplierID);
                ProductsSupplier = db.ProductsSuppliers.Find(productSupplierIDNum);
                db.ProductsSuppliers.Remove(ProductsSupplier);
                db.SaveChanges();
            }
            dgvProductSupplier.DataSource = TravelSource.GetProdSupps();
        }
    }
}
