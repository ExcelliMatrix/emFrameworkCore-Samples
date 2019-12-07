using emFrameworkCore.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeGenSample.Design
{
  public interface IAutomobileEntityDesign
  {
    GUID AutomobileGUID { get; set; }
    string AutomobileMake { get; set; }
    string AutomobileModel { get; set; }
    int AutomobileYear { get; set; }
    string AutomobileDeleted { get; set; }
  }
}
