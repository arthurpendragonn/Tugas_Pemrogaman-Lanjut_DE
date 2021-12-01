// Decompiled with JetBrains decompiler
// Type: Tugas.FrmPerhitungan
// Assembly: Tugas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AA41246E-0648-45C2-BB07-CEC8D36EFA14
// Assembly location: C:\Users\Dito\Desktop\demo aplikasi\Tugas.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Tugas
{
  public class FrmPerhitungan : Form
  {
    private IContainer components = (IContainer) null;
    private Label label1;
    private ComboBox comboBox1;
    private Label label2;
    private Label label3;
    private TextBox textBox1;
    private TextBox textBox2;
    private Button button1;

    public event FrmPerhitungan.ProsesEventHandler OnProses;

    public FrmPerhitungan()
    {
      this.InitializeComponent();
      this.comboBox1.SelectedIndex = 0;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      string lower = this.comboBox1.Text.ToLower();
      string op = string.Empty;
      int hasil = 0;
      int a = int.Parse(this.textBox1.Text);
      int b = int.Parse(this.textBox2.Text);
      switch (this.comboBox1.SelectedIndex)
      {
        case 0:
          hasil = a + b;
          op = "+";
          break;
        case 1:
          hasil = a - b;
          op = "-";
          break;
        case 2:
          hasil = a * b;
          op = "*";
          break;
        case 3:
          hasil = a / b;
          op = "/";
          break;
      }
      this.OnProses(lower, op, a, b, hasil);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.label1 = new Label();
      this.comboBox1 = new ComboBox();
      this.label2 = new Label();
      this.label3 = new Label();
      this.textBox1 = new TextBox();
      this.textBox2 = new TextBox();
      this.button1 = new Button();
      this.SuspendLayout();
      this.label1.AutoSize = true;
      this.label1.Location = new Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new Size(43, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Operasi";
      this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Items.AddRange(new object[4]
      {
        (object) "Penjumlahan",
        (object) "Pengurangan",
        (object) "Perkalian",
        (object) "Pembagian"
      });
      this.comboBox1.Location = new Point(61, 6);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new Size(121, 21);
      this.comboBox1.TabIndex = 0;
      this.label2.AutoSize = true;
      this.label2.Location = new Point(12, 36);
      this.label2.Name = "label2";
      this.label2.Size = new Size(37, 13);
      this.label2.TabIndex = 0;
      this.label2.Text = "Nilai A";
      this.label3.AutoSize = true;
      this.label3.Location = new Point(12, 62);
      this.label3.Name = "label3";
      this.label3.Size = new Size(37, 13);
      this.label3.TabIndex = 0;
      this.label3.Text = "Hilai B";
      this.textBox1.Location = new Point(61, 33);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(121, 20);
      this.textBox1.TabIndex = 1;
      this.textBox2.Location = new Point(61, 59);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new Size(121, 20);
      this.textBox2.TabIndex = 2;
      this.button1.Location = new Point(107, 95);
      this.button1.Name = "button1";
      this.button1.Size = new Size(75, 23);
      this.button1.TabIndex = 3;
      this.button1.Text = "Proses";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(206, 128);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.textBox2);
      this.Controls.Add((Control) this.textBox1);
      this.Controls.Add((Control) this.comboBox1);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (FrmPerhitungan);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Calculator";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public delegate void ProsesEventHandler(string operasi, string op, int a, int b, int hasil);
  }
}
