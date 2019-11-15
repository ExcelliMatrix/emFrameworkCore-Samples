using emFrameworkCore.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeGenSample.Design.App
{
  [Table("CodeGen_Automobile")]
  public class AutomobileAppEntityDesign : IAutomobileEntityDesign
  {
    [Key]
    public GUID AutomobileGUID { get; set; }
    public string AutomobileMake { get; set; }
    public string AutomobileModel { get; set; }
    public int AutomobileYear { get; set; }
  }
}
