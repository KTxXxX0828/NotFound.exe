// Decompiled with JetBrains decompiler
// Type: NotFound.Properties.Resources
// Assembly: NotFound, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B7644DC0-6B31-4023-8FF2-C9A9D8030183
// Assembly location: C:\Users\ナカムラ　マサト\Downloads\NotFound.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace NotFound.Properties
{
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  [DebuggerNonUserCode]
  [CompilerGenerated]
  internal class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    internal Resources()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (NotFound.Properties.Resources.resourceMan == null)
          NotFound.Properties.Resources.resourceMan = new ResourceManager("NotFound.Properties.Resources", typeof (NotFound.Properties.Resources).Assembly);
        return NotFound.Properties.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get => NotFound.Properties.Resources.resourceCulture;
      set => NotFound.Properties.Resources.resourceCulture = value;
    }
  }
}
