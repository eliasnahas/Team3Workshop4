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
    public partial class frmDatabaseViewer : Form
    {
        public frmDatabaseViewer()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            using (TravelExpertsContext db = new TravelExpertsContext()) // connect to the database and get data
            {
                var prod = db.Products.Select(p => new
                {
                    p.ProductId,
                    p.ProdName
                }).ToList();
                productsGrid.DataSource = prod;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void modPackageButton_Click(object sender, EventArgs e)
        {
            frmAddModifyPackage modWindow = new frmAddModifyPackage();
            modWindow.ShowDialog();
        }
    }
}
