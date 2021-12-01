// Decompiled with JetBrains decompiler
// Type: Tugas.Properties.Resources
// Assembly: Tugas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AA41246E-0648-45C2-BB07-CEC8D36EFA14
// Assembly location: C:\Users\Dito\Desktop\demo aplikasi\Tugas.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Tugas.Properties
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
        if (Tugas.Properties.Resources.resourceMan == null)
          Tugas.Properties.Resources.resourceMan = new ResourceManager("Tugas.Properties.Resources", typeof (Tugas.Properties.Resources).Assembly);
        return Tugas.Properties.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get => Tugas.Properties.Resources.resourceCulture;
      set => Tugas.Properties.Resources.resourceCulture = value;
    }
  }
}
