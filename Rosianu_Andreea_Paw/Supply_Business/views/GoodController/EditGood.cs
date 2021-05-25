using Supply_Business.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supply_Business.views.GoodController
{
    public partial class EditGood : Form
    {
        Good go;
        public EditGood(Good g)
        {
            InitializeComponent();
            go = g;
            rtbGoodName.Text = g.Name;
            rtbGoodId.Text = g.Id.ToString();
            rtbGoodSubtotal.Text = g.Subtotal.ToString();
            cbQuantity.Text = g.Quan.ToString();

        }
        
        private void btnGoodEdit_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(rtbGoodName.Text))
                {
                    errorProvider1.SetError(rtbGoodName, "Numele");
                }
                else
                if (string.IsNullOrEmpty(rtbGoodId.Text))
                {
                    errorProvider1.SetError(rtbGoodId, "ID-ul");
                }
                else
                if (string.IsNullOrEmpty(rtbGoodSubtotal.Text))
                {
                    errorProvider1.SetError(rtbGoodSubtotal, "subtotal");
                }
                else

                 if (string.IsNullOrEmpty(cbQuantity.Text))
                {
                    errorProvider1.SetError(cbQuantity, "quantity");
                }
                else

                {
                    string name = rtbGoodName.Text;
                    int id = Convert.ToInt32(rtbGoodId.Text);
                    int subtotal = Convert.ToInt32(rtbGoodSubtotal.Text);
                    int quantity = Convert.ToInt32(cbQuantity.Text);

                    go.Name = name;
                    go.Id = id;
                    go.Subtotal = subtotal;
                    go.Quan = quantity;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare");
            }
          
        }
    }
}
