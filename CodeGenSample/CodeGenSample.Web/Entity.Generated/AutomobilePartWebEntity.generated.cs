
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
 public partial class AutomobilePartWebEntity : AutomobilePartWebEntityDesign, IEntity_WebAPIConnection<AutomobilePartWebEntity>
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
        DeleteColumnName = "AutomobilePartDeleted",
        ShowDeletedRow = false
      };

      return xReturnValue;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    /// <summary>
    /// Create a new AutomobilePart using the specified URI.
    /// </summary>
    /// <param name="a_xURI">The database Connection used to perform the action. The Connection should be opened prior to calling the method.</param>
    /// <returns>AutomobilePartWebEntity</returns>
    public AutomobilePartWebEntity Create(Uri a_xURI)
    {
      AutomobilePartWebEntity xReturnValue = null;

      try
      {
        //----- Read after confirmation -----
        xReturnValue = Read(a_xURI, AutomobilePartGUID);
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
    /// Read an existing AutomobilePart using the specified URI and AutomobilePartGUID.
    /// </summary>
    /// <param name="a_xURI">The database Connection used to perform the action.</param>
    /// <param name="a_xAutomobilePartGUID">The unique identifies of the AutomobilePart to be retrieved.</param>
    /// <returns>AutomobilePartWebEntity</returns>
    public AutomobilePartWebEntity Read(Uri a_xURI, GUID a_xAutomobilePartGUID)
    {
      AutomobilePartWebEntity xReturnValue = null;

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
    /// Update this AutomobilePart using the specified ConnectionString.
    /// </summary>
    /// <param name="a_xURI">The database Connection used to perform the action.</param>
    /// <returns>AutomobilePartWebEntity</returns>
    public AutomobilePartWebEntity Update(Uri a_xURI)
    {
      AutomobilePartWebEntity xReturnValue = new AutomobilePartWebEntity();

      try
      {
        //----- Read after confirmation -----
        xReturnValue = Read(a_xURI, AutomobilePartGUID);
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
    /// Delete this AutomobilePart using the specified Uri.
    /// </summary>
    /// <param name="a_xURI">The database Connection used to perform the action.</param>
    /// <returns>AutomobilePartWebEntity</returns>
    public AutomobilePartWebEntity Delete(Uri a_xURI)
    {
      AutomobilePartWebEntity xReturnValue = null;

      try
      {
        //----- Read after confirmation -----
        xReturnValue = Read(a_xURI, AutomobilePartGUID);
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
    /// Delete a AutomobilePart using the specified Uri and AutomobilePartGUID.
    /// </summary>
    /// <param name="a_xURI">The database Uri used to perform the action.</param>
    /// <param name="a_xAutomobilePartGUID">The unique identifies of the AutomobilePart to be retrieved.</param>
    /// <returns>AutomobilePartWebEntity</returns>
    public AutomobilePartWebEntity Delete(Uri a_xURI, GUID a_xAutomobilePartGUID)
    {
      AutomobilePartWebEntity xReturnValue = new AutomobilePartWebEntity();

      try
      {
        //----- Read after confirmation -----
        xReturnValue = Read(a_xURI, a_xAutomobilePartGUID);
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
    /// Loads a set of AutomobileParts using the specified ConnectionString and DataRequest.
    /// </summary>
    /// <param name="a_xURI">The database Uri used to perform the action.</param>
    /// <returns>AutomobilePartWebEntity</returns>
    public IEnumerable<AutomobilePartWebEntity> Load(Uri a_xURI)
    {
      DataRequest xDataRequest = DataRequestFactory();
      DataResult xDataResult = new DataResult();

      return Load(a_xURI, xDataRequest, out xDataResult);
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------
  
    /// <summary>
    /// Loads a set of AutomobileParts using the specified Uri and DataRequest.
    /// </summary>
    /// <param name="a_xURI">The database Uri used to perform the action.</param>
    /// <param name="a_xDataRequest">DataRequest that specifies the set of AutomobileParts to be retrieved.</param>
    /// <returns>AutomobilePartWebEntity</returns>
    public IEnumerable<AutomobilePartWebEntity> Load(Uri a_xURI, DataRequest a_xDataRequest)
    {
      DataResult xDataResult = new DataResult();
      return Load(a_xURI, a_xDataRequest, out xDataResult);
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    /// <summary>
    /// Loads a set of AutomobileParts using the specified Connection and DataRequest.
    /// </summary>
    /// <param name="a_xURI">The database Connection used to perform the action.</param>
    /// <param name="a_xDataRequest">DataRequest that specifies the set of AutomobileParts to be retrieved; including paging information.</param>
    /// <param name="a_xDataResult">A DataResult containing the TotalCount, FilterCount, PageSize, PageCount, PageNumber, and DatabaseDateTime for the request.</param>
    /// <returns>IEnumerable<AutomobilePartWebEntity></returns>
    public IEnumerable<AutomobilePartWebEntity> Load(Uri a_xURI, DataRequest a_xDataRequest, out DataResult a_xDataResult)
    {
      List<AutomobilePartWebEntity> xReturnValue = null;
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
    /// Import a AutomobilePart from the specified JSON string.
    /// </summary>
    /// <param name="a_sJSONObject"></param>
    /// <returns>AutomobilePartWebEntity</returns>
    public AutomobilePartWebEntity Import_FromJSON(string a_sJSONObject)
    {
      AutomobilePartWebEntity xAutomobilePartWebEntity = new AutomobilePartWebEntity();
      JsonConvert.PopulateObject(a_sJSONObject, xAutomobilePartWebEntity);

      return xAutomobilePartWebEntity;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    /// <summary>
    /// Exports an AutomobilePart instance to a set of Key/Value pairs.
    /// </summary>
    /// <param name="Export_ToDictionary"></param>
    /// <returns>AutomobilePartWebEntity</returns>
    public List<KeyValuePair<string, string>> Export_ToKeyValuePairs()
    {
      List<KeyValuePair<string, string>> xReturnValue = new List<KeyValuePair<string, string>>();

      xReturnValue.Add(new KeyValuePair<string, string>(nameof(AutomobileGUID), nameof(AutomobileGUID).ToString()));
      xReturnValue.Add(new KeyValuePair<string, string>(nameof(AutomobilePartDeleted), nameof(AutomobilePartDeleted).ToString()));
      xReturnValue.Add(new KeyValuePair<string, string>(nameof(AutomobilePartDescription), nameof(AutomobilePartDescription).ToString()));
      xReturnValue.Add(new KeyValuePair<string, string>(nameof(AutomobilePartGUID), nameof(AutomobilePartGUID).ToString()));
      xReturnValue.Add(new KeyValuePair<string, string>(nameof(AutomobilePartName), nameof(AutomobilePartName).ToString()));
      xReturnValue.Add(new KeyValuePair<string, string>(nameof(AutomobilePartNumber), nameof(AutomobilePartNumber).ToString()));
      xReturnValue.Add(new KeyValuePair<string, string>(nameof(AutomobilePartPrice), nameof(AutomobilePartPrice).ToString()));

      return xReturnValue;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    public static partial class Helper
    {
      //=======================================================================
      //=======================================================================

      /// <summary>
      /// Read an existing AutomobilePart using the specified Uri and AutomobilePartGUID.
      /// </summary>
      /// <param name="a_xURI">The database Uri used to perform the action.</param>
      /// <param name="a_xAutomobilePartGUID">The unique identifies of the AutomobilePart to be retrieved.</param>
      /// <returns>AutomobilePartWebEntity</returns>
      public static AutomobilePartWebEntity Read(Uri a_xURI, GUID a_xAutomobilePartGUID)
      {
        if (m_xAutomobilePartWebEntity == null)
          m_xAutomobilePartWebEntity = new AutomobilePartWebEntity();

        return m_xAutomobilePartWebEntity.Read(a_xURI, a_xAutomobilePartGUID);
      }

      //=======================================================================
      //=======================================================================

      /// <summary>
      /// Update this AutomobilePart using the specified Uri.
      /// </summary>
      /// <param name="a_xURI">The database  Uri used to perform the action.</param>
      /// <returns>AutomobilePartWebEntity</returns>
      public static AutomobilePartWebEntity Update(Uri a_xURI)
      {
        if (m_xAutomobilePartWebEntity == null)
          m_xAutomobilePartWebEntity = new AutomobilePartWebEntity();

        return m_xAutomobilePartWebEntity.Update(a_xURI);
      }

      //=======================================================================
      //=======================================================================

      /// <summary>
      /// Delete a AutomobilePart using the specified Uri and AutomobilePartGUID.
      /// </summary>
      /// <param name="a_xURI">The database Uri used to perform the action.</param>
      /// <param name="a_xAutomobilePartGUID">The unique identifies of the AutomobilePart to be retrieved.</param>
      /// <returns>AutomobilePartWebEntity</returns>
      public static AutomobilePartWebEntity Delete(Uri a_xURI, GUID a_xAutomobilePartGUID)
      {
        if (m_xAutomobilePartWebEntity == null)
          m_xAutomobilePartWebEntity = new AutomobilePartWebEntity();

        return m_xAutomobilePartWebEntity.Delete(a_xURI, a_xAutomobilePartGUID);
      }

      //=======================================================================
      //=======================================================================

      /// <summary>
      /// Loads a set of AutomobileParts using the specified Uri and DataRequest.
      /// </summary>
      /// <param name="a_xURI">The database Uri used to perform the action.</param>
      /// <returns>AutomobilePartWebEntity</returns>
      public static IEnumerable<AutomobilePartWebEntity> Load(Uri a_xURI)
      {
        if (m_xAutomobilePartWebEntity == null)
          m_xAutomobilePartWebEntity = new AutomobilePartWebEntity();

        return m_xAutomobilePartWebEntity.Load(a_xURI);
      }

      //=======================================================================
      //=======================================================================

      /// <summary>
      /// Loads a set of AutomobileParts using the specified Uri and DataRequest.
      /// </summary>
      /// <param name="a_xURI">The database Uri used to perform the action.</param>
      /// <param name="a_xDataRequest">DataRequest that specifies the set of AutomobileParts to be retrieved.</param>
      /// <returns>AutomobilePartWebEntity</returns>
      public static IEnumerable<AutomobilePartWebEntity> Load(Uri a_xURI, DataRequest a_xDataRequest)
      {
        if (m_xAutomobilePartWebEntity == null)
          m_xAutomobilePartWebEntity = new AutomobilePartWebEntity();

        return m_xAutomobilePartWebEntity.Load(a_xURI, a_xDataRequest);
      }

      //=======================================================================
      //=======================================================================

      /// <summary>
      /// Loads a set of AutomobileParts using the specified Uri and DataRequest.
      /// </summary>
      /// <param name="a_xURI">The database Uri used to perform the action.</param>
      /// <param name="a_xDataRequest">DataRequest that specifies the set of AutomobileParts to be retrieved; including paging information.</param>
      /// <param name="a_xDataResult">A DataResult containing the TotalCount, FilterCount, PageSize, PageCount, PageNumber, and DatabaseDateTime for the request.</param>
      /// <returns>IEnumerable<AutomobilePartWebEntity></returns>
      public static IEnumerable<AutomobilePartWebEntity> Load(Uri a_xURI, DataRequest a_xDataRequest, out DataResult a_xDataResult)
      {
        if (m_xAutomobilePartWebEntity== null)
          m_xAutomobilePartWebEntity = new AutomobilePartWebEntity();

        return m_xAutomobilePartWebEntity.Load(a_xURI, a_xDataRequest, out a_xDataResult);
      }

      //=======================================================================
      //=======================================================================

      /// <summary>
      /// Import a AutomobilePartWebEntity from the specified JSON string.
      /// </summary>
      /// <param name="a_sJSONObject"></param>
      /// <returns>AutomobilePartWebEntity</returns>
      public static AutomobilePartWebEntity Import_FromJSON(string a_sJSONObject)
      {
        if (m_xAutomobilePartWebEntity == null)
          m_xAutomobilePartWebEntity = new AutomobilePartWebEntity();

        return m_xAutomobilePartWebEntity.Import_FromJSON(a_sJSONObject);
      }

      //=======================================================================
      //=======================================================================

      private static AutomobilePartWebEntity m_xAutomobilePartWebEntity = null;

      //=======================================================================
      //=======================================================================
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    public AutomobilePartWebEntity()
    {
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    public AutomobilePartWebEntity(IUserInfo a_xUserInfo)
    {
      UserInfo = a_xUserInfo;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------
    //-----
    //----- Metadata available for "Entity[AutomobilePartWebEntityDesign]"
    //-----
    //----- AutomobileGUID                           Key = "Entity[AutomobilePartWebEntityDesign].Property[AutomobileGUID]"
    //----- AutomobilePartDeleted                    Key = "Entity[AutomobilePartWebEntityDesign].Property[AutomobilePartDeleted]"
    //----- AutomobilePartDescription                Key = "Entity[AutomobilePartWebEntityDesign].Property[AutomobilePartDescription]"
    //----- AutomobilePartGUID                       Key = "Entity[AutomobilePartWebEntityDesign].Property[AutomobilePartGUID]"
    //----- AutomobilePartName                       Key = "Entity[AutomobilePartWebEntityDesign].Property[AutomobilePartName]"
    //----- AutomobilePartNumber                     Key = "Entity[AutomobilePartWebEntityDesign].Property[AutomobilePartNumber]"
    //----- AutomobilePartPrice                      Key = "Entity[AutomobilePartWebEntityDesign].Property[AutomobilePartPrice]"
    //-----
    //-----
    //----- (Type)                                   Entity[AutomobilePartWebEntityDesign] == "null"
    //----- (TypeAttribute)                          Entity[AutomobilePartWebEntityDesign].Attribute[WebResource] == "True"
    //----- (TypeAttributeProperty)                  Entity[AutomobilePartWebEntityDesign].Attribute[WebResource].Property[Name] == "AutomobilePart"
    //----- (TypeProperty)                           Entity[AutomobilePartWebEntityDesign].Property[AutomobileGUID] == "null"
    //----- (TypeProperty)                           Entity[AutomobilePartWebEntityDesign].Property[AutomobilePartDeleted] == "null"
    //----- (TypeProperty)                           Entity[AutomobilePartWebEntityDesign].Property[AutomobilePartDescription] == "null"
    //----- (TypeProperty)                           Entity[AutomobilePartWebEntityDesign].Property[AutomobilePartGUID] == "null"
    //----- (TypeProperty)                           Entity[AutomobilePartWebEntityDesign].Property[AutomobilePartName] == "null"
    //----- (TypeProperty)                           Entity[AutomobilePartWebEntityDesign].Property[AutomobilePartNumber] == "null"
    //----- (TypeProperty)                           Entity[AutomobilePartWebEntityDesign].Property[AutomobilePartPrice] == "null"
    //-----
    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

  }
}

//**************************************************************************************
//*                                                                                    *
//* This code was generated from an emFrameworkCore Template. DO NOT MODIFY THIS FILE. *
//*                                                           -----------------------  *
//**************************************************************************************
