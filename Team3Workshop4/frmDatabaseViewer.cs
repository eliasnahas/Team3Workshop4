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
using TravelSources;

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

            // productsGrid.DataSource = TravelSource.GetProducts();
            
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
