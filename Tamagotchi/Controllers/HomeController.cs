using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;

namespace Tamagotchi.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Form()
        {
            return View();
        }

        [HttpPost("/pets")]
        public ActionResult AllPets(string petName)
        {
            Pets newPet = new Pets();
            newPet.SetName(petName);

            return View(Pets.GetAll());
            //return new EmptyResult();
        }

        [HttpGet("/pets/{id}")]
        public ActionResult SinglePet(int id)
        {
            Pets newPet = Pets.Find(id);
            return View(newPet);
            //return new EmptyResult();
        }
    }
}
