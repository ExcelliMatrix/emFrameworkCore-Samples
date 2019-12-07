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
// CodeGenFilename:  (CodeGen.SQL).xml
// TemplateFilename: (Entity.SQL).tt

using CodeGenSample.Design.App;
using emFrameworkCore.Core;
using emFrameworkCore.Data;
using emFrameworkCore.Database.Extensions;
using System.Data.SqlClient;


namespace CodeGenSample.App.Entity
{
   public partial class AutomobileAppEntity : AutomobileAppEntityDesign
   {
    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    public SqlCommand SQLCommand_Create(SqlConnection a_xSQLConnection)
    {
      string sSQLStatement = "";

      sSQLStatement =
      $@"
        insert into CodeGen_Automobile
        (
          AutomobileMake, 
          AutomobileModel, 
          AutomobileYear, 
          AutomobileGUID
        )
        values
        (
          @AutomobileMake, 
          @AutomobileModel, 
          @AutomobileYear, 
          @AutomobileGUID
        )
      ";
      if (@AutomobileGUID == null)
        AutomobileGUID = new GUID();

      SqlCommand xSQLCommand = new SqlCommand(sSQLStatement, a_xSQLConnection);
      xSQLCommand.Parameters.Add(new SqlParameter("@AutomobileMake", AutomobileMake.ToDBNull()));
      xSQLCommand.Parameters.Add(new SqlParameter("@AutomobileModel", AutomobileModel.ToDBNull()));
      xSQLCommand.Parameters.Add(new SqlParameter("@AutomobileYear", AutomobileYear.ToDBNull()));
      xSQLCommand.Parameters.Add(new SqlParameter("@AutomobileGUID", AutomobileGUID.ToString()));

      return xSQLCommand;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    public SqlCommand SQLCommand_Delete(SqlConnection a_xSQLConnection)
    {
      SqlCommand xSQLCommand = SQLCommand_Delete(a_xSQLConnection, AutomobileGUID);

      return xSQLCommand;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    public SqlCommand SQLCommand_Delete(SqlConnection a_xSQLConnection, GUID a_xGUID)
    {
      string sSQLStatement = "";

      sSQLStatement =
        $@"
          update CodeGen_Automobile
            set
              AutomobileDeleted = 'True'
            where
              AutomobileGUID = @AutomobileGUID;
        ";
      SqlCommand xSQLCommand = new SqlCommand(sSQLStatement, a_xSQLConnection);
      xSQLCommand.Parameters.Add(new SqlParameter("@AutomobileGUID", a_xGUID.ToString()));

      return xSQLCommand;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    public SqlCommand SQLCommand_Load(SqlConnection a_xSQLConnection, DataRequest a_xDataRequest)
    {
      //----- NOTE: sSQLStatement is "" by default, this instructs the
      //-----       ApplyDataRequest to use a statement SQLStatement.
      string sSQLStatement = "";

      SqlCommand xSQLCommand = new SqlCommand(sSQLStatement, a_xSQLConnection);
      xSQLCommand = DataRequestExtension.ApplyDataRequest<AutomobileAppEntityDesign>(xSQLCommand, a_xDataRequest);

      return xSQLCommand;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    public SqlCommand SQLCommand_Read(SqlConnection a_xSQLConnection)
    {
      SqlCommand xSQLCommand = SQLCommand_Read(a_xSQLConnection, AutomobileGUID);

      return xSQLCommand;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    public SqlCommand SQLCommand_Read(SqlConnection a_xSQLConnection, GUID a_xGUID)
    {
      string sSQLStatement = "";

      sSQLStatement =
      $@"
        select
            *
          from 
            CodeGen_Automobile
          where
            AutomobileGUID = @AutomobileGUID
      ";

      SqlCommand xSQLCommand = new SqlCommand(sSQLStatement, a_xSQLConnection);
      xSQLCommand.Parameters.Add(new SqlParameter("AutomobileGUID", a_xGUID.ToString()));

      return xSQLCommand;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    public SqlCommand SQLCommand_Update(SqlConnection a_xSQLConnection)
    {
      string sSQLStatement = "";

      sSQLStatement =
      $@"
        update CodeGen_Automobile
          set 
            AutomobileMake                           = @AutomobileMake,
            AutomobileModel                          = @AutomobileModel,
            AutomobileYear                           = @AutomobileYear
          where
            AutomobileGUID = @AutomobileGUID
      ";

      SqlCommand xSQLCommand = new SqlCommand(sSQLStatement, a_xSQLConnection);
      xSQLCommand.Parameters.Add(new SqlParameter("@AutomobileMake", AutomobileMake.ToDBNull()));
      xSQLCommand.Parameters.Add(new SqlParameter("@AutomobileModel", AutomobileModel.ToDBNull()));
      xSQLCommand.Parameters.Add(new SqlParameter("@AutomobileYear", AutomobileYear.ToDBNull()));
      xSQLCommand.Parameters.Add(new SqlParameter("@AutomobileGUID", AutomobileGUID.ToString()));

      return xSQLCommand;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------
    //-----
    //----- Metadata available for "Entity[AutomobileAppEntityDesign]"
    //-----
    //----- AutomobileGUID                           Key = "Entity[AutomobileAppEntityDesign].Property[AutomobileGUID]"
    //----- AutomobileMake                           Key = "Entity[AutomobileAppEntityDesign].Property[AutomobileMake]"
    //----- AutomobileModel                          Key = "Entity[AutomobileAppEntityDesign].Property[AutomobileModel]"
    //----- AutomobileYear                           Key = "Entity[AutomobileAppEntityDesign].Property[AutomobileYear]"
    //-----
    //-----
    //----- (Type)                                   Entity[AutomobileAppEntityDesign] == "null"
    //----- (TypeAttribute)                          Entity[AutomobileAppEntityDesign].Attribute[DatabaseTable] == "True"
    //----- (TypeAttributeProperty)                  Entity[AutomobileAppEntityDesign].Attribute[DatabaseTable].Property[Name] == "CodeGen_Automobile"
    //----- (TypeAttributeProperty)                  Entity[AutomobileAppEntityDesign].Attribute[DatabaseTable].Property[Schema] == "null"
    //----- (TypeAttribute)                          Entity[AutomobileAppEntityDesign].Attribute[Table] == "True"
    //----- (TypeAttributeProperty)                  Entity[AutomobileAppEntityDesign].Attribute[Table].Property[Name] == "CodeGen_Automobile"
    //----- (TypeAttributeProperty)                  Entity[AutomobileAppEntityDesign].Attribute[Table].Property[Schema] == "null"
    //----- (TypeProperty)                           Entity[AutomobileAppEntityDesign].Property[AutomobileGUID] == "null"
    //----- (TypePropertyAttribute)                  Entity[AutomobileAppEntityDesign].Property[AutomobileGUID].Attribute[Column] == "True"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobileAppEntityDesign].Property[AutomobileGUID].Attribute[Column].Property[Name] == "AutomobileGUID"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobileAppEntityDesign].Property[AutomobileGUID].Attribute[Column].Property[Order] == "-1"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobileAppEntityDesign].Property[AutomobileGUID].Attribute[Column].Property[TypeName] == "null"
    //----- (TypePropertyAttribute)                  Entity[AutomobileAppEntityDesign].Property[AutomobileGUID].Attribute[DatabaseTableColumn] == "True"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobileAppEntityDesign].Property[AutomobileGUID].Attribute[DatabaseTableColumn].Property[Name] == "AutomobileGUID"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobileAppEntityDesign].Property[AutomobileGUID].Attribute[DatabaseTableColumn].Property[Order] == "-1"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobileAppEntityDesign].Property[AutomobileGUID].Attribute[DatabaseTableColumn].Property[TypeName] == "null"
    //----- (TypePropertyAttribute)                  Entity[AutomobileAppEntityDesign].Property[AutomobileGUID].Attribute[Key] == "True"
    //----- (TypeProperty)                           Entity[AutomobileAppEntityDesign].Property[AutomobileMake] == "null"
    //----- (TypePropertyAttribute)                  Entity[AutomobileAppEntityDesign].Property[AutomobileMake].Attribute[Column] == "True"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobileAppEntityDesign].Property[AutomobileMake].Attribute[Column].Property[Name] == "AutomobileMake"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobileAppEntityDesign].Property[AutomobileMake].Attribute[Column].Property[Order] == "-1"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobileAppEntityDesign].Property[AutomobileMake].Attribute[Column].Property[TypeName] == "null"
    //----- (TypePropertyAttribute)                  Entity[AutomobileAppEntityDesign].Property[AutomobileMake].Attribute[DatabaseTableColumn] == "True"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobileAppEntityDesign].Property[AutomobileMake].Attribute[DatabaseTableColumn].Property[Name] == "AutomobileMake"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobileAppEntityDesign].Property[AutomobileMake].Attribute[DatabaseTableColumn].Property[Order] == "-1"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobileAppEntityDesign].Property[AutomobileMake].Attribute[DatabaseTableColumn].Property[TypeName] == "null"
    //----- (TypePropertyAttribute)                  Entity[AutomobileAppEntityDesign].Property[AutomobileMake].Attribute[StringLength] == "True"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobileAppEntityDesign].Property[AutomobileMake].Attribute[StringLength].Property[MaximumLength] == "40"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobileAppEntityDesign].Property[AutomobileMake].Attribute[StringLength].Property[MinimumLength] == "0"
    //----- (TypeProperty)                           Entity[AutomobileAppEntityDesign].Property[AutomobileModel] == "null"
    //----- (TypePropertyAttribute)                  Entity[AutomobileAppEntityDesign].Property[AutomobileModel].Attribute[Column] == "True"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobileAppEntityDesign].Property[AutomobileModel].Attribute[Column].Property[Name] == "AutomobileModel"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobileAppEntityDesign].Property[AutomobileModel].Attribute[Column].Property[Order] == "-1"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobileAppEntityDesign].Property[AutomobileModel].Attribute[Column].Property[TypeName] == "null"
    //----- (TypePropertyAttribute)                  Entity[AutomobileAppEntityDesign].Property[AutomobileModel].Attribute[DatabaseTableColumn] == "True"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobileAppEntityDesign].Property[AutomobileModel].Attribute[DatabaseTableColumn].Property[Name] == "AutomobileModel"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobileAppEntityDesign].Property[AutomobileModel].Attribute[DatabaseTableColumn].Property[Order] == "-1"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobileAppEntityDesign].Property[AutomobileModel].Attribute[DatabaseTableColumn].Property[TypeName] == "null"
    //----- (TypePropertyAttribute)                  Entity[AutomobileAppEntityDesign].Property[AutomobileModel].Attribute[StringLength] == "True"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobileAppEntityDesign].Property[AutomobileModel].Attribute[StringLength].Property[MaximumLength] == "40"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobileAppEntityDesign].Property[AutomobileModel].Attribute[StringLength].Property[MinimumLength] == "0"
    //----- (TypeProperty)                           Entity[AutomobileAppEntityDesign].Property[AutomobileYear] == "null"
    //----- (TypePropertyAttribute)                  Entity[AutomobileAppEntityDesign].Property[AutomobileYear].Attribute[Column] == "True"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobileAppEntityDesign].Property[AutomobileYear].Attribute[Column].Property[Name] == "AutomobileYear"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobileAppEntityDesign].Property[AutomobileYear].Attribute[Column].Property[Order] == "-1"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobileAppEntityDesign].Property[AutomobileYear].Attribute[Column].Property[TypeName] == "null"
    //----- (TypePropertyAttribute)                  Entity[AutomobileAppEntityDesign].Property[AutomobileYear].Attribute[DatabaseTableColumn] == "True"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobileAppEntityDesign].Property[AutomobileYear].Attribute[DatabaseTableColumn].Property[Name] == "AutomobileYear"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobileAppEntityDesign].Property[AutomobileYear].Attribute[DatabaseTableColumn].Property[Order] == "-1"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobileAppEntityDesign].Property[AutomobileYear].Attribute[DatabaseTableColumn].Property[TypeName] == "null"
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
