using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeGenSample.Web.EntityDesign
{
  public interface IAutomobilePartEntityDesign
  {
    public string AutomobilePartGUID { get; set; }
    public string AutomobileGUID { get; set; }
    public string AutomobilePartNumber { get; set; }
    public string AutomobilePartName { get; set; }
    public string AutomobilePartDescription { get; set; }
    public decimal AutomobilePartPrice { get; set; }

  }
}
