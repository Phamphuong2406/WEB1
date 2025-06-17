using Web1.Models;

namespace Web1.ViewModel
{
    public class HomeViewModel
    {
        public List<FooterModel> Footer { get; set; }
        public List<GeneralDesription> generalDesription { get; set; }
        public List<Introduce> introduces { get; set; }
        public List<GeneralServiceFeature> generalserviceFeatures { get; set; }
        public Block6 block6 { get; set; }
        public Header header { get; set; }
        public List<Menu> menu { get; set; }
    }
}
