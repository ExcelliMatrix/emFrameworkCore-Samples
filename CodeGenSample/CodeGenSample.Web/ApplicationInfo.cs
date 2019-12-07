using emFrameworkCore.Core;
using System;

namespace CodeGenSample
{
  public static class ApplicationInfo
  {
    public static string Name { get { return "CodeGenSample.Web"; } }
    public static ApplicationTier Tier { get { return ApplicationTier.Web; } }
  }
}
