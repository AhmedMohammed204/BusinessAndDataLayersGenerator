using System.Collections.Generic;
using System.Text;

namespace Generator
{
    public static partial class clsGenerateDataLayer
    {
        //Private Members

        internal static string _GetFunctionProperties(List<clsColumn> Columnslist, string Prefix = "", bool ClassFileds = false, clsColumn ColumnToSkip = null, char Suffix = ',', bool AddThis = true, bool SpaceAfterPrefix = false)
        {

            string Properties = "";
            if (ClassFileds)
            {
                foreach (clsColumn property in Columnslist)
                {
                    if (property == ColumnToSkip)
                        continue;
                    Properties += $"{(SpaceAfterPrefix ? $"{Prefix} " : Prefix)}{(AddThis ? "this." : "")}{property.ColumnName}{Suffix} ";
                }
            }
            else
            {
                foreach (clsColumn property in Columnslist)
                {
                    if (property == ColumnToSkip)
                        continue;
                    Properties += $"{Prefix} {property.ColumnDataType} {property.ColumnName}{Suffix} ";
                }
            }
            return Properties.Remove(Properties.Length - 2);

        }
        private static string _CommandAddParameter(clsColumn Column)
        {
            string Parameter = "";
            if (Column.AllowNull)
            {
                Parameter += $"\n\tif(string.IsNullOrEmpty({(Column.ColumnDataType == "string" ? Column.ColumnName : $"{Column.ColumnName}.ToString()")}))\n\t\tcommand.Parameters.AddWithValue(\"@{Column.ColumnName}\", DBNull.Value );\n\telse\n\t\tcommand.Parameters.AddWithValue(\"@{Column.ColumnName}\", {Column.ColumnName} );";
            }
            else
            {
                Parameter += $"\n\tcommand.Parameters.AddWithValue(\"@{Column.ColumnName}\", {Column.ColumnName} );\n";
            }

            return Parameter;
        }
        private static string _CommandParametars(List<clsColumn> Columnslist, clsColumn ColumnToSkip = null)
        {
            string Parametars = "";
            foreach (clsColumn Column in Columnslist)
            {
                if (Column == ColumnToSkip)
                    continue;
                Parametars += _CommandAddParameter(Column);
            }
            return Parametars;
        }
        private static string _ConnectionLine()
        {
            return "\tSqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);";
        }
        private static string _CommandLine()
        {
            return "\tSqlCommand command = new SqlCommand(query, connection);";
        }
        private static string _CathcAndFinallyLines()
        {
            StringBuilder stbCathcAndFinally = new StringBuilder();
            stbCathcAndFinally.Append("\n\tcatch (Exception ex) {}");
            stbCathcAndFinally.Append("\n\tfinally{ connection.Close(); }\n");

            return stbCathcAndFinally.ToString();
        }
        private static string _IsFoundLine()
        {
            return "bool isFound = false;";
        }
        private static string _UpdateQueryParameters(List<clsColumn> Columnslist, clsColumn ColumnToSkip = null)
        {
            StringBuilder sbQueryParameters = new StringBuilder();

            foreach (clsColumn Column in Columnslist)
            {
                if (Column == ColumnToSkip)
                    continue;
                sbQueryParameters.Append($"\t{Column.ColumnName} = @{Column.ColumnName},\n");
            }


            return sbQueryParameters.ToString().Remove(sbQueryParameters.Length - 2);
        }
        private static string _GetReaderDataWithCasting(List<clsColumn> Columnslist)
        {
            StringBuilder sbReaderData = new StringBuilder();
            foreach (clsColumn Column in Columnslist)
            {
                if (Column.AllowNull)
                {
                    sbReaderData.Append($"\t\t\t{Column.ColumnName} = reader[\"{Column.ColumnName}\"] != DBNull.Value ?");
                    sbReaderData.Append($"({Column.ColumnDataType})reader[\"{Column.ColumnName}\"] : ");
                    sbReaderData.AppendLine($"{Column.ColumnName} = default;");
                }
                else
                {
                    sbReaderData.AppendLine($"\t\t\t{Column.ColumnName} = ({Column.ColumnDataType})reader[\"{Column.ColumnName}\"];");
                }
            }
            return sbReaderData.ToString();
        }

    }
}
