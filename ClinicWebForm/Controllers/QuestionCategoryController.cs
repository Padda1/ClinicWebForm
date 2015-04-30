using ClinicWebForm.Context;
using ClinicWebForm.Models;
using ClinicWebForm.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ClinicWebForm.Controllers
{
    public class QuestionCategoryController : Controller
    {
        // GET: QuestionCategory
        public ActionResult Index()
        {
            return View();
        }

        // GET: QuestionCategory/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: QuestionCategory/Create
        public ActionResult Create()
        {
            int formId = (int)TempData["FormId"];

            var questionCatergory = new QuestionCategoryViewModel();
            questionCatergory.QuestionCategories = AppUtils.LoadQuestionCategories(formId);

            return View(questionCatergory);
        }

        // POST: QuestionCategory/Create
        [HttpPost]
        public async Task<ActionResult> Create(QuestionCategoryViewModel questionCategory)
        {
            int docId = (int)TempData["FormDocumentId"];

            try
            {
                using (var dbContext = new ApplicationDbContext())
                {
                    FormDocument document = dbContext.FormDocuments.Where(d => d.Id == docId).First();

                    foreach (var category in questionCategory.QuestionCategories)
                    {
                        foreach (var question in category.Questions)
                        {
                            Answer answer = new Answer();
                            answer.FormDocument = document;
                            answer.Question = question;
                            answer.AnswerValue = question.QuestionValue;

                            dbContext.Answers.Add(answer);
                            await dbContext.SaveChangesAsync();
                        }
                    }
                }

                return RedirectToAction("Index","Documents");
            }
            catch
            {
                return View();
            }
        }

        // GET: QuestionCategory/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: QuestionCategory/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: QuestionCategory/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: QuestionCategory/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
