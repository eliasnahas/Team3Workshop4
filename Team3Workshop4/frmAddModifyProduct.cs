using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TravelExpertsData;

namespace TravelExpertsGUI
{
    public partial class frmAddModifyProduct : Form
    {
        public bool isAdd;
        public Product? product;
        public frmAddModifyProduct()
        {
            InitializeComponent();
        }

        private void frmAddModify_Load(object sender, EventArgs e)
        {
            if (isAdd)
            {
                Text = "Add Product";

            }
            else // if false, dior productcode
            {
                Text = "Modify Product";
                DisplayProduct();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (isAdd)
            {
                using (TravelExpertsContext db = new TravelExpertsContext())
                {
                    product = new Product();
                    GetProductData();
                    DialogResult = DialogResult.OK; // close the form
                }
            } else
            {
                GetProductData();
                DialogResult = DialogResult.OK;
            }
        }
        private void GetProductData()
        {
            if (product != null)
            {
                product.ProdName = txtProductName.Text;
            }
        }
        private void DisplayProduct()
        {
            if (product != null)
            {
                txtProductName.Text = product.ProdName;

            }
        }
    }
}
