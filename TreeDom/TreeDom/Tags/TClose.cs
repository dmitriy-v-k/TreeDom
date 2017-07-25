using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDom.Tags
{
    public sealed class TClose : ITag
    {
        private readonly ITag _origin;

        public TClose(ITag origin)
        {
            _origin = origin;
        }

        public string AsString()
        {
            return new Tag(Parts()).AsString();
        }

        public IEnumerable<IDomPart> Parts()
        {
            var parts = _origin.Parts().Take(1).ToList();
            parts.Insert(0, new Raw("/"));
            return parts;
        }

        public ITag Unwrap()
        {
            return _origin;
        }
    }
}
