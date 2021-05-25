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
    public partial class EditSupplier : Form
    {

        Supplier so;
        public EditSupplier(Supplier s)
        {
            InitializeComponent();
            so = s;
            rtbSupplierName.Text = s.Name;
            rtbSupplierSurname.Text = s.Surname;
           
            rtbSupplierEmail.Text = s.Email;
            rtbSupplierPhoneNumber.Text = s.Phone.ToString();
        }

        private void btntSupplierEdit_Click(object sender, EventArgs e)
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
                  if (string.IsNullOrEmpty(rtbSupplierPhoneNumber.Text))
                {
                    errorProvider1.SetError(rtbSupplierPhoneNumber, "Enter the supplier phone number");
                }
                else
                {
                    string name = rtbSupplierName.Text;
                    string surname = rtbSupplierSurname.Text;
                    
                    string email = rtbSupplierEmail.Text;
                    int phone = Convert.ToInt32(rtbSupplierPhoneNumber.Text);

                    so.Name = name;
                    so.Surname = surname;
                  
                    so.Email = email;
                    so.Phone = phone;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare");
            }
        }
    }
}
