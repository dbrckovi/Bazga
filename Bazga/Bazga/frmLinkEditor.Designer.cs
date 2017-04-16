namespace Bazga
{
  partial class frmLinkEditor
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
      this.dataLinks = new System.Windows.Forms.DataGridView();
      this.btnSave = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.btnCancel = new System.Windows.Forms.Button();
      this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colURL = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.dataLinks)).BeginInit();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // dataLinks
      // 
      this.dataLinks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataLinks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colURL});
      this.dataLinks.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataLinks.Location = new System.Drawing.Point(0, 0);
      this.dataLinks.Name = "dataLinks";
      this.dataLinks.Size = new System.Drawing.Size(680, 272);
      this.dataLinks.TabIndex = 0;
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(296, 8);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(88, 32);
      this.btnSave.TabIndex = 1;
      this.btnSave.Text = "Spremi";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.btnCancel);
      this.panel1.Controls.Add(this.btnSave);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel1.Location = new System.Drawing.Point(0, 272);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(680, 49);
      this.panel1.TabIndex = 2;
      // 
      // btnCancel
      // 
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(584, 8);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(88, 32);
      this.btnCancel.TabIndex = 2;
      this.btnCancel.Text = "Odustani";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // colName
      // 
      this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.colName.DataPropertyName = "Name";
      this.colName.HeaderText = "Ime";
      this.colName.Name = "colName";
      this.colName.Width = 49;
      // 
      // colURL
      // 
      this.colURL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.colURL.DataPropertyName = "URL";
      this.colURL.HeaderText = "URL";
      this.colURL.Name = "colURL";
      // 
      // frmLinkEditor
      // 
      this.AcceptButton = this.btnSave;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(680, 321);
      this.Controls.Add(this.dataLinks);
      this.Controls.Add(this.panel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmLinkEditor";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Linkovi";
      this.Load += new System.EventHandler(this.frmLinkEditor_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataLinks)).EndInit();
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dataLinks;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.DataGridViewTextBoxColumn colName;
    private System.Windows.Forms.DataGridViewTextBoxColumn colURL;
  }
}