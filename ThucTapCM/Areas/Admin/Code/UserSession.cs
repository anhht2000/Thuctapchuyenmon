﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThucTapCM.Areas.Admin.Code
{
    [Serializable]
    public class UserSession
    {
        public string UserName { set; get; }
        public long ID { set; get;}
    }
}