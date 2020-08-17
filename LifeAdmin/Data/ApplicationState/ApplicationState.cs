
namespace LifeAdmin.Data.ApplicationState
{
  public class ApplicationState
  {
    public bool IsDarkTheme {get; set;} = true;
    public bool IsDataLoaded {get; set;} = false;
    public bool IsDataEdited {get; set;} = false;

    public void ToggleTheme()
    {
      IsDarkTheme = !IsDarkTheme;
      NotifyStateChanged();
    }

    public event System.Action OnChange;
    private void NotifyStateChanged() => OnChange?.Invoke();
    }
}

