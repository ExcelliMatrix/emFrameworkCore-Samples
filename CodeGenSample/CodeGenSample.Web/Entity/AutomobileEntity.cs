using CodeGenSample.Web.EntityDesign;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeGenSample.Web.Entity
{
  public partial class AutomobileEntity : AppEntity, IAutomobileEntityDesign
  {
    public string AutomobileGUID { get; set; }
    public string AutomobileMake { get; set; }
    public string AutomobileModel { get; set; }
    public int AutomobileYear { get; set; }
  }
}
