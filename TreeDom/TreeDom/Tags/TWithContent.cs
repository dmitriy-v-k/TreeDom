using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDom.Tags
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
            return string.Format("{0}{1}{2}", 
                new TOpen(_origin).AsString(), _content.AsString(), new TClose(_origin).AsString()
            );
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
