using System;

namespace Company.OnlineStore.Domain.ShoppingBasket
{
    public class ShoppingBasket
    {
        public Order.Order ConvertToOrder()
        {
            return new Order.Order
            {
                Id = Guid.NewGuid(),
                CustomerId = Guid.NewGuid(),
            };

        }
        public Guid Id { get; set; }
    }
}