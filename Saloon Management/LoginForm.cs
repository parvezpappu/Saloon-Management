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
        private bool EmptyLogin()
        {

            if (string.IsNullOrEmpty(this.txtUser.Text) || string.IsNullOrEmpty(this.txtPass.Text))
            {
                MessageBox.Show("Please fill all the text fields.");
                return false;
            }

            else
            {
                return true;
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
                    BarberForm barberForm = new BarberForm //  na. but kaj korce

                    { LoginFormBarber = this };  //LoginFormBarber public Property // Barber Propertyr moddhe rakhlm ei class er instanc // reference.

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
        private void cbxShowPass_CheckedChanged(object sender, EventArgs e)
        {

            if (cbxShowPass.Checked == true)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtPass.Clear();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }

}

