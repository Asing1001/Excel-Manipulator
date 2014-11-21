﻿using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using NPOI.SS.Util;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        XmlHelper xmlHelper = new XmlHelper();
        ExcelHandler excelHandler = new ExcelHandler();
        DataTable dtMine = new DataTable();
        DataTable dtTheir = new DataTable();
        DataTable dtCantMatch = new DataTable();
        DataTable mergeDataTable = new DataTable();
        FolderBrowserDialog dialog = new FolderBrowserDialog();

        public Form1()
        {
            InitializeComponent();
            textBox1.Text = Properties.Settings.Default.SQLCommand1;
            textBox2.Text = Properties.Settings.Default.SQLCommand2;
        }

        #region Openfile to Datagridview and datatable
        
        private string OpenFile()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show("gotit");
                //MessageBox.Show(openFileDialog1.FileName);
                return openFileDialog1.FileName;
            }

            return string.Empty;
        }

        private DataTable GetExcelSheetNames(string filePath)
        {
            //Office 2003
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath + ";Extended Properties='Excel 8.0;HDR=YES;IMEX=1'");

            //Office 2007
            //OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties='Excel 12.0 Xml;HDR=YES'");

            DataSet ds = new DataSet();
            conn.Open();
            DataTable dt = conn.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Tables, null);
            conn.Close();
            return dt;
        }

        private DataTable GetExcelDataTable(string filePath, string sql)
        {
            try
            {
                //Office 2003
                //OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath + ";Extended Properties='Excel 8.0;HDR=YES;IMEX=1;Readonly=0'");

                //Office 2007
                OleDbConnection conn =
                    new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath +
                                        ";Extended Properties='Excel 12.0 Xml;HDR=YES'");

                OleDbDataAdapter da = new OleDbDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dt.TableName = "tmp";
                conn.Close();
                return dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Please input correct SQL Command for your file!");
                return null;
            }
        }

        private void OpenXML_Click(object sender, EventArgs e)
        {
            var fileName = OpenFile();
        }

        private void OpenMine_Click(object sender, EventArgs e)
        {
            var fileName = OpenFile();
            if (fileName != string.Empty)
            {
                string tableName = "[Sheet1$]";//在頁簽名稱後加$，再用中括號[]包起來
                string sql = textBox1.Text +" "+ tableName; //SQL查詢
                dtMine = GetExcelDataTable(fileName, sql);
                //dtMine.Columns.Add("Comment");
                dataGridView1.DataSource = dtMine;
                DataCount_BeChanged.Text = "DataCount : "+ DataCount(dataGridView1);
            }
        }

        private void Excel_Theirs_Click(object sender, EventArgs e)
        {
            var fileName = OpenFile();
            if (fileName != string.Empty)
            {
                string tableName = "[Sheet1$]"; //在頁簽名稱後加$，再用中括號[]包起來
                //string sql = "select Keys,value from " + tableName; //SQL查詢
                string sql = textBox2.Text +" "+ tableName; //SQL查詢
                dtTheir = GetExcelDataTable(fileName, sql);
                dataGridView2.DataSource = dtTheir;
                DataCount_Correct.Text = "DataCount : " + DataCount(dataGridView2);
            }
        }

        #endregion

        private void Search(object sender, EventArgs e)
        {
            SearchInUse searchInUse = new SearchInUse();
            dtCantMatch = new DataTable();
            dtCantMatch.Columns.Add("keys");
            dtCantMatch.Columns.Add("value");
            dtCantMatch.Columns.Add("InUse");

            foreach (DataRow row in dtMine.Rows)
            {
                row["InUse"] = searchInUse.SearchSingleWordInDatas(row["keys"].ToString(),
                    sourceFolder: @"D:\Project\DEV\Mobile\src\AgileBet.Cash.Mobile.Website\");

                string key = "'" + row["Keys"] + "'"; //規定要加''
                DataRow[] matchRows = dtTheir.Select("Keys=" + key);
                if (matchRows.Length != 0)
                {
                    row["value"] = matchRows[0]["value"];
                }
                else
                {
                    dtCantMatch.ImportRow(row);
                }
                dataGridView1.DataSource = dtMine;
                dataGridView3.DataSource = dtCantMatch;

            }
        }
   
        private void RunProgram_Click(object sender, EventArgs e)
        {
            dtCantMatch = new DataTable();
            dtCantMatch.Columns.Add("keys");
            dtCantMatch.Columns.Add("japnese");
            dtCantMatch.Columns.Add("Comment");
  
            foreach (DataRow row in dtMine.Rows)
            {
                string key = "'" + row["Keys"] + "'"; //規定要加''
                DataRow[] matchRows = dtTheir.Select("Keys=" + key);
                if (matchRows.Length != 0)
                {
                    row["Comment"] = matchRows[0]["Comment"];
                    row["japanese"] = matchRows[0]["japanese"];
                }
                else
                {
                    dtCantMatch.ImportRow(row);
                }
                dataGridView1.DataSource = dtMine;
                dataGridView3.DataSource = dtCantMatch;
            }

            DataCount_CantMatch.Text = "DataCount : " + DataCount(dataGridView3);
        }

        private string DataCount(DataGridView dgv)
        {
            return dgv.RowCount.ToString();
        }

        private void merge_Click(object sender, EventArgs e)
        {
            mergeDataTable = dtTheir.Copy();
            int i = 0;
            foreach (DataRow row in dtMine.Rows)
            {
                string key = "'" + row["Keys"] + "'"; //規定要加''
                DataRow[] matchRows = mergeDataTable.Select("Keys=" + key);
                if (matchRows.Length == 0)
                {
                    mergeDataTable.ImportRow(row);
                    i++;
                }
            }
            dataGridView4.DataSource = mergeDataTable;
            MessageBox.Show("merge : " + i+" data.");
            DataCount_Merge.Text = "DataCount : "+ DataCount(dataGridView4);
        }

        #region Export2Excel

        private void ExportMerge_Click(object sender, EventArgs e)
        {
            excelHandler.Export2Excel(mergeDataTable);
        }
        
        private void ExportMine_Click(object sender, EventArgs e)
        {
            excelHandler.Export2Excel(dtMine);
        }

        private void ExportMissing_Click(object sender, EventArgs e)
        {
            excelHandler.Export2Excel(dtCantMatch);
        }

        #endregion

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.SQLCommand1 = textBox1.Text;
            Properties.Settings.Default.SQLCommand2 = textBox2.Text;
            Properties.Settings.Default.Save();
        }
    }
}
