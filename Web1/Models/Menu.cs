namespace Web1.Models
{
    public class Menu
    {
     public string Title { get; set; }   
    }
    public class MenuButton
    {
        public string ButtonTitle { get; set; }
        public List<Menu> menus { get; set; }
    }
}
