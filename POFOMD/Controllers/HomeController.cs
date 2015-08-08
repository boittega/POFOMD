using System.Web.Mvc;

namespace POFOMD.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            
            ViewData["Usuario"] =  User.Identity.Name;
            return View();
        }

        public ActionResult Explicativos()
        {
            ViewBag.Message = "Para Onde Foi o Meu Dinheiro.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Página de contato.";

            return View();
        }

        public ActionResult Rectangle()
        {
            return File(Server.MapPath("/Views/Home/") + "Rectangle.html", "text/html" );
        }

        public ActionResult Bubble()
        {
            return File(Server.MapPath("/Views/Home/") + "Bubble.html", "text/html");
        }

        public ActionResult Help(string id)
        {
            ViewData["ID"] = id;
            return PartialView("Help");
        }
    }
}