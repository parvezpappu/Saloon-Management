
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
            //  txtPidInsert.ReadOnly = !isInsert;

        }
        public string PackageIdText
        {
            get { return this.txtPidInsert.Text; }
            set { this.txtPidInsert.Text = value; }
        }

        public string PackageNameText
        {
            get { return this.txtNameInsert.Text; }
            set { this.txtNameInsert.Text = value; }
        }

        public string PriceText
        {
            get { return this.txtPriceInsert.Text; }
            set { this.txtPriceInsert.Text = value; }
        }

        public string DiscountText
        {
            get { return this.txtDiscountInsert.Text; }
            set { this.txtDiscountInsert.Text = value; }
        }

        public string DurationText
        {
            get { return this.txtDurationInsert.Text; }
            set { this.txtDurationInsert.Text = value; }
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
                    return;
                }

                var insertQuery = "SELECT * FROM PackageTable WHERE [Package Id]='" + txtPidInsert.Text + "'";
                var insertInfo = this.DataAccessInsert.ExecuteQueryTable(insertQuery);

                if (insertInfo.Rows.Count == 1) // Package already exists
                {
                    if (IsInsertUpdate == true)
                    {
                        MessageBox.Show("You can't insert this value, it's already in the list.");
                        return;
                    }
                    else
                    {
                        UpdateMethod();
                    }
                }
                else        //  when Package not exists
                {
                    InsertMethod();
                }
                NavigateBackToCaller();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Incorrect Format ");
            }
        }

        private void NavigateBackToCaller()
        {
            if (callerForm is AdminForm)
            {
                AdminForm adminForm = (AdminForm)callerForm; // teype casting.  shob property access er jnno
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



        private void InsertForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}/////////insert