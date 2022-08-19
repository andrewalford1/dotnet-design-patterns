using models;

namespace Services
{
    public class DataService
    {
        private static readonly Dictionary<string, Animal> Animals = new()
        {
            [nameof(Cat)] = new Cat(),
            [nameof(Chicken)] = new Chicken(),
            [nameof(Cow)] = new Cow(),
            [nameof(Dog)] = new Dog(),
            [nameof(Eagle)] = new Eagle(),
            [nameof(Frog)] = new Frog(),
            [nameof(Lizard)] = new Lizard(),
            [nameof(Snake)] = new Snake()
        };

        public Animal GetAnimal(string name)
        {
            Animals.TryGetValue(name, out Animal? animal);
            return animal ?? Animal.Null;
        }
    }
}
