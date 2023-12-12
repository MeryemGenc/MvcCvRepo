﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;
using MvcCv.Models.Sinif;

namespace MvcCv.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        DbMvcCvEntities db = new DbMvcCvEntities();
        public ActionResult Index()
        {

            Class1 cs = new Class1();
            cs.deger1 = db.TBLABOUT.ToList();
            cs.deger2 = db.TBLEXPERIENCE.ToList();
            cs.deger3 = db.TBLEDUCATION.ToList();
            cs.deger4 = db.TBLSKILLS.ToList();
            cs.deger5 = db.TBLINTERESTS.ToList();
            cs.deger6 = db.TBLAWARDS.ToList();

            return View(cs);

            //var degerler = db.TBLABOUT.ToList();
            //return View(degerler);
        }
    }
}