using System.Collections.Generic;

namespace LessonFormsCSharp
{
    internal class Country
    {
        public Country() 
        {
            name_ = new string("");
            cities_ = new List<City>();
        }
        public Country(string name, string patch)
        {
            name_ = new string(name);
            patch_ = new string(patch);
            cities_ = new List<City>();
        }

        public void AddCity(params string[] cities)
        {
            string[] sCity;
            foreach (var city in cities)
            {
                sCity = city.Split(" ");
                city_ = new City(sCity[0], int.Parse(sCity[1]));
                cities_.Add(city_);
            }
        }
        public void DeleteCity(City city)
        {
            if (cities_.Contains(city))
            {
                cities_.Remove(city);
            }
        }
        public string GetName()
        {
            return name_;
        }
        public City GetCity(int indx)
        {
            return cities_[indx];
        }
        public string GetPatch()
        {
            return patch_;
        }
        public int countCities()
        {
            return cities_.Count;
        }

        private string name_;
        private string patch_;
        private City city_;
        private List<City> cities_;
    }
}
