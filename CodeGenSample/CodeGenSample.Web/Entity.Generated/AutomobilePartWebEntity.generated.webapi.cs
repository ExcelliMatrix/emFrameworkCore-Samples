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

using CodeGenSample.Design;
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

    public HttpResponseMessage WebAPI_Delete(Uri a_xURI, GUID a_xAutomobilePartGUID)
    {
      HttpResponseMessage xReturnValue = null;

      HttpClient xHttpClient = new HttpClient();
      string sURL = $"{a_xURI}/{a_xAutomobilePartGUID}";
      xReturnValue = xHttpClient.DeleteAsync(sURL).Result;

      return xReturnValue;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    public IEnumerable<AutomobilePartWebEntity> WebAPI_Load(Uri a_xURI, DataRequest a_xDataRequest)
    {
      IEnumerable<AutomobilePartWebEntity> xAutomobilePartWebEntities = null;

      HttpClient xHTTPClient = new HttpClient();
      Uri xURI = new Uri(a_xURI, "/api/AutomobilePart/Load");
      HttpRequestMessage xHTTPRequestMessage = new HttpRequestMessage(HttpMethod.Get, xURI);
      string sJSON = JsonConvert.SerializeObject(a_xDataRequest);
      xHTTPRequestMessage.Content = new StringContent(sJSON);
      xHTTPClient.SendAsync(xHTTPRequestMessage);
      HttpResponseMessage xHTTPResponseMessage = xHTTPClient.GetAsync(xURI).Result;
      if (xHTTPResponseMessage.IsSuccessStatusCode)
      {
        string sResult = xHTTPResponseMessage.Content.ReadAsStringAsync().Result;
        xAutomobilePartWebEntities = JsonConvert.DeserializeObject<IEnumerable<AutomobilePartWebEntity>>(sResult);
      }

      return xAutomobilePartWebEntities;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    public AutomobilePartWebEntity WebAPI_Read(Uri a_xURI)
    {
      AutomobilePartWebEntity xReturnValue = WebAPI_Read(a_xURI, AutomobilePartGUID);

      return xReturnValue;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    public AutomobilePartWebEntity WebAPI_Read(Uri a_xURI, GUID a_xAutomobilePartGUID)
    {
      AutomobilePartWebEntity xAutomobilePartWebEntity = null;

      HttpClient xHTTPClient = new HttpClient();
      Uri xURI = new Uri(a_xURI, $"/api/AutomobilePart/Read/{a_xAutomobilePartGUID.GUIDString}");
      HttpResponseMessage xHTTPResponseMessage = xHTTPClient.GetAsync(xURI).Result;
      if (xHTTPResponseMessage.IsSuccessStatusCode)
      {
        string sResult = xHTTPResponseMessage.Content.ReadAsStringAsync().Result;
        xAutomobilePartWebEntity = JsonConvert.DeserializeObject<AutomobilePartWebEntity>(sResult);
      }

      return xAutomobilePartWebEntity;
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
