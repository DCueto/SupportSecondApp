using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Razor.Language;

namespace SupportSecondApp.Models;

public class Project
{
    [Key]
    public int Id { get; set; }
    
    [StringLength(50), Required]
    public required string Name { get; set; }

    [StringLength(500), Required]
    public required string Description { get; set; }
    
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; } = null;

    public ICollection<SupportTask> SupportTasks { get; set; } = new List<SupportTask>();
}