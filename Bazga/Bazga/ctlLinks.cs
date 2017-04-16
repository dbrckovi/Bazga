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
  public partial class ctlLinks : UserControl
  {
    private Database _database = null;

    public Database Database
    {
      get { return _database; }
      set
      {
        if (value != _database)
        {
          _database = value;
          RefreshGUI();
        }
      }
    }

    public ctlLinks()
    {
      InitializeComponent();
    }

    public void RefreshGUI()
    {
      btnEditLinks.Enabled = _database != null;

      foreach (LinkLabel lbl in pnlContainer.Controls)
      {
        lbl.MouseUp -= lbl_MouseUp;
      }
      pnlContainer.Controls.Clear();

      if (_database != null)
      {
        foreach (Link link in _database.Links)
        {
          LinkLabel lbl = new LinkLabel();
          lbl.Text = link.Name;
          lbl.Tag = link.URL;
          lbl.MouseUp += lbl_MouseUp;
          lbl.ContextMenuStrip = contextLink;
          pnlContainer.Controls.Add(lbl);
          lbl.BringToFront();
        }
      }
    }

    private void lbl_MouseUp(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        try
        {
          LinkLabel lbl = (LinkLabel)sender;
          string url = (string)lbl.Tag;
          System.Diagnostics.Process.Start(url);
        }
        catch (Exception ex)
        {
          MsgBox.Show(ex);
        }
      }
    }

    private void kopirajToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        ToolStripMenuItem menuItem = sender as ToolStripMenuItem;

        if (menuItem != null)
        {
          ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
          if (owner != null)
          {
            // Get the control that is displaying this context menu
            Control sourceControl = owner.SourceControl;
            Clipboard.SetText((string)sourceControl.Tag);
          }
        }
      }
      catch (Exception ex)
      {
        MsgBox.Show(ex);
      }
    }

    private void btnEditLinks_Click(object sender, EventArgs e)
    {
      frmLinkEditor frm = new frmLinkEditor();
      frm.Database = _database;
      frm.ShowDialog(this.ParentForm);
    }
  }
}
