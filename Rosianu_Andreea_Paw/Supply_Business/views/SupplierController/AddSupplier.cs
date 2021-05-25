using Supply_Business.models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supply_Business.views.SupplierController
{
    public partial class AddSupplier : Form
    {
        List<Supplier> suppliers = new List<Supplier>();
        string suppliersPath;
       

        public event CallBack SaveSuppliers;
        public AddSupplier(List<Supplier> suppliers, string suppliersPath)
        {
            InitializeComponent();
            this.suppliers = suppliers;
            this.suppliersPath = suppliersPath;
            
        }

        private void AddSupplier_Load(object sender, EventArgs e)
        {

        }

        private void btnInputGood_Click(object sender, EventArgs e)
        {
            
            try
            {

                if (string.IsNullOrEmpty(rtbSupplierName.Text))
                {
                    errorProvider1.SetError(rtbSupplierName, "Enter the supplier name");
                }
                else
                if (string.IsNullOrEmpty(rtbSupplierSurname.Text))
                {
                    errorProvider1.SetError(rtbSupplierSurname, "Enter the supplier surname");
                }
                else


             
               

                 if (string.IsNullOrEmpty(rtbSupplierEmail.Text))
                {
                    errorProvider1.SetError(rtbSupplierEmail, "Enter the supplier email");
                }
                else
                  if (string.IsNullOrEmpty(rtbSupplierPhoneNumber.Text))// phonee.Length != 10
                {
                    errorProvider1.SetError(rtbSupplierPhoneNumber, "You didn't complete the phone field correctly");
                }
                else
                {
                    string name = rtbSupplierName.Text;
                    string surname = rtbSupplierSurname.Text;
                    
                    string email = rtbSupplierEmail.Text;
                    int phone = Convert.ToInt32(rtbSupplierPhoneNumber.Text);

                    Supplier s = new Supplier(name, surname, email,phone);
                    suppliers.Add(s);
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
                rtbSupplierName.Clear();
                rtbSupplierSurname.Clear();
                
                rtbSupplierEmail.Clear();
                rtbSupplierPhoneNumber.Clear();


            }
        }
    }
}
