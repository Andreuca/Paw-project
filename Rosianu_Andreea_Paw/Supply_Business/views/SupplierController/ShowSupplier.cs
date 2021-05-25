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

namespace Supply_Business.views.SupplierController
{
    public partial class ShowSupplier : Form
    {
        List<Supplier> suppliers = new List<Supplier>();

        string suppliersPath;
        public event CallBack SaveSuppliers;

        public ShowSupplier(List<Supplier> suppliers, string supplierPath)
        {
            InitializeComponent();
            this.suppliers = suppliers;
            this.suppliersPath = suppliersPath;
            populare();
        }
        private void populare()
        {
            listView1.Items.Clear();

            foreach (Supplier s in suppliers)
            {
                ListViewItem itm = new ListViewItem(s.Name);
                itm.SubItems.Add(s.Surname);
                
                itm.SubItems.Add(s.Email.ToString());
                itm.SubItems.Add(s.Phone.ToString());
                itm.Tag = s;
                listView1.Items.Add(itm);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            populare();
        }

        private void btnInputGood_Click(object sender, EventArgs e)
        {
            EditSupplier frmm = new EditSupplier((Supplier)listView1.SelectedItems[0].Tag);
            frmm.ShowDialog();
            populare();
        }

        private void btnDeleteGood_Click(object sender, EventArgs e)
        {
            Supplier s = (Supplier)listView1.SelectedItems[0].Tag;
           suppliers.Remove(s);
            populare();
        }
    }
}
