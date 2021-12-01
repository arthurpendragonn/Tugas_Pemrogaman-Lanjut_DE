// Decompiled with JetBrains decompiler
// Type: Tugas.Program
// Assembly: Tugas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AA41246E-0648-45C2-BB07-CEC8D36EFA14
// Assembly location: C:\Users\Dito\Desktop\demo aplikasi\Tugas.exe

using System;
using System.Windows.Forms;

namespace Tugas
{
  internal static class Program
  {
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run((Form) new FrmHasilPerhitungan());
    }
  }
}
