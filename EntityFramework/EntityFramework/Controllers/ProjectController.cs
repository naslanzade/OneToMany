using EntityFramework.Data;
using EntityFramework.Models;
using EntityFramework.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Controllers
{
    public class ProjectController : Controller
    {


        private readonly AppDbContext _context;

        public ProjectController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int? id)
        {

            if (id is null) return BadRequest();

           Projects projects=await _context.Projects.Where(m=>!m.SoftDeleted).FirstOrDefaultAsync(p => p.Id == id);

            if (projects == null) return NotFound();

            ProjectVM projectVM = new()
            {
                Id=projects.Id,
                Name=projects.Title,
                Description=projects.Description,
                Image=projects.Image

            };

            return View(projectVM);
        }
    }
}
