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
  public partial class ctlPersonList : UserControl
  {
    private int? _selectedPersonID = null;
    private Database _database = null;
    private bool? _activeFilter = true;

    public Database Database
    {
      get { return _database; }
      set
      {
        _database = value;
        RefreshList();
      }
    }

    public bool? ActiveFilter
    {
      get { return _activeFilter; }
      set
      {
        if (value != _activeFilter)
        {
          _activeFilter = value;
          RefreshList();
        }
      }
    }

    public int? SelectedPersonID
    {
      get { return _selectedPersonID; }
      set
      {
        if (value == _selectedPersonID) return;

        if (_selectedPersonID.HasValue)
        {
          ctlPerson control = FindPersonControl(_selectedPersonID.Value);
          if (control != null) control.Selected = false;
        }

        _selectedPersonID = value;

        if (_selectedPersonID.HasValue)
        {
          ctlPerson control = FindPersonControl(_selectedPersonID.Value);
          if (control != null) control.Selected = true;
        }        

        OnSelectionChanged();
      }
    }

    public event Delegates.VoidDelegate SelectionChanged;
    private void OnSelectionChanged()
    {
      if (SelectionChanged != null) SelectionChanged();
    }

    public ctlPersonList()
    {
      InitializeComponent();
    }

    /// <summary>
    /// Loads all persons from the specified database
    /// (missing persons are added. Extra persons are removed)
    /// </summary>
    /// <param name="database"></param>
    public void RefreshList()
    {
      List<Person> personList = new List<Person>();

      List<ctlPerson> addList = new List<ctlPerson>();
      List<ctlPerson> removeList = new List<ctlPerson>();

      #region Construct GUI person list
      //construct a list of persons which will be shown on GUI
      if (_database != null)
      {
        foreach (Person person in _database.Persons)
        {
          if ((_activeFilter.HasValue && _activeFilter.Value == person.Active) || !_activeFilter.HasValue)
          {
            personList.Add(person);
          }
        }
      }
      #endregion Construct GUI person list

      #region Add missing & refresh existing
      foreach (Person person in personList)
      {
        ctlPerson control = FindPersonControl(person.ID);

        if (control == null)
        {
          control = new ctlPerson();
          control.ID = person.ID;
          control.Dock = DockStyle.Top;
          addList.Add(control);  
        }

        control.PersonName = person.Name;
        control.Balance = person.Balance;
        control.EatenToday = person.HasEatenToday();
      }
      #endregion Add missing & refresh existing

      #region Remove extra
      foreach (ctlPerson ctl in pnlContainer.Controls)
      {
        bool exists = false;

        foreach (Person person in personList)
        {
          if (person.ID == ctl.ID)
          {
            exists = true;
            break;
          }
        }

        if (!exists)
        {
          removeList.Add(ctl);
        }
      }
      #endregion Remove extra

      foreach (ctlPerson ctl in removeList)
      {
        if (_selectedPersonID == ctl.ID) SelectedPersonID = null;
        pnlContainer.Controls.Remove(ctl);
        ctl.Enter -= ctl_Enter;
        ctl.TransactionSubmitted -= ctl_TransactionSubmitted;
      }

      foreach (ctlPerson ctl in addList)
      {
        pnlContainer.Controls.Add(ctl);
        ctl.BringToFront();
        ctl.Enter += ctl_Enter;
        ctl.TransactionSubmitted += ctl_TransactionSubmitted;
      }
    }

    private void ctl_TransactionSubmitted(int value)
    {
      Database.NewTransaction(SelectedPersonID.Value, value);
    }

    private ctlPerson FindPersonControl(long id)
    {
      foreach (ctlPerson ctl in pnlContainer.Controls)
      {
        if (ctl.ID == id) return ctl;
      }

      return null;
    }

    private void ctl_Enter(object sender, EventArgs e)
    {
      ctlPerson per = (ctlPerson)sender;
      SelectedPersonID = per.ID;
    }
  }
}
