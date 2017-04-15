using System;
using System.Collections.Generic;
using System.Data;
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
    public string Note;

    public List<Transaction> Transactions = new List<Transaction>();

    public DataTable GetTransactionTable()
    {
      DataTable table = new DataTable();

      table.TableName = "Transactions";
      table.Columns.Add("Date", typeof(DateTime));
      table.Columns.Add("Amount", typeof(int));
      table.Columns.Add("OldBalance", typeof(int));
      table.Columns.Add("NewBalance", typeof(int));
      table.Columns.Add("Description", typeof(int));
      table.Columns.Add("TransactionObject", typeof(Transaction));

      foreach (Transaction tran in Transactions)
      {
        DataRow row = table.NewRow();
        row["Date"] = tran.Date;
        row["Amount"] = tran.Amount;
        row["OldBalance"] = tran.OldBalance;
        row["NewBalance"] = tran.NewBalance;
        if (tran.Description != null) row["Description"] = tran.Description;
        else row["Description"] = DBNull.Value;
        row["TransactionObject"] = tran;
        table.Rows.Add(row);
      }

      return table;
    }

    public bool HasEatenToday()
    {
      DateTime start = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);

      foreach (Transaction tran in Transactions)
      {
        if (DateTime.Compare(tran.Date, start) > 0 && tran.Amount < 0) return true;
      }
      return false;
    }
  }
}
