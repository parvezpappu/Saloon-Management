
using System;
using System.Windows.Forms;

namespace Saloon_Management
{
    public partial class InsertForm : Form
    {
        public DataAccess DataAccessInsert { get; set; }
        public bool IsInsertUpdate { get; set; }
        private Form callerForm;// extra add ehsan
        public BarberForm BarberForm { get; set; }
        public InsertForm(bool isInsert, Form caller)
        {
            InitializeComponent();
            this.DataAccessInsert = new DataAccess();
            this.IsInsertUpdate = isInsert;
            this.callerForm = caller;
            txtPidInsert.ReadOnly = !isInsert;
        }

        private void lblPIdInsert_Click(object sender, EventArgs e)
        {

        }

        private bool IsValidInsert()
        {
            //try
            //{
            if (string.IsNullOrEmpty(this.txtPidInsert.Text) ||
                string.IsNullOrEmpty(this.txtNameInsert.Text) ||
                string.IsNullOrEmpty(this.txtPriceInsert.Text) ||
                string.IsNullOrEmpty(this.txtDiscountInsert.Text) ||
                string.IsNullOrEmpty(this.txtDurationInsert.Text))
                return false;
            else
                return true;
        }


        public void UpdateMethod()
        {
            var updateSql = @"UPDATE PackageTable
            SET [Package Name] = '" + this.txtNameInsert.Text + @"',
            Price = " + this.txtPriceInsert.Text + @",
            Discount = " + this.txtDiscountInsert.Text + @",
            Duration = '" + this.txtDurationInsert.Text + @"'
            WHERE [Package Id] = '" + this.txtPidInsert.Text + "'; ";
            var updateCount = this.DataAccessInsert.ExecuteDMLQuery(updateSql);

            if (updateCount == 1)
            {
                MessageBox.Show("Data has been updated successfully.");
            }
            else
            {
                MessageBox.Show("Unable to update data! Please try again.");
            }
        }


        public void InsertMethod()
        {
            var sqlInsert = "INSERT INTO PackageTable ([Package Id], [Package Name], Price, Discount, Duration) VALUES('"
            + this.txtPidInsert.Text + "','"
            + this.txtNameInsert.Text + "',"
            + this.txtPriceInsert.Text + ","
            + this.txtDiscountInsert.Text + ",'"
            + this.txtDurationInsert.Text + "');";
            var count = this.DataAccessInsert.ExecuteDMLQuery(sqlInsert);

            if (count == 1)
                MessageBox.Show("Data has been added successfully.");
            else
                MessageBox.Show("There was a problem while inserting data, please try again.");
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsValidInsert())
                {
                    MessageBox.Show("Please fill in all fields correctly.");
                    return; // Stop further execution if validation fails
                }

                var insertQuery = "SELECT * FROM PackageTable WHERE [Package Id]='" + txtPidInsert.Text + "'";
                var insertInfo = this.DataAccessInsert.ExecuteQueryTable(insertQuery);

                if (insertInfo.Rows.Count == 1) // Package already exists
                {
                    if (IsInsertUpdate == true)
                    {
                        MessageBox.Show("You can't insert this value, it's already in the list.");
                        return; // Stop further execution if the package already exists
                    }
                    else
                    {
                        UpdateMethod(); // Update the package if it's an update operation
                    }
                }
                else // New package insertion
                {
                    InsertMethod(); // Insert the new package
                }

                // If the insert/update operation was successful, navigate back to the caller form
                NavigateBackToCaller();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occurred: " + exc.Message);
            }
        }

        private void NavigateBackToCaller()
        {
            if (callerForm is AdminForm)
            {
                AdminForm adminForm = (AdminForm)callerForm;
                adminForm.LoadPackageTable(); // Refresh data in AdminForm
                adminForm.Show(); // Show AdminForm
            }
            else if (callerForm is BarberForm)
            {
                BarberForm barberForm = (BarberForm)callerForm;
                barberForm.ShowPackageList(); // Refresh data in BarberForm
                barberForm.Show(); // Show BarberForm
            }

            this.Close(); // Close InsertForm after navigation
        }

        public string PackageIdText
        {
            get { return txtPidInsert.Text; }
            set { txtPidInsert.Text = value; }
        }

        public string PackageNameText
        {
            get { return txtNameInsert.Text; }
            set { txtNameInsert.Text = value; }
        }

        public string PriceText
        {
            get { return txtPriceInsert.Text; }
            set { txtPriceInsert.Text = value; }
        }

        public string DiscountText
        {
            get { return txtDiscountInsert.Text; }
            set { txtDiscountInsert.Text = value; }
        }

        public string DurationText
        {
            get { return txtDurationInsert.Text; }
            set { txtDurationInsert.Text = value; }
        }




        private void btnEraseInsert_Click(object sender, EventArgs e)
        {
            // Set all the text boxes to empty
            this.txtPidInsert.Text = string.Empty;
            this.txtNameInsert.Text = string.Empty;
            this.txtPriceInsert.Text = string.Empty;
            this.txtDiscountInsert.Text = string.Empty;
            this.txtDurationInsert.Text = string.Empty;
            MessageBox.Show("All fields have been cleared.");
        }

        private void PanelInsert_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InsertForm_Load(object sender, EventArgs e)
        {
            SetReadOnlyMode();
        }

        private void SetReadOnlyMode()
        {
            txtPidInsert.ReadOnly = !IsInsertUpdate; // Make ReadOnly if it is update mode
        }

    }
}/////////insert