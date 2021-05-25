
namespace Supply_Business.views.ContractController
{
    partial class ShowContract
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowContract));
            this.btnDeleteContract = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.chContractSupplier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chContractGood = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chContractPayment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnInputGood = new System.Windows.Forms.Button();
            this.btncContractPopulare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDeleteContract
            // 
            this.btnDeleteContract.BackColor = System.Drawing.Color.DarkRed;
            this.btnDeleteContract.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteContract.BackgroundImage")));
            this.btnDeleteContract.Font = new System.Drawing.Font("Dubai", 11.1F);
            this.btnDeleteContract.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeleteContract.Location = new System.Drawing.Point(1063, 804);
            this.btnDeleteContract.Name = "btnDeleteContract";
            this.btnDeleteContract.Size = new System.Drawing.Size(213, 64);
            this.btnDeleteContract.TabIndex = 7;
            this.btnDeleteContract.Text = "Delete";
            this.btnDeleteContract.UseVisualStyleBackColor = false;
            this.btnDeleteContract.Click += new System.EventHandler(this.btnDeleteContract_Click_1);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chContractSupplier,
            this.chContractGood,
            this.chContractPayment});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(2, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1326, 623);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // chContractSupplier
            // 
            this.chContractSupplier.Text = "Supplier";
            this.chContractSupplier.Width = 120;
            // 
            // chContractGood
            // 
            this.chContractGood.Text = "Good";
            this.chContractGood.Width = 120;
            // 
            // chContractPayment
            // 
            this.chContractPayment.Text = "Payment";
            this.chContractPayment.Width = 120;
            // 
            // btnInputGood
            // 
            this.btnInputGood.BackColor = System.Drawing.Color.LimeGreen;
            this.btnInputGood.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInputGood.BackgroundImage")));
            this.btnInputGood.Font = new System.Drawing.Font("Dubai", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInputGood.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInputGood.Location = new System.Drawing.Point(830, 804);
            this.btnInputGood.Name = "btnInputGood";
            this.btnInputGood.Size = new System.Drawing.Size(213, 64);
            this.btnInputGood.TabIndex = 10;
            this.btnInputGood.Text = "Edit";
            this.btnInputGood.UseVisualStyleBackColor = false;
            this.btnInputGood.Click += new System.EventHandler(this.btnInputGood_Click);
            // 
            // btncContractPopulare
            // 
            this.btncContractPopulare.BackColor = System.Drawing.Color.LimeGreen;
            this.btncContractPopulare.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncContractPopulare.BackgroundImage")));
            this.btncContractPopulare.Font = new System.Drawing.Font("Dubai", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncContractPopulare.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btncContractPopulare.Location = new System.Drawing.Point(66, 683);
            this.btncContractPopulare.Name = "btncContractPopulare";
            this.btncContractPopulare.Size = new System.Drawing.Size(213, 64);
            this.btncContractPopulare.TabIndex = 11;
            this.btncContractPopulare.Text = "Populare";
            this.btncContractPopulare.UseVisualStyleBackColor = false;
            this.btncContractPopulare.Click += new System.EventHandler(this.btncContractPopulare_Click);
            // 
            // ShowContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(1320, 931);
            this.Controls.Add(this.btncContractPopulare);
            this.Controls.Add(this.btnInputGood);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnDeleteContract);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowContract";
            this.Text = "ShowContract";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteContract;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnInputGood;
        private System.Windows.Forms.ColumnHeader chContractSupplier;
        private System.Windows.Forms.ColumnHeader chContractGood;
        private System.Windows.Forms.ColumnHeader chContractPayment;
        private System.Windows.Forms.Button btncContractPopulare;
    }
}