using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using spice.Data;

namespace spice.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoriseController : Controller
    {
        private readonly ApplicationDbContext db;
        private ModelStateDictionary isvalid;

        public CategoriseController(ApplicationDbContext db)
        {
            this.db = db;
        }
       [HttpGet]
        public async Task <IActionResult> CategoryView()
        {
            return View(await db.categories.ToListAsync());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        //[HttpGet]
        //[ValidateAntiForgeryToken]

        //public async Task<IActionResult> create( category category)
        //{
        //    if (ModelState == isvalid)
        //    {
        //        db.categories.Add("");
        //        await db.SaveChangesAsync();
        //        return RedirectToAction("CategoryView");
        //    }
        //    return View(category);
        //}


    }
}
