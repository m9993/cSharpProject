using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using OOP2.PharmacyManagementSystem.Entity;
using OOP2.PharmacyManagementSystem.Repo;
using OOP2.PharmacyManagementSystem.Framework;

namespace OOP2.PharmacyManagementSystem.GUI
{
    public partial class FormSell : MetroForm
    {
        private SaleRepo sRepo = new SaleRepo();
        private MedicineRepo mRepo = new MedicineRepo();
        private Sale sal = new Sale();
        private Medicine medi = new Medicine();
        private DelegateClassForSale.GridDelegate sdg;
        private Medicine m;

        private string LoadAutoSaleIdValue()
        {
            string serial = sRepo.AutoNextSaleIdValue();
            this.txtID.Text = serial;
            this.txtID.Enabled = false;
            return this.txtID.Text;
        }
        public FormSell(DelegateClassForSale.GridDelegate sdg, Medicine m)
        {
            InitializeComponent();
            this.sdg = sdg;
            this.m = m;
        }

        private bool IsValideToSave()
        {
            if (Validation.IsStringValid(this.txtID.Text) && Validation.IsStringValid(this.txtName.Text) && Validation.IsStringValid(this.txtCompany.Text) && Validation.IsIntValid(this.txtQuantity.Text) && Validation.IsDoubleValid(this.txtPrice.Text))
            { 
                return true; 
            }
            else
            {
                return false;
            }
        }
        private bool FillEntity(Medicine m)
        {
            if (IsValideToSave() == false)
            {
                return false;
            }

            else
            {
                /*sal.id = this.txtID.Text;
                sal.name = this.txtName.Text;
                sal.company = this.txtCompany.Text;
                //sal.quantity = Int32.Parse(this.txtQuantity.Text);
                sal.quantity = Convert.ToInt32(this.txtQuantity.Text);
                sal.price = Convert.ToDouble(this.txtPrice.Text);*/


                sal.id = this.txtID.Text;
                sal.name = m.name;
                sal.company = m.company;
                //sal.quantity = Int32.Parse(this.txtQuantity.Text);
                sal.quantity = Convert.ToInt32(this.txtQuantity.Text);
                sal.price = m.price;

                this.medi.id = m.id;
                this.medi.quantity = Convert.ToInt32(this.txtQuantity.Text);
                return true;
            }
        }

        private void FillFields()
        {
            this.txtName.Text = m.name;
            this.txtCompany.Text = m.company;
            this.txtPrice.Text = m.price.ToString();
            this.txtQuantity.Select();

            this.txtName.Enabled = false;
            this.txtCompany.Enabled = false;
            this.txtPrice.Enabled = false;
        }
        private void ClearFields()
        {
            this.LoadAutoSaleIdValue();
            //this.txtName.Clear();
            this.txtName.Text = null;
            this.txtCompany.Text = null;
            this.txtQuantity.Text = null;
            this.txtPrice.Text = null;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void FormSell_Load(object sender, EventArgs e)
        {
            try
            {
                LoadAutoSaleIdValue();
                FillFields();
            }
            catch(Exception ex)
            {
                this.btnSell.Enabled = false;
                MessageBox.Show("Please Contact with Admin");
            }
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            if (this.FillEntity(this.m)==true)
            {
                //this.FillEntity(this.m);

                bool m = mRepo.SellingUpdate(this.medi);
                if (m==true)
                {
                    bool s = sRepo.SellingUpdate(sal);
                    MessageBox.Show("Sell Done. Total Price: " + sRepo.totalPrice.ToString()+" Taka");
                }
                else
                {
                    MessageBox.Show("Not Enough Quantaty");
                }
                this.sdg();
                this.ClearFields();
                this.btnSell.Enabled = false;
            }
            else
            {
                MessageBox.Show(" Quantity must be an integer");
            }
        }
    }
}
