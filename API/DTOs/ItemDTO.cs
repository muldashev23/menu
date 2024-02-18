namespace API.DTOs;

public class ItemDTO
{
    public int Id {get;set;}
    public required string Name {get;set;}
    public required string Category {get;set;}
    public int Price {get;set;}
    public required string Info {get;set;}
}
