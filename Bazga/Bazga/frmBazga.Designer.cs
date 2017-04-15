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
      this.panel2 = new System.Windows.Forms.Panel();
      this.lblDatabasePath = new System.Windows.Forms.Label();
      this.btnSave = new System.Windows.Forms.Button();
      this.grpMan = new System.Windows.Forms.GroupBox();
      this.grpLinks = new System.Windows.Forms.GroupBox();
      this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
      this.trayMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.mnuExitTray = new System.Windows.Forms.ToolStripMenuItem();
      this.lblNotSaved = new System.Windows.Forms.Label();
      this.ctlPersonDetails1 = new Bazga.ctlPersonDetails();
      this.ctlPersonList1 = new Bazga.ctlPersonList();
      this.grpPeople.SuspendLayout();
      this.panel1.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.pnlDatabase.SuspendLayout();
      this.panel2.SuspendLayout();
      this.grpMan.SuspendLayout();
      this.trayMenuStrip.SuspendLayout();
      this.SuspendLayout();
      // 
      // grpPeople
      // 
      this.grpPeople.Controls.Add(this.ctlPersonList1);
      this.grpPeople.Controls.Add(this.panel1);
      this.grpPeople.Dock = System.Windows.Forms.DockStyle.Left;
      this.grpPeople.Location = new System.Drawing.Point(0, 24);
      this.grpPeople.Name = "grpPeople";
      this.grpPeople.Size = new System.Drawing.Size(432, 556);
      this.grpPeople.TabIndex = 0;
      this.grpPeople.TabStop = false;
      this.grpPeople.Text = "Ljudi";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.btnEditPerson);
      this.panel1.Controls.Add(this.btnNewPerson);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(3, 16);
      this.panel1.Name = "panel1";
      this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
      this.panel1.Size = new System.Drawing.Size(426, 28);
      this.panel1.TabIndex = 0;
      // 
      // btnEditPerson
      // 
      this.btnEditPerson.Dock = System.Windows.Forms.DockStyle.Left;
      this.btnEditPerson.Enabled = false;
      this.btnEditPerson.Image = global::Bazga.Properties.Resources.Edit_Image;
      this.btnEditPerson.Location = new System.Drawing.Point(24, 0);
      this.btnEditPerson.Name = "btnEditPerson";
      this.btnEditPerson.Size = new System.Drawing.Size(24, 24);
      this.btnEditPerson.TabIndex = 1;
      this.btnEditPerson.UseVisualStyleBackColor = true;
      this.btnEditPerson.Click += new System.EventHandler(this.btnEditPerson_Click);
      // 
      // btnNewPerson
      // 
      this.btnNewPerson.Dock = System.Windows.Forms.DockStyle.Left;
      this.btnNewPerson.Image = global::Bazga.Properties.Resources.Add_Image;
      this.btnNewPerson.Location = new System.Drawing.Point(0, 0);
      this.btnNewPerson.Name = "btnNewPerson";
      this.btnNewPerson.Size = new System.Drawing.Size(24, 24);
      this.btnNewPerson.TabIndex = 0;
      this.btnNewPerson.UseVisualStyleBackColor = true;
      this.btnNewPerson.Click += new System.EventHandler(this.btnNewPerson_Click);
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDatabase,
            this.mnuSettings});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1162, 24);
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
      this.mnuNewDatabase.Image = global::Bazga.Properties.Resources.New_Image;
      this.mnuNewDatabase.Name = "mnuNewDatabase";
      this.mnuNewDatabase.Size = new System.Drawing.Size(142, 22);
      this.mnuNewDatabase.Text = "Nova";
      this.mnuNewDatabase.Click += new System.EventHandler(this.mnuNewDatabase_Click);
      // 
      // mnuOpenDatabase
      // 
      this.mnuOpenDatabase.Image = global::Bazga.Properties.Resources.Open_Image;
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
      this.mnuSaveDatabase.Image = global::Bazga.Properties.Resources.Save_Image;
      this.mnuSaveDatabase.Name = "mnuSaveDatabase";
      this.mnuSaveDatabase.Size = new System.Drawing.Size(142, 22);
      this.mnuSaveDatabase.Text = "Spremi";
      this.mnuSaveDatabase.Click += new System.EventHandler(this.mnuSaveDatabase_Click);
      // 
      // mnuSaveDatabaseAs
      // 
      this.mnuSaveDatabaseAs.Enabled = false;
      this.mnuSaveDatabaseAs.Image = global::Bazga.Properties.Resources.Save_Image;
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
      this.pnlDatabase.Controls.Add(this.panel2);
      this.pnlDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlDatabase.Enabled = false;
      this.pnlDatabase.Location = new System.Drawing.Point(0, 24);
      this.pnlDatabase.Name = "pnlDatabase";
      this.pnlDatabase.Size = new System.Drawing.Size(1162, 580);
      this.pnlDatabase.TabIndex = 2;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.lblDatabasePath);
      this.panel2.Controls.Add(this.lblNotSaved);
      this.panel2.Controls.Add(this.btnSave);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel2.Location = new System.Drawing.Point(0, 0);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(1162, 24);
      this.panel2.TabIndex = 4;
      // 
      // lblDatabasePath
      // 
      this.lblDatabasePath.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lblDatabasePath.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblDatabasePath.Location = new System.Drawing.Point(0, 0);
      this.lblDatabasePath.Name = "lblDatabasePath";
      this.lblDatabasePath.Size = new System.Drawing.Size(940, 24);
      this.lblDatabasePath.TabIndex = 1;
      this.lblDatabasePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // btnSave
      // 
      this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
      this.btnSave.Location = new System.Drawing.Point(1084, 0);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(78, 24);
      this.btnSave.TabIndex = 2;
      this.btnSave.Text = "Spremi";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // grpMan
      // 
      this.grpMan.Controls.Add(this.ctlPersonDetails1);
      this.grpMan.Dock = System.Windows.Forms.DockStyle.Fill;
      this.grpMan.Location = new System.Drawing.Point(432, 24);
      this.grpMan.Name = "grpMan";
      this.grpMan.Size = new System.Drawing.Size(730, 471);
      this.grpMan.TabIndex = 2;
      this.grpMan.TabStop = false;
      this.grpMan.Text = "Čovjek";
      // 
      // grpLinks
      // 
      this.grpLinks.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.grpLinks.Location = new System.Drawing.Point(432, 495);
      this.grpLinks.Name = "grpLinks";
      this.grpLinks.Size = new System.Drawing.Size(730, 85);
      this.grpLinks.TabIndex = 3;
      this.grpLinks.TabStop = false;
      this.grpLinks.Text = "Linkovi";
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
      // lblNotSaved
      // 
      this.lblNotSaved.Dock = System.Windows.Forms.DockStyle.Right;
      this.lblNotSaved.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.lblNotSaved.ForeColor = System.Drawing.Color.Red;
      this.lblNotSaved.Location = new System.Drawing.Point(940, 0);
      this.lblNotSaved.Name = "lblNotSaved";
      this.lblNotSaved.Size = new System.Drawing.Size(144, 24);
      this.lblNotSaved.TabIndex = 3;
      this.lblNotSaved.Text = "Nije Spremljeno";
      this.lblNotSaved.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.lblNotSaved.Visible = false;
      // 
      // ctlPersonDetails1
      // 
      this.ctlPersonDetails1.Database = null;
      this.ctlPersonDetails1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ctlPersonDetails1.Location = new System.Drawing.Point(3, 16);
      this.ctlPersonDetails1.Name = "ctlPersonDetails1";
      this.ctlPersonDetails1.PersonID = null;
      this.ctlPersonDetails1.Size = new System.Drawing.Size(724, 452);
      this.ctlPersonDetails1.TabIndex = 0;
      // 
      // ctlPersonList1
      // 
      this.ctlPersonList1.ActiveFilter = true;
      this.ctlPersonList1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.ctlPersonList1.Database = null;
      this.ctlPersonList1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ctlPersonList1.Location = new System.Drawing.Point(3, 44);
      this.ctlPersonList1.Name = "ctlPersonList1";
      this.ctlPersonList1.SelectedPersonID = null;
      this.ctlPersonList1.Size = new System.Drawing.Size(426, 509);
      this.ctlPersonList1.TabIndex = 1;
      this.ctlPersonList1.SelectionChanged += new Bazga.Delegates.VoidDelegate(this.ctlPersonList1_SelectionChanged);
      // 
      // frmBazga
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1162, 604);
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
      this.panel1.ResumeLayout(false);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.pnlDatabase.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.grpMan.ResumeLayout(false);
      this.trayMenuStrip.ResumeLayout(false);
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
    private System.Windows.Forms.GroupBox grpLinks;
    private System.Windows.Forms.GroupBox grpMan;
    private ctlPersonDetails ctlPersonDetails1;
    private ctlPersonList ctlPersonList1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Label lblNotSaved;
  }
}

