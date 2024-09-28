using System;
using System.Data;
using System.Windows.Forms;

namespace Saloon_Management
{
    public partial class RecordForm : Form
    {
        public DataAccess AccessRecord { get; set; }
        public LoginForm LoginFormRecord { get; set; }
        public string UserId { get; set; }


        public RecordForm(string userId)
        {
            InitializeComponent();
            this.AccessRecord = new DataAccess();
            this.UserId = userId;
            MessageBox.Show("RecordForm initialized with UserId: " + userId); // For debugging
            this.LoadRecordData();

        }



        private void RecordForm_Load(object sender, EventArgs e)
        {
            LoadRecordData();
        }

        private void LoadRecordData()
        {
            string query = string.Empty;

            if (UserId == "S-002")
            {
                query = "SELECT * FROM RecordBarber1";
            }
            else if (UserId == "S-003")
            {
                query = "SELECT * FROM RecordBarber2";
            }
            else
            {
                MessageBox.Show("Unauthorized access.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            ShowRecordList(query);
        }


        private void ShowRecordList(string hold)
        {
            try
            {
                var exquery = this.AccessRecord.ExecuteQuery(hold);
                this.gdvRecordView.AutoGenerateColumns = false;
                this.gdvRecordView.DataSource = exquery.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message);
            }
        }




        // Method to load data into gdvRecordView
        public void LoadData(DataTable dataTable)
        {
            try
            {
                this.gdvRecordView.AutoGenerateColumns = false;
                this.gdvRecordView.DataSource = dataTable;
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading record data: " + ex.Message);
            }
        }

        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            string deleteQuery = string.Empty;
            string selectQuery = string.Empty;

            if (UserId == "S-002")
            {
                deleteQuery = "DELETE FROM RecordBarber1";
                selectQuery = "SELECT * FROM RecordBarber1";
            }
            else if (UserId == "S-003")
            {
                deleteQuery = "DELETE FROM RecordBarber2";
                selectQuery = "SELECT * FROM RecordBarber2";
            }
            else
            {
                MessageBox.Show("Unauthorized action.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int rowsAffected = AccessRecord.ExecuteDMLQuery(deleteQuery);
                if (rowsAffected >= 0)
                {
                    MessageBox.Show("History cleared successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowRecordList(selectQuery);
                }
                else
                {
                    MessageBox.Show("No records were deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while clearing history: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BarberForm barberForm = new BarberForm();
            barberForm.Show();
            this.Hide();
        }
    }



}


