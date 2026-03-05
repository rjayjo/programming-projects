using Akses.DataModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Dynamic;

namespace Akses.App.Controllers
{
    [Authorize]
    public class SalesController : Controller
    {
        private readonly AppDbContext context;
        
        public SalesController(AppDbContext context)
        {
            this.context = context;
            
        }

        public IActionResult Index()
        {        
            return View(context.SalesTbl.ToList());
        }
    }
}
