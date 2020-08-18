using System.Collections.Generic;

namespace PDA.Data.Profile.Data
{
  public class MealItem
  {
    public int Day { get; set; } = 1;
    public string GroceryId { get; set; } = "grocery_id";
  }
  public class MealPlanner
  {
    public List<MealItem> MealItems { get; set; } = new List<MealItem>();
  }

}