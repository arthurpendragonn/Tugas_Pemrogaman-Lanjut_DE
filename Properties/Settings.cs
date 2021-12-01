// Decompiled with JetBrains decompiler
// Type: Tugas.Properties.Settings
// Assembly: Tugas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AA41246E-0648-45C2-BB07-CEC8D36EFA14
// Assembly location: C:\Users\Dito\Desktop\demo aplikasi\Tugas.exe

using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace Tugas.Properties
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
