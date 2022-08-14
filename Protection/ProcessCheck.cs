
// Type: Protection.ProcessCheck
// Assembly: Thunder Spoofer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6911BFCC-B15C-4BF6-865B-4753D2D18ED6
// Assembly location: C:\Users\ADIKIBERNITIKOS\Desktop\111\1_.exe

using System;
using System.Collections;
using System.Diagnostics;
using System.Threading;

namespace Protection
{
  internal class ProcessCheck
  {
    public static void Initialize() => new Thread(new ThreadStart(ProcessCheck.check)).Start();

    public static void check()
    {
      if (ProcessCheck.IsDetected())
        ProcessCheck.msg();
      if (!ProcessCheck.Run())
        return;
      ProcessCheck.msg();
    }

    internal static void msg() => Environment.Exit(0);

    private static IntPtr GetModuleHandle(object libName)
    {
      foreach (ProcessModule module in (ReadOnlyCollectionBase) Process.GetCurrentProcess().Modules)
      {
        if (module.ModuleName.ToLower().Contains(((string) libName).ToLower()))
          return module.BaseAddress;
      }
      return IntPtr.Zero;
    }

    internal static bool IsDetected() => ProcessCheck.GetModuleHandle((object) "SbieDll.dll") != IntPtr.Zero;

    internal static bool Run()
    {
      bool flag = false;
      if (!Debugger.IsAttached && !Debugger.IsLogging())
      {
        string[] strArray = new string[41]
        {
          "dnspy",
          "codecracker",
          "x32dbg",
          "x64dbg",
          "ollydbg",
          "ida",
          "charles",
          "simpleassembly",
          "peek",
          "httpanalyzer",
          "httpdebug",
          "fiddler",
          "wireshark",
          "dbx",
          "mdbg",
          "gdb",
          "windbg",
          "dbgclr",
          "kdb",
          "kgdb",
          "mdb",
          "processhacker",
          "scylla_x86",
          "scylla_x64",
          "scylla",
          "idau64",
          "idau",
          "idaq",
          "idaq64",
          "idaw",
          "idaw64",
          "idag",
          "idag64",
          "ida64",
          "ida",
          "ImportREC",
          "IMMUNITYDEBUGGER",
          "MegaDumper",
          "CodeBrowser",
          "reshacker",
          "cheat engine"
        };
        foreach (Process process in Process.GetProcesses())
        {
          if (process != Process.GetCurrentProcess())
          {
            for (int index = 0; index < strArray.Length; ++index)
            {
              if (process.ProcessName.ToLower().Contains(strArray[index]))
                flag = true;
              if (process.MainWindowTitle.ToLower().Contains(strArray[index]))
                flag = true;
            }
          }
        }
      }
      return flag;
    }
  }
}
