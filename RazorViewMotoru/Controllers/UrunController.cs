using Microsoft.AspNetCore.Mvc;
using RazorViewMotoru.Models;
using System.Collections.Generic;

namespace RazorViewMotoru.Controllers
{
    public class UrunController : Controller
    {
        public IActionResult Index()
        {
            List<Urun> urunler = new List<Urun>()
            {
                new Urun() {UrunId=1,UrunAdi="Samsung S6",Aciklama="İdare eder.",Fiyat=3000, Satistami=false},
                new Urun() {UrunId=2,UrunAdi="Samsung S22",Aciklama="Baadasd.",Fiyat=30000, Satistami=true},
                new Urun() {UrunId=3,UrunAdi="Samsung S23",Aciklama="Güzel.",Fiyat=40000, Satistami=true},
                new Urun() {UrunId=4,UrunAdi="Samsung S24",Aciklama="İdare eder.",Fiyat=3000, Satistami=false},
                new Urun() {UrunId=5,UrunAdi="IPhone 6",Aciklama="İdare eder.",Fiyat=3000, Satistami=false},
                new Urun() {UrunId=6,UrunAdi="IPhone 10",Aciklama="Harika.",Fiyat=30000, Satistami=true},
                new Urun() {UrunId=7,UrunAdi="IPhone 11",Aciklama="İyiiii.",Fiyat=60000, Satistami=true},
                new Urun() {UrunId=8,UrunAdi="IPhone 14",Aciklama="Harika.",Fiyat=30000, Satistami=true},
                new Urun() {UrunId=9,UrunAdi="IPhone 15",Aciklama="İyiiii.",Fiyat=60000, Satistami=true},
            };
            ViewBag.UrunSayisi = urunler.Count();
            return View(urunler);
        }
    }
}
