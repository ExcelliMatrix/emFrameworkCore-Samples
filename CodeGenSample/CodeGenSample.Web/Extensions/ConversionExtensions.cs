using CodeGenSample.Design;
using CodeGenSample.WebTier.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeGenSample.Web.Entity.Extensions
{
  public static class ConversionExtensions
  {

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    public static IEnumerable<AutomobileWebEntity> ToAutomobileWebEntity(this IEnumerable<IAutomobileEntityDesign> a_xAutomobileEntityDesigns)
    {
      List<AutomobileWebEntity> xReturnValue = null;

      if (a_xAutomobileEntityDesigns != null)
      {
        xReturnValue = new List<AutomobileWebEntity>();
        foreach (IAutomobileEntityDesign xAutomobileEntityDesign in a_xAutomobileEntityDesigns)
          xReturnValue.Add((AutomobileWebEntity)xAutomobileEntityDesign);
      }

      return xReturnValue;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    public static IEnumerable<AutomobileViewModel> ToAutomobileViewModel(this IEnumerable<IAutomobileEntityDesign> a_xAutomobileEntityDesigns)
    {
      List<AutomobileViewModel> xReturnValue = null;

      if (a_xAutomobileEntityDesigns != null)
      {
        xReturnValue = new List<AutomobileViewModel>();
        foreach (AutomobileWebEntity xAutomobileWebEntity in a_xAutomobileEntityDesigns)
          xReturnValue.Add(xAutomobileWebEntity.ToAutomobileViewModel());
      }

      return xReturnValue;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    public static AutomobileViewModel ToAutomobileViewModel(this IAutomobileEntityDesign a_xAutomobileEntityDesign)
    {
      AutomobileViewModel xReturnValue = new AutomobileViewModel()
      {
        AutomobileGUID = a_xAutomobileEntityDesign.AutomobileGUID,
        AutomobileMake = a_xAutomobileEntityDesign.AutomobileMake,
        AutomobileModel =a_xAutomobileEntityDesign.AutomobileModel,
        AutomobileYear = a_xAutomobileEntityDesign.AutomobileYear
      };

      return xReturnValue;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    public static IEnumerable<AutomobilePartViewModel> ToAutomobilePartViewModel(this IEnumerable<IAutomobilePartEntityDesign> a_xAutomobilePartEntityDesigns)
    {
      List<AutomobilePartViewModel> xReturnValue = null;

      if (a_xAutomobilePartEntityDesigns != null)
      {
        xReturnValue = new List<AutomobilePartViewModel>();
        foreach (AutomobilePartWebEntity xAutomobilePartWebEntity in a_xAutomobilePartEntityDesigns)
          xReturnValue.Add(xAutomobilePartWebEntity.ToAutomobilePartViewModel());
      }

      return xReturnValue;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    public static AutomobilePartViewModel ToAutomobilePartViewModel(this IAutomobilePartEntityDesign a_xAutomobilePartEntityDesign)
    {
      AutomobilePartViewModel xReturnValue = new AutomobilePartViewModel()
      {
        AutomobilePartGUID = a_xAutomobilePartEntityDesign.AutomobilePartGUID,
        AutomobilePartNumber = a_xAutomobilePartEntityDesign.AutomobilePartNumber,
        AutomobilePartName = a_xAutomobilePartEntityDesign.AutomobilePartName,
        AutomobilePartPrice = a_xAutomobilePartEntityDesign.AutomobilePartPrice,
        AutomobilePartDescription = a_xAutomobilePartEntityDesign.AutomobilePartDescription,
        AutomobileGUID = a_xAutomobilePartEntityDesign.AutomobileGUID
      };

      return xReturnValue;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

  }
}
