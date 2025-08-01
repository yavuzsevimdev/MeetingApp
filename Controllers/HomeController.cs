using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {
        //localhost
        //localhost/home
        //localhost/home/index
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;

            ViewData["Selamlama"] = saat > 12 ? "İyi Günler":"Günaydın";
            int UserCount = Repository.Users.Where(info => info.WillAttend == true).Count();
            //ViewData["UserName"] = "Yavuz";

            var meetingInfo = new MeetingInfo()
            {
                Id = 1,
                Location = "İstanbul, ABC Kongre Merkezi",
                Date = new DateTime(2004, 01, 20, 20, 0, 0),
                NumberOfPeople = UserCount
            };
            return View(meetingInfo);
        }
    }
}