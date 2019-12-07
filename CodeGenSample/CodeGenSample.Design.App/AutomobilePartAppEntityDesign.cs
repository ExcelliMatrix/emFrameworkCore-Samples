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
  [DatabaseTable("CodeGen_AutomobilePart")]
  public class AutomobilePartAppEntityDesign : IAutomobilePartEntityDesign
  {
    [Key]
    [DatabaseTableColumn("AutomobilePartGUID")]
    public GUID AutomobilePartGUID { get; set; }

    [ForeignKey("AutomobileGUID")]
    [DatabaseTableColumn("AutomobileGUID")]
    public GUID AutomobileGUID { get; set; }

    [StringLength(40)]
    [DatabaseTableColumn("AutomobilePartNumber")]
    public string AutomobilePartNumber { get; set; }

    [StringLength(40)]
    [DatabaseTableColumn("AutomobilePartName")]
    public string AutomobilePartName { get; set; }

    [StringLength(40)]
    [DatabaseTableColumn("AutomobilePartDescription")]
    public string AutomobilePartDescription { get; set; }

    [StringLength(40)]
    [DatabaseTableColumn("AutomobilePartPrice")]
    public decimal AutomobilePartPrice { get; set; }

    [StringLength(40)]
    [DatabaseTableColumn("AutomobilePartDeleted")]
    public string AutomobilePartDeleted { get; set; }
  }
}
