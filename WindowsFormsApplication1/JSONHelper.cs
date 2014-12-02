using System.Collections.Generic;
using System.Data;

namespace WindowsFormsApplication1
{
    class JsonHelper
    {
        public string ToJSON(DataTable dataTable)
        {
            string result = "[";

            foreach (DataRow row in dataTable.Rows)
            {
                string s = string.Empty;

                for (int i = 0; i < row.ItemArray.Length; i++) // "xxx":"yyy", "ttt","ggg"
                {
                    s += string.Format("\"{0}\":\"{1}\"", dataTable.Columns[i].ColumnName,row[i]);
                    if (i!=row.ItemArray.Length-1)
                    {
                        s+=",";
                    }
                }
                string jsonObjectString = string.Format("{{ {0} }},",s);

                result += jsonObjectString;
            }

            result = result.TrimEnd(',')+ "]";
            return result;
        }


    }
}
