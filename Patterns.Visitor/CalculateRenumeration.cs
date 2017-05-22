namespace Patterns.Visitor
{
    public class CalculateRenumeration: IEmployeeVisitor
    {
        public string Visit()
        {
            return "renumeration";
        }
    }
}