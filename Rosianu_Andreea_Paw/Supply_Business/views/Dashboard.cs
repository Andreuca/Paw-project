using Supply_Business.models;
using Supply_Business.views.ContractController;
using Supply_Business.views.GoodController;
using Supply_Business.views.SupplierController;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supply_Business
{
    public delegate void CallBack(object obj, string path);
    public partial class Form1 : Form
    {

       
        List<Good> goods = new List<Good>();
        List<Contract> contracts = new List<Contract>();
        List<Supplier> suppliers = new List<Supplier>();
        private const string goodsPath = "goods.bin";
        private const string contractsPath = "contracts.bin";
        private const string suppliersPath = "suppliers.bin";

        public Form1()
        {
            InitializeComponent();
            customizeDesign();
            try
            {
                this.goods = (List<Good>)Deserialize(goodsPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                this.contracts = (List<Contract>)Deserialize(contractsPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                this.suppliers = (List<Supplier>)Deserialize(suppliersPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void Serialize(object value, string path)
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();

                using (Stream fStream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    formatter.Serialize(fStream, value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static object Deserialize(string path)
        {
            if (!System.IO.File.Exists(path)) { throw new NotImplementedException(); }

            BinaryFormatter formatter = new BinaryFormatter();

            using (Stream fStream = File.OpenRead(path))
            {
                return formatter.Deserialize(fStream);
            }
        }
        private void customizeDesign()
        {
            panelSupply.Visible = false;
            panelContract.Visible = false;
            panelGood.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelSupply.Visible == true)
                panelSupply.Visible = false;
            if (panelContract.Visible == true)
                panelContract.Visible = false;
            if (panelGood.Visible == true)
                panelGood.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnSupply_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSupply);
        }

        #region subSupply
        private void button3_Click(object sender, EventArgs e)
        {


            AddSupplier form = new AddSupplier(suppliers, suppliersPath);
            form.SaveSuppliers += Serialize;
            openChildForm(form);
            //hideSubMenu();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new ShowSupplier(suppliers, suppliersPath));
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Save supplier?", "Save supplier", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Serialize(suppliers, suppliersPath);
                    MessageBox.Show("Suppliers saved in the " + suppliersPath + " document!");
                }

                if (activeForm != null)
                {
                    activeForm.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
#endregion

        private void btnContract_Click(object sender, EventArgs e)
        {
            showSubMenu(panelContract);
        }

        #region subContract
        private void button8_Click(object sender, EventArgs e)
        {
            AddContract form = new AddContract(contracts, contractsPath);
            form.SaveContracts += Serialize;
            openChildForm(form);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openChildForm(new ShowContract(contracts, contractsPath));
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Save contract?", "Save contract", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Serialize(contracts, contractsPath);
                    MessageBox.Show("Contracts saved in the " + contractsPath + " document!");
                }

                if (activeForm != null)
                {
                    activeForm.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void btnGood_Click(object sender, EventArgs e)
        {
            showSubMenu(panelGood);
        }
        #region subGood
        private void button13_Click(object sender, EventArgs e)
        {
            AddGood form = new AddGood(goods, goodsPath);
            form.SaveGoods += Serialize;
            openChildForm(form);
            //hideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            openChildForm(new ShowGood(goods, goodsPath));
            hideSubMenu();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Save good?", "Save good", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Serialize(goods, goodsPath);
                    MessageBox.Show("Goods saved in the " + goodsPath + " document");
                }

                if (activeForm != null)
                {
                    activeForm.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void messageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("merge???");

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSupplier form = new AddSupplier(suppliers, suppliersPath);
            form.SaveSuppliers += Serialize;
            openChildForm(form);
        }

        private void contractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddContract form = new AddContract(contracts, contractsPath);
            form.SaveContracts += Serialize;
            openChildForm(form);
        }

        private void goodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddGood form = new AddGood(goods, goodsPath);
            form.SaveGoods += Serialize;
            openChildForm(form);
            //hideSubMenu();
        }
    }
}
#endregion
