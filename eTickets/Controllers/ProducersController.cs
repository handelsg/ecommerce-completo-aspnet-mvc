using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class ProducersController : Controller 
    { 

        private readonly AppDbContext _context;

        public ProducersController(AppDbContext context)
        {
            _context = context;

        }

        public async Task<ActionResult> Index()
        {
            var allProducers = await _context.Producers.ToListAsync();
            return View();
        }
    }
}