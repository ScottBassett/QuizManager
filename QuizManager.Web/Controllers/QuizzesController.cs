using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using QuizManager.DataAccess;
using QuizManager.DataAccess.Models;
using QuizManager.Web.ViewModels;

namespace QuizManager.Web.Controllers
{
    public class QuizzesController : Controller
    {
        private readonly QuizManagerDbContext _context;

        public QuizzesController(QuizManagerDbContext context)
        {
            _context = context;
        }

        // GET: Quizzes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Quizzes.ToListAsync());
        }

        // GET: Quizzes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quizDetailsViewModel = new QuizDetailsViewModel
            {
                Quiz = await _context.Quizzes.FirstOrDefaultAsync(m => m.Id == id),
                Questions = _context.Questions.Where(x => x.QuizId == id)
            };


            return View(quizDetailsViewModel);
        }

        // GET: Quizzes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Quizzes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,QuizName")] Quiz quiz)
        {
            if (ModelState.IsValid)
            {

                _context.Add(quiz);
                await _context.SaveChangesAsync();

                TempData["quizId"] = quiz.Id;
                return RedirectToAction("Create", "Questions");
            }
            return View(quiz);
        }

        // GET: Quizzes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quiz = await _context.Quizzes.FindAsync(id);
            if (quiz == null)
            {
                return NotFound();
            }
            return View(quiz);
        }

        // POST: Quizzes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,QuizName")] Quiz quiz)
        {
            if (id != quiz.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(quiz);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QuizExists(quiz.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(quiz);
        }

        // GET: Quizzes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quiz = await _context.Quizzes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (quiz == null)
            {
                return NotFound();
            }

            return View(quiz);
        }

        // POST: Quizzes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var quiz = await _context.Quizzes.FindAsync(id);
            _context.Quizzes.Remove(quiz);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool QuizExists(int id)
        {
            return _context.Quizzes.Any(e => e.Id == id);
        }
    }
}
