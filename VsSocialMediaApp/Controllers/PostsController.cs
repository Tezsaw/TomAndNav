using Microsoft.AspNetCore.Mvc;
using VsSocialMediaApp.Models;

namespace VsSocialMediaApp.Controllers
{
    public class PostsController : Controller
    {
        private readonly ApplicationDBContext _context;

        public PostsController(ApplicationDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
