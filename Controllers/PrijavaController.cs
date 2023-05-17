using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RegistracijeApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;

namespace RegistracijeApp.Controllers
{
    public class PrijavaController : Controller
    {
        [AllowAnonymous]
        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated == true) 
            {
                return RedirectToAction("Ispis", "Glavni");
            }
            return View();
        }
        [AllowAnonymous]
        public IActionResult PrijavaKorisnika(string ime, string lozinka)
        {
            if (ime != null && lozinka != null) 
            {
                bool ispravniPodaci = Users.ProvjeraPodataka(ime, lozinka);
                if (ispravniPodaci==true)
                {
                    List<Claim> claims = new List<Claim> { new Claim(ClaimTypes.Name, ime) };
                    ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    AuthenticationProperties authProperties = new AuthenticationProperties();
                    HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);
                    return RedirectToAction("Ispis", "Glavni");
                }
            }
            return RedirectToAction("Login");
        }

        public IActionResult Odjava()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login");
        }
    }
}
