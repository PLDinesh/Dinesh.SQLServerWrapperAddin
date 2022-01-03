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
    public partial class SetSQLQuery : Form
    {
        public SetSQLQuery()
        {
            InitializeComponent();
        }
        public string SQLQuery { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            SQLQuery = textBox1.Text.Trim();
            this.Hide();
        }
    }
}
