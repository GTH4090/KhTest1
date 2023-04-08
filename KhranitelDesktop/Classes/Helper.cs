using Avalonia.Controls;
using KhranitelDesktop.Models;
using MessageBox.Avalonia;
using MessageBox.Avalonia.Enums;

namespace KhranitelDesktop.Classes;

public class Helper
{
    public static KhranitelDbContext Db = new KhranitelDbContext();

    public static Window Win = null;

    public static ContentControl Navigationn = null;

    public static User Loginned = null;

    public static void Error(string error = "ошибка подключеня к Бд")
    {
        MessageBoxManager.GetMessageBoxStandardWindow("Ошибка", error, ButtonEnum.Ok, Icon.Error).ShowDialog(Win);
    }
    public static void Info(string info = "Внимание")
    {
        MessageBoxManager.GetMessageBoxStandardWindow("Внимание", info, ButtonEnum.Ok, Icon.Info).ShowDialog(Win);
    }
    
}