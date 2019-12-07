using emFrameworkCore.Core;
using System;

namespace CodeGenSample
{
  public static class ApplicationInfo
  {
    public static string Name { get { return "CodeGenSample.Web"; } }
    public static ApplicationTier Tier { get { return ApplicationTier.Web; } }
    public static string BaseURL { get { return "http://localhost:60999/"; } }
    public static Uri BaseURI { get { return new Uri(BaseURL); } }
  }
}
