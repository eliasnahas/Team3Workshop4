using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertsData;

namespace Team3Workshop4
{
    public partial class frmAddModifyProductSupplier : Form
    {
        int ProductSupplierId;
        int ProductId;
        int SupplierId;
        public bool isAdd;
        public ProductsSupplier? ProdSupp;
        public frmAddModifyProductSupplier()
        {
            InitializeComponent();
        }

        private void frmAddModifyProductSupplier_Load(object sender, EventArgs e)
        {
            if (isAdd)
            {
                Text = "Add Product Supplier";
                DisplayProdSupp();
            }
            else // if false, display modify Product
            {
                Text = "Modify Product Supplier";
                DisplayProdSupp();
                DisplayProductSupplier();
            }
        }

        private void DisplayProdSupp()
        {
            using (TravelExpertsContext db = new TravelExpertsContext()) // connect to the database and get data
            {
                cboProductName.DataSource = db.Products.ToList();
                cboProductName.DisplayMember = "ProdName";
                cboSupplierName.DataSource = db.Suppliers.ToList();
                cboSupplierName.DisplayMember = "SupName";

            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (isAdd)
            {
                using (TravelExpertsContext db = new TravelExpertsContext())
                {
                    ProdSupp = new ProductsSupplier();
                    GetProductData();
                    DialogResult = DialogResult.OK; // close the form
                } 
            }
            else
            {
                GetProductData();
                DialogResult = DialogResult.OK;

            }
        }

        private void GetProductData()
        {
            string sid = cboSupplierName.GetItemText(cboSupplierName.SelectedItem);
            string pid = cboProductName.GetItemText(cboProductName.SelectedItem);

            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                var Supp = (from s in db.Suppliers
                            where s.SupName == sid
                            select new
                            {
                                s.SupplierId
                            }).ToList();

                var Pro = (from p in db.Products
                           where p.ProdName == pid
                           select new
                           {
                               p.ProductId
                           }).ToList();

                int supplierid = Supp[0].SupplierId;
                int productid = Pro[0].ProductId;


                if (isAdd)
                {
                    ProdSupp = new ProductsSupplier();
                    ProdSupp.ProductId = productid;
                    ProdSupp.SupplierId = supplierid; 
                }
                else
                {
                    ProdSupp.ProductId = productid;
                    ProdSupp.SupplierId = supplierid;
                }
            }
        }
        private void DisplayProductSupplier()
        {
            if (ProdSupp != null)
            {
                txtProductSupplierID.Text = ProdSupp.ProductSupplierId.ToString();
                ProductId = ProdSupp.ProductSupplierId;
                SupplierId = ProdSupp.ProductSupplierId;
                ProductSupplierId = ProdSupp.ProductSupplierId;
                using (TravelExpertsContext db = new TravelExpertsContext())
                {

                }
            }
        }
    }
}
