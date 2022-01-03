using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;
using System.Data.SqlClient;
//using System.Data;

namespace SQLServerWrapper
{
    public partial class SetConnection : Form
    {
        public string ConnectionString { get; set; }
        private static Logger _logger = LogManager.GetCurrentClassLogger();

        public SetConnection()
        {
            InitializeComponent();
        }

        private void SetConnection_Load(object sender, EventArgs e)
        {
            txtConnectionString.Text = "Server=(local);Initial Catalog=IVPPolaris;Integrated Security=true;Application Name=ExcelAddin";
            btnSetConnection.Enabled = false;
            btnTestConnection.Enabled = true;
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(txtConnectionString.Text);
                sqlConnection.Open();
                btnSetConnection.Enabled = true;
            }
            catch (Exception ex)
            {
                _logger.Fatal(ex);
            }
        }

        private void btnSetConnection_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectionString = txtConnectionString.Text;
                this.Hide();
            }
            catch (Exception ex)
            {
                _logger.Fatal(ex);
            }
        }
    }
}
