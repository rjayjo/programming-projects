using Akses.App.Models;
using Akses.DataModel;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Akses.App.Controllers
{
    public class CustomerDataController : Controller
    {
        private readonly AppDbContext context;
        private readonly IMapper mapper;
        public CustomerDataController(AppDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public IActionResult Index()
        {
            List<CustomerVM> list = mapper.Map<List<CustomerVM>>(context.CustomersINV.ToList());
            return View(list);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int CustomerID)
        {
            var custom = await context.CustomersINV.FindAsync(CustomerID);
            context.Set<Customer>().Remove(custom);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            CustomerVM customer = mapper.Map<CustomerVM>(await context.CustomersINV.FindAsync(id));
            return View(customer);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Edit(CustomerVM model)
        {
            if (ModelState.IsValid)
            {
                context.Set<Customer>().Update(mapper.Map<Customer>(model));
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
          
        }
    }

}
