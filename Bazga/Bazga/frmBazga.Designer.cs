﻿namespace Bazga
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
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.mnuDatabase = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuNewDatabase = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuOpenDatabase = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuSaveDatabase = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuSettings = new System.Windows.Forms.ToolStripMenuItem();
      this.pnlDatabase = new System.Windows.Forms.Panel();
      this.pnlStatus = new System.Windows.Forms.Panel();
      this.lblStatus = new System.Windows.Forms.Label();
      this.btnSave = new System.Windows.Forms.Button();
      this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
      this.trayMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.mnuExitTray = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.pnlDatabase.SuspendLayout();
      this.pnlStatus.SuspendLayout();
      this.trayMenuStrip.SuspendLayout();
      this.SuspendLayout();
      // 
      // grpPeople
      // 
      this.grpPeople.Location = new System.Drawing.Point(8, 24);
      this.grpPeople.Name = "grpPeople";
      this.grpPeople.Size = new System.Drawing.Size(312, 456);
      this.grpPeople.TabIndex = 0;
      this.grpPeople.TabStop = false;
      this.grpPeople.Text = "Ljudi";
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDatabase,
            this.mnuSettings});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(923, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "mnuMain";
      // 
      // mnuDatabase
      // 
      this.mnuDatabase.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNewDatabase,
            this.mnuOpenDatabase,
            this.mnuSaveDatabase});
      this.mnuDatabase.Name = "mnuDatabase";
      this.mnuDatabase.Size = new System.Drawing.Size(43, 20);
      this.mnuDatabase.Text = "Baza";
      // 
      // mnuNewDatabase
      // 
      this.mnuNewDatabase.Name = "mnuNewDatabase";
      this.mnuNewDatabase.Size = new System.Drawing.Size(111, 22);
      this.mnuNewDatabase.Text = "Nova";
      // 
      // mnuOpenDatabase
      // 
      this.mnuOpenDatabase.Name = "mnuOpenDatabase";
      this.mnuOpenDatabase.Size = new System.Drawing.Size(111, 22);
      this.mnuOpenDatabase.Text = "Otvori";
      // 
      // mnuSaveDatabase
      // 
      this.mnuSaveDatabase.Name = "mnuSaveDatabase";
      this.mnuSaveDatabase.Size = new System.Drawing.Size(111, 22);
      this.mnuSaveDatabase.Text = "Spremi";
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
      this.pnlDatabase.Controls.Add(this.grpPeople);
      this.pnlDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlDatabase.Enabled = false;
      this.pnlDatabase.Location = new System.Drawing.Point(0, 24);
      this.pnlDatabase.Name = "pnlDatabase";
      this.pnlDatabase.Size = new System.Drawing.Size(923, 536);
      this.pnlDatabase.TabIndex = 2;
      // 
      // pnlStatus
      // 
      this.pnlStatus.Controls.Add(this.lblStatus);
      this.pnlStatus.Controls.Add(this.btnSave);
      this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.pnlStatus.Location = new System.Drawing.Point(0, 560);
      this.pnlStatus.Name = "pnlStatus";
      this.pnlStatus.Padding = new System.Windows.Forms.Padding(2);
      this.pnlStatus.Size = new System.Drawing.Size(923, 31);
      this.pnlStatus.TabIndex = 3;
      // 
      // lblStatus
      // 
      this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblStatus.Location = new System.Drawing.Point(2, 2);
      this.lblStatus.Name = "lblStatus";
      this.lblStatus.Size = new System.Drawing.Size(863, 27);
      this.lblStatus.TabIndex = 0;
      this.lblStatus.Text = "label1";
      this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // btnSave
      // 
      this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
      this.btnSave.Location = new System.Drawing.Point(865, 2);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(56, 27);
      this.btnSave.TabIndex = 1;
      this.btnSave.Text = "Spremi";
      this.btnSave.UseVisualStyleBackColor = true;
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
      // frmBazga
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(923, 591);
      this.Controls.Add(this.pnlDatabase);
      this.Controls.Add(this.menuStrip1);
      this.Controls.Add(this.pnlStatus);
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
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.pnlDatabase.ResumeLayout(false);
      this.pnlStatus.ResumeLayout(false);
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
    private System.Windows.Forms.Panel pnlStatus;
    private System.Windows.Forms.Label lblStatus;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.ToolStripMenuItem mnuSettings;
    private System.Windows.Forms.NotifyIcon trayIcon;
    private System.Windows.Forms.ContextMenuStrip trayMenuStrip;
    private System.Windows.Forms.ToolStripMenuItem mnuExitTray;
  }
}

