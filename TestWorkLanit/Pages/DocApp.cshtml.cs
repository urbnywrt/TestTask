using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TestWorkLanit.Models;

namespace TestWorkLanit.Pages
{
    public class DocAppModel : PageModel
    {
        private readonly ApplicationContext _context;
       
        [BindProperty]
        public Patient Patient { get; set; }
        public DocAppModel(ApplicationContext db)
        {
            _context = db;
        }
        public void OnGet()
        {

        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                _context.Patient.Add(Patient);
                await _context.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
