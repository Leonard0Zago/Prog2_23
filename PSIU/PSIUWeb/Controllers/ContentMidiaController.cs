using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PSIUWeb.Data.EF;
using PSIUWeb.Data.Interface;
using PSIUWeb.Models;

namespace PSIUWeb.Controllers
{
    public class ContentMidiaController : Controller
    {
        public IContentMidiaRepository contentmidiaRepository;
        public ContentMidiaController(IContentMidiaRepository repo)
        {
            contentmidiaRepository = repo;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(contentmidiaRepository.GetContentMidias());
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id <= 0 || id == null)
                return NotFound();

            ContentMidia? cm = contentmidiaRepository.GetContentMidiaById(id.Value);

            if (cm == null)
                return NotFound();

            return View(cm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ContentMidia contentmidia)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    contentmidiaRepository.Update(contentmidia);
                    return View("Index", contentmidiaRepository.GetContentMidias());
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

            ContentMidia? cm = contentmidiaRepository.GetContentMidiaById(id.Value);
            if (cm == null)
                return NotFound();

            return View(cm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            if (id == null || id == 0)
                return NotFound();

            contentmidiaRepository.Delete(id);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Insert(ContentMidia cm)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    contentmidiaRepository.Create(cm);
                    return View("Index", contentmidiaRepository.GetContentMidias());
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
