namespace Saloon_Management
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker4 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker5 = new System.ComponentModel.BackgroundWorker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblAdminMode = new System.Windows.Forms.Label();
            this.rdBtnPackageTable = new System.Windows.Forms.RadioButton();
            this.rdBtnTable1 = new System.Windows.Forms.RadioButton();
            this.rdBtnTable2 = new System.Windows.Forms.RadioButton();
            this.pnlAdmin = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gdvAdminView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBackLogin = new System.Windows.Forms.Button();
            this.btnInsertBarber = new System.Windows.Forms.Button();
            this.pnlAdmin.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvAdminView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.ForestGreen;
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(260, 450);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 45);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.ForestGreen;
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(412, 450);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 45);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblAdminMode
            // 
            this.lblAdminMode.BackColor = System.Drawing.Color.Transparent;
            this.lblAdminMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminMode.Location = new System.Drawing.Point(212, 63);
            this.lblAdminMode.Name = "lblAdminMode";
            this.lblAdminMode.Size = new System.Drawing.Size(279, 24);
            this.lblAdminMode.TabIndex = 8;
            this.lblAdminMode.Text = "Select Mode";
            this.lblAdminMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdBtnPackageTable
            // 
            this.rdBtnPackageTable.BackColor = System.Drawing.Color.Transparent;
            this.rdBtnPackageTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnPackageTable.Location = new System.Drawing.Point(24, 16);
            this.rdBtnPackageTable.Name = "rdBtnPackageTable";
            this.rdBtnPackageTable.Size = new System.Drawing.Size(121, 24);
            this.rdBtnPackageTable.TabIndex = 9;
            this.rdBtnPackageTable.TabStop = true;
            this.rdBtnPackageTable.Text = "Package Table";
            this.rdBtnPackageTable.UseVisualStyleBackColor = false;
            this.rdBtnPackageTable.CheckedChanged += new System.EventHandler(this.rdBtnPackageTable_CheckedChanged);
            // 
            // rdBtnTable1
            // 
            this.rdBtnTable1.BackColor = System.Drawing.Color.Transparent;
            this.rdBtnTable1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnTable1.Location = new System.Drawing.Point(172, 16);
            this.rdBtnTable1.Name = "rdBtnTable1";
            this.rdBtnTable1.Size = new System.Drawing.Size(134, 24);
            this.rdBtnTable1.TabIndex = 10;
            this.rdBtnTable1.TabStop = true;
            this.rdBtnTable1.Text = "Record Table 1";
            this.rdBtnTable1.UseVisualStyleBackColor = false;
            this.rdBtnTable1.CheckedChanged += new System.EventHandler(this.rdBtnTable1_CheckedChanged);
            // 
            // rdBtnTable2
            // 
            this.rdBtnTable2.BackColor = System.Drawing.Color.Transparent;
            this.rdBtnTable2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnTable2.Location = new System.Drawing.Point(332, 16);
            this.rdBtnTable2.Name = "rdBtnTable2";
            this.rdBtnTable2.Size = new System.Drawing.Size(124, 24);
            this.rdBtnTable2.TabIndex = 11;
            this.rdBtnTable2.TabStop = true;
            this.rdBtnTable2.Text = "Record Table 2";
            this.rdBtnTable2.UseVisualStyleBackColor = false;
            this.rdBtnTable2.CheckedChanged += new System.EventHandler(this.rdBtnTable2_CheckedChanged);
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.BackColor = System.Drawing.Color.Honeydew;
            this.pnlAdmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlAdmin.BackgroundImage")));
            this.pnlAdmin.Controls.Add(this.rdBtnTable1);
            this.pnlAdmin.Controls.Add(this.rdBtnTable2);
            this.pnlAdmin.Controls.Add(this.rdBtnPackageTable);
            this.pnlAdmin.Location = new System.Drawing.Point(114, 90);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(474, 54);
            this.pnlAdmin.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gdvAdminView);
            this.panel1.Location = new System.Drawing.Point(83, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 279);
            this.panel1.TabIndex = 13;
            // 
            // gdvAdminView
            // 
            this.gdvAdminView.AllowUserToAddRows = false;
            this.gdvAdminView.AllowUserToDeleteRows = false;
            this.gdvAdminView.BackgroundColor = System.Drawing.Color.DimGray;
            this.gdvAdminView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvAdminView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.gdvAdminView.GridColor = System.Drawing.Color.Black;
            this.gdvAdminView.Location = new System.Drawing.Point(3, 0);
            this.gdvAdminView.Name = "gdvAdminView";
            this.gdvAdminView.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdvAdminView.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.gdvAdminView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdvAdminView.Size = new System.Drawing.Size(533, 276);
            this.gdvAdminView.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Package Id";
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column1.HeaderText = "Package Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Package Name";
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column2.HeaderText = "Package Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Price";
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle9;
            this.Column3.HeaderText = "Price";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Discount";
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle10;
            this.Column4.HeaderText = "Discount";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Duration";
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle11;
            this.Column5.HeaderText = "Duration";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // btnBackLogin
            // 
            this.btnBackLogin.BackColor = System.Drawing.Color.ForestGreen;
            this.btnBackLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBackLogin.BackgroundImage")));
            this.btnBackLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackLogin.ForeColor = System.Drawing.Color.White;
            this.btnBackLogin.Location = new System.Drawing.Point(245, 515);
            this.btnBackLogin.Name = "btnBackLogin";
            this.btnBackLogin.Size = new System.Drawing.Size(138, 45);
            this.btnBackLogin.TabIndex = 14;
            this.btnBackLogin.Text = "Back To Login";
            this.btnBackLogin.UseVisualStyleBackColor = false;
            this.btnBackLogin.Click += new System.EventHandler(this.btnBackLogin_Click);
            // 
            // btnInsertBarber
            // 
            this.btnInsertBarber.BackColor = System.Drawing.Color.ForestGreen;
            this.btnInsertBarber.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInsertBarber.BackgroundImage")));
            this.btnInsertBarber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertBarber.ForeColor = System.Drawing.Color.White;
            this.btnInsertBarber.Location = new System.Drawing.Point(100, 450);
            this.btnInsertBarber.Name = "btnInsertBarber";
            this.btnInsertBarber.Size = new System.Drawing.Size(112, 45);
            this.btnInsertBarber.TabIndex = 15;
            this.btnInsertBarber.Text = "Insert";
            this.btnInsertBarber.UseVisualStyleBackColor = false;
            this.btnInsertBarber.Click += new System.EventHandler(this.btnInsertBarber_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(682, 587);
            this.Controls.Add(this.btnInsertBarber);
            this.Controls.Add(this.btnBackLogin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlAdmin);
            this.Controls.Add(this.lblAdminMode);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.pnlAdmin.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdvAdminView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.ComponentModel.BackgroundWorker backgroundWorker4;
        private System.ComponentModel.BackgroundWorker backgroundWorker5;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblAdminMode;
        private System.Windows.Forms.RadioButton rdBtnPackageTable;
        private System.Windows.Forms.RadioButton rdBtnTable1;
        private System.Windows.Forms.RadioButton rdBtnTable2;
        private System.Windows.Forms.Panel pnlAdmin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gdvAdminView;
        private System.Windows.Forms.Button btnBackLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnInsertBarber;
    }
}