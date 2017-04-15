using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bazga
{
  public class Person
  {
    public int ID;
    public string Name;
    public bool Active;
    public int Balance;

    public List<Transaction> Transactions = new List<Transaction>();
  }
}
