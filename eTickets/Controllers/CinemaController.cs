using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class CinemaController : Controller
    {

        private readonly AppDbContext _context;

        public CinemaController(AppDbContext context)
        {
            _context = context;

        }

        public async Task<ActionResult> Index()
        {
            var allProducers = await _context.Cinemas.ToListAsync();
            return View();
        }
    }
}
