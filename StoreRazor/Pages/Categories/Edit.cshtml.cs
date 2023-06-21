using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StoreRazor.Data;
using StoreRazor.Model;

namespace StoreRazor.Pages.Categories
{
    [BindProperties]
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        
        public Category Category { get; set; }

        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet(int? id)
        {
            if (id != null && id != 0) {
                Category = _db.Categories_R.Find(id); 
            }
        }
        public IActionResult OnPost()
        {
            _db.Categories_R.Update(Category);
            _db.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
