using System.Text.Json;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class Seed
{
    public static async Task SeedMenu(DataContext context)
    {
        if (await context.Menu.AnyAsync())
            return;
        var menuData = await File.ReadAllTextAsync("Data/MenuSeedData.json");
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        var menu = JsonSerializer.Deserialize<List<Items>>(menuData);
        foreach (var item in menu)
        {
            context.Menu.Add(item);
        }
        await context.SaveChangesAsync();
    }
}
