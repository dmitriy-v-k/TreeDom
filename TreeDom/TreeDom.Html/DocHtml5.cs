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

        public DocHtml5()
            : this(Enumerable.Empty<IDomPart>(), Enumerable.Empty<IDomPart>())
        {
        }

        public DocHtml5(IDomPart head, IDomPart body)
            : this(new[] { head }, new[] { body })
        {
        }

        public DocHtml5(IEnumerable<IDomPart> head, IEnumerable<IDomPart> body)
        {
            _head = head;
            _body = body;
        }

        public IHtmlDocument WithPart(IDomPart part)
        {
            return AddToBody(part);
        }

        public IHtmlDocument AddToBody(IDomPart part)
        {
            return new DocHtml5(_head, _body.Add(part));
        }

        public IHtmlDocument AddToHead(IDomPart part)
        {
            return new DocHtml5(_head.Add(part), _body);
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
