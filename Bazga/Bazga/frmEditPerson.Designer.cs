namespace Bazga
{
  partial class frmEditPerson
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
      this.lblName = new System.Windows.Forms.Label();
      this.txtName = new System.Windows.Forms.TextBox();
      this.chkActive = new System.Windows.Forms.CheckBox();
      this.lblNote = new System.Windows.Forms.Label();
      this.txtNote = new System.Windows.Forms.RichTextBox();
      this.btnSave = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lblName
      // 
      this.lblName.AutoSize = true;
      this.lblName.Location = new System.Drawing.Point(16, 24);
      this.lblName.Name = "lblName";
      this.lblName.Size = new System.Drawing.Size(24, 13);
      this.lblName.TabIndex = 0;
      this.lblName.Text = "Ime";
      // 
      // txtName
      // 
      this.txtName.Location = new System.Drawing.Point(96, 24);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(312, 20);
      this.txtName.TabIndex = 1;
      // 
      // chkActive
      // 
      this.chkActive.AutoSize = true;
      this.chkActive.Checked = true;
      this.chkActive.CheckState = System.Windows.Forms.CheckState.Checked;
      this.chkActive.Location = new System.Drawing.Point(96, 152);
      this.chkActive.Name = "chkActive";
      this.chkActive.Size = new System.Drawing.Size(62, 17);
      this.chkActive.TabIndex = 2;
      this.chkActive.Text = "Aktivan";
      this.chkActive.UseVisualStyleBackColor = true;
      // 
      // lblNote
      // 
      this.lblNote.AutoSize = true;
      this.lblNote.Location = new System.Drawing.Point(16, 56);
      this.lblNote.Name = "lblNote";
      this.lblNote.Size = new System.Drawing.Size(59, 13);
      this.lblNote.TabIndex = 3;
      this.lblNote.Text = "Napomena";
      // 
      // txtNote
      // 
      this.txtNote.Location = new System.Drawing.Point(96, 56);
      this.txtNote.Name = "txtNote";
      this.txtNote.Size = new System.Drawing.Size(312, 88);
      this.txtNote.TabIndex = 4;
      this.txtNote.Text = "";
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(96, 184);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(96, 32);
      this.btnSave.TabIndex = 5;
      this.btnSave.Text = "Spremi";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(312, 184);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(96, 32);
      this.btnCancel.TabIndex = 6;
      this.btnCancel.Text = "Odustani";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // frmEditPerson
      // 
      this.AcceptButton = this.btnSave;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(426, 231);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.txtNote);
      this.Controls.Add(this.lblNote);
      this.Controls.Add(this.chkActive);
      this.Controls.Add(this.txtName);
      this.Controls.Add(this.lblName);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmEditPerson";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Čovjek";
      this.Load += new System.EventHandler(this.frmEditPerson_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblName;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.CheckBox chkActive;
    private System.Windows.Forms.Label lblNote;
    private System.Windows.Forms.RichTextBox txtNote;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnCancel;
  }
}