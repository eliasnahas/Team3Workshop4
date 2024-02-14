namespace Team3Workshop4
{
    partial class frmModifySupplier
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
            label1 = new Label();
            label2 = new Label();
            txtSupID = new TextBox();
            txtSupName = new TextBox();
            btnModify = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 33);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "Supplier ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 82);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 1;
            label2.Text = "Supplier Name:";
            // 
            // txtSupID
            // 
            txtSupID.Location = new Point(131, 30);
            txtSupID.Name = "txtSupID";
            txtSupID.Size = new Size(200, 23);
            txtSupID.TabIndex = 2;
            // 
            // txtSupName
            // 
            txtSupName.Location = new Point(131, 79);
            txtSupName.Name = "txtSupName";
            txtSupName.Size = new Size(200, 23);
            txtSupName.TabIndex = 3;
            // 
            // btnModify
            // 
            btnModify.Location = new Point(17, 157);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(75, 23);
            btnModify.TabIndex = 4;
            btnModify.Text = "Modify";
            btnModify.UseVisualStyleBackColor = true;
            btnModify.Click += btnModify_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(256, 157);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmModifySupplier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 204);
            Controls.Add(btnCancel);
            Controls.Add(btnModify);
            Controls.Add(txtSupName);
            Controls.Add(txtSupID);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmModifySupplier";
            Text = "frmModifySupplier";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSupID;
        private TextBox txtSupName;
        private Button btnModify;
        private Button btnCancel;
    }
}