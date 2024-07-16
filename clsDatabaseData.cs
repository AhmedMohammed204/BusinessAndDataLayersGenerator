using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Generator;
using System.Data.Common;

namespace BusinessAndDataLayersGenerator
{
    public class clsDatabaseData
    {
        public string DataBaseName;
        public string TableName;
        public string TableSingleName;
        public string Username;
        public string Password;

        public clsDatabaseData(string dataBaseName, string tableName, string tableSingleName, string username, string password)
        {
            DataBaseName = dataBaseName;
            TableName = tableName;
            TableSingleName = tableSingleName;
            Username = username;
            Password = password;
        }

        public clsDatabaseData(string dataBaseName, string tableName, string username, string password)
        {
            DataBaseName = dataBaseName;
            TableName = tableName;
            Username = username;
            Password = password;
        }

        public clsDatabaseData()
        {
        }

        public static string ConvertDataTypeFromSQL(string SQLDataType)
        {

            switch (SQLDataType)
            {
                case "bit":
                    return "bool";
                case "Date":
                case "date":
                case "datetime":
                case "datetime1":
                case "datetime2":
                case "smalldatetime":
                    return "DateTime";
                case "decimal":
                case "money":
                case "smallmoney":
                    return "decimal";
                case "float":
                    return "double";
                case "nchar":
                case "varchar":
                case "nvarchar":
                case "text":
                case "ntext":
                    return "string";
                case "tinyint":
                    return "byte";
                case "int":
                    return "int";
                case "smallint":
                    return "short";
                default:
                    return SQLDataType;
            }

        }

        public static void ColumnsListAutoFill(clsDatabaseData dbData, List<clsColumn> ColumnsList)
        {
            string ConnectionString = $"Server=.;Database={dbData.DataBaseName};User Id={dbData.Username};Password={dbData.Password};";
            SqlConnection connection = new SqlConnection(ConnectionString);
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand($"SELECT COLUMN_NAME, DATA_TYPE, " +
                    $"IS_NULLABLE, COLUMNPROPERTY(object_id(TABLE_NAME), COLUMN_NAME, 'IsIdentity') AS IS_IDENTITY, " +
                    $"COLUMNPROPERTY(object_id(TABLE_NAME), COLUMN_NAME, 'IsComputed') AS IS_COMPUTED " +
                    $"FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{dbData.TableName}'", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if(ColumnsList == null )
                    ColumnsList = new List<clsColumn>();
                ColumnsList.Clear();
                while (reader.Read())
                {
                    string columnName = reader["COLUMN_NAME"].ToString();
                    string dataType = reader["DATA_TYPE"].ToString();
                    bool isNullable = reader["IS_NULLABLE"].ToString() == "YES";
                    bool isIdentity = Convert.ToBoolean(reader["IS_IDENTITY"]);
                    bool isComputed = Convert.ToBoolean(reader["IS_COMPUTED"]);

                    dataType = clsDatabaseData.ConvertDataTypeFromSQL(dataType);

                    ColumnsList.Add(new clsColumn(columnName, dataType, isNullable, isIdentity));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        public static List<string> GetAllDatabases(string Username, string Password)
        {
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
                return null;

            List<string> list = new List<string>();
            string ConnectionString = $"Server=.;User Id={Username};Password={Password};";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    DataTable schema = connection.GetSchema("Databases");


                    foreach (DataRow row in schema.Rows)
                    {
                        string databaseName = row.Field<string>("database_name");
                        list.Add (databaseName);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }finally { connection.Close(); }
            }



            return list;
        }
        
        public static List<string> GetAllTables(string DatabaseName,string Username, string Password)
        {
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(DatabaseName))
                return null;

            List<string> list = new List<string>();
            string ConnectionString = $"Server=.;Database={DatabaseName};User Id={Username};Password={Password};";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    DataTable schema = connection.GetSchema("Tables");
                    foreach (DataRow row in schema.Rows)
                    {
                        string tableName = row.Field<string>("TABLE_NAME");
                        list.Add (tableName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally { connection.Close(); }
            }



            return list;
        }
        public static void Fill_CB(List<string> list, ComboBox CB)
        {
            CB.Items.Clear();
            foreach (string Database in list)
            {
                CB.Items.Add(Database);
            }
        }
    }
}
