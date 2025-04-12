using System.ComponentModel.DataAnnotations;
using COMP003B.Assignment4.Controllers;
using COMP003B.Assignment4.Models.Quiz;

namespace COMP003B.Assignment4.Models.Tickets;
public class ConcertTickets
{
   
    
        [Required] [MinLength(3)] public string FirstName { get; set; }

        [Required] [MinLength(3)] public string LastName { get; set; }

        [Required] [EmailAddress] public string Email { get; set; }
        
        [Required] [Range(1, 20)] public int TicketsCount { get; set; }
        
        public string? ConcertCode { get; set; }
        
        public TriviaQuiz TriQuiz { get; set; }

        
    
}