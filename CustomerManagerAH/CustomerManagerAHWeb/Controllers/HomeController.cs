using Microsoft.SharePoint.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomerManagerAHWeb.Models;

namespace CustomerManagerAHWeb.Controllers {
  public class HomeController : Controller {
    private CustomerDb _db;

    public HomeController() {
      CustomerContextFactory factory = new CustomerContextFactory();
      _db = factory.Create();
    }

    [SharePointContextFilter]
    public ActionResult Index() {
      var spContext = SharePointContextProvider.Current.GetSharePointContext(HttpContext);
      // get the current host url
      ViewBag.SPHostUrl = spContext.SPHostUrl;

      var allCustomers = _db.Customers;
      return View(allCustomers);
    }

    public ActionResult About() {
      var spContext = SharePointContextProvider.Current.GetSharePointContext(HttpContext);
      // get the current host url
      ViewBag.SPHostUrl = spContext.SPHostUrl;

      ViewBag.Message = "Your application description page.";
      return View();
    }

    public ActionResult Contact() {
      var spContext = SharePointContextProvider.Current.GetSharePointContext(HttpContext);
      // get the current host url
      ViewBag.SPHostUrl = spContext.SPHostUrl;

      ViewBag.Message = "Your contact page.";
      return View();
    }
  }
}
