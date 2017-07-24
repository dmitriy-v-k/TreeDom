using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDom.Tag
{
    public sealed class TOpen : ITag
    {
        private readonly ITag _origin;

        public TOpen(ITag origin)
        {
            _origin = origin;
        }

        public string AsString()
        {
            return _origin.ToString();
        }

        public IEnumerable<IDomPart> Parts()
        {
            return _origin.Parts();
        }

        public ITag Unwrap()
        {
            return _origin.Unwrap();
        }
    }
}
