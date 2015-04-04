namespace AcademyEcosystem
{
    public class Wolf : Animal, ICarnivore
    {
        private const int DefaultWolfSize = 4;

        public Wolf(string name, Point location)
            : base(name, location, DefaultWolfSize)
        {
        }

        public int TryEatAnimal(Animal animal)
        {
            int meatEaten = 0;
            if (animal != null && (animal.Size <= this.Size ||
                animal.State == AnimalState.Sleeping))
            {
                meatEaten = animal.GetMeatFromKillQuantity();
            }

            return meatEaten;
        }
    }
}
