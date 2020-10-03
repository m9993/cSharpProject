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
using OOP2.PharmacyManagementSystem.Framework;
using OOP2.PharmacyManagementSystem.Repo;

namespace OOP2.PharmacyManagementSystem.GUI
{
    public partial class FormUpdateUsers : MetroForm
    {
        private DelegateClassForUsers.GridDelegate udg;
        private Users u;
        private Users uEntity = new Users();
        private UsersRepo URepo { get; set; }
        public FormUpdateUsers(DelegateClassForUsers.GridDelegate udg, Users u)
        {
            InitializeComponent();
            this.udg = udg;
            this.u = u;
            URepo = new UsersRepo();
        }

        private bool IsValideToSave()
        {
            if (Validation.IsStringValid(this.txtID.Text) && Validation.IsStringValid(this.txtPassword.Text) && Validation.IsStringValid(this.cmbRole.SelectedItem.ToString()) && Validation.IsStringValid(this.txtName.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void FillFields()
        {
            this.txtID.Text = u.id;
            this.txtPassword.Text = u.password;
            this.cmbRole.SelectedItem = u.role;
            this.txtName.Text = u.name;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private bool FillEntity()
        {
            if (IsValideToSave() == false)
            {
                return false;
            }

            else
            {
                uEntity.id = this.txtID.Text;
                uEntity.password = this.txtPassword.Text;
                uEntity.role = this.cmbRole.SelectedItem.ToString();
                uEntity.name = this.txtName.Text;

                return true;
            }
        }

        private void FormUpdateUsers_Load(object sender, EventArgs e)
        {
            FillFields();
        }


        private void btnDone_Click(object sender, EventArgs e)
        {
            if (this.FillEntity()== true)
            {
                bool d = URepo.Save(uEntity);

                if (d == true)
                {
                    MessageBox.Show("Successfully Done");
                    this.btnDone.Enabled = false;
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
            this.udg();
        }
    }
    
}
