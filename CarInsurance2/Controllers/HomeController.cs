using CarInsurance2.Models;
using CarInsurance2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Admin()
        {
            using (InsuranceEntities ins = new InsuranceEntities())
            {
                var insurees = ins.Insurees;
                var insureeVms = new List<InsureeVm>();
                foreach (var user in insurees)
                {
                    var newIns = new InsureeVm();
                    newIns.FirstName = user.FirstName;
                    newIns.LastName = user.LastName;
                    newIns.EmailAddress = user.EmailAddress;
                    newIns.Quote = user.Quote;

                    insureeVms.Add(newIns);
                }

                return View(insureeVms);

            }
        }
    }
}