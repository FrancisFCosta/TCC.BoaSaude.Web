using Microsoft.AspNetCore.Mvc;

namespace TCC.BoaSaude.Web.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController()
        {
        }

        public ActionResult Index()
        {
            base.PreencherViewBagUsuarioLogado();
            return RedirectToAction("Index", "Atendimento");
        }
    }
}
