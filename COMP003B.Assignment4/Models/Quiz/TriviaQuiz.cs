using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment4.Models.Quiz;

public class TriviaQuiz
{
    [Required]
    public string Question1 { get; set; }
    
    [Required]
    public string Question2 { get; set; }
    
    [Required]
    public string Question3 { get; set; }
    
    [Required]
    public string Question4 { get; set; }
    
    [Required]
    public string Question5 { get; set; }
}