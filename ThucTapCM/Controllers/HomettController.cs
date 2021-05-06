using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThucTapCM.Areas.Admin.Controllers;
using ThucTapCM.Models.Admin.DAO;

namespace ThucTapCM.Controllers
{
    public class HomettController : Controller
    {
        // GET: Homett
        public ActionResult Index()
        {
            //var x = new SanPhamDAO().ListAll();
            //var y = new ChiTietSPDAO().ListAll();
            //var inner = x.Join(y, a => a.MaCTSP, b => b.MaCTSP, (a, b) => new
            //{
            //    ProName = a.TenSP,
            //    LastPrice =a.DonGiaCu,
            //    NewPrice =a.DonGia,
            //    Image = a.HinhAnh,
            //});
            ViewBag.listPd = new SanPhamDAO().ListAll();
            ViewBag.listBlog = new BlogDAO().ListAll();
            return View();
        }
        //[ChildActionOnly]
        //public ActionResult MainMenu()
        //{
        //    var model = new MenuDAO().ListAll(1);
        //    return PartialView(model);
        //}
        //public ActionResult Productions()
        //{
        //    return View();
        //}
    }
}