using Akses.App.Models;
using Akses.DataModel;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Akses.App.Controllers
{
    public class CustomerController : Controller
    {
        private readonly AppDbContext context;
        private readonly IMapper mapper;
        public CustomerController(AppDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public IActionResult Index()
        {
            List<CustomerVM> list = mapper.Map<List<CustomerVM>>(context.CustomersINV.ToList());
            return View(list);
        }

        public IActionResult Add()
        {
            return View(new CustomerVM());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(CustomerVM model)
        {
            if (ModelState.IsValid == true)
            {
                await context.AddAsync(mapper.Map<Customer>(model));
                await context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
 
        }

    }
}
