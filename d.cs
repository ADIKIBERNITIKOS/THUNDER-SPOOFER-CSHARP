
// Type: d
// Assembly: Thunder Spoofer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6911BFCC-B15C-4BF6-865B-4753D2D18ED6
// Assembly location: C:\Users\ADIKIBERNITIKOS\Desktop\111\1_.exe

using Microsoft.Win32;
using System;

internal class d
{
  private object m_a;
  private object m_c = (object) new string[7]
  {
    "Hardware\\Description\\System\\CentralProcessor\\0",
    "HARDWARE\\DEVICEMAP\\Scsi\\Scsi Port 0\\Scsi Bus 0\\Target Id 0\\Logical Unit Id 0",
    "SYSTEM\\CurrentControlSet\\Control\\SystemInformation",
    "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion",
    "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\WindowsUpdate",
    "SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e972-e325-11ce-bfc1-08002be10318}\\0001",
    "SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e972-e325-11ce-bfc1-08002be10318}\\0012"
  };
  private object m_d = (object) new string[7, 7]
  {
    {
      "SystemProductName",
      "Identifier",
      "Previous Update Revision",
      "ProcessorNameString",
      "VendorIdentifier",
      "Platform Specific Field1",
      "Component Information"
    },
    {
      "SerialNumber",
      "Identifier",
      "SystemManufacturer",
      "nop",
      "nop",
      "nop",
      "nop"
    },
    {
      "ComputerHardwareId",
      "ComputerHardwareIds",
      "BIOSVendor",
      "ProductId",
      "ProcessorNameString",
      "BIOSReleaseDate",
      "nop"
    },
    {
      "ProductId",
      "InstallDate",
      "InstallTime",
      "nop",
      "nop",
      "nop",
      "nop"
    },
    {
      "SusClientId",
      "nop",
      "nop",
      "nop",
      "nop",
      "nop",
      "nop"
    },
    {
      "NetCfgInstanceId",
      "NetLuidIndex",
      "nop",
      "nop",
      "nop",
      "nop",
      "nop"
    },
    {
      "NetworkAddress",
      "NetCfgInstanceId",
      "NetworkInterfaceInstallTimestamp",
      "nop",
      "nop",
      "nop",
      "nop"
    }
  };

  public void b()
  {
    this.m_a = (object) "pBuU91Vl9qHzPee3zGd7";
    for (int a = 0; a < this.m_c.Length; ++a)
      this.c(a);
  }

  private void c(int a)
  {
    RegistryKey registryKey = Registry.LocalMachine.OpenSubKey((string) this.m_c[a], true);
    if (registryKey == null)
      return;
    for (int index = 0; index < ((Array) this.m_d).GetLength(1) && !(((string[,]) this.m_d)[a, index] == "nop"); ++index)
    {
      registryKey.SetValue(((string[,]) this.m_d)[a, index], this.m_a);
      this.m_a = (object) "Gnaqk5MlQeuWinW2qQ4M";
    }
    registryKey.Close();
  }
}
