using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDom.Tag
{
    public sealed class TWithContent : ITag
    {
        private readonly ITag _origin;
        private readonly IDomPart _content;

        public TWithContent(ITag origin, IDomPart content)
        {
            _origin = origin;
            _content = content;
        }
        public string AsString()
        {
            return string.Join(string.Empty, Parts().Select(p => p.AsString()));
        }

        public IEnumerable<IDomPart> Parts()
        {
            return new[] {
                new TOpen(_origin),
                _content,
                new TClose(_origin)
            };
        }

        public ITag Unwrap()
        {
            return _origin.Unwrap();
        }
    }
}
