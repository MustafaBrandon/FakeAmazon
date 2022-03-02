using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheAmazon.Models;

namespace TheAmazon.Controllers
{
    public class PurchaseController : Controller
    {
        private IPurchasheRepository repo { get; set; }
        private Basket basket { get; set; }

        public PurchaseController(IPurchasheRepository temp, Basket b)
        {
            repo = temp;
            basket = b;
        }

        [HttpGet]
        public IActionResult Checkout()
        {
            return View(new Purchase());
        }

        [HttpPost]
        public IActionResult Checkout(Purchase purchase)
        {
            if (basket.Items.Count() == 0)
            {
                ModelState.AddModelError("", "Sorry your cart is empty!");
            }
            if (ModelState.IsValid)
            {
                purchase.Lines = basket.Items.ToArray();
                repo.SavePurchase(purchase);
                basket.ClearBasket();
                return RedirectToPage("/Confirmation");
            }
            else
            {
                return View();
            }

        }
    }
}
