using System.Collections.Generic;

namespace Generator
{
    public class clsColumn
    {
        public string ColumnName { get; set; }
        public string ColumnDataType { get; set; }
        public bool AllowNull { get; set; }
        public bool IsPK { get; set; }
        public clsColumn(string ColumnName, string ColumnDataType, bool AllowNull = false, bool IsPK = false)
        {
            this.ColumnName = ColumnName;
            this.ColumnDataType = ColumnDataType;
            this.AllowNull = AllowNull;
            this.IsPK = IsPK;
        }


        public static clsColumn GetPrimaryKeyColumn(List<clsColumn> Columnslist)
        {
            foreach (clsColumn Column in Columnslist)
            {
                if (Column.IsPK)
                    return Column;
            }

            return null;
        }

        public static clsColumn Find(List<clsColumn> Columnslist, string ColumnName)
        {
            foreach (clsColumn Column in Columnslist)
            {
                if(Column.ColumnName == ColumnName)
                    return Column;
            }

            return null;
        }
        public static bool SetRemovePKColumn(List<clsColumn> Columnslist, string ColumnName, bool SetPK = true)
        {
            clsColumn PKColumn = Find(Columnslist, ColumnName);
            if (PKColumn != null)
            {
                PKColumn.IsPK = SetPK;
                return true;
            }

            return false;
        }
    }
}
