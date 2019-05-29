using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace fshop.Controllers
{
    public class otherController : Controller
    {
        public IActionResult home()
        {

            return View();
        }
    }
}