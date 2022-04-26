using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RaoVat.Models;

namespace RaoVat.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        DBRaoVatEntities db = new DBRaoVatEntities();
        // GET: Home
        public ActionResult Index()
        {
            var rv = db.RAOVATs.ToList();
            foreach (var item in rv)
            {
                if (DateTime.Now == item.NGAYHETHAN || DateTime.Now > item.NGAYHETHAN)
                {
                    db.RAOVATs.Remove(item);
                    db.SaveChanges();
                }
            }
            return View(db.RAOVATs.Include("User").OrderByDescending(x => x.NGAYGIODANG).Where(s => s.MATRANGTHAI == 1).Take(6).ToList());
        }
    }
}