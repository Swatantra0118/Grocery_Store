using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StoreRazor.Data;
using StoreRazor.Model;

namespace StoreRazor.Pages.Categories
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        [BindProperty]
        public Category Category{ get; set; }

        public CreateModel (ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost()  {
            _db.Categories_R.Add(Category);
            _db.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
