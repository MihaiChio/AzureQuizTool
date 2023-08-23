using AzureWebLearningTool.Services;
using Microsoft.AspNetCore.Mvc;

namespace AzureWebLearningTool.Controllers
{
    public class ExamController : Controller
    {
        private readonly IExamService _examService;

        public ExamController(IExamService examService)
        {
            _examService = examService;
        }

        public ActionResult Index()
        {
            return View(_examService.GetExam());
        }
    }
}
