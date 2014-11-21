using System.Data;
using System.Xml;

namespace WindowsFormsApplication1
{
    class XmlHelper
    {
        public DataTable XmlStringToDataTable(string Xmlstring)
        {

            //新建XML文件類別
            XmlDocument Xmldoc = new XmlDocument();
            //從指定的字串載入XML文件
            Xmldoc.LoadXml(Xmlstring);
            //建立此物件，並輸入透過StringReader讀取Xmldoc中的Xmldoc字串輸出
            XmlReader Xmlreader = XmlReader.Create(new System.IO.StringReader(Xmldoc.OuterXml));
            //建立DataSet
            DataSet ds = new DataSet();
            //透過DataSet的ReadXml方法來讀取Xmlreader資料
            ds.ReadXml(Xmlreader);
            //建立DataTable並將DataSet中的第0個Table資料給DataTable
            DataTable dt = ds.Tables[0];
            //回傳DataTable
            return dt;
        }
    }
}
