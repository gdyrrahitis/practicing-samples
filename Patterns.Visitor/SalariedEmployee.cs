namespace Patterns.Visitor
{
    public class SalariedEmployee: IEmployee
    {
        public string Accept(IEmployeeVisitor visitor)
        {
            return visitor.Visit();
        }
    }
}