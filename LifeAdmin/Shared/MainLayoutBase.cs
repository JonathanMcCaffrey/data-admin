
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
using LifeAdmin.Data.ApplicationState;


namespace LifeAdmin.Shared
{
  public class MainLayoutBase :  LayoutComponentBase 
  {

    [Inject]
    protected ApplicationState ApplicationState { get; set; }

    [Inject]
    public ProfileData ProfileData { get; set; }


    private static MatTheme darkTheme = new MatTheme() 
    {

      Primary = MatThemeColors.Grey._800.Value,
      OnPrimary = MatThemeColors.Grey._100.Value,
      Secondary = MatThemeColors.Grey._800.Value,
      OnSecondary = MatThemeColors.Grey._100.Value,
      Surface = MatThemeColors.Grey._900.Value,
      OnSurface = MatThemeColors.Grey._100.Value,

    };

    private static MatTheme lightTheme = new MatTheme() 
    {

      Primary = MatThemeColors.Grey._200.Value,
      OnPrimary = MatThemeColors.Grey._900.Value,
      Secondary = MatThemeColors.Grey._200.Value,
      OnSecondary = MatThemeColors.Grey._900.Value,
      Surface = MatThemeColors.Grey._100.Value,
      OnSurface = MatThemeColors.Grey._900.Value,

    };

    protected MatTheme laTheme = darkTheme; 

    public override async Task SetParametersAsync(ParameterView parameters)
    {
      laTheme = ApplicationState.IsDarkTheme ? darkTheme : lightTheme;
    
      await base.SetParametersAsync(parameters);
    }

    protected override bool ShouldRender()
    {
      laTheme = ApplicationState.IsDarkTheme ? darkTheme : lightTheme;
   
      return true;
    }

    protected override void OnInitialized()
    {


      ProfileData.Food.Grocery.GroceryItems.Add(new GroceryItem());
      ProfileData.Food.MealPlanner.MealItems.Add(new MealItem());

      ProfileData.OnChange += StateHasChanged;

      ApplicationState.OnChange += StateHasChanged;
    }


    public void Dispose()
    {
      ProfileData.OnChange -= StateHasChanged;
      ApplicationState.OnChange -= StateHasChanged;
    }


  }
}
