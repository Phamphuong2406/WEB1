using Web1.Models;

namespace Web1.ViewModel
{
    public class HomeViewModel
    {
        public List<FooterModel> Footer { get; set; }
        public List<GeneralDesription> generalDesription { get; set; }
        public List<Introduce> introduces { get; set; }
        public List<GeneralServiceFeature> generalserviceFeatures { get; set; }
        public Contact contact { get; set; }
        public Header header { get; set; }
        public List<Menu> menu { get; set; }
        public List<TestYoneTitle> testYones { get; set; }
    }
}
