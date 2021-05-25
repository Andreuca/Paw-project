
namespace Supply_Business.views.GoodController
{
    partial class ShowGood
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowGood));
            this.listView1 = new System.Windows.Forms.ListView();
            this.chGoodName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGoodId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGoodSubtotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGoodQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.messageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteGood = new System.Windows.Forms.Button();
            this.btnInputGood = new System.Windows.Forms.Button();
            this.btnPopulare = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chGoodName,
            this.chGoodId,
            this.chGoodSubtotal,
            this.chGoodQuantity});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(1, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1326, 623);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // chGoodName
            // 
            this.chGoodName.Text = "Name";
            this.chGoodName.Width = 120;
            // 
            // chGoodId
            // 
            this.chGoodId.Text = "Id";
            this.chGoodId.Width = 120;
            // 
            // chGoodSubtotal
            // 
            this.chGoodSubtotal.Text = "Subtotal";
            this.chGoodSubtotal.Width = 120;
            // 
            // chGoodQuantity
            // 
            this.chGoodQuantity.Text = "Quantity";
            this.chGoodQuantity.Width = 120;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.messageToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(214, 52);
            // 
            // messageToolStripMenuItem
            // 
            this.messageToolStripMenuItem.Name = "messageToolStripMenuItem";
            this.messageToolStripMenuItem.Size = new System.Drawing.Size(213, 48);
            this.messageToolStripMenuItem.Text = "message";
            this.messageToolStripMenuItem.Click += new System.EventHandler(this.messageToolStripMenuItem_Click);
            // 
            // btnDeleteGood
            // 
            this.btnDeleteGood.BackColor = System.Drawing.Color.DarkRed;
            this.btnDeleteGood.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteGood.BackgroundImage")));
            this.btnDeleteGood.Font = new System.Drawing.Font("Dubai", 11.1F);
            this.btnDeleteGood.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeleteGood.Location = new System.Drawing.Point(1087, 818);
            this.btnDeleteGood.Name = "btnDeleteGood";
            this.btnDeleteGood.Size = new System.Drawing.Size(213, 64);
            this.btnDeleteGood.TabIndex = 7;
            this.btnDeleteGood.Text = "Delete";
            this.btnDeleteGood.UseVisualStyleBackColor = false;
            this.btnDeleteGood.Click += new System.EventHandler(this.btnDeleteGood_Click);
            // 
            // btnInputGood
            // 
            this.btnInputGood.BackColor = System.Drawing.Color.LimeGreen;
            this.btnInputGood.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInputGood.BackgroundImage")));
            this.btnInputGood.Font = new System.Drawing.Font("Dubai", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInputGood.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInputGood.Location = new System.Drawing.Point(860, 818);
            this.btnInputGood.Name = "btnInputGood";
            this.btnInputGood.Size = new System.Drawing.Size(213, 64);
            this.btnInputGood.TabIndex = 8;
            this.btnInputGood.Text = "Edit";
            this.btnInputGood.UseVisualStyleBackColor = false;
            this.btnInputGood.Click += new System.EventHandler(this.btnInputGood_Click);
            // 
            // btnPopulare
            // 
            this.btnPopulare.BackColor = System.Drawing.Color.LimeGreen;
            this.btnPopulare.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPopulare.BackgroundImage")));
            this.btnPopulare.Font = new System.Drawing.Font("Dubai", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPopulare.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPopulare.Location = new System.Drawing.Point(84, 782);
            this.btnPopulare.Name = "btnPopulare";
            this.btnPopulare.Size = new System.Drawing.Size(213, 64);
            this.btnPopulare.TabIndex = 9;
            this.btnPopulare.Text = "Populare";
            this.btnPopulare.UseVisualStyleBackColor = false;
            this.btnPopulare.Click += new System.EventHandler(this.btnPopulare_Click);
            // 
            // ShowGood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(1320, 931);
            this.Controls.Add(this.btnPopulare);
            this.Controls.Add(this.btnInputGood);
            this.Controls.Add(this.btnDeleteGood);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowGood";
            this.Text = "ShowContract";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader chGoodName;
        private System.Windows.Forms.ColumnHeader chGoodId;
        private System.Windows.Forms.Button btnDeleteGood;
        private System.Windows.Forms.Button btnInputGood;
        private System.Windows.Forms.ColumnHeader chGoodSubtotal;
        private System.Windows.Forms.ColumnHeader chGoodQuantity;
        private System.Windows.Forms.Button btnPopulare;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem messageToolStripMenuItem;
    }
}