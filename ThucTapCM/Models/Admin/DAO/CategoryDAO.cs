using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ThucTapCM.Models.Admin.EntitiesFW;

namespace ThucTapCM.Models.Admin.DAO
{
    public class CategoryDAO
    {
        private AutoShop_DbContext context = null;
        public CategoryDAO()
        {
            context = new AutoShop_DbContext();
        }
        public List<ChiTietSP> SelectAll()
        {
            //su dung cu phap LINQ cho phep viet cau lenh truy van
            //dang chaining method
            return context.ChiTietSPs.ToList();
        }
        //public IEnumerable<ChiTietSP> ListAll(string searchString, int page, int pageSize)
        //{
        //    IQueryable<ChiTietSP> x = context.ChiTietSPs;
        //    if (!string.IsNullOrEmpty(searchString))
        //    {
        //        x = x.Where(y => y.ChungLoai.Contains(searchString));
        //    }
        //    //context.Database.SqlQuery<Category>("Sp_Category_ListAll"); Lay tu proceduce ra se nhu tn
        //    var list = x.OrderByDescending(y => y.NamSanXuat).ToPagedList(page, pageSize);
        //    return list;
        //}
        public long Insert(ChiTietSP lh)
        {
            context.ChiTietSPs.Add(lh);
            context.SaveChanges();
            return lh.MaCTSP;
        }
    }
}