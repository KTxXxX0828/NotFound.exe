
/*
Decompiled by Ptr35
*/

using System;
using System.Media;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

#nullable disable
namespace NotFound
{
  internal static class Program
  {
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Task.Run((Action) (() =>
      {
        SystemSounds.Beep.Play();
        int num = 999;
        int millisecondsTimeout = 0;
        for (int index = 0; index < num; ++index)
        {
          Console.Beep();
          Thread.Sleep(millisecondsTimeout);
        }
      }));
      Warn w = new Warn();
      w.Warn_Load();
    }
  }
}
