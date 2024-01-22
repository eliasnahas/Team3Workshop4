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
                package = db.Packages.FirstOrDefault();
            }
            if (package != null) // if not null
            {
                txtPkgName.Text = package.PkgName;
                dtpPkgStartDate.Value = (DateTime)package.PkgStartDate;
                dtpPkgEndDate.Value = (DateTime)package.PkgEndDate;
                txtPkgDesc.Text = package.PkgDesc;
                txtPkgBasePrice.Text = package.PkgBasePrice.ToString("c");
                txtPkgAgencyCommission.Text = package.PkgAgencyCommission.ToString();
            }
        }
    }
}
