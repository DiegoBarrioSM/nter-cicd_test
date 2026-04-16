using Api.Aplication.Data;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Aplication.Service;

public class OrderService
{
    private readonly AppDbContext _dbContext;

    public OrderService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Order> GetById(Guid id)
    {
        return await _dbContext.Orders.FirstAsync(x => x.Id == id);
    }
}