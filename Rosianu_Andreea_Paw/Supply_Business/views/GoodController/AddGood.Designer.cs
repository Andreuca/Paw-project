
namespace Supply_Business.views.GoodController
{
    partial class AddGood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGood));
            this.btnDeleteGood = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbGoodName = new System.Windows.Forms.RichTextBox();
            this.rtbGoodId = new System.Windows.Forms.RichTextBox();
            this.rtbGoodSubtotal = new System.Windows.Forms.RichTextBox();
            this.ceva = new System.Windows.Forms.Label();
            this.btnInputGood = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbQuantity = new System.Windows.Forms.ComboBox();
            this.lbb = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeleteGood
            // 
            this.btnDeleteGood.BackColor = System.Drawing.Color.DarkRed;
            this.btnDeleteGood.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteGood.BackgroundImage")));
            this.btnDeleteGood.Font = new System.Drawing.Font("Dubai", 11.1F);
            this.btnDeleteGood.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeleteGood.Location = new System.Drawing.Point(339, 754);
            this.btnDeleteGood.Name = "btnDeleteGood";
            this.btnDeleteGood.Size = new System.Drawing.Size(203, 64);
            this.btnDeleteGood.TabIndex = 2;
            this.btnDeleteGood.Text = "Cancel";
            this.btnDeleteGood.UseVisualStyleBackColor = false;
            this.btnDeleteGood.Click += new System.EventHandler(this.btnDeleteGood_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai", 12F);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(78, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(397, 67);
            this.label2.TabIndex = 5;
            this.label2.Text = "The name of the good:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dubai", 12F);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(78, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 67);
            this.label3.TabIndex = 6;
            this.label3.Text = "The Id:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Dubai", 12F);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(78, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 67);
            this.label4.TabIndex = 7;
            this.label4.Text = "Subtotal:";
            // 
            // rtbGoodName
            // 
            this.rtbGoodName.Location = new System.Drawing.Point(90, 223);
            this.rtbGoodName.Name = "rtbGoodName";
            this.rtbGoodName.Size = new System.Drawing.Size(452, 46);
            this.rtbGoodName.TabIndex = 9;
            this.rtbGoodName.Text = "";
            // 
            // rtbGoodId
            // 
            this.rtbGoodId.Location = new System.Drawing.Point(90, 333);
            this.rtbGoodId.Name = "rtbGoodId";
            this.rtbGoodId.Size = new System.Drawing.Size(452, 46);
            this.rtbGoodId.TabIndex = 13;
            this.rtbGoodId.Text = "";
            // 
            // rtbGoodSubtotal
            // 
            this.rtbGoodSubtotal.Location = new System.Drawing.Point(90, 476);
            this.rtbGoodSubtotal.Name = "rtbGoodSubtotal";
            this.rtbGoodSubtotal.Size = new System.Drawing.Size(452, 46);
            this.rtbGoodSubtotal.TabIndex = 14;
            this.rtbGoodSubtotal.Text = "";
            // 
            // ceva
            // 
            this.ceva.AutoSize = true;
            this.ceva.Font = new System.Drawing.Font("Dubai", 12F);
            this.ceva.ForeColor = System.Drawing.Color.Gainsboro;
            this.ceva.Location = new System.Drawing.Point(82, 551);
            this.ceva.Name = "ceva";
            this.ceva.Size = new System.Drawing.Size(180, 67);
            this.ceva.TabIndex = 16;
            this.ceva.Text = "Quantity:";
            // 
            // btnInputGood
            // 
            this.btnInputGood.BackColor = System.Drawing.Color.LimeGreen;
            this.btnInputGood.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInputGood.BackgroundImage")));
            this.btnInputGood.Font = new System.Drawing.Font("Dubai", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInputGood.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInputGood.Location = new System.Drawing.Point(94, 754);
            this.btnInputGood.Name = "btnInputGood";
            this.btnInputGood.Size = new System.Drawing.Size(203, 64);
            this.btnInputGood.TabIndex = 17;
            this.btnInputGood.Text = "&Input";
            this.btnInputGood.UseVisualStyleBackColor = false;
            this.btnInputGood.Click += new System.EventHandler(this.btnInputGood_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cbQuantity
            // 
            this.cbQuantity.FormattingEnabled = true;
            this.cbQuantity.Items.AddRange(new object[] {
            "10",
            "100",
            "500",
            "1000",
            "1100",
            "1200",
            "1300",
            "1400",
            "1500"});
            this.cbQuantity.Location = new System.Drawing.Point(94, 621);
            this.cbQuantity.Name = "cbQuantity";
            this.cbQuantity.Size = new System.Drawing.Size(448, 39);
            this.cbQuantity.TabIndex = 18;
            // 
            // lbb
            // 
            this.lbb.AutoSize = true;
            this.lbb.Font = new System.Drawing.Font("Dubai", 21F);
            this.lbb.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbb.Location = new System.Drawing.Point(-1, 54);
            this.lbb.Name = "lbb";
            this.lbb.Size = new System.Drawing.Size(334, 118);
            this.lbb.TabIndex = 19;
            this.lbb.Text = "Add Good";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteDataToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(249, 52);
            // 
            // deleteDataToolStripMenuItem
            // 
            this.deleteDataToolStripMenuItem.Name = "deleteDataToolStripMenuItem";
            this.deleteDataToolStripMenuItem.Size = new System.Drawing.Size(248, 48);
            this.deleteDataToolStripMenuItem.Text = "Delete data";
            this.deleteDataToolStripMenuItem.Click += new System.EventHandler(this.deleteDataToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1320, 54);
            this.statusStrip1.TabIndex = 20;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(98, 41);
            this.toolStripStatusLabel1.Text = "Status";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 38);
            // 
            // AddGood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(1320, 931);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lbb);
            this.Controls.Add(this.cbQuantity);
            this.Controls.Add(this.btnInputGood);
            this.Controls.Add(this.ceva);
            this.Controls.Add(this.rtbGoodSubtotal);
            this.Controls.Add(this.rtbGoodId);
            this.Controls.Add(this.rtbGoodName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDeleteGood);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddGood";
            this.Text = "AddContract";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDeleteGood;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbGoodName;
        private System.Windows.Forms.RichTextBox rtbGoodId;
        private System.Windows.Forms.RichTextBox rtbGoodSubtotal;
        private System.Windows.Forms.Label ceva;
        private System.Windows.Forms.Button btnInputGood;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cbQuantity;
        private System.Windows.Forms.Label lbb;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteDataToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
    }
}