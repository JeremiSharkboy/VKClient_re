namespace VKClient.Common.Emoji
{
  public class PanelControlFocusedChangedEvent
  {
      public bool IsFocused { get; private set; }

    public PanelControlFocusedChangedEvent(bool isFocused)
    {
      this.IsFocused = isFocused;
    }
  }
}
