﻿
using System;
using System.Net.Http;
using Microsoft.AspNetCore.Components;
using MatBlazor;
using PDA.Data.UI.Nav;
using System.Threading.Tasks;


namespace PDA.Shared
{

  public partial class NavMenu : ComponentBase
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
