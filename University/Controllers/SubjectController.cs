using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using University.Models;

namespace University.Controllers
{
    public class SubjectController : Controller
    {
        Subject math = new Subject { SubjectId = 1, Name = "Mathematics" };

        // Criando novos Students
        Student student1 = new Student { StudentId = 1, Name = "Alice", Subject = math };
        Student student2 = new Student { StudentId = 2, Name = "Bob", Subject = math };

        // Adicionando os Students ao Subject
        math.Students.Add(student1);
        math.Students.Add(student2);
        // GET: SubjectController
        public ActionResult Index()
        {
            return View();
        }

        // GET: SubjectController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SubjectController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SubjectController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SubjectController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SubjectController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SubjectController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SubjectController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
