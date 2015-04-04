namespace AcademyEcosystem
{
    public class Lion : Animal, ICarnivore
    {
        public Lion(string name, Point location)
            : base(name, location, 6)
        {
        }

        public int TryEatAnimal(Animal animal)
        {
            int meatEaten = 0;
            if (animal != null && animal.Size <= this.Size * 2)
            {
                meatEaten = animal.GetMeatFromKillQuantity();
                base.Size++;
            }

            return meatEaten;
        }
    }
}
