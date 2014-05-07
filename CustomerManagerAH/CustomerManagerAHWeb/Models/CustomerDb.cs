using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CustomerManagerAHWeb.Models {
  public class CustomerDb : DbContext{

    public CustomerDb() { }
    public CustomerDb(SqlConnection sqlConnection) : base(sqlConnection, false) { }
    public DbSet<Customer> Customers { get; set; }
  }
}