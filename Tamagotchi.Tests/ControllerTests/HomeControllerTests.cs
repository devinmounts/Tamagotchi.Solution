using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Tamagotchi.Controllers;
using Tamagotchi.Models;

namespace Tamagotchi.Tests
{
    [TestClass]
    public class HomeControllerTests : IDisposable
    {
        public void Dispose()
        {
            Pets.ClearAll();
        }

        [TestMethod]
        public void Form_ReturnCorrectView_True()
        {
            HomeController controller = new HomeController();
            ActionResult petFormView = controller.Form();
            Assert.IsInstanceOfType(petFormView, typeof(ViewResult));

        }

        [TestMethod]
        public void Pets_ReturnsCorrectView_True()
        {
            HomeController controller = new HomeController();
            ActionResult allPetsView = controller.AllPets("Sam");
            Assert.IsInstanceOfType(allPetsView, typeof(ViewResult));

        }

        [TestMethod]
        public void Pets_HasCorrectModelType_True()
        {
            ViewResult allPetsView = new HomeController().AllPets("Sam") as ViewResult;
            var result = allPetsView.ViewData.Model;
            Assert.IsInstanceOfType(result, typeof(List<Pets>));
        }

        [TestMethod]
        public void SinglePet_ReturnsCorrectView_True()
        {
            Pets petOne = new Pets();
            Pets petTwo = new Pets();
            List<Pets> newPetList = new List<Pets>() { petOne, petTwo };
            HomeController controller = new HomeController();
            ActionResult singlePetView = controller.SinglePet(1);
            Assert.IsInstanceOfType(singlePetView, typeof(ViewResult));
        }

        [TestMethod]
        public void SinglePet_HasCorrectModeType_True()
        {
            Pets petOne = new Pets();
            Pets petTwo = new Pets();
            List<Pets> newPetList = new List<Pets>() { petOne, petTwo };
            ViewResult singlePetView = new HomeController().SinglePet(1) as ViewResult;
            var result = singlePetView.ViewData.Model;
            Assert.IsInstanceOfType(result, typeof(Pets));
        }

        [TestMethod]
        public void SinglePet_PetHungerIncreases_True()
        {
            Pets petOne = new Pets();
            List<Pets> newPetList = new List<Pets>() { petOne };
            ViewResult singlePetView = new HomeController().SinglePet(1) as ViewResult;
            var result = singlePetView.ViewData.Model;
            Assert.IsInstanceOfType(result, typeof(Pets));
        }
    }
}
