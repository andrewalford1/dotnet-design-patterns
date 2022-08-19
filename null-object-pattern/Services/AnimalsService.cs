using models;
using System.Text;

namespace Services
{
    public class AnimalsService
    {
        private readonly DataService _dataService;

        public AnimalsService()
        {
            _dataService = new DataService();
        }

        public string GetInfo(string animalName)
        {
            Animal animal = _dataService.GetAnimal(animalName);

            if (animal == Animal.Null)
            {
                return new StringBuilder()
                    .Append($"We have no records for {animalName}.")
                    .Append("Impossible. Perhaps the archives are incomplete.")
                    .ToString();                
            }

            return animal.ToString();
        }
    }
}