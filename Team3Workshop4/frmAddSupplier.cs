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
 * Form that allows user to add new suppliers
 * Author: Gurleen Dhillon
 * Date: Jan 31
 */

namespace Team3Workshop4
{
    public partial class frmAddSupplier : Form
    {
        public frmAddSupplier()
        {
            InitializeComponent();
        }

        private TextBox txtSupID;
        private TextBox txtSupName;

        private void InitializeComponent()
        {
            txtSupID = new TextBox();
            txtSupName = new TextBox();
            btnAdd = new Button();
            btnCancel = new Button();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtSupID
            // 
            txtSupID.Location = new Point(151, 29);
            txtSupID.Name = "txtSupID";
            txtSupID.Size = new Size(190, 23);
            txtSupID.TabIndex = 0;
            txtSupID.TextChanged += txtSupID_TextChanged;
            // 
            // txtSupName
            // 
            txtSupName.Location = new Point(151, 70);
            txtSupName.Name = "txtSupName";
            txtSupName.Size = new Size(190, 23);
            txtSupName.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(26, 153);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(266, 153);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 32);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 4;
            label3.Text = "Supplier ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 73);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 5;
            label4.Text = "Supplier Name:";
            // 
            // frmAddSupplier
            // 
            ClientSize = new Size(365, 198);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(txtSupName);
            Controls.Add(txtSupID);
            Name = "frmAddSupplier";
            Text = "Add Supplier";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnAdd;
        private Button btnCancel;

        private void txtSupID_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSupID.Text, out int supplierId))
            {
                string supplierName = txtSupName.Text;

                using (var context = new TravelExpertsContext())
                {
                    if (context.Suppliers.Any(s => s.SupplierId == supplierId))
                    {
                        MessageBox.Show("Supplier ID is already in use. Please enter a unique ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit the method if the ID is already in use
                    }
                }

                // Create a new Supplier object
                Supplier newSupplier = new Supplier
                {
                    SupplierId = supplierId,
                    SupName = supplierName
                };

                using (var context = new TravelExpertsContext())
                {
                    context.Suppliers.Add(newSupplier);
                    context.SaveChanges();
                }

                // Close the AddSupplier form
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Supplier ID. Please enter a valid numeric ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}