using System;
using System.Windows.Forms;

namespace Saloon_Management
{
    public partial class BarberForm : Form
    {
        // Instance of DataAccess class
        public DataAccess DataAccessBarber { get; set; }
        public InsertForm InsertFormBarber { get; set; }

        public RecordForm RecordFormBarber { get; set; }

        public LoginForm LoginFormBarber { get; set; }





        public BarberForm()
        {
            InitializeComponent();
            this.DataAccessBarber = new DataAccess();
            this.Click += new EventHandler(Form_Click);
            this.ShowPackageList();
            this.ShowCartList();


        }


        public void ShowPackageList(string hold = "SELECT * FROM PackageTable")
        {
            try
            {
                var exquery = this.DataAccessBarber.ExecuteQuery(hold);
                this.gdvBarberShow.AutoGenerateColumns = false;
                this.gdvBarberShow.DataSource = exquery.Tables[0];
                this.gdvBarberShow.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            // this.Hide();
            loginForm.Show();
            // Application.Exit();
            //this.Close();
        }
        private void BarberForm_Load(object sender, EventArgs e)
        {
            this.gdvBarberShow.ClearSelection();
        }

        public bool check = false;

        private void btnInsert_Click(object sender, EventArgs e)
        {
            check = true;
            InsertForm insertform = new InsertForm(check, this);
            insertform.Show();
            check = true;
            this.Hide();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (gdvBarberShow.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a row to update before proceeding.", "Action Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get the selected row data
                var selectedPackageId = gdvBarberShow.CurrentRow.Cells["Column1"].Value.ToString(); // Use actual column name or index
                var selectedPackageName = gdvBarberShow.CurrentRow.Cells["Column2"].Value.ToString(); // Use actual column name or index
                var selectedPrice = gdvBarberShow.CurrentRow.Cells["Column3"].Value.ToString(); // Use actual column name or index
                var selectedDiscount = gdvBarberShow.CurrentRow.Cells["Column4"].Value.ToString(); // Use actual column name or index
                var selectedDuration = gdvBarberShow.CurrentRow.Cells["Column5"].Value.ToString(); // Use actual column name or index

                // Open the InsertForm with the data to update
                InsertForm insertForm = new InsertForm(false, this)
                {
                    PackageIdText = selectedPackageId,
                    PackageNameText = selectedPackageName,
                    PriceText = selectedPrice,
                    DiscountText = selectedDiscount,
                    DurationText = selectedDuration
                };

                insertForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (gdvBarberShow.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a row to delete before proceeding.", "Action Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedPackageId = gdvBarberShow.CurrentRow.Cells[0].Value.ToString();
                var selectedPackageName = gdvBarberShow.CurrentRow.Cells[1].Value.ToString();
                var confirmation = MessageBox.Show($"Are you sure you want to delete the package '{selectedPackageName}'?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmation == DialogResult.No)
                {
                    return;
                }
                var deleteQuery = $"DELETE FROM PackageTable WHERE [Package Id]='{selectedPackageId}'";
                var rowsAffected = DataAccessBarber.ExecuteDMLQuery(deleteQuery);

                if (rowsAffected == 1)
                {
                    MessageBox.Show($"Package '{selectedPackageName}' has been successfully deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("An error occurred while deleting the package. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.ShowPackageList();
            }

            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form_Click(object sender, EventArgs e)
        {
            if (!this.gdvBarberShow.Focused)
            {
                this.gdvBarberShow.ClearSelection();
            }
        }





        private void ShowCartList(string query = "SELECT * FROM CartTable")
        {
            try
            {
                var cartQuery = this.DataAccessBarber.ExecuteQuery(query);
                this.gdvCartView.AutoGenerateColumns = false;
                this.gdvCartView.DataSource = cartQuery.Tables[0];
                this.gdvCartView.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading the cart data: " + ex.Message);
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            try
            {
                if (gdvBarberShow.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a row to add to the cart.", "Action Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get the selected row
                var selectedRow = gdvBarberShow.CurrentRow;

                // Retrieve necessary data from the selected row
                string packageId = selectedRow.Cells["Column1"].Value.ToString(); // Use actual column name or index
                string packageName = selectedRow.Cells["Column2"].Value.ToString();
                string price = selectedRow.Cells["Column3"].Value.ToString();
                string discount = selectedRow.Cells["Column4"].Value.ToString();
                string duration = selectedRow.Cells["Column5"].Value.ToString();

                // Construct SQL insert query
                var insertSql = $"INSERT INTO CartTable ([Package Id], [Package Name], Price, Discount, Duration) VALUES ('{packageId}', '{packageName}', {price}, {discount}, '{duration}')";

                // Execute the insert query
                var rowsAffected = DataAccessBarber.ExecuteDMLQuery(insertSql);

                if (rowsAffected == 1)
                {
                    MessageBox.Show("Package added to cart successfully.", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ShowCartList(); // Refresh cart grid view
                }
                else
                {
                    MessageBox.Show("An error occurred while adding to cart. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("This Item Already Exist in Cart  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnCancelCart_Click(object sender, EventArgs e)
        {
            try
            {
                if (gdvCartView.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a row to delete before proceeding.", "Action Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedPackageId = gdvCartView.CurrentRow.Cells[0].Value.ToString();
                var selectedPackageName = gdvCartView.CurrentRow.Cells[1].Value.ToString();
                var confirmation = MessageBox.Show($"Are you sure you want to delete the package '{selectedPackageName}'?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmation == DialogResult.No)
                {
                    return;
                }
                var deleteQuery = $"DELETE FROM CartTable WHERE [Package Id]='{selectedPackageId}'";
                var rowsAffected = DataAccessBarber.ExecuteDMLQuery(deleteQuery);

                if (rowsAffected == 1)
                {
                    MessageBox.Show($"Package '{selectedPackageName}' has been successfully deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ShowCartList();
                }
                else
                {
                    MessageBox.Show("An error occurred while deleting the package. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnRecord_Click(object sender, EventArgs e)
        {

            // Check if RecordForm is already open or not

            if (LoginFormBarber.Id == "S-002")
            {

                if (RecordFormBarber == null || RecordFormBarber.IsDisposed)
                {
                    RecordFormBarber = new RecordForm(LoginFormBarber.Id);
                }
                var recordQuery = this.DataAccessBarber.ExecuteQuery("SELECT * FROM RecordBarber1");
                RecordFormBarber.LoadData(recordQuery.Tables[0]);
                RecordFormBarber.Show();
            }

            else if (LoginFormBarber.Id == "S-003")
            {
                if (RecordFormBarber == null || RecordFormBarber.IsDisposed)
                {
                    RecordFormBarber = new RecordForm(this.LoginFormBarber.Id);
                }
                var recordQuery2 = this.DataAccessBarber.ExecuteQuery("SELECT * FROM RecordBarber2");
                RecordFormBarber.LoadData(recordQuery2.Tables[0]);
                RecordFormBarber.Show();
            }

        }


        private void btnConfirmCart_Click(object sender, EventArgs e)
        {
            if (LoginFormBarber.Id == "S-002")
            {
                try
                {
                    string insertQuery = @"
                 INSERT INTO RecordBarber1 ([Package Id], [Package Name], Price, Discount, Duration)
                 SELECT [Package Id], [Package Name], Price, Discount, Duration
                 FROM CartTable";

                    var rowsAffected = DataAccessBarber.ExecuteDMLQuery(insertQuery);

                    if (rowsAffected > 0)
                    {
                        string deleteQuery = "DELETE FROM CartTable";
                        var deleteRows = DataAccessBarber.ExecuteDMLQuery(deleteQuery);

                        MessageBox.Show($"{rowsAffected} package(s) have been successfully confirmed and moved to records.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.ShowCartList();
                    }
                    else
                    {
                        MessageBox.Show("No packages found in the cart to confirm.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while confirming the packages: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



            else if (LoginFormBarber.Id == "S-003")
            {

                try
                {

                    string insertQuery = @"
                 INSERT INTO RecordBarber2 ([Package Id], [Package Name], Price, Discount, Duration)
                 SELECT [Package Id], [Package Name], Price, Discount, Duration
                 FROM CartTable";

                    var rowsAffected = DataAccessBarber.ExecuteDMLQuery(insertQuery);

                    if (rowsAffected > 0)
                    {
                        string deleteQuery = "DELETE FROM CartTable";
                        var deleteRows = DataAccessBarber.ExecuteDMLQuery(deleteQuery);

                        MessageBox.Show($"{rowsAffected} package(s) have been successfully confirmed and moved to records.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.ShowCartList();
                    }
                    else
                    {
                        MessageBox.Show("No packages found in the cart to confirm.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while confirming the packages: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



        }

        private void gdvBarberShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }




    }
}///
