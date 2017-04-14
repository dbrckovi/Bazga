using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Bazga
{
  static class Program
  {
    public static readonly string SettingsPath = string.Format("{0}\\Bazga\\Settings.ini", Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData));
    public static bool DesignTime = true;
    public static bool Exitting = false;

    #region Main
    [STAThread]
    static void Main()
    {
      DesignTime = false;
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new frmBazga());
    }
    #endregion Main

    public static void ExitProperly()
    {
      Exitting = true;
      Application.Exit();
    }
  }
}
