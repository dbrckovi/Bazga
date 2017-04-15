namespace Bazga
{
  partial class frmBazga
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
      this.components = new System.ComponentModel.Container();
      this.grpPeople = new System.Windows.Forms.GroupBox();
      this.pnlPersons = new System.Windows.Forms.Panel();
      this.panel1 = new System.Windows.Forms.Panel();
      this.btnEditPerson = new System.Windows.Forms.Button();
      this.btnNewPerson = new System.Windows.Forms.Button();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.mnuDatabase = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuNewDatabase = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuOpenDatabase = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
      this.mnuSaveDatabase = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuSaveDatabaseAs = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuSettings = new System.Windows.Forms.ToolStripMenuItem();
      this.pnlDatabase = new System.Windows.Forms.Panel();
      this.lblDatabasePath = new System.Windows.Forms.Label();
      this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
      this.trayMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.mnuExitTray = new System.Windows.Forms.ToolStripMenuItem();
      this.grpMan = new System.Windows.Forms.GroupBox();
      this.grpLinks = new System.Windows.Forms.GroupBox();
      this.ctlPersonDetails1 = new Bazga.ctlPersonDetails();
      this.ctlPerson12 = new Bazga.ctlPerson();
      this.ctlPerson11 = new Bazga.ctlPerson();
      this.ctlPerson10 = new Bazga.ctlPerson();
      this.ctlPerson9 = new Bazga.ctlPerson();
      this.ctlPerson8 = new Bazga.ctlPerson();
      this.ctlPerson7 = new Bazga.ctlPerson();
      this.ctlPerson6 = new Bazga.ctlPerson();
      this.ctlPerson5 = new Bazga.ctlPerson();
      this.ctlPerson4 = new Bazga.ctlPerson();
      this.ctlPerson3 = new Bazga.ctlPerson();
      this.ctlPerson2 = new Bazga.ctlPerson();
      this.ctlPerson1 = new Bazga.ctlPerson();
      this.grpPeople.SuspendLayout();
      this.pnlPersons.SuspendLayout();
      this.panel1.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.pnlDatabase.SuspendLayout();
      this.trayMenuStrip.SuspendLayout();
      this.grpMan.SuspendLayout();
      this.SuspendLayout();
      // 
      // grpPeople
      // 
      this.grpPeople.Controls.Add(this.pnlPersons);
      this.grpPeople.Controls.Add(this.panel1);
      this.grpPeople.Dock = System.Windows.Forms.DockStyle.Left;
      this.grpPeople.Location = new System.Drawing.Point(0, 24);
      this.grpPeople.Name = "grpPeople";
      this.grpPeople.Size = new System.Drawing.Size(432, 520);
      this.grpPeople.TabIndex = 0;
      this.grpPeople.TabStop = false;
      this.grpPeople.Text = "Ljudi";
      // 
      // pnlPersons
      // 
      this.pnlPersons.AutoScroll = true;
      this.pnlPersons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.pnlPersons.Controls.Add(this.ctlPerson12);
      this.pnlPersons.Controls.Add(this.ctlPerson11);
      this.pnlPersons.Controls.Add(this.ctlPerson10);
      this.pnlPersons.Controls.Add(this.ctlPerson9);
      this.pnlPersons.Controls.Add(this.ctlPerson8);
      this.pnlPersons.Controls.Add(this.ctlPerson7);
      this.pnlPersons.Controls.Add(this.ctlPerson6);
      this.pnlPersons.Controls.Add(this.ctlPerson5);
      this.pnlPersons.Controls.Add(this.ctlPerson4);
      this.pnlPersons.Controls.Add(this.ctlPerson3);
      this.pnlPersons.Controls.Add(this.ctlPerson2);
      this.pnlPersons.Controls.Add(this.ctlPerson1);
      this.pnlPersons.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlPersons.Location = new System.Drawing.Point(3, 48);
      this.pnlPersons.Name = "pnlPersons";
      this.pnlPersons.Size = new System.Drawing.Size(426, 469);
      this.pnlPersons.TabIndex = 1;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.btnEditPerson);
      this.panel1.Controls.Add(this.btnNewPerson);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(3, 16);
      this.panel1.Name = "panel1";
      this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
      this.panel1.Size = new System.Drawing.Size(426, 32);
      this.panel1.TabIndex = 0;
      // 
      // btnEditPerson
      // 
      this.btnEditPerson.Dock = System.Windows.Forms.DockStyle.Left;
      this.btnEditPerson.Location = new System.Drawing.Point(40, 0);
      this.btnEditPerson.Name = "btnEditPerson";
      this.btnEditPerson.Size = new System.Drawing.Size(40, 28);
      this.btnEditPerson.TabIndex = 1;
      this.btnEditPerson.Text = "Edit";
      this.btnEditPerson.UseVisualStyleBackColor = true;
      // 
      // btnNewPerson
      // 
      this.btnNewPerson.Dock = System.Windows.Forms.DockStyle.Left;
      this.btnNewPerson.Location = new System.Drawing.Point(0, 0);
      this.btnNewPerson.Name = "btnNewPerson";
      this.btnNewPerson.Size = new System.Drawing.Size(40, 28);
      this.btnNewPerson.TabIndex = 0;
      this.btnNewPerson.Text = "New";
      this.btnNewPerson.UseVisualStyleBackColor = true;
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDatabase,
            this.mnuSettings});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1094, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "mnuMain";
      // 
      // mnuDatabase
      // 
      this.mnuDatabase.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNewDatabase,
            this.mnuOpenDatabase,
            this.toolStripMenuItem1,
            this.mnuSaveDatabase,
            this.mnuSaveDatabaseAs});
      this.mnuDatabase.Name = "mnuDatabase";
      this.mnuDatabase.Size = new System.Drawing.Size(43, 20);
      this.mnuDatabase.Text = "Baza";
      // 
      // mnuNewDatabase
      // 
      this.mnuNewDatabase.Name = "mnuNewDatabase";
      this.mnuNewDatabase.Size = new System.Drawing.Size(142, 22);
      this.mnuNewDatabase.Text = "Nova";
      this.mnuNewDatabase.Click += new System.EventHandler(this.mnuNewDatabase_Click);
      // 
      // mnuOpenDatabase
      // 
      this.mnuOpenDatabase.Name = "mnuOpenDatabase";
      this.mnuOpenDatabase.Size = new System.Drawing.Size(142, 22);
      this.mnuOpenDatabase.Text = "Otvori";
      this.mnuOpenDatabase.Click += new System.EventHandler(this.mnuOpenDatabase_Click);
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(139, 6);
      // 
      // mnuSaveDatabase
      // 
      this.mnuSaveDatabase.Enabled = false;
      this.mnuSaveDatabase.Name = "mnuSaveDatabase";
      this.mnuSaveDatabase.Size = new System.Drawing.Size(142, 22);
      this.mnuSaveDatabase.Text = "Spremi";
      this.mnuSaveDatabase.Click += new System.EventHandler(this.mnuSaveDatabase_Click);
      // 
      // mnuSaveDatabaseAs
      // 
      this.mnuSaveDatabaseAs.Enabled = false;
      this.mnuSaveDatabaseAs.Name = "mnuSaveDatabaseAs";
      this.mnuSaveDatabaseAs.Size = new System.Drawing.Size(142, 22);
      this.mnuSaveDatabaseAs.Text = "Spremi kao...";
      this.mnuSaveDatabaseAs.Click += new System.EventHandler(this.mnuSaveDatabaseAs_Click);
      // 
      // mnuSettings
      // 
      this.mnuSettings.Name = "mnuSettings";
      this.mnuSettings.Size = new System.Drawing.Size(66, 20);
      this.mnuSettings.Text = "Postavke";
      this.mnuSettings.Click += new System.EventHandler(this.mnuSettings_Click);
      // 
      // pnlDatabase
      // 
      this.pnlDatabase.Controls.Add(this.grpMan);
      this.pnlDatabase.Controls.Add(this.grpLinks);
      this.pnlDatabase.Controls.Add(this.grpPeople);
      this.pnlDatabase.Controls.Add(this.lblDatabasePath);
      this.pnlDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlDatabase.Enabled = false;
      this.pnlDatabase.Location = new System.Drawing.Point(0, 24);
      this.pnlDatabase.Name = "pnlDatabase";
      this.pnlDatabase.Size = new System.Drawing.Size(1094, 544);
      this.pnlDatabase.TabIndex = 2;
      // 
      // lblDatabasePath
      // 
      this.lblDatabasePath.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lblDatabasePath.Dock = System.Windows.Forms.DockStyle.Top;
      this.lblDatabasePath.Location = new System.Drawing.Point(0, 0);
      this.lblDatabasePath.Name = "lblDatabasePath";
      this.lblDatabasePath.Size = new System.Drawing.Size(1094, 24);
      this.lblDatabasePath.TabIndex = 1;
      this.lblDatabasePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // trayIcon
      // 
      this.trayIcon.ContextMenuStrip = this.trayMenuStrip;
      this.trayIcon.Text = "Baza za Gablece";
      this.trayIcon.Visible = true;
      this.trayIcon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseUp);
      // 
      // trayMenuStrip
      // 
      this.trayMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExitTray});
      this.trayMenuStrip.Name = "trayMenuStrip";
      this.trayMenuStrip.Size = new System.Drawing.Size(97, 26);
      // 
      // mnuExitTray
      // 
      this.mnuExitTray.Name = "mnuExitTray";
      this.mnuExitTray.Size = new System.Drawing.Size(96, 22);
      this.mnuExitTray.Text = "Izlaz";
      this.mnuExitTray.Click += new System.EventHandler(this.mnuExitTray_Click);
      // 
      // grpMan
      // 
      this.grpMan.Controls.Add(this.ctlPersonDetails1);
      this.grpMan.Dock = System.Windows.Forms.DockStyle.Fill;
      this.grpMan.Location = new System.Drawing.Point(432, 24);
      this.grpMan.Name = "grpMan";
      this.grpMan.Size = new System.Drawing.Size(662, 368);
      this.grpMan.TabIndex = 2;
      this.grpMan.TabStop = false;
      this.grpMan.Text = "Čovjek";
      // 
      // grpLinks
      // 
      this.grpLinks.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.grpLinks.Location = new System.Drawing.Point(432, 392);
      this.grpLinks.Name = "grpLinks";
      this.grpLinks.Size = new System.Drawing.Size(662, 152);
      this.grpLinks.TabIndex = 3;
      this.grpLinks.TabStop = false;
      this.grpLinks.Text = "Linkovi";
      // 
      // ctlPersonDetails1
      // 
      this.ctlPersonDetails1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ctlPersonDetails1.Location = new System.Drawing.Point(3, 16);
      this.ctlPersonDetails1.Name = "ctlPersonDetails1";
      this.ctlPersonDetails1.Size = new System.Drawing.Size(656, 349);
      this.ctlPersonDetails1.TabIndex = 0;
      this.ctlPersonDetails1.Visible = false;
      // 
      // ctlPerson12
      // 
      this.ctlPerson12.Dock = System.Windows.Forms.DockStyle.Top;
      this.ctlPerson12.Location = new System.Drawing.Point(0, 242);
      this.ctlPerson12.Name = "ctlPerson12";
      this.ctlPerson12.Size = new System.Drawing.Size(422, 22);
      this.ctlPerson12.TabIndex = 11;
      // 
      // ctlPerson11
      // 
      this.ctlPerson11.Dock = System.Windows.Forms.DockStyle.Top;
      this.ctlPerson11.Location = new System.Drawing.Point(0, 220);
      this.ctlPerson11.Name = "ctlPerson11";
      this.ctlPerson11.Size = new System.Drawing.Size(422, 22);
      this.ctlPerson11.TabIndex = 10;
      // 
      // ctlPerson10
      // 
      this.ctlPerson10.Dock = System.Windows.Forms.DockStyle.Top;
      this.ctlPerson10.Location = new System.Drawing.Point(0, 198);
      this.ctlPerson10.Name = "ctlPerson10";
      this.ctlPerson10.Size = new System.Drawing.Size(422, 22);
      this.ctlPerson10.TabIndex = 9;
      // 
      // ctlPerson9
      // 
      this.ctlPerson9.Dock = System.Windows.Forms.DockStyle.Top;
      this.ctlPerson9.Location = new System.Drawing.Point(0, 176);
      this.ctlPerson9.Name = "ctlPerson9";
      this.ctlPerson9.Size = new System.Drawing.Size(422, 22);
      this.ctlPerson9.TabIndex = 8;
      // 
      // ctlPerson8
      // 
      this.ctlPerson8.Dock = System.Windows.Forms.DockStyle.Top;
      this.ctlPerson8.Location = new System.Drawing.Point(0, 154);
      this.ctlPerson8.Name = "ctlPerson8";
      this.ctlPerson8.Size = new System.Drawing.Size(422, 22);
      this.ctlPerson8.TabIndex = 7;
      // 
      // ctlPerson7
      // 
      this.ctlPerson7.Dock = System.Windows.Forms.DockStyle.Top;
      this.ctlPerson7.Location = new System.Drawing.Point(0, 132);
      this.ctlPerson7.Name = "ctlPerson7";
      this.ctlPerson7.Size = new System.Drawing.Size(422, 22);
      this.ctlPerson7.TabIndex = 6;
      this.ctlPerson7.Load += new System.EventHandler(this.ctlPerson7_Load);
      // 
      // ctlPerson6
      // 
      this.ctlPerson6.Dock = System.Windows.Forms.DockStyle.Top;
      this.ctlPerson6.Location = new System.Drawing.Point(0, 110);
      this.ctlPerson6.Name = "ctlPerson6";
      this.ctlPerson6.Size = new System.Drawing.Size(422, 22);
      this.ctlPerson6.TabIndex = 5;
      this.ctlPerson6.Load += new System.EventHandler(this.ctlPerson6_Load);
      // 
      // ctlPerson5
      // 
      this.ctlPerson5.Dock = System.Windows.Forms.DockStyle.Top;
      this.ctlPerson5.Location = new System.Drawing.Point(0, 88);
      this.ctlPerson5.Name = "ctlPerson5";
      this.ctlPerson5.Size = new System.Drawing.Size(422, 22);
      this.ctlPerson5.TabIndex = 4;
      // 
      // ctlPerson4
      // 
      this.ctlPerson4.Dock = System.Windows.Forms.DockStyle.Top;
      this.ctlPerson4.Location = new System.Drawing.Point(0, 66);
      this.ctlPerson4.Name = "ctlPerson4";
      this.ctlPerson4.Size = new System.Drawing.Size(422, 22);
      this.ctlPerson4.TabIndex = 3;
      // 
      // ctlPerson3
      // 
      this.ctlPerson3.Dock = System.Windows.Forms.DockStyle.Top;
      this.ctlPerson3.Location = new System.Drawing.Point(0, 44);
      this.ctlPerson3.Name = "ctlPerson3";
      this.ctlPerson3.Size = new System.Drawing.Size(422, 22);
      this.ctlPerson3.TabIndex = 2;
      // 
      // ctlPerson2
      // 
      this.ctlPerson2.Dock = System.Windows.Forms.DockStyle.Top;
      this.ctlPerson2.Location = new System.Drawing.Point(0, 22);
      this.ctlPerson2.Name = "ctlPerson2";
      this.ctlPerson2.Size = new System.Drawing.Size(422, 22);
      this.ctlPerson2.TabIndex = 1;
      // 
      // ctlPerson1
      // 
      this.ctlPerson1.Dock = System.Windows.Forms.DockStyle.Top;
      this.ctlPerson1.Location = new System.Drawing.Point(0, 0);
      this.ctlPerson1.Name = "ctlPerson1";
      this.ctlPerson1.Size = new System.Drawing.Size(422, 22);
      this.ctlPerson1.TabIndex = 0;
      // 
      // frmBazga
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1094, 568);
      this.Controls.Add(this.pnlDatabase);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmBazga";
      this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
      this.Text = "Baza za Gablece";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBazga_FormClosing);
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmBazga_FormClosed);
      this.Load += new System.EventHandler(this.Form1_Load);
      this.Shown += new System.EventHandler(this.frmBazga_Shown);
      this.grpPeople.ResumeLayout(false);
      this.pnlPersons.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.pnlDatabase.ResumeLayout(false);
      this.trayMenuStrip.ResumeLayout(false);
      this.grpMan.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.GroupBox grpPeople;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem mnuDatabase;
    private System.Windows.Forms.ToolStripMenuItem mnuNewDatabase;
    private System.Windows.Forms.ToolStripMenuItem mnuOpenDatabase;
    private System.Windows.Forms.ToolStripMenuItem mnuSaveDatabase;
    private System.Windows.Forms.Panel pnlDatabase;
    private System.Windows.Forms.ToolStripMenuItem mnuSettings;
    private System.Windows.Forms.NotifyIcon trayIcon;
    private System.Windows.Forms.ContextMenuStrip trayMenuStrip;
    private System.Windows.Forms.ToolStripMenuItem mnuExitTray;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem mnuSaveDatabaseAs;
    private System.Windows.Forms.Label lblDatabasePath;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button btnEditPerson;
    private System.Windows.Forms.Button btnNewPerson;
    private System.Windows.Forms.Panel pnlPersons;
    private ctlPerson ctlPerson12;
    private ctlPerson ctlPerson11;
    private ctlPerson ctlPerson10;
    private ctlPerson ctlPerson9;
    private ctlPerson ctlPerson8;
    private ctlPerson ctlPerson7;
    private ctlPerson ctlPerson6;
    private ctlPerson ctlPerson5;
    private ctlPerson ctlPerson4;
    private ctlPerson ctlPerson3;
    private ctlPerson ctlPerson2;
    private ctlPerson ctlPerson1;
    private System.Windows.Forms.GroupBox grpLinks;
    private System.Windows.Forms.GroupBox grpMan;
    private ctlPersonDetails ctlPersonDetails1;
  }
}

