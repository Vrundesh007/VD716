using System;
using System.Drawing;
using Grasshopper;
using Grasshopper.Kernel;

namespace VD716
{
  public class VD716Info : GH_AssemblyInfo
  {
    public override string Name => "VD716";

    //Return a 24x24 pixel bitmap to represent this GHA library.
    public override Bitmap Icon => null;

    //Return a short string describing the purpose of this GHA library.
    public override string Description => "";

    public override Guid Id => new Guid("c330cda9-94c2-40ab-8acb-13bffd573f12");

    //Return a string identifying you or your company.
    public override string AuthorName => "";

    //Return a string representing your preferred contact details.
    public override string AuthorContact => "";

    //Return a string representing the version.  This returns the same version as the assembly.
    public override string AssemblyVersion => GetType().Assembly.GetName().Version.ToString();
  }
}