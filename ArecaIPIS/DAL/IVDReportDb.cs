﻿using ArecaIPIS.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArecaIPIS.DAL
{
    class IVDReportDb
    {

        private DbConnection dbConnection;
        public IVDReportDb()
        {
            dbConnection = new DbConnection();
        }


        public DataTable GetMessageStatus()
        {
                DataTable dataTable = new DataTable();
            try
            {
                
                    var parameters = new List<SqlParameter>
                    {

                    };
                    dataTable = (DataTable)DbConnection.ExecuteSps("[Config].[GetStatusName_Status_SP]", parameters, BaseClass.TypeDataTable);

              
            }
            catch (Exception ex)
            {
                Server.LogError(ex.ToString());
                return dataTable; // Or rethrow the exception if preferred
            }
            return dataTable;
        }

        public DataTable GetIVDReports( string fromDate, string toDate, string status)
        {
            DataTable IVDReport = new DataTable();
            try
            {
                var parameters = new List<SqlParameter>
                {
                new SqlParameter("@FromDate", fromDate),
                 new SqlParameter("@ToDate ", toDate),
                  new SqlParameter("@Status", status),

            };
                IVDReport = (DataTable)DbConnection.ExecuteSps("[Reports].[GetIVDREPORTS_SP]", parameters, BaseClass.TypeDataTable);

            }

            catch (Exception ex)
            {
                Server.LogError(ex.ToString());
              
            }
            return IVDReport;
        }
    }
}
