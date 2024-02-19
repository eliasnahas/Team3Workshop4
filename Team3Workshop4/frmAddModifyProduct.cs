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
    /*
     * Add.Edit form for Products
     * Author: Jack
     * Date: Jan 2024
     * 
     * 
     */
    public partial class frmAddModifyProduct : Form
    {
        public bool isAdd;
        public Product? product;
        string oldName;
        public frmAddModifyProduct()
        {
            InitializeComponent();
        }
        // load form based on add or modify. add will load blank page, modifty will load form with data.
        private void frmAddModify_Load(object sender, EventArgs e)
        {
            if (isAdd)
            {
                Text = "Add Product";
                txtProductID.Visible = false;
                lblProductID.Visible = false;

            }
            else // if false, display modify Product
            {
                Text = "Modify Product";
                txtProductID.Visible = true;
                lblProductID.Visible = true;
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
                            if (db.Products.Any(p => p.ProdName == txtProductName.Text.ToString()))
                            {
                                MessageBox.Show($"Product Name Already Exist \n Try Again with a Diffrent Name");
                            }
                            else
                            {
                                product = new Product();
                                GetProductData();
                                DialogResult = DialogResult.OK; // close the form
                            }

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
                    try
                    {
                        using (TravelExpertsContext db = new TravelExpertsContext())
                        {
                            if (txtProductName.Text == oldName)
                            {
                                MessageBox.Show("No Change Has Been Made");
                            }
                            else
                            {
                                if (db.Products.Any(p => p.ProdName == txtProductName.Text.ToString()))
                                {
                                    MessageBox.Show($"Product Name Already Exist \n Try Again with a Diffrent Name");
                                }
                                else
                                {
                                    GetProductData();
                                    DialogResult = DialogResult.OK;
                                }
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error when retrieving customer data: " +
                            ex.Message, ex.GetType().ToString());
                    }
                }
            }
        }
        // get product name
        private void GetProductData()
        {
            if (product != null)
            {

                if (Validator.IsPresent(txtProductName))
                {
                    product.ProdName = txtProductName.Text; 
                } 

            }
        }
        // Display Product with information
        private void DisplayProduct()
        {
            if (product != null)
            {
                txtProductID.Text = product.ProductId.ToString();
                txtProductName.Text = product.ProdName;
                oldName = product.ProdName;

            }
        }

        // exit the program
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
