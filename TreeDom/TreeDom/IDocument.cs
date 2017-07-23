using System.Collections.Generic;

namespace TreeDom
{
    public interface IDocument: IDomPart
    {
        IDocument WithDocumentParts(IEnumerable<IDomPart> domParts);
        IDocument WithDocumentPart(IDomPart domPart);
    }
}
