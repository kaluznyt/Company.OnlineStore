using System;

namespace Company.OnlineStore.Domain.Order
{
    public class Order
    {
        public Guid CustomerId { get; set; }
        public Guid Id { get; set; }
    }
}
