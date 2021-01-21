using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QuizManager.DataAccess;
using QuizManager.DataAccess.Models;
using QuizManager.Web.ViewModels;

namespace QuizManager.Web.Controllers
{
    public class AnswersController : Controller
    {
        private readonly QuizManagerDbContext _context;

        public AnswersController(QuizManagerDbContext context)
        {
            _context = context;
        }

        // GET: Answers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Answers.ToListAsync());
        }

        // GET: Answers/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var answer = await _context.Answers
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (answer == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(answer);
        //}

        // GET: Answers/Create
        public IActionResult Create()
        {
            ViewData["Question"] = new SelectList(_context.Questions, "Id", "QuestionName", TempData ["questionId"]);
            return View();
        }

        // POST: Answers/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create(CreateAnswersViewModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        foreach (var answer in model.Answers)
        //        {
        //            answer.QuestionId = model.QuestionId;
        //        }

        //        await _context.AddRangeAsync(model.Answers);
        //        await _context.SaveChangesAsync();

        //        return RedirectToAction("Index", "Quizzes");
        //    }
            
        //    return View(model);
        //}

        //// GET: Answers/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var answer = await _context.Answers.FindAsync(id);
        //    if (answer == null)
        //    {
        //        return NotFound();
        //    }

        //    ViewData["Question"] = new SelectList(_context.Questions, "Id", "QuestionName", TempData["questionId"]);
        //    return View(answer);
        //}

        //// POST: Answers/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, CreateAnswersViewModel model)
        //{
        //    if (id != answer.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(answer);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!AnswerExists(answer.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(model);
        //}

        // GET: Answers/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var answer = await _context.Answers
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (answer == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(answer);
        ////}

        //// POST: Answers/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var answer = await _context.Answers.FindAsync(id);
        //    _context.Answers.Remove(answer);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool AnswerExists(int id)
        //{
        //    return _context.Answers.Any(e => e.Id == id);
        //}
    }
}
