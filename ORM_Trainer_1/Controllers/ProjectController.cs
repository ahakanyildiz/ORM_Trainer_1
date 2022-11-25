using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ORM_Trainer_1.DBProvider;

namespace ORM_Trainer_1.Controllers
{
    public class ProjectController : Controller
    {
        MssqlContext _context = new MssqlContext();

        public IActionResult Index()
        {
            var cookie = Request.Cookies["LoginStatus"];

            if(cookie!=null)
            {
                var data = _context.Projects.Include(x => x.Owner).ToList();
                return View(data);
            }

            return RedirectToAction("Index", "Login");
        }
    }
}
