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
  public partial class frmLinkEditor : Form
  {
    public Database Database = null;

    public frmLinkEditor()
    {
      InitializeComponent();
      dataLinks.AutoGenerateColumns = false;
    }

    private void frmLinkEditor_Load(object sender, EventArgs e)
    {
      if (Database != null)
      {
        DataTable table = new DataTable();
        table.TableName = "Links";
        table.Columns.Add("Name", typeof(string));
        table.Columns.Add("URL", typeof(string));

        foreach (Link link in Database.Links)
        {
          DataRow row = table.NewRow();
          row["Name"] = link.Name;
          row["URL"] = link.URL;
          table.Rows.Add(row);
        }

        dataLinks.DataSource = table;
      }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      Database.Links.Clear();

      foreach (DataGridViewRow row in dataLinks.Rows)
      {
        if (row.Cells["colName"].Value != null || row.Cells["colURL"].Value != null)
        {
          Link lnk = new Link();
          if (row.Cells["colName"].Value != DBNull.Value) lnk.Name = (string)row.Cells["colName"].Value;
          if (row.Cells["colURL"].Value != DBNull.Value) lnk.URL = (string)row.Cells["colURL"].Value;
          Database.Links.Add(lnk);
        }
      }

      Database.NotifyLinksChanged();

      this.DialogResult = DialogResult.OK;
      this.Close();
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.Cancel;
      this.Close();
    }
  }
}
