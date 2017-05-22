namespace Firewall_Projekt
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBoxStream = new System.Windows.Forms.ListBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.netzwerkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interneUndExterneIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zeigeInternetKommunikationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spieleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pingPongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tABSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schnellesBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cS16ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxStream
            // 
            this.listBoxStream.FormattingEnabled = true;
            this.listBoxStream.Location = new System.Drawing.Point(12, 43);
            this.listBoxStream.Name = "listBoxStream";
            this.listBoxStream.Size = new System.Drawing.Size(380, 316);
            this.listBoxStream.TabIndex = 6;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(311, 365);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(81, 22);
            this.buttonReset.TabIndex = 7;
            this.buttonReset.Text = "Listbox Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.netzwerkToolStripMenuItem,
            this.spieleToolStripMenuItem,
            this.backupToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(404, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // netzwerkToolStripMenuItem
            // 
            this.netzwerkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.interneUndExterneIPToolStripMenuItem,
            this.zeigeInternetKommunikationToolStripMenuItem});
            this.netzwerkToolStripMenuItem.Name = "netzwerkToolStripMenuItem";
            this.netzwerkToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.netzwerkToolStripMenuItem.Text = "Netzwerk";
            // 
            // interneUndExterneIPToolStripMenuItem
            // 
            this.interneUndExterneIPToolStripMenuItem.Name = "interneUndExterneIPToolStripMenuItem";
            this.interneUndExterneIPToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.interneUndExterneIPToolStripMenuItem.Text = "Interne und Externe IP";
            this.interneUndExterneIPToolStripMenuItem.Click += new System.EventHandler(this.interneUndExterneIPToolStripMenuItem_Click);
            // 
            // zeigeInternetKommunikationToolStripMenuItem
            // 
            this.zeigeInternetKommunikationToolStripMenuItem.Name = "zeigeInternetKommunikationToolStripMenuItem";
            this.zeigeInternetKommunikationToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.zeigeInternetKommunikationToolStripMenuItem.Text = "Zeige Internet Kommunikation";
            this.zeigeInternetKommunikationToolStripMenuItem.Click += new System.EventHandler(this.zeigeInternetKommunikationToolStripMenuItem_Click);
            // 
            // spieleToolStripMenuItem
            // 
            this.spieleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pingPongToolStripMenuItem,
            this.tABSToolStripMenuItem,
            this.cS16ToolStripMenuItem});
            this.spieleToolStripMenuItem.Name = "spieleToolStripMenuItem";
            this.spieleToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.spieleToolStripMenuItem.Text = "Spiele";
            // 
            // pingPongToolStripMenuItem
            // 
            this.pingPongToolStripMenuItem.Name = "pingPongToolStripMenuItem";
            this.pingPongToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pingPongToolStripMenuItem.Text = "Ping Pong";
            this.pingPongToolStripMenuItem.Click += new System.EventHandler(this.pingPongToolStripMenuItem_Click);
            // 
            // tABSToolStripMenuItem
            // 
            this.tABSToolStripMenuItem.Name = "tABSToolStripMenuItem";
            this.tABSToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tABSToolStripMenuItem.Text = "TABS";
            this.tABSToolStripMenuItem.Click += new System.EventHandler(this.tABSToolStripMenuItem_Click);
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schnellesBackupToolStripMenuItem,
            this.detailBackupToolStripMenuItem});
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.backupToolStripMenuItem.Text = "Backup";
            // 
            // schnellesBackupToolStripMenuItem
            // 
            this.schnellesBackupToolStripMenuItem.Name = "schnellesBackupToolStripMenuItem";
            this.schnellesBackupToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.schnellesBackupToolStripMenuItem.Text = "Schnelles USB Backup";
            this.schnellesBackupToolStripMenuItem.Click += new System.EventHandler(this.schnellesBackupToolStripMenuItem_Click);
            // 
            // detailBackupToolStripMenuItem
            // 
            this.detailBackupToolStripMenuItem.Name = "detailBackupToolStripMenuItem";
            this.detailBackupToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.detailBackupToolStripMenuItem.Text = "Detail Backup";
            this.detailBackupToolStripMenuItem.Click += new System.EventHandler(this.detailBackupToolStripMenuItem_Click);
            // 
            // cS16ToolStripMenuItem
            // 
            this.cS16ToolStripMenuItem.Name = "cS16ToolStripMenuItem";
            this.cS16ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cS16ToolStripMenuItem.Text = "CS 1.6";
            this.cS16ToolStripMenuItem.Click += new System.EventHandler(this.cS16ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(404, 389);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.listBoxStream);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Multifunktionstool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxStream;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem netzwerkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interneUndExterneIPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zeigeInternetKommunikationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spieleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pingPongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tABSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schnellesBackupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailBackupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cS16ToolStripMenuItem;
    }
}

