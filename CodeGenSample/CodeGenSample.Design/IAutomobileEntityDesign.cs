using emFrameworkCore.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeGenSample.Design
{
  public interface IAutomobileEntityDesign
  {
    public GUID AutomobileGUID { get; set; }
    public string AutomobileMake { get; set; }
    public string AutomobileModel { get; set; }
    public int AutomobileYear { get; set; }
  }
}
