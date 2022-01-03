using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using NLog;

namespace SQLServerWrapper
{
    public partial class SQLServer
    {

        public string ConnectionString { get; set; }
        public string SQLQuery { get; set; }
        private SetConnection setConnection = null;
        private static Logger _logger = LogManager.GetCurrentClassLogger();

        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            try
            {
                setConnection = new SetConnection();
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
                setConnection.Show();
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
    }
}
