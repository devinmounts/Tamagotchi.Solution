using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Tamagotchi.Controllers
{
    public class TamagotchisController : Controller
    {
        [HttpGet("/pets")]
        public ActionResult AllPets()
        {
            return View();
        }
    }
}