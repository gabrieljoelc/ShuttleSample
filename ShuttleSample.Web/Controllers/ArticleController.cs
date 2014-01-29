using System.Web.Mvc;
using ShuttleSample.Messages;
using ShuttleSample.Web.App_Start;

namespace ShuttleSample.Web.Controllers
{
    public class ArticleController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult SendArticleToEditor(string article)
        {
            ViewBag.Message = typeof (SubmitArticleToEditor).Name;
            if (!ModelState.IsValid || string.IsNullOrEmpty("article"))
            {
                ViewBag.Message += " not sent!";
            }
            else
            {
                Bus.Instance.Send(new SubmitArticleToEditor { Article = article });
                ViewBag.Message += " sent!";
            }
            return RedirectToAction("Index");
        }
    }
}
