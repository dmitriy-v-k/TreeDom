using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDom.Tags
{
    public sealed class TEmpty : ITag
    {
        public string AsString()
        {
            return string.Empty;
        }

        public IEnumerable<IDomPart> Parts()
        {
            return Enumerable.Empty<IDomPart>();
        }

        public ITag Unwrap()
        {
            return this;
        }
    }
}
