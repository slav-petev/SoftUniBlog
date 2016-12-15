using System.Web.Mvc;

namespace SoftUniBlog.Controllers
{
    public class ContactsController : Controller
    {
        // GET: Contacts
        public ActionResult Index()
        {
            return View();
        }
    }
}