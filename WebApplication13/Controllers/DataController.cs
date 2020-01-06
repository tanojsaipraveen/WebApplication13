using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace WebApplication13.Controllers
{
    public class DataController : Controller
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public DataController(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public IActionResult Index()
        {
            return View();
        }

       

        public IActionResult Data()
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var Email = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Name);
            ViewBag.Id = userId;
            ViewBag.Email = Email;
            return View();
        }
    }
}