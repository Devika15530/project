using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dmart.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dmart.Controllers
{
    public class SubCatController : Controller
    {
        private readonly SubCategoryContext _sbcontext;

        public SubCatController(SubCategoryContext bcontext)
        {
            _sbcontext = bcontext;
        }
        // GET: SubCat
        public ActionResult AddCategories()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategories(Subcategories uc)
        {
            try
            {
                _sbcontext.Add(uc);
                _sbcontext.SaveChanges();
                ViewBag.message = uc.CName+ "has successfully registered";
                return RedirectToAction("");

            }
            catch (Exception e)
            {
                ViewBag.message = uc.CName+ "Registration failed";
            }
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }

        // GET: SubCat/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SubCat/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SubCat/Create
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

        // GET: SubCat/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SubCat/Edit/5
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

        // GET: SubCat/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SubCat/Delete/5
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