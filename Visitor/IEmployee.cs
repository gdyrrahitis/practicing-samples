namespace Visitor
{
    public interface IEmployee
    {
        string Accept(IEmployeeVisitor visitor);
    }
}