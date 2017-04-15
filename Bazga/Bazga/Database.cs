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

    public string Path;
    public string Password;
    public bool Changed = false;

    public List<Person> Persons = new List<Person>();

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
  }
}
