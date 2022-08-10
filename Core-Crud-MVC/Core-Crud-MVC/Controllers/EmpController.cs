using Microsoft.AspNetCore.Mvc;
using Core_Crud_MVC.Models;
using Microsoft.EntityFrameworkCore;


namespace Core_Crud_MVC.Controllers
{
    public class EmpController : Controller
    {
        private readonly ApplicationDbContext _db;

        public EmpController(ApplicationDbContext db)
        {
            _db = db;

        }
        public IActionResult Index()
        {
            var displaydata=_db.EmployeeTable.ToList();
            return View(displaydata);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(NewEmpClass nec)
        {
            if(ModelState.IsValid)
            {
                _db.Add(nec); 
                await _db.SaveChangesAsync();   
                return RedirectToAction("Index");
            }
            return View(nec);
        }
        //[HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if(id == null)
            {
                return RedirectToAction("Index");

            }

            var getempdetails = await _db.EmployeeTable.FindAsync(id);
            return View(getempdetails);
        }

        [HttpPost]

        public async Task<IActionResult> Edit(NewEmpClass nc)
        {
            if (ModelState.IsValid)
            {
                _db.Update(nc);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(nc);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");

            }

            var getempdetails = await _db.EmployeeTable.FindAsync(id);
            return View(getempdetails);
        }

        //[HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");

            }

            var getempdetails = await _db.EmployeeTable.FindAsync(id);
            return View(getempdetails);
        }

        [HttpPost]

        public async Task<IActionResult> Delete(int id)
        {
  
            var getempdetails = await _db.EmployeeTable.FindAsync(id);
            _db.EmployeeTable.Remove(getempdetails);
            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }

    }
}
