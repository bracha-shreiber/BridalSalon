﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bridal_salon.Controllers
{
    public class BrideController : Controller
    {
        // GET: BrideController
        public ActionResult Index()
        {
            return View();
        }

        // GET: BrideController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BrideController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BrideController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BrideController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BrideController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BrideController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BrideController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}