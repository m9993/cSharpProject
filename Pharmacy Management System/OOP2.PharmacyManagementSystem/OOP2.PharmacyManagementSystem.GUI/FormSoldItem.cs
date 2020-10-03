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
using OOP2.PharmacyManagementSystem.Repo;
using OOP2.PharmacyManagementSystem.Entity;
using OOP2.PharmacyManagementSystem.Framework;

namespace OOP2.PharmacyManagementSystem.GUI
{
    public partial class FormSoldItem : MetroForm
    {

        private SaleRepo SRepo { get; set; }
        private MedicineRepo MRepo { get; set; }

        private Sale sal = new Sale();
        private Medicine medi = new Medicine();
        public FormSoldItem()
        {
            InitializeComponent();
            this.SRepo = new SaleRepo();
            this.MRepo = new MedicineRepo();
        }
        private void PopulateGridView()
        {
            this.dgvSale.AutoGenerateColumns = false;
            this.dgvSale.DataSource = SRepo.GetAll().ToList();
            this.dgvSale.ClearSelection();
            this.dgvSale.Refresh();

            this.lblTotalSale.Text = "Total Sale : "+SRepo.CalculateTotalPrice().ToString()+" Taka";
            SRepo.calculateTotalPrice = 0;
        }

        private void FormSoldItem_Load(object sender, EventArgs e)
        {
            PopulateGridView();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
            this.txtIdSearch.Text = null;
            this.pnlUpdate.Visible = false;
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dgvSale.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please Select a Row First");
                return;
            }

            this.pnlUpdate.Visible = true;
            this.txtID.Text = this.dgvSale.CurrentRow.Cells["id"].Value.ToString();
            this.txtName.Text = this.dgvSale.CurrentRow.Cells["name"].Value.ToString();
            this.txtCompany.Text = this.dgvSale.CurrentRow.Cells["company"].Value.ToString();
            this.txtQuantity.Text = this.dgvSale.CurrentRow.Cells["quantity"].Value.ToString();
            this.txtPrice.Text = this.dgvSale.CurrentRow.Cells["price"].Value.ToString();

            this.txtID.Enabled = false;
            this.txtName.Enabled = false;
            this.txtCompany.Enabled = false;
            this.txtPrice.Enabled = false;
            this.txtQuantity.Select();


            DelegateClassForSale.GridDelegate sDelGrid = PopulateGridView;
           // FormSell fs = new FormSell(sDelGrid, s);
           // fs.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.pnlUpdate.Visible = false;
            //PopulateGridView();
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
                sal.id = this.txtID.Text;
                sal.name = this.txtName.Text;
                sal.company = this.txtCompany.Text;
                //sal.quantity = Int32.Parse(this.txtQuantity.Text);
                sal.quantity = Convert.ToInt32(this.txtQuantity.Text);
                sal.price = Convert.ToDouble(this.txtPrice.Text);


                medi.name = this.txtName.Text;
                medi.company = this.txtCompany.Text;
                //medi.quantity = Int32.Parse(this.txtQuantity.Text);
                medi.quantity = Convert.ToInt32(this.txtQuantity.Text);
                medi.price = Convert.ToDouble(this.txtPrice.Text);

                return true;
            }
        }
        private void btnDone_Click(object sender, EventArgs e)
        {
            if (this.FillEntity() == true)
            {
               // this.FillEntity();

                bool s = SRepo.SoldItemUpdate(sal);
                if (s == true)
                {
                    bool m = MRepo.SoldItemUpdate(medi);
                    MessageBox.Show("Update Successfull");
                    this.PopulateGridView();
                    this.pnlUpdate.Visible = false;
                }
                else
                {
                    MessageBox.Show("Update Failed");
                }
              
            }
            else
            {
                MessageBox.Show("Please Fill the Fields Correctly");
            }
        }

        private void txtIdSearch_ButtonClick(object sender, EventArgs e)
        {
            string sql = "select * from sale where id like'%" + this.txtIdSearch.Text + "%'";
            this.dgvSale.AutoGenerateColumns = false;
            this.dgvSale.DataSource = SRepo.GetAll(sql).ToList();
            this.dgvSale.ClearSelection();
            this.dgvSale.Refresh();
        }

        private void FormSoldItem_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.txtIdSearch.Text = null;
            this.pnlUpdate.Visible = false;
            this.Hide();
            //this.Parent = null;
            e.Cancel = true;
        }
    }

}
