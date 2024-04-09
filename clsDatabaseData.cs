using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAndDataLayersGenerator
{
    public class clsDatabaseData
    {
        public string DataBaseName;
        public string TableName;
        public string TableSingleName;
        public string Username;
        public string Password;

        public static string ConvertDataTypeFromSQL(string SQLDataType)
        {

            switch (SQLDataType)
            {
                case "bit":
                    return "bool";
                case "date":
                case "datetime":
                case "datetime1":
                case "datetime2":
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

    }
}
