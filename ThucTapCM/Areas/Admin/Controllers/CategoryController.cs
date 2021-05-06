using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThucTapCM.Models.Admin;
using ThucTapCM.Models.Admin.DAO;
using ThucTapCM.Models.Admin.EntitiesFW;

namespace ThucTapCM.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        //private AutoShop_DbContext db = new AutoShop_DbContext();
        //// GET: Admin/Category
        //public ActionResult Index(string searchString,int page=1,int PageSize=2)
        //{
        //    var iplCate = new CategoryDAO();
        //    var model = iplCate.ListAll(searchString, page,PageSize);
        //    ViewBag.StringSearch = searchString;
        //    return View(model);
        //}

        //// GET: Admin/Category/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: Admin/Category/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Admin/Category/Create
        //[HttpPost]
        //public ActionResult Create(Category category)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        // TODO: Add insert logic here
        //        db.Categories.Add(category);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(category);
            
        //}

        //// GET: Admin/Category/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Admin/Category/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here
                
        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Admin/Category/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Admin/Category/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
