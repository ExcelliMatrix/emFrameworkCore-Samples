using emFrameworkCore.Core;
using emFrameworkCore.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeGenSample.Design.Web
{
  [WebResource("AutomobilePart")]
  public class AutomobilePartWebEntityDesign : IAutomobilePartEntityDesign
  {
    public GUID AutomobilePartGUID { get; set; }
    public GUID AutomobileGUID { get; set; }
    public string AutomobilePartNumber { get; set; }
    public string AutomobilePartName { get; set; }
    public string AutomobilePartDescription { get; set; }
    public decimal AutomobilePartPrice { get; set; }

  }
}
