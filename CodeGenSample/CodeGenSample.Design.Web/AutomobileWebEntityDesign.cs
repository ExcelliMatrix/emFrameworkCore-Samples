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
  [WebResource("Automobile")]
  public class AutomobileWebEntityDesign : IAutomobileEntityDesign
  {
    public GUID AutomobileGUID { get; set; }
    public string AutomobileMake { get; set; }
    public string AutomobileModel { get; set; }
    public int AutomobileYear { get; set; }
  }
}
