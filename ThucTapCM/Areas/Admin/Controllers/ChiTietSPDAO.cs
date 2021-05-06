using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ThucTapCM.Models.Admin.EntitiesFW;

namespace ThucTapCM.Areas.Admin.Controllers
{
    public class ChiTietSPDAO
    {
        AutoShop_DbContext context = null;
        public ChiTietSPDAO()
        {
            context = new AutoShop_DbContext();
        }
        public List<ChiTietSP> ListAll()
        {
            return context.ChiTietSPs.ToList();
        }
    }
}