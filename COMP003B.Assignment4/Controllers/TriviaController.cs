using COMP003B.Assignment4.Models.Quiz;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor.Compilation;


namespace COMP003B.Assignment4.Controllers;

[Route("Trivia")]
public class TriviaController : Controller
{
   [HttpGet("Quiz")]
   public IActionResult TriviaQuiz()
   {
      return View();
   }

   [HttpPost("Quiz")]
   public IActionResult TriviaQuiz(TriviaQuiz quiz)
   {
      if (ModelState.IsValid)
      {
         return View("Result", quiz);
      }
      return View(quiz);
   }

   [HttpGet("Result")]
   public IActionResult Result()
   {
      return View();
   }
  

}