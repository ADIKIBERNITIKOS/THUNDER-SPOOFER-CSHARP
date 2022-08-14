
// Type: c`2
// Assembly: Thunder Spoofer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6911BFCC-B15C-4BF6-865B-4753D2D18ED6
// Assembly location: C:\Users\ADIKIBERNITIKOS\Desktop\111\1_.exe

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[CompilerGenerated]
[DebuggerDisplay("\\{ icon_url = {icon_url}, text = {text} }", Type = "<Anonymous Type>")]
internal sealed class c<g, h>
{
  private readonly g a;
  private readonly h b;
  private static object Sshubexl0dwuFfjZIIu;

  public g icon_url => this.a;

  public h text => this.b;

  public c(g a, h b)
  {
    // ISSUE: reference to a compiler-generated field
    this.a = a;
    // ISSUE: reference to a compiler-generated field
    this.b = b;
  }

  public override bool Equals(object a)
  {
    // ISSUE: variable of a compiler-generated type
    c<g, h> c = a as c<g, h>;
    if (this == c)
      return true;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    return c != null && EqualityComparer<g>.Default.Equals(this.a, c.a) && EqualityComparer<h>.Default.Equals(this.b, c.b);
  }

  public override int GetHashCode() => (EqualityComparer<g>.Default.GetHashCode(this.a) - 934571874) * -1521134295 + EqualityComparer<h>.Default.GetHashCode(this.b);

  public override string ToString()
  {
    string format = "{{ icon_url = {0}, text = {1} }}";
    object[] objArray = new object[2];
    // ISSUE: reference to a compiler-generated field
    g a = this.a;
    objArray[0] = (object) a == null ? (object) (string) null : (object) a.ToString();
    // ISSUE: reference to a compiler-generated field
    h b = this.b;
    objArray[1] = (object) b == null ? (object) (string) null : (object) b.ToString();
    return string.Format((IFormatProvider) null, format, objArray);
  }

  internal static bool q1N5VPxvsrUDu8LPWqG() => c<g, h>.Sshubexl0dwuFfjZIIu == null;
}
