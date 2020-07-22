using System.Collections.Generic;

namespace LifeAdmin.Data.Profile.Data.Finance
{
  public class ExpenseItem
  {
    public float Price { get; set; }
    public float Quantity { get; set; }
    public string Store { get; set; }

    public int Calories { get; set; }

    public string GroceryId { get; set; }
  }

  public class Expenses
  {
    public List<ExpenseItem> ExpenseItems { get; set; }
  }

}