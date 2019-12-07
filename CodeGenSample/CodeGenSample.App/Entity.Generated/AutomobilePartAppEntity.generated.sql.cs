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
   public partial class AutomobilePartAppEntity : AutomobilePartAppEntityDesign
   {
    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    public SqlCommand SQLCommand_Create(SqlConnection a_xSQLConnection)
    {
      string sSQLStatement = "";

      sSQLStatement =
      $@"
        insert into CodeGen_AutomobilePart
        (
          AutomobileGUID, 
          AutomobilePartDescription, 
          AutomobilePartName, 
          AutomobilePartNumber, 
          AutomobilePartPrice, 
          AutomobilePartGUID
        )
        values
        (
          @AutomobileGUID, 
          @AutomobilePartDescription, 
          @AutomobilePartName, 
          @AutomobilePartNumber, 
          @AutomobilePartPrice, 
          @AutomobilePartGUID
        )
      ";
      if (@AutomobilePartGUID == null)
        AutomobilePartGUID = new GUID();

      SqlCommand xSQLCommand = new SqlCommand(sSQLStatement, a_xSQLConnection);
      xSQLCommand.Parameters.Add(new SqlParameter("@AutomobileGUID", AutomobileGUID == null ? System.DBNull.Value : AutomobileGUID.ToString().ToDBNull()));
      xSQLCommand.Parameters.Add(new SqlParameter("@AutomobilePartDescription", AutomobilePartDescription.ToDBNull()));
      xSQLCommand.Parameters.Add(new SqlParameter("@AutomobilePartName", AutomobilePartName.ToDBNull()));
      xSQLCommand.Parameters.Add(new SqlParameter("@AutomobilePartNumber", AutomobilePartNumber.ToDBNull()));
      xSQLCommand.Parameters.Add(new SqlParameter("@AutomobilePartPrice", AutomobilePartPrice.ToDBNull()));
      xSQLCommand.Parameters.Add(new SqlParameter("@AutomobilePartGUID", AutomobilePartGUID.ToString()));

      return xSQLCommand;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    public SqlCommand SQLCommand_Delete(SqlConnection a_xSQLConnection)
    {
      SqlCommand xSQLCommand = SQLCommand_Delete(a_xSQLConnection, AutomobilePartGUID);

      return xSQLCommand;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    public SqlCommand SQLCommand_Delete(SqlConnection a_xSQLConnection, GUID a_xGUID)
    {
      string sSQLStatement = "";

      sSQLStatement =
        $@"
          update CodeGen_AutomobilePart
            set
              AutomobilePartDeleted = 'True'
            where
              AutomobilePartGUID = @AutomobilePartGUID;
        ";
      SqlCommand xSQLCommand = new SqlCommand(sSQLStatement, a_xSQLConnection);
      xSQLCommand.Parameters.Add(new SqlParameter("@AutomobilePartGUID", a_xGUID.ToString()));

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
      xSQLCommand = DataRequestExtension.ApplyDataRequest<AutomobilePartAppEntityDesign>(xSQLCommand, a_xDataRequest);

      return xSQLCommand;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    public SqlCommand SQLCommand_Read(SqlConnection a_xSQLConnection)
    {
      SqlCommand xSQLCommand = SQLCommand_Read(a_xSQLConnection, AutomobilePartGUID);

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
            CodeGen_AutomobilePart
          where
            AutomobilePartGUID = @AutomobilePartGUID
      ";

      SqlCommand xSQLCommand = new SqlCommand(sSQLStatement, a_xSQLConnection);
      xSQLCommand.Parameters.Add(new SqlParameter("AutomobilePartGUID", a_xGUID.ToString()));

      return xSQLCommand;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    public SqlCommand SQLCommand_Update(SqlConnection a_xSQLConnection)
    {
      string sSQLStatement = "";

      sSQLStatement =
      $@"
        update CodeGen_AutomobilePart
          set 
            AutomobileGUID                           = @AutomobileGUID,
            AutomobilePartDescription                = @AutomobilePartDescription,
            AutomobilePartName                       = @AutomobilePartName,
            AutomobilePartNumber                     = @AutomobilePartNumber,
            AutomobilePartPrice                      = @AutomobilePartPrice
          where
            AutomobilePartGUID = @AutomobilePartGUID
      ";

      SqlCommand xSQLCommand = new SqlCommand(sSQLStatement, a_xSQLConnection);
      xSQLCommand.Parameters.Add(new SqlParameter("@AutomobileGUID", AutomobileGUID.ToString().ToDBNull()));
      xSQLCommand.Parameters.Add(new SqlParameter("@AutomobilePartDescription", AutomobilePartDescription.ToDBNull()));
      xSQLCommand.Parameters.Add(new SqlParameter("@AutomobilePartName", AutomobilePartName.ToDBNull()));
      xSQLCommand.Parameters.Add(new SqlParameter("@AutomobilePartNumber", AutomobilePartNumber.ToDBNull()));
      xSQLCommand.Parameters.Add(new SqlParameter("@AutomobilePartPrice", AutomobilePartPrice.ToDBNull()));
      xSQLCommand.Parameters.Add(new SqlParameter("@AutomobilePartGUID", AutomobilePartGUID.ToString()));

      return xSQLCommand;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------
    //-----
    //----- Metadata available for "Entity[AutomobilePartAppEntityDesign]"
    //-----
    //----- AutomobileGUID                           Key = "Entity[AutomobilePartAppEntityDesign].Property[AutomobileGUID]"
    //----- AutomobilePartDescription                Key = "Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartDescription]"
    //----- AutomobilePartGUID                       Key = "Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartGUID]"
    //----- AutomobilePartName                       Key = "Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartName]"
    //----- AutomobilePartNumber                     Key = "Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartNumber]"
    //----- AutomobilePartPrice                      Key = "Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartPrice]"
    //-----
    //-----
    //----- (Type)                                   Entity[AutomobilePartAppEntityDesign] == "null"
    //----- (TypeAttribute)                          Entity[AutomobilePartAppEntityDesign].Attribute[DatabaseTable] == "True"
    //----- (TypeAttributeProperty)                  Entity[AutomobilePartAppEntityDesign].Attribute[DatabaseTable].Property[Name] == "CodeGen_AutomobilePart"
    //----- (TypeAttributeProperty)                  Entity[AutomobilePartAppEntityDesign].Attribute[DatabaseTable].Property[Schema] == "null"
    //----- (TypeAttribute)                          Entity[AutomobilePartAppEntityDesign].Attribute[Table] == "True"
    //----- (TypeAttributeProperty)                  Entity[AutomobilePartAppEntityDesign].Attribute[Table].Property[Name] == "CodeGen_AutomobilePart"
    //----- (TypeAttributeProperty)                  Entity[AutomobilePartAppEntityDesign].Attribute[Table].Property[Schema] == "null"
    //----- (TypeProperty)                           Entity[AutomobilePartAppEntityDesign].Property[AutomobileGUID] == "null"
    //----- (TypePropertyAttribute)                  Entity[AutomobilePartAppEntityDesign].Property[AutomobileGUID].Attribute[Column] == "True"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobilePartAppEntityDesign].Property[AutomobileGUID].Attribute[Column].Property[Name] == "AutomobileGUID"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobilePartAppEntityDesign].Property[AutomobileGUID].Attribute[Column].Property[Order] == "-1"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobilePartAppEntityDesign].Property[AutomobileGUID].Attribute[Column].Property[TypeName] == "null"
    //----- (TypePropertyAttribute)                  Entity[AutomobilePartAppEntityDesign].Property[AutomobileGUID].Attribute[DatabaseTableColumn] == "True"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobilePartAppEntityDesign].Property[AutomobileGUID].Attribute[DatabaseTableColumn].Property[Name] == "AutomobileGUID"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobilePartAppEntityDesign].Property[AutomobileGUID].Attribute[DatabaseTableColumn].Property[Order] == "-1"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobilePartAppEntityDesign].Property[AutomobileGUID].Attribute[DatabaseTableColumn].Property[TypeName] == "null"
    //----- (TypeProperty)                           Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartDescription] == "null"
    //----- (TypePropertyAttribute)                  Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartDescription].Attribute[Column] == "True"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartDescription].Attribute[Column].Property[Name] == "AutomobilePartDescription"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartDescription].Attribute[Column].Property[Order] == "-1"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartDescription].Attribute[Column].Property[TypeName] == "null"
    //----- (TypePropertyAttribute)                  Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartDescription].Attribute[DatabaseTableColumn] == "True"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartDescription].Attribute[DatabaseTableColumn].Property[Name] == "AutomobilePartDescription"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartDescription].Attribute[DatabaseTableColumn].Property[Order] == "-1"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartDescription].Attribute[DatabaseTableColumn].Property[TypeName] == "null"
    //----- (TypePropertyAttribute)                  Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartDescription].Attribute[StringLength] == "True"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartDescription].Attribute[StringLength].Property[MaximumLength] == "40"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartDescription].Attribute[StringLength].Property[MinimumLength] == "0"
    //----- (TypeProperty)                           Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartGUID] == "null"
    //----- (TypePropertyAttribute)                  Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartGUID].Attribute[Column] == "True"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartGUID].Attribute[Column].Property[Name] == "AutomobilePartGUID"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartGUID].Attribute[Column].Property[Order] == "-1"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartGUID].Attribute[Column].Property[TypeName] == "null"
    //----- (TypePropertyAttribute)                  Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartGUID].Attribute[DatabaseTableColumn] == "True"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartGUID].Attribute[DatabaseTableColumn].Property[Name] == "AutomobilePartGUID"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartGUID].Attribute[DatabaseTableColumn].Property[Order] == "-1"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartGUID].Attribute[DatabaseTableColumn].Property[TypeName] == "null"
    //----- (TypePropertyAttribute)                  Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartGUID].Attribute[Key] == "True"
    //----- (TypeProperty)                           Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartName] == "null"
    //----- (TypePropertyAttribute)                  Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartName].Attribute[Column] == "True"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartName].Attribute[Column].Property[Name] == "AutomobilePartName"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartName].Attribute[Column].Property[Order] == "-1"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartName].Attribute[Column].Property[TypeName] == "null"
    //----- (TypePropertyAttribute)                  Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartName].Attribute[DatabaseTableColumn] == "True"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartName].Attribute[DatabaseTableColumn].Property[Name] == "AutomobilePartName"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartName].Attribute[DatabaseTableColumn].Property[Order] == "-1"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartName].Attribute[DatabaseTableColumn].Property[TypeName] == "null"
    //----- (TypePropertyAttribute)                  Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartName].Attribute[StringLength] == "True"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartName].Attribute[StringLength].Property[MaximumLength] == "40"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartName].Attribute[StringLength].Property[MinimumLength] == "0"
    //----- (TypeProperty)                           Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartNumber] == "null"
    //----- (TypePropertyAttribute)                  Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartNumber].Attribute[Column] == "True"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartNumber].Attribute[Column].Property[Name] == "AutomobilePartNumber"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartNumber].Attribute[Column].Property[Order] == "-1"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartNumber].Attribute[Column].Property[TypeName] == "null"
    //----- (TypePropertyAttribute)                  Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartNumber].Attribute[DatabaseTableColumn] == "True"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartNumber].Attribute[DatabaseTableColumn].Property[Name] == "AutomobilePartNumber"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartNumber].Attribute[DatabaseTableColumn].Property[Order] == "-1"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartNumber].Attribute[DatabaseTableColumn].Property[TypeName] == "null"
    //----- (TypePropertyAttribute)                  Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartNumber].Attribute[StringLength] == "True"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartNumber].Attribute[StringLength].Property[MaximumLength] == "40"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartNumber].Attribute[StringLength].Property[MinimumLength] == "0"
    //----- (TypeProperty)                           Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartPrice] == "null"
    //----- (TypePropertyAttribute)                  Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartPrice].Attribute[Column] == "True"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartPrice].Attribute[Column].Property[Name] == "AutomobilePartPrice"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartPrice].Attribute[Column].Property[Order] == "-1"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartPrice].Attribute[Column].Property[TypeName] == "null"
    //----- (TypePropertyAttribute)                  Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartPrice].Attribute[DatabaseTableColumn] == "True"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartPrice].Attribute[DatabaseTableColumn].Property[Name] == "AutomobilePartPrice"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartPrice].Attribute[DatabaseTableColumn].Property[Order] == "-1"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartPrice].Attribute[DatabaseTableColumn].Property[TypeName] == "null"
    //----- (TypePropertyAttribute)                  Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartPrice].Attribute[StringLength] == "True"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartPrice].Attribute[StringLength].Property[MaximumLength] == "40"
    //----- (TypePropertyAttributeProperty)          Entity[AutomobilePartAppEntityDesign].Property[AutomobilePartPrice].Attribute[StringLength].Property[MinimumLength] == "0"
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
