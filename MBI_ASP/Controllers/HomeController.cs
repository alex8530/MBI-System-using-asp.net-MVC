using MBI_ASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MBI_ASP.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext contextDatabase = ApplicationDbContext.Create();
        public ActionResult ViewMBIList()
        {
            var list = contextDatabase.entries.ToList();
            return View(list);
        }



        public ActionResult AddMBI()
        {
            return View();
        }


        [HttpPost]
        public ActionResult AddMBI(Entry entry)
        {
            var _mbi_ = getMBI(entry.Weight, entry.Height);
            var ent = new Entry()
            {
                Weight=entry.Weight,
                Height=entry.Height,
                Gender=entry.Gender,
                MBI= _mbi_,
                Classification= getClassificationFromMBI(_mbi_)
            };

           
            contextDatabase.entries.Add(ent);
            contextDatabase.SaveChanges();

            return RedirectToAction("ViewMBIList" );
        }

        public double getMBI (double w , double h)
        {
            double mbi = (w) / (h * h);
                 
            return mbi;
        }



        public string getClassificationFromMBI( double mbi)
        {
            string result = "";

            string Normal = "Normal";
            string Under = "Under";
            string Obacity= "Obacity";

            if(mbi>18.5 && mbi < 24.9)
            {
                result = Normal;
            }else if(mbi < 18.5)
            {
                result = Under;
            }
            else
            {
                result = Obacity;
            }


            return result;
        }
    }

     
}