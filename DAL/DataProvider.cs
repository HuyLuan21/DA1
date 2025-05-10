using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataProvider
    {
        private string connectionString = "Data Source=MSI\\MSI;Initial Catalog=DA1_ver1;Integrated Security=True";

        private static DataProvider instance;

        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataProvider();
                    return instance;
                }
                else
                {
                    return DataProvider.instance;
                }
            }

            private set
            {
                DataProvider.instance = value;
            }
        }

        private DataProvider() { }

        public DataTable ExecuteQuery(string query)
        {
            DataTable data = new DataTable();

            try
            {
                // trong trường hợp mà khối lệnh bên trong có lỗi thì nó vẫn đóng connection
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
                Console.WriteLine(e.ToString());
            }

            return data;
        }

        public int ExecuteNonQuery(string query)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            SqlCommand command = new SqlCommand(query, connection, transaction);
                            rowsAffected = command.ExecuteNonQuery();

                            transaction.Commit();
                        }
                        catch (SqlException e)
                        {
                            transaction.Rollback();
                            Console.WriteLine(e.ToString());
                        }
                    }
                }
            }
            catch (SqlException e)
            {
               Console.WriteLine(e.ToString());
            }

            return rowsAffected;
        }


        public string ExecuteScalar(string query)
        {
            object result = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);

                    result = command.ExecuteScalar();

                    connection.Close();
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }

            if (result == null)
            {
                return null;
            }
            else
            {
                return result.ToString();
            }

        }
    }
}