﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace SalesMVCApp.Gateway
{
    public class Gateway
    {
        private string connectionString =
         WebConfigurationManager.ConnectionStrings["ItemsDBConString"].ConnectionString;

        public string Query { get; set; }
        public SqlConnection Connection { get; set; }
        public SqlCommand Command { get; set; }
        public SqlDataReader Reader { get; set; }

        public Gateway()
        {
            Connection = new SqlConnection(connectionString);
        }
    }
}