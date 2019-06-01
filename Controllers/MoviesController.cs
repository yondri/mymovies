using mymovies.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System.Linq;
namespace mymovies.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public MovieController(ApiDbContext context)
        {
            _context = context;
        }

        public object Get()
        {
            return _context.Movies.Where(b => b.Title.Contains("Title")).Select((c) => new
            {
                Id = c.Id,
                Title = c.Title,
                Description = c.Description,
                Rating = c.Rating
            }).ToList();
        }

        

    }
}