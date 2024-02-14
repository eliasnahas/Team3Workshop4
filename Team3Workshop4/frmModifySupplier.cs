using Microsoft.EntityFrameworkCore;
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

/*
 * Form that allows user to modify suppliers
 * Author: Gurleen Dhillon
 * Date: Jan 31
 */
namespace Team3Workshop4
{
    public partial class frmModifySupplier : Form
    {
        private Supplier existingSupplier;

        public frmModifySupplier(Supplier supplier)
        {
            InitializeComponent();
            existingSupplier = supplier;

            txtSupID.Text = existingSupplier.SupplierId.ToString();
            txtSupName.Text = existingSupplier.SupName;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            existingSupplier.SupplierId = int.Parse(txtSupID.Text);
            existingSupplier.SupName = txtSupName.Text;

            using (var context = new TravelExpertsContext())
            {
                context.Entry(existingSupplier).State = EntityState.Modified;
                context.SaveChanges();
            }

            // Close the ModifySupplier form
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Close the ModifySupplier form
            this.Close();
        }
    }
}
