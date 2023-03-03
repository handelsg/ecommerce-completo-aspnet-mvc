using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class MovieController : Controller
    {
        private readonly AppDbContext _context;

        public MovieController(AppDbContext context)
        {
            _context = context;

        }

        public async Task<ActionResult> Index()
        {
            var allProducers = await _context.Movie.ToListAsync();
            return View();
        }
    }
}
