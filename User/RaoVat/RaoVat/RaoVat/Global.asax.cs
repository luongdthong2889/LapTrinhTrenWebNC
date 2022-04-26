using RaoVat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace RaoVat
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            DBRaoVatEntities db = new DBRaoVatEntities();
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            var rv = db.RAOVATs.ToList();
            foreach (var item in rv)
            {
                if (DateTime.Now == item.NGAYHETHAN || DateTime.Now > item.NGAYHETHAN)
                {
                    db.RAOVATs.Remove(item);
                    db.SaveChanges();
                }
            }
        }
    }
}
