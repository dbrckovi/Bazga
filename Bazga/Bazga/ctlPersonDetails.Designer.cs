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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      this.lblName = new System.Windows.Forms.Label();
      this.lblNote = new System.Windows.Forms.Label();
      this.txtNote = new System.Windows.Forms.RichTextBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.lblBalance = new System.Windows.Forms.Label();
      this.dataTransactions = new System.Windows.Forms.DataGridView();
      this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colOldBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colNewBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colTransactionObject = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataTransactions)).BeginInit();
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
      this.txtNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.txtNote.Location = new System.Drawing.Point(0, 328);
      this.txtNote.Name = "txtNote";
      this.txtNote.ReadOnly = true;
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
      this.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // dataTransactions
      // 
      this.dataTransactions.AllowUserToAddRows = false;
      this.dataTransactions.AllowUserToDeleteRows = false;
      this.dataTransactions.AllowUserToResizeColumns = false;
      this.dataTransactions.AllowUserToResizeRows = false;
      this.dataTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dataTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.dataTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDate,
            this.colAmount,
            this.colOldBalance,
            this.colNewBalance,
            this.colDescription,
            this.colTransactionObject});
      this.dataTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataTransactions.Location = new System.Drawing.Point(0, 32);
      this.dataTransactions.MultiSelect = false;
      this.dataTransactions.Name = "dataTransactions";
      this.dataTransactions.ReadOnly = true;
      this.dataTransactions.RowHeadersVisible = false;
      this.dataTransactions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.dataTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataTransactions.ShowEditingIcon = false;
      this.dataTransactions.Size = new System.Drawing.Size(468, 280);
      this.dataTransactions.TabIndex = 4;
      // 
      // colDate
      // 
      this.colDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.colDate.DataPropertyName = "Date";
      dataGridViewCellStyle3.Format = "G";
      dataGridViewCellStyle3.NullValue = null;
      this.colDate.DefaultCellStyle = dataGridViewCellStyle3;
      this.colDate.FillWeight = 126.9036F;
      this.colDate.HeaderText = "Datum";
      this.colDate.Name = "colDate";
      this.colDate.ReadOnly = true;
      this.colDate.Width = 63;
      // 
      // colAmount
      // 
      this.colAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.colAmount.DataPropertyName = "Amount";
      this.colAmount.FillWeight = 93.27411F;
      this.colAmount.HeaderText = "Uplata";
      this.colAmount.Name = "colAmount";
      this.colAmount.ReadOnly = true;
      this.colAmount.Width = 63;
      // 
      // colOldBalance
      // 
      this.colOldBalance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.colOldBalance.DataPropertyName = "OldBalance";
      this.colOldBalance.FillWeight = 93.27411F;
      this.colOldBalance.HeaderText = "Staro stanje";
      this.colOldBalance.Name = "colOldBalance";
      this.colOldBalance.ReadOnly = true;
      this.colOldBalance.Width = 88;
      // 
      // colNewBalance
      // 
      this.colNewBalance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.colNewBalance.DataPropertyName = "NewBalance";
      this.colNewBalance.FillWeight = 93.27411F;
      this.colNewBalance.HeaderText = "Novo stanje";
      this.colNewBalance.Name = "colNewBalance";
      this.colNewBalance.ReadOnly = true;
      this.colNewBalance.Width = 89;
      // 
      // colDescription
      // 
      this.colDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.colDescription.DataPropertyName = "Description";
      this.colDescription.FillWeight = 93.27411F;
      this.colDescription.HeaderText = "Opis transakcije";
      this.colDescription.Name = "colDescription";
      this.colDescription.ReadOnly = true;
      // 
      // colTransactionObject
      // 
      this.colTransactionObject.DataPropertyName = "TransactionObject";
      this.colTransactionObject.HeaderText = "TransactionObject";
      this.colTransactionObject.Name = "colTransactionObject";
      this.colTransactionObject.ReadOnly = true;
      this.colTransactionObject.Visible = false;
      // 
      // ctlPersonDetails
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.dataTransactions);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.lblNote);
      this.Controls.Add(this.txtNote);
      this.Name = "ctlPersonDetails";
      this.Size = new System.Drawing.Size(468, 421);
      this.Load += new System.EventHandler(this.ctlPersonDetails_Load);
      this.panel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataTransactions)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label lblName;
    private System.Windows.Forms.Label lblNote;
    private System.Windows.Forms.RichTextBox txtNote;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label lblBalance;
    private System.Windows.Forms.DataGridView dataTransactions;
    private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
    private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
    private System.Windows.Forms.DataGridViewTextBoxColumn colOldBalance;
    private System.Windows.Forms.DataGridViewTextBoxColumn colNewBalance;
    private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
    private System.Windows.Forms.DataGridViewTextBoxColumn colTransactionObject;
  }
}
