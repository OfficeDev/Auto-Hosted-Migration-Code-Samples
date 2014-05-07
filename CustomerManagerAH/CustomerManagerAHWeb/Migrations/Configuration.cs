using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using CustomerManagerAHWeb.Models;

namespace CustomerManagerAHWeb.Migrations {

  internal sealed class Configuration : DbMigrationsConfiguration<CustomerManagerAHWeb.Models.CustomerDb> {
    public Configuration() {
      AutomaticMigrationsEnabled = true;
    }

    protected override void Seed(CustomerManagerAHWeb.Models.CustomerDb context) {
    }
  }
}
