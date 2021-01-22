using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Quizzes.OrderBy(q => q.Id).ToListAsync());
        }

        // GET: Quizzes/Details/5
        [AllowAnonymous]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quiz = await _context.Quizzes.FirstOrDefaultAsync(q => q.Id == id);
            var questions = _context.Questions
                .Where(x => x.QuizId == id)
                .Include(x => x.AllAnswers);

            var quizDetailsViewModel = new QuizDetailsViewModel
            {
                Quiz = quiz,
                Questions = questions,
            };

            TempData["quizId"] = quiz.Id;
            return View(quizDetailsViewModel);
        }

        // GET: Quizzes/Create
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Quizzes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
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
        [Authorize]
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
        [Authorize]
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
        [Authorize]
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
        [Authorize]
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

        //// GET: Quizzes/PlayQuiz/5
        //public async Task<IActionResult> PlayQuiz(int? id)
        //{
        //    if (id == null) return NotFound();

        //    var quiz = await _context.Quizzes.FirstOrDefaultAsync(q => q.Id == id);
        //    var questions = _context.Questions
        //        .Where(x => x.QuizId == id)
        //        .Include(x => x.AllAnswers);

        //    var playQuizViewModel = new PlayQuizViewModel
        //    {
        //        Quiz = quiz,
        //        Questions = questions,
        //        PlayerScore = playerScore
        //    };

        //    TempData["quizId"] = quiz.Id;
        //    return View(playQuizViewModel);
        //}

        //public void IncreaseScore()
        //{
        //    playerScore++;
        //}
    }
}
