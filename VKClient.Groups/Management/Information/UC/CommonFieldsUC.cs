using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using VKClient.Groups.Management.Information.Library;
using VKClient.Groups.UC;

namespace VKClient.Groups.Management.Information.UC
{
    public partial class CommonFieldsUC : UserControl
  {

    public CommonFieldsViewModel ViewModel
    {
      get
      {
        return this.DataContext as CommonFieldsViewModel;
      }
    }

    public CommonFieldsUC()
    {
      this.InitializeComponent();
    }

    private void DomainTextBox_OnTextChanged(object sender, TextChangedEventArgs e)
    {
      ((FrameworkElement) sender).GetBindingExpression(CommunityDomainTextBox.TextProperty).UpdateSource();
    }

    private void TextBox_OnTextChanged(object sender, TextChangedEventArgs e)
    {
      ((FrameworkElement) sender).GetBindingExpression(TextBox.TextProperty).UpdateSource();
    }

    private void TextBox_OnKeyDown(object sender, KeyEventArgs e)
    {
      if (e.Key != Key.Enter)
        return;
      this.Focus();
    }

    private void TextBox_OnGotFocus(object sender, RoutedEventArgs e)
    {
      RoutedEventHandler routedEventHandler = this.ViewModel.ParentViewModel.OnTextBoxGotFocus;
      if (routedEventHandler == null)
        return;
      object sender1 = sender;
      RoutedEventArgs e1 = e;
      routedEventHandler(sender1, e1);
    }

    private void TextBox_OnLostFocus(object sender, RoutedEventArgs e)
    {
      RoutedEventHandler routedEventHandler = this.ViewModel.ParentViewModel.OnTextBoxLostFocus;
      if (routedEventHandler == null)
        return;
      object sender1 = sender;
      RoutedEventArgs e1 = e;
      routedEventHandler(sender1, e1);
    }

  }
}