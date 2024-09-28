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
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlBerb = new System.Windows.Forms.Panel();
            this.gdvBarberShow = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInsert = new System.Windows.Forms.Button();
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
            this.pnlBerb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvBarberShow)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvCartView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(156, 304);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 35);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pnlBerb
            // 
            this.pnlBerb.Controls.Add(this.gdvBarberShow);
            this.pnlBerb.Location = new System.Drawing.Point(12, 12);
            this.pnlBerb.Name = "pnlBerb";
            this.pnlBerb.Size = new System.Drawing.Size(508, 286);
            this.pnlBerb.TabIndex = 6;
            // 
            // gdvBarberShow
            // 
            this.gdvBarberShow.AllowUserToAddRows = false;
            this.gdvBarberShow.AllowUserToDeleteRows = false;
            this.gdvBarberShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvBarberShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.gdvBarberShow.Location = new System.Drawing.Point(2, 0);
            this.gdvBarberShow.Name = "gdvBarberShow";
            this.gdvBarberShow.ReadOnly = true;
            this.gdvBarberShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdvBarberShow.Size = new System.Drawing.Size(503, 280);
            this.gdvBarberShow.TabIndex = 0;
         
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
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(32, 304);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(100, 35);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(287, 304);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 35);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(418, 304);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 35);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gdvCartView);
            this.panel1.Location = new System.Drawing.Point(528, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 286);
            this.panel1.TabIndex = 10;
            // 
            // gdvCartView
            // 
            this.gdvCartView.AllowUserToAddRows = false;
            this.gdvCartView.AllowUserToDeleteRows = false;
            this.gdvCartView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvCartView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.gdvCartView.Location = new System.Drawing.Point(3, 3);
            this.gdvCartView.Name = "gdvCartView";
            this.gdvCartView.ReadOnly = true;
            this.gdvCartView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdvCartView.Size = new System.Drawing.Size(507, 289);
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
            this.btnAddToCart.Location = new System.Drawing.Point(189, 360);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(100, 35);
            this.btnAddToCart.TabIndex = 11;
            this.btnAddToCart.Text = "Add to Cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnCancelCart
            // 
            this.btnCancelCart.Location = new System.Drawing.Point(835, 329);
            this.btnCancelCart.Name = "btnCancelCart";
            this.btnCancelCart.Size = new System.Drawing.Size(100, 35);
            this.btnCancelCart.TabIndex = 12;
            this.btnCancelCart.Text = "Cancel";
            this.btnCancelCart.UseVisualStyleBackColor = true;
            this.btnCancelCart.Click += new System.EventHandler(this.btnCancelCart_Click);
            // 
            // btnConfirmCart
            // 
            this.btnConfirmCart.Location = new System.Drawing.Point(616, 329);
            this.btnConfirmCart.Name = "btnConfirmCart";
            this.btnConfirmCart.Size = new System.Drawing.Size(100, 35);
            this.btnConfirmCart.TabIndex = 13;
            this.btnConfirmCart.Text = "Confirm";
            this.btnConfirmCart.UseVisualStyleBackColor = true;
            this.btnConfirmCart.Click += new System.EventHandler(this.btnConfirmCart_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(733, 384);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(100, 35);
            this.btnRecord.TabIndex = 14;
            this.btnRecord.Text = "Record";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // BarberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 448);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.btnConfirmCart);
            this.Controls.Add(this.btnCancelCart);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.pnlBerb);
            this.Controls.Add(this.btnBack);
            this.Name = "BarberForm";
            this.Text = "Barber";
            this.Load += new System.EventHandler(this.BarberForm_Load);
            this.pnlBerb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdvBarberShow)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdvCartView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlBerb;
        private System.Windows.Forms.DataGridView gdvBarberShow;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
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
    }
}