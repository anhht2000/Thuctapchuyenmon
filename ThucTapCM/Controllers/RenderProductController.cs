using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThucTapCM.Models.Admin.DAO;

namespace ThucTapCM.Controllers
{
    public class RenderProductController : Controller
    {
        //GET: RenderProduct
        public ActionResult LoadDetails(int id)
        {
            var sanpham = new SanPhamDAO().ViewDetail(id);
            return View(sanpham);
        }
        public ActionResult LoadBlog(int blogid)
        {
            var blog = new BlogDAO().ViewDetail(blogid);
            return View(blog);
        }
    }
}