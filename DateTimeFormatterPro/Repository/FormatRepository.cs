using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DateTimeFormatterPro.Repository
{
    public class FormatRepository
    {
        private readonly string connectionString =
            ConfigurationManager.ConnectionStrings["DateTimeFormatterDB"].ConnectionString;


        public void Save(DateTime originalDate, string format, string result)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"INSERT INTO FormatHistory
                               (OriginalDate, FormatString, Result)
                               VALUES
                               (@OriginalDate, @FormatString, @Result)";

                SqlCommand command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue("@OriginalDate", originalDate);
                command.Parameters.AddWithValue("@FormatString", format);
                command.Parameters.AddWithValue("@Result", result);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }


        public DataTable GetAll()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"SELECT
                                Id,
                                OriginalDate,
                                FormatString,
                                Result,
                                CreatedDate
                               FROM FormatHistory
                               ORDER BY Id DESC";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

                DataTable table = new DataTable();

                adapter.Fill(table);

                return table;
            }
        }


        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"DELETE FROM FormatHistory
                               WHERE Id = @Id";

                SqlCommand command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}