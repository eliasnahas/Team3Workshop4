using Microsoft.EntityFrameworkCore;
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
    /* This is for add/modify product supplier 
     * 
     * 
     * Author: Jack
     * Date: Jan
     */
    public partial class frmAddModifyProductSupplier : Form
    {
        int psId; // product supplier id
        int ProductId; // product id
        int SupplierId; // supplier id
        string productName; // product name
        string supplierName; // supplier name
        int supplierid; // product id for getting displaying from number to string
        int productid; // supplier id for gettting displaying from number to string
        public bool isAdd;
        public ProductsSupplier? ProdSupp; // class object for Produdct Supplier
        public ProductsSupplier? selectedProdSupp; //for modify to get the prod and supplier id
        public Product? product;
        public Product? prod; // class object used for getting product name of sleect name
        public Supplier? supplier;
        public Supplier? supp; // class object for getting supplier name to display currnet selected name

        public frmAddModifyProductSupplier()
        {
            InitializeComponent();
        }

        private void frmAddModifyProductSupplier_Load(object sender, EventArgs e)
        {
            if (isAdd)
            {
                lblProductSupplierID.Visible = false;
                txtProductSupplierID.Visible = false;
                Text = "Add Product Supplier";
                DisplayProdSupp();
            }
            else // if false, display modify Product
            {
                lblProductSupplierID.Visible = true;
                txtProductSupplierID.Visible = true;
                Text = "Modify Product Supplier";
                DisplayProdSupp();
                DisplayProductSupplier();
            }
        }
        // method for filling up the combobox with product name and supplier name
        private void DisplayProdSupp()
        {
            try
            {
                using (TravelExpertsContext db = new TravelExpertsContext()) // connect to the database and get data
                {
                    cboProductName.DataSource = db.Products.ToList();
                    cboProductName.DisplayMember = "ProdName";
                    cboSupplierName.DataSource = db.Suppliers.ToList();
                    cboSupplierName.DisplayMember = "SupName";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when retrieving customer data: " +
                    ex.Message, ex.GetType().ToString());
            }
        }
        // method for confirm creating a new data entry or modfity
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (isAdd)
            {
                try
                {
                    using (TravelExpertsContext db = new TravelExpertsContext())
                    {


                        GetProductData();
                        if (db.ProductsSuppliers.Any(p => p.ProductId == productid && p.SupplierId == supplierid))
                        {
                            MessageBox.Show($"Product Supplier Already Exist \n Double Check if combination is correct");
                        }
                        else
                        {
                            ProdSupp = new ProductsSupplier();
                            ProdSupp.ProductId = productid;
                            ProdSupp.SupplierId = supplierid;
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
                        GetProductData();
                        if (db.ProductsSuppliers.Any(p => p.ProductId == productid && p.SupplierId == supplierid))
                        {
                            MessageBox.Show($"Product Supplier Already Exist \n Double Check if combination is correct");
                        }
                        else
                        {

                            ProdSupp.ProductId = productid;
                            ProdSupp.SupplierId = supplierid;
                            DialogResult = DialogResult.OK;
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error when retrieving customer data: " +
                        ex.Message, ex.GetType().ToString());
                }
            }
        }
        // method for converting the name of combobox and transform into supplier id and product id
        private void GetProductData()
        {
            string sid = cboSupplierName.GetItemText(cboSupplierName.SelectedItem);
            string pid = cboProductName.GetItemText(cboProductName.SelectedItem);

            try
            {
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

                    supplierid = Supp[0].SupplierId;
                    productid = Pro[0].ProductId;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when retrieving customer data: " +
                    ex.Message, ex.GetType().ToString());
            }
        }
        // for modify data, display the current product ID and display the prod name and supplier name for the display product supplier id
        private void DisplayProductSupplier()
        {
            if (ProdSupp != null)
            {
                txtProductSupplierID.Text = ProdSupp.ProductSupplierId.ToString();
                int psid = ProdSupp.ProductSupplierId;

                // finding the name and display it
                try
                {
                    using (TravelExpertsContext db = new TravelExpertsContext())
                    {
                        selectedProdSupp = db.ProductsSuppliers.Find(psid);
                        if (selectedProdSupp != null)
                        {
                            productid = (int)selectedProdSupp.ProductId;
                            supplierid = (int)selectedProdSupp.SupplierId;
                        }

                        prod = db.Products.Find(productid);
                        productName = prod.ProdName.ToString();
                        supp = db.Suppliers.Find(supplierid);
                        supplierName = supp.SupName.ToString();



                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error when retrieving customer data: " +
                        ex.Message, ex.GetType().ToString());
                }
                cboProductName.SelectedIndex = cboProductName.FindString(productName);
                cboSupplierName.SelectedIndex = cboSupplierName.FindString(supplierName);
            }
        }
        // close the form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
