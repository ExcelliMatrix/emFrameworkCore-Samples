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
 public partial class AutomobileAppEntity : AutomobileAppEntityDesign, emFrameworkCore.Data.IEntity_SQLConnection<AutomobileAppEntity>
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
        DeleteColumnName = "AutomobileDeleted",
        ShowDeletedRow = false
      };

      return xReturnValue;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    /// <summary>
    /// Create a new Automobile using the specified SQLConnection.
    /// </summary>
    /// <param name="a_xSQLConnection">The database Connection used to perform the action. The Connection should be opened prior to calling the method.</param>
    /// <returns>AutomobileAppEntity</returns>
    public AutomobileAppEntity Create(SqlConnection a_xSQLConnection)
    {
      AutomobileAppEntity xReturnValue = null;
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

          //----- Step 1: Create new AutomobileAppEntity -----
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
    /// Read an existing Automobile using the specified SQLConnection object's AutomobileGUID.
    /// </summary>
    /// <param name="a_xSQLConnection">The database Connection used to perform the action.</param>
    /// <returns>AutomobileAppEntity</returns>
    public AutomobileAppEntity Read(SqlConnection a_xSQLConnection)
    {
      AutomobileAppEntity xReturnValue = Read(a_xSQLConnection, AutomobileGUID);

      return xReturnValue;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    /// <summary>
    /// Read an existing Automobile using the specified SQLConnection and AutomobileGUID.
    /// </summary>
    /// <param name="a_xSQLConnection">The database Connection used to perform the action.</param>
    /// <param name="a_xAutomobileGUID">The unique identifies of the Automobile to be retrieved.</param>
    /// <returns>AutomobileAppEntity</returns>
    public AutomobileAppEntity Read(SqlConnection a_xSQLConnection, GUID a_xAutomobileGUID)
    {
      AutomobileAppEntity xReturnValue = null;

      SqlConnection xSQLConnection = a_xSQLConnection;

      try
      {
        //----- Open SQLConnection -----
        if (xSQLConnection.State == System.Data.ConnectionState.Closed)
          xSQLConnection.Open();

        using (SqlTransaction xSQLTransaction = xSQLConnection.BeginTransaction())
        {
          int iRowAffected = 0;

          //----- Step 1: Create new AutomobileAppEntity -----
          using (SqlCommand xSQLCommand = SQLCommand_Read(xSQLConnection, a_xAutomobileGUID))
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
    /// Update this Automobile using the specified ConnectionString.
    /// </summary>
    /// <param name="a_xSQLConnection">The database Connection used to perform the action.</param>
    /// <returns>AutomobileAppEntity</returns>
    public AutomobileAppEntity Update(SqlConnection a_xSQLConnection)
    {
      AutomobileAppEntity xReturnValue = new AutomobileAppEntity();

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

          //----- Step 1: Update AutomobileAppEntity entry -----
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
    /// Delete this Automobile using the specified SQLConnection.
    /// </summary>
    /// <param name="a_xSQLConnection">The database Connection used to perform the action.</param>
    /// <returns>AutomobileAppEntity</returns>
    public AutomobileAppEntity Delete(SqlConnection a_xSQLConnection)
    {
      AutomobileAppEntity xReturnValue = null;

      SqlConnection xSQLConnection = a_xSQLConnection; ;

      try
      {
        //----- Open SQLConnection -----
        if (xSQLConnection.State == System.Data.ConnectionState.Closed)
          xSQLConnection.Open();

        //----- Use a Transaction to ensure the all of the steps are completed, or none are completed -----
        using (SqlTransaction xSQLTransaction = xSQLConnection.BeginTransaction())
        {
          int iRowAffected = 0;

          //----- Step 1: Delete AutomobileAppEntity entry -----
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
    /// Delete a Automobile using the specified SQLConnection and GUID.
    /// </summary>
    /// <param name="a_xSqlConnection">The database SQLConnection used to perform the action.</param>
    /// <param name="a_xGUID">The unique identifies of the Automobile to be retrieved.</param>
    /// <returns>AutomobileAppEntity</returns>
    public AutomobileAppEntity Delete(SqlConnection a_xSQLConnection, GUID a_xGUID)
    {
      AutomobileAppEntity xReturnValue = new AutomobileAppEntity();

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

          //----- Step 1: Delete AutomobileAppEntity entry -----
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
    /// Loads a set of Automobiles using the specified ConnectionString and DataRequest.
    /// </summary>
    /// <param name="a_xSqlConnection">The database SQLConnection used to perform the action.</param>
    /// <returns>AutomobileAppEntity</returns>
    public IEnumerable<AutomobileAppEntity> Load(SqlConnection a_xSQLConnection)
    {
      DataRequest xDataRequest = DataRequestFactory();
      DataResult xDataResult = new DataResult();

      return Load(a_xSQLConnection, xDataRequest, out xDataResult);
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------
  
    /// <summary>
    /// Loads a set of Automobiles using the specified SQLConnection and DataRequest.
    /// </summary>
    /// <param name="a_xSqlConnection">The database SQLConnection used to perform the action.</param>
    /// <param name="a_xDataRequest">DataRequest that specifies the set of Automobiles to be retrieved.</param>
    /// <returns>AutomobileAppEntity</returns>
    public IEnumerable<AutomobileAppEntity> Load(SqlConnection a_xSQLConnection, DataRequest a_xDataRequest)
    {
      DataResult xDataResult = new DataResult();
      return Load(a_xSQLConnection, a_xDataRequest, out xDataResult);
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    /// <summary>
    /// Loads a set of Automobiles using the specified Connection and DataRequest.
    /// </summary>
    /// <param name="a_xSqlConnection">The database Connection used to perform the action.</param>
    /// <param name="a_xDataRequest">DataRequest that specifies the set of Automobiles to be retrieved; including paging information.</param>
    /// <param name="a_xDataResult">A DataResult containing the TotalCount, FilterCount, PageSize, PageCount, PageNumber, and DatabaseDateTime for the request.</param>
    /// <returns>IEnumerable<AutomobileAppEntity></returns>
    public IEnumerable<AutomobileAppEntity> Load(SqlConnection a_xSQLConnection, DataRequest a_xDataRequest, out DataResult a_xDataResult)
    {
      List<AutomobileAppEntity> xReturnValue = null;
      a_xDataResult = null;
      SqlConnection xSQLConnection = a_xSQLConnection;

      try
      {
        //----- Open SQLConnection -----
        if (xSQLConnection.State == System.Data.ConnectionState.Closed)
          xSQLConnection.Open();

        AutomobileAppEntity xAutomobileAppEntity = null;

        using (SqlCommand xSQLCommand = SQLCommand_Load(xSQLConnection, a_xDataRequest))
        {
          DatabaseHelper.Monitor.SQLCommand(SystemInfo.Name, ApplicationInfo.Name, ApplicationInfo.Tier, xSQLCommand);
          using (SqlDataReader xSQLDataReader = xSQLCommand.ExecuteReader())
          {
            xReturnValue = new List<AutomobileAppEntity>();

            while (xSQLDataReader.Read())
            {
              xAutomobileAppEntity = Import(xSQLDataReader);
              xReturnValue.Add(xAutomobileAppEntity);
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
    /// Import a Automobile from the current SqlDataReader record.
    /// </summary>
    /// <param name="a_xSQLDataReader">The SqlDataReader containing the record to be imported.</param>
    /// <returns>AutomobileAppEntity</returns>
    public AutomobileAppEntity Import(SqlDataReader a_xSQLDataReader)
    {
      AutomobileAppEntity xAutomobileAppEntity = new AutomobileAppEntity();
      a_xSQLDataReader.Import<AutomobileAppEntity>(xAutomobileAppEntity);

      return xAutomobileAppEntity;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    public static partial class Helper
    {
      //=======================================================================
      //=======================================================================

      /// <summary>
      /// Read an existing Automobile using the specified SQLConnection and AutomobileGUID.
      /// </summary>
      /// <param name="a_xSQLConnection">The database SQLConnection used to perform the action.</param>
      /// <param name="a_xAutomobileGUID">The unique identifies of the Automobile to be retrieved.</param>
      /// <returns>AutomobileAppEntity</returns>
      public static AutomobileAppEntity Read(SqlConnection a_xSQLConnection, GUID a_xAutomobileGUID)
      {
        if (m_xAutomobileAppEntity == null)
          m_xAutomobileAppEntity = new AutomobileAppEntity();

        return m_xAutomobileAppEntity.Read(a_xSQLConnection, a_xAutomobileGUID);
      }

      //=======================================================================
      //=======================================================================

      /// <summary>
      /// Update this Automobile using the specified SQLConnection.
      /// </summary>
      /// <param name="a_xSQLConnection">The database  SQLConnection used to perform the action.</param>
      /// <returns>AutomobileAppEntity</returns>
      public static AutomobileAppEntity Update(SqlConnection a_xSQLConnection)
      {
        if (m_xAutomobileAppEntity == null)
          m_xAutomobileAppEntity = new AutomobileAppEntity();

        return m_xAutomobileAppEntity.Update(a_xSQLConnection);
      }

      //=======================================================================
      //=======================================================================

      /// <summary>
      /// Delete a Automobile using the specified SQLConnection and AutomobileGUID.
      /// </summary>
      /// <param name="a_xSQLConnection">The database SQLConnection used to perform the action.</param>
      /// <param name="a_xAutomobileGUID">The unique identifies of the Automobile to be retrieved.</param>
      /// <returns>AutomobileAppEntity</returns>
      public static AutomobileAppEntity Delete(SqlConnection a_xSQLConnection, GUID a_xAutomobileGUID)
      {
        if (m_xAutomobileAppEntity == null)
          m_xAutomobileAppEntity = new AutomobileAppEntity();

        return m_xAutomobileAppEntity.Delete(a_xSQLConnection, a_xAutomobileGUID);
      }

      //=======================================================================
      //=======================================================================

      /// <summary>
      /// Loads a set of Automobiles using the specified SQLConnection and DataRequest.
      /// </summary>
      /// <param name="a_xSQLConnection">The database SQLConnection used to perform the action.</param>
      /// <returns>AutomobileAppEntity</returns>
      public static IEnumerable<AutomobileAppEntity> Load(SqlConnection a_xSQLConnection)
      {
        if (m_xAutomobileAppEntity == null)
          m_xAutomobileAppEntity = new AutomobileAppEntity();

        return m_xAutomobileAppEntity.Load(a_xSQLConnection);
      }

      //=======================================================================
      //=======================================================================

      /// <summary>
      /// Loads a set of Automobiles using the specified SQLConnection and DataRequest.
      /// </summary>
      /// <param name="a_xSQLConnection">The database SQLConnection used to perform the action.</param>
      /// <param name="a_xDataRequest">DataRequest that specifies the set of Automobiles to be retrieved.</param>
      /// <returns>AutomobileAppEntity</returns>
      public static IEnumerable<AutomobileAppEntity> Load(SqlConnection a_xSQLConnection, DataRequest a_xDataRequest)
      {
        if (m_xAutomobileAppEntity == null)
          m_xAutomobileAppEntity = new AutomobileAppEntity();

        return m_xAutomobileAppEntity.Load(a_xSQLConnection, a_xDataRequest);
      }

      //=======================================================================
      //=======================================================================

      /// <summary>
      /// Loads a set of Automobiles using the specified SQLConnection and DataRequest.
      /// </summary>
      /// <param name="a_xSQLConnection">The database SQLConnection used to perform the action.</param>
      /// <param name="a_xDataRequest">DataRequest that specifies the set of Automobiles to be retrieved; including paging information.</param>
      /// <param name="a_xDataResult">A DataResult containing the TotalCount, FilterCount, PageSize, PageCount, PageNumber, and DatabaseDateTime for the request.</param>
      /// <returns>IEnumerable<AutomobileAppEntity></returns>
      public static IEnumerable<AutomobileAppEntity> Load(SqlConnection a_xSQLConnection, DataRequest a_xDataRequest, out DataResult a_xDataResult)
      {
        if (m_xAutomobileAppEntity== null)
          m_xAutomobileAppEntity = new AutomobileAppEntity();

        return m_xAutomobileAppEntity.Load(a_xSQLConnection, a_xDataRequest, out a_xDataResult);
      }

      //=======================================================================
      //=======================================================================

      /// <summary>
      /// Import an Automobile from the current SqlDataReader record.
      /// </summary>
      /// <param name="a_xSQLDataReader">The SqlDataReader containing the record to be imported.</param>
      /// <returns>AutomobileAppEntity</returns>
      public static AutomobileAppEntity Import(SqlDataReader a_xSQLDataReader)
      {
        if (m_xAutomobileAppEntity == null)
          m_xAutomobileAppEntity = new AutomobileAppEntity();

        return m_xAutomobileAppEntity.Import(a_xSQLDataReader);
      }

      //=======================================================================
		  //=======================================================================

      private static AutomobileAppEntity m_xAutomobileAppEntity = null;

      //=======================================================================
      //=======================================================================
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    public AutomobileAppEntity()
    {
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    public AutomobileAppEntity(IUserInfo a_xUserInfo)
    {
      UserInfo = a_xUserInfo;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------
    //-----
    //----- Metadata available for "Entity[AutomobileEntityDesign]"
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
