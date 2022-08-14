
// Type: Costura.AssemblyLoader
// Assembly: Thunder Spoofer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6911BFCC-B15C-4BF6-865B-4753D2D18ED6
// Assembly location: C:\Users\ADIKIBERNITIKOS\Desktop\111\1_.exe

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Costura
{
  [CompilerGenerated]
  internal static class AssemblyLoader
  {
    private static object nullCacheLock = new object();
    private static Dictionary<string, bool> nullCache = new Dictionary<string, bool>();
    private static Dictionary<string, string> assemblyNames = new Dictionary<string, string>();
    private static Dictionary<string, string> symbolNames = new Dictionary<string, string>();
    private static int isAttached;

    private static string CultureToString(CultureInfo culture) => culture != null ? culture.Name : "";

    private static Assembly ReadExistingAssembly(AssemblyName name)
    {
      foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
      {
        AssemblyName name1 = assembly.GetName();
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        if (string.Equals(name1.Name, name.Name, StringComparison.InvariantCultureIgnoreCase) && string.Equals(AssemblyLoader.CultureToString(name1.CultureInfo), AssemblyLoader.CultureToString(name.CultureInfo), StringComparison.InvariantCultureIgnoreCase))
          return assembly;
      }
      return (Assembly) null;
    }

    private static void CopyTo(Stream source, Stream destination)
    {
      byte[] buffer = new byte[81920];
      int count;
      while ((count = source.Read(buffer, 0, buffer.Length)) != 0)
        destination.Write(buffer, 0, count);
    }

    private static Stream LoadStream(string fullName)
    {
      Assembly executingAssembly = Assembly.GetExecutingAssembly();
      if (!fullName.EndsWith(".compressed"))
        return executingAssembly.GetManifestResourceStream(fullName);
      using (Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(fullName))
      {
        using (DeflateStream source = new DeflateStream(manifestResourceStream, CompressionMode.Decompress))
        {
          MemoryStream destination = new MemoryStream();
          // ISSUE: reference to a compiler-generated method
          AssemblyLoader.CopyTo((Stream) source, (Stream) destination);
          destination.Position = 0L;
          return (Stream) destination;
        }
      }
    }

    private static Stream LoadStream(Dictionary<string, string> resourceNames, string name)
    {
      string fullName;
      // ISSUE: reference to a compiler-generated method
      return resourceNames.TryGetValue(name, out fullName) ? AssemblyLoader.LoadStream(fullName) : (Stream) null;
    }

    private static byte[] ReadStream(Stream stream)
    {
      byte[] buffer = new byte[stream.Length];
      stream.Read(buffer, 0, buffer.Length);
      return buffer;
    }

    private static Assembly ReadFromEmbeddedResources(
      Dictionary<string, string> assemblyNames,
      Dictionary<string, string> symbolNames,
      AssemblyName requestedAssemblyName)
    {
      string name = requestedAssemblyName.Name.ToLowerInvariant();
      if (requestedAssemblyName.CultureInfo != null && !string.IsNullOrEmpty(requestedAssemblyName.CultureInfo.Name))
        name = requestedAssemblyName.CultureInfo.Name + "." + name;
      byte[] rawAssembly;
      // ISSUE: reference to a compiler-generated method
      using (Stream stream = AssemblyLoader.LoadStream(assemblyNames, name))
      {
        if (stream == null)
          return (Assembly) null;
        // ISSUE: reference to a compiler-generated method
        rawAssembly = AssemblyLoader.ReadStream(stream);
      }
      // ISSUE: reference to a compiler-generated method
      using (Stream stream = AssemblyLoader.LoadStream(symbolNames, name))
      {
        if (stream != null)
        {
          // ISSUE: reference to a compiler-generated method
          byte[] rawSymbolStore = AssemblyLoader.ReadStream(stream);
          return Assembly.Load(rawAssembly, rawSymbolStore);
        }
      }
      return Assembly.Load(rawAssembly);
    }

    public static Assembly ResolveAssembly(object sender, ResolveEventArgs e)
    {
      // ISSUE: reference to a compiler-generated field
      lock (AssemblyLoader.nullCacheLock)
      {
        // ISSUE: reference to a compiler-generated field
        if (AssemblyLoader.nullCache.ContainsKey(e.Name))
          return (Assembly) null;
      }
      AssemblyName assemblyName = new AssemblyName(e.Name);
      // ISSUE: reference to a compiler-generated method
      Assembly assembly1 = AssemblyLoader.ReadExistingAssembly(assemblyName);
      if ((object) assembly1 != null)
        return assembly1;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      Assembly assembly2 = AssemblyLoader.ReadFromEmbeddedResources(AssemblyLoader.assemblyNames, AssemblyLoader.symbolNames, assemblyName);
      if ((object) assembly2 == null)
      {
        // ISSUE: reference to a compiler-generated field
        lock (AssemblyLoader.nullCacheLock)
        {
          // ISSUE: reference to a compiler-generated field
          AssemblyLoader.nullCache[e.Name] = true;
        }
        if ((assemblyName.Flags & AssemblyNameFlags.Retargetable) != AssemblyNameFlags.None)
          assembly2 = Assembly.Load(assemblyName);
      }
      return assembly2;
    }

    static AssemblyLoader()
    {
      // ISSUE: reference to a compiler-generated field
      AssemblyLoader.assemblyNames.Add("costura", "costura.costura.dll.compressed");
      // ISSUE: reference to a compiler-generated field
      AssemblyLoader.symbolNames.Add("costura", "costura.costura.pdb.compressed");
      // ISSUE: reference to a compiler-generated field
      AssemblyLoader.assemblyNames.Add("discord.net.commands", "costura.discord.net.commands.dll.compressed");
      // ISSUE: reference to a compiler-generated field
      AssemblyLoader.assemblyNames.Add("discord.net.core", "costura.discord.net.core.dll.compressed");
      // ISSUE: reference to a compiler-generated field
      AssemblyLoader.assemblyNames.Add("discord.net.interactions", "costura.discord.net.interactions.dll.compressed");
      // ISSUE: reference to a compiler-generated field
      AssemblyLoader.assemblyNames.Add("discord.net.rest", "costura.discord.net.rest.dll.compressed");
      // ISSUE: reference to a compiler-generated field
      AssemblyLoader.assemblyNames.Add("discord.net.webhook", "costura.discord.net.webhook.dll.compressed");
      // ISSUE: reference to a compiler-generated field
      AssemblyLoader.assemblyNames.Add("discord.net.websocket", "costura.discord.net.websocket.dll.compressed");
      // ISSUE: reference to a compiler-generated field
      AssemblyLoader.assemblyNames.Add("discordrpc", "costura.discordrpc.dll.compressed");
      // ISSUE: reference to a compiler-generated field
      AssemblyLoader.symbolNames.Add("discordrpc", "costura.discordrpc.pdb.compressed");
      // ISSUE: reference to a compiler-generated field
      AssemblyLoader.assemblyNames.Add("guna.ui2", "costura.guna.ui2.dll.compressed");
      // ISSUE: reference to a compiler-generated field
      AssemblyLoader.assemblyNames.Add("metroframework", "costura.metroframework.dll.compressed");
      // ISSUE: reference to a compiler-generated field
      AssemblyLoader.assemblyNames.Add("metroframework.fonts", "costura.metroframework.fonts.dll.compressed");
      // ISSUE: reference to a compiler-generated field
      AssemblyLoader.assemblyNames.Add("microsoft.aspnetcore.hosting.abstractions", "costura.microsoft.aspnetcore.hosting.abstractions.dll.compressed");
      // ISSUE: reference to a compiler-generated field
      AssemblyLoader.assemblyNames.Add("microsoft.aspnetcore.hosting.server.abstractions", "costura.microsoft.aspnetcore.hosting.server.abstractions.dll.compressed");
      // ISSUE: reference to a compiler-generated field
      AssemblyLoader.assemblyNames.Add("microsoft.aspnetcore.http.abstractions", "costura.microsoft.aspnetcore.http.abstractions.dll.compressed");
      // ISSUE: reference to a compiler-generated field
      AssemblyLoader.assemblyNames.Add("microsoft.aspnetcore.http.extensions", "costura.microsoft.aspnetcore.http.extensions.dll.compressed");
      // ISSUE: reference to a compiler-generated field
      AssemblyLoader.assemblyNames.Add("microsoft.aspnetcore.http.features", "costura.microsoft.aspnetcore.http.features.dll.compressed");
      // ISSUE: reference to a compiler-generated field
      AssemblyLoader.assemblyNames.Add("microsoft.aspnetcore.websockets", "costura.microsoft.aspnetcore.websockets.dll.compressed");
      // ISSUE: reference to a compiler-generated field
      AssemblyLoader.assemblyNames.Add("microsoft.bcl.asyncinterfaces", "costura.microsoft.bcl.asyncinterfaces.dll.compressed");
      // ISSUE: reference to a compiler-generated field
      AssemblyLoader.assemblyNames.Add("microsoft.extensions.configuration.abstractions", "costura.microsoft.extensions.configuration.abstractions.dll.compressed");
      // ISSUE: reference to a compiler-generated field
      AssemblyLoader.assemblyNames.Add("microsoft.extensions.configuration.binder", "costura.microsoft.extensions.configuration.binder.dll.compressed");
      // ISSUE: reference to a compiler-generated field
      AssemblyLoader.assemblyNames.Add("microsoft.extensions.configuration", "costura.microsoft.extensions.configuration.dll.compressed");
      // ISSUE: reference to a compiler-generated field
      AssemblyLoader.assemblyNames.Add("microsoft.extensions.dependencyinjection.abstractions", "costura.microsoft.extensions.dependencyinjection.abstractions.dll.compressed");
      // ISSUE: reference to a compiler-generated field
      AssemblyLoader.assemblyNames.Add("microsoft.extensions.fileproviders.abstractions", "costura.microsoft.extensions.fileproviders.abstractions.dll.compressed");
      // ISSUE: reference to a compiler-generated field
      AssemblyLoader.assemblyNames.Add("microsoft.extensions.hosting.abstractions", "costura.microsoft.extensions.hosting.abstractions.dll.compressed");
      // ISSUE: reference to a compiler-generated field
      AssemblyLoader.assemblyNames.Add("microsoft.extensions.logging.abstractions", "costura.microsoft.extensions.logging.abstractions.dll.compressed");
      // ISSUE: reference to a compiler-generated field
      AssemblyLoader.assemblyNames.Add("microsoft.extensions.logging", "costura.microsoft.extensions.logging.dll.compressed");
      // ISSUE: reference to a compiler-generated field
      AssemblyLoader.assemblyNames.Add("microsoft.extensions.options", "costura.microsoft.extensions.options.dll.compressed");
      // ISSUE: reference to a compiler-generated field
      AssemblyLoader.assemblyNames.Add("microsoft.extensions.primitives", "costura.microsoft.extensions.primitives.dll.compressed");
      // ISSUE: reference to a compiler-generated field
      AssemblyLoader.assemblyNames.Add("microsoft.net.http.headers", "costura.microsoft.net.http.headers.dll.compressed");
      // ISSUE: reference to a compiler-generated field
      AssemblyLoader.assemblyNames.Add("netcorestack.websockets", "costura.netcorestack.websockets.dll.compressed");
      // ISSUE: reference to a compiler-generated field
      AssemblyLoader.assemblyNames.Add("netcorestack.websockets.proxyclient", "costura.netcorestack.websockets.proxyclient.dll.compressed");
      // ISSUE: reference to a compiler-generated field
      AssemblyLoader.assemblyNames.Add("newtonsoft.json", "costura.newtonsoft.json.dll.compressed");
      // ISSUE: reference to a compiler-generated field
      AssemblyLoader.assemblyNames.Add("siticone.ui", "costura.siticone.ui.dll.compressed");
      // ISSUE: reference to a compiler-generated field
      AssemblyLoader.assemblyNames.Add("system.buffers", "costura.system.buffers.dll.compressed");
      // ISSUE: reference to a compiler-generated field
      AssemblyLoader.assemblyNames.Add("system.collections.immutable", "costura.system.collections.immutable.dll.compressed");
      // ISSUE: reference to a compiler-generated field
      AssemblyLoader.assemblyNames.Add("system.componentmodel.annotations", "costura.system.componentmodel.annotations.dll.compressed");
      // ISSUE: reference to a compiler-generated field
      AssemblyLoader.assemblyNames.Add("system.diagnostics.diagnosticsource", "costura.system.diagnostics.diagnosticsource.dll.compressed");
      // ISSUE: reference to a compiler-generated field
      AssemblyLoader.assemblyNames.Add("system.interactive.async", "costura.system.interactive.async.dll.compressed");
      // ISSUE: reference to a compiler-generated field
      AssemblyLoader.assemblyNames.Add("system.linq.async", "costura.system.linq.async.dll.compressed");
      // ISSUE: reference to a compiler-generated field
      AssemblyLoader.assemblyNames.Add("system.memory", "costura.system.memory.dll.compressed");
      // ISSUE: reference to a compiler-generated field
      AssemblyLoader.assemblyNames.Add("system.net.websockets.websocketprotocol", "costura.system.net.websockets.websocketprotocol.dll.compressed");
      // ISSUE: reference to a compiler-generated field
      AssemblyLoader.assemblyNames.Add("system.numerics.vectors", "costura.system.numerics.vectors.dll.compressed");
      // ISSUE: reference to a compiler-generated field
      AssemblyLoader.assemblyNames.Add("system.reactive", "costura.system.reactive.dll.compressed");
      // ISSUE: reference to a compiler-generated field
      AssemblyLoader.assemblyNames.Add("system.runtime.compilerservices.unsafe", "costura.system.runtime.compilerservices.unsafe.dll.compressed");
      // ISSUE: reference to a compiler-generated field
      AssemblyLoader.assemblyNames.Add("system.text.encodings.web", "costura.system.text.encodings.web.dll.compressed");
      // ISSUE: reference to a compiler-generated field
      AssemblyLoader.assemblyNames.Add("system.threading.tasks.extensions", "costura.system.threading.tasks.extensions.dll.compressed");
      // ISSUE: reference to a compiler-generated field
      AssemblyLoader.assemblyNames.Add("system.valuetuple", "costura.system.valuetuple.dll.compressed");
      // ISSUE: reference to a compiler-generated field
      AssemblyLoader.assemblyNames.Add("winformanimation", "costura.winformanimation.dll.compressed");
    }

    public static void Attach()
    {
      // ISSUE: reference to a compiler-generated field
      if (Interlocked.Exchange(ref AssemblyLoader.isAttached, 1) == 1)
        return;
      AppDomain.CurrentDomain.AssemblyResolve += (ResolveEventHandler) ((sender, e) =>
      {
        // ISSUE: reference to a compiler-generated field
        lock (AssemblyLoader.nullCacheLock)
        {
          // ISSUE: reference to a compiler-generated field
          if (AssemblyLoader.nullCache.ContainsKey(e.Name))
            return (Assembly) null;
        }
        AssemblyName assemblyName = new AssemblyName(e.Name);
        // ISSUE: reference to a compiler-generated method
        Assembly assembly1 = AssemblyLoader.ReadExistingAssembly(assemblyName);
        if ((object) assembly1 != null)
          return assembly1;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        Assembly assembly2 = AssemblyLoader.ReadFromEmbeddedResources(AssemblyLoader.assemblyNames, AssemblyLoader.symbolNames, assemblyName);
        if ((object) assembly2 == null)
        {
          // ISSUE: reference to a compiler-generated field
          lock (AssemblyLoader.nullCacheLock)
          {
            // ISSUE: reference to a compiler-generated field
            AssemblyLoader.nullCache[e.Name] = true;
          }
          if ((assemblyName.Flags & AssemblyNameFlags.Retargetable) != AssemblyNameFlags.None)
            assembly2 = Assembly.Load(assemblyName);
        }
        return assembly2;
      });
    }
  }
}
