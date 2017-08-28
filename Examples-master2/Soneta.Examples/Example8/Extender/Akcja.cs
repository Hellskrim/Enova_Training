using Soneta.Business;
using static Soneta.Business.FieldValue;
using Soneta.Types;

namespace Soneta.Examples.Example8.Extender {
    public class Akcja {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public Types.Date Data { get; set; }
        public string Commit { get; set; }
        public string Branch { get; set; }

        public DataAppearance GetAppearance() {
            var appearance = new DataAppearance();
             
                appearance.SetForeColorFromName("Green");
             
            return appearance;
        }

        public DataAppearance GetAppearanceNazwa() {
            var appearance = new DataAppearance();
             
            return appearance;
        }
    }
}
