using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeGenSample.App.Entity;
using CodeGenSample.Design;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeGenSample.AppTier.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AutomobileController : ControllerBase
  {
    [HttpGet]
    public IEnumerable<IAutomobileEntityDesign> Get()
    {
      IEnumerable<AutomobileAppEntity> xAutomobileAppEntities = AutomobileAppEntity.Helper.Load(ApplicationInfo.SQLConnection);

      return xAutomobileAppEntities;
    }

    [HttpGet("{GUIDString}", Name = "Get")]
    public AutomobileAppEntity Get(string GUIDString)
    {
      AutomobileAppEntity xAutomobileAppEntity = AutomobileAppEntity.Helper.Read(ApplicationInfo.SQLConnection, new emFrameworkCore.Core.GUID(GUIDString));

      return xAutomobileAppEntity;
    }

    // POST: api/Automobile
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT: api/Automobile/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE: api/ApiWithActions/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
