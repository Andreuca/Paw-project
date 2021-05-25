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

namespace Supply_Business.views.ContractController
{
    public partial class ShowContract : Form
    {
        List<Contract> contracts = new List<Contract>();
        string contractsPath;
        public event CallBack SaveContracts;


        public ShowContract(List<Contract> contracts, string contractsPath)
        {
            InitializeComponent();
            this.contracts = contracts;
            this.contractsPath = contractsPath;

            populare();
        }
        private void populare()
        {
            listView1.Items.Clear();

            foreach (Contract c in contracts)
            {
                ListViewItem itm = new ListViewItem(c.Name);
                itm.SubItems.Add(c.Good);
                itm.SubItems.Add(c.Payment.ToString());
              
                itm.Tag = c;
                listView1.Items.Add(itm);
            }
        }

        private void btncContractPopulare_Click(object sender, EventArgs e)
        {
            populare();
        }

        private void btnInputGood_Click(object sender, EventArgs e)
        {
            EditContract frm = new EditContract((Contract)listView1.SelectedItems[0].Tag);
            frm.ShowDialog();
            populare();
        }
        private void btnDeleteContract_Click_1(object sender, EventArgs e)
        {
            Contract c = (Contract)listView1.SelectedItems[0].Tag;
            contracts.Remove(c);
            SaveContracts?.Invoke(contracts, contractsPath);
            MessageBox.Show("Contract deleted succesfully!");
            populare();
        }
    }
}
