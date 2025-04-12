using Microsoft.AspNetCore.Mvc;
using COMP003B.Assignment4.Models.Tickets;

namespace COMP003B.Assignment4.Controllers;


public class ConcertController : Controller
{
    
    [HttpGet("/concert/ticket/{ConcertCode?}")]
    public IActionResult ConcertTickets(string ConcertCode)
    {
        var model = new ConcertTickets
        {
            ConcertCode = ConcertCode
        };
        return View("SignUp", model);
    }

    [HttpGet("concert/signup")]
        public IActionResult SignUp()
        {
            return View(new ConcertTickets());
        }

        
    [HttpPost("concert/signup")]
    public IActionResult SignUp(ConcertTickets model)
    {
        if (!ModelState.IsValid)
        {
            return View("SignUp", model);
        }
        return RedirectToAction("Completion", "Concert", new
        {
            model.FirstName,
            model.LastName,
            model.Email,
            model.TicketsCount,
            model.ConcertCode
        });
    }

    [HttpGet("concert/completion)")]
    public IActionResult Completion(string FirstName, String LastName, string Email, int TicketsCount, string ConcertCode)
    {
        var model = new ConcertTickets
        {
            FirstName = FirstName,
            LastName = LastName,
            Email = Email,
            TicketsCount = TicketsCount,
            ConcertCode = ConcertCode
        };
        return View(model);
    }
}