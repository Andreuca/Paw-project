
namespace Supply_Business.views.ContractController
{
    partial class AddContract
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddContract));
            this.lbAddGood = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInputGood = new System.Windows.Forms.Button();
            this.btnDeleteGood = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbContractGood = new System.Windows.Forms.RichTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.rtbContractSupplier = new System.Windows.Forms.RichTextBox();
            this.cbContractPay = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbAddGood
            // 
            this.lbAddGood.AutoSize = true;
            this.lbAddGood.Font = new System.Drawing.Font("Dubai", 21F);
            this.lbAddGood.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbAddGood.Location = new System.Drawing.Point(-2, 58);
            this.lbAddGood.Name = "lbAddGood";
            this.lbAddGood.Size = new System.Drawing.Size(431, 118);
            this.lbAddGood.TabIndex = 1;
            this.lbAddGood.Text = "Add Contract";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(98, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 67);
            this.label1.TabIndex = 2;
            this.label1.Text = "Supplier name:";
            // 
            // btnInputGood
            // 
            this.btnInputGood.BackColor = System.Drawing.Color.LimeGreen;
            this.btnInputGood.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInputGood.BackgroundImage")));
            this.btnInputGood.Font = new System.Drawing.Font("Dubai", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInputGood.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInputGood.Location = new System.Drawing.Point(110, 787);
            this.btnInputGood.Name = "btnInputGood";
            this.btnInputGood.Size = new System.Drawing.Size(203, 64);
            this.btnInputGood.TabIndex = 5;
            this.btnInputGood.Text = "Input";
            this.btnInputGood.UseVisualStyleBackColor = false;
            this.btnInputGood.Click += new System.EventHandler(this.btnInputGood_Click);
            // 
            // btnDeleteGood
            // 
            this.btnDeleteGood.BackColor = System.Drawing.Color.DarkRed;
            this.btnDeleteGood.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteGood.BackgroundImage")));
            this.btnDeleteGood.Font = new System.Drawing.Font("Dubai", 11.1F);
            this.btnDeleteGood.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeleteGood.Location = new System.Drawing.Point(351, 787);
            this.btnDeleteGood.Name = "btnDeleteGood";
            this.btnDeleteGood.Size = new System.Drawing.Size(213, 64);
            this.btnDeleteGood.TabIndex = 6;
            this.btnDeleteGood.Text = "Delete";
            this.btnDeleteGood.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dubai", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(98, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(393, 67);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mainly good delivered:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Dubai", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(98, 460);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(331, 67);
            this.label4.TabIndex = 12;
            this.label4.Text = "Contract payment:";
            // 
            // rtbContractGood
            // 
            this.rtbContractGood.Location = new System.Drawing.Point(110, 375);
            this.rtbContractGood.Name = "rtbContractGood";
            this.rtbContractGood.Size = new System.Drawing.Size(452, 46);
            this.rtbContractGood.TabIndex = 15;
            this.rtbContractGood.Text = "";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // rtbContractSupplier
            // 
            this.rtbContractSupplier.Location = new System.Drawing.Point(110, 223);
            this.rtbContractSupplier.Name = "rtbContractSupplier";
            this.rtbContractSupplier.Size = new System.Drawing.Size(452, 46);
            this.rtbContractSupplier.TabIndex = 23;
            this.rtbContractSupplier.Text = "";
            // 
            // cbContractPay
            // 
            this.cbContractPay.FormattingEnabled = true;
            this.cbContractPay.Items.AddRange(new object[] {
            "1200 ",
            "1500 "});
            this.cbContractPay.Location = new System.Drawing.Point(110, 530);
            this.cbContractPay.Name = "cbContractPay";
            this.cbContractPay.Size = new System.Drawing.Size(452, 39);
            this.cbContractPay.TabIndex = 24;
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
            this.statusStrip1.TabIndex = 25;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(98, 41);
            this.toolStripStatusLabel1.Text = "Status";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 38);
            // 
            // AddContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(1320, 931);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cbContractPay);
            this.Controls.Add(this.rtbContractSupplier);
            this.Controls.Add(this.rtbContractGood);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDeleteGood);
            this.Controls.Add(this.btnInputGood);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbAddGood);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddContract";
            this.Text = "AddContract";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAddGood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInputGood;
        private System.Windows.Forms.Button btnDeleteGood;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbContractGood;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.RichTextBox rtbContractSupplier;
        private System.Windows.Forms.ComboBox cbContractPay;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
    }
}