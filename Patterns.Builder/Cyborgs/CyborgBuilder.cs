namespace Patterns.Builder.Cyborgs
{
    using System;
    using Deadly;

    public class CyborgBuilder: ICyborgBuilder
    {
        private readonly Cyborg _cyborg;

        public CyborgBuilder(Type type)
        {
            switch (type)
            {
                case Type.T800:
                    _cyborg = new FriendlyCyborg();
                    break;
                case Type.Tx:
                    _cyborg = new TerminatorCyborg();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }

        public void BuildHead(Part part) => _cyborg.Head = part;

        public void BuildTorso(Part part) => _cyborg.Torso = part;

        public void BuildArms(Part part) => _cyborg.Arms = part;

        public void BuildLegs(Part part) => _cyborg.Legs = part;

        public void BuildExtras(Part part) => _cyborg.Extras.Add(part);

        public Cyborg GetCyborg() => _cyborg;
    }
}