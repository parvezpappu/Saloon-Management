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

        }

        private void LoadData(string tableName)
        {
            string query = $"SELECT * FROM {tableName}";
            try
            {
                gdvAdminView.AutoGenerateColumns = false;
                var dataTable = dataAccess.ExecuteQuery(query).Tables[0];
                gdvAdminView.DataSource = dataTable;
                ConfigureDataGridViewColumns(tableName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message);
            }
        }

        private void ConfigureDataGridViewColumns(string tableName)
        {
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


        //  
        private void rdBtnPackageTable_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnPackageTable.Checked)
            {
                LoadPackageTable();
            }
        }

        private void rdBtnTable1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnTable1.Checked)
            {
                LoadData("RecordBarber1");
            }
        }

        private void rdBtnTable2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnTable2.Checked)
            {
                LoadData("RecordBarber2");
            }
        }

        public void LoadPackageTable()
        {
            LoadData("PackageTable");
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

                var selectedRow = gdvAdminView.CurrentRow;

                string tableName = GetCurrentTableName();

                if (string.IsNullOrEmpty(tableName))
                {
                    MessageBox.Show("No table selected for deletion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string packageId = gdvAdminView.CurrentRow.Cells[0].Value.ToString(); // Use actual column name for PackageId
                string packageName = gdvAdminView.CurrentRow.Cells[1].Value.ToString(); // Use actual column name for PackageName

                var confirmation = MessageBox.Show($"Are you sure you want to delete the package '{packageName}'?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmation == DialogResult.No)
                {
                    return;
                }

                // Delete query
                string deleteQuery = $"DELETE FROM {tableName} WHERE [Package Id] = '{packageId}'";


                var rowsAffected = dataAccess.ExecuteDMLQuery(deleteQuery);

                if (rowsAffected == 1)
                {

                    MessageBox.Show($"Package '{packageName}' has been successfully deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    gdvAdminView.Rows.Remove(selectedRow);


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

                var selectedPackageId = gdvAdminView.CurrentRow.Cells[0].Value.ToString();
                var selectedPackageName = gdvAdminView.CurrentRow.Cells[1].Value.ToString();
                var selectedPackagePrice = gdvAdminView.CurrentRow.Cells[2].Value.ToString();
                var selectedPackageDiscount = gdvAdminView.CurrentRow.Cells[3].Value.ToString();
                var selectedPackageDuration = gdvAdminView.CurrentRow.Cells[4].Value.ToString();


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

        private void btnBackLogin_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();

        }

        private void btnInsertBarber_Click(object sender, EventArgs e)
        {
            InsertForm inform = new InsertForm(false, this);
            inform.Show();
            this.Hide();

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
    }
}