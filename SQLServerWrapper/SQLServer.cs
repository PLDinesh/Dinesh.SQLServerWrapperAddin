using Microsoft.Office.Tools.Ribbon;
using Microsoft.Office.Tools.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using NLog;
using System.Runtime.InteropServices;

namespace SQLServerWrapper
{
    public partial class SQLServer
    {

        public string ConnectionString { get; set; }
        private string _connectionString;
        public string SQLQuery
        {
            get
            {

                return _connectionString.Replace("GO", ";");
            }
            set
            {
                _connectionString = value;
            }
        }
        private SetConnection setConnection = null;
        private SetSQLQuery setSQLQuery = null;
        private static Logger _logger = LogManager.GetCurrentClassLogger();

        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            try
            {
                setConnection = new SetConnection();
                setSQLQuery = new SetSQLQuery();
            }
            catch (Exception ex)
            {
                _logger.Fatal(ex, "Error occured during initialization.");
                ShowMessage("Error occured during initialization.", "Error", System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        private void btnRefreshData_Click(object sender, RibbonControlEventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandText = SQLQuery;
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sqlDataAdapter.Fill(ds);
                int iCurrentSheet = 0;
                Excel.Application oXL;
                Excel.Workbook oWB;
                oXL = (Excel.Application)Globals.ThisAddIn.Application;
                oXL.Visible = true;
                oWB = (Excel.Workbook)oXL.ActiveWorkbook;

                Excel.Worksheet ActiveWorkSheet = Globals.ThisAddIn.Application.ActiveSheet;

                Excel.Worksheet activeWorksheet = oWB.Worksheets.Add();


                foreach (Excel.Worksheet sheet in oWB.Worksheets)
                {

                }

                Excel.Workbook workbook = oWB;
                //  Excel.Range firstRow = activeWorksheet.get_Range("A1");
                activeWorksheet.Select();

                //firstRow.EntireRow.Insert(Excel.XlInsertShiftDirection.xlShiftDown);
                Excel.Range newFirstRow = activeWorksheet.get_Range("A1");
                Object tmpValue = newFirstRow.Value2;
                newFirstRow.Value2 = "This text will be deleted once the operation is completed";

                foreach (DataTable dt in ds.Tables)
                {
                    //Worksheet oSheet = oWB.Worksheets.Add();
                    // newWorksheet.impo

                    Excel.Worksheet oSheet = oWB.Worksheets.Add();

                    object[,] rawData = new object[dt.Rows.Count + 1, dt.Columns.Count];
                    for (int col = 0; col < dt.Columns.Count; col++)
                    {
                        rawData[0, col] = dt.Columns[col].ColumnName;
                    }
                    for (int col = 0; col < dt.Columns.Count; col++)
                    {
                        for (int row = 0; row < dt.Rows.Count; row++)
                        {
                            rawData[row + 1, col] = dt.Rows[row].ItemArray[col].ToString();
                        }
                    }
                    string finalColLetter = string.Empty;
                    string colCharset = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    int colCharsetLen = colCharset.Length;

                    if (dt.Columns.Count > colCharsetLen)
                    {
                        finalColLetter = colCharset.Substring(
                            (dt.Columns.Count - 1) / colCharsetLen - 1, 1);
                    }

                    finalColLetter += colCharset.Substring(
                            (dt.Columns.Count - 1) % colCharsetLen, 1);

                    // Fast data export to Excel
                    string excelRange = string.Format("A1:{0}{1}",
                        finalColLetter, dt.Rows.Count + 1);

                    //oSheet.get_Range(excelRange, Type.Missing).Style.NumberFormat = "@";
                    oSheet.get_Range(excelRange, Type.Missing).Value2 = rawData;
                    Excel.Range oRange = oSheet.get_Range(excelRange, Type.Missing);
                    Excel.Style oStyle = (Excel.Style)oRange.Style;
                    oStyle.NumberFormat = "@";
                    Excel.Range oRng = oSheet.get_Range("A1", "IV1");
                    oRng.EntireColumn.AutoFit();
                    iCurrentSheet++;


                }

                newFirstRow.Value2 = "";
                newFirstRow.Value2 = tmpValue;
            }
            catch (Exception ex)
            {
                _logger.Fatal(ex, "Error occured when trying to refresh results.");
                ShowMessage("Error occured when trying to refresh results.", "Error", System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        private void btnSetConnectionString_Click(object sender, RibbonControlEventArgs e)
        {
            try
            {
                setConnection.ShowDialog();
                ConnectionString = setConnection.ConnectionString;
            }
            catch (Exception ex)
            {
                _logger.Fatal(ex, "Error occured when attempting to set connection string.");
                ShowMessage("Error occured when attempting to set connection string.", "Error", System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        private void ShowMessage(string Message, string Caption, System.Windows.Forms.MessageBoxIcon messageBoxIcon)
        {
            System.Windows.Forms.MessageBox.Show(Message, Caption, System.Windows.Forms.MessageBoxButtons.OK, messageBoxIcon);
        }

        private void btnSetQuery_Click(object sender, RibbonControlEventArgs e)
        {
            try
            {
                setSQLQuery.ShowDialog();
                SQLQuery = setSQLQuery.SQLQuery;
            }
            catch (Exception ex)
            {
                _logger.Fatal(ex, "Error occured when attempting to set connection string.");
                ShowMessage("Error occured when attempting to set connection string.", "Error", System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
    }
}
