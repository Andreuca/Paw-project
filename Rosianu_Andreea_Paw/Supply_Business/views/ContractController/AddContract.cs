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

    public partial class AddContract : Form
    {

        List<Contract> contracts = new List<Contract>();
        string contractsPath;


        public event CallBack SaveContracts;


        public AddContract(List<Contract> contracts, string contractsPath)
        {
            InitializeComponent();
            this.contracts = contracts;
            this.contractsPath = contractsPath;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnInputGood_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(rtbContractSupplier.Text))
                {
                    errorProvider1.SetError(rtbContractSupplier, "Numele");
                }
                else
                if (string.IsNullOrEmpty(rtbContractGood.Text))
                {
                    errorProvider1.SetError(rtbContractGood, "ID-ul");
                }
                else
                if (string.IsNullOrEmpty(cbContractPay.Text))
                {
                    errorProvider1.SetError(cbContractPay, "subtotal");
                }
                else
                {
                    string name = rtbContractSupplier.Text;
                    string good = rtbContractGood.Text;
                    int pay = Convert.ToInt32(cbContractPay.Text);

                    Contract c = new Contract(name,good, pay);
                    contracts.Add(c);
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
                rtbContractSupplier.Clear();
                rtbContractGood.Clear();
                cbContractPay.SelectedIndex = -1;
            }
        }


    }
}
