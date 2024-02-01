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
            productsGrid.Columns["ProdName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Products_Suppliers
            prodSuppGrid.DataSource = TravelSource.GetProdSupps();

        }

        private void addPackageButton_Click(object sender, EventArgs e)
        {

        }

        private void modPackageButton_Click(object sender, EventArgs e)
        {
            selectedPackage = TravelSource.FindPackage((int)packagesGrid.SelectedRows[0].Cells[0].Value);
            if (selectedPackage != null)
            {
                frmAddModifyPackage addModifyPackageForm = new()
                {
                    package = selectedPackage
                };
                DialogResult result = addModifyPackageForm.ShowDialog();
            }
        }

        private void addProdButton_Click(object sender, EventArgs e)
        {

        }

        private void modProdButton_Click(object sender, EventArgs e)
        {

        }

        private void remProdButton_Click(object sender, EventArgs e)
        {
            // Remove product from database
            
            // Refresh grid view
        }
    }
}
