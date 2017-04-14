using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bazga
{
  public static class MsgBox
  {

    public static DialogResult Show(string text)
    {
      return Show(null, text, "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    public static DialogResult Show(string text, string caption)
    {
       return Show(null, text, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    public static DialogResult Show(Exception ex)
    {
      return Show(null, ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    public static DialogResult Show(IWin32Window owner, string text)
    {
      return Show(owner, text, "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    public static DialogResult Show(IWin32Window owner, string text, string caption)
    {
       return Show(owner, text, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    public static DialogResult Show(IWin32Window owner, Exception ex)
    {
      return Show(owner, ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
    {
      return MessageBox.Show(owner, text, caption, buttons, icon);
    }
  }
}
