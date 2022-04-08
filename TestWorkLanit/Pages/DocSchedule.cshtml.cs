using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TestWorkLanit.Models;


namespace TestWorkLanit.Pages
{
    public class DocSheduleModel : PageModel
    {
        private readonly ApplicationContext _context;
        public List<Doctor> Doctor { get; set; }
        public List<Patient> Patient { get; set; }

        public Doctor CurrentDoctor;
        public DocSheduleModel(ApplicationContext db)
        {
            _context = db;
        }

        public void OnGet(string name)
        {

            Doctor = _context.Doctor.AsNoTracking().ToList();
            Patient = _context.Patient.AsNoTracking().ToList();

            foreach (var doc in Doctor.Where(doc => doc.Name == name))
            {
                CurrentDoctor = doc;
            }
            
           
        }
    }
}

