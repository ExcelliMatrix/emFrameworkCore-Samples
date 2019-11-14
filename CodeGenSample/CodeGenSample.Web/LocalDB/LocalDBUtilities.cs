using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CodeGenSample.Web.LocalDB
{
  public static class LocalDBUtilities
  {

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    public static void Create(string a_sDatabaseName)
    {
      if (IsLocalDBInstalled() == false)
      {
        System.Diagnostics.Debugger.Break();
        throw new Exception("LocalDB is not currently installed.");
      }
      else
      {
        string sTempPath = Path.GetTempPath();
        string sDatabaseFileName = $"{sTempPath}\\{a_sDatabaseName}_Data01.mdf";
        string sLogFileName = $"{sTempPath}\\{a_sDatabaseName}_Log01.ldf";
        if (File.Exists(sDatabaseFileName) == false)
        {
          string sConnectionString = $@"Server=(localdb)\MSSQLLocalDB;Database=master;Integrated Security=True;";
          SqlConnection xSQLConnection = new SqlConnection(sConnectionString);
          using (xSQLConnection)
          {
            xSQLConnection.Open();

            string sSQLStatement = "";
            sSQLStatement += $"create database [{a_sDatabaseName}]";
            sSQLStatement += $"  on primary (name={Path.GetFileNameWithoutExtension(sDatabaseFileName)}, filename='{sDatabaseFileName}')";
            sSQLStatement += $"  log on     (name={Path.GetFileNameWithoutExtension(sLogFileName)},      filename='{sLogFileName}')";

            SqlCommand xSQLCommand = new SqlCommand(sSQLStatement, xSQLConnection);
            xSQLCommand.ExecuteNonQuery();

            xSQLConnection.Close();
          }

          if (File.Exists(sDatabaseFileName) == false)
          {
            System.Diagnostics.Debugger.Break();
            throw new Exception($"Creation of database '{a_sDatabaseName}' failed.");
          }

          sConnectionString = $@"Server=(localdb)\MSSQLLocalDB;Database={a_sDatabaseName};Integrated Security=True;";
          xSQLConnection = new SqlConnection(sConnectionString);
          using (xSQLConnection)
          {
            xSQLConnection.Open();

            string sSQLStatement = "";
            sSQLStatement += "create table [CodeGen_Automobile]\r\n";
            sSQLStatement += "(\r\n";
            sSQLStatement += "  AutomobileGUID                            varchar(40)                         not null default(('{'+lower(newid()))+'}'),\r\n";
            sSQLStatement += "  AutomobileMake                            varchar(25)                         not null,\r\n";
            sSQLStatement += "  AutomobileModel                           varchar(50)                         not null,\r\n";
            sSQLStatement += "  AutomobileYear                            int                                 not null,\r\n";
            sSQLStatement += "  AutomobileDeleted                         varchar(5)                          not null default ('False'),\r\n";
            sSQLStatement += "\r\n";
            sSQLStatement += "  constraint CodeGen_Automobile_PK primary key nonclustered (AutomobileGUID asc)\r\n";
            sSQLStatement += ");\r\n";
            SqlCommand xSQLCommand = new SqlCommand(sSQLStatement, xSQLConnection);
            xSQLCommand.ExecuteNonQuery();

            AddAutomobile(xSQLConnection, "{f712dd3a-697d-426a-9869-b7e9b0da22ce}", "Chevrolet", "Camero", 2018);

            sSQLStatement = "";
            sSQLStatement += "create table [CodeGen_AutomobilePart]\r\n";
            sSQLStatement += "(\r\n";
            sSQLStatement += "  AutomobilePartGUID                        varchar(40)                         not null default(('{'+lower(newid()))+'}'),\r\n";
            sSQLStatement += "  AutomobileGUID                            varchar(40)                         not null,\r\n";
            sSQLStatement += "  AutomobilePartNumber                      varchar(100)                        not null,\r\n";
            sSQLStatement += "  AutomobilePartName                        varchar(100)                        not null,\r\n";
            sSQLStatement += "  AutomobilePartDescription                 varchar(2000)                           null,\r\n";
            sSQLStatement += "  AutomobilePartPrice                       money                               not null,\r\n";
            sSQLStatement += "  AutomobilePartDeleted                     varchar(5)                          not null default ('False'),\r\n";
            sSQLStatement += "\r\n";
            sSQLStatement += "  constraint CodeGen_AutomobilePart_PK primary key nonclustered (AutomobilePartGUID asc)\r\n";
            sSQLStatement += ");\r\n";
            sSQLStatement += "\r\n";
            sSQLStatement += "alter table CodeGen_AutomobilePart add constraint CodeGen_AutomobilePart_FK01 foreign key (AutomobileGUID) references CodeGen_Automobile(AutomobileGUID) on delete cascade;\r\n";

            xSQLCommand = new SqlCommand(sSQLStatement, xSQLConnection);
            xSQLCommand.ExecuteNonQuery();

            AddAutomobilePart(xSQLConnection, "{e17ef11d-d8da-4930-81ab-352aba626ef8}", "{f712dd3a-697d-426a-9869-b7e9b0da22ce}", "123454", "Muffler", "Exhaust muffler for standard configuration vehicle", 123.45m);

            xSQLConnection.Close();
          }
        }
      }
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    private static void AddAutomobile(SqlConnection a_xSQLConnection, string a_sAutomobileGUID, string a_sAutomobileMake, string a_sAutomobileModel, int a_iAutomobileYear)
    {
      string sSQLStatement = "";
      sSQLStatement += "insert into [CodeGen_Automobile] (AutomobileGUID,  AutomobileMake,  AutomobileModel,  AutomobileYear)\r\n";
      sSQLStatement += "                          values (@AutomobileGUID, @AutomobileMake, @AutomobileModel, @AutomobileYear);\r\n";

      SqlCommand xSQLCommand = new SqlCommand(sSQLStatement, a_xSQLConnection);
      xSQLCommand.Parameters.AddWithValue("@AutomobileGUID", a_sAutomobileGUID);
      xSQLCommand.Parameters.AddWithValue("@AutomobileMake", a_sAutomobileMake);
      xSQLCommand.Parameters.AddWithValue("@AutomobileModel", a_sAutomobileModel);
      xSQLCommand.Parameters.AddWithValue("@AutomobileYear", a_iAutomobileYear);

      xSQLCommand.ExecuteNonQuery();
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    private static void AddAutomobilePart(SqlConnection a_xSQLConnection, string a_sAutomobilePartGUID, string a_sAutomobileGUID, string a_sAutomobilePartNumber, string a_sAutomobilePartName, string a_sAutomobilePartDescription, decimal a_dAutomobilePartPrice)
    {
      string sSQLStatement = "";
      sSQLStatement += "insert into [CodeGen_AutomobilePart] (AutomobilePartGUID,  AutomobileGUID,  AutomobilePartNumber,  AutomobilePartName,  AutomobilePartDescription,  AutomobilePartPrice)\r\n";
      sSQLStatement += "                             values  (@AutomobilePartGUID, @AutomobileGUID, @AutomobilePartNumber, @AutomobilePartName, @AutomobilePartDescription, @AutomobilePartPrice);\r\n";

      SqlCommand xSQLCommand = new SqlCommand(sSQLStatement, a_xSQLConnection);
      xSQLCommand.Parameters.AddWithValue("@AutomobilePartGUID", a_sAutomobilePartGUID);
      xSQLCommand.Parameters.AddWithValue("@AutomobileGUID", a_sAutomobileGUID);
      xSQLCommand.Parameters.AddWithValue("@AutomobilePartNumber", a_sAutomobilePartNumber);
      xSQLCommand.Parameters.AddWithValue("@AutomobilePartName", a_sAutomobilePartName);
      xSQLCommand.Parameters.AddWithValue("@AutomobilePartDescription", a_sAutomobilePartDescription);
      xSQLCommand.Parameters.AddWithValue("@AutomobilePartPrice", a_dAutomobilePartPrice);

      xSQLCommand.ExecuteNonQuery();
    }

    /*

    */

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    private static string LocalDBFileName()
    {
      string sReturnValue = "SqlLocalDB.exe";

      return sReturnValue;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    private static bool IsLocalDBInstalled()
    {
      bool bReturnValue = ExistsOnPath(LocalDBFileName());

      return bReturnValue;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    private static string LocalDBFullPath()
    {
      string sReturnValue = GetFullPath(LocalDBFileName());

      return sReturnValue;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    private static bool ExistsOnPath(string a_sFileName)
    {
      bool bReturnValue = false;

      string sFullPath = GetFullPath(a_sFileName);

      if (string.IsNullOrEmpty(sFullPath) == false)
        bReturnValue = true;

      return bReturnValue;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    private static string GetFullPath(string a_sFileName)
    {
      string sReturnValue = null;

      if (File.Exists(a_sFileName))
      {
        sReturnValue = Path.GetFullPath(a_sFileName);
      }
      else
      {
        string sEnvironmentPath = Environment.GetEnvironmentVariable("PATH");

        foreach (var path in sEnvironmentPath.Split(';'))
        {
          string sFullPath = Path.Combine(path, a_sFileName);

          if (File.Exists(sFullPath))
            sReturnValue = sFullPath;
        }
      }

      return sReturnValue;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

  }
}
