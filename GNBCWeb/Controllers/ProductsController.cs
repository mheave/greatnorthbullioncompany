﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GNBCWeb.Controllers
{
    public class ProductsController : Controller
    {
        //
        // GET: /Product/

        public ActionResult Index()
        {
            return View();
        }

		public ActionResult Details(int productId)
		{
			return View("Details");
		}
			
    }
}