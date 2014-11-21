using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class SearchInUse
    {
        //string sourceFolder = @"D:\Project\DEV\Mobile\src\AgileBet.Cash.Mobile.Website\views";
        private FolderBrowserDialog dialog = new FolderBrowserDialog();
        private List<string> allFiles = new List<string>();

        public string SearchSingleWordInDatas(string word, string sourceFolder)  
            //todo : 效能很差，這裡只適合搜尋單一字，傳入大量字應該改用每一頁查詢所有字。
        {
            sourceFolder = @"D:\Project\DEV\Mobile\src\AgileBet.Cash.Mobile.Website\";
            if (sourceFolder == String.Empty && dialog.ShowDialog() == DialogResult.OK)
            {
                sourceFolder = dialog.SelectedPath;
            }

            if (allFiles.Count == 0)
            {
                AddFileNamesToList(sourceFolder, allFiles);
            }

            foreach (string fileName in allFiles)
            {
                    var contents = File.ReadAllText(fileName);
                    if (contents.Contains(word))
                    {
                        return "Yes";
                    } 
                
            }
            return "No";
        }

        private static void AddFileNamesToList(string sourceDir, List<string> allFiles)
        {

            string[] fileEntries = Directory.GetFiles(sourceDir);
            foreach (string fileName in fileEntries)
            {
                if (fileName.EndsWith(".cs") || fileName.EndsWith(".cshtml") || fileName.EndsWith(".html")) //不搜尋resource
                {
                    if (fileName.IndexOf("App_GlobalResources") == -1 )
                    {
                        allFiles.Add(fileName);
                    }
                }
            }

            //Recursion    
            string[] subdirectoryEntries = Directory.GetDirectories(sourceDir);
            foreach (string item in subdirectoryEntries)
            {
                // Avoid "reparse points"
                if ((File.GetAttributes(item) & FileAttributes.ReparsePoint) != FileAttributes.ReparsePoint)
                {
                    AddFileNamesToList(item, allFiles);
                }
            }

        }
    }
}
