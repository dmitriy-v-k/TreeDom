using System.Collections.Generic;
using System.Linq;
using TreeDom.Extensions;
using TreeDom.Html.Doctypes;
using TreeDom.Tags;

namespace TreeDom.Html
{
    public sealed class DocHtml5 : IHtmlDocument
    {
        private readonly IEnumerable<IDomPart> _head;
        private readonly IEnumerable<IDomPart> _body;
        private readonly IDocument _origin;

        public DocHtml5(IDocument origin)
            : this(origin, Enumerable.Empty<IDomPart>())
        {
        }

        public DocHtml5(IDocument origin, IDomPart head)
            : this(origin, new[] { head })
        {
        }

        public DocHtml5(IDocument origin, IEnumerable<IDomPart> head)
        {
            _origin = origin;
            _head = head;
            _body = _origin.Parts();
        }

        public IDocument WithPart(IDomPart part)
        {
            return new Document(Parts().Add(part));
        }

        public IHtmlDocument AddToBody(IDomPart part)
        {
            return new DocHtml5(_origin.WithPart(part), _head);
        }

        public IHtmlDocument AddToHead(IDomPart part)
        {
            return new DocHtml5(_origin, _head.Add(part));
        }

        public string AsString()
        {
            return new PartsGroup(Parts()).AsString();
        }

        public IEnumerable<IDomPart> Parts()
        {
            return new List<IDomPart>()
            {
                new DTHtml5(),
                new TWithContent(
                    new Tag("html"),
                    new PartsGroup(
                        new TWithContent(
                            new Tag("head"),
                            new PartsGroup(_head)
                        ),
                        new TWithContent(
                            new Tag("body"),
                            new PartsGroup(_body)
                        )
                    )  
                )
            };
        }
    }
}
