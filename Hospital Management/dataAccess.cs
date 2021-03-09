using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management
{
    public static class DataAccess
    {
        public static DataTable LoadData(string query)
        {
            try
            {
                SqlConnection con =
                    new SqlConnection(@"Data Source=localhost;Initial Catalog=Hospital;Integrated Security=True");
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);

                DataTable dt = ds.Tables[0];

                return dt;
            }
            catch (Exception ex)
            {
                return new DataTable();
            }
        }

        public static int ExecuteQuery(string query)
        {
            try
            {
                SqlConnection con =
                    new SqlConnection(
                        @"Data Source=localhost;Initial Catalog=Hospital;Integrated Security=True");
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
                int row = cmd.ExecuteNonQuery();
                return row;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
    }
}
