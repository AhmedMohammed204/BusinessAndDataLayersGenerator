using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator
{
    public static class clsGenerateBusinessLayer
    {
        private static string _CallDataAccessCommand = "//call DataAccess Layer ";

        private static string _ColumnFiled(clsColumn Column, bool IsPrivate = false)
        {
            return $"{(IsPrivate ? "private" : "public")} {Column.ColumnDataType} {Column.ColumnName} {{get; set;}}";
        }
        private static string _ColumnsFileds(List<clsColumn> Columns)
        {
            StringBuilder sbFileds = new StringBuilder();

            foreach (clsColumn Column in Columns)
            {
                sbFileds.AppendLine(_ColumnFiled(Column));
            }

            return sbFileds.ToString();
        }
        private static string _DefualtFiledValue(clsColumn Column, bool UseDataType = false)
        {
            return $"{(UseDataType ? $"{Column.ColumnDataType} " : "this.")}{Column.ColumnName} = default;";
        }
        private static string _DefualtFiledsValues(List<clsColumn> Columns, bool UseDataType = false, clsColumn ColumnToSkip = null)
        {
            StringBuilder sbDefualtFiled = new StringBuilder();
            foreach (clsColumn Column in Columns)
            {
                if (Column == ColumnToSkip)
                    continue;
                sbDefualtFiled.AppendLine(_DefualtFiledValue(Column, UseDataType));
            }

            return sbDefualtFiled.ToString();
        }

        private static string _FillClassFileds(List<clsColumn> Columns)
        {
            StringBuilder sb = new StringBuilder();

            foreach (clsColumn Column in Columns)
            {
                sb.AppendLine($"this.{Column.ColumnName} = {Column.ColumnName};");
            }


            return sb.ToString();
        }
        public static string Class_FindStatic(string TableName, string TableSinglName, List<clsColumn> Columns)
        {
            clsColumn PkColumn = clsColumn.GetPrimaryKeyColumn(Columns);
            StringBuilder sbMethod = new StringBuilder();
            sbMethod.AppendLine($"public static cls{TableSinglName} Find({PkColumn.ColumnDataType} {PkColumn.ColumnName})");
            sbMethod.AppendLine("{");
            sbMethod.AppendLine(_DefualtFiledsValues(Columns, true, PkColumn));
            sbMethod.AppendLine($"\nif(cls{TableName}DataAccess.Get{TableSinglName}InfoByID({PkColumn.ColumnName}, {clsGenerateDataLayer._GetFunctionProperties(Columns, ColumnToSkip: PkColumn, Prefix: "ref", ClassFileds: true, AddThis: false, SpaceAfterPrefix: true)}))");
            sbMethod.AppendLine($"return new cls{TableSinglName}({clsGenerateDataLayer._GetFunctionProperties(Columns, ClassFileds: true, AddThis: false, SpaceAfterPrefix: true)});");
            sbMethod.AppendLine("else");
            sbMethod.AppendLine("return null;");
            sbMethod.AppendLine("\n}");
            return sbMethod.ToString();
        }
        public static string Class_SaveMethod(string TableSinglName)
        {
            StringBuilder sbMethod = new StringBuilder();
            sbMethod.AppendLine($"        public bool Save()\r\n        {{\r\n            \r\n\r\n            switch  (Mode)\r\n            {{\r\n                case enMode.AddNew:\r\n                    if (_AddNew{TableSinglName}())\r\n                    {{\r\n\r\n                        Mode = enMode.Update;\r\n                        return true;\r\n                    }}\r\n                    else\r\n                    {{\r\n                        return false;\r\n                    }}\r\n\r\n                case enMode.Update:\r\n\r\n                    return _Update{TableSinglName}();\r\n\r\n            }}\r\n\r\n\r\n\r\n\r\n            return false;\r\n        }}");
            return sbMethod.ToString();
        }
        public static string Class_GetAllStatic(string TableName, List<clsColumn> ColumnsList)
        {
            StringBuilder sbMethod = new StringBuilder();

            sbMethod.AppendLine($"public static DataTable GetAll{TableName}(){{return cls{TableName}DataAccess.GetAll{TableName}();}}");

            return sbMethod.ToString();
        }
        public static string Class_DeleteStatic(string TableName, string TableSinglName, List<clsColumn> ColumnsList)
        {
            clsColumn PkColumn = clsColumn.GetPrimaryKeyColumn(ColumnsList);
            StringBuilder sbMethod = new StringBuilder();

            sbMethod.AppendLine($"public static bool Delete{TableSinglName}({PkColumn.ColumnDataType} {PkColumn.ColumnName}){{return  cls{TableName}DataAccess.Delete{TableSinglName}({PkColumn.ColumnName});}}");

            return sbMethod.ToString();
        }
        public static string Class_IsExistStatic(string TableName, string TableSinglName, List<clsColumn> ColumnsList)
        {
            clsColumn PkColumn = clsColumn.GetPrimaryKeyColumn(ColumnsList);
            StringBuilder sbMethod = new StringBuilder();

            sbMethod.AppendLine($"public static bool is{TableSinglName}Exist({PkColumn.ColumnDataType} {PkColumn.ColumnName}){{return cls{TableName}DataAccess.Is{TableSinglName}Exist({PkColumn.ColumnName});}}");

            return sbMethod.ToString();
        }
        public static string Class_PrivateAddNewMethid(string TableName, string TableSinglName, List<clsColumn> Columns)
        {
            clsColumn PkColumn = clsColumn.GetPrimaryKeyColumn(Columns);
            StringBuilder sbMethod = new StringBuilder();

            sbMethod.AppendLine($"private bool _AddNew{TableSinglName}()");
            sbMethod.AppendLine("{");
            sbMethod.AppendLine($"{_CallDataAccessCommand}\n");
            sbMethod.Append($"this.{PkColumn.ColumnName} = cls{TableName}DataAccess.AddNew{TableSinglName}(");
            sbMethod.Append(clsGenerateDataLayer._GetFunctionProperties(Columns, ClassFileds: true, ColumnToSkip: PkColumn));
            sbMethod.AppendLine(");");
            sbMethod.AppendLine($"\nreturn (this.{PkColumn.ColumnName} != -1);");
            sbMethod.AppendLine("\n}");


            return sbMethod.ToString();
        }
        public static string Class_PrivateUpdateMethid(string TableName, string TableSinglName, List<clsColumn> Columns)
        {
            StringBuilder sbMethod = new StringBuilder();

            sbMethod.AppendLine($"private bool _Update{TableSinglName}()");
            sbMethod.AppendLine("{");
            sbMethod.AppendLine($"{_CallDataAccessCommand}\n");
            sbMethod.Append($"return cls{TableName}DataAccess.Update{TableSinglName}(");
            sbMethod.Append(clsGenerateDataLayer._GetFunctionProperties(Columns, ClassFileds: true));
            sbMethod.AppendLine(");");
            sbMethod.AppendLine("\n}");


            return sbMethod.ToString();
        }
        public static string Class_PrivateConstractor(string TableSinglName, List<clsColumn> Columns)
        {
            StringBuilder sbConstractor = new StringBuilder();

            sbConstractor.AppendLine($"private cls{TableSinglName}({clsGenerateDataLayer._GetFunctionProperties(Columns)})");
            sbConstractor.AppendLine("{");
            sbConstractor.AppendLine(_FillClassFileds(Columns));
            sbConstractor.AppendLine("\nMode = enMode.Update;");
            sbConstractor.AppendLine("\n}");


            return sbConstractor.ToString();
        }
        public static string Class_PublicConstractor(string TableSinglName, List<clsColumn> Columns)
        {
            StringBuilder sbConstractor = new StringBuilder();
            sbConstractor.AppendLine($"public cls{TableSinglName}()");
            sbConstractor.AppendLine("{");
            sbConstractor.AppendLine(_DefualtFiledsValues(Columns));
            sbConstractor.AppendLine("\nMode = enMode.AddNew;");
            sbConstractor.AppendLine("\n}");


            return sbConstractor.ToString();
        }
        public static string Class_Fileds(List<clsColumn> Columnslist)
        {
            StringBuilder sbFileds = new StringBuilder();
            sbFileds.AppendLine("public enum enMode { AddNew = 0, Update = 1 };");
            sbFileds.AppendLine("public enMode Mode = enMode.AddNew;");
            sbFileds.AppendLine(_ColumnsFileds(Columnslist));

            return sbFileds.ToString();
        }

        public static string Generate(string TableName, string TableSinglName, List<clsColumn> Columns)
        {
            StringBuilder sbBusinessLayer = new StringBuilder();

            sbBusinessLayer.AppendLine($"using System;\nusing System.Data;\nusing {TableName}DataAccessLayer;");
            sbBusinessLayer.AppendLine($"namespace {TableName}BusinessLayer\n{{\n");
            sbBusinessLayer.AppendLine($"public class cls{TableSinglName}\n{{");

            sbBusinessLayer.AppendLine(Class_Fileds(Columns));
            sbBusinessLayer.AppendLine(Class_PublicConstractor(TableSinglName, Columns));
            sbBusinessLayer.AppendLine(Class_PrivateConstractor(TableSinglName, Columns));
            sbBusinessLayer.AppendLine(Class_PrivateAddNewMethid(TableName, TableSinglName, Columns));
            sbBusinessLayer.AppendLine(Class_PrivateUpdateMethid(TableName, TableSinglName, Columns));
            sbBusinessLayer.AppendLine(Class_FindStatic(TableName, TableSinglName, Columns));
            sbBusinessLayer.AppendLine(Class_SaveMethod(TableSinglName));
            sbBusinessLayer.AppendLine(Class_GetAllStatic(TableName, Columns));
            sbBusinessLayer.AppendLine(Class_DeleteStatic(TableName, TableSinglName, Columns));
            sbBusinessLayer.AppendLine(Class_IsExistStatic(TableName, TableSinglName, Columns));


            sbBusinessLayer.AppendLine("\n}");
            sbBusinessLayer.Append("\n}");

            return sbBusinessLayer.ToString();
        }
    }
}
