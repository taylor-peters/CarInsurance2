using CarInsurance2.Models;
using CarInsurance2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance2.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
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