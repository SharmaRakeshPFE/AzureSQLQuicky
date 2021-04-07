namespace AzureProject
{
    partial class form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblserver = new System.Windows.Forms.Label();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.lbluser = new System.Windows.Forms.Label();
            this.txtpawd = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.dgvDatabases = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvfirewall = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvSession = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dgvconnections = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvtopsql = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.DgTblSize = new System.Windows.Forms.DataGridView();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.dgstats = new System.Windows.Forms.DataGridView();
            this.DgvRUsage = new System.Windows.Forms.DataGridView();
            this.Dbcombo = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblsize = new System.Windows.Forms.Label();
            this.Pbar = new System.Windows.Forms.ProgressBar();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tabControl1.SuspendLayout();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatabases)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfirewall)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSession)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvconnections)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtopsql)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgTblSize)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgstats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRUsage)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1182, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Analyze Database";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1484, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblserver
            // 
            this.lblserver.AutoSize = true;
            this.lblserver.Location = new System.Drawing.Point(15, 20);
            this.lblserver.Name = "lblserver";
            this.lblserver.Size = new System.Drawing.Size(339, 29);
            this.lblserver.TabIndex = 3;
            this.lblserver.Text = "Enter Azure SQL Server Name";
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(384, 20);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(500, 35);
            this.txtServerName.TabIndex = 4;
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(384, 88);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(500, 35);
            this.txtuser.TabIndex = 8;
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Location = new System.Drawing.Point(15, 88);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(252, 29);
            this.lbluser.TabIndex = 7;
            this.lbluser.Text = "Enter SQL User Name";
            // 
            // txtpawd
            // 
            this.txtpawd.Location = new System.Drawing.Point(384, 161);
            this.txtpawd.Name = "txtpawd";
            this.txtpawd.PasswordChar = '*';
            this.txtpawd.Size = new System.Drawing.Size(500, 35);
            this.txtpawd.TabIndex = 10;
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(15, 151);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(183, 29);
            this.lblpassword.TabIndex = 9;
            this.lblpassword.Text = "Enter Password";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Location = new System.Drawing.Point(20, 370);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1620, 917);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.dgvDatabases);
            this.tabPage8.Location = new System.Drawing.Point(10, 47);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(1600, 860);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Databases";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // dgvDatabases
            // 
            this.dgvDatabases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatabases.Location = new System.Drawing.Point(6, 6);
            this.dgvDatabases.Name = "dgvDatabases";
            this.dgvDatabases.RowTemplate.Height = 25;
            this.dgvDatabases.Size = new System.Drawing.Size(1588, 848);
            this.dgvDatabases.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvfirewall);
            this.tabPage3.Location = new System.Drawing.Point(10, 47);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1600, 860);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "FireWall Rules";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvfirewall
            // 
            this.dgvfirewall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfirewall.Location = new System.Drawing.Point(3, 3);
            this.dgvfirewall.Name = "dgvfirewall";
            this.dgvfirewall.RowTemplate.Height = 25;
            this.dgvfirewall.Size = new System.Drawing.Size(1594, 854);
            this.dgvfirewall.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgvSession);
            this.tabPage4.Location = new System.Drawing.Point(10, 47);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1600, 860);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Sessions";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvSession
            // 
            this.dgvSession.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSession.Location = new System.Drawing.Point(3, 3);
            this.dgvSession.Name = "dgvSession";
            this.dgvSession.RowTemplate.Height = 25;
            this.dgvSession.Size = new System.Drawing.Size(1594, 854);
            this.dgvSession.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dgvconnections);
            this.tabPage5.Location = new System.Drawing.Point(10, 47);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1600, 860);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Connections";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dgvconnections
            // 
            this.dgvconnections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvconnections.Location = new System.Drawing.Point(3, 3);
            this.dgvconnections.Name = "dgvconnections";
            this.dgvconnections.RowTemplate.Height = 25;
            this.dgvconnections.Size = new System.Drawing.Size(1594, 854);
            this.dgvconnections.TabIndex = 0;
            this.dgvconnections.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv);
            this.tabPage1.Location = new System.Drawing.Point(10, 47);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1600, 860);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Event Logs";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgv
            // 
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(6, 6);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 25;
            this.dgv.Size = new System.Drawing.Size(1579, 848);
            this.dgv.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvtopsql);
            this.tabPage2.Location = new System.Drawing.Point(10, 47);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1600, 860);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Top 15 CPU -Past";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvtopsql
            // 
            this.dgvtopsql.AllowUserToOrderColumns = true;
            this.dgvtopsql.AllowUserToResizeColumns = false;
            this.dgvtopsql.AllowUserToResizeRows = false;
            this.dgvtopsql.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtopsql.Location = new System.Drawing.Point(6, 7);
            this.dgvtopsql.Name = "dgvtopsql";
            this.dgvtopsql.RowTemplate.Height = 25;
            this.dgvtopsql.Size = new System.Drawing.Size(1579, 847);
            this.dgvtopsql.TabIndex = 14;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.DgTblSize);
            this.tabPage6.Location = new System.Drawing.Point(10, 47);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1600, 860);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Table_Size";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // DgTblSize
            // 
            this.DgTblSize.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgTblSize.Location = new System.Drawing.Point(3, 3);
            this.DgTblSize.Name = "DgTblSize";
            this.DgTblSize.RowTemplate.Height = 25;
            this.DgTblSize.Size = new System.Drawing.Size(1594, 854);
            this.DgTblSize.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.dgstats);
            this.tabPage7.Controls.Add(this.DgvRUsage);
            this.tabPage7.Location = new System.Drawing.Point(10, 47);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(1600, 860);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Resource Usage";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // dgstats
            // 
            this.dgstats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgstats.Location = new System.Drawing.Point(3, 341);
            this.dgstats.Name = "dgstats";
            this.dgstats.RowTemplate.Height = 25;
            this.dgstats.Size = new System.Drawing.Size(1594, 516);
            this.dgstats.TabIndex = 1;
            // 
            // DgvRUsage
            // 
            this.DgvRUsage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRUsage.Location = new System.Drawing.Point(3, 3);
            this.DgvRUsage.Name = "DgvRUsage";
            this.DgvRUsage.RowTemplate.Height = 25;
            this.DgvRUsage.Size = new System.Drawing.Size(1594, 307);
            this.DgvRUsage.TabIndex = 0;
            // 
            // Dbcombo
            // 
            this.Dbcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Dbcombo.FormattingEnabled = true;
            this.Dbcombo.Location = new System.Drawing.Point(384, 232);
            this.Dbcombo.Name = "Dbcombo";
            this.Dbcombo.Size = new System.Drawing.Size(759, 37);
            this.Dbcombo.TabIndex = 15;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1182, 154);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(269, 48);
            this.button3.TabIndex = 16;
            this.button3.Text = "Connect and List DB";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Select Database";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "Size of Selected DB";
            // 
            // lblsize
            // 
            this.lblsize.AutoSize = true;
            this.lblsize.Location = new System.Drawing.Point(379, 313);
            this.lblsize.Name = "lblsize";
            this.lblsize.Size = new System.Drawing.Size(19, 29);
            this.lblsize.TabIndex = 19;
            this.lblsize.Text = ".";
            // 
            // Pbar
            // 
            this.Pbar.Location = new System.Drawing.Point(782, 300);
            this.Pbar.Name = "Pbar";
            this.Pbar.Size = new System.Drawing.Size(845, 42);
            this.Pbar.TabIndex = 1;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 1299);
            this.splitter1.TabIndex = 21;
            this.splitter1.TabStop = false;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1654, 1299);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.Pbar);
            this.Controls.Add(this.lblsize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Dbcombo);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtpawd);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.txtServerName);
            this.Controls.Add(this.lblserver);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form1";
            this.Text = "SQL Azure Stats Quick Review                   Developed by Azure -Data & AI - Ra" +
    "kesh Sharma";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatabases)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvfirewall)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSession)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvconnections)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtopsql)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgTblSize)).EndInit();
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgstats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRUsage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblserver;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.TextBox txtpawd;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvtopsql;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvfirewall;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dgvSession;
        private System.Windows.Forms.DataGridView dgvconnections;
        private System.Windows.Forms.ComboBox Dbcombo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblsize;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView DgTblSize;
        private System.Windows.Forms.ProgressBar Pbar;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.DataGridView DgvRUsage;
        private System.Windows.Forms.DataGridView dgstats;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.DataGridView dgvDatabases;
    }
}

