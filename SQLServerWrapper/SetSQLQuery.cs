using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLServerWrapper
{
    /// <summary>
    /// 
    /// </summary>
    public partial class SetSQLQuery : Form
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();
        /// <summary>
        /// 
        /// </summary>
        public SetSQLQuery()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This public propery will hold the SQL query that will need to be parsed and executed
        /// </summary>
        public string SQLQuery { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            SQLQuery = textBox1.Text.Trim();
            this.Hide();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetSQLQuery_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnParseSQL_Click(object sender, EventArgs e)
        {

        }
    }
}
