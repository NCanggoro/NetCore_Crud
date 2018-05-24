using System.Linq;
using MahasiswaCrud.MahasiswaContext;
using MahasiswaCrud.Models;
using Microsoft.AspNetCore.Mvc;

namespace MahasiswaCrud.Controllers
{
    public class MahasiswaController : Controller
    {
        private readonly AppdataContext _context;
        public MahasiswaController(AppdataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var mhsw = _context.Mahasiswas.OrderByDescending(m => m.Id)
            .ToList();
            return View(mhsw);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Mahasiswa model)
        {
            if(!ModelState.IsValid) return View(model);
            _context.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var mhs = _context.Mahasiswas.SingleOrDefault(m => m.Id == id);
            return View(mhs);
        }
        [HttpPost]
        public IActionResult Edit(Mahasiswa model)
        {
            if(!ModelState.IsValid) return View(model);
            _context.Mahasiswas.Update(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var mhs = _context.Mahasiswas.FirstOrDefault(m => m.Id == id);
            _context.Mahasiswas.Remove(mhs);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}