using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace AliExpress.MVC.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> login(string username, string password)
        {
            //get user data from database

            if (username == "Ayed")
            {
                // create new claim
                Claim claim1 = new Claim(ClaimTypes.Name, username);
                Claim claim2 = new Claim(ClaimTypes.Role, "Admin");


                ClaimsIdentity claimsIdentity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
                claimsIdentity.AddClaim(claim1);
                claimsIdentity.AddClaim(claim2);

                ClaimsPrincipal principal = new ClaimsPrincipal(claimsIdentity);

                await HttpContext.SignInAsync(principal);

                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("Error", "Wrong");
                return View();
            }

        }




    }
}
