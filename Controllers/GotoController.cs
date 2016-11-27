using System;
using EasyLinks.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EasyLinks.Controllers
{
    public class GotoController : Controller
    {
        ApplicationDbContext _dbContext;

        public GotoController(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }


        // GET: /<controller>/
        public IActionResult Index(string target)
        {
            var link = this._dbContext.Links
                            .Where(x => x.ShortCut == target)
                            .SingleOrDefault();

            if (link != null)
            {
                return Redirect(link.Url);
            }
            else
            {
                return new NotFoundResult();
            }
        }
    }
}
