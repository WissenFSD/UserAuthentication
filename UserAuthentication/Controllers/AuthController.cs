using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using UserAuthentication.Models;

namespace UserAuthentication.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            // Kontroller ilk çağırıldığında, Get metodu çalışacaktır.
            // Get Metodu , sayfa açılırken içerisinde hazır bulunması gereken veriler burada hazırlanır.
            return View(new AuthModel()
            {
                 IsGet=true
            });
        }
        [HttpPost]
        public IActionResult Login(string username,string password)
        {
            if(username=="emrah" && password == "1010")
            {
                return View("Index",new AuthModel()
                {
                     IsSucces=true,
                      IsGet=false
                });

            }
            else
            {

                return View("Index",new AuthModel()
                {,
                     IsGet=false,
                      IsSucces=false
                });
            }

        }
    }
}
