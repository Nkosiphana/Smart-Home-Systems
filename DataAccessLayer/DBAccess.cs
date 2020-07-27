using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
   public class DBAccess
    {
        //Data Source=VINCENT\\SQLEXPRESS;Initial Catalog=SmartHomeSystem;Integrated Security=True
        SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder();
        SqlCommand sqlCommand = new SqlCommand();
            public DBAccess()
            {
            connectionStringBuilder.DataSource = @"VINCENT\SQLEXPRESS";
            connectionStringBuilder.InitialCatalog = "SmartHomeSystem";
            connectionStringBuilder.IntegratedSecurity = true;
            }

        public DataSet GetData(string tableName)
        {
            DataSet dataSet = new DataSet();
            SqlConnection conn = new SqlConnection(connectionStringBuilder.ToString());
            string query = string.Format("SELECT * FROM {0}", tableName);
            try
            {
                conn.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, conn);
                sqlDataAdapter.FillSchema(dataSet, SchemaType.Source, tableName);
                sqlDataAdapter.Fill(dataSet, tableName);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();    
            }
            return dataSet;
        }

        public void UpdateData(string query)
        {
            SqlConnection conn = new SqlConnection(connectionStringBuilder.ToString());
            try
            {
                conn.Open();
                sqlCommand = new SqlCommand(query, conn);
                sqlCommand.ExecuteNonQuery();
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }           
        }

        public void InsertData(string query)
        {
            SqlConnection conn = new SqlConnection(connectionStringBuilder.ToString());
            try
            {
                conn.Open();
                sqlCommand = new SqlCommand(query, conn);
                sqlCommand.ExecuteNonQuery();

            }
            catch (Exception e)
            { 
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
