using System;
using System.Windows.Forms;

namespace Saloon_Management
{
    public partial class BarberForm : Form
    {
        // Instance of DataAccess class
        public DataAccess dataAccess;

        public BarberForm()
        {
            InitializeComponent();
            this.dataAccess = new DataAccess();
            ShowPackageList();
        }


        private void ShowPackageList(string hold = "SELECT * FROM PackageTable")
        {
            try
            {
                var exquery = this.dataAccess.ExecuteQuery(hold);
                this.gdvBarberShow.AutoGenerateColumns = false;
                this.gdvBarberShow.DataSource = exquery.Tables[0];
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
            this.Close();
        }
        private void BarberForm_Load(object sender, EventArgs e)
        {

        }

    }
}
