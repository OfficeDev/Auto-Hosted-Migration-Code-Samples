using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace CustomerManagerAHWeb.Models {
  public class CustomerContextFactory : IDbContextFactory<CustomerDb>{
    public CustomerDb Create() {      
      // get connection string form autohosted DB
      string connectionString = WebConfigurationManager.AppSettings["SqlAzureConnectionString"];

      // create db connection
      SqlConnection sqlConnection = new SqlConnection(connectionString);

      return new CustomerDb(sqlConnection);
    }
  }
}