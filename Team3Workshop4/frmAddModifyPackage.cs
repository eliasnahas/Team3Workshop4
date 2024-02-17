using Castle.Core.Resource;
using Microsoft.EntityFrameworkCore;
using System;
using TravelExpertsData;
using TravelSources;
using GridData;

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
                btnEditProducts.Enabled = false;
            }
            else
            {
                Text = "Modify Package";
                DisplayPackage();
                if (package!.PkgStartDate != null)
                {
                    dtpPkgStartDate.Format = DateTimePickerFormat.Short;
                }
                if (package.PkgEndDate != null)
                {
                    dtpPkgEndDate.Format = DateTimePickerFormat.Short;
                }
            }
        }

        // displays current package for Modify
        private void DisplayPackage()
        {
            List<ProdSuppNames> prodSuppNames = TravelSource.GetProductsSupplierByPackage(package!.PackageId)!;
            if (prodSuppNames != null)
            {
                int i = 0;
                foreach (ProdSuppNames ps in prodSuppNames)
                {
                    lvProducts.Items.Add(ps.ProdName);
                    lvProducts.Items[i].SubItems.Add(ps.SuppName);
                    i++;
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
                txtPkgBasePrice.Text = package.PkgBasePrice.ToString("f2");
                if (package.PkgAgencyCommission != null)
                {
                    txtPkgAgencyCommission.Text = package.PkgAgencyCommission.Value.ToString("f2");
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

        // make a Package object from collected data
        private void btnAccept_Click(object sender, EventArgs e)
        {
            // validate data
            if (Validator.IsPresent(txtPkgName) &&
                Validator.IsPresent(txtPkgBasePrice) &&
                Validator.IsNonNegativeDecimal(txtPkgBasePrice) &&
                Validator.IsNonNegativeDecimal(txtPkgAgencyCommission) &&
                Validator.IsValidDateRange(dtpPkgStartDate, dtpPkgEndDate) &&
                Validator.IsDecimalLessThan(txtPkgAgencyCommission, txtPkgBasePrice)
                )
            {
                if (isAdd)
                {
                    package = new Package(); // creates empty object
                    GetPackageData();
                }
                else // Modify
                {
                    // package is not null
                    GetPackageData();
                }
                DialogResult = DialogResult.OK; // closes the form
            }
        }

        // populate Package object with data from the controls
        private void GetPackageData()
        {
            if (package != null)
            {
                package.PkgName = txtPkgName.Text;
                // if Dates are empty, set null
                if (dtpPkgStartDate.Format.ToString() == "Custom")
                {
                    package.PkgStartDate = null;
                }
                else
                {
                    package.PkgStartDate = dtpPkgStartDate.Value;
                }
                if (dtpPkgEndDate.Format.ToString() == "Custom")
                {
                    package.PkgEndDate = null;
                }
                else
                {
                    package.PkgEndDate = dtpPkgEndDate.Value;
                }
                if (txtPkgDesc.Text == "") // if Description is empty, set null
                {
                    package.PkgDesc = null;
                }
                else
                {
                    package.PkgDesc = txtPkgDesc.Text;
                }
                package.PkgBasePrice = Convert.ToDecimal(txtPkgBasePrice.Text);
                if (txtPkgAgencyCommission.Text == "") // if Agency Commission is empty, set null
                {
                    package.PkgAgencyCommission = null;
                }
                else
                {
                    package.PkgAgencyCommission = Convert.ToDecimal(txtPkgAgencyCommission.Text);
                }
            }
        }

        // Empty datetimepicker solution: https://www.youtube.com/watch?v=eNgBGF98Mb8
        private void dtpPkgStartDate_ValueChanged(object sender, EventArgs e)
        {
            dtpPkgStartDate.Format = DateTimePickerFormat.Short;
        }

        private void dtpPkgEndDate_ValueChanged(object sender, EventArgs e)
        {
            dtpPkgEndDate.Format = DateTimePickerFormat.Short;
        }

        private void dtpPkgStartDate_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                dtpPkgStartDate.Format = DateTimePickerFormat.Custom;
            }
        }

        private void dtpPkgEndDate_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                dtpPkgEndDate.Format = DateTimePickerFormat.Custom;
            }
        }

        private void btnEditProducts_Click(object sender, EventArgs e)
        {
            if (package != null)
            {
                List<ProdSuppNames>? packageProductSuppliers = TravelSource.GetProductsSupplierByPackage(package.PackageId);
                List<ProdSuppNames> availableProductSuppliers = TravelSource.GetRemainingProductsSuppliersByPackage(package.PackageId);
                frmEditPackageProducts editPackageProducts = new frmEditPackageProducts()
                {
                    packageProductSuppliers = packageProductSuppliers,
                    availableProductSuppliers = availableProductSuppliers,
                    packageId = package.PackageId
                };
                DialogResult result = editPackageProducts.ShowDialog();
                if (result == DialogResult.OK)
                {
                    lvProducts.Items.Clear();
                    DisplayPackage();
                }
            }
        }
    }
}
