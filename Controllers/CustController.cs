using Code_FIrst.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code_FIrst.Controllers
{
    public class CustController : Controller
    {
        private readonly CusDbContext _db;
        public CustController(CusDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<CustClass> displaydata = _db.custb.ToList();
            return View(displaydata);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> Create(CustClass uc)

        {
            if (!ModelState.IsValid)
            {
                return View(uc);
            }
            _db.Add(uc);
            await _db.SaveChangesAsync();
            ViewBag.message = "The Customer " + uc.Username + " Is saved Successfully..";
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var getcusdetails = await _db.custb.FindAsync(id);
            return View(getcusdetails);
        }


        [HttpPost]

        public async Task<IActionResult> Edit(CustClass uc)

        {
            if (ModelState.IsValid)
            {
                _db.Update(uc);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(uc);
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var getcusdetails = await _db.custb.FindAsync(id);
            return View(getcusdetails);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var getcusdetails = await _db.custb.FindAsync(id);
            return View(getcusdetails);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var getcusdetails = await _db.custb.FindAsync(id);
            _db.custb.Remove(getcusdetails);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
