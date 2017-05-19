namespace Visitor
{
    public class CalculateRate: IEmployeeVisitor
    {
        public string Visit()
        {
            return "rate";
        }
    }
}