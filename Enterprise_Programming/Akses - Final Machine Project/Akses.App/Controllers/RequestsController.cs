using Akses.DataModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Akses.App.Controllers
{
    [Authorize]
    public class RequestsController : Controller
    {
        private readonly AppDbContext context;

        public RequestsController(AppDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View(context.MedicineRequestTbl.ToList());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Supplied(int RequestID)
        {
            var request = await context.MedicineRequestTbl.FindAsync(RequestID);
            context.Set<MedicineRequest>().Remove(request);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }


    }
}
