using System.Web.Mvc;

namespace HtmlGenerateManager.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return Redirect("/index.html");
        }
    }
}