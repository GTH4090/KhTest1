using System;
using System.Collections.Generic;
using System.Linq;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using static KhranitelDesktop.Classes.Helper;
using KhranitelDesktop.Models;
using Microsoft.EntityFrameworkCore;


namespace KhranitelDesktop.Pages;

public partial class MainMenu : UserControl
{
    private void LoadData()
    {
        try
        {
            List<Visit> visits = Db.Visits.Where(el => el.Userid == Loginned.Id).Include(el
                => el.Status).Include(el => el.Type).Include(el =>
                el.Employee).ThenInclude(el => el.Division).ToList();
            if (visits.Count() != 0)
            {
                VisitDg.Items = visits;
            }
            else
            {
                Info("Нет результатов поиска");
            }
            
        }
        catch (Exception e)
        {
            Error();
        }
    }
    public MainMenu()
    {
        InitializeComponent();
        LoadData();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }

    private void VisitBtn_OnClick(object? sender, RoutedEventArgs e)
    {
        Navigationn.Content = new VisitPage();
    }
}