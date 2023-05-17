using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RegistracijeApp.Models;
using System.Data;

namespace RegistracijeApp.Controllers
{
    public class GlavniController : Controller
    {
        #region Početna stranica
        public IActionResult Ispis()
        {
            DataTable podaci = Registracije.DohvatiRegistracije();
            ViewBag.registracije = podaci;
            return View();
        }
        #endregion

        #region Novi unos
        public IActionResult NoviUnos()
        {
            return View();
        }

        public IActionResult Dodaj(string oznaka,DateTime datum)
        {
            bool uspjesnoDodano = Registracije.DodajNoviZapis(oznaka, datum);
            ViewBag.uspjesnoDodano = uspjesnoDodano;
            return View("NoviUnos");
        }
        #endregion

        #region Ažuriranje
        public IActionResult Azuriranje(int id)
        {
            List<object> podaci = Registracije.DohvatiRegistracijuPoId(id);
            ViewBag.podaciZaIzmjenu = podaci;
            ViewBag.id = id;
            return View();
        }

        public IActionResult SpremiIzmjene(int id,string oznaka,DateTime datum)
        {
            bool promjena = Registracije.IzmjenaPodataka(id, oznaka, datum);
            ViewBag.uspjenoIzmijenjeno = promjena;
            
            List<object> podaci = Registracije.DohvatiRegistracijuPoId(id);
            ViewBag.podaciZaIzmjenu = podaci;
            ViewBag.id = id;

            return View("Azuriranje");
        }
        #endregion

        #region Brisanje
        public IActionResult Brisanje(int id)
        {
            bool uspjesnoObrisano = Registracije.BrisanjePodataka(id);
            ViewBag.uspjesnoObrisano = uspjesnoObrisano;

            DataTable podaci = Registracije.DohvatiRegistracije();
            ViewBag.registracije = podaci;

            return View("Ispis");
        }
        #endregion
    }
}
