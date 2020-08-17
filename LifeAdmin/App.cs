
using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using LifeAdmin.Data.Profile.Data;
using LifeAdmin.Data.ApplicationState;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;
using Microsoft.AspNetCore.Components;


namespace LifeAdmin
{
  public partial class App
  {

    string yaml;

    private string Example {get; set;}

    [Inject]
    private HttpClient Http { get; set; }
    
    protected override async Task OnInitializedAsync()
    {
  

      var deserializer = new DeserializerBuilder()
        .WithNamingConvention(CamelCaseNamingConvention.Instance)
        .Build();
        
      yaml = await Http.GetStringAsync("yaml/root/data.yaml");

      var data = deserializer.Deserialize<Dictionary<string, object>>(yaml);
        Example =(string) data["example"];
    }

  }
}
