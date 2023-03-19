using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ZiiBlog.Data;
using ZiiBlog.Models;

namespace ZiiBlog.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MysqlContext _context;

        public HomeController(ILogger<HomeController> logger, MysqlContext c)
        {
            _logger = logger;
            _context = c;
        }

        public IActionResult Index()
        {
            List<post> posts = _context.Posts.ToList();
            return View(posts);

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}