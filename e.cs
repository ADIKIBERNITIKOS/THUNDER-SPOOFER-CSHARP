
// Type: e
// Assembly: Thunder Spoofer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6911BFCC-B15C-4BF6-865B-4753D2D18ED6
// Assembly location: C:\Users\ADIKIBERNITIKOS\Desktop\111\1_.exe

using System.Collections.Specialized;
using System.Net;

internal class e
{
  public static byte[] a(object a, object b) => new WebClient().UploadValues((string) a, (NameValueCollection) b);
}
