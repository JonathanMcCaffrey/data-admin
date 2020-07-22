
using System;
using System.Net.Http;
using Microsoft.AspNetCore.Components;
using MatBlazor;
using LifeAdmin.Data.UI.Nav;
using System.Threading.Tasks;
using LifeAdmin.Data.Profile.Data;


using System.Text.Json;
using System.Reflection;
using Microsoft.JSInterop;
using BlazorInputFile;


namespace LifeAdmin.Shared
{
  public class MainLayoutBase : LayoutComponentBase
  {


    [Inject]
    public ProfileData ProfileData { get; set; }

    protected MatTheme laTheme = new MatTheme()
    {
      Primary = MatThemeColors.Grey._900.Value,
      Secondary = MatThemeColors.Green._900.Value,
    };


    protected override void OnInitialized()
    {


      ProfileData.Food.Grocery.GroceryItems.Add(new GroceryItem());
      ProfileData.Food.MealPlanner.MealItems.Add(new MealItem());

      ProfileData.OnChange += StateHasChanged;

    }


    public void Dispose()
    {
      ProfileData.OnChange -= StateHasChanged;
    }


  }
}