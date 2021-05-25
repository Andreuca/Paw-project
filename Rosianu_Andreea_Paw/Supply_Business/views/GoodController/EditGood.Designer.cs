
namespace Supply_Business.views.GoodController
{
    partial class EditGood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditGood));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.rtbGoodName = new System.Windows.Forms.RichTextBox();
            this.rtbGoodId = new System.Windows.Forms.RichTextBox();
            this.rtbGoodSubtotal = new System.Windows.Forms.RichTextBox();
            this.cbQuantity = new System.Windows.Forms.ComboBox();
            this.btnGoodEdit = new System.Windows.Forms.Button();
            this.btnGoodDelete = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai", 12F);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(144, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(397, 67);
            this.label2.TabIndex = 6;
            this.label2.Text = "The name of the good:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dubai", 12F);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(144, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 67);
            this.label3.TabIndex = 7;
            this.label3.Text = "The Id:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Dubai", 12F);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(144, 472);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 67);
            this.label4.TabIndex = 8;
            this.label4.Text = "Subtotal:";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Dubai", 12F);
            this.lb.ForeColor = System.Drawing.Color.Gainsboro;
            this.lb.Location = new System.Drawing.Point(144, 622);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(180, 67);
            this.lb.TabIndex = 17;
            this.lb.Text = "Quantity:";
            // 
            // rtbGoodName
            // 
            this.rtbGoodName.Location = new System.Drawing.Point(156, 208);
            this.rtbGoodName.Name = "rtbGoodName";
            this.rtbGoodName.Size = new System.Drawing.Size(452, 46);
            this.rtbGoodName.TabIndex = 18;
            this.rtbGoodName.Text = "";
            // 
            // rtbGoodId
            // 
            this.rtbGoodId.Location = new System.Drawing.Point(156, 364);
            this.rtbGoodId.Name = "rtbGoodId";
            this.rtbGoodId.Size = new System.Drawing.Size(452, 46);
            this.rtbGoodId.TabIndex = 19;
            this.rtbGoodId.Text = "";
            // 
            // rtbGoodSubtotal
            // 
            this.rtbGoodSubtotal.Location = new System.Drawing.Point(156, 526);
            this.rtbGoodSubtotal.Name = "rtbGoodSubtotal";
            this.rtbGoodSubtotal.Size = new System.Drawing.Size(452, 46);
            this.rtbGoodSubtotal.TabIndex = 20;
            this.rtbGoodSubtotal.Text = "";
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
            this.cbQuantity.Location = new System.Drawing.Point(160, 682);
            this.cbQuantity.Name = "cbQuantity";
            this.cbQuantity.Size = new System.Drawing.Size(448, 39);
            this.cbQuantity.TabIndex = 21;
            // 
            // btnGoodEdit
            // 
            this.btnGoodEdit.BackColor = System.Drawing.Color.LimeGreen;
            this.btnGoodEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGoodEdit.BackgroundImage")));
            this.btnGoodEdit.Font = new System.Drawing.Font("Dubai", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoodEdit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGoodEdit.Location = new System.Drawing.Point(160, 756);
            this.btnGoodEdit.Name = "btnGoodEdit";
            this.btnGoodEdit.Size = new System.Drawing.Size(203, 64);
            this.btnGoodEdit.TabIndex = 22;
            this.btnGoodEdit.Text = "Edit";
            this.btnGoodEdit.UseVisualStyleBackColor = false;
            this.btnGoodEdit.Click += new System.EventHandler(this.btnGoodEdit_Click);
            // 
            // btnGoodDelete
            // 
            this.btnGoodDelete.BackColor = System.Drawing.Color.DarkRed;
            this.btnGoodDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGoodDelete.BackgroundImage")));
            this.btnGoodDelete.Font = new System.Drawing.Font("Dubai", 11.1F);
            this.btnGoodDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGoodDelete.Location = new System.Drawing.Point(405, 756);
            this.btnGoodDelete.Name = "btnGoodDelete";
            this.btnGoodDelete.Size = new System.Drawing.Size(203, 64);
            this.btnGoodDelete.TabIndex = 23;
            this.btnGoodDelete.Text = "Delete";
            this.btnGoodDelete.UseVisualStyleBackColor = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EditGood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(1288, 843);
            this.Controls.Add(this.btnGoodDelete);
            this.Controls.Add(this.btnGoodEdit);
            this.Controls.Add(this.cbQuantity);
            this.Controls.Add(this.rtbGoodSubtotal);
            this.Controls.Add(this.rtbGoodId);
            this.Controls.Add(this.rtbGoodName);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "EditGood";
            this.Text = "EditContract";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.RichTextBox rtbGoodName;
        private System.Windows.Forms.RichTextBox rtbGoodId;
        private System.Windows.Forms.RichTextBox rtbGoodSubtotal;
        private System.Windows.Forms.ComboBox cbQuantity;
        private System.Windows.Forms.Button btnGoodEdit;
        private System.Windows.Forms.Button btnGoodDelete;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}