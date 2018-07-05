using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Tamagotchi.Models;

namespace Tamagotchi.Tests
{
    [TestClass]
    public class PetsTests : IDisposable
    {
        public void Dispose()
        {
            Pets.ClearAll();
        }

        [TestMethod]
        public void SetGetName_SetsGetsName_String()
        {
            Pets newPet = new Pets();

            Assert.AreEqual("Sam", newPet.GetName());

        }

        //[TestMethod]
        //public void SetGetId_SetsGetsId_Int()
        //{
        //    Pets newPet = new Pets();
        //    newPet.SetId(1);
        //    Assert.AreEqual(true, newPet.GetId());

        //}

        //[TestMethod]
        //public void SetGetName_SetsGetsName_String()
        //{
            //Pets newPet = new Pets();
            //newPet.SetName("Sam");
            //Assert.AreEqual("Sam", newPet.GetName());

        //}

        [TestMethod]
        public void SetGetAge_SetsGetsAge_Int()
        {
            Pets newPet = new Pets();

            Assert.AreEqual(0, newPet.GetAge());

        }

        [TestMethod]
        public void SetGetHunger_SetsGetsHunger_Int()
        {
            Pets newPet = new Pets();

            Assert.AreEqual(5, newPet.GetHunger());

        }

        [TestMethod]
        public void SetGetHappiness_SetsGetsHappines_Int()
        {
            Pets newPet = new Pets();
           
            Assert.AreEqual(5, newPet.GetHunger());
        }

        [TestMethod]
        public void SetGetFatigue_SetsGetsFatigue_Int()
        {
            Pets newPet = new Pets();
         
            Assert.AreEqual(5, newPet.GetFatigue());
        }
        
        [TestMethod]
        public void SetGetStatus_SetsGetsStatus_String()
        {
            Pets newPet = new Pets();

            Assert.AreEqual(true, newPet.GetStatus());
        }

        [TestMethod]
        public void AddGetPets_AddGetList_List()
        {
            Pets newPet = new Pets();

            Pets newPet02 = new Pets();

            List<Pets> compare = new List<Pets>() { newPet, newPet02 };
            CollectionAssert.AreEqual(compare, Pets.GetAll());
        }

        [TestMethod]
        public void SetGetId_SetsGetsId_int()
        {
            Pets newPet = new Pets();

            Pets newPet02 = new Pets();

            List<Pets> compare = new List<Pets>() { newPet, newPet02 };

            Assert.AreEqual(newPet, Pets.Find(1));

        }

    }
}
