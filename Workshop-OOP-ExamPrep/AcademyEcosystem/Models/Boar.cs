namespace AcademyEcosystem
{
    public class Boar : Animal, ICarnivore, IHerbivore
    {
        private int biteSize;

        public Boar(string name, Point location)
            : base(name, location, 4)
        {
            this.biteSize = 2;
        }

        public int TryEatAnimal(Animal animal)
        {
            int meatEaten = 0;
            if (animal != null && animal.Size <= base.Size)
            {
                meatEaten = animal.GetMeatFromKillQuantity();
            }

            return meatEaten;
        }

        public int EatPlant(Plant plant)
        {
            int quantityEaten = 0;
            if (plant != null)
            {
                quantityEaten = plant.GetEatenQuantity(this.biteSize);
                base.Size++;
            }

            return quantityEaten;
        }
    }
}
