﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ch24ShoppingCartMVC.Models;

namespace Ch24ShoppingCartMVC.Controllers {
    public class HomeController : Controller
    {
        [HttpGet]
        public ViewResult Index() {
            ViewBag.HeaderText = "Welcome to the Halloween Store";
            ViewData["FooterText"] = "Where every day is Halloween!";
            ViewBag.nextheader = "Thank you for visiting us this beautiful CURRENT DAY!";
            return View();
        }
        [HttpGet]
        public ViewResult Contact() {
            //CREATE A ContactViewModel OBJECT call model  model
            ____________________________________________________
            //Pass model to View
            _________________________________
        }
    }
}