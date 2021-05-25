
namespace Supply_Business.views.SupplierController
{
    partial class ShowSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowSupplier));
            this.btnDeleteGood = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.chSupplierName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSupplierSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSupplierEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSupplierPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnInputGood = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDeleteGood
            // 
            this.btnDeleteGood.BackColor = System.Drawing.Color.DarkRed;
            this.btnDeleteGood.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteGood.BackgroundImage")));
            this.btnDeleteGood.Font = new System.Drawing.Font("Dubai", 11.1F);
            this.btnDeleteGood.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeleteGood.Location = new System.Drawing.Point(1011, 806);
            this.btnDeleteGood.Name = "btnDeleteGood";
            this.btnDeleteGood.Size = new System.Drawing.Size(213, 64);
            this.btnDeleteGood.TabIndex = 7;
            this.btnDeleteGood.Text = "Delete";
            this.btnDeleteGood.UseVisualStyleBackColor = false;
            this.btnDeleteGood.Click += new System.EventHandler(this.btnDeleteGood_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chSupplierName,
            this.chSupplierSurname,
            this.chSupplierEmail,
            this.chSupplierPhone});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(2, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1326, 623);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // chSupplierName
            // 
            this.chSupplierName.Text = "Name";
            this.chSupplierName.Width = 120;
            // 
            // chSupplierSurname
            // 
            this.chSupplierSurname.Text = "Surname";
            this.chSupplierSurname.Width = 120;
            // 
            // chSupplierEmail
            // 
            this.chSupplierEmail.Text = "Email";
            this.chSupplierEmail.Width = 200;
            // 
            // chSupplierPhone
            // 
            this.chSupplierPhone.Text = "Phone Number";
            this.chSupplierPhone.Width = 120;
            // 
            // btnInputGood
            // 
            this.btnInputGood.BackColor = System.Drawing.Color.LimeGreen;
            this.btnInputGood.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInputGood.BackgroundImage")));
            this.btnInputGood.Font = new System.Drawing.Font("Dubai", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInputGood.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInputGood.Location = new System.Drawing.Point(774, 806);
            this.btnInputGood.Name = "btnInputGood";
            this.btnInputGood.Size = new System.Drawing.Size(213, 64);
            this.btnInputGood.TabIndex = 9;
            this.btnInputGood.Text = "Edit";
            this.btnInputGood.UseVisualStyleBackColor = false;
            this.btnInputGood.Click += new System.EventHandler(this.btnInputGood_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("Dubai", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(56, 699);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 64);
            this.button1.TabIndex = 10;
            this.button1.Text = "Populare";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShowSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(1320, 931);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnInputGood);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnDeleteGood);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowSupplier";
            this.Text = "ShowSupplier";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDeleteGood;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnInputGood;
        private System.Windows.Forms.ColumnHeader chSupplierName;
        private System.Windows.Forms.ColumnHeader chSupplierSurname;
        private System.Windows.Forms.ColumnHeader chSupplierEmail;
        private System.Windows.Forms.ColumnHeader chSupplierPhone;
        private System.Windows.Forms.Button button1;
    }
}