using System.Collections.Generic;

namespace LifeAdmin.Data.Profile.Data
{
  public class Food
  {
    public Grocery Grocery { get; set; } = new Grocery();
    public MealPlanner MealPlanner { get; set; } = new MealPlanner();
    public Nutrition Nutrition { get; set; } = new Nutrition();

  }



}