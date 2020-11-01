using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using HumanResources.Models;
using Microsoft.Extensions.Configuration;

namespace HumanResources.Data
{
    public class MockJobTitleRepo : IJobTitleRepo
    {
        public IEnumerable<JobTitle> GetAll()
        {
            List<JobTitle> placeInfos = null;
            string sQry = @"SELECT
                                ID,
                                JobTitle
                            FROM [HumanResources].[JobTitle]";
            DataTable dtPlaceInfo = ExecuteQuery(sQry);
            if (dtPlaceInfo != null)
            {
                placeInfos = new List<JobTitle>();
                foreach (DataRow dr in dtPlaceInfo.Rows)
                    placeInfos.Add(GetJobTitleByRow(dr));
            }
            return placeInfos;
        }

        private DataTable ExecuteQuery(string strSql)
        {

            var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .AddEnvironmentVariables()
            .Build();

            string sConStr = configuration.GetConnectionString("DBConnection");
            SqlConnection conn = null;
            DataTable dt = null;
            try
            {
                conn = new SqlConnection(sConStr);
                SqlCommand cmd = new SqlCommand(strSql, conn);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                conn.Open();
                dt = new DataTable();
                da.Fill(dt);
                if (!(dt.Rows.Count > 0)) dt = null;
            }
            catch { dt = null; }
            finally { if (conn.State != 0) conn.Close(); }
            return dt;
        }

        private JobTitle GetJobTitleByRow(DataRow dr)
        {
            JobTitle jt = new JobTitle();
            jt.Id = Convert.ToInt32(dr["ID"]);
            jt.JobTitleName = dr["JobTitle"].ToString();
            return jt;
        }

    }

}