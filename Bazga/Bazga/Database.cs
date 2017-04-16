using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace Bazga
{
  public class Database
  {
    public const string FILE_FILTER = "Bazga baze|*.bazga";
    public const string FILE_EXTENSION = ".bazga";

    private bool _changed = false;

    public string Path;
    public string Password;
    public List<Person> Persons = new List<Person>();
    public List<Link> Links = new List<Link>();
    
    public bool Changed
    {
      get
      {
        return _changed;
      }
      set
      {
        if (value != _changed)
        {
          _changed = value;
          OnDataChanged();
        }
      }
    }

    public event Delegates.VoidDelegate DataChanged;
    private void OnDataChanged()
    {
      if (DataChanged != null) DataChanged();
    }

    public event Delegates.IntDelegate PersonAdded;
    private void OnPersonAdded(int id)
    {
      if (PersonAdded != null) PersonAdded(id);
    }

    public event Delegates.IntDelegate PersonChanged;
    private void OnPersonChanged(int id)
    {
      if (PersonChanged != null) PersonChanged(id);
    }

    public event Delegates.VoidDelegate LinksChanged;
    private void OnLinksChanged()
    {
      if (LinksChanged != null) LinksChanged();
    }

    /// <summary>
    /// Saves personal data to the database
    /// </summary>
    /// <param name="id">Id of the existing person, or null for creating new person</param>
    /// <param name="name">Name of the person</param>
    /// <param name="note">Person's note</param>
    /// <param name="active">Is person active</param>
    public void SavePerson(int? id, string name, string note, bool active)
    {
      Person person = null;
      bool added = false;

      #region Create or load person
      if (id.HasValue)
      {
        foreach (Person existing in Persons)
        {
          if (existing.ID == id.Value)
          {
            person = existing;
            break;
          }
        }
      }
      else
      {
        person = new Person();
        person.ID = Persons.Count;
        Persons.Add(person);
        added = true;
      }
      #endregion Create or load person

      if (person == null) throw new Exception("Person is null");

      person.Name = name;
      person.Note = note;
      person.Active = active;

      if (added) OnPersonAdded(person.ID);
      else OnPersonChanged(person.ID);

      Changed = true;
    }

    public void NewTransaction(int id, int amount)
    {
      Person person = FindPerson(id);
      
      Transaction trans = new Transaction();
      trans.Amount = amount;
      trans.Date = DateTime.Now;
      trans.OldBalance = person.Balance;
      trans.NewBalance = person.Balance = person.Balance + amount;
      person.Transactions.Add(trans);

      OnPersonChanged(id);
      Changed = true;
    }

    /// <summary>
    /// Saves link and raises events. Needs to be called even if the change is made on the actual object which is already in the list
    /// </summary>
    /// <param name="link"></param>
    public void SaveLink(Link link)
    {
      if (!Links.Contains(link))
      {
        Links.Add(link);
      }

      OnLinksChanged();
      Changed = true;
    }

    public void RemoveLink(Link link)
    {
      if (Links.Contains(link))
      {
        Links.Remove(link);
        OnLinksChanged();
        Changed = true;
      }
    }

    public void NotifyLinksChanged()
    {
      OnLinksChanged();
      Changed = true;
    }

    /// <summary>
    /// Returns person with specified ID. Or null
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public Person FindPerson(int id)
    {
      foreach (Person person in Persons)
      {
        if (person.ID == id) return person;
      }

      return null;
    }

    #region Save / Load
    public void Save()
    {
      string json = JsonConvert.SerializeObject(this);
      using (StreamWriter sw = File.CreateText(Path))
      {
        sw.Write(json);
      }
      Changed = false;

      Settings.Instance.LastAccessedDatabasePath = Path;
      Settings.Save();
    }

    public static Database Load(string path)
    {
      string json;
      using (StreamReader sr = File.OpenText(path))
      {
        json = sr.ReadToEnd();
      }

      Database ret = JsonConvert.DeserializeObject<Database>(json);
      ret.Changed = false;
      ret.Path = path;

      Settings.Instance.LastAccessedDatabasePath = path;
      Settings.Save();
      return ret;
    }
    #endregion Save / Load
  }
}
