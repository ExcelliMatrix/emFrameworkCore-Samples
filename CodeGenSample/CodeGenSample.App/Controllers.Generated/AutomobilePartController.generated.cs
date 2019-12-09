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
  public partial class AutomobilePartController : ControllerBase
  {

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    [HttpGet("Load")]
    public WebAPIResult<IEnumerable<AutomobilePartAppEntity>> Load()
    {
      WebAPIResult<IEnumerable<AutomobilePartAppEntity>> xReturnValue = new WebAPIResult<IEnumerable<AutomobilePartAppEntity>>();

      DataRequest xDataRequest = new DataRequest()
      {
        DeleteColumnName = "AutomobilePartDeleted",
        ShowDeletedRow = false
      };
      DataResult xDataResult = new DataResult();
      xReturnValue.Result = AutomobilePartAppEntity.Helper.Load(ApplicationInfo.SQLConnection, xDataRequest, out xDataResult);
      xReturnValue.DataResult = xDataResult;

      return xReturnValue;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    [HttpPost("Load")]
    public WebAPIResult<IEnumerable<AutomobilePartAppEntity>> Load(DataRequest a_xDataRequest)
    {
      WebAPIResult<IEnumerable<AutomobilePartAppEntity>> xReturnValue = new WebAPIResult<IEnumerable<AutomobilePartAppEntity>>();

      DataResult xDataResult = new DataResult();
      xReturnValue.Result = AutomobilePartAppEntity.Helper.Load(ApplicationInfo.SQLConnection, a_xDataRequest, out xDataResult);
      xReturnValue.DataResult = xDataResult;

      return xReturnValue;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    [HttpGet("Read/{a_sAutomobilePartGUID}")]
    public AutomobilePartAppEntity Read(string a_sAutomobilePartGUID)
    {
      GUID xAutomobilePartGUID = new GUID(a_sAutomobilePartGUID);
      AutomobilePartAppEntity xAutomobilePartAppEntity = AutomobilePartAppEntity.Helper.Read(ApplicationInfo.SQLConnection, xAutomobilePartGUID);

      return xAutomobilePartAppEntity;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

  }
}
