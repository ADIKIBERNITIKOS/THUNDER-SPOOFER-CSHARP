
// Type: rTtVXgHRgBSsFavshV.fousyr1O5TImehMQsy
// Assembly: Thunder Spoofer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6911BFCC-B15C-4BF6-865B-4753D2D18ED6
// Assembly location: C:\Users\ADIKIBERNITIKOS\Desktop\111\1_.exe

using System;
using System.Reflection;

namespace rTtVXgHRgBSsFavshV
{
  internal class fousyr1O5TImehMQsy
  {
    internal static object fou1syrO5 = (object) typeof (fousyr1O5TImehMQsy).Assembly.ManifestModule;

    internal static void dmgq1T2v0M(int typemdt)
    {
      Type type = ((Module) fousyr1O5TImehMQsy.fou1syrO5).ResolveType(33554432 + typemdt);
      foreach (FieldInfo field in type.GetFields())
      {
        MethodInfo method = (MethodInfo) ((Module) fousyr1O5TImehMQsy.fou1syrO5).ResolveMethod(field.MetadataToken + 100663296);
        field.SetValue((object) null, (object) (MulticastDelegate) Delegate.CreateDelegate(type, method));
      }
    }

    internal delegate void SFU4mbT3GMret7THonf(object o);
  }
}
