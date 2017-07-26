using TreeDom.Tags;

namespace TreeDom.Html
{
    public interface IHtmlDocument: IDocument<IHtmlDocument>
    {
        IHtmlDocument AddToHead(IDomPart part);
        IHtmlDocument AddToBody(IDomPart part);
    }
}
