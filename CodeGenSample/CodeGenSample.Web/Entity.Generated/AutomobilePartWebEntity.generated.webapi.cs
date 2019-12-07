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
// CodeGenFilename:  (CodeGen.WebAPI).xml
// TemplateFilename: (Entity.WebAPI).tt

using CodeGenSample.Design.Web;
using CodeGenSample.WebTier;
using emFrameworkCore.Core;
using emFrameworkCore.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;


namespace CodeGenSample.Web.Entity
{
   public partial class AutomobilePartWebEntity
   {
    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    public HttpResponseMessage WebAPI_Create(Uri a_xURI)
    {
      HttpResponseMessage xReturnValue = null;

      HttpClient xHttpClient = new HttpClient();
      List<KeyValuePair<string, string>> xKeyValuePairs = Export_ToKeyValuePairs();
      FormUrlEncodedContent formUrlEncodedContent = new FormUrlEncodedContent(xKeyValuePairs);
      xReturnValue = xHttpClient.PostAsync(a_xURI, formUrlEncodedContent).Result;

      return xReturnValue;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    public HttpResponseMessage WebAPI_Delete(Uri a_xURI)
    {
      HttpResponseMessage xReturnValue = WebAPI_Delete(a_xURI, AutomobilePartGUID);

      return xReturnValue;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    public HttpResponseMessage WebAPI_Delete(Uri a_xURI, GUID a_xGUID)
    {
      HttpResponseMessage xReturnValue = null;

      HttpClient xHttpClient = new HttpClient();
      string sURL = $"{a_xURI}/{a_xGUID}";
      xReturnValue = xHttpClient.DeleteAsync(sURL).Result;

      return xReturnValue;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    public HttpResponseMessage WebAPI_Load(Uri a_xURI, DataRequest a_xDataRequest)
    {
      HttpResponseMessage xReturnValue = null;

      HttpClient xHttpClient = new HttpClient();
      xReturnValue = xHttpClient.DeleteAsync(a_xURI).Result;

      return xReturnValue;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    public HttpResponseMessage WebAPI_Read(Uri a_xURI)
    {
      HttpResponseMessage xReturnValue = WebAPI_Read(a_xURI, AutomobilePartGUID);

      return xReturnValue;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    public HttpResponseMessage WebAPI_Read(Uri a_xURI, GUID a_xGUID)
    {
      HttpResponseMessage xReturnValue = null;

      HttpClient xHttpClient = new HttpClient();
      string sURL = $"{a_xURI}/{a_xGUID}";
      xReturnValue = xHttpClient.DeleteAsync(sURL).Result;

      return xReturnValue;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    public HttpResponseMessage WebAPI_Update(Uri a_xURI)
    {
      HttpResponseMessage xReturnValue = null;

      HttpClient xHttpClient = new HttpClient();
      List<KeyValuePair<string, string>> xKeyValuePairs = Export_ToKeyValuePairs();
      FormUrlEncodedContent formUrlEncodedContent = new FormUrlEncodedContent(xKeyValuePairs);
      xReturnValue = xHttpClient.PutAsync(a_xURI, formUrlEncodedContent).Result;

      return xReturnValue;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------


	

	

    //---------------------------------------------------------------------------------------------
    //-----
    //----- Metadata available for "Entity[AutomobilePartWebEntityDesign]"
    //-----
    //----- AutomobileGUID                           Key = "Entity[AutomobilePartWebEntityDesign].Property[AutomobileGUID]"
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

//**********************************************************************************
//*                                                                                *
//* This code was generated from an emFramework Template. DO NOT MODIFY THIS FILE. *
//*                                                       -----------------------  *
//**********************************************************************************
