using EasyLinks.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EasyLinks.Controllers
{
    public class LinksController : Controller
    {
        ApplicationDbContext _dbContext;

        public LinksController(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View(this._dbContext.Links);
        }

        [HttpPost]
        public IActionResult SetLink(Link link)
        {
            this._dbContext.Add(link);
            this._dbContext.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
