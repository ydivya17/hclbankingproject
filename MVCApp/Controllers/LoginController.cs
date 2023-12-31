﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCRepository;

namespace MVCApp.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            LoginRepository lrepo = new LoginRepository();
            string[] str = lrepo.checkLogin(username, password);
            str[1] = str[1].Trim();


            if (str[1] == "User")
            {
                return RedirectToAction("Home", "User", lrepo.bringUser(str[0]));
            }
            else if (str[1].Trim()=="Admin")
            {
                return RedirectToAction("Home", "Admin", lrepo.bringAdmin(str[0]));
            }
            else if (str[1] == "MD")
            {
                return RedirectToAction("Home", "MD", lrepo.bringMD(str[0]));
            }
            else if (str[1] == "HROfficer")
            {
                return RedirectToAction("Home", "HROfficer", lrepo.bringHROfficer(str[0]));
            }
            else if (str[1] == "TOfficer")
            {
                return RedirectToAction("Home", "TOfficer", lrepo.bringTOfficer(str[0]));
            }
            else if (str[1] == "LOfficer")
            {
                return RedirectToAction("Home", "LOfficer", lrepo.bringLOfficer(str[0]));
            }
            else if (str[1] == "Manager")
            {
                return RedirectToAction("Home", "Manager", lrepo.bringManager(str[0]));
            }
            else if (str[1] == "Cashier")
            {
                return RedirectToAction("Home", "Cashier", lrepo.bringCashier(str[0]));
            }
            else if (str[1] == "Officer")
            {
                return RedirectToAction("Home", "Officer", lrepo.bringOfficer(str[0]));
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }
    }
}