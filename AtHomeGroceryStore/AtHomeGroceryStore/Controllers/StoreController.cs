using AtHomeGroceryStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AtHomeGroceryStore.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Products()
        {
            ProductSearch search = new ProductSearch();
            return View(search);
        }

        [HttpPost]
        public ActionResult Products(ProductSearch search)
        {
            return View(search);
        }

        [HttpGet]
        public ActionResult FAQ()
        {
            return View();
        }

        [HttpGet]
        public new ActionResult Profile()
        {
            //TODO: Add profile login and profile info
            return View();
        }

        [HttpGet]
        public ActionResult ProductInfo()
        {
            //TODO: add db calls to fill in prodct
            Product p = new Product();
            return View(p);
        }

        [HttpPost]
        public ActionResult ProductInfo(Product p)
        {
            return View(p);
        }

        [HttpGet]
        public ActionResult Login()
        {
            Login login = new Login();
            return View(login);
        }

        [HttpPost]
        public ActionResult Login(Login login)
        {
            //TODO: Validate user login
            return View(login);
        }

        [HttpGet]
        public ActionResult AdminPanel()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AdminPanel(GenericResponse resp)
        {
            return View(resp);
        }
    }
}