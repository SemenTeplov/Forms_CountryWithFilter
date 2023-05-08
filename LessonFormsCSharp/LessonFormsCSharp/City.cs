namespace LessonFormsCSharp
{
    internal class City
    {
        public City() 
        {
            nameCity_ = new string("");
            population_ = 0;
        }
        public City(string nameCity) 
        {
            nameCity_ = new string(nameCity);
            population_ = 0;
        }
        public City(string nameCity, int population) 
        {
            nameCity_ = new string(nameCity);
            population_ = population;
        }

        public string GetNameCity() 
        {
            return nameCity_;
        }
        public int GetPopulation() 
        { 
            return population_; 
        }

        private string nameCity_;
        private int population_;
    }
}
