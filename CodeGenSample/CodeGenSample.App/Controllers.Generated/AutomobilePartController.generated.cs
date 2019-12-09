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
    public IEnumerable<AutomobilePartAppEntity> Load()
    {
      DataRequest xDataRequest = new DataRequest()
      {
        DeleteColumnName = "AutomobilePartDeleted",
        ShowDeletedRow = false
      };
      DataResult xDataResult = new DataResult();
      IEnumerable<AutomobilePartAppEntity> xAutomobileAppEntities = AutomobilePartAppEntity.Helper.Load(ApplicationInfo.SQLConnection, xDataRequest, out xDataResult);

      return xAutomobileAppEntities;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    [HttpPost("Load")]
    public IEnumerable<AutomobilePartAppEntity> Load(DataRequest a_xDataRequest)
    {
      DataResult xDataResult = new DataResult();
      IEnumerable<AutomobilePartAppEntity> xAutomobilePartAppEntity = AutomobilePartAppEntity.Helper.Load(ApplicationInfo.SQLConnection, a_xDataRequest, out xDataResult);

      return xAutomobilePartAppEntity;
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
