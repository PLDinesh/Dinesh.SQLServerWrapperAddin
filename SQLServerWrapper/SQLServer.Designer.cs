namespace SQLServerWrapper
{
    partial class SQLServer : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public SQLServer()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.grpSQLServer = this.Factory.CreateRibbonGroup();
            this.btnRefreshData = this.Factory.CreateRibbonButton();
            this.btnSetQuery = this.Factory.CreateRibbonButton();
            this.btnSetConnectionString = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.grpSQLServer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.grpSQLServer);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // grpSQLServer
            // 
            this.grpSQLServer.Items.Add(this.btnRefreshData);
            this.grpSQLServer.Items.Add(this.btnSetQuery);
            this.grpSQLServer.Items.Add(this.btnSetConnectionString);
            this.grpSQLServer.Label = "SQL Server Interface";
            this.grpSQLServer.Name = "grpSQLServer";
            // 
            // btnRefreshData
            // 
            this.btnRefreshData.Image = global::SQLServerWrapper.Properties.Resources.Refresh_grey_16x;
            this.btnRefreshData.Label = "Refresh Data";
            this.btnRefreshData.Name = "btnRefreshData";
            this.btnRefreshData.ShowImage = true;
            this.btnRefreshData.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnRefreshData_Click);
            // 
            // btnSetQuery
            // 
            this.btnSetQuery.Image = global::SQLServerWrapper.Properties.Resources.SetField_ActionGray_16x;
            this.btnSetQuery.Label = "Edit / Set Query";
            this.btnSetQuery.Name = "btnSetQuery";
            this.btnSetQuery.ShowImage = true;
            this.btnSetQuery.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnSetQuery_Click);
            // 
            // btnSetConnectionString
            // 
            this.btnSetConnectionString.Image = global::SQLServerWrapper.Properties.Resources.SetField_16x;
            this.btnSetConnectionString.Label = "Edit / Set Connection";
            this.btnSetConnectionString.Name = "btnSetConnectionString";
            this.btnSetConnectionString.ShowImage = true;
            this.btnSetConnectionString.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnSetConnectionString_Click);
            // 
            // SQLServer
            // 
            this.Name = "SQLServer";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.grpSQLServer.ResumeLayout(false);
            this.grpSQLServer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup grpSQLServer;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnRefreshData;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnSetQuery;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnSetConnectionString;
    }

    partial class ThisRibbonCollection
    {
        internal SQLServer Ribbon1
        {
            get { return this.GetRibbon<SQLServer>(); }
        }
    }
}
