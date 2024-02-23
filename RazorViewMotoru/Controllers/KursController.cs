using Microsoft.AspNetCore.Mvc;

namespace RazorViewMotoru.Controllers
{
    public class KursController : Controller
    {
        public IActionResult Index()
        {
            //Veritabanına bağlanır ve bilgileri getirir.
            //Getirilen bilgiler bir model içerisine yani bir sınıf
            //içerisine aktarılır ve model View'e gönderilir.
            string[] diller = { "Python", "C#", "Java", "JavaScript" };
            return View(diller);
        }
    }
}
