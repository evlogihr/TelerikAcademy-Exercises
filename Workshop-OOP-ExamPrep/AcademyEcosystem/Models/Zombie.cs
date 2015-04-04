namespace AcademyEcosystem
{
    public class Zombie : Animal
    {
        public Zombie(string name, Point location)
            : base(name, location, 0)
        {
        }

        public override int GetMeatFromKillQuantity()
        {
            return 10;
        }
    }
}
