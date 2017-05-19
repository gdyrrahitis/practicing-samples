namespace Visitor
{
    public class CalculateRenumeration: IEmployeeVisitor
    {
        public string Visit()
        {
            return "renumeration";
        }
    }
}