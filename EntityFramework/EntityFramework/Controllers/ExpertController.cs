using EntityFramework.Data;
using EntityFramework.Models;
using EntityFramework.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Controllers
{
    public class ExpertController : Controller
    {

        private readonly AppDbContext _context;

        public ExpertController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult>  Index(int? id)
        {
            if (id is null) return BadRequest();

            Expert expert = await _context.Experts.Where(m=>!m.SoftDeleted).FirstOrDefaultAsync(p => p.Id == id);

            if (expert is  null) return NotFound();

            ExpertVM expertVM = new()
            {
                Id = expert.Id,
                FullName=expert.FullName,
                Position = expert.Position,
                Image=expert.Image

            };

            return View(expertVM);
        }
    }
}
