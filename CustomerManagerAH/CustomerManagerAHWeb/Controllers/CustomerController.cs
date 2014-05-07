using Microsoft.SharePoint.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomerManagerAHWeb.Models;


namespace CustomerManagerAHWeb.Controllers {
  public class CustomerController : Controller {

    private CustomerDb _db;

    public CustomerController() {
      CustomerContextFactory factory = new CustomerContextFactory();
      _db = factory.Create();
    }

    [SharePointContextFilter]
    [HttpGet]
    public ActionResult Create() {
      var spContext = SharePointContextProvider.Current.GetSharePointContext(HttpContext);
      // get the current host url
      ViewBag.SPHostUrl = spContext.SPHostUrl;

      // create viewmodel & return
      var model = new CreateCustomerViewModel();
      return View(model);
    }

    [SharePointContextFilter]
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(CreateCustomerViewModel viewModel) {
      if (ModelState.IsValid) {
        var customer = new Customer();
        customer.FirstName = viewModel.FirstName;
        customer.LastName = viewModel.LastName;
        customer.Email = viewModel.Email;

        _db.Customers.Add(customer);
        _db.SaveChanges();

        return RedirectToAction("Index", "Home", new { SPHostUrl = SharePointContext.GetSPHostUrl(HttpContext.Request).AbsoluteUri });
      }
      return View(viewModel);
    }
  }
}