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

        [HttpGet("/pets")]
        public ActionResult AllPets()
        {
            return View(Pets.GetAll());
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

        [HttpPost("/pets/{id}/feed-pet")]
        public ActionResult FeedPet(int id)
        {
            Pets selectedPet = Pets.Find(id);
            selectedPet.Feed();
            return View(selectedPet);
        }

        [HttpPost("/pets/{id}/play-pet")]
        public ActionResult PlayPet(int id)
        {
            Pets selectedPet = Pets.Find(id);
            selectedPet.Play();
            return View(selectedPet);
        }

        [HttpPost("/pets/{id}/sleep-pet")]
        public ActionResult SleepPet(int id)
        {
            Pets selectedPet = Pets.Find(id);
            selectedPet.Sleep();
            return View(selectedPet);
        }
    }
}
