using System;
using System.Collections.Generic;

namespace Tamagotchi.Models
{
    public class Pets
    {
        private string _name;
        private int _id;
        private static int _age;
        private int _hunger;
        private int _happiness;
        private int _fatigue;
        private bool _alive;
        private static List<Pets> _pets = new List<Pets> { };

        public Pets(string name)
        {
            _name = name;
            _pets.Add(this);
            _id = _pets.Count;
            _age = 0;
            _hunger = 5;
            _happiness = 5;
            _fatigue = 5;
            _alive = true;
        }

        public Pets()
        {
            _name = "Sam";
            _pets.Add(this);
            _id = _pets.Count;
            _age = 0;
            _hunger = 5;
            _happiness = 5;
            _fatigue = 5;
            _alive = true;
        }



        public string GetName()
        {
            return _name;
        }

        //public void SetName(string newName)
        //{
        //    _name = newName;
        //}

        public static Pets Find(int searchId)
        {
            return _pets[searchId -1];
        }

        //public void SetId(List<Pets> allPets)
        //{
        //    _id = allPets.Count - 1;
        //}

        public int GetAge()
        {
            return _age;
        }

        //public void SetAge(int petAge)
        //{
        //    _age = petAge;
        //}

        public int GetHunger()
        {
            return _hunger;
        }

        //public void SetHunger(int hunger)
        //{
        //    _hunger = hunger;
        //}

        public int GetHappiness()
        {
            return _happiness;
        }

        //public void SetHappiness(int happiness)
        //{
        //    _happiness = happiness;
        //}

        public int GetFatigue()
        {
            return _fatigue;
        }

        //public void SetFatigue(int fatigue)
        //{
        //    _fatigue = fatigue;
        //}
               
        public bool GetStatus()
        {
            return _alive;
        }

        //public void SetStatus(string status)
        //{
        //    _alive = status;
        //}
       

        public static List<Pets> GetAll()
        {
           return _pets;
            //return false;
        }

        //public void AddPet()
        //{
        //    _pets.Add(this);
        //}
        public static void ClearAll()
        {
            _pets.Clear();
        }
    }
}
