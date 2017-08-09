namespace Patterns.Strategy.PartialTypeNameRoleHint
{
    public class InternalServerErrorResponder: IResponder
    {
        public string Content()
        {
            return "InternalServerError_Result";
        }
    }
}