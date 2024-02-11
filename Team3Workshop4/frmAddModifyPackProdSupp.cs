using Castle.Components.DictionaryAdapter.Xml;
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
            if (entry != null) // if 'Add' pressed
            {
                LoadSelectedEntry();
            }
            else // if 'Modify' pressed
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
    }
}
