namespace Bazga
{
  partial class ctlPersonDetails
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
      this.lblName = new System.Windows.Forms.Label();
      this.lblNote = new System.Windows.Forms.Label();
      this.txtNote = new System.Windows.Forms.RichTextBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.lblBalance = new System.Windows.Forms.Label();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // lblName
      // 
      this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.lblName.Location = new System.Drawing.Point(0, 0);
      this.lblName.Name = "lblName";
      this.lblName.Size = new System.Drawing.Size(384, 32);
      this.lblName.TabIndex = 0;
      this.lblName.Text = "asda";
      this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lblNote
      // 
      this.lblNote.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.lblNote.Location = new System.Drawing.Point(0, 312);
      this.lblNote.Name = "lblNote";
      this.lblNote.Size = new System.Drawing.Size(468, 16);
      this.lblNote.TabIndex = 1;
      this.lblNote.Text = "Napomena";
      // 
      // txtNote
      // 
      this.txtNote.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.txtNote.Location = new System.Drawing.Point(0, 328);
      this.txtNote.Name = "txtNote";
      this.txtNote.Size = new System.Drawing.Size(468, 93);
      this.txtNote.TabIndex = 2;
      this.txtNote.Text = "";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.lblName);
      this.panel1.Controls.Add(this.lblBalance);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(468, 32);
      this.panel1.TabIndex = 3;
      // 
      // lblBalance
      // 
      this.lblBalance.Dock = System.Windows.Forms.DockStyle.Right;
      this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.lblBalance.Location = new System.Drawing.Point(384, 0);
      this.lblBalance.Name = "lblBalance";
      this.lblBalance.Size = new System.Drawing.Size(84, 32);
      this.lblBalance.TabIndex = 1;
      this.lblBalance.Text = "0";
      this.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridView1.Location = new System.Drawing.Point(0, 32);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(468, 280);
      this.dataGridView1.TabIndex = 4;
      // 
      // ctlPersonDetails
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.lblNote);
      this.Controls.Add(this.txtNote);
      this.Name = "ctlPersonDetails";
      this.Size = new System.Drawing.Size(468, 421);
      this.panel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label lblName;
    private System.Windows.Forms.Label lblNote;
    private System.Windows.Forms.RichTextBox txtNote;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label lblBalance;
    private System.Windows.Forms.DataGridView dataGridView1;
  }
}
