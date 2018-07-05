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

        public Pets()
        {
            //_name = name;
            _pets.Add(this);
            _id = _pets.Count;
            _age = 0;
            _hunger = 50;
            _happiness = 50;
            _fatigue = 50;
            _alive = true;
        }

        //public Pets()
        //{
        //    _name = "Sam";
        //    _pets.Add(this);
        //    _id = _pets.Count;
        //    _age = 0;
        //    _hunger = 5;
        //    _happiness = 5;
        //    _fatigue = 5;
        //    _alive = true;
        //}

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public static Pets Find(int searchId)
        {
            return _pets[searchId - 1];
        }

        public int GetId()
        {
            return _id;
        }

        public int GetAge()
        {
            return _age;
        }

        public int GetHunger()
        {
            return _hunger;
        }

        public int GetHappiness()
        {
            return _happiness;
        }

        public int GetFatigue()
        {
            return _fatigue;
        }
               
        public bool GetStatus()
        {
            return _alive;
        }


        public static List<Pets> GetAll()
        {
           return _pets;
            //return false;
        }

        public static void ClearAll()
        {
            _pets.Clear();
        }

        public void Feed()
        {
            _hunger += 10;
            _fatigue -= 5;
            _happiness -= 5;
        }

        public void Sleep()
        {
            _fatigue += 10;
            _happiness -= 5;
            _hunger -= 5;
        }

        public void Play()
        {
            _happiness += 10;
            _fatigue -= 5;
            _hunger -= 5;
        }

        public void Time()
        {
            _age += 1;
            _happiness -= 20;
            _fatigue -= 20;
            _hunger -= 20;
        }
    }
}
