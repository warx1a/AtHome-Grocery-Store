using AtHomeGroceryStore.Models;
using AtHomeGroceryStore.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AtHomeGroceryStore.Controllers
{
    public class StoreController : Controller
    {

        private ProductDB _productDB;
        private ProductDB productDB
        {
            get
            {
                if(_productDB == null)
                {
                    _productDB = new ProductDB();
                }
                return _productDB;
            }
        }

        private List<int> filteredCategories
        {
            get
            {
                return (List<int>)Session["filteredCategories"];
            }
            set
            {
                Session["filteredCategories"] = value;
            }
        }



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
            filteredCategories = new List<int>();
            search.filterCats = new List<int>();
            return View(search);
        }

        [HttpPost]
        public ActionResult Products(ProductSearch search)
        {
            if(search.infoCode != null)
            {
                ProductInfo p = productDB.getProductInfoById(search.infoCode ?? 0);
                return View("ProductInfo", p);
            } else
            {
                if(search.filterOperation.Equals("add"))
                {
                    filteredCategories.Add(search.filterCategory);
                } else if(search.filterOperation.Equals("remove"))
                {
                    filteredCategories.Remove(search.filterCategory);
                }
                search.filterCats = filteredCategories;
                search.filteredProducts = productDB.searchProducts(search);
                return View(search);
            }
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