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
  public partial class ctlPersonDetails : UserControl
  {
    private int? _personID = null;
    private Database _database = null;

    public int? PersonID
    {
      get { return _personID; }
      set
      {
        if (value == _personID) return;
        _personID = value;
        ReloadGUI();
      }
    }

    public Database Database
    {
      get { return _database; }
      set
      {
        _database = value;
        ReloadGUI();
      }
    }

    public ctlPersonDetails()
    {
      InitializeComponent();
    }

    public void ReloadGUI()
    {
      if (_database != null && _personID.HasValue)
      {
        Person person = _database.FindPerson(_personID.Value);
        lblName.Text = person.Name;
        lblBalance.Text = person.Balance.ToString();
        dataTransactions.DataSource = person.GetTransactionTable();
        txtNote.Text = person.Note;

        if (dataTransactions.Rows.Count > 0)
        {
          dataTransactions.Rows[dataTransactions.Rows.Count - 1].Selected = true;
          dataTransactions.FirstDisplayedScrollingRowIndex = dataTransactions.Rows.Count - 1;
        }
      }
      else
      {
        lblName.Text = "";
        lblBalance.Text = "";
        dataTransactions.DataSource = null;
        txtNote.Text = "";
      }
    }

    private void ctlPersonDetails_Load(object sender, EventArgs e)
    {
      dataTransactions.AutoGenerateColumns = false;
    }
  }
}
