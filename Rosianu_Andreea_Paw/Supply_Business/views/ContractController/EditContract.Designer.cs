
namespace Supply_Business.views.ContractController
{
    partial class EditContract
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditContract));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbContractSupplier = new System.Windows.Forms.RichTextBox();
            this.rtbContractGood = new System.Windows.Forms.RichTextBox();
            this.btnContractEdit = new System.Windows.Forms.Button();
            this.btnContractCancel = new System.Windows.Forms.Button();
            this.cbContractPay = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(177, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 67);
            this.label1.TabIndex = 3;
            this.label1.Text = "Supplier name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dubai", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(177, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(393, 67);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mainly good delivered:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Dubai", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(177, 490);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(331, 67);
            this.label4.TabIndex = 13;
            this.label4.Text = "Contract payment:";
            // 
            // rtbContractSupplier
            // 
            this.rtbContractSupplier.Location = new System.Drawing.Point(189, 200);
            this.rtbContractSupplier.Name = "rtbContractSupplier";
            this.rtbContractSupplier.Size = new System.Drawing.Size(452, 46);
            this.rtbContractSupplier.TabIndex = 24;
            this.rtbContractSupplier.Text = "";
            // 
            // rtbContractGood
            // 
            this.rtbContractGood.Location = new System.Drawing.Point(189, 371);
            this.rtbContractGood.Name = "rtbContractGood";
            this.rtbContractGood.Size = new System.Drawing.Size(452, 46);
            this.rtbContractGood.TabIndex = 25;
            this.rtbContractGood.Text = "";
            // 
            // btnContractEdit
            // 
            this.btnContractEdit.BackColor = System.Drawing.Color.LimeGreen;
            this.btnContractEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnContractEdit.BackgroundImage")));
            this.btnContractEdit.Font = new System.Drawing.Font("Dubai", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContractEdit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnContractEdit.Location = new System.Drawing.Point(189, 655);
            this.btnContractEdit.Name = "btnContractEdit";
            this.btnContractEdit.Size = new System.Drawing.Size(203, 64);
            this.btnContractEdit.TabIndex = 27;
            this.btnContractEdit.Text = "Edit";
            this.btnContractEdit.UseVisualStyleBackColor = false;
            this.btnContractEdit.Click += new System.EventHandler(this.btnContractEdit_Click);
            // 
            // btnContractCancel
            // 
            this.btnContractCancel.BackColor = System.Drawing.Color.DarkRed;
            this.btnContractCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnContractCancel.BackgroundImage")));
            this.btnContractCancel.Font = new System.Drawing.Font("Dubai", 11.1F);
            this.btnContractCancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnContractCancel.Location = new System.Drawing.Point(428, 655);
            this.btnContractCancel.Name = "btnContractCancel";
            this.btnContractCancel.Size = new System.Drawing.Size(213, 64);
            this.btnContractCancel.TabIndex = 28;
            this.btnContractCancel.Text = "Cancel";
            this.btnContractCancel.UseVisualStyleBackColor = false;
            this.btnContractCancel.Click += new System.EventHandler(this.btnContractCancel_Click);
            // 
            // cbContractPay
            // 
            this.cbContractPay.FormattingEnabled = true;
            this.cbContractPay.Items.AddRange(new object[] {
            "1200 ",
            "1500 "});
            this.cbContractPay.Location = new System.Drawing.Point(189, 560);
            this.cbContractPay.Name = "cbContractPay";
            this.cbContractPay.Size = new System.Drawing.Size(452, 39);
            this.cbContractPay.TabIndex = 29;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EditContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(1288, 843);
            this.Controls.Add(this.cbContractPay);
            this.Controls.Add(this.btnContractCancel);
            this.Controls.Add(this.btnContractEdit);
            this.Controls.Add(this.rtbContractGood);
            this.Controls.Add(this.rtbContractSupplier);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "EditContract";
            this.Text = "EditContract";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbContractSupplier;
        private System.Windows.Forms.RichTextBox rtbContractGood;
        private System.Windows.Forms.Button btnContractEdit;
        private System.Windows.Forms.Button btnContractCancel;
        private System.Windows.Forms.ComboBox cbContractPay;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}