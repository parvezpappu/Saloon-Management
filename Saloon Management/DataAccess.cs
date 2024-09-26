using System.Data;
using System.Data.SqlClient;
namespace Saloon_Management
{
    public class DataAccess
    {
        private SqlConnection sqlconnect;

        public SqlConnection Sqlconnect
        {
            get { return this.sqlconnect; }
            set { this.sqlconnect = value; }
        }

        private SqlCommand sqlcmd;
        public SqlCommand Sqlcmd
        {
            get { return this.sqlcmd; }
            set { this.sqlcmd = value; }
        }

        private SqlDataAdapter sqladp;
        public SqlDataAdapter Sqladp
        {
            get { return this.sqladp; }
            set { this.sqladp = value; }
        }

        private DataSet dataset;
        public DataSet Dataset
        {
            get { return this.dataset; }
            set { this.dataset = value; }
        }

        public DataAccess()
        {
            this.Sqlconnect = new SqlConnection("Data Source=DESKTOP-N1RD257;Initial Catalog=\"Saloon Management\";User ID=sa;Password=parvej;Encrypt=False");
            Sqlconnect.Open();
        }

        private void QueryText(string sqlQury)
        {
            this.Sqlcmd = new SqlCommand(sqlQury, this.sqlconnect);
        }
        public DataSet ExecuteQuery(string sql)
        {
            this.Sqlcmd = new SqlCommand(sql, this.Sqlconnect);//this.QueryText(sql);
            this.Sqladp = new SqlDataAdapter(this.Sqlcmd);
            this.Dataset = new DataSet();
            this.Sqladp.Fill(this.dataset);
            return dataset;
        }

        public DataTable ExecuteQueryTable(string sql)
        {
            this.Sqlcmd = new SqlCommand(sql, this.Sqlconnect);//this.QueryText(sql);
            this.Sqladp = new SqlDataAdapter(this.Sqlcmd);
            this.dataset = new DataSet();
            this.Sqladp.Fill(this.dataset);
            return dataset.Tables[0];
        }

        public int ExecuteDMLQuery(string sql)
        {
            this.Sqlcmd = new SqlCommand(sql, this.Sqlconnect);//this.QueryText(sql);
            int u = this.Sqlcmd.ExecuteNonQuery();
            return u;
        }

    }


}
