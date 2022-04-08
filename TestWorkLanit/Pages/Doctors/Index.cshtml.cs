using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TestWorkLanit.Models;

namespace TestWorkLanit.Pages.Doctors
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationContext _context;
        public List<Doctor> Doctor { get; set; }
        public IndexModel(ApplicationContext db)
        {
            _context = db;
        }
        public void OnGet()
        {
            Doctor = _context.Doctor.AsNoTracking().ToList();
        }
    }
}
