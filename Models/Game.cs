using System.ComponentModel.DataAnnotations;

namespace my_tracker.Models;

public class Game
{
    public int Id { get; set;}
    [Required]
    public string Title { get; set;} = string.Empty;
    [Required]
    public string Platform { get; set;} = string.Empty;
    public string Status { get; set; } = string.Empty;
    public DateOnly LaunchDate { get; set; }
}