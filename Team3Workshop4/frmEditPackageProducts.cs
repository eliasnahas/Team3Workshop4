using GridData;
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
    /*
     * Auxilliary form to add or remove products
     * from a particular package
     * Author: Elias Nahas
     * When: Feb 2024
     */
    public partial class frmEditPackageProducts : Form
    {
        public List<ProdSuppNames>? packageProductSuppliers;
        public List<ProdSuppNames>? availableProductSuppliers;
        public int packageId;
        public frmEditPackageProducts()
        {
            InitializeComponent();
        }

        private void DisplayProducts()
        {
            if (packageProductSuppliers != null)
            {
                dgvAddedProducts.DataSource = packageProductSuppliers;
                dgvAddedProducts.Columns[0].HeaderText = "Products";
                dgvAddedProducts.Columns[1].HeaderText = "Suppliers";
                dgvAddedProducts.AutoResizeColumns();
            }
            if (availableProductSuppliers != null)
            {
                dgvAvailableProducts.DataSource = availableProductSuppliers;
                dgvAvailableProducts.Columns[0].HeaderText = "Products";
                dgvAvailableProducts.Columns[1].HeaderText = "Suppliers";
                dgvAvailableProducts.AutoResizeColumns();
            }
        }

        private void frmEditPackageProducts_Load(object sender, EventArgs e)
        {
            DisplayProducts();
        }

        // Add Product to Package
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int idx = dgvAvailableProducts.CurrentCell.RowIndex;
            if (idx != -1)
            {
                ProdSuppNames itemToTransfer = availableProductSuppliers[idx];
                if (itemToTransfer != null)
                {
                    using (TravelExpertsContext db = new TravelExpertsContext())
                    {
                        Product prod = db.Products.Where(p => p.ProdName == itemToTransfer.ProdName).FirstOrDefault();
                        Supplier supp = db.Suppliers.Where(s => s.SupName == itemToTransfer.SuppName).FirstOrDefault();
                        ProductsSupplier prodSupp = db.ProductsSuppliers.Where(ps => ps.ProductId == prod.ProductId).Where(ps => ps.SupplierId == supp.SupplierId).FirstOrDefault();
                        PackagesProductsSupplier ppsToAdd = new PackagesProductsSupplier()
                        {
                            PackageId = packageId,
                            ProductSupplierId = prodSupp.ProductSupplierId
                        };
                        db.PackagesProductsSuppliers.Add(ppsToAdd);
                        db.SaveChanges();

                        packageProductSuppliers.Add(itemToTransfer);
                        availableProductSuppliers.Remove(itemToTransfer);
                        packageProductSuppliers = packageProductSuppliers.OrderBy(i => i.ProdName).ThenBy(i => i.SuppName).ToList();
                        availableProductSuppliers = availableProductSuppliers.OrderBy(i => i.ProdName).ThenBy(i => i.SuppName).ToList();
                        dgvAddedProducts.DataSource = null;
                        dgvAvailableProducts.DataSource = null;
                        DisplayProducts();
                    }
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int idx = dgvAddedProducts.CurrentCell.RowIndex;
            if (idx != -1)
            {
                ProdSuppNames itemToTransfer = packageProductSuppliers[idx];
                if (itemToTransfer != null)
                {
                    using (TravelExpertsContext db = new TravelExpertsContext())
                    {
                        Product prod = db.Products.Where(p => p.ProdName == itemToTransfer.ProdName).FirstOrDefault();
                        Supplier supp = db.Suppliers.Where(s => s.SupName == itemToTransfer.SuppName).FirstOrDefault();
                        ProductsSupplier prodSupp = db.ProductsSuppliers.Where(ps => ps.ProductId == prod.ProductId).Where(ps => ps.SupplierId == supp.SupplierId).FirstOrDefault();
                        PackagesProductsSupplier ppsToDelete = db.PackagesProductsSuppliers.Where(pps => packageId == packageId).Where(pps => pps.ProductSupplierId == prodSupp.ProductSupplierId).FirstOrDefault();
                        db.PackagesProductsSuppliers.Remove(ppsToDelete);
                        db.SaveChanges();

                        packageProductSuppliers.Remove(itemToTransfer);
                        availableProductSuppliers.Add(itemToTransfer);
                        packageProductSuppliers = packageProductSuppliers.OrderBy(i => i.ProdName).ThenBy(i => i.SuppName).ToList();
                        availableProductSuppliers = availableProductSuppliers.OrderBy(i => i.ProdName).ThenBy(i => i.SuppName).ToList();
                        dgvAddedProducts.DataSource = null;
                        dgvAvailableProducts.DataSource = null;
                        DisplayProducts();
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
