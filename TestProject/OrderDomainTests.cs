using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace TestProject;

public class OrderDomainTests(PostgresTestFixture fixture) : IntegrationTest(fixture)
{
    [Fact]
    public async Task GetSeededAccount_Should_ReturnOk()
    {
        // Arrange
        Guid id = new("11111111-1111-1111-1111-111111111111");

        // Act
        var order = await _context.Orders.FirstOrDefaultAsync(x => x.Id == id);

        // Assert
        Assert.NotNull(order);
        Assert.Equal("Test Order 1", order.UserName);
    }

    [Fact]
    public async Task AddOrder_Should_Ok()
    {
        // Arrange
        var or = new Order(Guid.NewGuid(), "name1");

        // Act
        _context.Orders.Add(or);
        await _context.SaveChangesAsync();

        var order = await _context.Orders
            .FirstOrDefaultAsync(x => x.Id == or.Id);

        // Assert
        Assert.NotNull(order);
        Assert.Equal(or.Id, order.Id);
        Assert.Equal("name1", order.UserName);
    }
}