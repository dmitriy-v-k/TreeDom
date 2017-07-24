using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDom.Tags.Attributes
{
    public sealed class TAWithValue : ITAttribute
    {
        private readonly string _value;
        private readonly ITAttribute _original;

        public TAWithValue(ITAttribute original, string value)
        {
            _value = value;
            _original = original;
        }
        public string AsString()
        {
            return string.Format("{0}=\"{1}\" ", _original.AsString(), _value);
        }

        public string Name()
        {
            return _original.Name();
        }
    }
}
