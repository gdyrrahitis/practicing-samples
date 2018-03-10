namespace Patterns.Builder.Cyborgs
{
    public interface ICyborgBuilder
    {
        void BuildHead(Part part);
        void BuildTorso(Part part);
        void BuildArms(Part part);
        void BuildLegs(Part part);
        void BuildExtras(Part part);
        Cyborg GetCyborg();
    }
}