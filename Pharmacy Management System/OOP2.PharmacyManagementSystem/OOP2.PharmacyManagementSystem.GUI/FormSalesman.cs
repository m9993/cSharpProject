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
//using OOP2.PharmacyManagementSystem.Data;
using OOP2.PharmacyManagementSystem.Entity;

namespace OOP2.PharmacyManagementSystem.GUI
{
    public partial class FormSalesman : MetroForm
    {
        private MedicineRepo MRepo { get; set; }
        private Medicine m = new Medicine();
        public FormSalesman()
        {
            InitializeComponent();
            this.MRepo = new MedicineRepo();

            this.updateMedicineToolStripMenuItem.Enabled = false;
            this.deleteMedicineToolStripMenuItem.Enabled = false;
        }

        private void FormSalesman_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Text == "Salesman")
            {
                Application.Exit();
            }
            else 
            {
                this.Hide();
                //this.Parent = null;
                e.Cancel = true;
                PopulateGridView();
            }

        }
        private void PopulateGridView(/*string sql = "select * from sale"*/)
        {
            this.dgvMedicine.AutoGenerateColumns = false;
            this.dgvMedicine.DataSource = MRepo.GetAll().ToList();
            this.dgvMedicine.ClearSelection();
            this.dgvMedicine.Refresh();

            this.txtNameSearch.Text = null;
        }

        private void FormSalesman_Load(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
            //this.txtNameSearch.Text = null;
        }
        
        private void txtNameSearch_ButtonClick(object sender, EventArgs e)
        {
            string sql = "select * from medicine where name like'%" + this.txtNameSearch.Text + "%'";
            this.dgvMedicine.AutoGenerateColumns = false;
            this.dgvMedicine.DataSource = MRepo.GetAll(sql).ToList();
            this.dgvMedicine.ClearSelection();
            this.dgvMedicine.Refresh();
        }
      
        private void sellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dgvMedicine.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please Select a Row First");
                return;
            }

             m.id = this.dgvMedicine.CurrentRow.Cells["id"].Value.ToString();
             m.name = this.dgvMedicine.CurrentRow.Cells["name"].Value.ToString();
             m.company = this.dgvMedicine.CurrentRow.Cells["company"].Value.ToString();
             m.quantity = Convert.ToInt32(this.dgvMedicine.CurrentRow.Cells["quantity"].Value);
             m.price = Convert.ToDouble(this.dgvMedicine.CurrentRow.Cells["price"].Value);
            

            DelegateClassForSale.GridDelegate sDelGrid = PopulateGridView;
            FormSell fs = new FormSell(sDelGrid , m);
            fs.Visible = true;
            
        }

        private void soldItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSoldItem fsi= new FormSoldItem();
            fsi.Visible = true;
        }

        private void updateMedicineToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DelegateClassForMedicine.GridDelegate mDelGrid = PopulateGridView;

            FormUpdateMedicine fum = new FormUpdateMedicine(mDelGrid);

            if (this.dgvMedicine.SelectedRows.Count != 1)
            {
                //add new medicine
                MessageBox.Show("Adding a New Medicine");
                fum.txtID.Text = MRepo.AutoNextMedicineIdValue();
                fum.txtID.Enabled = false;

            }
            else
            {
                MessageBox.Show("Updating Medicine");
                //add in existing inventory medicine

                fum.txtID.Text = this.dgvMedicine.CurrentRow.Cells["id"].Value.ToString();
                fum.txtName.Text = this.dgvMedicine.CurrentRow.Cells["name"].Value.ToString();
                fum.txtCompany.Text = this.dgvMedicine.CurrentRow.Cells["company"].Value.ToString();
                fum.txtQuantity.Text = this.dgvMedicine.CurrentRow.Cells["quantity"].Value.ToString();
                fum.txtPrice.Text = this.dgvMedicine.CurrentRow.Cells["price"].Value.ToString();

                fum.txtID.Enabled = false;
            }

            fum.Visible = true;
        }

        private void deleteMedicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.dgvMedicine.SelectedRows.Count !=1 )
            {
                MessageBox.Show("Please Select a Row First");
                return;
            }

            if(MessageBox.Show("Are You Sure ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            string mediId = this.dgvMedicine.CurrentRow.Cells["id"].Value.ToString();

            bool d = MRepo.Delete(mediId);
            
            if(d==true)
            {
                MessageBox.Show("Delete Confirmed");
                this.PopulateGridView();
            }
            else
            {
                MessageBox.Show("Failed Deletion");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            FormLogin fl = new FormLogin();
            fl.Visible = true;
        }
    }
}
