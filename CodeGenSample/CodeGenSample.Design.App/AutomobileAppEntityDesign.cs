using emFrameworkCore.Core;
using emFrameworkCore.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace CodeGenSample.Design.App
{
  [DatabaseTable("CodeGen_Automobile")]
  public class AutomobileAppEntityDesign : IAutomobileEntityDesign
  {
    [Key]
    [DatabaseTableColumn("AutomobileGUID")]
    public GUID AutomobileGUID { get; set; }

    [StringLength(40)]
    [DatabaseTableColumn("AutomobileMake")]
    public string AutomobileMake { get; set; }

    [StringLength(40)]
    [DatabaseTableColumn("AutomobileModel")]
    public string AutomobileModel { get; set; }

    [DatabaseTableColumn("AutomobileYear")]
    public int AutomobileYear { get; set; }
  }
}
