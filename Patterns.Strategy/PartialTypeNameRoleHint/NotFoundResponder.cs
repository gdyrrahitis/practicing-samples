namespace Patterns.Strategy.PartialTypeNameRoleHint
{
    public class NotFoundResponder: IResponder
    {
        public string Content()
        {
            return "NotFound_Result";
        }
    }
}