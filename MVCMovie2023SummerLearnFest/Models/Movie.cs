using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCMovie2023SummerLearnFest.Models;

public class Movie
{
    public int Id { get; set; }
    [Required]
    [StringLength(50, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 8)]
    public string? Title { get; set; }
    [Display(Name = "Release Date")]
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }
    public string? Genre { get; set; }
    [Range(0, 59.99, ErrorMessage = "that's too much!!!")]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }
    public string? Rating { get; set; }
}
