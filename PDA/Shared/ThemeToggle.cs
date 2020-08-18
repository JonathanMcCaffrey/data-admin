

using System;
using System.Net.Http;
using Microsoft.AspNetCore.Components;
using MatBlazor;
using PDA.Data.UI.Nav;
using System.Threading.Tasks;
using PDA.Data.ApplicationState;


namespace PDA.Shared
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
