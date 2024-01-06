using System.Collections.Generic;
using System.Text;

namespace Generator
{


    public static partial class clsGenerateDataLayer
    {

        public static string GetAll_Function(string TableName, List<clsColumn> Columnslist)
        {
            clsColumn PkColumn = clsColumn.GetPrimaryKeyColumn(Columnslist);
            StringBuilder sbGetAll = new StringBuilder();
            sbGetAll.AppendLine($"public static DataTable GetAll{TableName}()");
            sbGetAll.AppendLine("{");

            sbGetAll.AppendLine("\n\tDataTable dt = new DataTable();");
            sbGetAll.AppendLine(_ConnectionLine());
            sbGetAll.AppendLine($"\tstring query = \"SELECT * FROM {TableName}\";");
            sbGetAll.AppendLine(_CommandLine());
            sbGetAll.AppendLine("\n\ttry\n\t{");
            sbGetAll.AppendLine("\t\tconnection.Open();");
            sbGetAll.AppendLine("\t\tSqlDataReader reader = command.ExecuteReader();");
            sbGetAll.AppendLine("\t\tif (reader.HasRows)dt.Load(reader);");
            sbGetAll.AppendLine("\t\treader.Close();");
            sbGetAll.Append("\t}");
            sbGetAll.AppendLine(_CathcAndFinallyLines());
            sbGetAll.Append("\n\treturn dt;");


            sbGetAll.AppendLine("\n}");
            return sbGetAll.ToString();
        }
        public static string IsExist_Function(string TableName, string TableSinglName, List<clsColumn> Columnslist)
        {
            clsColumn PkColumn = clsColumn.GetPrimaryKeyColumn(Columnslist);
            StringBuilder sbIsExist = new StringBuilder();

            sbIsExist.Append($"public static bool Is{TableSinglName}Exist({PkColumn.ColumnDataType} {PkColumn.ColumnName})");
            sbIsExist.AppendLine("\n{");
            sbIsExist.AppendLine($"\t{_IsFoundLine()}");
            sbIsExist.AppendLine(_ConnectionLine());
            sbIsExist.AppendLine($"\tstring query = \"SELECT Found=1 FROM {TableName} WHERE {PkColumn.ColumnName}= @{PkColumn.ColumnName}\"; ");
            sbIsExist.AppendLine(_CommandLine());
            sbIsExist.AppendLine(_CommandAddParameter(PkColumn));
            sbIsExist.AppendLine("\ttry\n\t{");
            sbIsExist.AppendLine("\t\tconnection.Open();");
            sbIsExist.AppendLine("\t\tSqlDataReader reader = command.ExecuteReader();");
            sbIsExist.AppendLine("\t\tisFound = reader.HasRows;");
            sbIsExist.AppendLine("\t\treader.Close();");
            sbIsExist.Append("\t}");
            sbIsExist.AppendLine(_CathcAndFinallyLines());
            sbIsExist.AppendLine("\n\treturn isFound;");
            sbIsExist.AppendLine("\n}");
            return sbIsExist.ToString();
        }
        public static string Delete_Function(string TableName, string TableSinglName, List<clsColumn> Columnslist)
        {
            clsColumn PkColumn = clsColumn.GetPrimaryKeyColumn(Columnslist);
            StringBuilder sbDeleteFunc = new StringBuilder();

            sbDeleteFunc.Append($"public static bool Delete{TableSinglName}({PkColumn.ColumnDataType} {PkColumn.ColumnName})");
            sbDeleteFunc.AppendLine("\n{");

            sbDeleteFunc.AppendLine($"\tint rowsAffected = 0;");
            sbDeleteFunc.AppendLine(_ConnectionLine());
            sbDeleteFunc.Append($"\tstring query = \"DELETE {TableName} WHERE {PkColumn.ColumnName} = @{PkColumn.ColumnName}\";\n");
            sbDeleteFunc.AppendLine(_CommandLine());
            sbDeleteFunc.AppendLine(_CommandAddParameter(PkColumn));

            sbDeleteFunc.AppendLine("\ttry\n\t{");
            sbDeleteFunc.AppendLine("\t\tconnection.Open();");
            sbDeleteFunc.AppendLine("\t\trowsAffected = command.ExecuteNonQuery();");
            sbDeleteFunc.Append("\t}");
            sbDeleteFunc.AppendLine(_CathcAndFinallyLines());
            sbDeleteFunc.AppendLine("\n\treturn (rowsAffected > 0);");
            sbDeleteFunc.AppendLine("\n}");

            return sbDeleteFunc.ToString();
        }
        public static string GetInfoByID_Function(string TableName, string TableSinglName, List<clsColumn> Columnslist)
        {
            StringBuilder stbFindFunction = new StringBuilder();
            clsColumn PkColumn = clsColumn.GetPrimaryKeyColumn(Columnslist);

            stbFindFunction.Append($"public static bool Get{TableSinglName}InfoByID({PkColumn.ColumnDataType} {PkColumn.ColumnName}, {_GetFunctionProperties(Columnslist, "ref", ColumnToSkip: PkColumn)})");

            stbFindFunction.Append("\n{\n");

            stbFindFunction.AppendLine($"\t{_IsFoundLine()}\n");
            stbFindFunction.AppendLine(_ConnectionLine());
            stbFindFunction.AppendLine($"\tstring query = \"SELECT * FROM {TableName} WHERE {PkColumn.ColumnName} = @{PkColumn.ColumnName}\";");
            stbFindFunction.AppendLine(_CommandLine());
            stbFindFunction.AppendLine($"\tcommand.Parameters.AddWithValue(\"@{PkColumn.ColumnName}\", {PkColumn.ColumnName});\n");
            stbFindFunction.AppendLine($"\ttry\n\t{{\n");
            stbFindFunction.AppendLine($"\t\tconnection.Open();");
            stbFindFunction.AppendLine($"\t\tSqlDataReader reader = command.ExecuteReader();");
            stbFindFunction.AppendLine($"\n\t\tif (reader.Read())");
            stbFindFunction.AppendLine($"\t\t{{");
            stbFindFunction.AppendLine($"\t\t\tisFound = true;\n");
            stbFindFunction.AppendLine(_GetReaderDataWithCasting(Columnslist));
            stbFindFunction.AppendLine($"\t\t}}");
            stbFindFunction.AppendLine($"\t\telse\n\t\t{{\n\t\t\tisFound = false;\n\t\t}}");
            stbFindFunction.AppendLine($"\n\t\treader.Close();");
            stbFindFunction.Append($"\t}}");
            stbFindFunction.AppendLine(_CathcAndFinallyLines());
            stbFindFunction.AppendLine("\treturn isFound;");



            stbFindFunction.Append("\n}");

            return stbFindFunction.ToString();
        }
        public static string Update_Function(string TableName, string TableSinglName, List<clsColumn> Columnslist)
        {
            StringBuilder strUpdateFunction = new StringBuilder();
            clsColumn PkColumn = clsColumn.GetPrimaryKeyColumn(Columnslist);
            string UpdateDefinition = $"public static bool Update{TableSinglName}({_GetFunctionProperties(Columnslist)})";
            strUpdateFunction.Append(UpdateDefinition);
            strUpdateFunction.Append("\n{");

            strUpdateFunction.Append("\n\tint rowsAffected=0;\n");
            strUpdateFunction.Append($"\n{_ConnectionLine()}\n");
            strUpdateFunction.Append($"\n\tstring query = @\"UPDATE {TableName}\n\tSET{_UpdateQueryParameters(Columnslist, PkColumn)}\tWHERE {PkColumn.ColumnName} = @{PkColumn.ColumnName}\";\n");
            strUpdateFunction.Append($"\n{_CommandLine()}\n");
            strUpdateFunction.Append($"\n{_CommandParametars(Columnslist)}\n");
            strUpdateFunction.Append("\n\ttry {connection.Open(); rowsAffected = command.ExecuteNonQuery();}");
            strUpdateFunction.Append(_CathcAndFinallyLines());
            strUpdateFunction.Append("\n\treturn (rowsAffected > 0);\n");

            strUpdateFunction.Append("\n}");


            return strUpdateFunction.ToString();
        }
        public static string AddNew_Function(string TableName, string TableSinglName, List<clsColumn> Columnslist)
        {
            clsColumn PkColumn = clsColumn.GetPrimaryKeyColumn(Columnslist);
            string ID = "ID";
            string AddNewDefinition = $"public static int AddNew{TableSinglName}({_GetFunctionProperties(Columnslist, ColumnToSkip: PkColumn)})";
            string AddNewBody = $@"
        int {ID} = -1;

{_ConnectionLine()}

        string query = @""INSERT INTO {TableName} VALUES ({_GetFunctionProperties(Columnslist, Prefix: "@", ColumnToSkip: PkColumn, ClassFileds: true, AddThis: false, SpaceAfterPrefix: false)})
        SELECT SCOPE_IDENTITY()"";

{_CommandLine()}

{_CommandParametars(Columnslist, PkColumn)}
";
            string TryCatchString = $@"
                    try
            {{
                connection.Open();

                object result = command.ExecuteScalar();
            

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {{
                    {ID} = insertedID;
                }}
            }}

            catch (Exception ex)
            {{
                //Console.WriteLine(Error:  + ex.Message);
               
            }}

            finally 
            {{
                connection.Close(); 
            }}


            return {ID};
";


            return AddNewDefinition + "{\n" + AddNewBody + TryCatchString + "\n}";
        }
        public static string DataAccess_Class()
        {
            StringBuilder sbDataAccess = new StringBuilder();
            sbDataAccess.AppendLine("static class clsDataAccessSettings\n{\n\t public static string ConnectionString = \"Server=YOUR_SERVER;Database=YOUR_DATABASE;User Id=YOUR_USER_ID;Password=YOUR_PASSWORD;\";\n}");
            return sbDataAccess.ToString();
        }

        public static StringBuilder Generate(string TableName, string TableSinglName, List<clsColumn> Columnslist, bool UsingDataAccessClass = false)
        {
            StringBuilder sbDataLayer = new StringBuilder();
            sbDataLayer.AppendLine("using System;\nusing System.Data;\r\nusing System.Data.SqlClient;\n");
            sbDataLayer.AppendLine($"namespace {TableName}DataAccessLayer\n{{");
            if (UsingDataAccessClass) sbDataLayer.AppendLine(DataAccess_Class());
            sbDataLayer.Append($"public static class cls{TableName}DataAccess");
            sbDataLayer.AppendLine("\n{");
            sbDataLayer.AppendLine(GetInfoByID_Function(TableName, TableSinglName, Columnslist));
            sbDataLayer.AppendLine(AddNew_Function(TableName, TableSinglName, Columnslist));
            sbDataLayer.AppendLine(Update_Function(TableName, TableSinglName, Columnslist));
            sbDataLayer.AppendLine(Delete_Function(TableName, TableSinglName, Columnslist));
            sbDataLayer.AppendLine(IsExist_Function(TableName, TableSinglName, Columnslist));
            sbDataLayer.AppendLine(GetAll_Function(TableName, Columnslist));
            sbDataLayer.AppendLine("\n}");
            sbDataLayer.Append("\n}");
            return sbDataLayer;
        }
    }
}




