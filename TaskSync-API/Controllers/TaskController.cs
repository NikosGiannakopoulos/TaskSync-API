﻿using Microsoft.AspNetCore.Mvc;

namespace TaskSync_API.Controllers
{
    public class TaskController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}