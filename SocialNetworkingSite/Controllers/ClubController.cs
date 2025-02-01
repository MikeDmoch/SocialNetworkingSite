using Microsoft.AspNetCore.Mvc;

namespace SocialNetworkingSite.Controllers
{
    public class ClubController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
