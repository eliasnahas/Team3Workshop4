﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertsData;
using TravelSources;

namespace Team3Workshop4
{
    public partial class frmDatabaseViewer : Form
    {
        public frmDatabaseViewer()
        {
            InitializeComponent();
        }

        private Package selectedPackage = null!;

        // Operations done when the Database Viewer loads
        private void MainForm_Load(object sender, EventArgs e)
        {
            // gets width of grid for calculating even column widths;
            int dgvWidth = packagesGrid.Width;

            // Set DataGridViewer sources, display without extra fields
            // Packages
            packagesGrid.DataSource = TravelSource.GetPackages();

            // Products
            productsGrid.DataSource = TravelSource.GetProducts();

            // Products_Suppliers
            prodSuppGrid.DataSource = TravelSource.GetProdSupps();

            // Suppliers
            suppliersGrid.DataSource = TravelSource.GetSuppliers();

            // Packages_Products_Suppliers
            dgvPacksProdsSupps.DataSource = TravelSource.GetPacksProdsSupps();

            // Auto-scale columns to be at least as long as their data
            productsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            prodSuppGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            suppliersGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

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
    }
}
