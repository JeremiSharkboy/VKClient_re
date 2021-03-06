using System;
using System.Windows;
using VKClient.Common.Framework;

namespace VKClient.Common.VideoCatalog
{
  public class CategoryMoreFooter : ViewModelBase
  {
    private Visibility _showAllVisibility;
    private Visibility _showMoreVisibility;

    public Visibility ShowAllVisibility
    {
      get
      {
        return this._showAllVisibility;
      }
      set
      {
        this._showAllVisibility = value;
        this.NotifyPropertyChanged<Visibility>((System.Linq.Expressions.Expression<Func<Visibility>>) (() => this.ShowAllVisibility));
      }
    }

    public Visibility ShowMoreVisibility
    {
      get
      {
        return this._showMoreVisibility;
      }
      set
      {
        this._showMoreVisibility = value;
        this.NotifyPropertyChanged<Visibility>((System.Linq.Expressions.Expression<Func<Visibility>>) (() => this.ShowMoreVisibility));
      }
    }

    public Action HandleTap { get; set; }
  }
}
