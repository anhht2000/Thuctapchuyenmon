using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThucTapCM.Models.Admin.DAO;

namespace ThucTapCM.Controllers
{
    public class CarController : Controller
    {
        // GET: Car
        public ActionResult Index(int page =1,int PageSize =2)
        {
            var sanpham = new SanPhamDAO().ListAllPage(page,PageSize);
            return View(sanpham);
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Team()
        {
            return View();
        }
        public ActionResult Blog()
        {
            var blog = new BlogDAO().ListAllShow();
            return View(blog);
        }
    }
}