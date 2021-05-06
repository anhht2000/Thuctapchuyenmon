using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ThucTapCM.Models.Admin.EntitiesFW;

namespace ThucTapCM.Models.Admin.DAO
{
    public class SanPhamDAO
    {
        AutoShop_DbContext context = null;
        public SanPhamDAO()
        {
            context = new AutoShop_DbContext();
        }
        public List<SanPham> ListAll()
        {
            return context.SanPhams.Where(x => x.TrangThai == true).OrderBy(y => y.DonGia).ToList();
        }
        public IEnumerable<SanPham> ListAllPage(int page,int PageSize)
        {
            return context.SanPhams.Where(x => x.TrangThai == true).OrderBy(y => y.DonGia).ToPagedList(page, PageSize);
        }
        public SanPham ViewDetail(int id)
        {
            return context.SanPhams.Find(id);
        }
    }
}