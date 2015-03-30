using System.Security.AccessControl;

namespace HTK_Support_Tool
{
    partial class MainGui
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuStartenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aktionenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.überToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.lblFqdn = new System.Windows.Forms.Label();
            this.lblFqdn_lbl = new System.Windows.Forms.Label();
            this.lblComputerIP = new System.Windows.Forms.Label();
            this.lblComputerIP_lbl = new System.Windows.Forms.Label();
            this.lblDomain = new System.Windows.Forms.Label();
            this.lblDomain_lbl = new System.Windows.Forms.Label();
            this.lblComputername = new System.Windows.Forms.Label();
            this.lblComputername_lbl = new System.Windows.Forms.Label();
            this.tabOfficeLine = new System.Windows.Forms.TabPage();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.cbOLInstalled = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabInfo.SuspendLayout();
            this.tabOfficeLine.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.aktionenToolStripMenuItem,
            this.hilfeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(755, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuStartenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // neuStartenToolStripMenuItem
            // 
            this.neuStartenToolStripMenuItem.Name = "neuStartenToolStripMenuItem";
            this.neuStartenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.neuStartenToolStripMenuItem.Text = "Neu starten";
            this.neuStartenToolStripMenuItem.Click += new System.EventHandler(this.neuStartenToolStripMenuItem_Click);
            // 
            // aktionenToolStripMenuItem
            // 
            this.aktionenToolStripMenuItem.Name = "aktionenToolStripMenuItem";
            this.aktionenToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.aktionenToolStripMenuItem.Text = "Aktionen";
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.überToolStripMenuItem});
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.hilfeToolStripMenuItem.Text = "Hilfe";
            // 
            // überToolStripMenuItem
            // 
            this.überToolStripMenuItem.Name = "überToolStripMenuItem";
            this.überToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.überToolStripMenuItem.Text = "Über";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabInfo);
            this.tabControl1.Controls.Add(this.tabOfficeLine);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(755, 398);
            this.tabControl1.TabIndex = 1;
            // 
            // tabInfo
            // 
            this.tabInfo.Controls.Add(this.lblFqdn);
            this.tabInfo.Controls.Add(this.lblFqdn_lbl);
            this.tabInfo.Controls.Add(this.lblComputerIP);
            this.tabInfo.Controls.Add(this.lblComputerIP_lbl);
            this.tabInfo.Controls.Add(this.lblDomain);
            this.tabInfo.Controls.Add(this.lblDomain_lbl);
            this.tabInfo.Controls.Add(this.lblComputername);
            this.tabInfo.Controls.Add(this.lblComputername_lbl);
            this.tabInfo.Location = new System.Drawing.Point(4, 22);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabInfo.Size = new System.Drawing.Size(747, 372);
            this.tabInfo.TabIndex = 0;
            this.tabInfo.Text = "Info";
            this.tabInfo.UseVisualStyleBackColor = true;
            // 
            // lblFqdn
            // 
            this.lblFqdn.AutoSize = true;
            this.lblFqdn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFqdn.Location = new System.Drawing.Point(95, 55);
            this.lblFqdn.Name = "lblFqdn";
            this.lblFqdn.Size = new System.Drawing.Size(206, 13);
            this.lblFqdn.TabIndex = 8;
            this.lblFqdn.Text = "FULLY QUALIFIED DOMAIN NAME";
            this.lblFqdn.Click += new System.EventHandler(this.lblFqdn_Click);
            this.lblFqdn.DoubleClick += new System.EventHandler(this.lblFqdn_DoubleClick);
            // 
            // lblFqdn_lbl
            // 
            this.lblFqdn_lbl.AutoSize = true;
            this.lblFqdn_lbl.Location = new System.Drawing.Point(8, 55);
            this.lblFqdn_lbl.Name = "lblFqdn_lbl";
            this.lblFqdn_lbl.Size = new System.Drawing.Size(40, 13);
            this.lblFqdn_lbl.TabIndex = 7;
            this.lblFqdn_lbl.Text = "FQDN:";
            // 
            // lblComputerIP
            // 
            this.lblComputerIP.AutoSize = true;
            this.lblComputerIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerIP.Location = new System.Drawing.Point(95, 75);
            this.lblComputerIP.Name = "lblComputerIP";
            this.lblComputerIP.Size = new System.Drawing.Size(100, 13);
            this.lblComputerIP.TabIndex = 6;
            this.lblComputerIP.Text = "COM.PUT.ER.IP";
            this.lblComputerIP.Click += new System.EventHandler(this.lblComputerIP_Click);
            this.lblComputerIP.DoubleClick += new System.EventHandler(this.lblComputerIP_DoubleClick);
            // 
            // lblComputerIP_lbl
            // 
            this.lblComputerIP_lbl.AutoSize = true;
            this.lblComputerIP_lbl.Location = new System.Drawing.Point(8, 75);
            this.lblComputerIP_lbl.Name = "lblComputerIP_lbl";
            this.lblComputerIP_lbl.Size = new System.Drawing.Size(61, 13);
            this.lblComputerIP_lbl.TabIndex = 5;
            this.lblComputerIP_lbl.Text = "IP Adresse:";
            // 
            // lblDomain
            // 
            this.lblDomain.AutoSize = true;
            this.lblDomain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomain.Location = new System.Drawing.Point(95, 35);
            this.lblDomain.Name = "lblDomain";
            this.lblDomain.Size = new System.Drawing.Size(56, 13);
            this.lblDomain.TabIndex = 4;
            this.lblDomain.Text = "DOMAIN";
            this.lblDomain.Click += new System.EventHandler(this.lblDomain_Click);
            // 
            // lblDomain_lbl
            // 
            this.lblDomain_lbl.AutoSize = true;
            this.lblDomain_lbl.Location = new System.Drawing.Point(8, 35);
            this.lblDomain_lbl.Name = "lblDomain_lbl";
            this.lblDomain_lbl.Size = new System.Drawing.Size(46, 13);
            this.lblDomain_lbl.TabIndex = 3;
            this.lblDomain_lbl.Text = "Domain:";
            // 
            // lblComputername
            // 
            this.lblComputername.AutoSize = true;
            this.lblComputername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputername.Location = new System.Drawing.Point(95, 15);
            this.lblComputername.Name = "lblComputername";
            this.lblComputername.Size = new System.Drawing.Size(111, 13);
            this.lblComputername.TabIndex = 2;
            this.lblComputername.Text = "COMPUTERNAME";
            this.lblComputername.Click += new System.EventHandler(this.lblComputername_Click);
            // 
            // lblComputername_lbl
            // 
            this.lblComputername_lbl.AutoSize = true;
            this.lblComputername_lbl.Location = new System.Drawing.Point(8, 15);
            this.lblComputername_lbl.Name = "lblComputername_lbl";
            this.lblComputername_lbl.Size = new System.Drawing.Size(81, 13);
            this.lblComputername_lbl.TabIndex = 0;
            this.lblComputername_lbl.Text = "Computername:";
            // 
            // tabOfficeLine
            // 
            this.tabOfficeLine.Controls.Add(this.cbOLInstalled);
            this.tabOfficeLine.Location = new System.Drawing.Point(4, 22);
            this.tabOfficeLine.Name = "tabOfficeLine";
            this.tabOfficeLine.Padding = new System.Windows.Forms.Padding(3);
            this.tabOfficeLine.Size = new System.Drawing.Size(747, 372);
            this.tabOfficeLine.TabIndex = 1;
            this.tabOfficeLine.Text = "Office Line";
            this.tabOfficeLine.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(560, 427);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(191, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // cbOLInstalled
            // 
            this.cbOLInstalled.AutoCheck = false;
            this.cbOLInstalled.AutoSize = true;
            this.cbOLInstalled.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOLInstalled.Location = new System.Drawing.Point(8, 15);
            this.cbOLInstalled.Name = "cbOLInstalled";
            this.cbOLInstalled.Size = new System.Drawing.Size(143, 17);
            this.cbOLInstalled.TabIndex = 1;
            this.cbOLInstalled.Text = "Office Line installiert";
            this.cbOLInstalled.UseVisualStyleBackColor = true;
            // 
            // MainGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 454);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainGui";
            this.Text = "HTK Support Tool";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabInfo.ResumeLayout(false);
            this.tabInfo.PerformLayout();
            this.tabOfficeLine.ResumeLayout(false);
            this.tabOfficeLine.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuStartenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aktionenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem überToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabInfo;
        private System.Windows.Forms.TabPage tabOfficeLine;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblComputername_lbl;
        private System.Windows.Forms.Label lblComputername;
        private System.Windows.Forms.Label lblDomain;
        private System.Windows.Forms.Label lblDomain_lbl;
        private System.Windows.Forms.Label lblComputerIP_lbl;
        private System.Windows.Forms.Label lblComputerIP;
        private System.Windows.Forms.Label lblFqdn;
        private System.Windows.Forms.Label lblFqdn_lbl;
        private System.Windows.Forms.CheckBox cbOLInstalled;
    }
}

