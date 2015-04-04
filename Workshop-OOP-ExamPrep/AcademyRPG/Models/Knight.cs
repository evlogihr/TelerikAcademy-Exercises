namespace AcademyRPG.Models
{
    using System.Collections.Generic;
    using System.Linq;

    public class Knight : Fighter, IFighter, IControllable, IWorldObject
    {
        public Knight(string name, Point position, int owner)
            : base(name, position, owner, 100, 100, 100)
        {
        }

        public override int GetTargetIndex(List<WorldObject> availableTargets)
        {
            var target = availableTargets
                .FirstOrDefault(x => x.Owner != 0 && x.Owner != this.Owner);

            return availableTargets.IndexOf(target);
        }
    }
}
