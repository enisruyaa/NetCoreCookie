using Microsoft.AspNetCore.Mvc;

namespace NetCoreCookie_0.Controllers
{
    public class SessionController : Controller
    {
        public IActionResult Index()
        {
            SetSession();
            ViewBag.Session = GetSession();
            return View();
        }


        void SetSession()
        {
            HttpContext.Session.SetString("Deneme", "Session verisi olustu");
        }

        string GetSession()
        {
            return HttpContext.Session.GetString("Deneme");
        }
    }
}
