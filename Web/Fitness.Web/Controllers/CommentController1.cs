﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitness.Web.Controllers
{
    public class CommentController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}