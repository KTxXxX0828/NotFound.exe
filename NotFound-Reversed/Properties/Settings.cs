// Decompiled with JetBrains decompiler
// Type: NotFound.Properties.Settings
// Assembly: NotFound, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B7644DC0-6B31-4023-8FF2-C9A9D8030183
// Assembly location: C:\Users\ナカムラ　マサト\Downloads\NotFound.exe

using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

#nullable disable
namespace NotFound.Properties
{
  [CompilerGenerated]
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
  internal sealed class Settings : ApplicationSettingsBase
  {
    private static Settings defaultInstance = (Settings) SettingsBase.Synchronized((SettingsBase) new Settings());

    public static Settings Default
    {
      get
      {
        Settings defaultInstance = Settings.defaultInstance;
        return defaultInstance;
      }
    }
  }
}
