using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDom
{
    public class Tag : IDomPart
    {
        private readonly IEnumerable<string> _tagParts;

        public Tag(string tagName)
        {
            _tagParts = new[] {
                "<",tagName,">"
            };
        }
        public string AsString()
        {
            return string.Concat(_tagParts);
        }
    }
}
