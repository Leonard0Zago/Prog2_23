using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PSIUWeb.Data.EF;
using PSIUWeb.Data.Interface;
using PSIUWeb.Models;

namespace PSIUWeb.Controllers
{
    public class ContentCategoryController : Controller
    {
        public IContentCategoryRepository contentcategoryRepository;
        public ContentCategoryController(IContentCategoryRepository repo)
        {
            contentcategoryRepository = repo;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(contentcategoryRepository.GetContentCategories());
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id <= 0 || id == null)
                return NotFound();

            ContentCategory? cc = contentcategoryRepository.GetContentCategoryById(id.Value);

            if (cc == null)
                return NotFound();

            return View(cc);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ContentCategory contentcategory)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    contentcategoryRepository.Update(contentcategory);
                    return View("Index", contentcategoryRepository.GetContentCategories());
                }
                catch (DbUpdateConcurrencyException)
                {
                    throw;
                }
            }
            return View("Index");
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
                return NotFound();

            ContentCategory? cc = contentcategoryRepository.GetContentCategoryById(id.Value);
            if (cc == null)
                return NotFound();

            return View(cc);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            if (id == null || id == 0)
                return NotFound();

            contentcategoryRepository.Delete(id);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Insert(ContentCategory cc)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    contentcategoryRepository.Create(cc);
                    return View("Index", contentcategoryRepository.GetContentCategories());
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return View();
        }
    }
}
