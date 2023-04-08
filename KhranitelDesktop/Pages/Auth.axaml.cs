using System;
using System.Linq;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using static  KhranitelDesktop.Classes.Helper;
using KhranitelDesktop.Models;


namespace KhranitelDesktop.Pages;

public partial class Auth : UserControl
{
    public Auth()
    {
        InitializeComponent();
    }

    

    private void PasswCb_OnChecked(object? sender, RoutedEventArgs e)
    {
        PasswordTbx.PasswordChar = '\0';
    }

    private void PasswCb_OnUnchecked(object? sender, RoutedEventArgs e)
    {
        PasswordTbx.PasswordChar = '*';
    }

    private void LoginBtn_OnClick(object? sender, RoutedEventArgs e)
    {
        try
        {
            if (Db.Users.FirstOrDefault(el => el.Login == LoginTbx.Text) != null)
            {
                var item = Db.Users.FirstOrDefault(el => el.Login == LoginTbx.Text) as User;
                if (BCrypt.Net.BCrypt.Verify(PasswordTbx.Text, item.Password))
                {
                    Loginned = item;
                    Navigationn.Content = new MainMenu();
                }
                else
                {
                    Info("Не привильный пароль");
                }
            }
            else
            {
                Info("Не правильный логин");
            }
        }
        catch (Exception exception)
        {
            Error();
        }
        
    }

    private void RegBtn_OnClick(object? sender, RoutedEventArgs e)
    {
        Navigationn.Content = new Registration();
    }
}