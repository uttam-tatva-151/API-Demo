namespace Data.Entity;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Cars")]
public class Car
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required(ErrorMessage = "Car model name is required.")]
    [MaxLength(100)]
    public string Model { get; set; } = string.Empty;

    [Required(ErrorMessage = "Price is required.")]
    [Range(0, 1000000, ErrorMessage = "Price must be between 0 and 1,000,000.")]
    [Column(TypeName = "decimal(18,2)")]
    public decimal Price { get; set; }

    [Required(ErrorMessage = "Manufacture year is required.")]
    [Range(1900, 2100, ErrorMessage = "Year must be valid.")]
    public int ManufactureYear { get; set; }

    [Required]
    [Range(0, int.MaxValue, ErrorMessage = "Stock cannot be negative.")]
    public int Stock { get; set; }

    [DataType(DataType.DateTime)]
    [Column(TypeName = "timestamp without time zone")]
    public DateTime CreatedAt { get; set; } = DateTime.Now;

    // Foreign Key
    [Required]
    public int ManufacturerId { get; set; }

    // Navigation Property
    public Manufacturer Manufacturer { get; set; } = null!;
}
