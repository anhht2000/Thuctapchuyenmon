using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ThucTapCM.Models.Admin.EntitiesFW;

namespace ThucTapCM.Models.Admin.DAO
{
    //public class UserDAO
    //{
    //    private AutoShop_DbContext context = null;
    //    public UserDAO()
    //    {
    //        context = new AutoShop_DbContext();
    //    }
    //    public long Insert(tblAccount lh)
    //    {
    //        context.tblAccounts.Add(lh);
    //        context.SaveChanges();
    //        return lh.ID;
    //    }
    //    public tblAccount GetByID(string USN)
    //    {
    //        return context.tblAccounts.SingleOrDefault(x => x.UserName == USN);
    //    }
    //    public int Login(string userName, string Password)
    //    {
    //        var result = context.tblAccounts.SingleOrDefault(x => x.UserName == userName);
    //        if (result == null)
    //        {
    //            return 0;
    //        }
    //        else
    //        {
    //            if (result.PassWord == Password) return 1;
    //            else return -1;
    //        }
    //    }
    //}
}