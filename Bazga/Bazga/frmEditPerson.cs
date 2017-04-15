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
  public partial class frmEditPerson : Form
  {
    public Database Database;
    public int? ID;

    public frmEditPerson()
    {
      InitializeComponent();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      try
      {
        Database.SavePerson(ID, txtName.Text, txtNote.Text, chkActive.Checked);
        this.DialogResult = DialogResult.OK;
        this.Close();
      }
      catch (Exception ex)
      {
        MsgBox.Show(ex);
      }
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.Cancel;
      this.Close();
    }

    private void frmEditPerson_Load(object sender, EventArgs e)
    {
      if (ID.HasValue)
      {
        Person person = Database.FindPerson(ID.Value);
        txtName.Text = person.Name;
        txtNote.Text = person.Note;
        chkActive.Checked = person.Active;
      }
    }
  }
}
