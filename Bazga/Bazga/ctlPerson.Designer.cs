namespace Bazga
{
  partial class ctlPerson
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
      this.lblBalance = new System.Windows.Forms.Label();
      this.txtTransaction = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // lblName
      // 
      this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblName.Location = new System.Drawing.Point(0, 0);
      this.lblName.Name = "lblName";
      this.lblName.Size = new System.Drawing.Size(240, 22);
      this.lblName.TabIndex = 0;
      this.lblName.Text = "Person name";
      this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lblBalance
      // 
      this.lblBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lblBalance.Dock = System.Windows.Forms.DockStyle.Right;
      this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.lblBalance.Location = new System.Drawing.Point(240, 0);
      this.lblBalance.Name = "lblBalance";
      this.lblBalance.Size = new System.Drawing.Size(72, 22);
      this.lblBalance.TabIndex = 1;
      this.lblBalance.Text = "balance";
      this.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // txtTransaction
      // 
      this.txtTransaction.Dock = System.Windows.Forms.DockStyle.Right;
      this.txtTransaction.Location = new System.Drawing.Point(312, 0);
      this.txtTransaction.Name = "txtTransaction";
      this.txtTransaction.Size = new System.Drawing.Size(51, 20);
      this.txtTransaction.TabIndex = 2;
      // 
      // ctlPerson
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.lblName);
      this.Controls.Add(this.lblBalance);
      this.Controls.Add(this.txtTransaction);
      this.Name = "ctlPerson";
      this.Size = new System.Drawing.Size(363, 22);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblName;
    private System.Windows.Forms.Label lblBalance;
    private System.Windows.Forms.TextBox txtTransaction;
  }
}
