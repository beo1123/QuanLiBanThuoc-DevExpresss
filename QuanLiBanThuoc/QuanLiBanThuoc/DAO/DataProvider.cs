using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiBanThuoc.DAO
{
    class DataProvider
    {

        private static string conectionSTR = @"Data Source=VOMINHQUOCBAOPC\QUOCBAO1123;Initial Catalog=DrugSalesManager;Integrated Security=True";




        public static DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable myData = new DataTable();
            using (SqlConnection connection = new SqlConnection(conectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                #region Truyền parameter
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                #endregion
                SqlDataAdapter myAdapter = new SqlDataAdapter(command);
                myAdapter.Fill(myData);
                connection.Close();

            }
            return myData;
        }


        public static int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int rowAffected = 0;

            using (SqlConnection connection = new SqlConnection(conectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                #region Truyền parameter
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in parameter)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                #endregion
                rowAffected = command.ExecuteNonQuery();
                connection.Close();
            }
            return rowAffected;

        }

        public static object ExecuteScalar(string query, object[] parameter = null)
        {
            object result = 0;

            using (SqlConnection connection = new SqlConnection(conectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                #region Truyền parameter
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in parameter)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                #endregion
                result = command.ExecuteScalar();
                connection.Close();
            }
            return result;

        }

    }

}
