using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDom.Tags
{
    public sealed class TSingle: ITag
    {
        private readonly ITag _origin;

        public TSingle(ITag origin)
        {
            _origin = origin;
        }

        public string AsString()
        {
            return new Tag(Parts()).AsString();
        }

        public IEnumerable<IDomPart> Parts()
        {
            var parts = _origin.Parts().ToList();
            parts.Add(new Raw(" /"));
            return parts;
        }

        public ITag Unwrap()
        {
            return this;
        }
    }
}
