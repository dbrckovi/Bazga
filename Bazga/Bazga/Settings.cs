using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.IO;
using System.Drawing;

namespace Bazga
{
  public class Settings
  {
    public string DefaultDatabasePath;
    public int TransactionLifetimeDays = 30;
    public Size? LastFormSize;
    public Point? LastFormLocation;
    public bool HideOnStartup = false;

    #region Instance
    private static Settings _instance;
    public static Settings Instance
    {
      get { return _instance; }
    }
    #endregion Instance

    #region Load / Save
    public static void Load()
    {
      if (!File.Exists(Program.SettingsPath))
      {
        try
        {
          Directory.CreateDirectory(Path.GetDirectoryName(Program.SettingsPath));
          _instance = new Settings();
          Save();
        }
        catch (Exception ex)
        {
          throw new Exception("Ne mogu kreirati postavke\r\n" + ex.Message);
        }
      }
      else
      {
        try
        {
          string json;
          using (StreamReader sr = File.OpenText(Program.SettingsPath))
          {
            json = sr.ReadToEnd();
          }
          _instance = Deserialize(json);
        }
        catch (Exception ex)
        {
          throw new Exception("Ne mogu otvoriti postavke\r\n" + ex.Message);
        }
      }
    }

    public static void Save()
    {
      try
      {
        string json = _instance.Serialize();
        using (StreamWriter sw = File.CreateText(Program.SettingsPath))
        {
          sw.Write(json);
        }
      }
      catch (Exception ex)
      {
        throw new Exception("Ne mogu spremiti postavke\r\n" + ex.Message);
      }
    }
    #endregion Load / Save

    #region Serialization
    private string Serialize()
    {
      return JsonConvert.SerializeObject(this);
    }

    private static Settings Deserialize(string json)
    {
      return JsonConvert.DeserializeObject<Settings>(json);
    }
    #endregion Serialization
  }
}
