using emFrameworkCore.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeGenSample.Design
{
  public interface IAutomobilePartEntityDesign
  {
    GUID AutomobilePartGUID { get; set; }
    GUID AutomobileGUID { get; set; }
    string AutomobilePartNumber { get; set; }
    string AutomobilePartName { get; set; }
    string AutomobilePartDescription { get; set; }
    decimal AutomobilePartPrice { get; set; }
    string AutomobilePartDeleted { get; set; }
  }
}
