// Decompiled with JetBrains decompiler
// Type: Tugas.FrmHasilPerhitungan
// Assembly: Tugas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AA41246E-0648-45C2-BB07-CEC8D36EFA14
// Assembly location: C:\Users\Dito\Desktop\demo aplikasi\Tugas.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Tugas
{
  public class FrmHasilPerhitungan : Form
  {
    private IContainer components = (IContainer) null;
    private GroupBox groupBox1;
    private ListBox listBox1;
    private Button button1;

    public FrmHasilPerhitungan() => this.InitializeComponent();

    private void button1_Click(object sender, EventArgs e)
    {
      FrmPerhitungan frmPerhitungan = new FrmPerhitungan();
      frmPerhitungan.OnProses += new FrmPerhitungan.ProsesEventHandler(this.Form_OnProses);
      int num = (int) frmPerhitungan.ShowDialog();
    }

    private void Form_OnProses(string operasi, string op, int a, int b, int hasil) => this.listBox1.Items.Add((object) string.Format("Hasil {0} {1} {2} {3} = {4}", (object) operasi, (object) a, (object) op, (object) b, (object) hasil));

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.groupBox1 = new GroupBox();
      this.listBox1 = new ListBox();
      this.button1 = new Button();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      this.groupBox1.Controls.Add((Control) this.listBox1);
      this.groupBox1.Location = new Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(340, 240);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = " [ Hasil ] ";
      this.listBox1.FormattingEnabled = true;
      this.listBox1.Location = new Point(6, 19);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new Size(327, 212);
      this.listBox1.TabIndex = 0;
      this.button1.Location = new Point(12, 258);
      this.button1.Name = "button1";
      this.button1.Size = new Size(340, 23);
      this.button1.TabIndex = 1;
      this.button1.Text = "Hitung";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(365, 292);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.groupBox1);
      this.MaximizeBox = false;
      this.Name = nameof (FrmHasilPerhitungan);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Hasil Perhitungan";
      this.groupBox1.ResumeLayout(false);
      this.ResumeLayout(false);
    }
  }
}
