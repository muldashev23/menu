using System.ComponentModel.DataAnnotations;

namespace API.Entities;

public class Items
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public int Price { get; set; }
    public string Info { get; set; }
}
