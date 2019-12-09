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
    public IEnumerable<AutomobileAppEntity> Load()
    {
      IEnumerable<AutomobileAppEntity> xAutomobileAppEntities = AutomobileAppEntity.Helper.Load(ApplicationInfo.SQLConnection);

      return xAutomobileAppEntities;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    [HttpPost("Load")]
    public IEnumerable<AutomobileAppEntity> Load(DataRequest a_xDataRequest)
    {
      IEnumerable<AutomobileAppEntity> xAutomobileAppEntity = AutomobileAppEntity.Helper.Load(ApplicationInfo.SQLConnection, a_xDataRequest);

      return xAutomobileAppEntity;
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
