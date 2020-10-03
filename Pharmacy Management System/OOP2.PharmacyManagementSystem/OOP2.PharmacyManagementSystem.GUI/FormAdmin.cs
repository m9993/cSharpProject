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
using OOP2.PharmacyManagementSystem.Data;
using OOP2.PharmacyManagementSystem.Entity;
using OOP2.PharmacyManagementSystem.Repo;

namespace OOP2.PharmacyManagementSystem.GUI
{
    public partial class FormAdmin : MetroForm
    {
        private Users u = new Users();
        private FormSalesman fs;
        private FormSoldItem fsi;
        private UsersRepo URepo {get;set;}
        public FormAdmin()
        {
            InitializeComponent();
            URepo = new UsersRepo();
            LoadFormSalesman();
            LoadFormSoldItem();
            CustomizeDesign();
            fs.btnLogout.Visible = false;
        }

        private void CustomizeDesign()
        {
            this.pnlUsers.Visible = false;
        }

        private void HidePanel()
        {
            if (this.pnlUsers.Visible == true)
            {
                this.pnlUsers.Visible = true;
            }
        }
        private void ShowPanel(Panel p)
        {
            if (p.Visible == false)
            {
                HidePanel();
                p.Visible = true;
            }
            else
            {
                p.Visible = false;
            }
        }

        private void FormAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LoadFormSalesman()
        {
            fs = new FormSalesman();
            fs.Text = "Inventory";
            fs.lblSalesmanName.Visible = false;
            fs.pboxSalesman.Visible = false;
            //fs.ControlBox = false;
            fs.Resizable = false;
            //fs.Location = new System.Drawing.Point(300, 65);
            //fs.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            //fs.ClientSize = new System.Drawing.Size(609, 383);

            // fs.Visible = true;

            fs.updateMedicineToolStripMenuItem.Enabled = true;
            fs.deleteMedicineToolStripMenuItem.Enabled = true;
        }

        private void LoadFormSoldItem()
        {
            fsi = new FormSoldItem();
        }
        
        private void PopulateGridView()
        {
            this.dgvUsers.DataSource = URepo.GetAll();
            this.dgvUsers.ClearSelection();
            this.dgvUsers.Refresh();
            this.txtRoleSearch.Text = null;
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            PopulateGridView();
        }
        private void txtRoleSearch_ButtonClick(object sender, EventArgs e)
        {

            string sql = "select * from users where role like'%" + this.txtRoleSearch.Text + "%'";
            this.dgvUsers.AutoGenerateColumns = false;
            this.dgvUsers.DataSource = URepo.GetAll(sql).ToList();
            this.dgvUsers.ClearSelection();
            this.dgvUsers.Refresh();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.dgvUsers.SelectedRows.Count !=1)
            {
                MessageBox.Show("Please Select a Row First");
                return;
            }

            MessageBox.Show("Updating Users");
            u.id = this.dgvUsers.CurrentRow.Cells["id"].Value.ToString();
            u.password = this.dgvUsers.CurrentRow.Cells["password"].Value.ToString();
            u.role = this.dgvUsers.CurrentRow.Cells["role"].Value.ToString();
            u.name = this.dgvUsers.CurrentRow.Cells["name"].Value.ToString();

            DelegateClassForUsers.GridDelegate uDelGrid = PopulateGridView;
            FormUpdateUsers fuu = new FormUpdateUsers(uDelGrid, u);
            fuu.txtID.Enabled = false;
            fuu.Visible = true;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Adding New Users");
            u.id = 
            u.password = null;
            u.role = null;
            u.name = null;

            DelegateClassForUsers.GridDelegate uDelGrid = PopulateGridView;
            FormUpdateUsers fuu = new FormUpdateUsers(uDelGrid, u);
            fuu.Visible = true;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dgvUsers.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please Select a Row First");
                return;
            }

            if (MessageBox.Show("Are You Sure ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            u.id = this.dgvUsers.CurrentRow.Cells["id"].Value.ToString();

            bool d = URepo.Delete(u.id);
           
            if (d == true)
            {
                MessageBox.Show("Delete Confirmed");
                this.PopulateGridView();
            }
            else
            {
                MessageBox.Show("Failed Deletion");
            }
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            ShowPanel(this.pnlUsers);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.dgvUsers.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please Select a Row First");
                return;
            }

            MessageBox.Show("Updating Users");
            u.id = this.dgvUsers.CurrentRow.Cells["id"].Value.ToString();
            u.password = this.dgvUsers.CurrentRow.Cells["password"].Value.ToString();
            u.role = this.dgvUsers.CurrentRow.Cells["role"].Value.ToString();
            u.name = this.dgvUsers.CurrentRow.Cells["name"].Value.ToString();

            DelegateClassForUsers.GridDelegate uDelGrid = PopulateGridView;
            FormUpdateUsers fuu = new FormUpdateUsers(uDelGrid, u);
            fuu.txtID.Enabled = false;
            fuu.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Adding New Users");
            u.id =
            u.password = null;
            u.role = null;
            u.name = null;

            DelegateClassForUsers.GridDelegate uDelGrid = PopulateGridView;
            FormUpdateUsers fuu = new FormUpdateUsers(uDelGrid, u);
            fuu.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvUsers.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please Select a Row First");
                return;
            }

            if (MessageBox.Show("Are You Sure ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            u.id = this.dgvUsers.CurrentRow.Cells["id"].Value.ToString();

            bool d = URepo.Delete(u.id);

            if (d == true)
            {
                MessageBox.Show("Delete Confirmed");
                this.PopulateGridView();
            }
            else
            {
                MessageBox.Show("Failed Deletion");
            }
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            fs.Visible = true;
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            fsi.Visible = true;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormLogin fl = new FormLogin();
            fl.Visible = true;
        }
    }
}
