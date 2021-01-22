using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QuizManager.DataAccess;
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

        // GET: Answers/Create
        public IActionResult Create()
        {
            ViewData["Question"] = new SelectList(_context.Questions, "Id", "QuestionName", TempData ["questionId"]);
            return View();
        }

       // POST: Answers/Create
       [HttpPost]
       [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateAnswersViewModel model)
        {
            if (ModelState.IsValid)
            {
                foreach (var answer in model.Answers)
                {
                    answer.QuestionId = model.QuestionId;
                }

                await _context.AddRangeAsync(model.Answers);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index", "Quizzes");
            }

            return View(model);
        }
    }
}
