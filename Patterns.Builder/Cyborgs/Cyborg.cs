namespace Patterns.Builder.Cyborgs
{
    using System.Collections.Generic;
    using System.Linq;

    public abstract class Cyborg
    {
        public Part Legs { get; set; }
        public Part Arms { get; set; }
        public Part Torso { get; set; }
        public Part Head { get; set; }
        public IList<Part> Extras { get; set; } = Enumerable.Empty<Part>().ToList();

        public virtual string Mission() => "Kill";

        public abstract string Talk();
    }
}