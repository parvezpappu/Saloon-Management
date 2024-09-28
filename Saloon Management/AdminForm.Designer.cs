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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker4 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker5 = new System.ComponentModel.BackgroundWorker();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRecordDelete = new System.Windows.Forms.Button();
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
            this.pnlAdmin.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvAdminView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(39, 463);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(112, 45);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(188, 463);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 45);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnRecordDelete
            // 
            this.btnRecordDelete.Location = new System.Drawing.Point(499, 463);
            this.btnRecordDelete.Name = "btnRecordDelete";
            this.btnRecordDelete.Size = new System.Drawing.Size(112, 45);
            this.btnRecordDelete.TabIndex = 6;
            this.btnRecordDelete.Text = "Clear Record";
            this.btnRecordDelete.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(338, 463);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 45);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblAdminMode
            // 
            this.lblAdminMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminMode.Location = new System.Drawing.Point(266, 20);
            this.lblAdminMode.Name = "lblAdminMode";
            this.lblAdminMode.Size = new System.Drawing.Size(134, 23);
            this.lblAdminMode.TabIndex = 8;
            this.lblAdminMode.Text = "Select Mode";
            this.lblAdminMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdBtnPackageTable
            // 
            this.rdBtnPackageTable.AutoSize = true;
            this.rdBtnPackageTable.Location = new System.Drawing.Point(17, 23);
            this.rdBtnPackageTable.Name = "rdBtnPackageTable";
            this.rdBtnPackageTable.Size = new System.Drawing.Size(98, 17);
            this.rdBtnPackageTable.TabIndex = 9;
            this.rdBtnPackageTable.TabStop = true;
            this.rdBtnPackageTable.Text = "Package Table";
            this.rdBtnPackageTable.UseVisualStyleBackColor = true;
            this.rdBtnPackageTable.CheckedChanged += new System.EventHandler(this.rdBtnPackageTable_CheckedChanged);
            // 
            // rdBtnTable1
            // 
            this.rdBtnTable1.AutoSize = true;
            this.rdBtnTable1.Location = new System.Drawing.Point(172, 23);
            this.rdBtnTable1.Name = "rdBtnTable1";
            this.rdBtnTable1.Size = new System.Drawing.Size(99, 17);
            this.rdBtnTable1.TabIndex = 10;
            this.rdBtnTable1.TabStop = true;
            this.rdBtnTable1.Text = "Record Table 1";
            this.rdBtnTable1.UseVisualStyleBackColor = true;
            this.rdBtnTable1.CheckedChanged += new System.EventHandler(this.rdBtnTable1_CheckedChanged);
            // 
            // rdBtnTable2
            // 
            this.rdBtnTable2.AutoSize = true;
            this.rdBtnTable2.Location = new System.Drawing.Point(321, 23);
            this.rdBtnTable2.Name = "rdBtnTable2";
            this.rdBtnTable2.Size = new System.Drawing.Size(99, 17);
            this.rdBtnTable2.TabIndex = 11;
            this.rdBtnTable2.TabStop = true;
            this.rdBtnTable2.Text = "Record Table 2";
            this.rdBtnTable2.UseVisualStyleBackColor = true;
            this.rdBtnTable2.CheckedChanged += new System.EventHandler(this.rdBtnTable2_CheckedChanged);
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.Controls.Add(this.rdBtnTable1);
            this.pnlAdmin.Controls.Add(this.rdBtnTable2);
            this.pnlAdmin.Controls.Add(this.rdBtnPackageTable);
            this.pnlAdmin.Location = new System.Drawing.Point(114, 60);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(441, 54);
            this.pnlAdmin.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gdvAdminView);
            this.panel1.Location = new System.Drawing.Point(64, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 236);
            this.panel1.TabIndex = 13;
            // 
            // gdvAdminView
            // 
            this.gdvAdminView.AllowUserToAddRows = false;
            this.gdvAdminView.AllowUserToDeleteRows = false;
            this.gdvAdminView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvAdminView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.gdvAdminView.Location = new System.Drawing.Point(40, 20);
            this.gdvAdminView.Name = "gdvAdminView";
            this.gdvAdminView.ReadOnly = true;
            this.gdvAdminView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdvAdminView.Size = new System.Drawing.Size(451, 192);
            this.gdvAdminView.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Package Id";
            this.Column1.HeaderText = "Package Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Package Name";
            this.Column2.HeaderText = "Package Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Price";
            this.Column3.HeaderText = "Price";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Discount";
            this.Column4.HeaderText = "Discount";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Duration";
            this.Column5.HeaderText = "Duration";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 533);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlAdmin);
            this.Controls.Add(this.lblAdminMode);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRecordDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.pnlAdmin.ResumeLayout(false);
            this.pnlAdmin.PerformLayout();
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
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRecordDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblAdminMode;
        private System.Windows.Forms.RadioButton rdBtnPackageTable;
        private System.Windows.Forms.RadioButton rdBtnTable1;
        private System.Windows.Forms.RadioButton rdBtnTable2;
        private System.Windows.Forms.Panel pnlAdmin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gdvAdminView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}