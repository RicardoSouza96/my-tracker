using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;

namespace my_tracker.Models;

public class Game
{
    public int Id { get; set;}
    [Required]
    public string Title { get; set;} = string.Empty;
    [Required]
    public string Platform { get; set;} = string.Empty;
}