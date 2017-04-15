using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bazga
{
  public class Transaction
  {
    public DateTime Date;
    public int Amount;
    public int OldBalance;
    public int NewBalance;
    public string Description;
  }
}
