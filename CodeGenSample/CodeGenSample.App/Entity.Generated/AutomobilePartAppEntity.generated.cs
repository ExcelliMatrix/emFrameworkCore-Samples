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

// Directory:        {{SolutionDir}}CodeGenSample.App\Entity.Generated
// CodeGenFilename:  (CodeGen).xml
// TemplateFilename: (Entity).tt

using CodeGenSample.AppTier;
using CodeGenSample.Design.App;
using emFrameworkCore.Core;
using emFrameworkCore.Data;
using emFrameworkCore.Database;
using emFrameworkCore.Database.Extensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;


namespace CodeGenSample.App.Entity
{
 public partial class AutomobilePartAppEntity : AutomobilePartAppEntityDesign, emFrameworkCore.Data.IEntity_SQLConnection<AutomobilePartAppEntity>
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
        if (m_xAppUserInfo == null)
          m_xAppUserInfo = new AppUserInfo();
        return m_xAppUserInfo;
      }
      set
      {
        m_xAppUserInfo = (AppUserInfo)value;
      }
    }
    private AppUserInfo m_xAppUserInfo;

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
    /// Create a new AutomobilePart using the specified SQLConnection.
    /// </summary>
    /// <param name="a_xSQLConnection">The database Connection used to perform the action. The Connection should be opened prior to calling the method.</param>
    /// <returns>AutomobilePartAppEntity</returns>
    public AutomobilePartAppEntity Create(SqlConnection a_xSQLConnection)
    {
      AutomobilePartAppEntity xReturnValue = null;
      SqlConnection xSQLConnection = a_xSQLConnection;

      //if (UserInfo == null)
        //throw new ArgumentNullException("UserInfo");

      try
      {
        //----- Open SQLConnection -----
        if (xSQLConnection.State == System.Data.ConnectionState.Closed)
          xSQLConnection.Open();

        //----- Use a Transaction to ensure the all of the steps are completed, or none are completed -----
        using (SqlTransaction xSQLTransaction = xSQLConnection.BeginTransaction())
        {
          int iRowAffected = 0;

          //----- Step 1: Create new AutomobilePartAppEntity -----
          using (SqlCommand xSQLCommand = SQLCommand_Create(xSQLConnection))
          {
            DatabaseHelper.Monitor.SQLCommand(SystemInfo.Name, ApplicationInfo.Name, ApplicationInfo.Tier, xSQLCommand);
            xSQLCommand.Transaction = xSQLTransaction;
            iRowAffected = xSQLCommand.ExecuteNonQuery();
          }

          //----- Commit Transaction -----
          xSQLTransaction.Commit();
        }

        //----- Read after confirmation -----
        xReturnValue = Read(xSQLConnection);
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
        xSQLConnection.Close();
      }

      return xReturnValue;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    /// <summary>
    /// Read an existing AutomobilePart using the specified SQLConnection object's GUID.
    /// </summary>
    /// <param name="a_xSQLConnection">The database Connection used to perform the action.</param>
    /// <returns>AutomobilePartAppEntity</returns>
    public AutomobilePartAppEntity Read(SqlConnection a_xSQLConnection)
    {
      AutomobilePartAppEntity xReturnValue = Read(a_xSQLConnection, AutomobilePartGUID);

      return xReturnValue;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    /// <summary>
    /// Read an existing AutomobilePart using the specified SQLConnection and GUID.
    /// </summary>
    /// <param name="a_xSQLConnection">The database Connection used to perform the action.</param>
    /// <param name="a_xGUID">The unique identifies of the AutomobilePart to be retrieved.</param>
    /// <returns>AutomobilePartAppEntity</returns>
    public AutomobilePartAppEntity Read(SqlConnection a_xSQLConnection, GUID a_xGUID)
    {
      AutomobilePartAppEntity xReturnValue = null;

      SqlConnection xSQLConnection = a_xSQLConnection;

      try
      {
        //----- Open SQLConnection -----
        if (xSQLConnection.State == System.Data.ConnectionState.Closed)
          xSQLConnection.Open();

        using (SqlTransaction xSQLTransaction = xSQLConnection.BeginTransaction())
        {
          int iRowAffected = 0;

          //----- Step 1: Create new AutomobilePartAppEntity -----
          using (SqlCommand xSQLCommand = SQLCommand_Read(xSQLConnection, a_xGUID))
          {
            DatabaseHelper.Monitor.SQLCommand(SystemInfo.Name, ApplicationInfo.Name, ApplicationInfo.Tier, xSQLCommand);
            xSQLCommand.Transaction = xSQLTransaction;
            using (SqlDataReader xSQLDataReader = xSQLCommand.ExecuteReader())
            {
              iRowAffected = 0;
              while (xSQLDataReader.Read())
              {
                xReturnValue = Import(xSQLDataReader);

				
                iRowAffected++;
              }
            }
          }
        }
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
        xSQLConnection.Close();
      }

      return xReturnValue;
    }

    
    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    /// <summary>
    /// Update this AutomobilePart using the specified ConnectionString.
    /// </summary>
    /// <param name="a_xSQLConnection">The database Connection used to perform the action.</param>
    /// <returns>AutomobilePartAppEntity</returns>
    public AutomobilePartAppEntity Update(SqlConnection a_xSQLConnection)
    {
      AutomobilePartAppEntity xReturnValue = new AutomobilePartAppEntity();

      SqlConnection  xSQLConnection = a_xSQLConnection;

      try
      {
        //----- Open SQLConnection -----
        if (xSQLConnection.State == System.Data.ConnectionState.Closed)
          xSQLConnection.Open();

        //----- Use a Transaction to ensure the all of the steps are completed, or none are completed -----
        using (SqlTransaction xSQLTransaction = xSQLConnection.BeginTransaction())
        {
          int iRowAffected = 0;

          //----- Step 1: Update AutomobilePartAppEntity entry -----
          using (SqlCommand xSQLCommand = SQLCommand_Update(xSQLConnection))
          {
            DatabaseHelper.Monitor.SQLCommand(SystemInfo.Name, ApplicationInfo.Name, ApplicationInfo.Tier, xSQLCommand);
            xSQLCommand.Transaction = xSQLTransaction;
            iRowAffected = xSQLCommand.ExecuteNonQuery();
          }

          //----- Commit Transaction -----
          xSQLTransaction.Commit();
        }

        //----- Read after confirmation -----
        xReturnValue = Read(xSQLConnection);
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
        xSQLConnection.Close();
      }

      return xReturnValue;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    /// <summary>
    /// Delete this AutomobilePart using the specified SQLConnection.
    /// </summary>
    /// <param name="a_xSQLConnection">The database Connection used to perform the action.</param>
    /// <returns>AutomobilePartAppEntity</returns>
    public AutomobilePartAppEntity Delete(SqlConnection a_xSQLConnection)
    {
      AutomobilePartAppEntity xReturnValue = null;

      SqlConnection xSQLConnection = a_xSQLConnection; ;

      //if (UserInfo == null)
        //throw new ArgumentNullException("UserInfo");

      try
      {
        //----- Open SQLConnection -----
        if (xSQLConnection.State == System.Data.ConnectionState.Closed)
          xSQLConnection.Open();

        //----- Use a Transaction to ensure the all of the steps are completed, or none are completed -----
        using (SqlTransaction xSQLTransaction = xSQLConnection.BeginTransaction())
        {
          int iRowAffected = 0;

          //----- Step 1: Delete AutomobilePartAppEntity entry -----
          using (SqlCommand xSQLCommand = SQLCommand_Delete(xSQLConnection))
          {
            DatabaseHelper.Monitor.SQLCommand(SystemInfo.Name, ApplicationInfo.Name, ApplicationInfo.Tier, xSQLCommand);
            xSQLCommand.Transaction = xSQLTransaction;
            iRowAffected = xSQLCommand.ExecuteNonQuery();
          }

          //----- Commit Transaction -----
          xSQLTransaction.Commit();
        }

        //----- Read after confirmation -----
        xReturnValue = Read(xSQLConnection);
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
        xSQLConnection.Close();
      }

      return xReturnValue;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    /// <summary>
    /// Delete a AutomobilePart using the specified SQLConnection and GUID.
    /// </summary>
    /// <param name="a_xSqlConnection">The database SQLConnection used to perform the action.</param>
    /// <param name="a_xGUID">The unique identifies of the AutomobilePart to be retrieved.</param>
    /// <returns>AutomobilePartAppEntity</returns>
    public AutomobilePartAppEntity Delete(SqlConnection a_xSQLConnection, GUID a_xGUID)
    {
      AutomobilePartAppEntity xReturnValue = new AutomobilePartAppEntity();

      SqlConnection xSQLConnection = a_xSQLConnection;

      try
      {
        //----- Open SQLConnection -----
        if (xSQLConnection.State == System.Data.ConnectionState.Closed)
          xSQLConnection.Open();

        //----- Use a Transaction to ensure the all of the steps are completed, or none are completed -----
        using (SqlTransaction xSQLTransaction = xSQLConnection.BeginTransaction())
        {
          int iRowAffected = 0;

          //----- Step 1: Delete AutomobilePartAppEntity entry -----
          using (SqlCommand xSQLCommand = SQLCommand_Delete(xSQLConnection, a_xGUID))
          {
            DatabaseHelper.Monitor.SQLCommand(SystemInfo.Name, ApplicationInfo.Name, ApplicationInfo.Tier, xSQLCommand);
            xSQLCommand.Transaction = xSQLTransaction;
            iRowAffected = xSQLCommand.ExecuteNonQuery();
          }

          //----- Commit Transaction -----
          xSQLTransaction.Commit();
        }

        //----- Read after confirmation -----
        xReturnValue = Read(xSQLConnection, a_xGUID);
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
        xSQLConnection.Close();
      }

      return xReturnValue;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    /// <summary>
    /// Loads a set of AutomobileParts using the specified ConnectionString and DataRequest.
    /// </summary>
    /// <param name="a_xSqlConnection">The database SQLConnection used to perform the action.</param>
    /// <returns>AutomobilePartAppEntity</returns>
    public IEnumerable<AutomobilePartAppEntity> Load(SqlConnection a_xSQLConnection)
    {
      DataRequest xDataRequest = DataRequestFactory();
      DataResult xDataResult = new DataResult();

      return Load(a_xSQLConnection, xDataRequest, out xDataResult);
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------
  
    /// <summary>
    /// Loads a set of AutomobileParts using the specified SQLConnection and DataRequest.
    /// </summary>
    /// <param name="a_xSqlConnection">The database SQLConnection used to perform the action.</param>
    /// <param name="a_xDataRequest">DataRequest that specifies the set of AutomobileParts to be retrieved.</param>
    /// <returns>AutomobilePartAppEntity</returns>
    public IEnumerable<AutomobilePartAppEntity> Load(SqlConnection a_xSQLConnection, DataRequest a_xDataRequest)
    {
      DataResult xDataResult = new DataResult();
      return Load(a_xSQLConnection, a_xDataRequest, out xDataResult);
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    /// <summary>
    /// Loads a set of AutomobileParts using the specified Connection and DataRequest.
    /// </summary>
    /// <param name="a_xSqlConnection">The database Connection used to perform the action.</param>
    /// <param name="a_xDataRequest">DataRequest that specifies the set of AutomobileParts to be retrieved; including paging information.</param>
    /// <param name="a_xDataResult">A DataResult containing the TotalCount, FilterCount, PageSize, PageCount, PageNumber, and DatabaseDateTime for the request.</param>
    /// <returns>IEnumerable<AutomobilePartAppEntity></returns>
    public IEnumerable<AutomobilePartAppEntity> Load(SqlConnection a_xSQLConnection, DataRequest a_xDataRequest, out DataResult a_xDataResult)
    {
      List<AutomobilePartAppEntity> xReturnValue = null;
      a_xDataResult = null;
      SqlConnection xSQLConnection = a_xSQLConnection;

      try
      {
        //----- Open SQLConnection -----
        if (xSQLConnection.State == System.Data.ConnectionState.Closed)
          xSQLConnection.Open();

        AutomobilePartAppEntity xAutomobilePartAppEntity = null;

        using (SqlCommand xSQLCommand = SQLCommand_Load(xSQLConnection, a_xDataRequest))
        {
          DatabaseHelper.Monitor.SQLCommand(SystemInfo.Name, ApplicationInfo.Name, ApplicationInfo.Tier, xSQLCommand);
          using (SqlDataReader xSQLDataReader = xSQLCommand.ExecuteReader())
          {
            xReturnValue = new List<AutomobilePartAppEntity>();

            while (xSQLDataReader.Read())
            {
              xAutomobilePartAppEntity = Import(xSQLDataReader);
              xReturnValue.Add(xAutomobilePartAppEntity);
            }

            if (xReturnValue.Count == 0)
              xReturnValue = null;

            if (xSQLDataReader.NextResult())
            {
              a_xDataResult = new DataResult();

              while (xSQLDataReader.Read())
              {
                a_xDataResult.TotalCount = Convert.ToInt32(xSQLDataReader["TotalCount"]);
                a_xDataResult.FilterCount = Convert.ToInt32(xSQLDataReader["FilterCount"]);
                a_xDataResult.PageSize = Convert.ToInt32(xSQLDataReader["PageSize"]);
                a_xDataResult.PageCount = Convert.ToInt32(xSQLDataReader["PageCount"]);
                a_xDataResult.PageNumber = Convert.ToInt32(xSQLDataReader["PageNumber"]);
                a_xDataResult.DatabaseDateTime = ((DateTimeOffset)xSQLDataReader["DatabaseDateTime"]).DateTime;
              }
            }
          }
        }
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
        xSQLConnection.Close();
      }

      return xReturnValue;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    /// <summary>
    /// Import a AutomobilePart from the current SqlDataReader record.
    /// </summary>
    /// <param name="a_xSQLDataReader">The SqlDataReader containing the record to be imported.</param>
    /// <returns>AutomobilePartAppEntity</returns>
    public AutomobilePartAppEntity Import(SqlDataReader a_xSQLDataReader)
    {
      AutomobilePartAppEntity xAutomobilePartAppEntity = new AutomobilePartAppEntity();
      a_xSQLDataReader.Import<AutomobilePartAppEntity>(xAutomobilePartAppEntity);

      return xAutomobilePartAppEntity;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    public static partial class Helper
    {
      //=======================================================================
      //=======================================================================

      /// <summary>
      /// Read an existing AutomobilePart using the specified SQLConnection and GUID.
      /// </summary>
      /// <param name="a_xSQLConnection">The database SQLConnection used to perform the action.</param>
      /// <param name="a_xGUID">The unique identifies of the AutomobilePart to be retrieved.</param>
      /// <returns>AutomobilePartAppEntity</returns>
      public static AutomobilePartAppEntity Read(SqlConnection a_xSQLConnection, GUID a_xGUID)
      {
        if (m_xAutomobilePartAppEntity == null)
          m_xAutomobilePartAppEntity = new AutomobilePartAppEntity();

        return m_xAutomobilePartAppEntity.Read(a_xSQLConnection, a_xGUID);
      }

      //=======================================================================
      //=======================================================================

      /// <summary>
      /// Update this AutomobilePart using the specified SQLConnection.
      /// </summary>
      /// <param name="a_xSQLConnection">The database  SQLConnection used to perform the action.</param>
      /// <returns>AutomobilePartAppEntity</returns>
      public static AutomobilePartAppEntity Update(SqlConnection a_xSQLConnection)
      {
        if (m_xAutomobilePartAppEntity == null)
          m_xAutomobilePartAppEntity = new AutomobilePartAppEntity();

        return m_xAutomobilePartAppEntity.Update(a_xSQLConnection);
      }

      //=======================================================================
      //=======================================================================

      /// <summary>
      /// Delete a AutomobilePart using the specified SQLConnection and GUID.
      /// </summary>
      /// <param name="a_xSQLConnection">The database SQLConnection used to perform the action.</param>
      /// <param name="a_xGUID">The unique identifies of the AutomobilePart to be retrieved.</param>
      /// <returns>AutomobilePartAppEntity</returns>
      public static AutomobilePartAppEntity Delete(SqlConnection a_xSQLConnection, GUID a_xGUID)
      {
        if (m_xAutomobilePartAppEntity == null)
          m_xAutomobilePartAppEntity = new AutomobilePartAppEntity();

        return m_xAutomobilePartAppEntity.Delete(a_xSQLConnection, a_xGUID);
      }

      //=======================================================================
      //=======================================================================

      /// <summary>
      /// Loads a set of AutomobileParts using the specified SQLConnection and DataRequest.
      /// </summary>
      /// <param name="a_xSQLConnection">The database SQLConnection used to perform the action.</param>
      /// <returns>AutomobilePartAppEntity</returns>
      public static IEnumerable<AutomobilePartAppEntity> Load(SqlConnection a_xSQLConnection)
      {
        if (m_xAutomobilePartAppEntity == null)
          m_xAutomobilePartAppEntity = new AutomobilePartAppEntity();

        return m_xAutomobilePartAppEntity.Load(a_xSQLConnection);
      }

      //=======================================================================
      //=======================================================================

      /// <summary>
      /// Loads a set of AutomobileParts using the specified SQLConnection and DataRequest.
      /// </summary>
      /// <param name="a_xSQLConnection">The database SQLConnection used to perform the action.</param>
      /// <param name="a_xDataRequest">DataRequest that specifies the set of AutomobileParts to be retrieved.</param>
      /// <returns>AutomobilePartAppEntity</returns>
      public static IEnumerable<AutomobilePartAppEntity> Load(SqlConnection a_xSQLConnection, DataRequest a_xDataRequest)
      {
        if (m_xAutomobilePartAppEntity == null)
          m_xAutomobilePartAppEntity = new AutomobilePartAppEntity();

        return m_xAutomobilePartAppEntity.Load(a_xSQLConnection, a_xDataRequest);
      }

      //=======================================================================
      //=======================================================================

      /// <summary>
      /// Loads a set of AutomobileParts using the specified SQLConnection and DataRequest.
      /// </summary>
      /// <param name="a_xSQLConnection">The database SQLConnection used to perform the action.</param>
      /// <param name="a_xDataRequest">DataRequest that specifies the set of AutomobileParts to be retrieved; including paging information.</param>
      /// <param name="a_xDataResult">A DataResult containing the TotalCount, FilterCount, PageSize, PageCount, PageNumber, and DatabaseDateTime for the request.</param>
      /// <returns>IEnumerable<AutomobilePartAppEntity></returns>
      public static IEnumerable<AutomobilePartAppEntity> Load(SqlConnection a_xSQLConnection, DataRequest a_xDataRequest, out DataResult a_xDataResult)
      {
        if (m_xAutomobilePartAppEntity== null)
          m_xAutomobilePartAppEntity = new AutomobilePartAppEntity();

        return m_xAutomobilePartAppEntity.Load(a_xSQLConnection, a_xDataRequest, out a_xDataResult);
      }

      //=======================================================================
      //=======================================================================

      /// <summary>
      /// Import an AutomobilePart from the current SqlDataReader record.
      /// </summary>
      /// <param name="a_xSQLDataReader">The SqlDataReader containing the record to be imported.</param>
      /// <returns>AutomobilePartAppEntity</returns>
      public static AutomobilePartAppEntity Import(SqlDataReader a_xSQLDataReader)
      {
        if (m_xAutomobilePartAppEntity == null)
          m_xAutomobilePartAppEntity = new AutomobilePartAppEntity();

        return m_xAutomobilePartAppEntity.Import(a_xSQLDataReader);
      }

      //=======================================================================
		  //=======================================================================

      private static AutomobilePartAppEntity m_xAutomobilePartAppEntity = null;

      //=======================================================================
      //=======================================================================
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    public AutomobilePartAppEntity()
    {
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    public AutomobilePartAppEntity(IUserInfo a_xUserInfo)
    {
      UserInfo = a_xUserInfo;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------
    //-----
    //----- Metadata available for "Entity[AutomobilePartEntityDesign]"
    //-----
    //-----
    //-----
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
