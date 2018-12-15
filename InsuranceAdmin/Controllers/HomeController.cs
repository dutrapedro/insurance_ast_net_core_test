using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InsuranceAdmin.Models;
using NpgsqlTypes;

namespace InsuranceAdmin.Controllers
{
    public class HomeController : Controller
    {
        private readonly InsuranceContext _context;

        public HomeController(InsuranceContext context)
        {
            _context = context;
        }

        public string Index()
        {
            var insurance = new Insurance("Seguro blah", 2, "1234334", "Alberto Noronha");
            _context.insurances.Add(insurance);
            _context.SaveChanges();

            int insurance_id = _context.insurances.Where(i => i.Id > 0).First().Id;

            var life = new HouseInsurance("Rua abc", 5, "RS", "Brazil", insurance_id);
            _context.house_insurances.Add(life);
            _context.SaveChanges();

            return "Huehuebr lIFE " + _context.house_insurances.Count() + " --- iNSU: " + _context.insurances.Count();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
