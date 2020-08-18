using System.Collections.Generic;

namespace PDA.Data.Profile.Data
{
  public class GroceryItem
  {
    public float Price { get; set; } = 2.99f;
    public float Quantity { get; set; } = 1.5f;
    public string Store { get; set; } = "example_store";

    public int Calories { get; set; } = 1;

    public string GroceryId { get; set; } = "example_id";
  }

  public class Grocery
  {
    public List<GroceryItem> GroceryItems { get; set; } = new List<GroceryItem>();
  }

}