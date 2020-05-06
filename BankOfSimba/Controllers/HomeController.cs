using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankOfSimba.Models;
using Microsoft.AspNetCore.Mvc;

namespace BankOfSimba.Controllers
{
    public class HomeController : Controller
    {
        public static List<BankAccount> bankAccounts = BankAccount.InitializeList();

        [HttpGet("show")]
        public IActionResult Index()
        {
            return View(bankAccounts);
        }
        [HttpPost]
        public IActionResult RaiseBalance()
        {
            foreach (var item in bankAccounts)
            {
                if(item.IsKing)
                {
                    item.Balance += 100;
                }
                else
                {
                    item.Balance += 10;
                }
            }
            return View("index",bankAccounts);
        }
        [HttpPost]
        public IActionResult AddNewAccount(string name, decimal balance, string animalType, bool isKing, bool isGood)
        {
            var bankAccounts = new List<BankAccount>();
            bankAccounts.Add(new BankAccount(name, balance, animalType, isKing, isGood));
            return View("index", bankAccounts);
        }

        [HttpGet("showText")]
        public IActionResult ShowText()
        {
            ViewBag.message = "This is an <em>HTML</em> text. <b>Enjoy yourself!</b>";            
            return View();
        }
    }
}
