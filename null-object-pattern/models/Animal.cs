namespace models
{
    public abstract record Animal(int NumberOfLegs, SpeciesType SpeciesType)
    {
        public static Animal Null => new NullAnimal();

        private record NullAnimal() : Animal(default, SpeciesType.Unknown);

        public override string ToString()
        {
            return $"{GetType().Name}'s are {SpeciesType.ToString().ToLower()} and have {NumberOfLegs} legs.";
        }
    }
}