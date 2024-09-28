using System;
using System.Windows.Forms;

namespace Saloon_Management
{
    public partial class AdminForm : Form
    {
        private DataAccess dataAccess;
        public InsertForm InsertForm { get; set; }

        public AdminForm()
        {
            InitializeComponent();
            this.dataAccess = new DataAccess();
            LoadPackageTable(); // Load PackageTable by default on form load
        }

        // Load data into the DataGridView based on selected radio button
        private void LoadData(string tableName)
        {
            string query = $"SELECT * FROM {tableName}";
            try
            {
                gdvAdminView.AutoGenerateColumns = false;
                var dataTable = dataAccess.ExecuteQuery(query).Tables[0];
                gdvAdminView.DataSource = dataTable;
                ConfigureDataGridViewColumns(tableName); // Adjust columns for the selected table
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message);
            }
        }

        // Configure DataGridView columns based on the selected table
        private void ConfigureDataGridViewColumns(string tableName)
        {
            // Configure columns for PackageTable
            if (tableName == "PackageTable")
            {
                if (gdvAdminView.Columns["Package Id"] != null)
                {
                    gdvAdminView.Columns["Package Id"].HeaderText = "Package Id";
                }
                if (gdvAdminView.Columns["Package Name"] != null)
                {
                    gdvAdminView.Columns["Package Name"].HeaderText = "Package Name";
                }
                if (gdvAdminView.Columns["Price"] != null)
                {
                    gdvAdminView.Columns["Price"].HeaderText = "Price";
                }
                if (gdvAdminView.Columns["Discount"] != null)
                {
                    gdvAdminView.Columns["Discount"].HeaderText = "Discount";
                }
                if (gdvAdminView.Columns["Duration"] != null)
                {
                    gdvAdminView.Columns["Duration"].HeaderText = "Duration";
                }
            }
            // Configure columns for RecordBarber1 or RecordBarber2
            else if (tableName == "RecordBarber1" || tableName == "RecordBarber2")
            {
                if (gdvAdminView.Columns["Package Id"] != null)
                {
                    gdvAdminView.Columns["Package Id"].HeaderText = "Package Id";
                }
                if (gdvAdminView.Columns["Package Name"] != null)
                {
                    gdvAdminView.Columns["Package Name"].HeaderText = "Package Name";
                }
                if (gdvAdminView.Columns["Price"] != null)
                {
                    gdvAdminView.Columns["Price"].HeaderText = "Price";
                }
                if (gdvAdminView.Columns["Discount"] != null)
                {
                    gdvAdminView.Columns["Discount"].HeaderText = "Discount";
                }
                if (gdvAdminView.Columns["Duration"] != null)
                {
                    gdvAdminView.Columns["Duration"].HeaderText = "Duration";
                }
            }
        }

        // Method to insert a new package into the PackageTable
        //private void InsertPackage(string packageName, decimal price, int discount, string duration)
        //{
        //    string query = $"INSERT INTO PackageTable ([Package Name], Price, Discount, Duration) VALUES ('{packageName}', {price}, {discount}, '{duration}')";
        //    try
        //    {
        //        dataAccess.ExecuteDMLQuery(query);
        //        LoadPackageTable(); // Reload the data to reflect changes
        //        MessageBox.Show("Package inserted successfully.");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("An error occurred while inserting the package: " + ex.Message);
        //    }
        //}

        //// Method to update an existing package in the PackageTable
        //private void UpdatePackage(string packageId, string packageName, decimal price, int discount, string duration)
        //{
        //    string query = $"UPDATE PackageTable SET [Package Name]='{packageName}', Price={price}, Discount={discount}, Duration='{duration}' WHERE [Package Id]='{packageId}'";
        //    try
        //    {
        //        dataAccess.ExecuteDMLQuery(query);
        //        LoadPackageTable(); // Reload the data to reflect changes
        //        MessageBox.Show("Package updated successfully.");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("An error occurred while updating the package: " + ex.Message);
        //    }
        //}

        //// Method to delete a package from the PackageTable
        //private void DeletePackage(string packageId)
        //{
        //    string query = $"DELETE FROM PackageTable WHERE [Package Id]='{packageId}'";
        //    try
        //    {
        //        dataAccess.ExecuteDMLQuery(query);
        //        LoadPackageTable(); // Reload the data to reflect changes
        //        MessageBox.Show("Package deleted successfully.");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("An error occurred while deleting the package: " + ex.Message);
        //    }
        //}

        //// Method to clear records from the specified record table
        //private void ClearRecord(string tableName)
        //{
        //    string query = $"DELETE FROM {tableName}";
        //    try
        //    {
        //        dataAccess.ExecuteDMLQuery(query);
        //        LoadData(tableName); // Reload the data to reflect changes
        //        MessageBox.Show($"{tableName} records cleared successfully.");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"An error occurred while clearing records from {tableName}: " + ex.Message);
        //    }
        //}

        // Event handler for PackageTable radio button
        private void rdBtnPackageTable_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnPackageTable.Checked)
            {
                LoadPackageTable();
            }
        }

        // Event handler for RecordBarber1 radio button
        private void rdBtnTable1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnTable1.Checked)
            {
                LoadData("RecordBarber1");
            }
        }

        // Event handler for RecordBarber2 radio button
        private void rdBtnTable2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnTable2.Checked)
            {
                LoadData("RecordBarber2");
            }
        }

        // Event handler for Insert button

        // Load PackageTable by default
        public void LoadPackageTable()
        {
            LoadData("PackageTable");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            InsertForm insertForm = new InsertForm(true, this);
            insertForm.Show();
            this.Hide();
        }



        private string GetCurrentTableName()
        {
            if (rdBtnPackageTable.Checked)
            {
                return "PackageTable";
            }
            else if (rdBtnTable1.Checked)
            {
                return "RecordBarber1";
            }
            else if (rdBtnTable2.Checked)
            {
                return "RecordBarber2";
            }
            return null;
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if any row is selected in the DataGridView
                if (gdvAdminView.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a row to delete before proceeding.", "Action Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get the selected row from the DataGridView
                var selectedRow = gdvAdminView.CurrentRow;

                // Get the table name based on the selected radio button
                string tableName = GetCurrentTableName();

                if (string.IsNullOrEmpty(tableName))
                {
                    MessageBox.Show("No table selected for deletion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Get the PackageId and PackageName from the selected row
                string packageId = gdvAdminView.CurrentRow.Cells[0].Value.ToString(); // Use actual column name for PackageId
                string packageName = gdvAdminView.CurrentRow.Cells[1].Value.ToString(); // Use actual column name for PackageName

                // Confirm the deletion
                var confirmation = MessageBox.Show($"Are you sure you want to delete the package '{packageName}'?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmation == DialogResult.No)
                {
                    return;
                }

                // Delete query
                string deleteQuery = $"DELETE FROM {tableName} WHERE [Package Id] = '{packageId}'";

                // Execute the delete query
                var rowsAffected = dataAccess.ExecuteDMLQuery(deleteQuery);

                if (rowsAffected == 1)
                {
                    // If deletion is successful, show success message
                    MessageBox.Show($"Package '{packageName}' has been successfully deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Remove the deleted row from the DataGridView
                    gdvAdminView.Rows.Remove(selectedRow);

                    // Refresh the DataGridView to reflect changes
                    LoadData(tableName);
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

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (gdvAdminView.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a row to update before proceeding.", "Action Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get the selected row data
                var selectedPackageId = gdvAdminView.CurrentRow.Cells[0].Value.ToString();
                var selectedPackageName = gdvAdminView.CurrentRow.Cells[1].Value.ToString();
                var selectedPackagePrice = gdvAdminView.CurrentRow.Cells[2].Value.ToString();
                var selectedPackageDiscount = gdvAdminView.CurrentRow.Cells[3].Value.ToString();
                var selectedPackageDuration = gdvAdminView.CurrentRow.Cells[4].Value.ToString();

                // Open the InsertForm with the data to update
                InsertForm insertForm = new InsertForm(false, this)
                {
                    PackageIdText = selectedPackageId,
                    PackageNameText = selectedPackageName,
                    PriceText = selectedPackagePrice,
                    DiscountText = selectedPackageDiscount,
                    DurationText = selectedPackageDuration
                };
                insertForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}