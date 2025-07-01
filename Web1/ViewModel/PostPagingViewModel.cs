using Web1.DTO;

namespace Web1.ViewModel
{
    public class PostPagingViewModel
    {
        public IEnumerable<IntroductoryPostDTO> Posts { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPage { get; set; }
        public string Temp { get; set; }
        public int? PageSize { get; set; }
        public DateTime? ValidDate { get; set; }
        public DateTime? PostingStartDate { get; set; }
        public DateTime? PostingEndDate { get; set; }

    }
}
