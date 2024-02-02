using Microsoft.Data.SqlClient;
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

            DisplayPackages();

            // Products
            productsGrid.DataSource = TravelSource.GetProducts();
            

            // Products_Suppliers
            prodSuppGrid.DataSource = TravelSource.GetProdSupps();
            

            // Suppliers
            suppliersGrid.DataSource = TravelSource.GetSuppliers();

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
        // Modify package - by: Elias Nahas
        private void modPackageButton_Click(object sender, EventArgs e)
        {
            int packageId = (int)packagesGrid.SelectedRows[0].Cells[0].Value;
            selectedPackage = TravelSource.FindPackage(packageId);
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
                    DisplayPackages(selectedPackage.PackageId);
                }
            }
        }

        // Add new package - by: Elias Nahas
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
                selectedPackage = addModifyPackageForm.package!;
                // add it to the Packages table
                TravelSource.AddPackage(selectedPackage);
                DisplayPackages(selectedPackage.PackageId);
            }
        }

        // Delete package - by: Elias Nahas
        private void remPackageButton_Click(object sender, EventArgs e)
        {
            int packageId = (int)packagesGrid.SelectedRows[0].Cells[0].Value;
            selectedPackage = TravelSource.FindPackage(packageId);
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

        // Displays and refreshes list of packages
        private void DisplayPackages(int packageId = 0)
        {
            packagesGrid.DataSource = TravelSource.GetPackages();
            // formatting the columns in short date time and currency formats
            packagesGrid.Columns["PkgStartDate"].DefaultCellStyle.Format = "M/dd/yyyy";
            packagesGrid.Columns["PkgEndDate"].DefaultCellStyle.Format = "M/dd/yyyy";
            packagesGrid.Columns["PkgBasePrice"].DefaultCellStyle.Format = "c";
            packagesGrid.Columns["PkgAgencyCommission"].DefaultCellStyle.Format = "c";
            // selects the current package from the list
            foreach (DataGridViewRow row in packagesGrid.Rows)
            {
                if ((int)row.Cells[0].Value == packageId)
                {
                    packagesGrid.ClearSelection();
                    packagesGrid.CurrentCell = packagesGrid.Rows[row.Index].Cells[0];
                }
            }
        }
    }
}
