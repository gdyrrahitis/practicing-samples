namespace Data.Structures.LinkedLists
{
    public interface IBiDirectionalLinkedList: ILinkedList
    {
        Link Last { get; }
        void Append(int value);
    }
}