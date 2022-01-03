namespace SQLServerWrapper
{
    partial class SetSQLQuery
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnParseSQL = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSetSQL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnParseSQL
            // 
            this.btnParseSQL.Location = new System.Drawing.Point(87, 277);
            this.btnParseSQL.Name = "btnParseSQL";
            this.btnParseSQL.Size = new System.Drawing.Size(75, 23);
            this.btnParseSQL.TabIndex = 0;
            this.btnParseSQL.Text = "Parse SQL";
            this.btnParseSQL.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-1, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(613, 269);
            this.textBox1.TabIndex = 1;
            // 
            // btnSetSQL
            // 
            this.btnSetSQL.Location = new System.Drawing.Point(329, 277);
            this.btnSetSQL.Name = "btnSetSQL";
            this.btnSetSQL.Size = new System.Drawing.Size(75, 23);
            this.btnSetSQL.TabIndex = 0;
            this.btnSetSQL.Text = "Set SQL";
            this.btnSetSQL.UseVisualStyleBackColor = true;
            this.btnSetSQL.Click += new System.EventHandler(this.button1_Click);
            // 
            // SetSQLQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 312);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSetSQL);
            this.Controls.Add(this.btnParseSQL);
            this.Name = "SetSQLQuery";
            this.Text = "SetSQLQuery";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnParseSQL;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSetSQL;
    }
}