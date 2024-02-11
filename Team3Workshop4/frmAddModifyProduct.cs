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

namespace Team3Workshop4
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
            else // if false, display modify Product
            {
                Text = "Modify Product";
                DisplayProduct();
            }
        }
        // confirm and send data to main page
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(txtProductName))
            {
                if (isAdd)
                {
                    try
                    {
                        using (TravelExpertsContext db = new TravelExpertsContext())
                        {
                            product = new Product();
                            GetProductData();
                            DialogResult = DialogResult.OK; // close the form
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error when retrieving customer data: " +
                            ex.Message, ex.GetType().ToString());
                    }
                }
                else
                {
                    GetProductData();
                    DialogResult = DialogResult.OK;
                } 
            }
        }
        // get product name
        private void GetProductData()
        {
            if (product != null)
            {
                
                product.ProdName = txtProductName.Text; 

            }
        }
        // Display Product with information
        private void DisplayProduct()
        {
            if (product != null)
            {
                txtProductID.Text = product.ProductId.ToString();
                txtProductName.Text = product.ProdName;

            }
        }

        // exit the program
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
