using Microsoft.AspNetCore.Mvc;
using ORM_Trainer_1.DBProvider;
using ORM_Trainer_1.Models;

namespace ORM_Trainer_1.Controllers
{
    public class LoginController : Controller
    {
        MssqlContext _context = new MssqlContext();

        public IActionResult Index()
        {
            var cookie = Request.Cookies["LoginStatus"];
            if (cookie != null)
            {
                return RedirectToAction("Index", "Project");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Index(User user)
        {

            var data = _context.Users.Where(x => x.UserName == user.UserName && x.UserPassword == user.UserPassword).FirstOrDefault();
            if (data != null)
            {
                var cookieOptions = new CookieOptions();
                cookieOptions.Expires = DateTime.Now.AddMinutes(1);
                cookieOptions.Path = "/";

                Response.Cookies.Append("LoginStatus", "Okey", cookieOptions);
                return RedirectToAction("Index", "Project");
            }
            return View();
        }

        [HttpGet]
        public IActionResult SifremiUnuttum(string id)
        {
            var data = _context.Users.Where(x => x.UserName == id).FirstOrDefault();
            if (data != null)
            {
                //Baba adının ilk 2 harfi + anne adının son 2 harfi + (anneuzunluk + 10) + (babauzunluk + 10)
                string newPass = data.FatherName.Substring(0, 2) + data.MotherName.Substring(data.MotherName.Length - 2, 2) + (data.MotherName.Length + 10) + (data.FatherName.Length + 10);
                data.UserPassword = newPass;
                _context.Users.Update(data);
                _context.SaveChanges();
                return RedirectToAction("Index", "Login");
            }
            return View();
        }


        //[HttpPost]
        //public IActionResult SifremiUnuttum(string userName)
        //{
        //    var data = _context.Users.Where(x => x.UserName == userName).FirstOrDefault();
        //    if (data != null)
        //    {
        //        //Baba adının ilk 2 harfi + anne adının son 2 harfi + (anneuzunluk + 10) + (babauzunluk + 10)
        //        string newPass = data.FatherName.Substring(0, 2) + data.MotherName.Substring(data.MotherName.Length - 2, 2) + (data.MotherName.Length + 10) + (data.FatherName.Length + 10);
        //        data.UserPassword = newPass;
        //        _context.Users.Update(data);
        //        _context.SaveChanges();
        //        return RedirectToAction("Index", "Login");
        //    }

        //    return View();
        //}




    }

}
