         using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dmart.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dmart.Controllers
{
    public class SellerController : Controller
    {
        // GET: Seller


        private readonly SellerContext _scontext;

        public SellerController(SellerContext context)
        {
            _scontext = context;
        }

        [HttpGet]
         public ActionResult RegisterSeller()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RegisterSeller(Seller uc)
        {
            try
            {
                _scontext.Add(uc);
                _scontext.SaveChanges();
                ViewBag.message = uc.Name+ "has successfully registered";
                return RedirectToAction("");

            }
            catch (Exception e)
            {
                ViewBag.message = uc.Name + "Registration failed";
            }
            return View();
        }



        [HttpGet]
        public ActionResult SellerLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SellerLogin(Seller uc)
        {
            var loguser = _scontext.SellerAccounts.Where(e => e.Name== uc.Name && e.Password == uc.Password).ToList();
            if (loguser.Count == 0)
            {
                ViewBag.message = "Not a valid user";
                return View();

            }
            else
            {
                ////to store session values
                //HttpContext.Session.SetString("name", uc.name);
                ////Response.Cookies.Append("lastlogin", DateTime.Now.ToString());
                ////HttpContext.Session.SetString("LastLogin", DateTime.Now.ToString());
                return RedirectToAction("SDashBoard");
            }
        }

        public ActionResult SDashBoard()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddCategories(Categories c)
        {
            return View();

        }


        //public ActionResult AddItems(ItemBo b)
        //{
          
        //    return View();

        //}

     



        public ActionResult Index()
        {
            return View();
        }

        // GET: Seller/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Seller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Seller/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Seller/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Seller/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Seller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Seller/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}