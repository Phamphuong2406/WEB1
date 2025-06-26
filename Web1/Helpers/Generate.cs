using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace Web1.Helpers
{
    public class Generate()
    {
        public static string GenerateSlug(string title)
        {
            // 1. Chuyển sang chữ thường
            title = title.ToLowerInvariant();

            // 2. Loại bỏ dấu tiếng Việt
            string normalized = title.Normalize(NormalizationForm.FormD);
            var sb = new StringBuilder();
            foreach (var c in normalized)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(c);
                }
            }
            string noDiacritics = sb.ToString().Normalize(NormalizationForm.FormC);

            // 3. Loại bỏ ký tự đặc biệt (chỉ giữ chữ, số và khoảng trắng)
            string cleaned = Regex.Replace(noDiacritics, @"[^a-z0-9\s]", "");

            // 4. Thay khoảng trắng bằng dấu _
            string slug = Regex.Replace(cleaned, @"\s+", "_");

            return slug.Trim('_');
        }
    }
    

}
