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
    }
}
