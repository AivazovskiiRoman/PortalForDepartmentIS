using System.Web.Mvc;
using BLL.Abstraction;
using BLL.DTO;

namespace PortalForDepartmentIS.Controllers
{
    public class HomeController : Controller
    {
        private IPostService _postService;

        public HomeController(IPostService postService)
        {
            _postService = postService;
        }

        public ActionResult Index()
        {
            _postService.AddPost(new PostDto
            {
                Title = "Новое объявление",
                Content = "Описание объявления"
            });

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}