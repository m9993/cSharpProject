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

namespace OOP2.PharmacyManagementSystem.GUI
{
    public partial class FormLogin : MetroForm
    {
        private Users u=new Users();
        private UsersRepo URepo { get; set; }
        public FormLogin()
        {
            InitializeComponent();
            URepo = new UsersRepo();
        }

        private void ClearFields()
        {
            this.txtID.Text = null;
            this.txtPassword.Text = null;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            u.id = this.txtID.Text;
            u.password = this.txtPassword.Text;

            bool d = URepo.Validation(u);

            if (d==true)
            {
                this.Visible = false;
                MessageBox.Show("Welcome "+u.name.ToUpper());
                if(u.role=="admin")
                {
                    FormAdmin fa = new FormAdmin();
                    fa.lblAdminName.Text= "Welcome, " + u.name.ToUpper();
                    fa.Visible = true;
                }
                if (u.role == "salesman")
                {
                    FormSalesman fs = new FormSalesman();
                    fs.lblSalesmanName.Text = "Welcome, "+u.name.ToUpper();
                    fs.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Please Try Again");
                ClearFields();
            }
            
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
