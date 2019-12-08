using emFrameworkCore.Core;
using System;
using System.Data.SqlClient;

namespace CodeGenSample
{
  public static class ApplicationInfo
  {
    public static string Name { get { return "CodeGenSample.App"; } }
    public static ApplicationTier Tier { get { return ApplicationTier.Application; } }
    public static SqlConnection SQLConnection
    {
      get
      {
        if (m_xSQLConnection == null)
        {
          string sConnectionString = $@"Server=(localdb)\MSSQLLocalDB;Database=CodeGenSampleDB;Integrated Security=True;";
          m_xSQLConnection = new SqlConnection(sConnectionString);
        }

        return m_xSQLConnection;
      }
      set
      {
        m_xSQLConnection = value;
      }
    }
    private static SqlConnection m_xSQLConnection = null;
  }
}
