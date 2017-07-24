using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDom
{
    public sealed class Raw : IDomPart
    {
        private readonly string _source;
        public Raw(string source)
        {
            _source = source;
        }
        public string AsString()
        {
            return _source;
        }
    }
}
