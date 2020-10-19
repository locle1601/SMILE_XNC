using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;
using OfficeOpenXml;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using System.Xml;
using System.Xml.Serialization;
using DataTable = System.Data.DataTable;
using System.Text.RegularExpressions;

namespace SMILE_XNC
{
    public partial class FMain : Form
    {

        System.Data.DataTable table = new System.Data.DataTable("tbl");
        public FMain()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        //private Stream fileName;
        DataSet ds = new DataSet();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FMain_Load(object sender, EventArgs e)
        {

            string constring = ConfigurationManager.ConnectionStrings["SMILE"].ConnectionString.ToString();
            conn = new SqlConnection(constring);
            conn.Open();
            Dictionary<int, string> guestDic = new Dictionary<int, string>();
            guestDic.Add(0, "ALL");
            guestDic.Add(1, "Viet Nam");
            guestDic.Add(2, "Foreigner");

            Dictionary<string, string> typeDic = new Dictionary<string, string>();
            typeDic.Add("SpTamTru", "Khai Báo Tạm Trú");
            typeDic.Add("SpXNC", "Xuất nhập cảnh");

            cbGuest.DataSource = new BindingSource(guestDic, null);
            cbGuest.DisplayMember = "value";
            cbGuest.ValueMember = "key";

            comboBox1.DataSource = new BindingSource(typeDic, null);
            comboBox1.DisplayMember = "value";
            comboBox1.ValueMember = "key";
            spTamTru();

            dataGridViewSML.DataSource = table;

        }
        private void FMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }
        ////public void loadxml()
        ////{
        ////    SqlCommand cmd = new SqlCommand("select * FROM [table]", conn);
        ////    SqlDataAdapter da = new SqlDataAdapter(cmd);
        ////    System.Data.DataTable dt = new System.Data.DataTable();
        ////    dt.TableName = "Records";
        ////    da.Fill(dt);
        ////    DataSet dS = new DataSet();
        ////    dS.DataSetName = "RecordSet";
        ////    dS.Tables.Add(dt);
        ////    StringWriter sw = new StringWriter();
        ////    dS.WriteXml(sw, XmlWriteMode.IgnoreSchema);
        ////    string s = sw.ToString();
        ////    string attachment = "attachment; filename=test.xml";
        ////    Response.ClearContent();
        ////    Response.ContentType = "application/xml";
        ////    Response.AddHeader("content-disposition", attachment);
        ////    Response.Write(s);
        ////    Response.End();
        //}
        public void spTamTru()
        {
            String SQLspTamTru = "spXMLTHUE";
            SqlCommand cmd = new SqlCommand(SQLspTamTru, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@FDate", dateFDate.Value.Date));
            cmd.Parameters.Add(new SqlParameter("@TDate", DateToD.Value.Date));
            var idguest = (cbGuest.SelectedItem as dynamic).Key;
            cmd.Parameters.Add(new SqlParameter("@Foreigner", idguest));
            SqlDataReader dr = cmd.ExecuteReader();
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Load(dr);
            dataGridViewSML.DataSource = dt;

        }
        public void spXNC()
        {
            String SQLspTamTru = "spXML";
            SqlCommand cmd = new SqlCommand(SQLspTamTru, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@sDate", dateFDate.Value.Date));
            //cmd.Parameters.Add(new SqlParameter("@TDate", DateToD.Value.Date));
            //var idguest = (cbGuest.SelectedItem as dynamic).Key;
            //cmd.Parameters.Add(new SqlParameter("@Foreigner", idguest));
            SqlDataReader dr = cmd.ExecuteReader();
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Load(dr);
            dataGridViewSML.DataSource = dt;

        }


        private void btloaddata_Click(object sender, EventArgs e)
        {


            KeyValuePair<string, string> selectedEntry = (KeyValuePair<string, string>)comboBox1.SelectedItem;

            // var selectCombobo = (comboBox1.SelectedItem as dynamic).Key;
            if (selectedEntry.Key == "SpTamTru")
            {
                spTamTru();


            }
            else if (selectedEntry.Key == "SpXNC")
            {
                spXNC();
            }



        }



        //private void copyAlltoClipboard()
        //{

        //   dataGridViewSML.RowHeadersVisible = false;
        //   dataGridViewSML.SelectAll();
        //   DataObject dataObj = dataGridViewSML.GetClipboardContent();
        //  if (dataObj != null)
        //      Clipboard.SetDataObject(dataObj);
        //}


        private void btExcel_Click(object sender, EventArgs e)

        {

            saveFileDialog1.InitialDirectory = "C:";
            saveFileDialog1.Title = "Save as Excel File";
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "Excel Documents(*.xls) | *.xls";
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {



                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

                app.Visible = true;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                for (int i = 1; i < dataGridViewSML.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dataGridViewSML.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dataGridViewSML.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridViewSML.Columns.Count; j++)
                    {
                        if (dataGridViewSML.Rows[i].Cells[j].Value != null)
                        {
                            worksheet.Cells[i + 2, j + 1] = dataGridViewSML.Rows[i].Cells[j].Value.ToString();
                        }
                        else
                        {
                            worksheet.Cells[i + 2, j + 1] = "";
                            // worksheet.Cells[i + 2, j + 1] = AutoSize;
                        }
                    }

                }
                //copyAlltoClipboard();
                worksheet.Columns.ColumnWidth = 20;
                //worksheet.Columns.FillRight();
                app.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName.ToString());
                app.ActiveWorkbook.Saved = true;
                //app.Quit();
                MessageBox.Show("Sucsecful!");

            }
            else { MessageBox.Show("Fail!"); }



        }





        private void cbGuest_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void saveFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }



        private void btSaveXML_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = "C:";
            saveFileDialog1.Title = "Save as .XML File";
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "XML file(*.xml)|*.xml";
            saveFileDialog1.RestoreDirectory = true;


            //SaveFileDialog dlg = new SaveFileDialog();
            //dlg.Filter = "XML Files (*.xml)|*.xml";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)

            //SaveFileDialog sfd = new SaveFileDialog();
            //sfd.Filter = "XML file(*.xml)|*.xml";
            //sfd.FileName = "";
            //sfd.RestoreDirectory = true;
            //if (sfd.ShowDialog() == DialogResult.OK)
            {
                DataTable dt = new DataTable();
                dt.TableName = "THONG_TIN_KHACH";
                
                for (int i = 0; i < dataGridViewSML.Columns.Count; i++)
                {
                    if (dataGridViewSML.Columns[i].Visible) // Add's only Visible columns (if you need it)
                    {
                        string headerText = dataGridViewSML.Columns[i].HeaderText;
                       headerText = Regex.Replace(headerText, "[-/, ]", "_");

                       DataColumn column = new DataColumn(headerText);
                       dt.Columns.Add(column);
                   }
                }
                object[] cellvalue = new object[dataGridViewSML.Columns.Count];
                foreach (DataGridViewRow DataGVRow in dataGridViewSML.Rows)
                {
                    DataRow dataRow = dt.NewRow();
                    for (int i = 0; i < DataGVRow.Cells.Count; i++)
                    {
                        cellvalue[i] = DataGVRow.Cells[i].Value;
                       
                       
                    }
                    dt.Rows.Add(cellvalue);
                    //dt.Columns.Add();
                    //using (MemoryStream stream = new MemoryStream())

                    //using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8)) ;
                }
                DataSet ds = new DataSet();
                ds.DataSetName = "KHAI_BAO_TAM_TRU";
                ds.Tables.Add(dt);
               
                MessageBox.Show("Sucsecfull!");

                
                //XmlWriterSettings settings = new XmlWriterSettings();
                //settings.Indent = true;
                //settings.Encoding = Encoding.Unicode;

                //XmlDocument doc = new XmlDocument(); // construct your doc here
                //XmlWriterSettings settings = new XmlWriterSettings();
                //settings.Encoding = new UTF8Encoding(false);
                //XmlWriter writer = XmlWriter.Create(stream, settings);
                //doc.Save(writer);
                //XmlTextWriter writer = new XmlTextWriter(dlg.FileName, encoding);
                //writer.Formatting = Formatting.Indented;
                dt.WriteXml(saveFileDialog1.FileName, XmlWriteMode.WriteSchema,false);
               

            }
        }

       




    

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            KeyValuePair<string, string> selectedEntry = (KeyValuePair<string, string>)comboBox1.SelectedItem;

            // var selectCombobo = (comboBox1.SelectedItem as dynamic).Key;
            if (selectedEntry.Key == "SpTamTru")
            {
                DateToD.Visible = true;
                cbGuest.Visible = true;
                txtTDate.Visible = true;
                lbGuest.Visible = true;


            }
            else if (selectedEntry.Key == "SpXNC")
            {
                DateToD.Visible = false;
                cbGuest.Visible = false;
                txtTDate.Visible = false;
                lbGuest.Visible = false;
            }

        }
    }
}
       
        
    
        


