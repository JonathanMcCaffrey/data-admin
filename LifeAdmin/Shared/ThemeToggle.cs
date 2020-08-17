

using System;
using System.Net.Http;
using Microsoft.AspNetCore.Components;
using MatBlazor;
using LifeAdmin.Data.UI.Nav;
using System.Threading.Tasks;
using LifeAdmin.Data.ApplicationState;


namespace LifeAdmin.Shared
{

  public partial class ThemeToggle : ComponentBase
  {
    [Inject]
    private ApplicationState ApplicationState { get; set; }


    private void OnToggleTheme()
    {
      ApplicationState.ToggleTheme();
    }
    
  }
}
