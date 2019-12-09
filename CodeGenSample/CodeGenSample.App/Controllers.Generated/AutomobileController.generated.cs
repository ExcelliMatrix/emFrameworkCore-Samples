using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeGenSample.App.Entity;
using CodeGenSample.Design;
using emFrameworkCore.Core;
using emFrameworkCore.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeGenSample.AppTier.Controllers
{
  public partial class AutomobileController : ControllerBase
  {

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    [HttpGet("Load")]
    public WebAPIResult<IEnumerable<AutomobileAppEntity>> Load()
    {
      WebAPIResult<IEnumerable<AutomobileAppEntity>> xReturnValue = new WebAPIResult<IEnumerable<AutomobileAppEntity>>();

      DataRequest xDataRequest = new DataRequest()
      {
        DeleteColumnName = "AutomobileDeleted",
        ShowDeletedRow = false
      };
      DataResult xDataResult = new DataResult();
      xReturnValue.Result = AutomobileAppEntity.Helper.Load(ApplicationInfo.SQLConnection, xDataRequest, out xDataResult);
      xReturnValue.DataResult = xDataResult;

      return xReturnValue;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    [HttpPost("Load")]
    public WebAPIResult<IEnumerable<AutomobileAppEntity>> Load(DataRequest a_xDataRequest)
    {
      WebAPIResult<IEnumerable<AutomobileAppEntity>> xReturnValue = new WebAPIResult<IEnumerable<AutomobileAppEntity>>();

      DataResult xDataResult = new DataResult();
      xReturnValue.Result = AutomobileAppEntity.Helper.Load(ApplicationInfo.SQLConnection, a_xDataRequest, out xDataResult);
      xReturnValue.DataResult = xDataResult;

      return xReturnValue;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    [HttpGet("Read/{a_sAutomobileGUID}")]
    public AutomobileAppEntity Read(string a_sAutomobileGUID)
    {
      GUID xAutomobileGUID = new GUID(a_sAutomobileGUID);
      AutomobileAppEntity xAutomobileAppEntity = AutomobileAppEntity.Helper.Read(ApplicationInfo.SQLConnection, xAutomobileGUID);

      return xAutomobileAppEntity;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

  }
}
