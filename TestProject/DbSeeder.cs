using Api.Aplication.Data;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace TestProject;

public static class DbSeeder
{
    public static async Task SeedAsync(AppDbContext context)
    {
        if (await context.Orders.AnyAsync())
            return;

        var account = new Order(new Guid("11111111-1111-1111-1111-111111111111"), "Test Order 1");

        context.Orders.Add(account);

        await context.SaveChangesAsync();
    }
}