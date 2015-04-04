namespace AcademyRPG.Models
{
    using System.Linq;

    public class Ninja : Fighter, IFighter, IControllable, IWorldObject, IGatherer
    {
        public Ninja(string name, Point position, int owner)
            : base(name, position, owner, 0, int.MaxValue, 1)
        {
        }

        public override int GetTargetIndex(System.Collections.Generic.List<WorldObject> availableTargets)
        {
            var target = availableTargets
                .Where(x => x.Owner != 0 && x.Owner != this.Owner)
                .OrderByDescending(x => x.HitPoints)
                .FirstOrDefault();

            return availableTargets.IndexOf(target);
        }

        public bool TryGather(IResource resource)
        {
            bool canGather = false;
            if (resource.Type == ResourceType.Lumber)
            {
                base.AttackPoints += resource.Quantity;
                canGather = true;
            }
            else if (resource.Type == ResourceType.Stone)
            {
                base.AttackPoints += resource.Quantity * 2;
                canGather = true;
            }

            return canGather;
        }
    }
}
