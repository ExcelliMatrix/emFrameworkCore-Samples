using emFrameworkCore.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeGenSample.AppTier
{
  public class AppUserInfo : IUserInfo
  {
    public GUID UserGUID { get; set; }
    public string UserIPAddress { get; set; }
    public string UserHostName { get; set; }
  }
}
