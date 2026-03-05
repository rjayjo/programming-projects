using Akses.DataModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Akses.App.Controllers
{
    [Authorize]
    public class ExpensesController : Controller
    {
        private readonly AppDbContext context;

        public ExpensesController(AppDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View(context.ExpensesTbl.ToList());
        }
        
        public IActionResult Add()
        {
            return View(new Expenses());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Expenses model)
        {
            context.Add(model);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int EntryID)
        {
            var expense = await context.ExpensesTbl.FindAsync(EntryID);
            context.Set<Expenses>().Remove(expense);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            var item = context.ExpensesTbl.Find(id);
            return View(item);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Edit(Expenses model)
        {

            context.Set<Expenses>().Update(model);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
