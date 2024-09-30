namespace Saloon_Management
{
    partial class BarberForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarberForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlBerb = new System.Windows.Forms.Panel();
            this.gdvBarberShow = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gdvCartView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnCancelCart = new System.Windows.Forms.Button();
            this.btnConfirmCart = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.lblPackage = new System.Windows.Forms.Label();
            this.lblCartview = new System.Windows.Forms.Label();
            this.btnBackToLogin = new System.Windows.Forms.Button();
            this.btnInsertBarberForm = new System.Windows.Forms.Button();
            this.pnlBerb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvBarberShow)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvCartView)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBerb
            // 
            this.pnlBerb.Controls.Add(this.gdvBarberShow);
            this.pnlBerb.Location = new System.Drawing.Point(34, 79);
            this.pnlBerb.Name = "pnlBerb";
            this.pnlBerb.Size = new System.Drawing.Size(493, 409);
            this.pnlBerb.TabIndex = 6;
            // 
            // gdvBarberShow
            // 
            this.gdvBarberShow.AllowUserToAddRows = false;
            this.gdvBarberShow.AllowUserToDeleteRows = false;
            this.gdvBarberShow.BackgroundColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdvBarberShow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gdvBarberShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvBarberShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.gdvBarberShow.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gdvBarberShow.Location = new System.Drawing.Point(3, 3);
            this.gdvBarberShow.Name = "gdvBarberShow";
            this.gdvBarberShow.ReadOnly = true;
            this.gdvBarberShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdvBarberShow.Size = new System.Drawing.Size(493, 468);
            this.gdvBarberShow.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Package Id";
            this.Column1.HeaderText = "Package Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 90;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Package Name";
            this.Column2.HeaderText = "Package Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 90;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Price";
            this.Column3.HeaderText = "Price";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 90;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Discount";
            this.Column4.HeaderText = "Discount";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 90;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Duration";
            this.Column5.HeaderText = "Duration";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 90;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.ForestGreen;
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(208, 503);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 35);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.ForestGreen;
            this.btnRemove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemove.BackgroundImage")));
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(363, 503);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 35);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gdvCartView);
            this.panel1.Location = new System.Drawing.Point(554, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 403);
            this.panel1.TabIndex = 10;
            // 
            // gdvCartView
            // 
            this.gdvCartView.AllowUserToAddRows = false;
            this.gdvCartView.AllowUserToDeleteRows = false;
            this.gdvCartView.AllowUserToResizeColumns = false;
            this.gdvCartView.AllowUserToResizeRows = false;
            this.gdvCartView.BackgroundColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdvCartView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.gdvCartView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvCartView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.gdvCartView.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gdvCartView.Location = new System.Drawing.Point(0, 3);
            this.gdvCartView.Name = "gdvCartView";
            this.gdvCartView.ReadOnly = true;
            this.gdvCartView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdvCartView.Size = new System.Drawing.Size(524, 403);
            this.gdvCartView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Package Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Package Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Package Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Package Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn3.HeaderText = "Price";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Discount";
            this.dataGridViewTextBoxColumn4.HeaderText = "Discount";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Duration";
            this.dataGridViewTextBoxColumn5.HeaderText = "Duration";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddToCart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddToCart.BackgroundImage")));
            this.btnAddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.Location = new System.Drawing.Point(208, 568);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(132, 37);
            this.btnAddToCart.TabIndex = 11;
            this.btnAddToCart.Text = "Add to Cart";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnCancelCart
            // 
            this.btnCancelCart.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCancelCart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelCart.BackgroundImage")));
            this.btnCancelCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelCart.ForeColor = System.Drawing.Color.White;
            this.btnCancelCart.Location = new System.Drawing.Point(879, 503);
            this.btnCancelCart.Name = "btnCancelCart";
            this.btnCancelCart.Size = new System.Drawing.Size(105, 35);
            this.btnCancelCart.TabIndex = 12;
            this.btnCancelCart.Text = "Cancel";
            this.btnCancelCart.UseVisualStyleBackColor = false;
            this.btnCancelCart.Click += new System.EventHandler(this.btnCancelCart_Click);
            // 
            // btnConfirmCart
            // 
            this.btnConfirmCart.BackColor = System.Drawing.Color.ForestGreen;
            this.btnConfirmCart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirmCart.BackgroundImage")));
            this.btnConfirmCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmCart.ForeColor = System.Drawing.Color.White;
            this.btnConfirmCart.Location = new System.Drawing.Point(591, 503);
            this.btnConfirmCart.Name = "btnConfirmCart";
            this.btnConfirmCart.Size = new System.Drawing.Size(117, 35);
            this.btnConfirmCart.TabIndex = 13;
            this.btnConfirmCart.Text = "Confirm";
            this.btnConfirmCart.UseVisualStyleBackColor = false;
            this.btnConfirmCart.Click += new System.EventHandler(this.btnConfirmCart_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.BackColor = System.Drawing.Color.ForestGreen;
            this.btnRecord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRecord.BackgroundImage")));
            this.btnRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecord.ForeColor = System.Drawing.Color.White;
            this.btnRecord.Location = new System.Drawing.Point(744, 503);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(105, 35);
            this.btnRecord.TabIndex = 14;
            this.btnRecord.Text = "Record";
            this.btnRecord.UseVisualStyleBackColor = false;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // lblPackage
            // 
            this.lblPackage.BackColor = System.Drawing.Color.Transparent;
            this.lblPackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackage.ForeColor = System.Drawing.Color.White;
            this.lblPackage.Image = ((System.Drawing.Image)(resources.GetObject("lblPackage.Image")));
            this.lblPackage.Location = new System.Drawing.Point(158, 26);
            this.lblPackage.Name = "lblPackage";
            this.lblPackage.Size = new System.Drawing.Size(231, 39);
            this.lblPackage.TabIndex = 15;
            this.lblPackage.Text = "Package List";
            this.lblPackage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCartview
            // 
            this.lblCartview.BackColor = System.Drawing.Color.Transparent;
            this.lblCartview.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartview.ForeColor = System.Drawing.Color.White;
            this.lblCartview.Image = ((System.Drawing.Image)(resources.GetObject("lblCartview.Image")));
            this.lblCartview.Location = new System.Drawing.Point(683, 26);
            this.lblCartview.Name = "lblCartview";
            this.lblCartview.Size = new System.Drawing.Size(219, 39);
            this.lblCartview.TabIndex = 16;
            this.lblCartview.Text = "Cart View";
            this.lblCartview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBackToLogin
            // 
            this.btnBackToLogin.BackColor = System.Drawing.Color.ForestGreen;
            this.btnBackToLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBackToLogin.BackgroundImage")));
            this.btnBackToLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToLogin.ForeColor = System.Drawing.Color.White;
            this.btnBackToLogin.Location = new System.Drawing.Point(409, 620);
            this.btnBackToLogin.Name = "btnBackToLogin";
            this.btnBackToLogin.Size = new System.Drawing.Size(226, 35);
            this.btnBackToLogin.TabIndex = 17;
            this.btnBackToLogin.Text = "Back To Login Form";
            this.btnBackToLogin.UseVisualStyleBackColor = false;
            this.btnBackToLogin.Click += new System.EventHandler(this.btnBackToLogin_Click);
            // 
            // btnInsertBarberForm
            // 
            this.btnInsertBarberForm.BackColor = System.Drawing.Color.ForestGreen;
            this.btnInsertBarberForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInsertBarberForm.BackgroundImage")));
            this.btnInsertBarberForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertBarberForm.ForeColor = System.Drawing.Color.White;
            this.btnInsertBarberForm.Location = new System.Drawing.Point(52, 504);
            this.btnInsertBarberForm.Name = "btnInsertBarberForm";
            this.btnInsertBarberForm.Size = new System.Drawing.Size(100, 35);
            this.btnInsertBarberForm.TabIndex = 18;
            this.btnInsertBarberForm.Text = "Insert";
            this.btnInsertBarberForm.UseVisualStyleBackColor = false;
            this.btnInsertBarberForm.Click += new System.EventHandler(this.btnInsertBarberForm_Click);
            // 
            // BarberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1113, 684);
            this.Controls.Add(this.btnInsertBarberForm);
            this.Controls.Add(this.btnBackToLogin);
            this.Controls.Add(this.lblCartview);
            this.Controls.Add(this.lblPackage);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.btnConfirmCart);
            this.Controls.Add(this.btnCancelCart);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.pnlBerb);
            this.Name = "BarberForm";
            this.Text = "Barber";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BarberForm_FormClosing);
            this.Load += new System.EventHandler(this.BarberForm_Load);
            this.pnlBerb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdvBarberShow)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdvCartView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlBerb;
        private System.Windows.Forms.DataGridView gdvBarberShow;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gdvCartView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnCancelCart;
        private System.Windows.Forms.Button btnConfirmCart;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Label lblPackage;
        private System.Windows.Forms.Label lblCartview;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnBackToLogin;
        private System.Windows.Forms.Button btnInsertBarberForm;
    }
}