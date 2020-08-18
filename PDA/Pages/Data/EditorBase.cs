
using System;
using System.Net.Http;
using Microsoft.AspNetCore.Components;
using PDA.Data.UI.Nav;
using System.Threading.Tasks;
using PDA.Data.Profile.Data;
using System.Text.Json;
using System.IO;
using System.Reflection;
using Microsoft.JSInterop;
using BlazorInputFile;

namespace PDA.Pages.Data
{
  public class EditorBase : ComponentBase
  {

    [Inject]
    public ProfileData ProfileData { get; set; }

    public string ChangeThisValueTwo = "213";
    public void UpdateChangeTheValue()
    {
      ProfileData.SetText("Test");


    }


    [Inject]
    private IJSRuntime JSRuntime { get; set; }

    public string JSONString { get; set; } = "blank";

    public string FoundValues { get; set; } = "";
    protected string UploadedProfileDataPath { get; set; }

    protected string UploadedProfileData { get; set; }


    protected string T1 = "";
    protected string T2 = "";
    protected string T3 = "";
    protected async Task HandleFileSelected(IFileListEntry[] files)
    {
      if (files == null || files.Length == 0)
      {
        return;
      }

      var file = files[0];

      UploadedProfileData = "";

      using (var reader = new System.IO.StreamReader(file.Data))
      {
        var line = await reader.ReadLineAsync();

        while (line != null)
        {
          UploadedProfileData += line;

          line = await reader.ReadLineAsync();
        }
      }
    }
    protected override void OnInitialized()
    {



      JSONString = JsonSerializer.Serialize(ProfileData);

      /*
            var type = ProfileData.GetType();

            PropertyInfo[] properties = typeof(ProfileData).GetProperties();
            foreach (PropertyInfo property in properties)
            {
              FoundValues += property.Name + " " + property.PropertyType;

              var ProfileDataType = typeof(ProfileData);

              PropertyInfo propInfo = ProfileDataType.GetProperty(property.Name);
            }*/
    }
  }
}