using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ThucTapCM.Models.Admin.EntitiesFW;

namespace ThucTapCM.Models.Admin.DAO
{
    public class BlogDAO
    {
        AutoShop_DbContext context = null;
        public BlogDAO()
        {
            context = new AutoShop_DbContext();
        }
        public List<SlideShow> ListAll()
        {
            return context.SlideShows.Where(x => x.Status == true).ToList();
        }
        public List<SlideShow> ListAllShow()
        {
            return context.SlideShows.ToList();
        }
        public IEnumerable<SlideShow> ListAllPage(int page, int PageSize)
        {
            return context.SlideShows.OrderBy(y => y.CreatedDay).ToPagedList(page, PageSize);
        }
        public SlideShow ViewDetail(int blogid)
        {
            return context.SlideShows.Find(blogid);
        }
    }
}