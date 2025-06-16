using Web1.Models;

namespace Web1.Service
{
    public interface IFooterService
    {
        List<FooterModel> GetSampleFooter();
    }
    public class FooterService: IFooterService
    {
        public List<FooterModel> GetSampleFooter()
        {
            return new List<FooterModel> {   new FooterModel
            {
                Title = "Footer nội dung",
                LinkGroups = new List<FooterLinkGroup>
            {
                new FooterLinkGroup
                {
                    GroupTitle = "group title",
                    Links = new List<FooterLinkItem>
                    {
                        new FooterLinkItem { Text = "jjjjjjjjjjjjjjjjjjjjjjjjjjjjj", Url = "#" },
                        new FooterLinkItem { Text = "Ojjjjjjjjjjjjjjjjjjjjjg", Url = "#" },
                        new FooterLinkItem { Text = "oooooooooooooooooooooo", Url = "#" },
                        new FooterLinkItem { Text = "mmmmmmmmmmmmm", Url = "#" },
                        new FooterLinkItem { Text = "nnnnnnnnnnnnnnnnnnnn", Url = "#" }
                    }
                },
                new FooterLinkGroup
                {
                    GroupTitle = "jjjjjjjjjj",
                    Links = new List<FooterLinkItem>
                    {
                        new FooterLinkItem { Text = "kkkkkkkkkkkkkk", Url = "#" },
                        new FooterLinkItem { Text = "kkkkkkkkkkkkkkkkk", Url = "#" },
                        new FooterLinkItem { Text = "kkkkkkkkkkkkkkkkkkkkkkkkkkkkk", Url = "#" },
                        new FooterLinkItem { Text = "lllllllllllllllllllllllllllll", Url = "#" }
                    }
                },
                new FooterLinkGroup
                {
                    GroupTitle = "Công ti",
                    Links = new List<FooterLinkItem>
                    {
                        new FooterLinkItem{Text = "gsfhfhsgdgdgsjffffffffffffff", Url="#"},
                        new FooterLinkItem{Text="gsaccasbdnsdnxxxxxxxxxxxz", Url="#"},
                        new FooterLinkItem{Text="ggggg" , Url="#"}
                    }

                }
            }
            }};
              
        }
    }
}
