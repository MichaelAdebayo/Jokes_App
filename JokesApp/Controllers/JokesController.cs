using Microsoft.AspNetCore.Mvc;

namespace JokesApp.Controllers
{
    public class JokesController : Controller
    {
        // GET: JokesController
        public ActionResult Index()
        {
            return View();
        }

    }}
