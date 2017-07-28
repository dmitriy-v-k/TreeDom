# TreeDom is a "TrueOOP" library for a work with DOM and in particular with HTML via C#

It's only a sketch but I beleave it should be in this way.

A small example:

```
  return 
  new Document(
      new List<IDomPart> {
          new Tag("!DOCTYPE html"),
          new TWithContent(
              new Tag("html"),
              new TWithContent(
                  new TWithAttributes(
                      new Tag("head"),
                      new TAWithValue(
                          new TAttribute("lang"),
                          "ru_RU"
                      )
                  ).Attr(
                      new TAttribute("required")
                  ),
                  new Raw("test")
              )
          )
      }
  )
  .AsString();
```

p.s. Other examples you can find in tests.
p.p.s If you want you can help ;)
