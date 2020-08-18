
using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using PDA.Data.Profile.Data;
using PDA.Data.ApplicationState;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;
using Microsoft.AspNetCore.Components;


namespace PDA
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
