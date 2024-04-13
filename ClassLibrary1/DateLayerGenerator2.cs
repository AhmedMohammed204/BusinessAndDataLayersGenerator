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
            sbGetAll.AppendLine("\n\ttry\n\t{");
                sbGetAll.AppendLine($"using({_ConnectionLine()})");
                sbGetAll.AppendLine("{");

                    sbGetAll.AppendLine($"\tstring query = \"SELECT * FROM {TableName}\";");
                    sbGetAll.AppendLine($"using({_CommandLine()}) ");
                    sbGetAll.AppendLine("{");
                        sbGetAll.AppendLine("\t\tconnection.Open();");
                        sbGetAll.AppendLine("\t\tusing(SqlDataReader reader = command.ExecuteReader()){");
                            sbGetAll.AppendLine("\t\tif (reader.HasRows)dt.Load(reader);");
                            sbGetAll.AppendLine("\t\treader.Close();");
                        sbGetAll.AppendLine("}");
                    sbGetAll.AppendLine("}");
                    sbGetAll.Append("\t}");
            
            sbGetAll.AppendLine("}");
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
            sbIsExist.AppendLine("\ttry\n\t{");

            sbIsExist.AppendLine($"using({_ConnectionLine()})");
            sbIsExist.AppendLine("{");

            sbIsExist.AppendLine($"\tstring query = \"SELECT Found=1 FROM {TableName} WHERE {PkColumn.ColumnName}= @{PkColumn.ColumnName}\"; ");
            sbIsExist.AppendLine($"using({_CommandLine()}) ");
            sbIsExist.AppendLine("{");
                sbIsExist.AppendLine(_CommandAddParameter(PkColumn));
                sbIsExist.AppendLine("\t\tconnection.Open();");
                sbIsExist.AppendLine("\t\tusing(SqlDataReader reader = command.ExecuteReader()){");
                    sbIsExist.AppendLine("\t\t\tisFound = reader.HasRows;");
                sbIsExist.AppendLine("}");
            sbIsExist.AppendLine("}");
            
            sbIsExist.AppendLine("}");
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
            sbDeleteFunc.AppendLine("\ttry\n\t{");
            sbDeleteFunc.AppendLine($"using({_ConnectionLine()}) ");
            sbDeleteFunc.AppendLine("{");

            sbDeleteFunc.Append($"\tstring query = \"DELETE {TableName} WHERE {PkColumn.ColumnName} = @{PkColumn.ColumnName}\";\n");
            sbDeleteFunc.AppendLine($"using({_CommandLine()}) ");
            sbDeleteFunc.AppendLine("{");
            sbDeleteFunc.AppendLine(_CommandAddParameter(PkColumn));
            sbDeleteFunc.AppendLine("\t\tconnection.Open();");
            sbDeleteFunc.AppendLine("\t\trowsAffected = command.ExecuteNonQuery();");
            sbDeleteFunc.AppendLine("}");

            sbDeleteFunc.AppendLine("}");
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
            stbFindFunction.AppendLine($"\ttry\n\t{{\n");
            stbFindFunction.AppendLine($"using({_ConnectionLine()}) ");
            stbFindFunction.AppendLine("{");

            stbFindFunction.AppendLine($"\tstring query = \"SELECT * FROM {TableName} WHERE {PkColumn.ColumnName} = @{PkColumn.ColumnName}\";");
            stbFindFunction.AppendLine($"using({_CommandLine()}) ");
            stbFindFunction.AppendLine("{");

            stbFindFunction.AppendLine($"\tcommand.Parameters.AddWithValue(\"@{PkColumn.ColumnName}\", {PkColumn.ColumnName});\n");
            stbFindFunction.AppendLine($"\t\tconnection.Open();");
            stbFindFunction.AppendLine($"\t\tusing(SqlDataReader reader = command.ExecuteReader())");
            stbFindFunction.AppendLine("{");
            stbFindFunction.AppendLine($"\n\t\tif (reader.Read())");
            stbFindFunction.AppendLine($"\t\t{{");
            stbFindFunction.AppendLine($"\t\t\tisFound = true;\n");
            stbFindFunction.AppendLine(_GetReaderDataWithCasting(Columnslist));
            stbFindFunction.AppendLine($"\t\t}}");
            stbFindFunction.AppendLine($"\t\telse\n\t\t{{\n\t\t\tisFound = false;\n\t\t}}");
            
            stbFindFunction.AppendLine("}");
            stbFindFunction.AppendLine("}");
            stbFindFunction.AppendLine("}");
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
            strUpdateFunction.Append("\n\ttry{\n");
            strUpdateFunction.AppendLine($"using({_ConnectionLine()})");
            strUpdateFunction.AppendLine("\t{");
            strUpdateFunction.Append($"\n\tstring query = @\"UPDATE {TableName}\n\tSET{_UpdateQueryParameters(Columnslist, PkColumn)}\tWHERE {PkColumn.ColumnName} = @{PkColumn.ColumnName}\";\n");
            strUpdateFunction.AppendLine($"\tusing({_CommandLine()}) ");
            strUpdateFunction.AppendLine("\t\t{");
            strUpdateFunction.Append($"\n{_CommandParametars(Columnslist)}\n");
            strUpdateFunction.Append("\n\t\tconnection.Open(); rowsAffected = command.ExecuteNonQuery();");
            strUpdateFunction.AppendLine("\t\t}");
            strUpdateFunction.AppendLine("\t}");
            strUpdateFunction.AppendLine("}");
            strUpdateFunction.Append(_CathcAndFinallyLines());
            strUpdateFunction.Append("\n\treturn (rowsAffected > 0);\n");

            strUpdateFunction.Append("\n}");


            return strUpdateFunction.ToString();
        }
        public static string AddNew_Function(string TableName, string TableSinglName, List<clsColumn> Columnslist)
        {
            clsColumn PkColumn = clsColumn.GetPrimaryKeyColumn(Columnslist);
            StringBuilder strAddNewFunc = new StringBuilder();
            
            string ID = "ID";
            strAddNewFunc.AppendLine($"public static int AddNew{TableSinglName}({_GetFunctionProperties(Columnslist, ColumnToSkip: PkColumn)}) {{" );
            strAddNewFunc.AppendLine($@"
    int {ID} = -1;
    try{{
    using({_ConnectionLine()})
    {{

        string query = @""INSERT INTO {TableName} VALUES ({_GetFunctionProperties(Columnslist, Prefix: "@", ColumnToSkip: PkColumn, ClassFileds: true, AddThis: false, SpaceAfterPrefix: false)})
        SELECT SCOPE_IDENTITY()"";

    using ({_CommandLine()})
        {{

        {_CommandParametars(Columnslist, PkColumn)}
");
            strAddNewFunc.AppendLine( $@"

                connection.Open();

                object result = command.ExecuteScalar();
            

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {{
                    {ID} = insertedID;
                }}
            }}
        }}          
    }}
    {_CathcAndFinallyLines()}
    return {ID};

}}
");


            return strAddNewFunc.ToString();
        }
        public static string DataAccess_Class()
        {
            StringBuilder sbDataAccess = new StringBuilder();
            sbDataAccess.AppendLine("static class clsDataAccessSettings\n{\n\t public static string ConnectionString = \"Server=YOUR_SERVER;Database=YOUR_DATABASE;User Id=YOUR_USER_ID;Password=YOUR_PASSWORD;\";\n}");
            return sbDataAccess.ToString();
        }

        public static StringBuilder Generate(string TableName, string TableSinglName, List<clsColumn> Columnslist, string DatabaseName, bool UsingDataAccessClass = false)
        {
            StringBuilder sbDataLayer = new StringBuilder();
            sbDataLayer.AppendLine("using System;\nusing System.Data;\r\nusing System.Data.SqlClient;\n");
            sbDataLayer.AppendLine($"namespace {DatabaseName}DataAccessLayer\n{{");
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




