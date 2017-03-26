namespace Patterns.Iterator.V1
{
    public abstract class Iterator
    {
        public abstract bool HasNext();
        public abstract object Get(int index);
    }
}