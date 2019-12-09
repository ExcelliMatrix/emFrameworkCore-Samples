using CodeGenSample.Design.Web;
using emFrameworkCore.Core;
using emFrameworkCore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeGenSample.Web.Entity
{
  public partial class AutomobilePartWebEntity : AutomobilePartWebEntityDesign
  {

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    /// <summary>
    /// Loads a set of AutomobileParts using the specified Uri and DataRequest.
    /// </summary>
    /// <param name="a_xURI">The database Uri used to perform the action.</param>
    /// <param name="a_xDataRequest">DataRequest that specifies the set of AutomobileParts to be retrieved.</param>
    /// <returns>AutomobilePartWebEntity</returns>
    public IEnumerable<AutomobilePartWebEntity> Load_ByAutomobileGUID(Uri a_xURI, GUID a_xAutomobileGUIt)
    {
      DataRequest xDataRequest = new DataRequest();
      DataResult xDataResult = new DataResult();

      return Load(a_xURI, xDataRequest, out xDataResult);
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    public static partial class Helper
    {
      //=======================================================================
      //=======================================================================

      /// <summary>
      /// Loads a set of AutomobileParts using the specified Uri AutomobileGUID.
      /// </summary>
      /// <param name="a_xURI">The database Uri used to perform the action.</param>
      /// <param name="a_xDataRequest">DataRequest that specifies the set of AutomobileParts to be retrieved.</param>
      /// <returns>AutomobilePartWebEntity</returns>
      public static IEnumerable<AutomobilePartWebEntity> Load_ByAutomobileGUID(Uri a_xURI, GUID a_xAutomobileGUID)
      {
        if (m_xAutomobilePartWebEntity == null)
          m_xAutomobilePartWebEntity = new AutomobilePartWebEntity();

        return m_xAutomobilePartWebEntity.Load_ByAutomobileGUID(a_xURI, a_xAutomobileGUID);
      }

      //=======================================================================
      //=======================================================================
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

  }
}
