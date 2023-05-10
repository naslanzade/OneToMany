
using EntityFramework.Data;
using EntityFramework.Models;
using EntityFramework.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace EntityFramework.Controllers
{
    public class HomeController : Controller
    {

        private readonly AppDbContext _context;


        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult>Index()
        {

            IEnumerable<Features> features = await _context.Features.Where(m => !m.SoftDeleted).ToListAsync();
            IEnumerable<Projects> projects = await _context.Projects.Where(m => !m.SoftDeleted).ToListAsync();
            IEnumerable<Services> services = await _context.Services.Where(m => !m.SoftDeleted).ToListAsync();
            IEnumerable<Slider> slider = await _context.Sliders.Where(m => !m.SoftDeleted).ToListAsync();
            IEnumerable<AboutSecond> aboutSeconds = await _context.AboutsSeconds.Where(m => !m.SoftDeleted).ToListAsync();
            About about = await _context.Abouts.Where(m => !m.SoftDeleted).FirstOrDefaultAsync();
            IEnumerable<Expert> experts= await _context.Experts.Where(m => !m.SoftDeleted).ToListAsync();
            IEnumerable<Testimonial> testimonials = await _context.Testimonials.Where(m => !m.SoftDeleted).ToListAsync();

            HomeVM model = new()
            {
                Features = features,
                Projects = projects,
                Services=services,
                Sliders= slider,
                AboutSecond= aboutSeconds,
                About=about,
                Experts=experts,
                Testimonials=testimonials

            };

            return View(model);
        }

       

      
    }
}