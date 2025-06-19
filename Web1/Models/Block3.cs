namespace Web1.Models
{
    public class Block3
    {
        public string Name { get; set; }
    }
    public class Block3Title
    {
        public string Title { get; set; }

        public string DescriptionTitle { get; set; }
        public string Icon { get; set; }
        public string Icon2 { get; set; }
        public List<Block3> blocks { get; set; }
    }
}
