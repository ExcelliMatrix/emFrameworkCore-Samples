using CodeGenSample.Design;
using emFrameworkCore.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeGenSample.WebTier.Models
{
  public class AutomobilePartViewModel : IAutomobilePartEntityDesign
  {
    public GUID AutomobilePartGUID { get; set; }
    public GUID AutomobileGUID { get; set; }
    public string AutomobilePartNumber { get; set; }
    public string AutomobilePartName { get; set; }
    public string AutomobilePartDescription { get; set; }
    public decimal AutomobilePartPrice { get; set; }
    public string AutomobilePartDeleted { get; set; }
  }
}
