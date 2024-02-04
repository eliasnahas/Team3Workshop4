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

namespace Team3Workshop4
{
    public partial class frmAddModifyPackProdSupp : Form
    {
        public PackagesProductsSupplier? entry; // The currently selected entry (if it exists)
        public int? entryIndex; // The index of the currently selected entry (if it exists)

        public frmAddModifyPackProdSupp()
        {
            InitializeComponent();
        }

        // function when Add/Modify form Loads
        private void frmAddModifyPackProdSupp_Load(object sender, EventArgs e)
        {
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                comboPackageId.DataSource = db.Packages.ToList();
                comboPackageId.ValueMember = "PackageId";
                comboPackageId.DisplayMember = "PackageId";

                comboProdSuppId.DataSource = db.ProductsSuppliers.ToList();
                comboProdSuppId.ValueMember = "ProductSupplierId";
                comboProdSuppId.DisplayMember = "ProductSupplierId";
            }
            if (entry != null)
            {
                LoadSelectedEntry();
            }
            else
            {
                InsertNewId();
            }
        }
        private void InsertNewId()
        {
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                int NewPPSId = db.PackagesProductsSuppliers
                                .OrderByDescending(pps => pps.PackageProductSupplierId)
                                .FirstOrDefault()!.PackageProductSupplierId;
                textPackProdSuppId.Text = NewPPSId.ToString();
            }
        }
        private void LoadSelectedEntry()
        {
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                textPackProdSuppId.Text = entry.PackageProductSupplierId.ToString();
                comboPackageId.Text = entry.PackageId.ToString();
                comboProdSuppId.Text = entry.ProductSupplierId.ToString();
            }
        }


        private void btnAccept_Click(object sender, EventArgs e)
        {


            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


        // Functions to show the PackageName/ProductSupplierName for their respective ID
        private void comboPackageId_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                int selectedPackageId = Convert.ToInt32(comboPackageId.GetItemText(comboPackageId.SelectedItem!)); // comedy
                textPackageName.Text = db.Packages
                    .Find(selectedPackageId)! // find the matching package in the db
                    .PkgName // get its package name
                    .ToString(); // make string to set in textPackageName
            }
            
        }
        private void comboProdSuppId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
