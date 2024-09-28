using System;
using System.Windows.Forms;

namespace Saloon_Management
{
    public partial class LoginForm : Form
    {

        public DataAccess DbConnection { get; set; }
        public string Id;

        public LoginForm()
        {
            InitializeComponent();
            this.DbConnection = new DataAccess();
        }

        private void lblUser_Click(object sender, EventArgs e)
        {
        }

        private bool EmptyLogin()
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtUser.Text) || string.IsNullOrEmpty(this.txtPass.Text))
                {
                    MessageBox.Show("Incorrect value. Please fill all the text fields.");
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during validation: " + ex.Message);
                return false;
            }
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Id = this.txtUser.Text;
            var query = "SELECT * FROM LoginTable WHERE userId='" + this.txtUser.Text + "' AND password='" + this.txtPass.Text + "'";
            var sendQuery = DbConnection.ExecuteQuery(query);
            var validation = EmptyLogin();
            if (!validation)
            {
                return;
            }
            if (DbConnection.Dataset.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("Login successful!");
                string role = DbConnection.Dataset.Tables[0].Rows[0]["role"].ToString();

                if (role == "Barber")
                {
                    BarberForm barberForm = new BarberForm // ki korci nijeo  jani. na. but kaj korce

                    { LoginFormBarber = this };

                    this.Hide();
                    barberForm.Show();
                }

                else if (role == "Admin")
                {
                    AdminForm adminForm = new AdminForm();
                    this.Hide();
                    adminForm.Show();
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void lgnPanel_Paint(object sender, PaintEventArgs e)
        {

        }


    }

}

