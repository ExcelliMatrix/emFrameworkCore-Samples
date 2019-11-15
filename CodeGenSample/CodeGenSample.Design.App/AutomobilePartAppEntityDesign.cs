using emFrameworkCore.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeGenSample.Design.App
{
  [Table("CodeGen_AutomobilePart")]
  public class AutomobilePartAppEntityDesign : IAutomobilePartEntityDesign
  {
    [Key]
    public GUID AutomobilePartGUID { get; set; }
    [ForeignKey("AutomobileGUID")]
    public GUID AutomobileGUID { get; set; }
    public string AutomobilePartNumber { get; set; }
    public string AutomobilePartName { get; set; }
    public string AutomobilePartDescription { get; set; }
    public decimal AutomobilePartPrice { get; set; }

  }
}
