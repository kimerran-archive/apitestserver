using KmrApiTestServ.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KmrApiTestServ.Data
{
    public class UserCollection : List<User>
    {
        public UserCollection()
        {
            this.Add(new User { Id = 1, Fullname = "Bed Sheet", Username = "bed", Password = "sheet" });
            this.Add(new User { Id = 2, Fullname = "Pillow Case", Username = "pillow", Password = "case" });
            this.Add(new User { Id = 3, Fullname = "Lamp Shade", Username = "lamp", Password = "shade" });
        }
    }
}