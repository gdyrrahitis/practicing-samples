using System.Collections.Generic;

namespace Patterns.Strategy.PartialTypeNameRoleHint
{
    using System;
    using System.Linq;
    using System.Net;

    public class ResponderSelector
    {
        private readonly List<IResponder> _candidates;

        public ResponderSelector(List<IResponder> candidates)
        {
            _candidates = candidates;
        }

        public IResponder Select(HttpStatusCode code)
        {
            return (from item in _candidates
                let t = item.GetType()
                where t.Name.StartsWith(code.ToString(), StringComparison.InvariantCultureIgnoreCase)
                select item).Single();
        }
    }
}