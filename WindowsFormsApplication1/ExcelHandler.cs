using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;

namespace WindowsFormsApplication1
{
    public class ExcelHandler
    {
       
        public void Export2Excel(DataTable dt)
        {
            Microsoft.Office.Interop.Excel.Application excel = null;
            Microsoft.Office.Interop.Excel.Workbook wb = null;

            Microsoft.Office.Interop.Excel.Worksheet ws = null;

            try
            {
                excel = new Microsoft.Office.Interop.Excel.Application();
                wb = excel.Workbooks.Add();
                ws = (Microsoft.Office.Interop.Excel.Worksheet) wb.ActiveSheet;

                for (int idx = 0; idx < dt.Columns.Count; idx++)
                {
                    ws.Range["A1"].Offset[0, idx].Value = dt.Columns[idx].ColumnName;
                }

                for (int idx = 0; idx < dt.Rows.Count; idx++)
                {
                    // <small>hey! I did not invent this line of code, 
                    // I found it somewhere on CodeProject.</small> 
                    // <small>It works to add the whole row at once, pretty cool huh?</small>
                    ws.Range["A2"].Offset[idx].Resize[1, dt.Columns.Count].Value =
                        dt.Rows[idx].ItemArray;
                }

                excel.Visible = true;
                wb.Activate();
            }
            catch (COMException ex)
            {
                MessageBox.Show("Error accessing Excel: " + ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
    }
}


