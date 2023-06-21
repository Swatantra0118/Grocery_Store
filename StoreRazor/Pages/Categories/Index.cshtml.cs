using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StoreRazor.Data;
using StoreRazor.Model;

namespace StoreRazor.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public List<Category> CategoryList { get; set; }

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;     
        }
        public void OnGet()
        {
            CategoryList = _db.Categories_R.ToList();
        }
    }
}
