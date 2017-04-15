using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bazga
{
  public partial class frmBazga : Form
  {
    private Database _currentDatabase = null;
    private Database CurrentDatabase
    {
      get { return _currentDatabase; }
      set
      {
        mnuSaveDatabase.Enabled = mnuSaveDatabaseAs.Enabled = pnlDatabase.Enabled = value != null;
        _currentDatabase = value;
        LoadGUI();
      }
    }

    public frmBazga()
    {
      InitializeComponent();
    }

    private void NewDatabase()
    {
      if (!CheckChanged()) return;
      CurrentDatabase = new Database();
    }

    private void OpenDatabase()
    {
      if (!CheckChanged()) return;

      OpenFileDialog dlg = new OpenFileDialog();
      dlg.Filter = Database.FILE_FILTER;
      dlg.InitialDirectory = GetDatabaseInitialDirectory();
      DialogResult res = dlg.ShowDialog(this);
      if (res == DialogResult.OK)
      {
        CurrentDatabase = Database.Load(dlg.FileName);
      }
    }

    private void SaveDatabase()
    {
      if (CurrentDatabase == null) throw new Exception("Baza nije otvorena");
      if (string.IsNullOrEmpty(CurrentDatabase.Path)) SaveDatabaseAs();
      else CurrentDatabase.Save();
    }

    private void SaveDatabaseAs()
    {
      SaveFileDialog dlg = new SaveFileDialog();
      dlg.Filter = Database.FILE_FILTER;
      dlg.InitialDirectory = GetDatabaseInitialDirectory();
      DialogResult res = dlg.ShowDialog(this);
      if (res == DialogResult.OK)
      {
        CurrentDatabase.Path = dlg.FileName;
        CurrentDatabase.Save();
      }
    }

    private bool CheckChanged()
    {
      if (CurrentDatabase != null && CurrentDatabase.Changed)
      {
        DialogResult dlgRes = MsgBox.Show(this, "Trenutno otvorena baza nije spremljena. Spremiti sad?", "Pažnja", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
        if (dlgRes == DialogResult.Cancel) return false;
        else if (dlgRes == DialogResult.No) return true;
        else
        {
          SaveDatabase();
          return true;
        }
      }

      return true;
    }

    private void LoadGUI()
    {
      lblDatabasePath.Text = CurrentDatabase != null && !string.IsNullOrEmpty(CurrentDatabase.Path) ? CurrentDatabase.Path : "";
    }

    private string GetDatabaseInitialDirectory()
    {
      string ret = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
      if (!string.IsNullOrEmpty(Settings.Instance.LastAccessedDatabasePath)) ret = Path.GetDirectoryName(Settings.Instance.LastAccessedDatabasePath);
      return ret;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      this.Icon = Properties.Resources.BazgaGreen;
      trayIcon.Icon = Properties.Resources.BazgaGreen;
      trayIcon.Text = this.Text;

      try
      {
        Settings.Load();
        if (Settings.Instance.LastFormLocation.HasValue) this.Location = Settings.Instance.LastFormLocation.Value;
        if (Settings.Instance.LastFormSize.HasValue) this.Size = Settings.Instance.LastFormSize.Value;
      }
      catch (Exception ex)
      {
        MsgBox.Show(ex);
        Program.ExitProperly();
      }
    }

    private void frmBazga_FormClosed(object sender, FormClosedEventArgs e)
    {
      try
      {
        Settings.Instance.LastFormLocation = this.Location;
        Settings.Instance.LastFormSize = this.Size;
        Settings.Save();
      }
      catch (Exception ex)
      {
        MsgBox.Show(ex);
      }
    }

    private void mnuExitTray_Click(object sender, EventArgs e)
    {
      Program.ExitProperly();
    }

    private void frmBazga_Shown(object sender, EventArgs e)
    {
      if (Settings.Instance.HideOnStartup) this.Hide();

      if (!string.IsNullOrEmpty(Settings.Instance.LastAccessedDatabasePath))
      {
        try
        {
          CurrentDatabase = Database.Load(Settings.Instance.LastAccessedDatabasePath);
        }
        catch (Exception ex)
        {
          Settings.Instance.LastAccessedDatabasePath = null;
          Settings.Save();
          this.Show();
          MsgBox.Show(this, string.Format("Greška kod otvaranja prošle baze\r\n{0}", ex.Message), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }

    private void frmBazga_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (!Program.Exitting)
      {
        this.Hide();
        e.Cancel = true;
      }
    }

    private void trayIcon_MouseUp(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        this.Show();
        this.Activate();
      }
    }

    private void mnuSettings_Click(object sender, EventArgs e)
    {
      frmSettings frm = new frmSettings();
      frm.ShowDialog(this);
    }

    private void mnuNewDatabase_Click(object sender, EventArgs e)
    {
      try
      {
        NewDatabase();
      }
      catch (Exception ex)
      {
        MsgBox.Show(ex);
      }
    }

    private void mnuOpenDatabase_Click(object sender, EventArgs e)
    {
      try
      {
        OpenDatabase();
      }
      catch (Exception ex)
      {
        MsgBox.Show(ex);
      }
    }

    private void mnuSaveDatabase_Click(object sender, EventArgs e)
    {
      try
      {
        SaveDatabase();
      }
      catch (Exception ex)
      {
        MsgBox.Show(ex);
      }
    }

    private void mnuSaveDatabaseAs_Click(object sender, EventArgs e)
    {
      try
      {
        SaveDatabaseAs();
        LoadGUI();
      }
      catch (Exception ex)
      {
        MsgBox.Show(ex);
      }
    }
  }
}
