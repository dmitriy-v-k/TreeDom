﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace TreeDom.Tags
{
    public sealed class Tag : ITag
    {
        private readonly IEnumerable<IDomPart> _tagParts;

        public Tag(string name)
            : this(new[] { new Raw(name) })
        {
        }

        public Tag(IDomPart tagPart)
            : this(new[] { tagPart })
        {
        }

        public Tag(IEnumerable<IDomPart> tagParts)
        {
            _tagParts = tagParts;
        }

        public string AsString()
        {
            var tagParts = _tagParts.ToList();
            tagParts.Insert(0, new Raw("<"));
            tagParts.Add(new Raw(">"));
            return string.Concat(tagParts.Select(p => p.AsString()));
        }

        public IEnumerable<IDomPart> Parts()
        {
            return _tagParts.ToList();
        }

        public ITag Unwrap()
        {
            return this;
        }
    }
}
