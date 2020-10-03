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
    public partial class FormUpdateMedicine : MetroForm
    {
        private MedicineRepo mRepo = new MedicineRepo();
        private Medicine medi = new Medicine();
        private DelegateClassForMedicine.GridDelegate mdg;

        private string LoadAutoMedicineIdValue()
        {
            string serial = mRepo.AutoNextMedicineIdValue();
            this.txtID.Text = serial;
            this.txtID.Enabled = false;
            return this.txtID.Text;
        }
        public FormUpdateMedicine(DelegateClassForMedicine.GridDelegate mdg)
        {
            InitializeComponent();
            this.mdg = mdg;
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

        private bool FillEntity()
        {
            if (IsValideToSave() == false)
            {
                return false;
            }

            else
            {
                medi.id = this.txtID.Text;
                medi.name = this.txtName.Text;
                medi.company = this.txtCompany.Text;
                //medi.quantity = Int32.Parse(this.txtQuantity.Text);
                medi.quantity = Convert.ToInt32(this.txtQuantity.Text);
                medi.price = Convert.ToInt32(this.txtPrice.Text);

                return true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btnDone_Click(object sender, EventArgs e)
        {
            bool f = this.FillEntity();
           
            if (f == true)
            {
                bool d = mRepo.Save(medi);

                if (d == true)
                {
                    MessageBox.Show("Successfully Done");
                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }
            else
            {
                MessageBox.Show("Please Fill the Fields Properly");
            }
            this.mdg();
        }

    }
}
