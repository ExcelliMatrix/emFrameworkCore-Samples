using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeGenSample.Web.EntityDesign
{
  public interface IAutomobileEntityDesign
  {
    public string AutomobileGUID { get; set; }
    public string AutomobileMake { get; set; }
    public string AutomobileModel { get; set; }
    public int AutomobileYear { get; set; }
  }
}
