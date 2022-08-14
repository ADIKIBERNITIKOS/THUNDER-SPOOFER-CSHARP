
// Type: Loader.REGISTER
// Assembly: Thunder Spoofer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6911BFCC-B15C-4BF6-865B-4753D2D18ED6
// Assembly location: C:\Users\ADIKIBERNITIKOS\Desktop\111\1_.exe

using Guna.UI2.WinForms;
using KeyAuth;
using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Loader
{
  public class REGISTER : UserControl
  {
    public static api KeyAuthApp = new api("Spooferaa", "6NRM3uhCkq", "6e6acd5c87b491b297cc6087ddf255493afe851c14da4f474da4ec0283e5b897", "1.0");
    private IContainer components;
    private Guna2PictureBox guna2PictureBox1;
    private Guna2TextBox username;
    private Guna2TextBox password;
    private Guna2TextBox key;
    private Guna2Button RgstrBtn;
    private Guna2Button guna2Button1;

    public REGISTER() => this.InitializeComponent();

    public static void sendWebHookregister(
      string Url,
      string msg,
      string Username,
      string Plan,
      string Key)
    {
      e.a((object) "https://discord.com/api/webhooks/996491172774154370/gG61AbiMmcyQPRPx2I5VIRZGxI7JqSlYpr_TOImomjS-QCoRx_isK7meLwAfJfrULXHT", (object) new NameValueCollection()
      {
        {
          "username",
          Username
        },
        {
          "content",
          msg
        },
        {
          "content",
          Plan
        },
        {
          "content",
          Key
        }
      });
    }

    private void RgstrBtn_Click(object sender, EventArgs e)
    {
      REGISTER.KeyAuthApp.register(this.username.Text, this.password.Text, this.key.Text);
      if (!REGISTER.KeyAuthApp.response.success)
      {
        int num1 = (int) MessageBox.Show(Login.KeyAuthApp.response.message, "Legion Woofer: Failed to login", MessageBoxButtons.OK);
      }
      else
      {
        string[] strArray1 = new string[1]
        {
          this.username.Text
        };
        string path1 = "C:\\Program Files\\legionuser.txt";
        if (File.Exists(path1))
          File.Delete(path1);
        using (StreamWriter streamWriter = new StreamWriter(Path.Combine("C:\\Program Files", "legionuser.txt")))
        {
          foreach (string str in strArray1)
            streamWriter.WriteLine(str);
          File.SetAttributes("C:\\Program Files\\legionuser.txt", FileAttributes.Hidden);
        }
        string[] strArray2 = new string[1]
        {
          this.password.Text
        };
        string path2 = "C:\\Program Files\\legionpass.txt";
        if (File.Exists(path2))
          File.Delete(path2);
        using (StreamWriter streamWriter = new StreamWriter(Path.Combine("C:\\Program Files", "legionpass.txt")))
        {
          foreach (string str in strArray2)
            streamWriter.WriteLine(str);
          File.SetAttributes("C:\\Program Files\\legionpass.txt", FileAttributes.Hidden);
        }
        REGISTER.sendWebHookregister("https://discord.com/api/webhooks/964204068350361700/cO5UIZ8SOzosICZo3lRgQu5vhr9Usd_as2pCDLRerLuxIQ7Vd0_t0OqKuF9oMID_h-8B", "\uD83D\uDD0B Plan: " + Login.KeyAuthApp.user_data.subscriptions[0].subscription, "Legion Woofer", "\n\uD83D\uDD11 License: " + this.key.Text, "\nThanks for buying Legion Woofer " + this.username.Text + " \uD83D\uDC9C ");
        new Main().Show();
        this.Hide();
        int num2 = (int) MessageBox.Show("Thanks For Choosing Legion Woofer, Welcome!", "Legion Woofer", MessageBoxButtons.OK);
      }
    }

    private void REGISTER_Load(object sender, EventArgs e)
    {
    }

    private void LoginBtn_Click(object sender, EventArgs e)
    {
    }

    private void guna2Button1_Click(object sender, EventArgs e)
    {
      new Login().Show();
      this.Hide();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (REGISTER));
      this.guna2PictureBox1 = new Guna2PictureBox();
      this.username = new Guna2TextBox();
      this.password = new Guna2TextBox();
      this.key = new Guna2TextBox();
      this.RgstrBtn = new Guna2Button();
      this.guna2Button1 = new Guna2Button();
      ((ISupportInitialize) this.guna2PictureBox1).BeginInit();
      this.SuspendLayout();
      this.guna2PictureBox1.BackColor = Color.Transparent;
      this.guna2PictureBox1.Image = (Image) componentResourceManager.GetObject("guna2PictureBox1.Image");
      this.guna2PictureBox1.ImageRotate = 0.0f;
      this.guna2PictureBox1.Location = new Point(102, 7);
      this.guna2PictureBox1.Name = "guna2PictureBox1";
      this.guna2PictureBox1.Size = new Size(96, 85);
      this.guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
      this.guna2PictureBox1.TabIndex = 1;
      this.guna2PictureBox1.TabStop = false;
      this.username.BackColor = Color.Transparent;
      this.username.BorderColor = Color.FromArgb(64, 64, 64);
      this.username.Cursor = Cursors.IBeam;
      this.username.DefaultText = "";
      this.username.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
      this.username.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
      this.username.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
      this.username.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
      this.username.FillColor = Color.FromArgb(20, 20, 20);
      this.username.FocusedState.BorderColor = Color.FromArgb(94, 148, (int) byte.MaxValue);
      this.username.Font = new Font("Segoe UI", 9f);
      this.username.ForeColor = Color.White;
      this.username.HoverState.BorderColor = Color.FromArgb(94, 148, (int) byte.MaxValue);
      this.username.Location = new Point(67, 98);
      this.username.Name = "username";
      this.username.PasswordChar = char.MinValue;
      this.username.PlaceholderForeColor = Color.GreenYellow;
      this.username.PlaceholderText = "Username";
      this.username.SelectedText = "";
      this.username.Size = new Size(183, 40);
      this.username.TabIndex = 38;
      this.password.BorderColor = Color.FromArgb(64, 64, 64);
      this.password.Cursor = Cursors.IBeam;
      this.password.DefaultText = "";
      this.password.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
      this.password.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
      this.password.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
      this.password.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
      this.password.FillColor = Color.FromArgb(20, 20, 20);
      this.password.FocusedState.BorderColor = Color.FromArgb(94, 148, (int) byte.MaxValue);
      this.password.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.password.ForeColor = Color.White;
      this.password.HoverState.BorderColor = Color.FromArgb(94, 148, (int) byte.MaxValue);
      this.password.Location = new Point(67, 153);
      this.password.Name = "password";
      this.password.PasswordChar = char.MinValue;
      this.password.PlaceholderForeColor = Color.GreenYellow;
      this.password.PlaceholderText = "Password";
      this.password.SelectedText = "";
      this.password.Size = new Size(183, 40);
      this.password.TabIndex = 39;
      this.key.BorderColor = Color.FromArgb(64, 64, 64);
      this.key.Cursor = Cursors.IBeam;
      this.key.DefaultText = "";
      this.key.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
      this.key.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
      this.key.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
      this.key.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
      this.key.FillColor = Color.FromArgb(20, 20, 20);
      this.key.FocusedState.BorderColor = Color.FromArgb(94, 148, (int) byte.MaxValue);
      this.key.Font = new Font("Segoe UI", 9f);
      this.key.ForeColor = Color.White;
      this.key.HoverState.BorderColor = Color.FromArgb(94, 148, (int) byte.MaxValue);
      this.key.Location = new Point(67, 211);
      this.key.Name = "key";
      this.key.PasswordChar = char.MinValue;
      this.key.PlaceholderForeColor = Color.GreenYellow;
      this.key.PlaceholderText = "Key";
      this.key.SelectedText = "";
      this.key.Size = new Size(183, 40);
      this.key.TabIndex = 40;
      this.RgstrBtn.AutoRoundedCorners = true;
      this.RgstrBtn.BackColor = Color.Transparent;
      this.RgstrBtn.BorderRadius = 11;
      this.RgstrBtn.DisabledState.BorderColor = Color.DarkGray;
      this.RgstrBtn.DisabledState.CustomBorderColor = Color.DarkGray;
      this.RgstrBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
      this.RgstrBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
      this.RgstrBtn.FillColor = Color.GreenYellow;
      this.RgstrBtn.Font = new Font("Segoe UI", 9f);
      this.RgstrBtn.ForeColor = Color.Black;
      this.RgstrBtn.Location = new Point(67, 270);
      this.RgstrBtn.Name = "RgstrBtn";
      this.RgstrBtn.Size = new Size(183, 25);
      this.RgstrBtn.TabIndex = 42;
      ((Control) this.RgstrBtn).Text = "Register";
      this.RgstrBtn.Click += new EventHandler(this.RgstrBtn_Click);
      this.guna2Button1.AutoRoundedCorners = true;
      this.guna2Button1.BackColor = Color.Transparent;
      this.guna2Button1.BorderRadius = 11;
      this.guna2Button1.DisabledState.BorderColor = Color.DarkGray;
      this.guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
      this.guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
      this.guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
      this.guna2Button1.FillColor = Color.GreenYellow;
      this.guna2Button1.Font = new Font("Segoe UI", 9f);
      this.guna2Button1.ForeColor = Color.Black;
      this.guna2Button1.Location = new Point(67, 301);
      this.guna2Button1.Name = "guna2Button1";
      this.guna2Button1.Size = new Size(183, 25);
      this.guna2Button1.TabIndex = 43;
      ((Control) this.guna2Button1).Text = "Login";
      this.guna2Button1.Click += new EventHandler(this.guna2Button1_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.Black;
      this.Controls.Add((Control) this.guna2Button1);
      this.Controls.Add((Control) this.RgstrBtn);
      this.Controls.Add((Control) this.key);
      this.Controls.Add((Control) this.password);
      this.Controls.Add((Control) this.username);
      this.Controls.Add((Control) this.guna2PictureBox1);
      this.Name = nameof (REGISTER);
      this.Size = new Size(298, 352);
      this.Load += new EventHandler(this.REGISTER_Load);
      ((ISupportInitialize) this.guna2PictureBox1).EndInit();
      this.ResumeLayout(false);
    }
  }
}
