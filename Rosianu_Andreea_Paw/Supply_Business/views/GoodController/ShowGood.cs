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
    public partial class ShowGood : Form
    {
        List<Good> goods = new List<Good>();

        string goodsPath;
        public event CallBack SaveGoods;
        public ShowGood(List<Good> goods, string goodsPath)
        {
            InitializeComponent();
            this.goods = goods;
            this.goodsPath = goodsPath;
            populare();
        }

        private void populare()
        {
            listView1.Items.Clear();

            foreach (Good g in goods)
            {
                ListViewItem itm = new ListViewItem(g.Name);
                itm.SubItems.Add(g.Id.ToString());
                itm.SubItems.Add(g.Subtotal.ToString());
                itm.SubItems.Add(g.Quan.ToString());
                itm.Tag = g;
                listView1.Items.Add(itm);
            }
        }

        private void btnPopulare_Click(object sender, EventArgs e)
        {
            populare();

        }

        private void messageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("message");
        }

        private void altmesajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("another message");
        }

        private void btnInputGood_Click(object sender, EventArgs e)
        {
            EditGood frmm = new EditGood((Good)listView1.SelectedItems[0].Tag);
            frmm.ShowDialog();
            populare();
        }

        private void btnDeleteGood_Click(object sender, EventArgs e)
        {
            Good g= (Good)listView1.SelectedItems[0].Tag;
            goods.Remove(g);
            SaveGoods?.Invoke(goods, goodsPath);
            MessageBox.Show("Good deleted succesfully!");
            populare();
           
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
