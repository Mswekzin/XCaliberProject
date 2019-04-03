using System;
using System.Data;
using System.Windows.Forms;
using System.Xml;
using System.Data.SqlClient;

namespace WindowsApplication1
{
    public partial class InsertXMLdata : Form
    {
        public InsertXMLdata()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adpter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            XmlReader xmlFile;
            string sql = null;

            String ID = "";
            String Document = "MyDocument";
            String Cust_Name = null;
            String Address = null;
            String Profession = null;
            String Customer_FK = "0";

            connetionString = "Data Source=LINDANIMABASO\\LINDANIDB;Initial Catalog=LocalDB;Integrated Security=True";

            connection = new SqlConnection(connetionString);

            xmlFile = XmlReader.Create("C:/Users/Lindani Mabaso/source/repos/DBConvertXML/DBConvertXML/Customer_Sale.xml", new XmlReaderSettings());
            ds.ReadXml(xmlFile);
            int i = 0;
            connection.Open();
            for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
            {
                ID = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                Cust_Name = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                Address = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                Profession = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                sql = "insert into Customer_Table values(" + ID + ",'" + Document + "','" + Cust_Name + "','" + Address + "','" + Profession + "'," + Customer_FK + ")";
                command = new SqlCommand(sql, connection);
                adpter.InsertCommand = command;
                adpter.InsertCommand.ExecuteNonQuery();
            }
            connection.Close();
            System.Windows.MessageBox.Show("Data Exported Succesfully .. ");

        }
    
    }
}
