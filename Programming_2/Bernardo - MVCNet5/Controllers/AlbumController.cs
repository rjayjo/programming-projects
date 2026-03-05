using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Intepro.BusinessLogic;

namespace Bernardo___MVCNet5.Controllers
{
    public class AlbumController : Controller
    {
        private AlbumBLL bll = new AlbumBLL();

        public IActionResult List()
        {
            List<AlbumBLL> list = bll.GetAll();
            
            return View(list);
        }

        public IActionResult Add()
        {
            return View(new AlbumBLL());
        }
        [HttpPost]

        public IActionResult Add(AlbumBLL obj)
        {
            if (ModelState.IsValid)
            {
                obj.Add();
                return RedirectToAction("List");
            }
            else
            {
                return View(obj);
            }
        }

        public IActionResult Edit(int id)
        {
            AlbumBLL obj = bll.Get(id);
            if (obj.AlbumID == 0) return RedirectToAction("List");

            return View(obj);
        }
        [HttpPost]

        public IActionResult Edit(AlbumBLL obj)
        {
            if (ModelState.IsValid)
            {
                obj.Edit();
                return RedirectToAction("List");
            }
            else
            {
                return View(obj);
            }
        }
        [HttpPost]

        public IActionResult Delete(AlbumBLL obj)
        {
            obj.Delete();
            return RedirectToAction("List");
        }

    }

}
