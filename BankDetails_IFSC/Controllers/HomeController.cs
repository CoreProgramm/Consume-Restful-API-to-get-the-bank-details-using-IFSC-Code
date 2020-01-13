using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankDetails_IFSC.Models;

namespace BankDetails_IFSC.Controllers
{
   
    public class HomeController : Controller
    {
        IBankRepository _bankrepository;
        public HomeController(IBankRepository bankRepository)
        {
            ViewBag.IFSC = null;
            _bankrepository = bankRepository;
        }
        public IActionResult Index()
        {
         
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(string IFSC)
        {
            BankDetails bankdetails = _bankrepository.GetBankDetails(IFSC);
            ViewBag.IFSC = IFSC;
            return View(bankdetails); 
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Privacy123()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
