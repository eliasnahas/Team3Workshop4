﻿using System;
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

        // Operations done when the Database Viewer loads
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Set DataGridViewer sources, display without extra fields 
            // Products
            productsGrid.DataSource = TravelSource.GetProducts();
            productsGrid.Columns["ProductsSuppliers"].Visible = false;

            // Products_Suppliers
            prodSuppGrid.DataSource = TravelSource.GetProdSupps();
            prodSuppGrid.Columns["BookingDetails"].Visible = false;
            prodSuppGrid.Columns["Product"].Visible = false;
            prodSuppGrid.Columns["Supplier"].Visible = false;
            prodSuppGrid.Columns["Packages"].Visible = false;



        }

        private void addPackageButton_Click(object sender, EventArgs e)
        {

        }

        private void modPackageButton_Click(object sender, EventArgs e)
        {
            frmAddModifyPackage modWindow = new frmAddModifyPackage();
            modWindow.ShowDialog();
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
