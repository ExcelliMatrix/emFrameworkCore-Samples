
//********************************************************************
//*                                                                  *
//* Copyright (c) 2016-2019 ExcelliMatrix, Inc. All Rights Reserved. *
//*                                                                  *
//*    This code was generated from an emFrameworkCode Template.     *
//*                                                                  *
//*                     DO NOT MODIFY THIS FILE.                     *
//*                     -----------------------                      *
//*                                                                  *
//********************************************************************

// Directory:        {{SolutionDir}}CodeGenSample.Web\Entity.Generated
// CodeGenFilename:  (CodeGen).xml
// TemplateFilename: (Entity).tt

using CodeGenSample.Design.Web;
using CodeGenSample.WebTier;
using emFrameworkCore.Core;
using emFrameworkCore.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;


namespace CodeGenSample.Web.Entity
{
 public partial class AutomobileWebEntity : AutomobileWebEntityDesign, IEntity_WebAPIConnection<AutomobileWebEntity>
  {

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    public enum CRUDAction { Create, Read, Update, Delete, Load }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    public IUserInfo UserInfo
    {
      get
      {
        if (m_xWebUserInfo == null)
          m_xWebUserInfo = new WebUserInfo();
        return m_xWebUserInfo;
      }
      set
      {
        m_xWebUserInfo = (WebUserInfo)value;
      }
    }
    private WebUserInfo m_xWebUserInfo;

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    public static DataRequest DataRequestFactory()
    {
      DataRequest xReturnValue = new DataRequest()
      {
        DeleteColumnName = "AutomobileDeleted",
        ShowDeletedRow = false
      };

      return xReturnValue;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    /// <summary>
    /// Create a new Automobile using the specified URI.
    /// </summary>
    /// <param name="a_xURI">The database Connection used to perform the action. The Connection should be opened prior to calling the method.</param>
    /// <returns>AutomobileWebEntity</returns>
    public AutomobileWebEntity Create(Uri a_xURI)
    {
      AutomobileWebEntity xReturnValue = null;

      try
      {
        //----- Read after confirmation -----
        xReturnValue = Read(a_xURI, AutomobileGUID);
      }
      catch (Exception xException)
      {

#if DEBUG
        if (System.Diagnostics.Debugger.IsAttached)
        {
          System.Diagnostics.Debug.WriteLine(xException.ToString());
          System.Diagnostics.Debugger.Break();
        }
#endif
        throw xException;
      }
      finally
      {
      }

      return xReturnValue;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    /// <summary>
    /// Read an existing Automobile using the specified URI and AutomobileGUID.
    /// </summary>
    /// <param name="a_xURI">The database Connection used to perform the action.</param>
    /// <param name="a_xAutomobileGUID">The unique identifies of the Automobile to be retrieved.</param>
    /// <returns>AutomobileWebEntity</returns>
    public AutomobileWebEntity Read(Uri a_xURI, GUID a_xAutomobileGUID)
    {
      AutomobileWebEntity xReturnValue = null;

      try
      {
      }
      catch (Exception xException)
      {
#if DEBUG
        if (System.Diagnostics.Debugger.IsAttached)
        {
          System.Diagnostics.Debug.WriteLine(xException.ToString());
          System.Diagnostics.Debugger.Break();
        }
#endif
        throw xException;
      }
      finally
      {
      }

      return xReturnValue;
    }

    
    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    /// <summary>
    /// Update this Automobile using the specified ConnectionString.
    /// </summary>
    /// <param name="a_xURI">The database Connection used to perform the action.</param>
    /// <returns>AutomobileWebEntity</returns>
    public AutomobileWebEntity Update(Uri a_xURI)
    {
      AutomobileWebEntity xReturnValue = new AutomobileWebEntity();

      try
      {
        //----- Read after confirmation -----
        xReturnValue = Read(a_xURI, AutomobileGUID);
      }
      catch (Exception xException)
      {
#if DEBUG
        if (System.Diagnostics.Debugger.IsAttached)
        {
          System.Diagnostics.Debug.WriteLine(xException.ToString());
          System.Diagnostics.Debugger.Break();
        }
#endif
        throw xException;
      }
      finally
      {
      }

      return xReturnValue;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    /// <summary>
    /// Delete this Automobile using the specified Uri.
    /// </summary>
    /// <param name="a_xURI">The database Connection used to perform the action.</param>
    /// <returns>AutomobileWebEntity</returns>
    public AutomobileWebEntity Delete(Uri a_xURI)
    {
      AutomobileWebEntity xReturnValue = null;

      try
      {
        //----- Read after confirmation -----
        xReturnValue = Read(a_xURI, AutomobileGUID);
      }
      catch (Exception xException)
      {
#if DEBUG
        if (System.Diagnostics.Debugger.IsAttached)
        {
          System.Diagnostics.Debug.WriteLine(xException.ToString());
          System.Diagnostics.Debugger.Break();
        }
#endif
        throw xException;
      }
      finally
      {
      }

      return xReturnValue;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    /// <summary>
    /// Delete a Automobile using the specified Uri and AutomobileGUID.
    /// </summary>
    /// <param name="a_xURI">The database Uri used to perform the action.</param>
    /// <param name="a_xAutomobileGUID">The unique identifies of the Automobile to be retrieved.</param>
    /// <returns>AutomobileWebEntity</returns>
    public AutomobileWebEntity Delete(Uri a_xURI, GUID a_xAutomobileGUID)
    {
      AutomobileWebEntity xReturnValue = new AutomobileWebEntity();

      try
      {
        //----- Read after confirmation -----
        xReturnValue = Read(a_xURI, a_xAutomobileGUID);
      }
      catch (Exception xException)
      {
#if DEBUG
        if (System.Diagnostics.Debugger.IsAttached)
        {
          System.Diagnostics.Debug.WriteLine(xException.ToString());
          System.Diagnostics.Debugger.Break();
        }
#endif
        throw xException;
      }
      finally
      {
      }

      return xReturnValue;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    /// <summary>
    /// Loads a set of Automobiles using the specified ConnectionString and DataRequest.
    /// </summary>
    /// <param name="a_xURI">The database Uri used to perform the action.</param>
    /// <returns>AutomobileWebEntity</returns>
    public IEnumerable<AutomobileWebEntity> Load(Uri a_xURI)
    {
      DataRequest xDataRequest = DataRequestFactory();
      DataResult xDataResult = new DataResult();

      return Load(a_xURI, xDataRequest, out xDataResult);
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------
  
    /// <summary>
    /// Loads a set of Automobiles using the specified Uri and DataRequest.
    /// </summary>
    /// <param name="a_xURI">The database Uri used to perform the action.</param>
    /// <param name="a_xDataRequest">DataRequest that specifies the set of Automobiles to be retrieved.</param>
    /// <returns>AutomobileWebEntity</returns>
    public IEnumerable<AutomobileWebEntity> Load(Uri a_xURI, DataRequest a_xDataRequest)
    {
      DataResult xDataResult = new DataResult();
      return Load(a_xURI, a_xDataRequest, out xDataResult);
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    /// <summary>
    /// Loads a set of Automobiles using the specified Connection and DataRequest.
    /// </summary>
    /// <param name="a_xURI">The database Connection used to perform the action.</param>
    /// <param name="a_xDataRequest">DataRequest that specifies the set of Automobiles to be retrieved; including paging information.</param>
    /// <param name="a_xDataResult">A DataResult containing the TotalCount, FilterCount, PageSize, PageCount, PageNumber, and DatabaseDateTime for the request.</param>
    /// <returns>IEnumerable<AutomobileWebEntity></returns>
    public IEnumerable<AutomobileWebEntity> Load(Uri a_xURI, DataRequest a_xDataRequest, out DataResult a_xDataResult)
    {
      List<AutomobileWebEntity> xReturnValue = null;
      a_xDataResult = null;

      try
      {
      }
      catch (Exception xException)
      {
#if DEBUG
        if (System.Diagnostics.Debugger.IsAttached)
        {
          System.Diagnostics.Debug.WriteLine(xException.ToString());
          System.Diagnostics.Debugger.Break();
        }
#endif
        throw xException;
      }
      finally
      {
      }

      return xReturnValue;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    /// <summary>
    /// Import a Automobile from the specified JSON string.
    /// </summary>
    /// <param name="a_sJSONObject"></param>
    /// <returns>AutomobileWebEntity</returns>
    public AutomobileWebEntity Import_FromJSON(string a_sJSONObject)
    {
      AutomobileWebEntity xAutomobileWebEntity = new AutomobileWebEntity();
      JsonConvert.PopulateObject(a_sJSONObject, xAutomobileWebEntity);

      return xAutomobileWebEntity;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    /// <summary>
    /// Exports an Automobile instance to a set of Key/Value pairs.
    /// </summary>
    /// <param name="Export_ToDictionary"></param>
    /// <returns>AutomobileWebEntity</returns>
    public List<KeyValuePair<string, string>> Export_ToKeyValuePairs()
    {
      List<KeyValuePair<string, string>> xReturnValue = new List<KeyValuePair<string, string>>();

      xReturnValue.Add(new KeyValuePair<string, string>(nameof(AutomobileGUID), nameof(AutomobileGUID).ToString()));
      xReturnValue.Add(new KeyValuePair<string, string>(nameof(AutomobileMake), nameof(AutomobileMake).ToString()));
      xReturnValue.Add(new KeyValuePair<string, string>(nameof(AutomobileModel), nameof(AutomobileModel).ToString()));
      xReturnValue.Add(new KeyValuePair<string, string>(nameof(AutomobileYear), nameof(AutomobileYear).ToString()));

      return xReturnValue;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    public static partial class Helper
    {
      //=======================================================================
      //=======================================================================

      /// <summary>
      /// Read an existing Automobile using the specified Uri and AutomobileGUID.
      /// </summary>
      /// <param name="a_xURI">The database Uri used to perform the action.</param>
      /// <param name="a_xAutomobileGUID">The unique identifies of the Automobile to be retrieved.</param>
      /// <returns>AutomobileWebEntity</returns>
      public static AutomobileWebEntity Read(Uri a_xURI, GUID a_xAutomobileGUID)
      {
        if (m_xAutomobileWebEntity == null)
          m_xAutomobileWebEntity = new AutomobileWebEntity();

        return m_xAutomobileWebEntity.Read(a_xURI, a_xAutomobileGUID);
      }

      //=======================================================================
      //=======================================================================

      /// <summary>
      /// Update this Automobile using the specified Uri.
      /// </summary>
      /// <param name="a_xURI">The database  Uri used to perform the action.</param>
      /// <returns>AutomobileWebEntity</returns>
      public static AutomobileWebEntity Update(Uri a_xURI)
      {
        if (m_xAutomobileWebEntity == null)
          m_xAutomobileWebEntity = new AutomobileWebEntity();

        return m_xAutomobileWebEntity.Update(a_xURI);
      }

      //=======================================================================
      //=======================================================================

      /// <summary>
      /// Delete a Automobile using the specified Uri and AutomobileGUID.
      /// </summary>
      /// <param name="a_xURI">The database Uri used to perform the action.</param>
      /// <param name="a_xAutomobileGUID">The unique identifies of the Automobile to be retrieved.</param>
      /// <returns>AutomobileWebEntity</returns>
      public static AutomobileWebEntity Delete(Uri a_xURI, GUID a_xAutomobileGUID)
      {
        if (m_xAutomobileWebEntity == null)
          m_xAutomobileWebEntity = new AutomobileWebEntity();

        return m_xAutomobileWebEntity.Delete(a_xURI, a_xAutomobileGUID);
      }

      //=======================================================================
      //=======================================================================

      /// <summary>
      /// Loads a set of Automobiles using the specified Uri and DataRequest.
      /// </summary>
      /// <param name="a_xURI">The database Uri used to perform the action.</param>
      /// <param name="a_xDataRequest">DataRequest that specifies the set of Automobiles to be retrieved.</param>
      /// <returns>AutomobileWebEntity</returns>
      public static IEnumerable<AutomobileWebEntity> Load(Uri a_xURI, DataRequest a_xDataRequest)
      {
        if (m_xAutomobileWebEntity == null)
          m_xAutomobileWebEntity = new AutomobileWebEntity();

        return m_xAutomobileWebEntity.Load(a_xURI, a_xDataRequest);
      }


      //=======================================================================
      //=======================================================================

      /// <summary>
      /// Loads a set of Automobiles using the specified Uri and DataRequest.
      /// </summary>
      /// <param name="a_xURI">The database Uri used to perform the action.</param>
      /// <param name="a_xDataRequest">DataRequest that specifies the set of Automobiles to be retrieved; including paging information.</param>
      /// <param name="a_xDataResult">A DataResult containing the TotalCount, FilterCount, PageSize, PageCount, PageNumber, and DatabaseDateTime for the request.</param>
      /// <returns>IEnumerable<AutomobileWebEntity></returns>
      public static IEnumerable<AutomobileWebEntity> Load(Uri a_xURI, DataRequest a_xDataRequest, out DataResult a_xDataResult)
      {
        if (m_xAutomobileWebEntity== null)
          m_xAutomobileWebEntity = new AutomobileWebEntity();

        return m_xAutomobileWebEntity.Load(a_xURI, a_xDataRequest, out a_xDataResult);
      }

      //=======================================================================
      //=======================================================================

      /// <summary>
      /// Import a AutomobileWebEntity from the specified JSON string.
      /// </summary>
      /// <param name="a_sJSONObject"></param>
      /// <returns>AutomobileWebEntity</returns>
      public static AutomobileWebEntity Import_FromJSON(string a_sJSONObject)
      {
        if (m_xAutomobileWebEntity == null)
          m_xAutomobileWebEntity = new AutomobileWebEntity();

        return m_xAutomobileWebEntity.Import_FromJSON(a_sJSONObject);
      }

      //=======================================================================
      //=======================================================================

      private static AutomobileWebEntity m_xAutomobileWebEntity = null;

      //=======================================================================
      //=======================================================================
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    public AutomobileWebEntity()
    {
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    public AutomobileWebEntity(IUserInfo a_xUserInfo)
    {
      UserInfo = a_xUserInfo;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------
    //-----
    //----- Metadata available for "Entity[AutomobileWebEntityDesign]"
    //-----
    //----- AutomobileGUID                           Key = "Entity[AutomobileWebEntityDesign].Property[AutomobileGUID]"
    //----- AutomobileMake                           Key = "Entity[AutomobileWebEntityDesign].Property[AutomobileMake]"
    //----- AutomobileModel                          Key = "Entity[AutomobileWebEntityDesign].Property[AutomobileModel]"
    //----- AutomobileYear                           Key = "Entity[AutomobileWebEntityDesign].Property[AutomobileYear]"
    //-----
    //-----
    //----- (Type)                                   Entity[AutomobileWebEntityDesign] == "null"
    //----- (TypeAttribute)                          Entity[AutomobileWebEntityDesign].Attribute[WebResource] == "True"
    //----- (TypeAttributeProperty)                  Entity[AutomobileWebEntityDesign].Attribute[WebResource].Property[Name] == "Automobile"
    //----- (TypeProperty)                           Entity[AutomobileWebEntityDesign].Property[AutomobileGUID] == "null"
    //----- (TypeProperty)                           Entity[AutomobileWebEntityDesign].Property[AutomobileMake] == "null"
    //----- (TypeProperty)                           Entity[AutomobileWebEntityDesign].Property[AutomobileModel] == "null"
    //----- (TypeProperty)                           Entity[AutomobileWebEntityDesign].Property[AutomobileYear] == "null"
    //-----
    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

  }
}

//**********************************************************************************
//*                                                                                *
//* This code was generated from an emFramework Template. DO NOT MODIFY THIS FILE. *
//*                                                       -----------------------  *
//**********************************************************************************
