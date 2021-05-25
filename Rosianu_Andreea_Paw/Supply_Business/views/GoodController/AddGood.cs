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
    
    public partial class AddGood : Form
    {
        List<Good> goods = new List<Good>();
        string goodsPath;

        public event CallBack SaveGoods;
        public AddGood(List<Good> goods, string goodsPath)
        {
            
            InitializeComponent();
            this.goods = goods;
            this.goodsPath = goodsPath;

        }

        private void btnDeleteGood_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnInputGood_Click(object sender, EventArgs e)
        {
            int idd = -1;
            
            try
            {

                if (string.IsNullOrEmpty(rtbGoodName.Text))
                {
                    errorProvider1.SetError(rtbGoodName, "Numele");
                }
                else
                if (goods.Any(g => g.Id == idd))
                {
                    errorProvider1.SetError(rtbGoodId, "This id has already been used");
                }
                else
                if (string.IsNullOrEmpty(rtbGoodSubtotal.Text))
                {
                    errorProvider1.SetError(rtbGoodSubtotal, "subtotal");
                }
                else

                 if (string.IsNullOrEmpty(cbQuantity.Text))
                {
                    errorProvider1.SetError(cbQuantity, "Invalid quantity");
                }
                else
                   

                {
                    string name = rtbGoodName.Text;
                    int id = Convert.ToInt32(rtbGoodId.Text);
                    int subtotal = Convert.ToInt32(rtbGoodSubtotal.Text);
                    int quantity = Convert.ToInt32(cbQuantity.Text);
                   
                    Good g = new Good(name, id, subtotal, quantity);
                    goods.Add(g);
                    toolStripProgressBar1.Value = 100;
                    toolStripStatusLabel1.Text = toolStripProgressBar1.Value.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                rtbGoodName.Clear();
                rtbGoodId.Clear();
                rtbGoodSubtotal.Clear();
               cbQuantity.SelectedIndex = -1;

            }
        }

        private void deleteDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbGoodName.Clear();
            rtbGoodId.Clear();
            rtbGoodSubtotal.Clear();
            cbQuantity.SelectedIndex = -1;
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
