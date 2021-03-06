using System;
using System.Linq.Expressions;
using VKClient.Common.Framework;

namespace VKClient.Common.Library
{
  public class AppNotificationViewModel : ViewModelBase
  {
    private static AppNotificationViewModel _instance;
    private string _imageSrc;
    private string _title;
    private string _subtitle;

    public static AppNotificationViewModel Instance
    {
      get
      {
        if (AppNotificationViewModel._instance == null)
          AppNotificationViewModel._instance = new AppNotificationViewModel();
        return AppNotificationViewModel._instance;
      }
    }

    public string ImageSrc
    {
      get
      {
        return this._imageSrc;
      }
      set
      {
        this._imageSrc = value;
        this.NotifyPropertyChanged<string>((Expression<Func<string>>) (() => this.ImageSrc));
      }
    }

    public string Title
    {
      get
      {
        return this._title;
      }
      set
      {
        this._title = value;
        this.NotifyPropertyChanged<string>((Expression<Func<string>>) (() => this.Title));
      }
    }

    public string Subtitle
    {
      get
      {
        return this._subtitle;
      }
      set
      {
        this._subtitle = value;
        this.NotifyPropertyChanged<string>((Expression<Func<string>>) (() => this.Subtitle));
      }
    }

    public void SetData(string imageSrc, string title, string subtitle)
    {
      this.ImageSrc = imageSrc;
      this.Title = title;
      this.Subtitle = subtitle;
    }
  }
}
