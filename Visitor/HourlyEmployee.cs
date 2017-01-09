namespace Visitor
{
    public class HourlyEmployee: IEmployee
    {
        public string Accept(IEmployeeVisitor visitor)
        {
            return visitor.Visit();
        }
    }
}