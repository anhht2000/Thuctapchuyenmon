using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using ThucTapCM.Areas.Admin.Code;
using ThucTapCM.Areas.Admin.Models;
using ThucTapCM.Models;
using ThucTapCM.Models.Admin.DAO;

namespace ThucTapCM.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }
        //public ActionResult Login(LoginModel lg)
        //{
        //    if(ModelState.IsValid) //kiem tra form da nhap chua theo require
        //    {
        //        var dao = new UserDAO();
        //        var result = dao.Login(lg.UserName, Md5.MD5Hash(lg.PassWord));
        //        if (result==1)
        //        {
        //            var user = dao.GetByID(lg.UserName);
        //            var userSession = new UserSession();
        //            userSession.UserName = user.UserName;
        //            userSession.ID = user.ID;

        //            Session.Add(UserSessionName.USER_SESSION,userSession);
        //            return RedirectToAction("Index", "Homett");
        //        }
        //        else if (result == -1)
        //        {
        //            ModelState.AddModelError("", "Mật khẩu không đúng");
        //        }
        //        else if (result == 0)
        //        {
        //            ModelState.AddModelError("", "Tài Khoản không tồn tại");
        //        }
        //        else
        //        {
        //            ModelState.AddModelError("", "Đăng nhập không đúng");
        //        }
        //    }
        //    return View("Index");
        //}
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Login");
        }
    }
}