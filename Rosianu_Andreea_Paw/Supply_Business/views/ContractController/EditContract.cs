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
    public partial class EditContract : Form
    {
        Contract co;
        public EditContract(Contract c)
        {
            InitializeComponent();
            co = c;
            rtbContractSupplier.Text = c.Name;
            rtbContractGood.Text = c.Good;
            cbContractPay.Text = c.Payment.ToString();

        }

        private void btnContractEdit_Click(object sender, EventArgs e)
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

                    
                    co.Name = name;
                    co.Good = good;
                    co.Payment = pay;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare");
            }
        }

        private void btnContractCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
