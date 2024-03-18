using Microsoft.AspNetCore.Mvc;

namespace NetCoreCookie_0.Controllers
{
    public class CookieUsageController : Controller
    {
        //Bir Cookie'yi setleyebilmek icin Response, getirebilmek icin Request kullanılır...
        public IActionResult Index()
        {
            SetCookie();
            ViewBag.Message = GetCookie();
            
            return View();
        }


        void SetCookie()
        {
            HttpContext.Response.Cookies.Append("Deneme", "Olusturdugumuz cookie verisi", new CookieOptions
            {
                Expires = DateTime.Now.AddDays(1),
                HttpOnly = true, //document.cookie ile cookielere ulasılamaz
                SameSite = SameSiteMode.Strict
                
            });
        }


        string GetCookie()
        {
            HttpContext.Request.Cookies.TryGetValue("Deneme",out string cookie);
            return cookie == null ? null:cookie;
           
        }





    }
}
