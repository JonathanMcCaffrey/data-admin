
using System;
using System.Net.Http;
using Microsoft.AspNetCore.Components;
using MatBlazor;
using LifeAdmin.Data.UI.Nav;
using System.Threading.Tasks;


namespace LifeAdmin.Shared
{

  public class NavMenuBase : ComponentBase
  {

    protected bool MultiChecked { get; set; }
    protected MatNavMenu navMenu;

    [Inject]
    private HttpClient Http { get; set; }

    protected NavData NavData { get; set; }

    protected override async Task OnInitializedAsync()
    {
      NavData = await Http.GetJsonAsync<NavData>("json/navbar/data.json");
    }
  }
}