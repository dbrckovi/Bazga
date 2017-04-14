using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bazga
{
  public partial class frmBazga : Form
  {
    private Database CurrentDatabase = null;

    public frmBazga()
    {
      InitializeComponent();
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
  }
}
