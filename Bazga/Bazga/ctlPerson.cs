using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bazga
{
  public partial class ctlPerson : UserControl
  {
    private readonly Color COLOR_SELECTED = Color.LightBlue;
    private readonly Color COLOR_NORMAL = SystemColors.Control;

    private readonly Color COLOR_BALANCE_GOOD = SystemColors.ControlText;
    private readonly Color COLOR_BALANCE_BAD = Color.Red;

    private bool _selected = false;
    private int _id;
    private int _balance;
    private bool _eatenToday = false;

    public int ID
    {
      get { return _id; }
      set { _id = value; }
    }

    public string PersonName
    {
      get { return lblName.Text; }
      set { lblName.Text = value; }
    }

    public int Balance
    {
      get { return _balance; }
      set
      {
        _balance = value;
        lblBalance.Text = _balance.ToString();
        lblBalance.ForeColor = _balance >= 0 ? COLOR_BALANCE_GOOD : COLOR_BALANCE_BAD;
      }
    }

    public bool Selected
    {
      get { return _selected; }
      set
      {
        _selected = value;
        lblName.BackColor = lblBalance.BackColor = _selected ? COLOR_SELECTED : COLOR_NORMAL;
      }
    }

    public bool EatenToday
    {
      get { return _eatenToday; }
      set
      {
        _eatenToday = value;
        if (_eatenToday) picEatenToday.Image = Properties.Resources.DanasJeo;
        else picEatenToday.Image = null;
      }
    }

    public event Delegates.IntDelegate TransactionSubmitted;
    private void OnTransactionSubmitted(int value)
    {
      if (TransactionSubmitted != null) TransactionSubmitted(value);
    }

    public ctlPerson()
    {
      InitializeComponent();
    }

    private void ProcessTransaction()
    {
      string strValue = txtTransaction.Text.Trim();
      if (string.IsNullOrEmpty(strValue)) return;

      int value = 0;
      if (!int.TryParse(strValue, out value)) throw new Exception("Upiši pozitivan ili negativan cijeli broj");
      OnTransactionSubmitted(value);
      txtTransaction.Text = "";
    }

    private void lbl_Click(object sender, EventArgs e)
    {
      txtTransaction.Focus();
    }

    private void txtTransaction_Leave(object sender, EventArgs e)
    {
      txtTransaction.Text = "";
    }

    private void txtTransaction_KeyPress(object sender, KeyPressEventArgs e)
    {
      try
      {
        if (e.KeyChar == (char)Keys.Enter)
        {
          ProcessTransaction();
          e.Handled = true;
        }
      }
      catch (Exception ex)
      {
        MsgBox.Show(ex);
      }
    }
  }
}
