namespace AcademyRPG.Models
{
    public class House: StaticObject
    {
        public House(Point position, int owner)
            :base(position, owner)
        {
            base.HitPoints = 500;
        }
    }
}
