namespace OOP2.PharmacyManagementSystem.GUI
{
    partial class FormSalesman
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSalesman));
            this.dgvMedicine = new MetroFramework.Controls.MetroGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soldItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateMedicineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMedicineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSalesmanName = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtNameSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.pboxSalesman = new System.Windows.Forms.PictureBox();
            this.btnLogout = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicine)).BeginInit();
            this.metroContextMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSalesman)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMedicine
            // 
            this.dgvMedicine.AllowUserToAddRows = false;
            this.dgvMedicine.AllowUserToDeleteRows = false;
            this.dgvMedicine.AllowUserToResizeRows = false;
            this.dgvMedicine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMedicine.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvMedicine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMedicine.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvMedicine.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedicine.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.company,
            this.quantity,
            this.price});
            this.dgvMedicine.ContextMenuStrip = this.metroContextMenu1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMedicine.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMedicine.EnableHeadersVisualStyles = false;
            this.dgvMedicine.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvMedicine.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvMedicine.Location = new System.Drawing.Point(23, 190);
            this.dgvMedicine.MultiSelect = false;
            this.dgvMedicine.Name = "dgvMedicine";
            this.dgvMedicine.ReadOnly = true;
            this.dgvMedicine.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedicine.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMedicine.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMedicine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicine.Size = new System.Drawing.Size(843, 405);
            this.dgvMedicine.Style = MetroFramework.MetroColorStyle.Brown;
            this.dgvMedicine.TabIndex = 0;
            this.dgvMedicine.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // company
            // 
            this.company.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.company.DataPropertyName = "company";
            this.company.HeaderText = "Company";
            this.company.Name = "company";
            this.company.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.ToolTipText = "Per Unit";
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.sellToolStripMenuItem,
            this.soldItemsToolStripMenuItem,
            this.updateMedicineToolStripMenuItem,
            this.deleteMedicineToolStripMenuItem});
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(165, 114);
            this.metroContextMenu1.Style = MetroFramework.MetroColorStyle.Brown;
            this.metroContextMenu1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // sellToolStripMenuItem
            // 
            this.sellToolStripMenuItem.Name = "sellToolStripMenuItem";
            this.sellToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.sellToolStripMenuItem.Text = "Sell";
            this.sellToolStripMenuItem.Click += new System.EventHandler(this.sellToolStripMenuItem_Click);
            // 
            // soldItemsToolStripMenuItem
            // 
            this.soldItemsToolStripMenuItem.Name = "soldItemsToolStripMenuItem";
            this.soldItemsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.soldItemsToolStripMenuItem.Text = "Sold items";
            this.soldItemsToolStripMenuItem.Click += new System.EventHandler(this.soldItemsToolStripMenuItem_Click);
            // 
            // updateMedicineToolStripMenuItem
            // 
            this.updateMedicineToolStripMenuItem.Name = "updateMedicineToolStripMenuItem";
            this.updateMedicineToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.updateMedicineToolStripMenuItem.Text = "Update Medicine";
            this.updateMedicineToolStripMenuItem.Click += new System.EventHandler(this.updateMedicineToolStripMenuItem_Click);
            // 
            // deleteMedicineToolStripMenuItem
            // 
            this.deleteMedicineToolStripMenuItem.Name = "deleteMedicineToolStripMenuItem";
            this.deleteMedicineToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.deleteMedicineToolStripMenuItem.Text = "Delete Medicine";
            this.deleteMedicineToolStripMenuItem.Click += new System.EventHandler(this.deleteMedicineToolStripMenuItem_Click);
            // 
            // lblSalesmanName
            // 
            this.lblSalesmanName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSalesmanName.AutoSize = true;
            this.lblSalesmanName.Location = new System.Drawing.Point(700, 58);
            this.lblSalesmanName.Name = "lblSalesmanName";
            this.lblSalesmanName.Size = new System.Drawing.Size(75, 19);
            this.lblSalesmanName.TabIndex = 1;
            this.lblSalesmanName.Text = "User Name";
            this.lblSalesmanName.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 121);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(74, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Medicines :";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtNameSearch
            // 
            this.txtNameSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtNameSearch.CustomButton.Image = null;
            this.txtNameSearch.CustomButton.Location = new System.Drawing.Point(83, 1);
            this.txtNameSearch.CustomButton.Name = "";
            this.txtNameSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNameSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNameSearch.CustomButton.TabIndex = 1;
            this.txtNameSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNameSearch.CustomButton.UseSelectable = true;
            this.txtNameSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.txtNameSearch.Lines = new string[0];
            this.txtNameSearch.Location = new System.Drawing.Point(761, 161);
            this.txtNameSearch.MaxLength = 32767;
            this.txtNameSearch.Name = "txtNameSearch";
            this.txtNameSearch.PasswordChar = '\0';
            this.txtNameSearch.PromptText = "Name";
            this.txtNameSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNameSearch.SelectedText = "";
            this.txtNameSearch.SelectionLength = 0;
            this.txtNameSearch.SelectionStart = 0;
            this.txtNameSearch.ShortcutsEnabled = true;
            this.txtNameSearch.ShowButton = true;
            this.txtNameSearch.Size = new System.Drawing.Size(105, 23);
            this.txtNameSearch.Style = MetroFramework.MetroColorStyle.Brown;
            this.txtNameSearch.TabIndex = 4;
            this.txtNameSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNameSearch.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtNameSearch.UseCustomForeColor = true;
            this.txtNameSearch.UseSelectable = true;
            this.txtNameSearch.WaterMark = "Name";
            this.txtNameSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNameSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNameSearch.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.txtNameSearch_ButtonClick);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(700, 161);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(55, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Search :";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // pboxSalesman
            // 
            this.pboxSalesman.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pboxSalesman.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pboxSalesman.BackgroundImage")));
            this.pboxSalesman.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pboxSalesman.Image = ((System.Drawing.Image)(resources.GetObject("pboxSalesman.Image")));
            this.pboxSalesman.Location = new System.Drawing.Point(627, 58);
            this.pboxSalesman.Name = "pboxSalesman";
            this.pboxSalesman.Size = new System.Drawing.Size(67, 24);
            this.pboxSalesman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxSalesman.TabIndex = 13;
            this.pboxSalesman.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.BackgroundImage")));
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.DisplayFocus = true;
            this.btnLogout.Location = new System.Drawing.Point(839, 58);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(27, 21);
            this.btnLogout.Style = MetroFramework.MetroColorStyle.Brown;
            this.btnLogout.TabIndex = 14;
            this.btnLogout.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnLogout.UseSelectable = true;
            this.btnLogout.UseStyleColors = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // FormSalesman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 593);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.pboxSalesman);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtNameSearch);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lblSalesmanName);
            this.Controls.Add(this.dgvMedicine);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(609, 383);
            this.Name = "FormSalesman";
            this.Style = MetroFramework.MetroColorStyle.Brown;
            this.Text = "Salesman";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSalesman_FormClosing);
            this.Load += new System.EventHandler(this.FormSalesman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicine)).EndInit();
            this.metroContextMenu1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxSalesman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid dgvMedicine;
        internal MetroFramework.Controls.MetroLabel lblSalesmanName;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn company;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private MetroFramework.Controls.MetroTextBox txtNameSearch;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.ToolStripMenuItem sellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soldItemsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem updateMedicineToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem deleteMedicineToolStripMenuItem;
        internal System.Windows.Forms.PictureBox pboxSalesman;
        internal MetroFramework.Controls.MetroButton btnLogout;
    }
}