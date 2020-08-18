namespace PDA.Data.Profile.Data
{
  public class ProfileData
  {
    public Food Food { get; set; } = new Food();

    public event System.Action OnChange;

    public string Text { get; set; }
    public void SetText(string text)
    {
      Text = text;
      NotifyStateChanged();
    }

    private void NotifyStateChanged() => OnChange?.Invoke();

  }

}

