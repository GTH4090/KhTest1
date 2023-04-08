using Avalonia.Controls;
using Avalonia.Interactivity;
using KhranitelDesktop.Pages;
using static KhranitelDesktop.Classes.Helper;

namespace KhranitelDesktop;

public partial class KeeperWindow : Window
{
    public KeeperWindow()
    {
        InitializeComponent();
        Win = this;
        Navigationn = MainFrame;
        Navigationn.Content = new Auth();

    }

    private void ExitBtn_OnClick(object? sender, RoutedEventArgs e)
    {
        Navigationn.Content = new Auth();
    }
}