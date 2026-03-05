using Bernardo___ENTPROG___OTIS1;
using Suppliers;
using Microsoft.AspNetCore.Mvc;
using Suppliers.App.Models;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;

namespace Suppliers.App.Controllers
{
    [Authorize]
    public class SupplierController : Controller
    {
        private readonly AppDbContext context;
        private readonly IMapper mapper;
        public SupplierController(AppDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        public IActionResult Index()

        {
            List<SupplierVM> list = mapper.Map<List<SupplierVM>>(context.SuppliersINV.ToList());
            return View(list);
        }

        public IActionResult Add()
        {
           
            return View(new SupplierVM());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Add(SupplierVM model)
        {
            if (ModelState.IsValid == true)
            {
                await context.AddAsync(mapper.Map<Supplier>(model));
                context.Accessed();
                await context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            else return View(model);
               
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Delete(int SupplierID)
        {
            var supplier = await context.SuppliersINV.FindAsync(SupplierID);
            context.Set<Supplier>().Remove(supplier);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int? id)
        {
                 if (id == null) return RedirectToAction("Index");
                SupplierVM supplier = mapper.Map<SupplierVM>(await context.SuppliersINV.FindAsync(id));
                return View(supplier);
                View(supplier);
           
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Edit(SupplierVM model)
        {
            
            context.Set<Supplier>().Update(mapper.Map<Supplier>(model));
            context.Accessed();
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }


    }
    
}
