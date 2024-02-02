namespace TravelExpertsGUI
{
    partial class frmAddModifyProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtProductName = new TextBox();
            label1 = new Label();
            btnConfirm = new Button();
            SuspendLayout();
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(134, 51);
            txtProductName.Margin = new Padding(4);
            txtProductName.MaxLength = 50;
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(156, 29);
            txtProductName.TabIndex = 1;
            txtProductName.Tag = "Product Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 54);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(113, 21);
            label1.TabIndex = 2;
            label1.Text = "Product Name:";
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(120, 126);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(75, 30);
            btnConfirm.TabIndex = 3;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // frmAddModifyProduct
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 168);
            Controls.Add(btnConfirm);
            Controls.Add(label1);
            Controls.Add(txtProductName);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmAddModifyProduct";
            Text = "Add/Modify";
            Load += frmAddModify_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtProductName;
        private Label label1;
        private Button btnConfirm;
    }
}