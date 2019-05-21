using Microsoft.AspNetCore.Mvc;
using System;
using TimeDisplay;
using System.Globalization;
using System.Threading.Tasks;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;

namespace TimeDisplay
{
    public class TimeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            DateTime CurrentTime = DateTime.Now;
            ViewBag.Time = CurrentTime;
            return View();
        }
    }

}