
// Type: Loader.Setting
// Assembly: Thunder Spoofer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6911BFCC-B15C-4BF6-865B-4753D2D18ED6
// Assembly location: C:\Users\ADIKIBERNITIKOS\Desktop\111\1_.exe

using DiscordRPC;
using DiscordRPC.Logging;
using Guna.UI2.WinForms;
using KeyAuth;
using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;

namespace Loader
{
  public class Setting : UserControl
  {
    public static Random random = new Random();
    private DiscordRpcClient client;
    private IContainer components;
    private Label label1;
    private Label label2;
    private Label label3;
    private Guna2ToggleSwitch guna2ToggleSwitch1;
    private Guna2Button start;
    private Guna2Button guna2Button1;
    private Label label4;
    private Guna2TextBox guna2TextBox1;
    private Guna2PictureBox guna2PictureBox1;
    private Label label5;
    private Label label6;
    private Guna2PictureBox guna2PictureBox2;
    private Label label7;
    private Guna2ToggleSwitch guna2ToggleSwitch2;
    private Guna2Button guna2Button9;
    private Guna2Button guna2Button2;

    public Setting() => this.InitializeComponent();

    public static void Enable_LocalAreaConection(string adapterId, bool enable = true)
    {
      string str1 = "Ethernet";
      foreach (NetworkInterface networkInterface in NetworkInterface.GetAllNetworkInterfaces())
      {
        if (networkInterface.Id == adapterId)
        {
          str1 = networkInterface.Name;
          break;
        }
      }
      string str2 = enable ? nameof (enable) : "disable";
      ProcessStartInfo processStartInfo = new ProcessStartInfo("netsh", "interface set interface \"" + str1 + "\" " + str2);
      Process process = new Process();
      process.StartInfo = processStartInfo;
      process.Start();
      process.StartInfo.CreateNoWindow = true;
      process.WaitForExit();
    }

    public static string RandomMac()
    {
      string str1 = "ABCDEF0123456789";
      string str2 = "26AE";
      string str3 = "";
      Random random = new Random();
      string str4 = str3 + str1[random.Next(str1.Length)].ToString() + str2[random.Next(str2.Length)].ToString();
      for (int index = 0; index < 5; ++index)
        str4 = str4 + "-" + str1[random.Next(str1.Length)].ToString() + str1[random.Next(str1.Length)].ToString();
      return str4;
    }

    public static void HWIDclick()
    {
      string keyName = "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\IDConfigDB\\Hardware Profiles\\0001";
      string str1 = (string) Registry.GetValue(keyName, "HwProfileGuid", (object) "default");
      string str2 = "{LeanOnTop-72597-62482-4194-844193755}";
      Registry.SetValue(keyName, "GUID", (object) str2);
      Registry.SetValue(keyName, "HwProfileGuid", (object) str2);
    }

    public static void XBOXclick()
    {
      string str = "40438d3e";
      RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", true).SetValue("InstallDate", (object) str);
    }

    public static void IDclick()
    {
      string str = "EBB39-DAA7F-ABA35-FE4BE";
      RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", true);
      registryKey.SetValue("ProductID", (object) str);
      registryKey.Close();
    }

    public static void PCclick()
    {
      RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\ComputerName\\ActiveComputerName", true);
      registryKey.SetValue("ComputerName", (object) "DESKTOP-2129BA");
      registryKey.Close();
    }

    public static void Diskclick()
    {
      foreach (string subKeyName1 in Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi").GetSubKeyNames())
      {
        foreach (string subKeyName2 in Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi\\" + subKeyName1).GetSubKeyNames())
        {
          RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi\\" + subKeyName1 + "\\" + subKeyName2 + "\\Target Id 0\\Logical Unit Id 0", true);
          if (registryKey != null && registryKey.GetValue("DeviceType").ToString() == "DiskPeripheral")
          {
            string s1 = "XB0L95MV9YE3IR";
            string s2 = "XB0L95MV9YE3IR";
            registryKey.SetValue("DeviceIdentifierPage", (object) Encoding.UTF8.GetBytes(s2));
            registryKey.SetValue("Identifier", (object) s1);
            registryKey.SetValue("InquiryData", (object) Encoding.UTF8.GetBytes(s1));
            registryKey.SetValue("SerialNumber", (object) s2);
          }
        }
      }
    }

    public static string DiskGen(int length) => new string(Enumerable.Repeat<string>("12345786789", length).Select<string, char>((Func<string, char>) (a => a[Setting.random.Next(a.Length)])).ToArray<char>());

    public static string RandomString(int length) => new string(Enumerable.Repeat<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", length).Select<string, char>((Func<string, char>) (a => a[Setting.random.Next(a.Length)])).ToArray<char>());

    private void Setting_Load(object sender, EventArgs e)
    {
    }

    private void y(object sender, EventArgs e)
    {
      int num = this.guna2ToggleSwitch2.Checked ? 1 : 0;
    }

    private void guna2Button2_Click(object sender, EventArgs e)
    {
      if (File.Exists("C:\\Program Files\\legionuser.txt"))
        File.Delete("C:\\Program Files\\legionuser.txt");
      if (File.Exists("C:\\Program Files\\legionpass.txt"))
        File.Delete("C:\\Program Files\\legionpass.txt");
      int num = (int) MessageBox.Show("Deleted Saved Logins!", "Legion Woofer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
    }

    private void guna2ToggleSwitch2_CheckedChanged(object sender, EventArgs e)
    {
      this.client = new DiscordRpcClient("999357157914972190");
      this.client.Logger = (ILogger) new ConsoleLogger();
      this.client.Initialize();
      DiscordRpcClient client = this.client;
      RichPresence presence = new RichPresence();
      presence.Details = "Username: " + Login.KeyAuthApp.user_data.username;
      presence.State = "discord.gg/XqwqdwcMEX";
      presence.Timestamps = new Timestamps()
      {
        Start = new DateTime?(DateTime.UtcNow)
      };
      presence.Assets = new Assets()
      {
        LargeImageKey = "rich_presense",
        LargeImageText = "Best Spoofer",
        SmallImageKey = "rich"
      };
      client.SetPresence(presence);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Setting));
      this.label1 = new Label();
      this.label2 = new Label();
      this.label3 = new Label();
      this.guna2ToggleSwitch1 = new Guna2ToggleSwitch();
      this.start = new Guna2Button();
      this.guna2Button1 = new Guna2Button();
      this.label4 = new Label();
      this.guna2TextBox1 = new Guna2TextBox();
      this.guna2PictureBox1 = new Guna2PictureBox();
      this.label5 = new Label();
      this.label6 = new Label();
      this.guna2PictureBox2 = new Guna2PictureBox();
      this.label7 = new Label();
      this.guna2ToggleSwitch2 = new Guna2ToggleSwitch();
      this.guna2Button9 = new Guna2Button();
      this.guna2Button2 = new Guna2Button();
      ((ISupportInitialize) this.guna2PictureBox1).BeginInit();
      ((ISupportInitialize) this.guna2PictureBox2).BeginInit();
      this.SuspendLayout();
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Segoe UI Black", 15.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new Point(76, 19);
      this.label1.Name = "label1";
      this.label1.Size = new Size(97, 30);
      this.label1.TabIndex = 12;
      this.label1.Text = "Settings";
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Segoe UI Black", 5.75f, FontStyle.Bold);
      this.label2.ForeColor = System.Drawing.Color.Red;
      this.label2.Location = new Point(85, 49);
      this.label2.Name = "label2";
      this.label2.Size = new Size(77, 11);
      this.label2.TabIndex = 13;
      this.label2.Text = "Customize Spoofer";
      this.label3.AutoSize = true;
      this.label3.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label3.ForeColor = System.Drawing.Color.Red;
      this.label3.Location = new Point(54, 114);
      this.label3.Name = "label3";
      this.label3.Size = new Size(87, 17);
      this.label3.TabIndex = 14;
      this.label3.Text = "Discord RPC :";
      this.guna2ToggleSwitch1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, (int) byte.MaxValue);
      this.guna2ToggleSwitch1.CheckedState.FillColor = System.Drawing.Color.FromArgb(94, 148, (int) byte.MaxValue);
      this.guna2ToggleSwitch1.CheckedState.InnerBorderColor = System.Drawing.Color.White;
      this.guna2ToggleSwitch1.CheckedState.InnerColor = System.Drawing.Color.White;
      this.guna2ToggleSwitch1.Location = new Point(154, 114);
      this.guna2ToggleSwitch1.Name = "guna2ToggleSwitch1";
      this.guna2ToggleSwitch1.Size = new Size(37, 17);
      this.guna2ToggleSwitch1.TabIndex = 15;
      this.guna2ToggleSwitch1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(125, 137, 149);
      this.guna2ToggleSwitch1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(125, 137, 149);
      this.guna2ToggleSwitch1.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
      this.guna2ToggleSwitch1.UncheckedState.InnerColor = System.Drawing.Color.White;
      this.start.BorderColor = System.Drawing.Color.Red;
      this.start.BorderThickness = 1;
      this.start.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
      this.start.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
      this.start.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
      this.start.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
      this.start.FillColor = System.Drawing.Color.Transparent;
      this.start.Font = new Font("Segoe UI Black", 9f, FontStyle.Bold);
      this.start.ForeColor = System.Drawing.Color.Red;
      this.start.Location = new Point(57, 160);
      this.start.Name = "start";
      this.start.Size = new Size(143, 28);
      this.start.TabIndex = 20;
      ((Control) this.start).Text = "Delete Credentials";
      this.guna2Button1.BorderColor = System.Drawing.Color.Red;
      this.guna2Button1.BorderThickness = 1;
      this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
      this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
      this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
      this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
      this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
      this.guna2Button1.Font = new Font("Segoe UI Black", 9f, FontStyle.Bold);
      this.guna2Button1.ForeColor = System.Drawing.Color.Red;
      this.guna2Button1.Location = new Point(57, 203);
      this.guna2Button1.Name = "guna2Button1";
      this.guna2Button1.Size = new Size(143, 28);
      this.guna2Button1.TabIndex = 21;
      ((Control) this.guna2Button1).Text = "Reset User Photo";
      this.label4.AutoSize = true;
      this.label4.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label4.ForeColor = System.Drawing.Color.Red;
      this.label4.Location = new Point(54, 251);
      this.label4.Name = "label4";
      this.label4.Size = new Size(78, 17);
      this.label4.TabIndex = 22;
      this.label4.Text = "Disk Name :";
      this.guna2TextBox1.BorderColor = System.Drawing.Color.Red;
      this.guna2TextBox1.Cursor = Cursors.IBeam;
      this.guna2TextBox1.DefaultText = "";
      this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
      this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
      this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
      this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
      this.guna2TextBox1.FillColor = System.Drawing.Color.Transparent;
      this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, (int) byte.MaxValue);
      this.guna2TextBox1.Font = new Font("Segoe UI", 9f);
      this.guna2TextBox1.ForeColor = System.Drawing.Color.Red;
      this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, (int) byte.MaxValue);
      this.guna2TextBox1.Location = new Point(163, 251);
      this.guna2TextBox1.Name = "guna2TextBox1";
      this.guna2TextBox1.PasswordChar = char.MinValue;
      this.guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.Red;
      this.guna2TextBox1.PlaceholderText = "";
      this.guna2TextBox1.SelectedText = "";
      this.guna2TextBox1.Size = new Size(28, 27);
      this.guna2TextBox1.TabIndex = 23;
      this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
      this.guna2PictureBox1.ImageRotate = 0.0f;
      this.guna2PictureBox1.Location = new Point(33, 19);
      this.guna2PictureBox1.Name = "guna2PictureBox1";
      this.guna2PictureBox1.Size = new Size(46, 41);
      this.guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
      this.guna2PictureBox1.TabIndex = 32;
      this.guna2PictureBox1.TabStop = false;
      this.label5.AutoSize = true;
      this.label5.Font = new Font("Segoe UI Black", 15.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label5.ForeColor = System.Drawing.Color.White;
      this.label5.Location = new Point(76, 19);
      this.label5.Name = "label5";
      this.label5.Size = new Size(97, 30);
      this.label5.TabIndex = 1;
      this.label5.Text = "Settings";
      this.label6.AutoSize = true;
      this.label6.Font = new Font("Segoe UI Black", 5.75f, FontStyle.Bold);
      this.label6.ForeColor = System.Drawing.Color.White;
      this.label6.Location = new Point(85, 49);
      this.label6.Name = "label6";
      this.label6.Size = new Size(77, 11);
      this.label6.TabIndex = 22;
      this.label6.Text = "Customize Spoofer";
      this.guna2PictureBox2.FillColor = System.Drawing.Color.Transparent;
      this.guna2PictureBox2.Image = (Image) componentResourceManager.GetObject("guna2PictureBox2.Image");
      this.guna2PictureBox2.ImageRotate = 0.0f;
      this.guna2PictureBox2.Location = new Point(33, 19);
      this.guna2PictureBox2.Name = "guna2PictureBox2";
      this.guna2PictureBox2.Size = new Size(46, 41);
      this.guna2PictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
      this.guna2PictureBox2.TabIndex = 32;
      this.guna2PictureBox2.TabStop = false;
      this.label7.AutoSize = true;
      this.label7.Font = new Font("Segoe UI Black", 9f, FontStyle.Bold);
      this.label7.ForeColor = System.Drawing.Color.White;
      this.label7.Location = new Point(85, 97);
      this.label7.Name = "label7";
      this.label7.Size = new Size(80, 15);
      this.label7.TabIndex = 33;
      this.label7.Text = "Discord RPC";
      this.guna2ToggleSwitch2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, (int) byte.MaxValue);
      this.guna2ToggleSwitch2.CheckedState.FillColor = System.Drawing.Color.FromArgb(94, 148, (int) byte.MaxValue);
      this.guna2ToggleSwitch2.CheckedState.InnerBorderColor = System.Drawing.Color.White;
      this.guna2ToggleSwitch2.CheckedState.InnerColor = System.Drawing.Color.White;
      this.guna2ToggleSwitch2.Location = new Point(171, 97);
      this.guna2ToggleSwitch2.Name = "guna2ToggleSwitch2";
      this.guna2ToggleSwitch2.Size = new Size(46, 15);
      this.guna2ToggleSwitch2.TabIndex = 34;
      this.guna2ToggleSwitch2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(125, 137, 149);
      this.guna2ToggleSwitch2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(125, 137, 149);
      this.guna2ToggleSwitch2.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
      this.guna2ToggleSwitch2.UncheckedState.InnerColor = System.Drawing.Color.White;
      this.guna2ToggleSwitch2.CheckedChanged += new EventHandler(this.guna2ToggleSwitch2_CheckedChanged);
      this.guna2Button9.BorderColor = System.Drawing.Color.White;
      this.guna2Button9.BorderThickness = 1;
      this.guna2Button9.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
      this.guna2Button9.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
      this.guna2Button9.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
      this.guna2Button9.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
      this.guna2Button9.FillColor = System.Drawing.Color.Transparent;
      this.guna2Button9.Font = new Font("Segoe UI Black", 9f, FontStyle.Bold);
      this.guna2Button9.ForeColor = System.Drawing.Color.White;
      this.guna2Button9.Location = new Point(88, 134);
      this.guna2Button9.Name = "guna2Button9";
      this.guna2Button9.Size = new Size(138, 29);
      this.guna2Button9.TabIndex = 35;
      ((Control) this.guna2Button9).Text = "Delete Credentials";
      this.guna2Button2.BorderColor = System.Drawing.Color.White;
      this.guna2Button2.BorderThickness = 1;
      this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
      this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
      this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
      this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
      this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
      this.guna2Button2.Font = new Font("Segoe UI Black", 9f, FontStyle.Bold);
      this.guna2Button2.ForeColor = System.Drawing.Color.White;
      this.guna2Button2.Location = new Point(88, 169);
      this.guna2Button2.Name = "guna2Button2";
      this.guna2Button2.Size = new Size(138, 29);
      this.guna2Button2.TabIndex = 36;
      ((Control) this.guna2Button2).Text = "Reset User Photo";
      this.guna2Button2.Click += new EventHandler(this.guna2Button2_Click);
      this.BackColor = System.Drawing.Color.Transparent;
      this.Controls.Add((Control) this.guna2Button2);
      this.Controls.Add((Control) this.guna2Button9);
      this.Controls.Add((Control) this.guna2ToggleSwitch2);
      this.Controls.Add((Control) this.label7);
      this.Controls.Add((Control) this.guna2PictureBox2);
      this.Controls.Add((Control) this.label6);
      this.Controls.Add((Control) this.label5);
      this.Name = nameof (Setting);
      this.Size = new Size(521, 345);
      this.Load += new EventHandler(this.Setting_Load);
      ((ISupportInitialize) this.guna2PictureBox1).EndInit();
      ((ISupportInitialize) this.guna2PictureBox2).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
