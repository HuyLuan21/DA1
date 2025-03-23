using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DAL
{
    public class DataProvider
    {
        private string connectionString = "Data Source=MSI\\MSI;Initial Catalog=DoAn;Integrated Security=True";

        private static DataProvider instance;
        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataProvider();
                return DataProvider.instance;
            }
            private set
            {
                DataProvider.instance = value;
            }
        }
        public DataTable ExecuteQuery(string query)
        {
            DataTable data = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    adapter.Fill(data);

                    connection.Close();
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }

            return data;
        }
        public int ExecuteNonQuery(string query)
        {
            int Affected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            SqlCommand cmd = new SqlCommand(query, connection, transaction);
                            Affected = cmd.ExecuteNonQuery();
                            transaction.Commit();
                        }
                        catch (SqlException e)
                        {
                            MessageBox.Show(e.Message);
                            transaction.Rollback();
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show($"Database error: {e.Message}");
            }
            return Affected;
        }
    }
}
