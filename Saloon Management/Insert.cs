using System;
using System.Windows.Forms;

namespace Saloon_Management
{
    public partial class InsertForm : Form
    {
        public DataAccess DataAccessInsert { get; set; }
        public bool IsInsertUpdate { get; set; }
        public InsertForm(bool isInsert)
        {
            InitializeComponent();
            this.DataAccessInsert = new DataAccess();
            this.IsInsertUpdate = isInsert;
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

        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("An Error Occured" + ex.Message);
        //        return true;
        //    }
        //  }



        public void UpdateMethod()
        {
            var updateSql = @"update PackageTable
                    set [Package Name]= '" + this.txtNameInsert.Text + @"',
                    Price = " + this.txtPriceInsert.Text + @",
                    Discount = " + this.txtDiscountInsert.Text + @",
                    Duration = '" + this.txtDurationInsert.Text + @"'
                    where [Package Id] = '" + this.txtPidInsert.Text + "'; ";
            var updateCount = this.DataAccessInsert.ExecuteDMLQuery(updateSql);

            if (updateCount == 1)
            {
                MessageBox.Show("Data Has Been Successfully Updated");
                BarberForm b = new BarberForm();
                b.Show();
                //  b.Hide();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Unable to Insert Data! Please Re-Try ");
            }
        }



        public void InsertMethod()
        {
            var sqlInsert = "insert into PackageTable values('"
            + this.txtPidInsert.Text + "','"
            + this.txtNameInsert.Text + "',"
            + this.txtPriceInsert.Text + ","
            + this.txtDiscountInsert.Text + ",'"
            + this.txtDurationInsert.Text + "');";
            var count = this.DataAccessInsert.ExecuteDMLQuery(sqlInsert);

            if (count == 1)
                MessageBox.Show("Data has been added properly");
            else
                MessageBox.Show("There was a problem while inserting data, please try again");
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsValidInsert())
                {
                    MessageBox.Show("Insert the correct text");
                }
                else
                {
                    var insertQuery = "select * from PackageTable where [Package Id]='" + txtPidInsert.Text + "'";
                    var insertInfo = this.DataAccessInsert.ExecuteQueryTable(insertQuery);
                    if (insertInfo.Rows.Count == 1)
                    {
                        if (IsInsertUpdate == true)
                        {
                            MessageBox.Show("You Can't Insert Value, It's already in the list");
                        }
                        else
                            UpdateMethod();
                    }

                    else  // Row.Count = 0;
                    {
                        //insert

                        InsertMethod();

                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
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


    }
}

