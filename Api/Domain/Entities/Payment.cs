namespace Api.Domain.Entities
{
    public class Payment
    {
        public Payment(Guid id, string bankName, Guid orderId)
        {
            Id = id;
            BankName = bankName ?? throw new ArgumentNullException(nameof(bankName));
            OrderId = orderId;
        }

        public Guid Id { get; private set; }

        public string BankName { get; private set; } = string.Empty;

        public Guid OrderId { get; private set; }

        public Order Order { get; private set; } = null!;
    }
}
