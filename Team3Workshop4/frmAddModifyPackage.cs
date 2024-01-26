using Castle.Core.Resource;
using Microsoft.EntityFrameworkCore;
using System;
using TravelExpertsData;

namespace Team3Workshop4
{
    /* 
     * Auxilliary form to collect data for Add or Modify operation
     * for Packages and the Products they contain
     * Author: Elias Nahas
     * When: Jan 2024
     */
    public partial class frmAddModifyPackage : Form
    {
        // public declaration to provide access to main form
        public bool isAdd; // true when Add, false when Modify
        public Package? package; // new package data
        // public List<Product>? products; // empty list of products
        public frmAddModifyPackage()
        {
            InitializeComponent();
        }

        // when the package form loads
        private void frmAddModifyPackage_Load(object sender, EventArgs e)
        {
            if (isAdd)
            {
                Text = "Add Package";
            }
            else
            {
                Text = "Modify Package";
                DisplayPackage();
            }
        }

        // displays current package for Modify
        private void DisplayPackage()
        {
            // mockup data
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                package = db.Packages.Find(1);

                var packagesProductsSuppliers = package?.ProductSuppliers
                            .Select(p => new
                            {
                                Product = p.Product?.ProdName,
                                Supplier = p.Supplier?.SupName
                            })
                            .ToList();

                if (packagesProductsSuppliers != null)
                {
                    int i = 0;
                    foreach (var packagesProductsSupplier in packagesProductsSuppliers)
                    {
                        lvProducts.Items.Add(packagesProductsSupplier.Product);
                        lvProducts.Items[i].SubItems.Add(packagesProductsSupplier.Supplier);
                        i += 1;
                    }
                }
            }

            if (package != null) // if not null
            {
                txtPkgName.Text = package.PkgName;
                if (package.PkgStartDate != null)
                {
                    dtpPkgStartDate.Value = (DateTime)package.PkgStartDate;
                }
                if (package.PkgEndDate != null)
                {
                    dtpPkgEndDate.Value = (DateTime)package.PkgEndDate;
                }
                txtPkgDesc.Text = package.PkgDesc;
                txtPkgBasePrice.Text = package.PkgBasePrice.ToString("c");
                if (package.PkgAgencyCommission != null)
                {
                    txtPkgAgencyCommission.Text = package.PkgAgencyCommission.Value.ToString("c");
                }
            }
        }

        // implement alternating row colour
        // from: https://stackoverflow.com/questions/2866730/winforms-how-to-alternate-the-color-of-rows-in-a-listview-control
        private void lvProducts_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
            if ((e.ItemIndex % 2) == 1)
            {
                e.Item.BackColor = Color.WhiteSmoke;
                e.Item.UseItemStyleForSubItems = true;
            }
        }

        private void lvProducts_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true;
        }
    }
}
