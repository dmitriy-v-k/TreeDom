﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDom.Tag
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
            var parts = Parts().ToList();
            parts.Insert(0, new Raw("/"));
            return new Tag(parts).AsString();
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