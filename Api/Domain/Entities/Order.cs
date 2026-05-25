namespace Api.Domain.Entities;

public class Order
{
    public Order(Guid id, string userName)
    {
        Id = id;
        UserName = userName ?? throw new ArgumentNullException(nameof(userName));
    }

    public Guid Id { get; private set; }

    public string UserName { get; private set; }

    public ICollection<Payment> Payments { get; private set; } = [];
}