using System;
using System.Linq;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using KhranitelDesktop.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using static KhranitelDesktop.Classes.Helper;

namespace KhranitelDesktop.Pages;

public partial class Registration : UserControl
{
    public Registration()
    {
        InitializeComponent();
    }

    

    private void CancelBtn_OnClick(object? sender, RoutedEventArgs e)
    {
        Navigationn.Content = new Auth();
    }

    private void LoginBtn_OnClick(object? sender, RoutedEventArgs e)
    {
        try
        {
            string nums = "1234567890";
            string lowLet = "qwertyuiopasdfghjklzxcvbnm";
            string upLet = lowLet.ToUpper();
            string spec = "!@#$%^&*()";
            if (LoginTbx.Text[0] != '@' && LoginTbx.Text[^1] != '@' && LoginTbx.Text.Count(el => el == '@') == 1 
                && PasswordTbx.Text.Intersect(nums).Count() > 0 && PasswordTbx.Text.Intersect(lowLet).Count() > 0 
                && PasswordTbx.Text.Intersect(upLet).Count() > 0 && PasswordTbx.Text.Intersect(spec).Count() > 0 &&
                PasswordTbx.Text == Password2Tbx.Text && PasswordTbx.Text.Length >= 8)
            {
                User user = new User();
                user.Login = LoginTbx.Text;
                user.Password = BCrypt.Net.BCrypt.HashPassword(PasswordTbx.Text);
                Db.Users.Add(user);
                Db.SaveChanges();
                Navigationn.Content = new Auth();
            }
            else
            {
                Error("Логин или пароль не соответствуют требованиям");
            }
        }
        catch (Exception exception)
        {
            Error();
        }
    }
}