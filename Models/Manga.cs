using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;

namespace my_tracker.Models;

public class Manga
{
    public int Id { get; set;}
    [Required]
    public string Title { get; set;} = string.Empty;
    [Required]
    public string Author { get; set;} = string.Empty;
    public string Status { get; set; } = string.Empty;
    public DateOnly? StartDate { get; set;}
    public DateOnly? EndDate { get; set;}
}