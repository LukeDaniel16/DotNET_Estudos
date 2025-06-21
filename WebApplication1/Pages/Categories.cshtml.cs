using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesIntroduction.Pages
{
    public class CategoriesModel : PageModel
    {
        public List<Category> Categories { get; set; } = [];
        public void OnGet(int skip = 0, int take = 25)
        {
            var categs = new List<Category>();

            for (int i = 0; i <= 2000; i++)
            {
                categs.Add(new Category(i, $"Categoria {i}", i * 3.97M));
            }

            Categories = [.. categs.Skip(skip).Take(take)];
        }

        public void OnPost() { }
    }

    public record Category(int Id, string Title, decimal Price) { }

}
