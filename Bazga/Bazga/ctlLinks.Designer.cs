namespace Bazga
{
  partial class ctlLinks
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.contextLink = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.kopirajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.btnEditLinks = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.pnlContainer = new System.Windows.Forms.FlowLayoutPanel();
      this.contextLink.SuspendLayout();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // contextLink
      // 
      this.contextLink.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kopirajToolStripMenuItem});
      this.contextLink.Name = "contextLink";
      this.contextLink.Size = new System.Drawing.Size(112, 26);
      // 
      // kopirajToolStripMenuItem
      // 
      this.kopirajToolStripMenuItem.Name = "kopirajToolStripMenuItem";
      this.kopirajToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
      this.kopirajToolStripMenuItem.Text = "Kopiraj";
      this.kopirajToolStripMenuItem.Click += new System.EventHandler(this.kopirajToolStripMenuItem_Click);
      // 
      // btnEditLinks
      // 
      this.btnEditLinks.Enabled = false;
      this.btnEditLinks.Image = global::Bazga.Properties.Resources.Edit_Image;
      this.btnEditLinks.Location = new System.Drawing.Point(0, 0);
      this.btnEditLinks.Name = "btnEditLinks";
      this.btnEditLinks.Size = new System.Drawing.Size(24, 24);
      this.btnEditLinks.TabIndex = 2;
      this.btnEditLinks.UseVisualStyleBackColor = true;
      this.btnEditLinks.Click += new System.EventHandler(this.btnEditLinks_Click);
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.btnEditLinks);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
      this.panel1.Location = new System.Drawing.Point(738, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(24, 257);
      this.panel1.TabIndex = 3;
      // 
      // pnlContainer
      // 
      this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlContainer.Location = new System.Drawing.Point(0, 0);
      this.pnlContainer.Name = "pnlContainer";
      this.pnlContainer.Padding = new System.Windows.Forms.Padding(32, 8, 8, 8);
      this.pnlContainer.Size = new System.Drawing.Size(738, 257);
      this.pnlContainer.TabIndex = 4;
      // 
      // ctlLinks
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.pnlContainer);
      this.Controls.Add(this.panel1);
      this.Name = "ctlLinks";
      this.Size = new System.Drawing.Size(762, 257);
      this.contextLink.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.ContextMenuStrip contextLink;
    private System.Windows.Forms.ToolStripMenuItem kopirajToolStripMenuItem;
    private System.Windows.Forms.Button btnEditLinks;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.FlowLayoutPanel pnlContainer;
  }
}
