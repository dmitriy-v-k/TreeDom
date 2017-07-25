using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDom.Tags.Attributes
{
    public sealed class TAEmpty : ITAttribute
    {
        private readonly string _name;
        public TAEmpty()
            : this(string.Empty)
        {
        }

        public TAEmpty(string name)
        {
            _name = name;
        }

        public string AsString()
        {
            return string.Empty;
        }

        public string Name()
        {
            return _name;
        }
    }
}
