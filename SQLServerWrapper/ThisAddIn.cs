using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;

namespace SQLServerWrapper
{
    public partial class ThisAddIn
    {
        public Excel.Application ExcelApplication
        {
            get
            {
                return this.Application;
            }
        }
        public Excel.Workbook ExcelWorkBook
        {
            get
            {
                return Application.ActiveWorkbook;
            }
        }

        private void SaveSettings(string ConnectionString,string SQLQuery)
        {
            try
            {
                Properties.Settings MySettings = new Properties.Settings();

                MySettings.ConnectionString = ConnectionString;
                MySettings.SQLQuery = SQLQuery;
                MySettings.Save();

            }
            catch (Exception ex)
            {
               
            }
        }
        private void LoadSettings()
        {
            //Load the settings here..
            try
            {
                Properties.Settings MySettings = new Properties.Settings();

                MySettings.Reload();
                //txtServerName.Text = MySettings.Server;
                //txtDatabaseName.Text = MySettings.Database;
                //rbnWindowsAuthentication.Checked = MySettings.IntegratedSecurity;
                //txtSQLUserID.Text = MySettings.SQLUserID;
                //txtSQLPassword.Text = MySettings.SQLPassword;
                //txtSQLQuery.Text = MySettings.SQLQuery;
                //textBox1.Text = MySettings.SheetNames;

            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            try
            {

            }catch(Exception ex)
            {

            }
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {

        }

        void Application_WorkbookBeforeSave(Microsoft.Office.Interop.Excel.Workbook Wb, bool SaveAsUI, ref bool Cancel)
        {
            Excel.Worksheet activeWorksheet = ((Excel.Worksheet)Application.ActiveSheet);
            Excel.Workbook workbook = Application.ActiveWorkbook;
            Excel.Range firstRow = activeWorksheet.get_Range("A1");
            //firstRow.EntireRow.Insert(Excel.XlInsertShiftDirection.xlShiftDown);
            //Excel.Range newFirstRow = activeWorksheet.get_Range("A1");
            //newFirstRow.Value2 = "This text was added by using code";
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
            this.Application.WorkbookBeforeSave += new Microsoft.Office.Interop.Excel.AppEvents_WorkbookBeforeSaveEventHandler(Application_WorkbookBeforeSave);
        }

        #endregion
    }
}
