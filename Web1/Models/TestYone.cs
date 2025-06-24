namespace Web1.Models
{
    public class TestYone
    {
        public string Name { get; set; }
    }
    public class TestYoneTitle
    {
        public string Title { get; set; }

        public string DescriptionTitle { get; set; }
        public string Icon { get; set; }
        public string Icon2 { get; set; }
        public List<TestYone> blocks { get; set; }
    }
}
