using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.Language;
using Microsoft.EntityFrameworkCore;
using QuizManager.DataAccess;
using QuizManager.DataAccess.Models;
using QuizManager.Web.ViewModels;

namespace QuizManager.Web.Controllers
{
    public class QuestionsController : Controller
    {
        private readonly QuizManagerDbContext _context;

        public QuestionsController(QuizManagerDbContext context)
        {
            _context = context;
        }

        // GET: Questions
        public async Task<IActionResult> Index()
        {
            var questions = await _context.Questions.OrderBy(x => x.QuizId).ToListAsync();
            var quizzes = await _context.Quizzes.ToListAsync();

            var model = new QuestionIndexViewModel
            {
                Questions = questions,
                Quizzes = quizzes
            };

            return View(model);
        }

        // GET: Questions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var question = await _context.Questions.FirstOrDefaultAsync(m => m.Id == id);
            var answers =  _context.Answers.Where(x => x.QuestionId == question.Id);

            var questionDetailsViewModel = new QuestionDetailsViewModel
            {
                Question = question,
                Answers = answers
            };

            return View(questionDetailsViewModel);
        }

        // GET: Questions/Create
        public IActionResult Create()
        {
            ViewData["Quiz"] = new SelectList(_context.Quizzes, "Id", "QuizName", TempData["quizId"]);
            return View();
        }

        // POST: Questions/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,QuizId,QuestionName,CorrectAnswerId")] Question question)
        {
            if (ModelState.IsValid)
            {
                _context.Add(question);
                await _context.SaveChangesAsync();

                TempData["questionId"] = question.Id;

                return RedirectToAction("Create", "Answers");
            }
            
            return View(question);
        }

        // GET: Questions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var question = await _context.Questions.FindAsync(id);
            if (question == null)
            {
                return NotFound();
            }

            var answers = await _context.Answers
                .Where(x => x.QuestionId == question.Id)
                .ToListAsync();

            if (!answers.Any())
            {
                return NotFound();
            }

            var quiz = await _context.Quizzes.FirstOrDefaultAsync(x => x.Id == question.QuizId);

            ViewData["QuizName"] = quiz.QuizName;
            return View( new EditQuestionViewModel
            {
                Question = question,
                Answers = answers
            });
        }

        // POST: Questions/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(EditQuestionViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(model.Question);
                    _context.UpdateRange(model.Answers);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QuestionExists(model.Question.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                TempData["questionId"] = model.Question.Id;
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        // GET: Questions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var question = await _context.Questions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (question == null)
            {
                return NotFound();
            }

            return View(question);
        }

        // POST: Questions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var question = await _context.Questions.FindAsync(id);
            _context.Questions.Remove(question);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool QuestionExists(int id)
        {
            return _context.Questions.Any(e => e.Id == id);
        }
    }
}
