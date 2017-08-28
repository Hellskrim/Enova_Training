#define EXAMPLE8

using Soneta.Business.UI;
using Soneta.Examples.Example8.Extender;

#if EXAMPLE8

[assembly: FolderView("Git",
    Priority = 13,
    Description = "Przykład pokazujący programistyczne możliwości kolorowania wierszy",
    ObjectType = typeof(Notowania),
    ObjectPage = "Notowania.Ogolne.pageform.xml",
    ReadOnlySession = false,
    ConfigSession = false
)]

#endif