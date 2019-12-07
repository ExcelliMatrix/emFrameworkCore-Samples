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
   public partial class AutomobileWebEntity
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
      HttpResponseMessage xReturnValue = WebAPI_Delete(a_xURI, AutomobileGUID);

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
      HttpResponseMessage xReturnValue = WebAPI_Read(a_xURI, AutomobileGUID);

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
