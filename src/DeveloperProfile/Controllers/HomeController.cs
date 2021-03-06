﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DeveloperProfile.Models;
using static DeveloperProfile.Models.GitClass;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace DeveloperProfile.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Portfolio()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GitHubGetHub()
        { 
            GitReuslt GitApi = new Models.GitReuslt();
            RootObject[] newcall = GitApi.GitCall();    
            return Json(newcall);
        }
        
    }
}
