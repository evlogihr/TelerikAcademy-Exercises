namespace AcademyRPG.Models
{
    public abstract class Fighter : Character, IFighter
    {
        public Fighter(string name, Point position, int owner, int attackPoints, int defensePoints, int hitPoints)
            :base(name, position, owner)
        {
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.HitPoints = hitPoints;
        }

        public int AttackPoints { get; protected set; }

        public int DefensePoints { get; private set; }

        public abstract int GetTargetIndex(System.Collections.Generic.List<WorldObject> availableTargets);
    }
}
