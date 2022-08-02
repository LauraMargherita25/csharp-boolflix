using csharp_boolflix.Context;
using csharp_boolflix.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace csharp_boolflix.Controllers
{
    public class HomeController : Controller
    {
        private readonly BoolflixContext _context;

        public HomeController(BoolflixContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int? id)
        {
            if (id == null || _context.Profiles == null)
            {
                return NotFound();
            }

            var profile = await _context.Profiles.FirstOrDefaultAsync(m => m.Id == id);
            var rndNum = new Random().Next(1, _context.Contents.ToList().Count);
            var content = _context.Contents.FirstOrDefault(m => m.Id == rndNum);
            return View(content);
        }

        public async Task<IActionResult> Play(int currentProfileId, int currentContentId)
        {
            var profileId = await _context.Profiles.FirstOrDefaultAsync(m => m.Id == id);
        }

    }
}